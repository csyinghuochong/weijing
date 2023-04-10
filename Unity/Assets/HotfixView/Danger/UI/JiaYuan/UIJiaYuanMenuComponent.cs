using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanMenuComponent : Entity, IAwake
    {

        public GameObject Button_Open;
        public GameObject Button_Sell;
        public GameObject Button_Uproot;
        public GameObject Button_Gather;
        public GameObject Button_Watch;
        public GameObject Button_Plan;
        public GameObject PositionSet;
        public GameObject ImageDi;
        public GameObject ImageBg;
        public GameObject ImageBg_1;

        public long UnitId;
        public int OperateType;
    }

    [ObjectSystem]
    public class UIJiaYuanMenuComponentAwake : AwakeSystem<UIJiaYuanMenuComponent>
    {
        public override void Awake(UIJiaYuanMenuComponent self)
        {
            self.UnitId = 0;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageBg = rc.Get<GameObject>("ImageBg");
            self.ImageBg.GetComponent<Button>().onClick.AddListener(self.OnBtn_ImageBg);

            self.ImageBg_1 = rc.Get<GameObject>("ImageBg_1");
            self.ImageBg_1.GetComponent<Button>().onClick.AddListener(self.OnBtn_ImageBg);
            
            self.Button_Plan = rc.Get<GameObject>("Button_Plan");
            self.Button_Plan.GetComponent<Button>().onClick.AddListener(self.OnButton_Plan);

            self.Button_Watch = rc.Get<GameObject>("Button_Watch");
            self.Button_Watch.GetComponent<Button>().onClick.AddListener(self.OnButton_Watch);

            self.Button_Gather = rc.Get<GameObject>("Button_Gather");
            self.Button_Gather.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Gather().Coroutine(); });

            self.Button_Uproot = rc.Get<GameObject>("Button_Uproot");
            self.Button_Uproot.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Uproot().Coroutine(); });

            self.Button_Sell = rc.Get<GameObject>("Button_Sell");
            self.Button_Sell.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Sell().Coroutine(); });

            self.Button_Open = rc.Get<GameObject>("Button_Open");
            self.Button_Open.SetActive(false);

            self.PositionSet = rc.Get<GameObject>("PositionSet");
        }
    }

    public static class UIJiaYuanMenuComponentSystem
    {

        public static void OnUpdatePasture(this UIJiaYuanMenuComponent self, Unit unit)
        {
            self.OperateType = 2;
            Unit mainunit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            bool ismyJiayuan = self.ZoneScene().GetComponent<JiaYuanComponent>().IsMyJiaYuan(mainunit.Id);
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].GetComponent<RectTransform>();

            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            Camera mainCamera = self.DomainScene().GetComponent<UIComponent>().MainCamera;
            Vector2 OldPosition = WorldPosiToUIPos.WorldPosiToUIPosition(unit.Position, self.GetParent<UI>().GameObject, uiCamera, mainCamera, false);
            Vector3 NewPosition = Vector3.zero;
            NewPosition.x = OldPosition.x;
            NewPosition.y = OldPosition.y;
            //RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, Input.mousePosition, uiCamera, out localPoint);
            self.PositionSet.transform.localPosition = NewPosition;

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long startTime = numericComponent.GetAsLong(NumericType.StartTime);
            int gatherNumber = numericComponent.GetAsInt(NumericType.GatherNumber);
            long GatherLastTime = numericComponent.GetAsLong(NumericType.GatherLastTime);
            int getcode = JiaYuanHelper.GetPastureShouHuoItem(unit.ConfigId, startTime, gatherNumber, GatherLastTime);
            self.UnitId = unit.Id;
            self.Button_Watch.SetActive(false);
            self.Button_Uproot.SetActive(false);
            self.Button_Plan.SetActive(false);
            self.Button_Sell.SetActive(true && ismyJiayuan);
            self.Button_Gather.SetActive(getcode == ErrorCore.ERR_Success);
        }

        public static void OnUpdatePlan(this UIJiaYuanMenuComponent self)
        {
            self.OperateType = 1;
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIJiaYuanMain);
            UIJiaYuanMainComponent jiaYuanViewComponent = uI.GetComponent<UIJiaYuanMainComponent>();
            Unit unit = JiaYuanHelper.GetUnitByCellIndex(self.ZoneScene().CurrentScene(), jiaYuanViewComponent.CellIndex);

            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].GetComponent<RectTransform>();
            //gameObject.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            Camera mainCamera = self.DomainScene().GetComponent<UIComponent>().MainCamera;
            Vector2 OldPosition = WorldPosiToUIPos.WorldPosiToUIPosition(JiaYuanHelper.PlanPositionList[jiaYuanViewComponent.CellIndex], self.GetParent<UI>().GameObject, uiCamera, mainCamera, false);
            Vector3 NewPosition = Vector3.zero;
            NewPosition.x = OldPosition.x;
            NewPosition.y = OldPosition.y;
            //RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, Input.mousePosition, uiCamera, out localPoint);
            self.PositionSet.transform.localPosition = NewPosition;

            Unit mainunit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            bool ismyJiayuan = self.ZoneScene().GetComponent<JiaYuanComponent>().IsMyJiaYuan(mainunit.Id);
            self.Button_Watch.SetActive(ismyJiayuan && unit != null);
            self.Button_Uproot.SetActive(ismyJiayuan && unit != null);
            self.Button_Plan.SetActive(ismyJiayuan && unit == null);
            self.Button_Sell.SetActive(false);
            if (unit != null)
            {
                self.UnitId = unit.Id;
                NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                long startTime = numericComponent.GetAsLong(NumericType.StartTime);
                int gatherNumber = numericComponent.GetAsInt(NumericType.GatherNumber);
                long gatherLastTime = numericComponent.GetAsLong(NumericType.GatherLastTime);
                self.Button_Gather.SetActive(JiaYuanHelper.GetPlanShouHuoItem(unit.ConfigId, startTime, gatherNumber, gatherLastTime) == ErrorCore.ERR_Success);
            }
            else
            {
                self.UnitId = 0;
                self.Button_Gather.SetActive(false);
            }
        }

        public static void OnBtn_ImageBg(this UIJiaYuanMenuComponent self)
        {
            Scene zonescene = self.ZoneScene();
            UIHelper.Remove(zonescene, UIType.UIJiaYuanMenu);
        }

        public static void OnButton_Watch(this UIJiaYuanMenuComponent self)
        {
            Scene zonescene = self.ZoneScene();
            UIHelper.Create(zonescene, UIType.UIJiaYuanPlanWatch).Coroutine();
            UIHelper.Remove(zonescene, UIType.UIJiaYuanMenu);
        }

        public static async ETTask OnButton_Sell(this UIJiaYuanMenuComponent self)
        {
            Scene zoneScene = self.ZoneScene();
            C2M_JiaYuanUprootRequest request = new C2M_JiaYuanUprootRequest() {  UnitId = self.UnitId, OperateType = 2 };
            M2C_JiaYuanUprootResponse response = (M2C_JiaYuanUprootResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            UIHelper.Remove(zoneScene, UIType.UIJiaYuanMenu);

            if (response.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            zoneScene.GetComponent<JiaYuanComponent>().JiaYuanPastureList_7 = response.JiaYuanPastureList;
        }

        public static async ETTask OnButton_Uproot(this UIJiaYuanMenuComponent self)
        {
            Scene zoneScene = self.ZoneScene();
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIJiaYuanMain);
            UIJiaYuanMainComponent jiaYuanViewComponent = uI.GetComponent<UIJiaYuanMainComponent>();
            Unit unit = JiaYuanHelper.GetUnitByCellIndex(self.ZoneScene().CurrentScene(), jiaYuanViewComponent.CellIndex);
            if (unit == null)
            {
                return;
            }

            C2M_JiaYuanUprootRequest request = new C2M_JiaYuanUprootRequest() { CellIndex = jiaYuanViewComponent.CellIndex, UnitId = unit.Id, OperateType = 1 };
            M2C_JiaYuanUprootResponse response = (M2C_JiaYuanUprootResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            UIHelper.Remove(zoneScene, UIType.UIJiaYuanMenu);
        }

        public static async ETTask OnButton_Gather(this UIJiaYuanMenuComponent self)
        {
            Scene zoneScene = self.ZoneScene();
            Unit mainunit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            bool isMyjiayuan = (self.ZoneScene().GetComponent<JiaYuanComponent>().IsMyJiaYuan(mainunit.Id));

            switch (self.OperateType)
            {
                case 1:
                    UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIJiaYuanMain);
                    UIJiaYuanMainComponent jiaYuanViewComponent = uI.GetComponent<UIJiaYuanMainComponent>();
                    Unit unit = JiaYuanHelper.GetUnitByCellIndex(self.ZoneScene().CurrentScene(), jiaYuanViewComponent.CellIndex);
                    if (unit == null)
                    {
                        return;
                    }
                    
                    C2M_JiaYuanGatherRequest request = new C2M_JiaYuanGatherRequest() { CellIndex = jiaYuanViewComponent.CellIndex, UnitId = unit.Id, OperateType = 1 };
                    M2C_JiaYuanGatherResponse response = (M2C_JiaYuanGatherResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                    UIHelper.Remove(zoneScene, UIType.UIJiaYuanMenu);
                    break;
                case 2:
                    request = new C2M_JiaYuanGatherRequest() { UnitId = self.UnitId, OperateType = 2 };
                    response = (M2C_JiaYuanGatherResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                    UIHelper.Remove(zoneScene, UIType.UIJiaYuanMenu);
                    break;
                default:
                    break;
            }
        }

        public static void OnButton_Plan(this UIJiaYuanMenuComponent self)
        {
            Scene zonescene = self.ZoneScene();
            UIHelper.Create(zonescene, UIType.UIJiaYuanBag).Coroutine();
            UIHelper.Remove(zonescene, UIType.UIJiaYuanMenu);
        }
    }
}
