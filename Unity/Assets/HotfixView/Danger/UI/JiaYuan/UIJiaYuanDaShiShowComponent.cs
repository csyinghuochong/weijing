using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanDaShiShowComponent : Entity, IAwake
    {
        public GameObject BuildingList1;

        public List<UIJiaYuanDaShiShowItemComponent> uIJiaYuanDaShis = new List<UIJiaYuanDaShiShowItemComponent>();
    }

    public class UIJiaYuanDaShiShowComponentAwake : AwakeSystem<UIJiaYuanDaShiShowComponent>
    {
        public override void Awake(UIJiaYuanDaShiShowComponent self)
        {
            self.uIJiaYuanDaShis.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BuildingList1 = rc.Get<GameObject>("BuildingList1");

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UIJiaYuanDaShiShowComponentSystem
    {
        public static void OnUpdateUI(this UIJiaYuanDaShiShowComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanDaShiShowItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            List<KeyValuePair> jiayuandashi = ConfigHelper.JiaYuanDaShiPro;
            for (int i = 0; i < jiayuandashi.Count; i++)
            {
                UIJiaYuanDaShiShowItemComponent ui_1 = null;
                if (i < self.uIJiaYuanDaShis.Count)
                {
                    ui_1 = self.uIJiaYuanDaShis[i];
                }
                else
                {
                    GameObject gameObject = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(gameObject, self.BuildingList1);
                    ui_1 = self.AddChild<UIJiaYuanDaShiShowItemComponent, GameObject>(gameObject);
                    self.uIJiaYuanDaShis.Add(ui_1);
                }
                ui_1.OnUpdateUI(jiayuandashi[i], jiaYuanComponent.JiaYuanDaShiTime_1);
            }
        }
    }
}