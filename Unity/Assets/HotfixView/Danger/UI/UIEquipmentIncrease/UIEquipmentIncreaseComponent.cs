using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    /// <summary>
    /// 装备增幅
    /// </summary>
    public class UIEquipmentIncreaseComponent: Entity, IAwake, IDestroy
    {
        public GameObject IncreaseEffect;
        public GameObject Obj_EquipPropertyText;
        public GameObject EquipBaseSetList;
        public GameObject UIIncreaseItemNode;
        public GameObject IncreaseButton;
        public GameObject ReelListNode;
        public GameObject EquipListNode;
        public GameObject FunctionBtnSet;
        public GameObject ImageButton;

        public BagComponent BagComponent;

        /// <summary>
        /// 待增幅装备
        /// </summary>
        public UIItemComponent IncreaseItemUI;

        /// <summary>
        /// 卷轴列表
        /// </summary>
        public List<UIItemComponent> ReelUIList = new List<UIItemComponent>();

        /// <summary>
        /// 装备列表
        /// </summary>
        public List<UIItemComponent> EquipUIList = new List<UIItemComponent>();

        /// <summary>
        /// 待增幅的装备BagInfo
        /// </summary>
        public BagInfo EquipmentBagInfo;

        /// <summary>
        /// 此次增幅所用的卷轴BagInfo
        /// </summary>
        public BagInfo ReelBagInfo;

        public ETCancellationToken ETCancellationToken;
    }

    public class UIEquipmentIncreaseComponentAwakeSystem: AwakeSystem<UIEquipmentIncreaseComponent>
    {
        public override void Awake(UIEquipmentIncreaseComponent self)
        {
            self.Awake();
        }
    }

    public class UIEquipmentIncreaseComponentDestroyStstem: DestroySystem<UIEquipmentIncreaseComponent>
    {
        public override void Destroy(UIEquipmentIncreaseComponent self)
        {
            self.Destroy();
        }
    }

    public static class UIEquipmentIncreaseComponentSystem
    {
        public static void Awake(this UIEquipmentIncreaseComponent self)
        {
            self.EquipUIList.Clear();
            self.EquipmentBagInfo = null;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.IncreaseButton = rc.Get<GameObject>("IncreaseButton");
            ButtonHelp.AddListenerEx(self.IncreaseButton, () => { self.OnIncreaseButton().Coroutine(); });

            self.IncreaseEffect = rc.Get<GameObject>("IncreaseEffect");
            self.ReelListNode = rc.Get<GameObject>("ReelListNode");
            self.EquipListNode = rc.Get<GameObject>("EquipListNode");
            self.UIIncreaseItemNode = rc.Get<GameObject>("UIIncreaseItemNode");
            self.Obj_EquipPropertyText = rc.Get<GameObject>("Obj_EquipPropertyText");
            self.EquipBaseSetList = rc.Get<GameObject>("EquipBaseSetList");

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);
            
            self.OnUpdateUI();
            self.IncreaseItemUI = null;
            self.InitSubItemUI().Coroutine();
        }

        //显示的时候刷新
        public static void OnUpdateUI(this UIEquipmentIncreaseComponent self)
        {
            self.EquipmentBagInfo = null;
            self.OnEquiListUpdate().Coroutine();
            self.OnReelListUpdate().Coroutine();
        }

        /// <summary>
        /// 更新待增幅装备的属性信息
        /// </summary>
        /// <param name="self"></param>
        /// <param name="bagInfo"></param>
        public static void UpdateAttribute(this UIEquipmentIncreaseComponent self, BagInfo bagInfo)
        {
            UICommonHelper.DestoryChild(self.EquipBaseSetList);
            if (bagInfo == null)
            {
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            ItemViewHelp.ShowBaseAttribute(bagComponent.GetEquipList(), bagInfo, self.Obj_EquipPropertyText, self.EquipBaseSetList);
        }

        /// <summary>
        /// 更新待增幅装备的信息
        /// </summary>
        /// <param name="self"></param>
        public static void OnUpdateIncrease(this UIEquipmentIncreaseComponent self)
        {
            BagInfo bagInfo = self.EquipmentBagInfo;
            self.UpdateAttribute(bagInfo);
            if (bagInfo == null)
            {
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            if (self.IncreaseItemUI != null)
            {
                self.IncreaseItemUI.UpdateItem(bagInfo, ItemOperateEnum.None);
            }
        }

        /// <summary>
        /// 可增幅装备列表刷新
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask OnEquiListUpdate(this UIEquipmentIncreaseComponent self)
        {
            int number = 0;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            List<BagInfo> equipInfos = self.BagComponent.GetItemsByType(ItemTypeEnum.Equipment);

            for (int i = 0; i < equipInfos.Count; i++)
            {
                if (equipInfos[i].IfJianDing)
                {
                    continue;
                }

                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equipInfos[i].ItemID);
                if (itemConfig.EquipType == 101)
                {
                    continue;
                }

                UIItemComponent uI = null;
                if (number < self.EquipUIList.Count)
                {
                    uI = self.EquipUIList[number];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.EquipListNode);
                    uI = self.AddChild<UIItemComponent, GameObject>(go);
                    uI.SetClickHandler((BagInfo bagInfo) => { self.OnSelectEquip(bagInfo); });
                    self.EquipUIList.Add(uI);
                }

                number++;
                uI.UpdateItem(equipInfos[i], ItemOperateEnum.ItemXiLian);
            }

            for (int i = number; i < self.EquipUIList.Count; i++)
            {
                self.EquipUIList[i].GameObject.SetActive(false);
            }

            // 默认选择第一个装备
            if (self.EquipmentBagInfo != null)
            {
                self.OnSelectEquip(self.EquipmentBagInfo);
            }
            else if (number > 0)
            {
                self.EquipUIList[0].OnClickUIItem();
            }
        }

        /// <summary>
        /// 增幅卷轴列表刷新
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask OnReelListUpdate(this UIEquipmentIncreaseComponent self)
        {
            int number = 0;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            foreach (BagInfo bagInfo in self.BagComponent.GetBagList())
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                if (itemConfig.ItemType == ItemTypeEnum.Consume && itemConfig.ItemSubType == 17)
                {
                    UIItemComponent uI = null;
                    if (number < self.ReelUIList.Count)
                    {
                        uI = self.ReelUIList[number];
                        uI.GameObject.SetActive(true);
                    }
                    else
                    {
                        GameObject go = GameObject.Instantiate(bundleGameObject);
                        uI = self.AddChild<UIItemComponent, GameObject>(go);
                        uI.SetClickHandler((BagInfo bagInfo) => { self.OnSelectReel(bagInfo); });
                        uI.HideItemName();
                        UICommonHelper.SetParent(go, self.ReelListNode);
                        self.ReelUIList.Add(uI);
                    }

                    number++;
                    uI.UpdateItem(bagInfo, ItemOperateEnum.None);
                }
            }

            for (int i = number; i < self.ReelUIList.Count; i++)
            {
                self.ReelUIList[i].GameObject.SetActive(false);
            }
        }

        /// <summary>
        /// 选择增强卷轴
        /// </summary>
        /// <param name="self"></param>
        /// <param name="bagInfo"></param>
        public static void OnSelectReel(this UIEquipmentIncreaseComponent self, BagInfo bagInfo)
        {
            self.ReelBagInfo = bagInfo;
            for (int i = 0; i < self.ReelUIList.Count; i++)
            {
                self.ReelUIList[i].SetSelected(bagInfo);
            }
        }

        /// <summary>
        /// 选择增强装备
        /// </summary>
        /// <param name="self"></param>
        /// <param name="bagInfo"></param>
        public static void OnSelectEquip(this UIEquipmentIncreaseComponent self, BagInfo bagInfo)
        {
            self.EquipmentBagInfo = bagInfo;
            for (int i = 0; i < self.EquipUIList.Count; i++)
            {
                self.EquipUIList[i].SetSelected(bagInfo);
            }

            self.OnUpdateIncrease();
        }

        /// <summary>
        /// 初始化待增强装备面板信息
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask InitSubItemUI(this UIEquipmentIncreaseComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            GameObject go = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(go, self.UIIncreaseItemNode);
            self.IncreaseItemUI = self.AddChild<UIItemComponent, GameObject>(go);
            self.IncreaseItemUI.Label_ItemName.SetActive(true);

            BagInfo bagInfo = self.EquipmentBagInfo;
            if (bagInfo != null)
            {
                self.IncreaseItemUI.UpdateItem(bagInfo, ItemOperateEnum.None);
            }
        }

        /// <summary>
        /// 增幅
        /// </summary>
        /// <param name="self"></param>
        /// <param name="times"></param>
        public static async ETTask OnIncreaseButton(this UIEquipmentIncreaseComponent self)
        {
            if (self.EquipmentBagInfo == null)
            {
                return;
            }

            if (self.ReelBagInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip("未选择增幅卷轴");
                return;
            }

            string reelAss = "";
            if (self.ReelBagInfo.IncreaseProLists != null && self.ReelBagInfo.IncreaseProLists.Count > 0)
            {
                reelAss = ItemViewHelp.GetFumpProDesc(self.ReelBagInfo.IncreaseProLists);
            }
            else if(self.ReelBagInfo.IncreaseSkillLists != null && self.ReelBagInfo.IncreaseSkillLists.Count > 0)
            {
                // 先显示一个吧
                reelAss = SkillConfigCategory.Instance.Get(self.ReelBagInfo.IncreaseSkillLists[0]).SkillName;
            }
            
            // 当前装备已经存在增幅属性
            if (self.EquipmentBagInfo.IncreaseProLists.Count > 0)
            {
                string equipmentPro = ItemViewHelp.GetFumpProDesc(self.EquipmentBagInfo.IncreaseProLists);

                string tip = $"当前增幅<color=#BEFF34>{reelAss}</color> \n是否覆盖已有属性\n{equipmentPro}\n此附魔道具已消耗";
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "装备增幅", tip, async () =>
                {
                    await self.ZoneScene().GetComponent<BagComponent>().SendEquipmentIncrease(self.EquipmentBagInfo, self.ReelBagInfo);
                    FloatTipManager.Instance.ShowFloatTip($"增幅 {reelAss}");
                }, () => { }).Coroutine();
            }
            // 存在增幅技能
            else if (self.EquipmentBagInfo.IncreaseSkillLists.Count > 0)
            {
                string equipmentSkillName = SkillConfigCategory.Instance.Get(self.EquipmentBagInfo.IncreaseSkillLists[0]).SkillName;

                string tip = $"当前增幅<color=#BEFF34>{reelAss}</color> \n是否覆盖已有技能\n{equipmentSkillName}\n此附魔道具已消耗";
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "装备增幅", tip, async () =>
                {
                    await self.ZoneScene().GetComponent<BagComponent>().SendEquipmentIncrease(self.EquipmentBagInfo, self.ReelBagInfo);
                    FloatTipManager.Instance.ShowFloatTip($"增幅 {reelAss}");
                }, () => { }).Coroutine();
            }
            else
            {
                await self.ZoneScene().GetComponent<BagComponent>().SendEquipmentIncrease(self.EquipmentBagInfo, self.ReelBagInfo);
                FloatTipManager.Instance.ShowFloatTip($"增幅 {reelAss}");
            }
        }

        public static void Destroy(this UIEquipmentIncreaseComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
        }
    }
}