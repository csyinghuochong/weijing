using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanWarehouseComponent:Entity, IAwake, IDestroy
    {
        public GameObject BtnItemTypeSet;
        public GameObject BuildingList1;
        public GameObject BuildingList2;
        public GameObject ButtonPack;

        public BagComponent BagComponent;
        public JiaYuanComponent JiaYuanComponent;   
        public UIPageButtonComponent UIPageComponent;

        public List<UIItemComponent> BagList = new List<UIItemComponent>();
        public List<UIItemComponent> HouseList = new List<UIItemComponent>();

        public List<GameObject> LockList = new List<GameObject>();
        public List<GameObject> NoLockList = new List<GameObject>();

        public int OpenIndex;
    }

    [ObjectSystem]
    public class UIJiaYuanWarehouseComponentDestroy : DestroySystem<UIJiaYuanWarehouseComponent>
    {
        public override void Destroy(UIJiaYuanWarehouseComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.BuyBagCell, self);
        }
    }

    [ObjectSystem]
    public class UIJiaYuanWarehouseComponentAwake : AwakeSystem<UIJiaYuanWarehouseComponent>
    {
        public override void Awake(UIJiaYuanWarehouseComponent self)
        {
            self.BagList.Clear();
            self.HouseList.Clear();
            self.LockList.Clear();
            self.NoLockList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonPack = rc.Get<GameObject>("ButtonPack");
            self.ButtonPack.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhengLi(); });

            self.BuildingList1 = rc.Get<GameObject>("BuildingList1");
            self.BuildingList2 = rc.Get<GameObject>("BuildingList2");

            self.LockList.Add(rc.Get<GameObject>("Lock_1"));
            self.LockList.Add(rc.Get<GameObject>("Lock_2"));
            self.LockList.Add(rc.Get<GameObject>("Lock_3"));
            self.LockList.Add(rc.Get<GameObject>("Lock_4"));
            self.NoLockList.Add(rc.Get<GameObject>("NoLock_1"));
            self.NoLockList.Add(rc.Get<GameObject>("NoLock_2"));
            self.NoLockList.Add(rc.Get<GameObject>("NoLock_3"));
            self.NoLockList.Add(rc.Get<GameObject>("NoLock_4"));

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
            self.JiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent pageButton = uiPage.AddComponent<UIPageButtonComponent>();
            self.UIPageComponent = pageButton;
            pageButton.CheckHandler = (int page) => { return self.CheckPageButton_1(page); };
            pageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageComponent.ClickEnabled = false;
            self.InitBagCell().Coroutine();
            self.UpdateLockList(0);

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.BuyBagCell, self);
        }
    }

    public static class UIJiaYuanWarehouseComponentSystem
    {

        public static bool CheckPageButton_1(this UIJiaYuanWarehouseComponent self, int page)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int cangkuNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CangKuNumber);
            if (cangkuNumber <= page)
            {
                self.OpenIndex = page;
                string costItems = GlobalValueConfigCategory.Instance.Get(38).Value;
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "开启仓库",
                    $"是否消耗{UICommonHelper.GetNeedItemDesc(costItems)}开启一个仓库",
                    () =>
                    {
                        self.RequestOpenCangKu().Coroutine();
                    }, null).Coroutine();
                return false;
            }
            return true;
        }

        public static void UpdateLockList(this UIJiaYuanWarehouseComponent self, int page)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int cangkuNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CangKuNumber);
            for (int i = 0; i < self.LockList.Count; i++)
            {
                self.LockList[i].SetActive(cangkuNumber - 1 < i);
                self.NoLockList[i].SetActive(cangkuNumber - 1 >= i && i != page);
            }
        }

        public static async ETTask RequestOpenCangKu(this UIJiaYuanWarehouseComponent self)
        {
            C2M_RoleOpenCangKuRequest request = new C2M_RoleOpenCangKuRequest();
            M2C_RoleOpenCangKuResponse response = (M2C_RoleOpenCangKuResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            self.UpdateLockList(self.OpenIndex);
            self.UIPageComponent.OnSelectIndex(self.OpenIndex);
        }

        public static void OnBtn_ZhengLi(this UIJiaYuanWarehouseComponent self)
        {

        }

        public static async ETTask InitBagCell(this UIJiaYuanWarehouseComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            int bagcellNumber = self.BagComponent.GetTotalSpace();

            for (int i = 0; i < bagcellNumber; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList2);

                UIItemComponent uiitem = self.AddChild<UIItemComponent, GameObject>(go);
                self.BagList.Add(uiitem);
            }

            int hourseNumber = GlobalValueConfigCategory.Instance.StoreCapacity;
            for (int i = 0; i < hourseNumber; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList1);

                UIItemComponent uiitem = self.AddChild<UIItemComponent, GameObject>(go);
                uiitem.Image_Lock.GetComponent<Button>().onClick.AddListener(self.OnClickImage_Lock);
                self.HouseList.Add(uiitem);
            }

            self.UIPageComponent.ClickEnabled = true;
            self.UIPageComponent.OnSelectIndex(0);

            self.OnUpdateUI();
        }

        public static void OnBuyBagCell(this UIJiaYuanWarehouseComponent self, string dataparams)
        {
            self.UpdateWareHouse();

            FloatTipManager.Instance.ShowFloatTip($"获得道具: {UICommonHelper.GetNeedItemDesc(dataparams)}");
        }


        public static void OnClickImage_Lock(this UIJiaYuanWarehouseComponent self)
        {
            //int curindex = self.UIPageComponent.GetCurrentIndex();
            string costitems = GlobalValueConfigCategory.Instance.Get(83).Value;
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "购买格子",
                $"是否花费{UICommonHelper.GetNeedItemDesc(costitems)}购买一个背包格子?", () =>
                {

                }, null).Coroutine();
            return;
        }

        public static void OnClickPageButton(this UIJiaYuanWarehouseComponent self, int page)
        {
            int itemType = self.UIPageComponent.GetCurrentIndex();
            self.BagComponent.CurrentHouse = itemType + (int)ItemLocType.ItemWareHouse1;

            self.UpdateWareHouse();
            self.UpdateLockList(itemType);
        }

        /// <summary>
        /// 刷新仓库
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateWareHouse(this UIJiaYuanWarehouseComponent self)
        {
            int curindex = self.UIPageComponent.GetCurrentIndex();

            List<BagInfo> bagInfos = self.BagComponent.GetItemsByLoc((curindex + ItemLocType.JianYuanWareHouse1));
            for (int i = 0; i < self.HouseList.Count; i++)
            {
                if (i < bagInfos.Count)
                {
                    self.HouseList[i].UpdateItem(bagInfos[i], ItemOperateEnum.Cangku);
                }
                else
                {
                    self.HouseList[i].UpdateItem(null, ItemOperateEnum.None);
                }
            }
        }

        /// <summary>
        /// 刷新背包
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateBagList(this UIJiaYuanWarehouseComponent self)
        {
            int number = 0;
            List<BagInfo> bagInfos = self.BagComponent.GetItemsByLoc(ItemLocType.ItemLocBag);
            for (int i = 0; i < self.BagList.Count; i++)
            {
                if (i >= bagInfos.Count)
                {
                    self.BagList[i].UpdateItem(null, ItemOperateEnum.None);
                    continue;
                }

                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemType == 2 && (itemConfig.ItemSubType == 101 || itemConfig.ItemSubType == 201))
                {
                    self.BagList[number].UpdateItem(bagInfos[i], ItemOperateEnum.CangkuBag);
                    number++;
                }
            }
        }

        public static void OnUpdateUI(this UIJiaYuanWarehouseComponent self)
        {
            if (self.HouseList.Count < GlobalValueConfigCategory.Instance.StoreCapacity)
            {
                return;
            }

            self.UpdateWareHouse();
            self.UpdateBagList();
        }

        public static void OnCloseWarehouse(this UIJiaYuanWarehouseComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIJiaYuanWarehouse);
        }

    }
}
