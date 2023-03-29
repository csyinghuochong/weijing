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

            if (self.PlanEffectObj != null)
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(self.PlanEffectPath, self.PlanEffectObj, false);
                self.PlanEffectObj = null;
            }
        }
    }

    public static class JiaYuanPlanLockComponentSystem
    {

        public static void SetOpenState(this JiaYuanPlanLockComponent self, int index, bool open)
        {
            self.CellIndex = index;
            if (self.HeadBar != null)
            {
                GameObject.Destroy(self.HeadBar);
                self.HeadBar = null;
            }

            if (open)
            {
                self.InitEffect();
            }
            else
            {
                self.InitHeadBar();
            }
        }

        public static void InitEffect(this JiaYuanPlanLockComponent self)
        {
            self.PlanEffectPath = ABPathHelper.GetEffetPath($"ScenceEffect/Eff_JiaYuan_Zhong");
            GameObjectPoolComponent.Instance.AddLoadQueue(self.PlanEffectPath, self.InstanceId, self.OnLoadEffect);
        }

        public static void OnLoadEffect(this JiaYuanPlanLockComponent self, GameObject go, long formId)
        {
            if (self.IsDisposed)
            {
                GameObject.Destroy(go);
                return;
            }

            self.PlanEffectObj = go;
            UICommonHelper.SetParent(go, GlobalComponent.Instance.Unit.gameObject);
            go.transform.localPosition = JiaYuanHelper.PlanPositionList[self.CellIndex];
            go.transform.localScale = Vector3.one;
            go.SetActive(true);
        }

        public static void InitHeadBar(this JiaYuanPlanLockComponent self)
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