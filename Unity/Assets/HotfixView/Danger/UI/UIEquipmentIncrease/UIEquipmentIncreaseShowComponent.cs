using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIEquipmentIncreaseShowComponent: Entity, IAwake, IDestroy
    {
        public GameObject ScrollViewEquip;
        public GameObject EquipSet;
        public GameObject IncreaseEffect;
        public GameObject Obj_EquipPropertyText;
        public GameObject EquipBaseSetList;
        public GameObject UIIncreaseItemNode;
        public GameObject IncreaseButton;
        public GameObject ReelListNode;
        public GameObject EquipListNode;
        public GameObject FunctionBtnSet;
        public GameObject ImageButton;

        public UIEquipSetComponent UIEquipSetComponent;
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
        public UIPageButtonComponent UIPageComponent;
        public int Page;

        public ETCancellationToken ETCancellationToken;
        
        public List<Vector2> UIOldPositionList = new List<Vector2>();
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

            self.ScrollViewEquip = rc.Get<GameObject>("ScrollViewEquip");
            self.EquipSet = rc.Get<GameObject>("EquipSet");
            self.IncreaseEffect = rc.Get<GameObject>("IncreaseEffect");
            self.ReelListNode = rc.Get<GameObject>("ReelListNode");
            self.EquipListNode = rc.Get<GameObject>("EquipListNode");
            self.UIIncreaseItemNode = rc.Get<GameObject>("UIIncreaseItemNode");
            self.Obj_EquipPropertyText = rc.Get<GameObject>("Obj_EquipPropertyText");
            self.EquipBaseSetList = rc.Get<GameObject>("EquipBaseSetList");

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            BagInfo bagInfo = self.BagComponent.GetEquipBySubType(ItemLocType.ItemLocEquip, (int)ItemSubTypeEnum.Wuqi);
            self.UIEquipSetComponent = self.AddChild<UIEquipSetComponent, GameObject, int>(self.EquipSet, 0);
            self.UIEquipSetComponent.PlayerLv(userInfo.Lv);
            self.UIEquipSetComponent.PlayerName(userInfo.Name);
            self.UIEquipSetComponent.ShowPlayerModel(bagInfo, userInfo.Occ, unit.GetComponent<NumericComponent>().GetAsInt(NumericType.EquipIndex), self.BagComponent.FashionEquipList);

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);
            
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>( "BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent  = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler( (int page)=>{
                self.OnClickPageButton(page);
            } );
            self.UIPageComponent = uIPageViewComponent;

            self.StoreUIdData();
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
            
            self.OnUpdateUI();
            self.IncreaseItemUI = null;
            self.InitSubItemUI().Coroutine();
        }

        public static void StoreUIdData(this UIEquipmentIncreaseShowComponent self)
        {
            Transform tt = self.UIPageComponent.GetParent<UI>().GameObject.transform;

            int childCount = tt.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Transform transform = tt.transform.GetChild(i);

                Transform XuanZhong = transform.Find("XuanZhong");
                if (XuanZhong)
                {
                    Text text = XuanZhong.GetComponentInChildren<Text>();
                    RectTransform rt = text.GetComponent<RectTransform>();

                    self.UIOldPositionList.Add(rt.localPosition);
                }
            }
        }
        
        public static void OnLanguageUpdate(this UIEquipmentIncreaseShowComponent self)
        {
            self.EquipListNode.GetComponent<GridLayoutGroup>().spacing = GameSettingLanguge.Language == 0 ? new Vector2(24, 10) : new Vector2(30, 20);
            
            Transform tt = self.UIPageComponent.GetParent<UI>().GameObject.transform;

            int childCount = tt.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Transform transform = tt.transform.GetChild(i);

                Transform XuanZhong = transform.Find("XuanZhong");
                if (XuanZhong)
                {
                    Transform icon = XuanZhong.Find("XuanZhong (1)");
                    if (icon)
                    {
                        icon.gameObject.SetActive(GameSettingLanguge.Language == 0);
                    }
                    
                    Text text = XuanZhong.GetComponentInChildren<Text>();
                    RectTransform rt = text.GetComponent<RectTransform>();
                    if (text)
                    {
                        // 调整文字大小
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                        
                        // 调整文字宽度
                        Vector2 size = rt.sizeDelta;
                        size.x = GameSettingLanguge.Language == 0? 160f : 200f;
                        rt.sizeDelta = size;
                        
                        // 调整文字位置
                        Vector2 position = Vector2.zero;
                        position = self.UIOldPositionList[i];
                        if (GameSettingLanguge.Language == 1)
                        {
                            position.x = 0f;
                        }
                        rt.localPosition = position;
                        
                        // 调整文字对齐方式
                        text.alignment = GameSettingLanguge.Language == 0? TextAnchor.UpperLeft : TextAnchor.UpperCenter;
                    }
                }

                Transform WeiXuanZhong = transform.Find("WeiXuanZhong");
                if (WeiXuanZhong)
                {
                    Text text = WeiXuanZhong.GetComponentInChildren<Text>();
                    RectTransform rt = text.GetComponent<RectTransform>();
                    if (text)
                    {
                        // 调整文字大小
                        text.fontSize = GameSettingLanguge.Language == 0? 32 : 28;
                        
                        // 调整文字宽度
                        Vector2 size = rt.sizeDelta;
                        size.x = GameSettingLanguge.Language == 0? 160f : 200f;
                        rt.sizeDelta = size;
                    }
                }
            }
        }
        
        public static void OnClickPageButton(this UIEquipmentIncreaseShowComponent self, int page)
        {
            self.Page = page;
            self.EquipmentBagInfo = null;
            self.OnEquiListUpdate(page).Coroutine();
        }
        
        //显示的时候刷新
        public static void OnUpdateUI(this UIEquipmentIncreaseShowComponent self)
        {
            self.OnEquiListUpdate(self.Page).Coroutine();
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
            self.EquipmentBagInfo = self.BagComponent.GetBagInfo(self.EquipmentBagInfo.BagInfoID);
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
        public static async ETTask OnEquiListUpdate(this UIEquipmentIncreaseShowComponent self, int page)
        {
            if (page == 0)
            {
                self.EquipSet.SetActive(true);
                self.ScrollViewEquip.SetActive(false);

                self.UIEquipSetComponent.PlayShowIdelAnimate(null);
                UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                self.UIEquipSetComponent.UpdateBagUI(self.BagComponent.GetEquipList(), userInfoComponent.UserInfo.Occ, ItemOperateEnum.Juese);
                self.UIEquipSetComponent.UpdateBagUI_2(self.BagComponent.GetEquipList_2(), userInfoComponent.UserInfo.Occ, ItemOperateEnum.Juese);
                self.UIEquipSetComponent.SetCallBack(self.OnSelectEquip);
            }
            else
            {
                self.EquipSet.SetActive(false);
                self.ScrollViewEquip.SetActive(true);
                int number = 0;
                var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
                var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

                List<BagInfo> equipInfos = new List<BagInfo>();
                equipInfos = self.BagComponent.GetItemsByType(ItemTypeEnum.Equipment);
                for (int i = 0; i < equipInfos.Count; i++)
                {
                    if (equipInfos[i].IfJianDing)
                    {
                        continue;
                    }

                    ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equipInfos[i].ItemID);
                    if (itemConfig.EquipType > 100)
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
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("未选择增幅卷轴"));
                return;
            }

            // 获取卷轴的传承和非传承的技能与属性
            string reelCanTransfAttribute = GameSettingLanguge.LoadLocalization("传承增幅:");
            string reelNoTransfAttribute = GameSettingLanguge.LoadLocalization("增幅:");
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
                string skillName = skillConfig.GetSkillName();

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
            string equipmentCanTransfAttribute = GameSettingLanguge.LoadLocalization("传承增幅:");
            string equipmentNoTransfAttribute = GameSettingLanguge.LoadLocalization("增幅:");
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
                string skillName = skillConfig.GetSkillName();

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
            if (reelCanTransfAttribute != GameSettingLanguge.LoadLocalization("传承增幅:") && equipmentCanTransfAttribute != GameSettingLanguge.LoadLocalization("传承增幅:"))
            {
                tipStr += string.Format(GameSettingLanguge.LoadLocalization("当前<color=#BEFF34>{0}</color> \n是否覆盖已有\n{1}\n"), reelCanTransfAttribute, equipmentCanTransfAttribute);
                isTip = true;
            }

            // 当前装备已经存在非传承增幅
            if (reelNoTransfAttribute != GameSettingLanguge.LoadLocalization("增幅:") && equipmentNoTransfAttribute != GameSettingLanguge.LoadLocalization("增幅:"))
            {
                tipStr += string.Format(GameSettingLanguge.LoadLocalization("当前<color=#BEFF34>{0}</color> \n是否覆盖已有\n{1}\n"), reelNoTransfAttribute, equipmentNoTransfAttribute);
                isTip = true;
            }

            // 是否弹出提示框
            if (isTip)
            {
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), GameSettingLanguge.LoadLocalization("装备增幅"), tipStr, async () =>
                {
                    await self.ZoneScene().GetComponent<BagComponent>().SendEquipmentIncrease(self.EquipmentBagInfo, self.ReelBagInfo);
                    FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("增幅成功"));
                    self.OnUpdateIncrease();
                }, () => { }).Coroutine();
            }
            else
            {
                await self.ZoneScene().GetComponent<BagComponent>().SendEquipmentIncrease(self.EquipmentBagInfo, self.ReelBagInfo);
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("增幅成功"));
                self.OnUpdateIncrease();
            }
        }

        public static void Destroy(this UIEquipmentIncreaseShowComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
}