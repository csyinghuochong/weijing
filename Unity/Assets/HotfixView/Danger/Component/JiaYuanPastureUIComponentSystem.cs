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
            self.MainUnitEnter = false;
            self.MainUnitExit = false;
            self.EnterPassTime = 0f;
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

        public static void OnUpdateNpcTalk(this JiaYuanPastureUIComponent self, Unit mainUnit)
        {
            Unit unit = self.GetParent<Unit>();
            float distance = PositionHelper.Distance2D(mainUnit, unit);
            if (distance < 3f && !self.MainUnitEnter)
            {
                self.MainUnitEnter = true;
                self.MainUnitExit = false;

                JiaYuanPastureConfig jiaYuanPastureConfig = JiaYuanPastureConfigCategory.Instance.Get(unit.ConfigId);
                self.HeadBar.Get<GameObject>("TalkNode").SetActive(true);
                self.HeadBar.Get<GameObject>("Lal_Talk").GetComponent<TextMeshProUGUI>().text = $"{jiaYuanPastureConfig.Name}  靠近了说话";
            }
            if (distance > 3f && !self.MainUnitExit)
            {
                self.MainUnitEnter = false;
                self.MainUnitExit = true;
                self.EnterPassTime = 0f;
                self.HeadBar.Get<GameObject>("TalkNode").SetActive(false);
            }

            if (self.MainUnitEnter)
            {
                self.EnterPassTime += Time.deltaTime;
            }
            if (self.MainUnitEnter && self.EnterPassTime >= 3f)
            {
                self.HeadBar.Get<GameObject>("TalkNode").SetActive(false);
            }
        }

        public static void OnUpdateUI(this JiaYuanPastureUIComponent self)
        {
            if (self.HeadBar == null)
            {
                return;
            }
            NumericComponent numericComponent = self.NumericComponent;
            long startTime = numericComponent.GetAsLong(NumericType.StartTime);
            int gatherNumber = numericComponent.GetAsInt(NumericType.GatherNumber);
            long gatherLastTime = numericComponent.GetAsLong(NumericType.GatherLastTime);
            int stage = JiaYuanHelper.GetPastureState(self.GetParent<Unit>().ConfigId, startTime, gatherNumber);
           
            if (JiaYuanHelper.GetPastureShouHuoItem(self.GetParent<Unit>().ConfigId, startTime, gatherNumber, gatherLastTime) == 0)
            {
                self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = "可收获";
                self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().color = new Color(170f / 255f, 1, 0);
            }
            else
            {
                if (stage == 3)
                {
                    long shouhuoTime = JiaYuanHelper.GetPastureNextShouHuoTime(self.GetParent<Unit>().ConfigId, startTime, gatherNumber, gatherLastTime);
                    System.TimeSpan chaDate = TimeInfo.Instance.ToDateTime(shouhuoTime) - TimeHelper.DateTimeNow();
                    string showStr = String.Empty;
                    if (chaDate.Days > 0)
                    {
                        showStr = chaDate.Days + "天" + chaDate.Hours + "时" + chaDate.Minutes + "分" + chaDate.Seconds + "秒";
                    }
                    else
                    {
                        showStr = chaDate.Hours + "时" + chaDate.Minutes + "分" + chaDate.Seconds + "秒";
                    }
                    self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = $"收获计时: {showStr}";
                }
                else
                {
                    self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = JiaYuanHelper.GetPastureStageName(stage);
                }
            }

            if (self.PlanStage != stage)
            {
                GameObject gameObject = self.GetParent<Unit>().GetComponent<GameObjectComponent>().GameObject;
                gameObject.transform.localScale = JiaYuanHelper.GetPastureStageScale(stage) * Vector3.one;
            }
            self.PlanStage = stage;
        }
    }
}
