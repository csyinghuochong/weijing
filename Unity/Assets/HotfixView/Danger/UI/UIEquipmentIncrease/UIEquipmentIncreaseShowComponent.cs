using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UIEquipmentIncreaseShowComponent: Entity, IAwake, IDestroy
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

    public class UIEquipmentIncreaseShowComponentAwakeSystem: AwakeSystem<UIEquipmentIncreaseShowComponent>
    {
        public override void Awake(UIEquipmentIncreaseShowComponent self)
        {
            self.Awake();
        }
    }

    public class UIEquipmentIncreaseShowComponentDestroySystem: DestroySystem<UIEquipmentIncreaseShowComponent>
    {
        public override void Destroy(UIEquipmentIncreaseShowComponent self)
        {
            self.Destroy();
        }
    }

    public static class UIEquipmentIncreaseShowComponentSystem
    {
        public static void Awake(this UIEquipmentIncreaseShowComponent self)
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
        public static void OnUpdateUI(this UIEquipmentIncreaseShowComponent self)
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
        public static void UpdateAttribute(this UIEquipmentIncreaseShowComponent self, BagInfo bagInfo)
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
        public static void OnUpdateIncrease(this UIEquipmentIncreaseShowComponent self)
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
        public static async ETTask OnEquiListUpdate(this UIEquipmentIncreaseShowComponent self)
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
        public static async ETTask OnReelListUpdate(this UIEquipmentIncreaseShowComponent self)
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
        public static void OnSelectReel(this UIEquipmentIncreaseShowComponent self, BagInfo bagInfo)
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
        public static void OnSelectEquip(this UIEquipmentIncreaseShowComponent self, BagInfo bagInfo)
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
        public static async ETTask InitSubItemUI(this UIEquipmentIncreaseShowComponent self)
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
        public static async ETTask OnIncreaseButton(this UIEquipmentIncreaseShowComponent self)
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

            // 获取卷轴的传承和非传承的技能与属性
            string reelCanTransfAttribute = "传承增幅:";
            string reelNoTransfAttribute = "增幅:";
            for (int i = 0; i < self.ReelBagInfo.IncreaseProLists.Count; i++)
            {
                HideProList hide = self.ReelBagInfo.IncreaseProLists[i];
                HideProListConfig hideProListConfig = HideProListConfigCategory.Instance.Get(hide.HideID);
                string proName = ItemViewHelp.GetAttributeName(hideProListConfig.PropertyType);
                int showType = NumericHelp.GetNumericValueType(hideProListConfig.PropertyType);

                string str = "";
                if (showType == 2)
                {
                    float value = (float)hide.HideValue / 100f;
                    str = proName + " " + value.ToString("0.##") + "%" + " ";
                }
                else
                {
                    str = proName + " " + hide.HideValue + " ";
                }

                if (hideProListConfig.IfMove == 1)
                {
                    reelCanTransfAttribute += str;
                }
                else
                {
                    reelNoTransfAttribute += str;
                }
            }

            for (int i = 0; i < self.ReelBagInfo.IncreaseSkillLists.Count; i++)
            {
                int hide = self.ReelBagInfo.IncreaseSkillLists[i];
                HideProListConfig hideProListConfig = HideProListConfigCategory.Instance.Get(hide);
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(hideProListConfig.PropertyType);
                string skillName = skillConfig.SkillName;

                if (hideProListConfig.IfMove == 1)
                {
                    reelCanTransfAttribute += skillName + " ";
                }
                else
                {
                    reelNoTransfAttribute += skillName + " ";
                }
            }

            // 获取装备的传承和非传承的技能与属性
            string equipmentCanTransfAttribute = "传承增幅:";
            string equipmentNoTransfAttribute = "增幅:";
            for (int i = 0; i < self.EquipmentBagInfo.IncreaseProLists.Count; i++)
            {
                HideProList hide = self.EquipmentBagInfo.IncreaseProLists[i];
                HideProListConfig hideProListConfig = HideProListConfigCategory.Instance.Get(hide.HideID);
                string proName = ItemViewHelp.GetAttributeName(hideProListConfig.PropertyType);
                int showType = NumericHelp.GetNumericValueType(hideProListConfig.PropertyType);

                string str = "";
                if (showType == 2)
                {
                    float value = (float)hide.HideValue / 100f;
                    str = proName + " " + value.ToString("0.##") + "%" + " ";
                }
                else
                {
                    str = proName + " " + hide.HideValue + " ";
                }

                if (hideProListConfig.IfMove == 1)
                {
                    equipmentCanTransfAttribute += str;
                }
                else
                {
                    equipmentNoTransfAttribute += str;
                }
            }

            for (int i = 0; i < self.EquipmentBagInfo.IncreaseSkillLists.Count; i++)
            {
                int hide = self.EquipmentBagInfo.IncreaseSkillLists[i];
                HideProListConfig hideProListConfig = HideProListConfigCategory.Instance.Get(hide);
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(hideProListConfig.PropertyType);
                string skillName = skillConfig.SkillName;

                if (hideProListConfig.IfMove == 1)
                {
                    equipmentCanTransfAttribute += skillName + " ";
                }
                else
                {
                    equipmentNoTransfAttribute += skillName + " ";
                }
            }

            // 当前装备已经存在传承增幅
            string tipStr = "";
            bool isTip = false;
            if (reelCanTransfAttribute != "传承增幅:" && equipmentCanTransfAttribute != "传承增幅:")
            {
                tipStr += $"当前<color=#BEFF34>{reelCanTransfAttribute}</color> \n是否覆盖已有\n{equipmentCanTransfAttribute}\n";
                isTip = true;
            }

            // 当前装备已经存在非传承增幅
            if (reelNoTransfAttribute != "增幅:" && equipmentNoTransfAttribute != "增幅:")
            {
                tipStr += $"当前<color=#BEFF34>{reelNoTransfAttribute}</color> \n是否覆盖已有\n{equipmentNoTransfAttribute}\n";
                isTip = true;
            }

            // 是否弹出提示框
            if (isTip)
            {
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "装备增幅", tipStr, async () =>
                {
                    await self.ZoneScene().GetComponent<BagComponent>().SendEquipmentIncrease(self.EquipmentBagInfo, self.ReelBagInfo);
                    FloatTipManager.Instance.ShowFloatTip("增幅成功");
                }, () => { }).Coroutine();
            }
            else
            {
                await self.ZoneScene().GetComponent<BagComponent>().SendEquipmentIncrease(self.EquipmentBagInfo, self.ReelBagInfo);
                FloatTipManager.Instance.ShowFloatTip("增幅成功");
            }
        }

        public static void Destroy(this UIEquipmentIncreaseShowComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
        }
    }
}