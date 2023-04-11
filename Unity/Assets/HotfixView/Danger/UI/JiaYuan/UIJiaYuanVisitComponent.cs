using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public  class UIJiaYuanVisitComponent : Entity, IAwake<GameObject>
    {
        public GameObject ButtonRefresh;
        public GameObject TextLimit;
        public GameObject FunctionSetBtn;
        public GameObject BuildingList2;

        public GameObject GameObject;
        public UIPageButtonComponent UIPageButton;

        public M2C_JiaYuanVisitListResponse m2C_JiaYuanVisitList;
        public List<UIJiaYuanVisitItemComponent> VisitItemList = new List<UIJiaYuanVisitItemComponent>();

        public float LastTime;
    }

    public class UIJiaYuaVisitComponentAwake : AwakeSystem<UIJiaYuanVisitComponent, GameObject>
    {
        public override void Awake(UIJiaYuanVisitComponent self, GameObject a)
        {
            self.GameObject = a;
            self.VisitItemList.Clear();
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.TextLimit = rc.Get<GameObject>("TextLimit");
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");

            self.BuildingList2 = rc.Get<GameObject>("BuildingList2");

            self.ButtonRefresh = rc.Get<GameObject>("ButtonRefresh");


            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI pageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);

            self.UIPageButton = pageButton.AddComponent<UIPageButtonComponent>();
            self.UIPageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton.OnSelectIndex(0);
        }
    }

    public static class UIJiaYuaVisitComponentSystem
    {

        public static async ETTask OnInitUI(this UIJiaYuanVisitComponent self, int operateType)
        {
            if (Time.time - self.LastTime < 2f)
            {
                return;
            }
            self.LastTime = Time.time;
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            C2M_JiaYuanVisitListRequest  request    = new C2M_JiaYuanVisitListRequest() { MasterId = jiaYuanComponent.MasterId, UnitId = unit.Id,OperateType = operateType  };
            M2C_JiaYuanVisitListResponse response = (M2C_JiaYuanVisitListResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.m2C_JiaYuanVisitList = response;
            Log.ILog.Debug($"UIJiaYuanVisitComponent: {response.JiaYuanVisit_1.Count} {response.JiaYuanVisit_2.Count}");
            self.OnClickPageButton(self.UIPageButton.CurrentIndex);
        }

        public static void  OnButtonRefresh(this UIJiaYuanVisitComponent self)
        {
            self.OnInitUI(1).Coroutine();
        }

        public static void OnClickPageButton(this UIJiaYuanVisitComponent self, int page)
        {
            if (self.m2C_JiaYuanVisitList == null)
            {
                return;
            }

            var path = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanVisitItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<JiaYuanVisit> visits = page == 1 ? self.m2C_JiaYuanVisitList.JiaYuanVisit_1 : self.m2C_JiaYuanVisitList.JiaYuanVisit_2;
            for (int i = 0; i < visits.Count; i++)
            {
                UIJiaYuanVisitItemComponent ui_1 = null;
                if (i < self.VisitItemList.Count)
                {
                    ui_1 = self.VisitItemList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject gameObject = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent( gameObject, self.BuildingList2 );
                    ui_1 = self.AddChild<UIJiaYuanVisitItemComponent, GameObject>(gameObject);
                    self.VisitItemList.Add(ui_1);
                }

                ui_1.OnUpdateUI(visits[i]);
            }
            for (int i = visits.Count; i < self.VisitItemList.Count; i++)
            {
                self.VisitItemList[i].GameObject.SetActive(false);
            }

            self.UpdateGatherTimes();
        }

        public static void UpdateGatherTimes(this UIJiaYuanVisitComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            self.TextLimit.GetComponent<Text>().text = $"采摘:{numericComponent.GetAsInt(NumericType.JiaYuanGatherOther)}/5\r\n打扫:{numericComponent.GetAsInt(NumericType.JiaYuanPickOther)}/5";
        }

    }
}
