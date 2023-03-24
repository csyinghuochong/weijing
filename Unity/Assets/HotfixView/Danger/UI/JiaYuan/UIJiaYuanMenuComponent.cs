using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanMenuComponent : Entity, IAwake
    {
        public GameObject Button_Gather;
        public GameObject Button_Watch;
        public GameObject Button_Plan;
        public GameObject PositionSet;
        public GameObject ImageDi;
        public GameObject ImageBg;
    }

    [ObjectSystem]
    public class UIJiaYuanMenuComponentAwake : AwakeSystem<UIJiaYuanMenuComponent>
    {
        public override void Awake(UIJiaYuanMenuComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageBg = rc.Get<GameObject>("ImageBg");
            self.ImageBg.GetComponent<Button>().onClick.AddListener(self.OnBtn_ImageBg);

            self.Button_Plan = rc.Get<GameObject>("Button_Plan");
            self.Button_Plan.GetComponent<Button>().onClick.AddListener(self.OnButton_Plan);

            self.Button_Watch = rc.Get<GameObject>("Button_Watch");
            self.Button_Watch.GetComponent<Button>().onClick.AddListener(self.OnButton_Watch);

            self.Button_Gather = rc.Get<GameObject>("Button_Gather");
            self.Button_Gather.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Gather().Coroutine(); });

            self.PositionSet = rc.Get<GameObject>("PositionSet");

            self.OnUpdateUI();
        }
    }

    public static class UIJiaYuanMenuComponentSystem
    {
        public static void OnUpdateUI(this UIJiaYuanMenuComponent self)
        {
            Vector2 localPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].GetComponent<RectTransform>();
            //gameObject.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, Input.mousePosition, uiCamera, out localPoint);
            self.PositionSet.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
            //self.ImageDi.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
            //self.ImageDi.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(220, 0f);

            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            self.Button_Watch.SetActive(jiaYuanComponent.GetCellPlant(jiaYuanComponent.CellIndex)!=null);
            self.Button_Plan.SetActive(jiaYuanComponent.GetCellPlant(jiaYuanComponent.CellIndex)==null);
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

        public static async ETTask OnButton_Gather(this UIJiaYuanMenuComponent self)
        {
            Scene zonescene = self.ZoneScene();
            JiaYuanComponent jiaYuanComponent = zonescene.GetComponent<JiaYuanComponent>(); 
            C2M_JiaYuanGatherRequest  request = new C2M_JiaYuanGatherRequest() { CellIndex = jiaYuanComponent.CellIndex };
            M2C_JiaYuanGatherResponse response = (M2C_JiaYuanGatherResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            UIHelper.Remove(zonescene, UIType.UIJiaYuanMenu);
        }

        public static void OnButton_Plan(this UIJiaYuanMenuComponent self)
        {
            Scene zonescene = self.ZoneScene();
            UIHelper.Create(zonescene, UIType.UIJiaYuanBag).Coroutine();
            UIHelper.Remove(zonescene, UIType.UIJiaYuanMenu);
        }
    }
}
