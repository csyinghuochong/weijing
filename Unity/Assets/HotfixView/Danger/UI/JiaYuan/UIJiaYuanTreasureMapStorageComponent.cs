using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    /// <summary>
    /// 家园藏宝图仓库UI
    /// </summary>
    public class UIJiaYuanTreasureMapStorageComponent: Entity, IAwake, IDestroy
    {
        /// <summary>
        /// 一键取出按钮
        /// </summary>
        public GameObject ButtonTakeOutAll;

        /// <summary>
        /// 一键放入按钮
        /// </summary>
        public GameObject ButtonOneKey;

        /// <summary>
        /// 仓库列表
        /// </summary>
        public GameObject BuildingList1;

        /// <summary>
        /// 背包列表
        /// </summary>
        public GameObject BuildingList2;

        /// <summary>
        /// 整理按钮
        /// </summary>
        public GameObject ButtonPack;

        /// <summary>
        /// 分页按钮组
        /// </summary>
        public GameObject BtnItemTypeSet;

        public BagComponent BagComponent;
        public JiaYuanComponent JiaYuanComponent;
        public UIPageButtonComponent UIPageComponent;

        public List<UIItemComponent> BagList = new List<UIItemComponent>();
        public List<UIItemComponent> StorageList = new List<UIItemComponent>();
    }

    public class UIJiaYuanTreasureMapStorageComponentAwakeSystem: AwakeSystem<UIJiaYuanTreasureMapStorageComponent>
    {
        public override void Awake(UIJiaYuanTreasureMapStorageComponent self)
        {
            self.Awake();
        }
    }

    public class UIJiaYuanTreasureMapStorageComponentDestroySystem: DestroySystem<UIJiaYuanTreasureMapStorageComponent>
    {
        public override void Destroy(UIJiaYuanTreasureMapStorageComponent self)
        {
            self.Destroy();
        }
    }

    public static class UIJiaYuanTreasureMapStorageComponentSystem
    {
        public static void Awake(this UIJiaYuanTreasureMapStorageComponent self)
        {
            self.BagList.Clear();
            self.StorageList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonPack = rc.Get<GameObject>("ButtonPack");
            self.ButtonPack.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhengLi().Coroutine(); });

            self.ButtonTakeOutAll = rc.Get<GameObject>("ButtonTakeOutAll");
            self.ButtonTakeOutAll.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonTakeOutAll().Coroutine(); });

            self.ButtonOneKey = rc.Get<GameObject>("ButtonOneKey");
            self.ButtonOneKey.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonOneKey().Coroutine(); });

            self.BuildingList1 = rc.Get<GameObject>("BuildingList1");
            self.BuildingList2 = rc.Get<GameObject>("BuildingList2");

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
            self.JiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent pageButton = uiPage.AddComponent<UIPageButtonComponent>();
            self.UIPageComponent = pageButton;
            pageButton.CheckHandler = self.CheckPageButton;
            pageButton.SetClickHandler(self.OnClickPageButton);
            self.UIPageComponent.ClickEnabled = false;

            self.InitBagCell().Coroutine();

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);
            DataUpdateComponent.Instance.AddListener(DataType.BuyBagCell, self);
        }

        public static bool CheckPageButton(this UIJiaYuanTreasureMapStorageComponent self, int page)
        {
            return true;
        }

        public static void OnClickPageButton(this UIJiaYuanTreasureMapStorageComponent self, int page)
        {
            int itemType = self.UIPageComponent.GetCurrentIndex();
            self.BagComponent.CurrentHouse = itemType + (int)ItemLocType.JianYuanTreasureMapStorage1;

            // 点击类别后会自动刷新仓库物品和背包物品
            self.UpdateStorage();
            self.UpdateBagList();
        }

        public static async ETTask OnBtn_ZhengLi(this UIJiaYuanTreasureMapStorageComponent self)
        {
            int currentHouse = self.UIPageComponent.GetCurrentIndex() + (int)ItemLocType.JianYuanWareHouse1;
            await self.ZoneScene().GetComponent<BagComponent>().SendSortByLoc((ItemLocType)currentHouse);
            self.UpdateStorage();
        }

        /// <summary>
        /// 一键取出
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask OnButtonTakeOutAll(this UIJiaYuanTreasureMapStorageComponent self)
        {
            C2M_TakeOutAllRequest request = new C2M_TakeOutAllRequest() { HorseId = self.BagComponent.CurrentHouse };
            M2C_TakeOutAllResponse response = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_TakeOutAllResponse;
        }

        public static async ETTask OnButtonOneKey(this UIJiaYuanTreasureMapStorageComponent self)
        {
            C2M_JiaYuanStoreRequest request = new C2M_JiaYuanStoreRequest() { HorseId = self.BagComponent.CurrentHouse };
            M2C_JiaYuanStoreResponse response =
                    (M2C_JiaYuanStoreResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
        }

        /// <summary>
        /// 初始化仓库、背包格子
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask InitBagCell(this UIJiaYuanTreasureMapStorageComponent self)
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

            int storageNumber = GlobalValueConfigCategory.Instance.StoreCapacity;
            for (int i = 0; i < storageNumber; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList1);

                UIItemComponent uiitem = self.AddChild<UIItemComponent, GameObject>(go);
                uiitem.Image_Lock.GetComponent<Button>().onClick.AddListener(self.OnClickImage_Lock);
                self.StorageList.Add(uiitem);
            }

            self.UIPageComponent.ClickEnabled = true;
            self.UIPageComponent.OnSelectIndex(0);
        }

        /// <summary>
        /// 刷新仓库道具
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateStorage(this UIJiaYuanTreasureMapStorageComponent self)
        {
            int curindex = self.UIPageComponent.GetCurrentIndex();

            List<BagInfo> bagInfos = self.BagComponent.GetItemsByLoc(curindex + ItemLocType.JianYuanTreasureMapStorage1);
            for (int i = 0; i < self.StorageList.Count; i++)
            {
                if (i < bagInfos.Count)
                {
                    self.StorageList[i].UpdateItem(bagInfos[i], ItemOperateEnum.Cangku);
                }
                else
                {
                    self.StorageList[i].UpdateItem(null, ItemOperateEnum.None);
                }
            }
        }

        /// <summary>
        /// 刷新背包道具
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateBagList(this UIJiaYuanTreasureMapStorageComponent self)
        {
            List<BagInfo> bagInfos = self.BagComponent.GetItemsByLoc(ItemLocType.ItemLocBag);

            List<BagInfo> treasureMapList = new List<BagInfo>();
            if (self.UIPageComponent.CurrentIndex == 0)
            {
                treasureMapList = ItemHelper.GetTreasureMapList(bagInfos);
            }
            else if (self.UIPageComponent.CurrentIndex == 1)
            {
                treasureMapList = ItemHelper.GetTreasureMapList2(bagInfos);
            }

            for (int i = 0; i < self.BagList.Count; i++)
            {
                if (i >= treasureMapList.Count)
                {
                    continue;
                }

                self.BagList[i].UpdateItem(treasureMapList[i], ItemOperateEnum.CangkuBag);
            }

            for (int i = treasureMapList.Count; i < self.BagList.Count; i++)
            {
                self.BagList[i].UpdateItem(null, ItemOperateEnum.None);
            }
        }

        public static void OnUpdateUI(this UIJiaYuanTreasureMapStorageComponent self)
        {
            if (self.StorageList.Count < GlobalValueConfigCategory.Instance.StoreCapacity)
            {
                return;
            }

            self.UpdateStorage();
            self.UpdateBagList();
        }

        public static void OnClickImage_Lock(this UIJiaYuanTreasureMapStorageComponent self)
        {
            // //int curindex = self.UIPageComponent.GetCurrentIndex();
            // string costitems = GlobalValueConfigCategory.Instance.Get(83).Value;
            // PopupTipHelp.OpenPopupTip(self.ZoneScene(), "购买格子",
            //     $"是否花费{UICommonHelper.GetNeedItemDesc(costitems)}购买一个背包格子?", () => { }, null).Coroutine();
            // return;
        }

        public static void Destroy(this UIJiaYuanTreasureMapStorageComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.BuyBagCell, self);
        }
    }
}