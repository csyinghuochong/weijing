using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanMenuComponent : Entity, IAwake
    {
        public GameObject Button_Uproot;
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

            self.Button_Uproot = rc.Get<GameObject>("Button_Uproot");
            self.Button_Uproot.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Uproot().Coroutine(); });


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
            JiaYuanPlant jiaYuanPlant = jiaYuanComponent.GetCellPlant(jiaYuanComponent.CellIndex);
            self.Button_Watch.SetActive(jiaYuanPlant != null);
            self.Button_Uproot.SetActive(jiaYuanPlant != null);
            self.Button_Plan.SetActive(jiaYuanPlant == null);
            self.Button_Gather.SetActive(jiaYuanPlant!=null && JiaYuanHelper.GetShouHuoItem(jiaYuanPlant)== ErrorCore.ERR_Success);
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
            JiaYuanComponent jiaYuanComponent = zoneScene.GetComponent<JiaYuanComponent>();
            C2M_JiaYuanUprootRequest request = new C2M_JiaYuanUprootRequest() { CellIndex = jiaYuanComponent.CellIndex };
            M2C_JiaYuanUprootResponse response = (M2C_JiaYuanUprootResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            UIHelper.Remove(zoneScene, UIType.UIJiaYuanMenu);
        }

        public static async ETTask OnButton_Gather(this UIJiaYuanMenuComponent self)
        {
            Scene zoneScene = self.ZoneScene();
            JiaYuanComponent jiaYuanComponent = zoneScene.GetComponent<JiaYuanComponent>(); 
            C2M_JiaYuanGatherRequest  request = new C2M_JiaYuanGatherRequest() { CellIndex = jiaYuanComponent.CellIndex };
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
