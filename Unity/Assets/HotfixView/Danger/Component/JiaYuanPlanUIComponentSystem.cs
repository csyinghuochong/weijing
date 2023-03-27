using ET;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.JiaYuanPlanTimer)]
    public class JiaYuanPlanTimer : ATimer<JiaYuanPlanUIComponent>
    {
        public override void Run(JiaYuanPlanUIComponent self)
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
    public class JiaYuanPlanUIComponentAwake : AwakeSystem<JiaYuanPlanUIComponent>
    {
        public override void Awake(JiaYuanPlanUIComponent self)
        {
            self.HeadBar = null;
            self.PlanStage = -1;
            self.UICamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            self.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.JiaYuanPlanTimer, self);

            self.OnInitUI();
        }
    }

    [ObjectSystem]
    public class JiaYuanPlanUIComponentDestroy : DestroySystem<JiaYuanPlanUIComponent>
    {
        public override void Destroy(JiaYuanPlanUIComponent self)
        {
            if (self.HeadBar != null)
            {
                GameObject.Destroy(self.HeadBar);
                self.HeadBar = null;
            }
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class JiaYuanPlanUIComponentSystem
    {
        public static void OnInitUI(this JiaYuanPlanUIComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            self.NumericComponent = unit.GetComponent<NumericComponent>();
            self.PlanStage = self.GetPlanStage();

            self.UIPosition = unit.GetComponent<GameObjectComponent>().GameObject.transform.Find("Head");
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
            self.UpdateShouHuoTime();
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(unit.ConfigId);
            self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<TextMeshProUGUI>().text = jiaYuanFarmConfig.Name;
        }

        public static int GetPlanStage(this JiaYuanPlanUIComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            long startTime = self.NumericComponent.GetAsLong(NumericType.StartTime);
            int gatherNumber = self.NumericComponent.GetAsInt(NumericType.GatherNumber);
            return JiaYuanHelper.GetPlanStage(unit.ConfigId, startTime, gatherNumber);
        }

        public static void OnTimer(this JiaYuanPlanUIComponent self)
        {
            self.UpdateShouHuoTime();
            int state = self.GetPlanStage();
            if (state!= self.PlanStage)
            {
                self.PlanStage = state;
                Unit unit = self.GetParent<Unit>();
                unit.GetComponent<JiaYuanPlanEffectComponent>().OnUpdateUI(state);
                unit.GetComponent<GameObjectComponent>().OnUpdatePlan();
            }
        }


        public static void UpdateShouHuoTime(this JiaYuanPlanUIComponent self)
        {
            if (self.HeadBar == null)
            {
                return;
            }
            Unit unit = self.GetParent<Unit>(); 
            NumericComponent numericComponent = self.NumericComponent;
            long startTime = numericComponent.GetAsLong(NumericType.StartTime);
            int gatherNumber = numericComponent.GetAsInt(NumericType.GatherNumber);
            long gatherLastTime = numericComponent.GetAsLong(NumericType.GatherLastTime);
            if (JiaYuanHelper.GetPlanShouHuoItem(unit.ConfigId, startTime, gatherNumber, gatherLastTime) == 0)
            {
                self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = "可收获";
                self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().color = new Color(170f / 255f, 1, 0);
            }
            else
            {
                if (self.PlanStage == 3)
                {
                    long shouhuoTime = JiaYuanHelper.GetPlanNextShouHuoTime(unit.ConfigId, startTime, gatherNumber, gatherLastTime);
                    System.TimeSpan chaDate = TimeInfo.Instance.ToDateTime(shouhuoTime) - TimeHelper.DateTimeNow();
                    string showStr = "";
                    if (chaDate.Days > 0)
                    {
                        showStr = chaDate.Days + "天" + chaDate.Hours + "时" + chaDate.Minutes + "分" + chaDate.Seconds + "秒";
                    }
                    else
                    {
                        showStr = chaDate.Hours + "时" + chaDate.Minutes + "分" + chaDate.Seconds + "秒";
                    }
                    self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = $"收获计时: {showStr}";
                    //self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = $"收获计时: { JiaYuanHelper.TimeToShow(TimeInfo.Instance.ToDateTime(shouhuoTime).ToString("f"))}";
                }
                else
                {
                    self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = JiaYuanHelper.GetPlanStageName(self.PlanStage);
                }
            }
        }
    }
}