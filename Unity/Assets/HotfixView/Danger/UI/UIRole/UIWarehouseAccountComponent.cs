using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWarehouseAccountComponent: Entity, IAwake, IDestroy
    {
        public GameObject BtnItemTypeSet;
        public GameObject BuildingList1;
        public GameObject BuildingList2;
        public GameObject ButtonPack;
        public GameObject ButtonQuick;

        public BagComponent BagComponent;
        public UIPageButtonComponent UIPageComponent;

        public List<UIItemComponent> BagList = new List<UIItemComponent>();
        public List<UIItemComponent> HouseList = new List<UIItemComponent>();

        public List<GameObject> LockList = new List<GameObject>();
        public List<GameObject> NoLockList = new List<GameObject>();

        public List<BagInfo> AccountBagInfos = new List<BagInfo>();

        public BagInfo BagInfoPutIn;
    }

    public class UIWarehouseAccountComponentAwake : AwakeSystem<UIWarehouseAccountComponent>
    {
        public override void Awake(UIWarehouseAccountComponent self)
        {
            self.BagList.Clear();
            self.HouseList.Clear();
            self.LockList.Clear();
            self.NoLockList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonPack = rc.Get<GameObject>("ButtonPack");
            self.ButtonPack.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhengLi().Coroutine();  });

            self.ButtonQuick = rc.Get<GameObject>("ButtonQuick");
            self.ButtonQuick.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonQuick().Coroutine(); });

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
            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent pageButton = uiPage.AddComponent<UIPageButtonComponent>();
            self.UIPageComponent = pageButton;
            pageButton.CheckHandler = (int page) => { return self.CheckPageButton_1(page); };
            pageButton.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            self.UIPageComponent.ClickEnabled = false;
            self.InitBagCell().Coroutine();
            self.UpdateLockList(0);

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.AccountWarehous, self);
        }
    }

    public class UIWarehouseAccountComponentDestroy : DestroySystem<UIWarehouseAccountComponent>
    {
        public override void Destroy(UIWarehouseAccountComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.AccountWarehous, self);
        }
    }

    public static class UIWarehouseAccountComponentSystem
    {
        public static bool CheckPageButton_1(this UIWarehouseAccountComponent self, int page)
        {
            return false;
        }

        public static void UpdateLockList(this UIWarehouseAccountComponent self, int page)
        {
            
        }

        public static async ETTask RequestOpenCangKu(this UIWarehouseAccountComponent self)
        {
            await ETTask.CompletedTask;
        }

        public static async ETTask OnButtonQuick(this UIWarehouseAccountComponent self)
        {
            await ETTask.CompletedTask;
        }

        public static async ETTask OnBtn_ZhengLi(this UIWarehouseAccountComponent self)
        {
            await self. SendAccountWarehousOperate(3, 0);
            ItemHelper.ItemLitSort(self.AccountBagInfos);
            self.UpdateWareHouse();
        }

        public static async ETTask SendAccountWarehousOperate(this UIWarehouseAccountComponent self, int operateType, long operateId)
        {
            C2M_AccountWarehousOperateRequest request = new C2M_AccountWarehousOperateRequest() { OperatateType = operateType, OperateBagID = operateId };
            M2C_AccountWarehousOperateResponse response = (M2C_AccountWarehousOperateResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
        }

        public static void OnAccountWarehous(this UIWarehouseAccountComponent self, string paramstr, long baginfoId)
        {
            if (paramstr == "1")
            {
                if (self.BagInfoPutIn == null || self.BagInfoPutIn.BagInfoID != baginfoId)
                {
                    return;
                }
                for (int i = self.AccountBagInfos.Count - 1; i >= 0; i--)
                {
                    if (self.AccountBagInfos[i].BagInfoID == baginfoId)
                    {
                        return;
                    }
                }
                self.AccountBagInfos.Add(self.BagInfoPutIn);
                self.UpdateWareHouse();
                self.UpdateBagList();
            }
            if (paramstr == "2")
            {
                for (int i = self.AccountBagInfos.Count - 1; i >= 0; i--)
                {
                    if (self.AccountBagInfos[i].BagInfoID == baginfoId)
                    {
                        self.AccountBagInfos.RemoveAt(i);
                    }
                }
                self.UpdateWareHouse();
                self.UpdateBagList();
            }
        }

        public static async ETTask InitBagCell(this UIWarehouseAccountComponent self)
        {
            long instanceid = self.InstanceId;
            long accountId = self.ZoneScene().GetComponent<AccountInfoComponent>().AccountId;
            C2E_AccountWarehousInfoRequest reuqest = new C2E_AccountWarehousInfoRequest() { AccInfoID = accountId };
            E2C_AccountWarehousInfoResponse response = (E2C_AccountWarehousInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reuqest);
            if (instanceid != self.InstanceId || response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            ///初始化背包格子
            int bagcellNumber = self.BagComponent.GetTotalSpace();
            for (int i = 0; i < bagcellNumber; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList2);

                UIItemComponent uiitem = self.AddChild<UIItemComponent, GameObject>(go);
                self.BagList.Add(uiitem);
            }

            ////初始化仓库格子
            int hourseNumber = GlobalValueConfigCategory.Instance.AccountBagMax;
            hourseNumber = response.BagInfos.Count > hourseNumber ? response.BagInfos.Count : hourseNumber;
            for (int i = 0; i < hourseNumber; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList1);

                UIItemComponent uiitem = self.AddChild<UIItemComponent, GameObject>(go);
                uiitem.Image_Lock.GetComponent<Button>().onClick.AddListener(self.OnClickImage_Lock);
                self.HouseList.Add(uiitem);
            }
            self.AccountBagInfos = response.BagInfos;

            self.UIPageComponent.ClickEnabled = true;
            self.UIPageComponent.OnSelectIndex(0);

            self.UpdateBagList();
        }

        public static void OnBuyBagCell(this UIWarehouseAccountComponent self, string dataparams)
        {
            
        }

        public static void OnClickImage_Lock(this UIWarehouseAccountComponent self)
        {
            
        }

        public static void OnClickPageButton(this UIWarehouseAccountComponent self, int page)
        {
            self.UpdateWareHouse();
        }

        /// <summary>
        /// 刷新仓库
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateWareHouse(this UIWarehouseAccountComponent self)
        {
            List<BagInfo> bagInfos = self.AccountBagInfos;
            for (int i = 0; i < self.HouseList.Count; i++)
            {
                if (i < bagInfos.Count)
                {
                    self.HouseList[i].UpdateItem(bagInfos[i], ItemOperateEnum.AccountCangku);
                }
                else
                {
                    self.HouseList[i].UpdateItem(null, ItemOperateEnum.None);
                }
            }
        }

        public static void OnUpdateUI(this UIWarehouseAccountComponent self)
        {
            self.UpdateBagList();
        }

        /// <summary>
        /// 刷新背包
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateBagList(this UIWarehouseAccountComponent self)
        {
            List<BagInfo> bagInfos = self.BagComponent.GetItemsByLoc(ItemLocType.ItemLocBag);
            for (int i = 0; i < self.BagList.Count; i++)
            {
                if (i < bagInfos.Count)
                {
                    self.BagList[i].UpdateItem(bagInfos[i], ItemOperateEnum.AccountBag);
                }
                else
                {
                    self.BagList[i].UpdateItem(null, ItemOperateEnum.None);
                }
            }
        }

        public static void UpdateBagUI(this UIWarehouseAccountComponent self)
        {
            if (self.HouseList.Count < 20)
            {
                return;
            }

            self.UpdateWareHouse();
            self.UpdateBagList();
        }
    }
}