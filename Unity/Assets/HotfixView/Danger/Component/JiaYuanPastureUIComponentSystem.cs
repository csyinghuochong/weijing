using ET;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.JiaYuanPastureTimer)]
    public class JiaYuanPastureTimer : ATimer<JiaYuanPastureUIComponent>
    {
        public override void Run(JiaYuanPastureUIComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class JiaYuanPastureUIComponentAwake : AwakeSystem<JiaYuanPastureUIComponent>
    {
        public override void Awake(JiaYuanPastureUIComponent self)
        {
            self.HeadBar = null;
            self.PlanStage = -1;
            self.MyUnit = self.GetParent<Unit>();
            self.UICamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            self.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.JiaYuanPastureTimer, self);
            self.OnInitUI().Coroutine();
        }
    }

    [ObjectSystem]
    public class JiaYuanPastureUIComponentDestroy : DestroySystem<JiaYuanPastureUIComponent>
    {
        public override void Destroy(JiaYuanPastureUIComponent self)
        {
            if (self.HeadBar != null)
            {
                GameObject.Destroy(self.HeadBar);
                self.HeadBar = null;
            }
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class JiaYuanPastureUIComponentSystem
    {
        public static async ETTask OnInitUI(this JiaYuanPastureUIComponent self)
        {
            self.PlanStage = 0;
            string path = ABPathHelper.GetUGUIPath("Battle/UIEnergyTable");
            self.UIPosition = self.MyUnit.GetComponent<GameObjectComponent>().GameObject.transform.Find("NamePosi");
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
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

            self.NumericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            int configId = self.MyUnit.ConfigId;
            JiaYuanPastureConfig jiaYuanFarmConfig = JiaYuanPastureConfigCategory.Instance.Get(configId);
            self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<TextMeshProUGUI>().text = jiaYuanFarmConfig.Name;
            self.OnUpdateUI();
        }

        public static void OnTimer(this JiaYuanPastureUIComponent self)
        {
            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this JiaYuanPastureUIComponent self)
        {
            if (self.HeadBar == null)
            {
                return;
            }
            NumericComponent numericComponent = self.NumericComponent;
            long startTime = numericComponent.GetAsLong(NumericType.StartTime);
            int gatherTime = numericComponent.GetAsInt(NumericType.GatherNumber);
            int stage = JiaYuanHelper.GetPastureState(self.GetParent<Unit>().ConfigId, startTime, gatherTime);
            if (self.PlanStage == stage)
            {
                return;
            }
            self.PlanStage = stage;
            self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = JiaYuanHelper.GetPlanStageName(stage);
        }
    }

}
