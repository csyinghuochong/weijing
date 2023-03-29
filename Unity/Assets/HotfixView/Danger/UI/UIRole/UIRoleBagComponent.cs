using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleBagComponent : Entity, IAwake
    {
        public Transform BuildingList;
        public GameObject Btn_ZhengLi;
        public GameObject Btn_OneSell;
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();
        public UIPageButtonComponent UIPageComponent;
    }

    [ObjectSystem]
    public class UIRoleBagComponentAwakeSystem : AwakeSystem<UIRoleBagComponent>
    {
        public override void Awake(UIRoleBagComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.BuildingList = rc.Get<GameObject>("BuildingList").transform;
            self.ItemUIlist.Clear();

            self.Btn_ZhengLi = rc.Get<GameObject>("Btn_ZhengLi");
            self.Btn_ZhengLi.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhengLi(); });

            self.Btn_OneSell = rc.Get<GameObject>("Btn_OneSell");
            self.Btn_OneSell.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_OneSell(); });

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>( "BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent  = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler( (int page)=>{
                self.OnClickPageButton(page);
            } );
            self.UIPageComponent = uIPageViewComponent;
            self.InitBagUIList().Coroutine();
        }
    }

    public static class UIRoleBagComponentSystem
    {
        public static void OnUpdateUI(this UIRoleBagComponent self)
        {
            self.UIPageComponent.OnSelectIndex(0);
        }

        public static void OnBtn_ZhengLi(this UIRoleBagComponent self)
        {
            self.ZoneScene().GetComponent<BagComponent>().SendSortByLoc(ItemLocType.ItemLocBag).Coroutine();
            FloatTipManager.Instance.ShowFloatTip("背包已整理完毕");
        }

        public static  void OnBtn_OneSell(this UIRoleBagComponent self)
        {
            PopupTipHelp.OpenPopupTip( self.ZoneScene(), "一键出售", "是否一键出售低品质装备和宝石,出售品质可以在设置中进行选择", ()=>
            {
                self.RequestOneSell().Coroutine();
            }, null).Coroutine();
        }

        public static async ETTask RequestOneSell(this UIRoleBagComponent self)
        {
            List<long> baginfoids = new List<long>();   
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetBagList();

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            string value = userInfoComponent.GetGameSettingValue(GameSettingEnum.OneSellSet);
            string[] setvalues = value.Split('@');  //绿色 蓝色 宝石

            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                
                if (setvalues[2] == "1" && itemConfig.ItemType == ItemTypeEnum.Gemstone && itemConfig.ItemQuality <= 3)
                {
                    baginfoids.Add(bagInfos[i].BagInfoID);
                    continue;
                }

                if (itemConfig.ItemType != ItemTypeEnum.Equipment)
                {
                    continue;
                }
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

            C2M_ItemOneSellRequest request = new C2M_ItemOneSellRequest() { BagInfoIds = baginfoids };
            M2C_ItemOneSellResponse response = (M2C_ItemOneSellResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
        }

        //点击回调
        public static void OnClickPageButton(this UIRoleBagComponent self, int page)
        {
            if (self.ItemUIlist.Count < GlobalValueConfigCategory.Instance.BagMaxCell)
            {
                return;
            }
            self.UpdateBagUI(page);
        }

        public static async ETTask  InitBagUIList(this UIRoleBagComponent self)
        {
            //Log.Debug("page:   " + page);
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetItemsByType(0);
            int opencell = bagComponent.GetTotalSpace();
            int maxCount = GlobalValueConfigCategory.Instance.BagMaxCell;
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
                uIItemComponent.UpdateUnLock(i < opencell);
                uIItemComponent.Image_Lock.GetComponent<Button>().onClick.AddListener(self.OnClickImage_Lock);
                self.ItemUIlist.Add(uIItemComponent);
            }
        }

        public static void OnClickImage_Lock(this UIRoleBagComponent self)
        {
            //string costitems = GlobalValueConfigCategory.Instance.Get(83).Value;
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            BuyCellCost buyCellCost = ConfigHelper.BuyBagCellCosts[bagComponent.BagAddedCell];

            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "购买格子",
                $"是否花费{UICommonHelper.GetNeedItemDesc(buyCellCost.Cost)}购买一个背包格子?", () =>
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
            int openell = bagComponent.GetTotalSpace();
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                BagInfo bagInfo = i < bagInfos.Count ?  bagInfos[i] : null;
                self.ItemUIlist[i].UpdateItem(bagInfo, ItemOperateEnum.Bag);

                if (i < openell)
                {
                    self.ItemUIlist[i].UpdateUnLock(true);
                }
                else
                {
                    self.ItemUIlist[i].UpdateUnLock(false);
                    int addcell = bagComponent.BagAddedCell + (i - openell);
                    BuyCellCost buyCellCost = ConfigHelper.BuyBagCellCosts[addcell];
                    int itemid = int.Parse(buyCellCost.Get.Split(';')[0]);
                    int itemnum = int.Parse(buyCellCost.Get.Split(';')[1]);
                    self.ItemUIlist[i].UpdateItem(new BagInfo() { ItemID = itemid, BagInfoID = i, ItemNum = itemnum }, ItemOperateEnum.None);
                }
            }
        }

    }
}
