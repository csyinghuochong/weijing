using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleBagComponent : Entity, IAwake, IDestroy
    {
        public GameObject Button_OpenOneSellSet;
        public GameObject Btn_OneGem;
        public Transform BuildingList;
        public GameObject Btn_ZhengLi;
        public GameObject Btn_OneSell;
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();
        public UIPageButtonComponent UIPageComponent;
        
        public List<Vector2> UIOldPositionList = new List<Vector2>();
    }


    public class UIRoleBagComponentAwakeSystem : AwakeSystem<UIRoleBagComponent>
    {
        public override void Awake(UIRoleBagComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.BuildingList = rc.Get<GameObject>("BuildingList").transform;
            self.ItemUIlist.Clear();
            
            self.Button_OpenOneSellSet = rc.Get<GameObject>("Button_OpenOneSellSet");
            self.Button_OpenOneSellSet.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_OpenOneSellSet(); });
            
            self.Btn_ZhengLi = rc.Get<GameObject>("Btn_ZhengLi");
            self.Btn_ZhengLi.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhengLi(); });

            self.Btn_OneSell = rc.Get<GameObject>("Btn_OneSell");
            self.Btn_OneSell.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_OneSell(); });

            self.Btn_OneGem = rc.Get<GameObject>("Btn_OneGem");
            self.Btn_OneGem.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_OneGem(); });

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            //单选组件
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
            
            self.InitBagUIList().Coroutine();
        }
    }

    public class UIRoleBagComponentDestroySystem: DestroySystem<UIRoleBagComponent>
    {
        public override void Destroy(UIRoleBagComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }


    public static class UIRoleBagComponentSystem
    {
        public static void StoreUIdData(this UIRoleBagComponent self)
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

        public static void OnLanguageUpdate(this UIRoleBagComponent self)
        {
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
                        text.fontSize = GameSettingLanguge.Language == 0 ? 32 : 28;

                        // 调整文字宽度
                        Vector2 size = rt.sizeDelta;
                        size.x = GameSettingLanguge.Language == 0 ? 160f : 200f;
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
                        text.alignment = GameSettingLanguge.Language == 0 ? TextAnchor.UpperLeft : TextAnchor.UpperCenter;
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
                        text.fontSize = GameSettingLanguge.Language == 0 ? 32 : 28;

                        // 调整文字宽度
                        Vector2 size = rt.sizeDelta;
                        size.x = GameSettingLanguge.Language == 0 ? 160f : 200f;
                        rt.sizeDelta = size;
                    }
                }
            }
        }

        public static void OnUpdateUI(this UIRoleBagComponent self)
        {
            self.UIPageComponent.OnSelectIndex(0);
        }

        public static void OnButton_OpenOneSellSet(this UIRoleBagComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIOneSellSet).Coroutine();
        }


        public static void OnBtn_ZhengLi(this UIRoleBagComponent self)
        {
            self.ZoneScene().GetComponent<BagComponent>().SendSortByLoc(ItemLocType.ItemLocBag).Coroutine();
            FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("背包已整理完毕"));
        }

        public static void OnBtn_OneSell(this UIRoleBagComponent self)
        {
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), GameSettingLanguge.LoadLocalization("一键出售"), GameSettingLanguge.LoadLocalization("是否一键出售低品质装备和宝石,出售品质可以在设置中进行选择"), () =>
            {
                self.RequestOneSell().Coroutine();
            }, null).Coroutine();
        }

        public static void OnBtn_OneGem(this UIRoleBagComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftCell() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("请至少预留一个格子"));
                return;
            }

            List<BagInfo> bagItemList = bagComponent.GetBagList();
            List<BagInfo> gemList = new List<BagInfo>();
            for (int i = 0; i < bagItemList.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagItemList[i].ItemID);
                if (itemConfig.ItemType != ItemTypeEnum.Gemstone)
                {
                    continue;
                }

                if (!EquipMakeConfigCategory.Instance.GetHeChengList.ContainsKey(itemConfig.Id))
                {
                    continue;
                }
                gemList.Add(bagItemList[i]);
            }
            long costgold = 0;
            long costvitality = 0;
            for (int i = gemList.Count - 1; i >= 0; i--)
            {
                KeyValuePairInt keyValuePair = EquipMakeConfigCategory.Instance.GetHeChengList[gemList[i].ItemID];
                int neednumber = (int)keyValuePair.Value;
                int newmakeid = keyValuePair.KeyId;
                int newnumber = gemList[i].ItemNum / neednumber;
                EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(newmakeid);
                costgold += (equipMakeConfig.MakeNeedGold * newnumber);
                costvitality += (equipMakeConfig.CostVitality * newnumber);
            }

            if (costgold <= 0)
            {

                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("当前背包暂无可合成宝石"));
                return;
            }
            //{costvitality}活力
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), GameSettingLanguge.LoadLocalization("合成宝石"), string.Format(GameSettingLanguge.LoadLocalization("一键合成消耗{0}金币"), costgold), () =>
            {


                self.REquestGemHeCheng().Coroutine();
            }, null).Coroutine();
        }

        public static async ETTask REquestGemHeCheng(this UIRoleBagComponent self)
        {
            C2M_GemHeChengQuickRequest request = new C2M_GemHeChengQuickRequest();
            M2C_GemHeChengQuickResponse response = (M2C_GemHeChengQuickResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

        }

        public static async ETTask RequestOneSell(this UIRoleBagComponent self)
        {

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            await bagComponent.RequestOneSell(ItemLocType.ItemLocBag);        //方法封装进通用里了

            /*
            List<long> baginfoids = new List<long>();   
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetBagList();

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            string value = userInfoComponent.GetGameSettingValue(GameSettingEnum.OneSellSet);
            string[] setvalues = value.Split('@');  //绿色 蓝色 宝石

            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                
                if (itemConfig.ItemType == ItemTypeEnum.Gemstone)
                {
                    if (setvalues[2] == "1" && itemConfig.ItemQuality <= 3)
                    {
                        baginfoids.Add(bagInfos[i].BagInfoID);
                        continue;
                    }
                }

                if (itemConfig.ItemType == ItemTypeEnum.Equipment)
                {
                    if (setvalues[0] == "1" && itemConfig.ItemQuality <= 2)
                    {
                        baginfoids.Add(bagInfos[i].BagInfoID);
                        continue;
                    }
                    if (setvalues[1] == "1" && itemConfig.ItemQuality <= 3)
                    {
                        baginfoids.Add(bagInfos[i].BagInfoID);
                        continue;
                    }
                }
            }

            C2M_ItemOneSellRequest request = new C2M_ItemOneSellRequest() { BagInfoIds = baginfoids };
            M2C_ItemOneSellResponse response = (M2C_ItemOneSellResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            */
        }

        //点击回调
        public static void OnClickPageButton(this UIRoleBagComponent self, int page)
        {
            if (self.ItemUIlist.Count < GlobalValueConfigCategory.Instance.BagInitCapacity)
            {
                return;
            }
            self.UpdateBagUI(page);
        }

        public static async ETTask InitBagUIList(this UIRoleBagComponent self)
        {
            //Log.Debug("page:   " + page);
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetItemsByType(0);
            int maxCount = GlobalValueConfigCategory.Instance.BagMaxCapacity;
            for (int i = 0; i < maxCount; i++)
            {
                if (i % 10 == 30)
                {
                    await TimerComponent.Instance.WaitAsync(500);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }
                GameObject go = GameObject.Instantiate(bundleGameObject);
                go.transform.SetParent(self.BuildingList);
                go.transform.localPosition = Vector3.zero;
                go.transform.localScale = Vector3.one;

                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(go);
                uIItemComponent.SetClickHandler((BagInfo bInfo) => { self.OnClickHandler(bInfo); });
                BagInfo bagInfo = i < bagInfos.Count ? bagInfos[i] : null;
                uIItemComponent.UpdateItem(bagInfo, ItemOperateEnum.Bag);
                //uIItemComponent.UpdateUnLock(i < opencell);
                uIItemComponent.Image_Lock.GetComponent<Button>().onClick.AddListener(self.OnClickImage_Lock);
                self.ItemUIlist.Add(uIItemComponent);

                go.name = bagInfo != null ? bagInfo.BagInfoID.ToString() : "0";
            }

            self.CheckUpItem();
        }

        public static void OnClickImage_Lock(this UIRoleBagComponent self)
        {
            //string costitems = GlobalValueConfigCategory.Instance.Get(83).Value;
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            BuyCellCost buyCellCost = ConfigHelper.BuyBagCellCosts[bagComponent.WarehouseAddedCell[0]];

            PopupTipHelp.OpenPopupTip(self.ZoneScene(), GameSettingLanguge.LoadLocalization("购买格子"),
                string.Format(GameSettingLanguge.LoadLocalization("是否花费{0}购买一个背包格子?"), UICommonHelper.GetNeedItemDesc(buyCellCost.Cost)), () =>
                {
                    self.ZoneScene().GetComponent<BagComponent>().SendBuyBagCell(0).Coroutine();
                }, null).Coroutine();
            return;
        }

        public static void OnClickHandler(this UIRoleBagComponent self, BagInfo bagInfo)
        {
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].SetSelected(bagInfo);
            }
        }

        public static void OnBuyBagCell(this UIRoleBagComponent self)
        {
            //BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            //int opencell = bagComponent.GetTotalSpace();
            //for (int i = 0; i < self.ItemUIlist.Count; i++)
            //{
            //    self.ItemUIlist[i].UpdateUnLock(i < opencell);
            //}

            self.UpdateBagUI(-1);
        }

        public static void CheckUpItem(this UIRoleBagComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            UserInfo userInfo = userInfoComponent.UserInfo;
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                BagInfo bagInfo = self.ItemUIlist[i].Baginfo;
                if (bagInfo == null)
                {
                    continue;
                }

                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                List<BagInfo> curEquiplist = bagComponent.GetEquipListByWeizhi(itemConfig.ItemSubType);

                bool showup = ItemHelper.CheckUpItem(userInfo, bagInfo, curEquiplist);
                self.ItemUIlist[i].Image_UpTip.SetActive(showup);
            }
        }

        //属性背包
        public static void UpdateBagUI(this UIRoleBagComponent self, int page)
        {
            if (page == -1)
            {
                page = self.UIPageComponent.GetCurrentIndex();
            }
            int itemTypeEnum = ItemTypeEnum.ALL;
            switch (page)
            {
                case 0:
                    itemTypeEnum = ItemTypeEnum.ALL;
                    break;
                case 1:
                    itemTypeEnum = ItemTypeEnum.Equipment;
                    break;
                case 2:
                    itemTypeEnum = ItemTypeEnum.Material;
                    break;
                case 3:
                    itemTypeEnum = ItemTypeEnum.Consume;
                    break;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetItemsByType(itemTypeEnum);
            int openell = bagComponent.GetBagTotalCell();
            int allNumber = bagComponent.GetBagShowCell();  
            for (int i = 0; i < allNumber; i++)
            {
                BagInfo bagInfo = i < bagInfos.Count ?  bagInfos[i] : null;
                self.ItemUIlist[i].UpdateItem(bagInfo, ItemOperateEnum.Bag);
                self.ItemUIlist[i].GameObject.SetActive(true);
                if (i < openell)
                {
                    self.ItemUIlist[i].UpdateUnLock(true);
                }
                else
                {
                    self.ItemUIlist[i].UpdateUnLock(false);
                    int addcell = bagComponent.WarehouseAddedCell[0] + (i - openell);
                    BuyCellCost buyCellCost = ConfigHelper.BuyBagCellCosts[addcell];
                    int itemid = int.Parse(buyCellCost.Get.Split(';')[0]);
                    int itemnum = int.Parse(buyCellCost.Get.Split(';')[1]);
                    self.ItemUIlist[i].UpdateItem(new BagInfo() { ItemID = itemid, BagInfoID = i, ItemNum = itemnum }, ItemOperateEnum.None);
                }
            }
            for (int i = allNumber; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].GameObject.SetActive(false);
            }

            self.CheckUpItem();
        }

    }
}
