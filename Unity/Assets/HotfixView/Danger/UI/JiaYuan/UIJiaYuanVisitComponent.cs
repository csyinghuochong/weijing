using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    public  class UIJiaYuanVisitComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextLimit;
        public GameObject FunctionSetBtn;
        public GameObject BuildingList2;

        public GameObject GameObject;
        public UIPageButtonComponent UIPageButton;

        public float LastTime;
    }

    public class UIJiaYuaVisitComponentAwake : AwakeSystem<UIJiaYuanVisitComponent, GameObject>
    {
        public override void Awake(UIJiaYuanVisitComponent self, GameObject a)
        {
            self.GameObject = a;
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.TextLimit = rc.Get<GameObject>("TextLimit");
            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");

            self.BuildingList2 = rc.Get<GameObject>("BuildingList2");

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

        public static async ETTask ToggleShow(this UIJiaYuanVisitComponent self)
        {
            self.GameObject.SetActive(!self.GameObject.activeSelf);
            if (!self.GameObject.activeSelf)
            {
                return;
            }
            if (Time.time - self.LastTime < 2f)
            {
                return;
            }
            self.LastTime = Time.time;
            C2M_JiaYuanVisitListRequest  request    = new C2M_JiaYuanVisitListRequest() { };
            M2C_JiaYuanVisitListResponse response = (M2C_JiaYuanVisitListResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

        }

        public static void OnClickPageButton(this UIJiaYuanVisitComponent self, int page)
        {
            
        }
    }
}
