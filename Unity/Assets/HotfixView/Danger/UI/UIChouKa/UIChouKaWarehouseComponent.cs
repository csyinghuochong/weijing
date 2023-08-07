using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    /// <summary>
    /// 抽卡仓库
    /// </summary>
    public class UIChouKaWarehouseComponent: Entity, IAwake, IDestroy
    {
        /// <summary>
        /// 一键取出按钮
        /// </summary>
        public GameObject ButtonTakeOutAll;

        /// <summary>
        /// 一键出售
        /// </summary>
        public GameObject ButtonSell;

        /// <summary>
        /// 整理背包
        /// </summary>
        public GameObject ButtonZhengLi;

        /// <summary>
        /// 仓库列表
        /// </summary>
        public GameObject BuildingList1;

        /// <summary>
        /// 背包列表
        /// </summary>
        public GameObject BuildingList2;

        public BagComponent BagComponent;

        public List<UIItemComponent> BagList = new List<UIItemComponent>();
        public List<UIItemComponent> StorageList = new List<UIItemComponent>();
    }

    public class UIChouKaWarehouseComponentAwakeSystem: AwakeSystem<UIChouKaWarehouseComponent>
    {
        public override void Awake(UIChouKaWarehouseComponent self)
        {
            self.Awake();
        }
    }

    public class UIChouKaWarehouseComponentDestroySystem: DestroySystem<UIChouKaWarehouseComponent>
    {
        public override void Destroy(UIChouKaWarehouseComponent self)
        {
            self.Destroy();
        }
    }

    public static class UIChouKaWarehouseComponentSystem
    {
        public static void Awake(this UIChouKaWarehouseComponent self)
        {
            self.BagList.Clear();
            self.StorageList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonTakeOutAll = rc.Get<GameObject>("ButtonTakeOutAll");
            self.ButtonTakeOutAll.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonTakeOutAll().Coroutine(); });

            self.ButtonSell = rc.Get<GameObject>("ButtonSell");
            self.ButtonSell.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonSell(); });

            self.ButtonZhengLi = rc.Get<GameObject>("ButtonZhengLi");
            self.ButtonZhengLi.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonZhengLi().Coroutine(); });

            self.BuildingList1 = rc.Get<GameObject>("BuildingList1");
            self.BuildingList2 = rc.Get<GameObject>("BuildingList2");

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);

            self.InitBagCell().Coroutine();
        }

        public static void Destroy(this UIChouKaWarehouseComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
        }

        public static async ETTask OnButtonTakeOutAll(this UIChouKaWarehouseComponent self)
        {
            C2M_TakeOutAllRequest request = new C2M_TakeOutAllRequest() { HorseId = (int)ItemLocType.ChouKaWarehouse };
            M2C_TakeOutAllResponse response = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_TakeOutAllResponse;
        }

        public static void OnButtonSell(this UIChouKaWarehouseComponent self)
        {
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "一键出售", "是否一键出售低品质装备和宝石,出售品质可以在设置中进行选择",
                () => { self.BagComponent.RequestOneSell(ItemLocType.ChouKaWarehouse).Coroutine(); }, null).Coroutine();
        }

        public static async ETTask OnButtonZhengLi(this UIChouKaWarehouseComponent self)
        {
            await self.ZoneScene().GetComponent<BagComponent>().SendSortByLoc(ItemLocType.ChouKaWarehouse);
            self.UpdateStorage();
        }

        /// <summary>
        /// 初始化仓库、背包格子
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask InitBagCell(this UIChouKaWarehouseComponent self)
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

            // 上限100
            int storageNumber = 100;
            for (int i = 0; i < storageNumber; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList1);

                UIItemComponent uiitem = self.AddChild<UIItemComponent, GameObject>(go);
                self.StorageList.Add(uiitem);
            }

            self.OnUpdateUI();
        }

        /// <summary>
        /// 刷新UI信息
        /// </summary>
        /// <param name="self"></param>
        public static void OnUpdateUI(this UIChouKaWarehouseComponent self)
        {
            self.UpdateStorage();
            self.UpdateBagList();
        }

        /// <summary>
        /// 刷新仓库道具
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateStorage(this UIChouKaWarehouseComponent self)
        {
            List<BagInfo> bagInfos = self.BagComponent.GetItemsByLoc(ItemLocType.ChouKaWarehouse);
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
        public static void UpdateBagList(this UIChouKaWarehouseComponent self)
        {
            List<BagInfo> bagInfos = self.BagComponent.GetItemsByLoc(ItemLocType.ItemLocBag);
            for (int i = 0; i < self.BagList.Count; i++)
            {
                if (i < bagInfos.Count)
                {
                    self.BagList[i].UpdateItem(bagInfos[i], ItemOperateEnum.Muchang);
                }
                else
                {
                    self.BagList[i].UpdateItem(null, ItemOperateEnum.None);
                }
            }
        }
    }
}