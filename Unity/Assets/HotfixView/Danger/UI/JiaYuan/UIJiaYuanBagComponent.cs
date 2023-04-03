using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanBagComponent : Entity, IAwake, IDestroy
    {
        public GameObject Btn_Plan;
        public GameObject ButtonClose;
        public GameObject BuildingList;

        public BagInfo BagInfo;
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();
    }

    [ObjectSystem]
    public class UIJiaYuanBagComponentAwake : AwakeSystem<UIJiaYuanBagComponent>
    {
        public override void Awake(UIJiaYuanBagComponent self)
        {
            self.BagInfo = null;

            ReferenceCollector rc  = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.BuildingList = rc.Get<GameObject>("BuildingList");

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIJiaYuanBag); });

            self.Btn_Plan = rc.Get<GameObject>("Btn_Plan");
            self.Btn_Plan.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Plan().Coroutine(); });

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);

            self.OnInitUI().Coroutine();
        }
    }

    [ObjectSystem]
    public class UIJiaYuanBagComponentDestroy : DestroySystem<UIJiaYuanBagComponent>
    {
        public override void Destroy(UIJiaYuanBagComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
        }
    }

    public static class UIJiaYuanBagComponentSystem
    {

        public static async ETTask OnBtn_Plan(this UIJiaYuanBagComponent self)
        {
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIJiaYuanMain);
            UIJiaYuanMainComponent jiaYuanViewComponent = uI.GetComponent<UIJiaYuanMainComponent>();
            Unit unit = JiaYuanHelper.GetUnitByCellIndex(self.ZoneScene().CurrentScene(), jiaYuanViewComponent.CellIndex);
            if (unit != null)
            {
                FloatTipManager.Instance.ShowFloatTip("当前土地有植物！");
                return;
            }
            try
            {
                C2M_JiaYuanPlantRequest request = new C2M_JiaYuanPlantRequest() { CellIndex = jiaYuanViewComponent.CellIndex, ItemId = self.BagInfo.ItemID };
                M2C_JiaYuanPlantResponse response = (M2C_JiaYuanPlantResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return;
            }
            if (self.IsDisposed) 
            {
                return;
            }
            UIHelper.Remove( self.ZoneScene(), UIType.UIJiaYuanBag );
        }


        public static async ETTask OnInitUI(this UIJiaYuanBagComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
         
            for (int i = 0; i < GlobalValueConfigCategory.Instance.BagMaxCapacity; i++)
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
                UICommonHelper.SetParent(go, self.BuildingList);

                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(go);
                uIItemComponent.SetClickHandler((BagInfo bInfo) => { self.OnClickHandler(bInfo); });
                uIItemComponent.UpdateItem(null, ItemOperateEnum.Bag);
                self.ItemUIlist.Add(uIItemComponent);
            }

            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIJiaYuanBagComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetItemsByType(2);

            int number = 0;
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemType != 2 || itemConfig.ItemSubType != 101)
                {
                    continue;
                }
   
                UIItemComponent uIItemComponent = self.ItemUIlist[number];
                BagInfo bagInfo = i < bagInfos.Count ? bagInfos[i] : null;
                uIItemComponent.UpdateItem(bagInfo, ItemOperateEnum.JianYuanBag);
                number++;   
            }
            for (int i = number; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[number].GameObject.SetActive(false);
            }
        }

        public static void OnClickHandler(this UIJiaYuanBagComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].SetSelected(bagInfo);
            }
        }
    }
}
