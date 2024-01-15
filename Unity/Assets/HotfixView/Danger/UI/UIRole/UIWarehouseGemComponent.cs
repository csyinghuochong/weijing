using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIWarehouseGemComponent : Entity, IAwake, IDestroy
    {
        public GameObject BtnItemTypeSet;
        public GameObject BuildingList1;
        public GameObject BuildingList2;
        public GameObject ButtonPack;
        public GameObject ButtonQuick;
        public GameObject ButtonHeCheng;

        public BagComponent BagComponent;
        public UIPageButtonComponent UIPageComponent;

        public List<UIItemComponent> BagList = new List<UIItemComponent>();
        public List<UIItemComponent> HouseList = new List<UIItemComponent>();

        public List<GameObject> LockList = new List<GameObject>();
        public List<GameObject> NoLockList = new List<GameObject>();

        public List<BagInfo> AccountBagInfos = new List<BagInfo>();

        public BagInfo BagInfoPutIn;
    }

    public class UIWarehouseGemComponentAwake : AwakeSystem<UIWarehouseGemComponent>
    {
        public override void Awake(UIWarehouseGemComponent self)
        {
            self.BagList.Clear();
            self.HouseList.Clear();
            self.LockList.Clear();
            self.NoLockList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonPack = rc.Get<GameObject>("ButtonPack");
            self.ButtonPack.GetComponent<Button>().onClick.AddListener(self.OnBtn_ZhengLi);

            self.ButtonQuick = rc.Get<GameObject>("ButtonQuick");
            self.ButtonQuick.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonQuick().Coroutine(); });

            self.ButtonHeCheng = rc.Get<GameObject>("ButtonHeCheng");
            self.ButtonHeCheng.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonHeCheng().Coroutine(); });

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
            self.InitBagCell();
            self.UpdateLockList(0);

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);
        }
    }

    public class UIWarehouseGemComponentDestroy : DestroySystem<UIWarehouseGemComponent>
    {
        public override void Destroy(UIWarehouseGemComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
        }
    }

    public static class UIWarehouseGemComponentSystem
    {

        public static bool CheckPageButton_1(this UIWarehouseGemComponent self, int page)
        {
            return false;
        }

        public static void UpdateLockList(this UIWarehouseGemComponent self, int page)
        {

        }

        public static async ETTask RequestOpenCangKu(this UIWarehouseGemComponent self)
        {
            await ETTask.CompletedTask;
        }

        public static async ETTask OnButtonQuick(this UIWarehouseGemComponent self)
        {
            await ETTask.CompletedTask;
        }

        public static async ETTask OnButtonHeCheng(this UIWarehouseGemComponent self)
        {
            C2M_GemHeChengQuickRequest request = new C2M_GemHeChengQuickRequest() { LocType = 19 };
            M2C_GemHeChengQuickResponse response =
                    (M2C_GemHeChengQuickResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error == 0)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("宝石合成成功！"));
                
            }
        }

        public static  void OnBtn_ZhengLi(this UIWarehouseGemComponent self)
        {
            self.ZoneScene().GetComponent<BagComponent>().SendSortByLoc(ItemLocType.GemWareHouse1).Coroutine();
            FloatTipManager.Instance.ShowFloatTip("宝石仓库已整理完毕");
        }

        public static  void InitBagCell(this UIWarehouseGemComponent self)
        {
            long instanceid = self.InstanceId;
            
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            ///初始化背包格子
            int bagcellNumber = self.BagComponent.GetBagTotalCell();
            for (int i = 0; i < bagcellNumber; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList2);

                UIItemComponent uiitem = self.AddChild<UIItemComponent, GameObject>(go);
                self.BagList.Add(uiitem);
            }

            ////初始化仓库格子
            int hourseNumber = GlobalValueConfigCategory.Instance.GemStoreMaxCapacity;
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

            self.UpdateBagList();
        }

        public static void OnBuyBagCell(this UIWarehouseGemComponent self, string dataparams)
        {
        }

        public static void OnClickImage_Lock(this UIWarehouseGemComponent self)
        {
           
        }

        public static void OnClickPageButton(this UIWarehouseGemComponent self, int page)
        {
            int itemType = self.UIPageComponent.GetCurrentIndex();
            self.UpdateCurrentHouse();
            self.UpdateWareHouse();
            self.UpdateLockList(itemType);
        }

        /// <summary>
        /// 刷新仓库
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateWareHouse(this UIWarehouseGemComponent self)
        {
            List<BagInfo> bagInfos = self.BagComponent.GetItemsByLoc((ItemLocType)self.BagComponent.CurrentHouse);
            for (int i = 0; i < self.HouseList.Count; i++)
            {
                if (i < bagInfos.Count)
                {
                    self.HouseList[i].UpdateItem(bagInfos[i], ItemOperateEnum.GemCangku);
                }
                else
                {
                    self.HouseList[i].UpdateItem(null, ItemOperateEnum.None);
                }
            }
        }

        public static void UpdateBagUI(this UIWarehouseGemComponent self)
        {
            self.UpdateWareHouse();
            self.UpdateBagList();
        }

        public static void UpdateCurrentHouse(this UIWarehouseGemComponent self)
        {
            int itemType = self.UIPageComponent.GetCurrentIndex();
            self.BagComponent.CurrentHouse = itemType + (int)ItemLocType.GemWareHouse1;
        }

        public static void OnUpdateUI(this UIWarehouseGemComponent self)
        {
            self.UpdateCurrentHouse();
            self.UpdateWareHouse();
            self.UpdateBagList();
        }

        /// <summary>
        /// 刷新背包
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateBagList(this UIWarehouseGemComponent self)
        {
            List<BagInfo> bagInfos = new List<BagInfo>();

            List<BagInfo> allItems = self.BagComponent.GetItemsByLoc(ItemLocType.ItemLocBag);
            for (int i = 0; i < allItems.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(allItems[i].ItemID);
                if (itemConfig.ItemType == ItemTypeEnum.Gemstone)
                {
                    bagInfos.Add(allItems[i]);
                }
            }

            for (int i = 0; i < self.BagList.Count; i++)
            {
                if (i < bagInfos.Count)
                {
                    self.BagList[i].UpdateItem(bagInfos[i], ItemOperateEnum.GemBag);
                }
                else
                {
                    self.BagList[i].UpdateItem(null, ItemOperateEnum.None);
                }
            }
        }

    }
}