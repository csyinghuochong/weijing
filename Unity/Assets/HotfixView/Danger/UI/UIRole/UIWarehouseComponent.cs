using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIWarehouseComponent : Entity, IAwake, IDestroy
    {

        public GameObject BtnItemTypeSet;
        public GameObject BuildingList1;
        public GameObject BuildingList2;
        public GameObject ButtonPack;

        public BagComponent BagComponent;
        public UIPageButtonComponent UIPageComponent;

        public List<UI> BagList = new List<UI>();
        public List<UI> HouseList = new List<UI>();

        public List<GameObject> LockList = new List<GameObject>();
        public List<GameObject> NoLockList = new List<GameObject>();

        public int OpenIndex;
    }

    [ObjectSystem]
    public class UIWarehouseComponentDestroySystem : DestroySystem<UIWarehouseComponent>
    {
        public override void Destroy(UIWarehouseComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
        }
    }

    [ObjectSystem]
    public class UIWarehouseComponentAwakeSystem : AwakeSystem<UIWarehouseComponent>
    {
        public override void Awake(UIWarehouseComponent self)
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

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>( "BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent pageButton = uiPage.AddComponent<UIPageButtonComponent>();
            self.UIPageComponent = pageButton;
            pageButton.CheckHandler = (int page) => { return self.CheckPageButton_1(page); };
            pageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            pageButton.OnSelectIndex(0);
            self.UpdateLockList(0);
            self.UpdateBagList().Coroutine();

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);
        }
    }

    public static class UIWarehouseComponentSystem
    {

        public static bool CheckPageButton_1(this UIWarehouseComponent self, int page)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int cangkuNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CangKuNumber);
            if (cangkuNumber <= page)
            {
                self.OpenIndex = page;
                string costItems = GlobalValueConfigCategory.Instance.Get(38).Value;
                PopupTipHelp.OpenPopupTip( self.ZoneScene(), "开启仓库", 
                    $"是否消耗{UICommonHelper.GetNeedItemDesc(costItems)}开启一个仓库",
                    ()=>
                    {
                        self.RequestOpenCangKu(  ).Coroutine();
                    }, null).Coroutine();
                return false;
            }
            return true;
        }

        public static void UpdateLockList(this UIWarehouseComponent self, int page)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int cangkuNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CangKuNumber);
            for (int i = 0; i < self.LockList.Count; i++)
            {
                self.LockList[i].SetActive( cangkuNumber - 1 < i );
                self.NoLockList[i].SetActive(cangkuNumber - 1 >= i && i != page);
            }
        }

        public static async ETTask RequestOpenCangKu(this UIWarehouseComponent self)
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

        public static void OnBtn_ZhengLi(this UIWarehouseComponent self)
        {
            self.ZoneScene().GetComponent<BagComponent>().SendSortByLoc((ItemLocType)self.BagComponent.CurrentHouse).Coroutine();
        }

        public static async ETTask InitBagCell(this UIWarehouseComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            int totalNumber = int.Parse(GlobalValueConfigCategory.Instance.Get(3).Value);

            for (int i = 0; i < totalNumber; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList2);

                UI uiitem = self.AddChild<UI, string, GameObject>( "UIItem_" + i, go);
                uiitem.AddComponent<UIItemComponent>();
                self.BagList.Add(uiitem);
            }

            int hourseNumber = int.Parse(GlobalValueConfigCategory.Instance.Get(4).Value);
            for (int i = 0; i < hourseNumber; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList1);

                UI uiitem = self.AddChild<UI, string, GameObject>( "UIItem_" + i, go);
                uiitem.AddComponent<UIItemComponent>();
                self.HouseList.Add(uiitem);
            }
        }

        public static void OnClickPageButton(this UIWarehouseComponent self, int page)
        {
            int itemType = self.UIPageComponent.GetCurrentIndex();
            self.BagComponent.CurrentHouse = itemType + (int)ItemLocType.ItemWareHouse1;

            self.UpdateWareHouse().Coroutine();
            self.UpdateLockList(itemType);
        }

        /// <summary>
        /// 刷新仓库
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask UpdateWareHouse(this UIWarehouseComponent self)
        {
            if (self.HouseList.Count == 0)
            {
                await self.InitBagCell();
            }
            for (int i = 0; i < self.HouseList.Count; i++)
            {
                self.HouseList[i].GetComponent<UIItemComponent>().UpdateItem(null);
            }

            List<BagInfo> bagInfos = self.BagComponent.GetItemsByLoc((ItemLocType)self.BagComponent.CurrentHouse);
            if (bagInfos.Count == 0)
                return;

            for (int i = 0; i < bagInfos.Count; i++)
            {
                self.HouseList[i].GetComponent<UIItemComponent>().UpdateItem( bagInfos[i], ItemOperateEnum.Cangku);
            }
        }

        /// <summary>
        /// 刷新背包
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask UpdateBagList(this UIWarehouseComponent self)
        {
            if (self.BagList.Count == 0)
            {
                await self.InitBagCell();
            }

            for (int i = 0; i < self.BagList.Count; i++)
            {
                self.BagList[i].GetComponent<UIItemComponent>().UpdateItem(null);
            }

            List<BagInfo> bagInfos = self.BagComponent.GetItemsByLoc(ItemLocType.ItemLocBag);
            if (bagInfos.Count == 0)
                return;
            for (int i = 0; i < bagInfos.Count; i++)
            {
                self.BagList[i].GetComponent<UIItemComponent>().UpdateItem(bagInfos[i], ItemOperateEnum.CangkuBag);
            }
        }

        public static void UpdateBagUI(this UIWarehouseComponent self)
        {
            self.UpdateWareHouse().Coroutine();
            self.UpdateBagList().Coroutine();
        }

        public static void OnCloseWarehouse(this UIWarehouseComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIWarehouse);
        }


    }

}
