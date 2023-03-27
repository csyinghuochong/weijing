using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanMenuComponent : Entity, IAwake
    {
        public GameObject Button_Gather_2;
        public GameObject Button_Uproot;
        public GameObject Button_Gather;
        public GameObject Button_Watch;
        public GameObject Button_Plan;
        public GameObject PositionSet;
        public GameObject ImageDi;
        public GameObject ImageBg;

        public long UnitId;
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

            self.Button_Plan = rc.Get<GameObject>("Button_Plan");
            self.Button_Plan.GetComponent<Button>().onClick.AddListener(self.OnButton_Plan);

            self.Button_Watch = rc.Get<GameObject>("Button_Watch");
            self.Button_Watch.GetComponent<Button>().onClick.AddListener(self.OnButton_Watch);

            self.Button_Gather = rc.Get<GameObject>("Button_Gather");
            self.Button_Gather.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Gather().Coroutine(); });

            self.Button_Uproot = rc.Get<GameObject>("Button_Uproot");
            self.Button_Uproot.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Uproot().Coroutine(); });

            self.Button_Gather_2 = rc.Get<GameObject>("Button_Gather_2");
            self.Button_Gather_2.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Gather_2().Coroutine(); });

            self.PositionSet = rc.Get<GameObject>("PositionSet");
        }
    }

    public static class UIJiaYuanMenuComponentSystem
    {

        public static void OnUpdatePasture(this UIJiaYuanMenuComponent self, Unit unit)
        {
            Vector2 localPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].GetComponent<RectTransform>();

            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, Input.mousePosition, uiCamera, out localPoint);
            self.PositionSet.transform.localPosition = new Vector3(localPoint.x, localPoint.y + 70F, 0f);

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long startTime = numericComponent.GetAsLong(NumericType.StartTime);
            int gatherNumber = numericComponent.GetAsInt(NumericType.GatherNumber);
            long GatherLastTime = numericComponent.GetAsLong(NumericType.GatherLastTime);
            int getcode = JiaYuanHelper.GetPastureShouHuoItem(unit.ConfigId, startTime, gatherNumber, GatherLastTime);
            self.UnitId = unit.Id;
            self.Button_Watch.SetActive(false);
            self.Button_Uproot.SetActive(false);
            self.Button_Plan.SetActive(false);
            self.Button_Gather.SetActive(false);
            self.Button_Gather_2.SetActive(getcode == ErrorCore.ERR_Success);
        }

        public static void OnUpdatePlan(this UIJiaYuanMenuComponent self)
        {
            Vector2 localPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].GetComponent<RectTransform>();
            //gameObject.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, Input.mousePosition, uiCamera, out localPoint);
            self.PositionSet.transform.localPosition = new Vector3(localPoint.x, localPoint.y + 70F, 0f);

            JiaYuanViewComponent jiaYuanViewComponent = self.ZoneScene().CurrentScene().GetComponent<JiaYuanViewComponent>();
            Unit unit = JiaYuanHelper.GetUnitByCellIndex(self.ZoneScene().CurrentScene(), jiaYuanViewComponent.CellIndex);
           
            self.Button_Watch.SetActive(unit != null);
            self.Button_Uproot.SetActive(unit != null);
            self.Button_Plan.SetActive(unit == null);
            self.Button_Gather_2.SetActive(false);
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

        public static async ETTask OnButton_Uproot(this UIJiaYuanMenuComponent self)
        {
            Scene zoneScene = self.ZoneScene();
            JiaYuanViewComponent jiaYuanViewComponent = self.ZoneScene().CurrentScene().GetComponent<JiaYuanViewComponent>();
            Unit unit = JiaYuanHelper.GetUnitByCellIndex(self.ZoneScene().CurrentScene(), jiaYuanViewComponent.CellIndex);
            if (unit == null)
            {
                return;
            }

            C2M_JiaYuanUprootRequest request = new C2M_JiaYuanUprootRequest() { CellIndex = jiaYuanViewComponent.CellIndex, UnitId = unit.Id };
            M2C_JiaYuanUprootResponse response = (M2C_JiaYuanUprootResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            UIHelper.Remove(zoneScene, UIType.UIJiaYuanMenu);
        }

        public static async ETTask OnButton_Gather_2(this UIJiaYuanMenuComponent self)
        {
            Scene zoneScene = self.ZoneScene();

            C2M_JiaYuanGatherRequest request = new C2M_JiaYuanGatherRequest() {  UnitId = unit.Id, OperateType = 2 };
            M2C_JiaYuanGatherResponse response = (M2C_JiaYuanGatherResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            UIHelper.Remove(zoneScene, UIType.UIJiaYuanMenu);
        }

        public static async ETTask OnButton_Gather(this UIJiaYuanMenuComponent self)
        {
            Scene zoneScene = self.ZoneScene();
           
            JiaYuanViewComponent jiaYuanViewComponent = self.ZoneScene().CurrentScene().GetComponent<JiaYuanViewComponent>();
            Unit unit = JiaYuanHelper.GetUnitByCellIndex(self.ZoneScene().CurrentScene(), jiaYuanViewComponent.CellIndex);
            if (unit == null)
            {
                return;
            }

            C2M_JiaYuanGatherRequest  request = new C2M_JiaYuanGatherRequest() { CellIndex = jiaYuanViewComponent.CellIndex,UnitId = unit.Id, OperateType = 1 };
            M2C_JiaYuanGatherResponse response = (M2C_JiaYuanGatherResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            UIHelper.Remove(zoneScene, UIType.UIJiaYuanMenu);
        }

        public static void OnButton_Plan(this UIJiaYuanMenuComponent self)
        {
            Scene zonescene = self.ZoneScene();
            UIHelper.Create(zonescene, UIType.UIJiaYuanBag).Coroutine();
            UIHelper.Remove(zonescene, UIType.UIJiaYuanMenu);
        }
    }
}
