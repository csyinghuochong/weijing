using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanDaShiShowComponent : Entity, IAwake
    {
        public GameObject BuildingList1;
    }

    public class UIJiaYuanDaShiShowComponentAwake : AwakeSystem<UIJiaYuanDaShiShowComponent>
    {
        public override void Awake(UIJiaYuanDaShiShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BuildingList1 = rc.Get<GameObject>("BuildingList1");

            self.OnUpdateUI();
        }
    }

    public static class UIJiaYuanDaShiShowComponentSystem
    {
        public static void OnUpdateUI(this UIJiaYuanDaShiShowComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanDaShiShowItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < 2; i++)
            {
                GameObject gameObject = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(gameObject, self.BuildingList1);
            }
        }
    }
}