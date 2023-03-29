using ET;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [ObjectSystem]
    public class JiaYuanPlanLockComponentAwake : AwakeSystem<JiaYuanPlanLockComponent, GameObject>
    {
        public override void Awake(JiaYuanPlanLockComponent self, GameObject gameObject)
        {
            self.HeadBar = null;
            self.GameObject = gameObject;
            self.UICamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            self.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();

            self.OnInitUI();
        }
    }

    [ObjectSystem]
    public class JiaYuanPlanLockComponentDestroy : DestroySystem<JiaYuanPlanLockComponent>
    {
        public override void Destroy(JiaYuanPlanLockComponent self)
        {
            if (self.HeadBar != null)
            {
                GameObject.Destroy(self.HeadBar);
                self.HeadBar = null;
            }
        }
    }

    public static class JiaYuanPlanLockComponentSystem
    {
        public static void OnInitUI(this JiaYuanPlanLockComponent self)
        {
            self.UIPosition = self.GameObject.transform;
            string path = ABPathHelper.GetUGUIPath("Battle/UIEnergyTable");
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            self.HeadBar = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            self.HeadBar.transform.SetParent(UIEventComponent.Instance.UILayers[(int)UILayer.Blood]);
            self.HeadBar.transform.localScale = Vector3.one;
            if (self.HeadBar.GetComponent<HeadBarUI>() == null)
            {
                self.HeadBar.AddComponent<HeadBarUI>();
            }
            self.HeadBarUI = self.HeadBar.GetComponent<HeadBarUI>();
            self.HeadBarUI.HeadPos = self.UIPosition;
            self.HeadBarUI.HeadBar = self.HeadBar;
            self.HeadBar.transform.SetAsFirstSibling();

            self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<TextMeshProUGUI>().text = "未开启";
            self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = String.Empty;
        }
    }

}