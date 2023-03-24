using ET;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [ObjectSystem]
    public class JiaYuanPlanUIComponentAwake : AwakeSystem<JiaYuanPlanUIComponent>
    {
        public override void Awake(JiaYuanPlanUIComponent self)
        {
            self.HeadBar = null;
            self.PlanStage = -1;
            self.UICamera = GameObject.Find("Global/UI/UICamera").GetComponent<Camera>();
            self.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
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
        }
    }

    public static class JiaYuanPlanUIComponentSystem
    {
        public static void OnInitUI(this JiaYuanPlanUIComponent self, JiaYuanPlant jiaYuanPlan)
        {
            self.JiaYuanPlant = jiaYuanPlan;
            self.PlanStage = JiaYuanHelper.GetPlanStage(jiaYuanPlan);

            self.UpdateModel();
        }

        public static void OnUprootPlan(this JiaYuanPlanUIComponent self)
        {
            self.JiaYuanPlant = null;
            if (self.HeadBar != null)
            {
                GameObject.Destroy(self.HeadBar);
                self.HeadBar = null;
            }
            if (self.PlanModelObj != null)
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(self.PlanModelPath, self.PlanModelObj, false);
            }
        }

        public static void UpdateModel(this JiaYuanPlanUIComponent self)
        {
            JiaYuanPlant jiaYuanPlant = self.JiaYuanPlant;

            if (self.HeadBar != null)
            {
                GameObject.Destroy(self.HeadBar);
                self.HeadBar = null;
            }
            if (self.PlanModelObj != null)
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(self.PlanModelPath, self.PlanModelObj, false);
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlant.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            self.PlanModelPath = ABPathHelper.GetUnitPath($"JiaYuan/{jiaYuanFarmConfig.ModelID + self.PlanStage}");
            GameObjectPoolComponent.Instance.AddLoadQueue(self.PlanModelPath, self.InstanceId, self.OnLoadGameObject);
        }

        public static void OnUpdateUI(this JiaYuanPlanUIComponent self, JiaYuanPlant jiaYuanPlan)
        {
            self.JiaYuanPlant = jiaYuanPlan;
            self.UpdateShouHuoTime();
            int planStage = JiaYuanHelper.GetPlanStage(jiaYuanPlan);
            if (planStage == self.PlanStage)
            {
                return;
            }

            self.PlanStage = planStage;
            self.UpdateModel();
        }

        public static void UpdateShouHuoTime(this JiaYuanPlanUIComponent self)
        {
            if (self.JiaYuanPlant == null || self.HeadBar == null)
            {
                return;
            }

            if (JiaYuanHelper.GetShouHuoItem(self.JiaYuanPlant) == 0)
            {
                self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = "可收获";
                self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().color = new Color(170f / 255f, 1, 0);
            }
            else
            {
                if (self.PlanStage == 3)
                {
                    long shouhuoTime = JiaYuanHelper.GetNextShouHuoTime(self.JiaYuanPlant);
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

        public static void OnLoadGameObject(this JiaYuanPlanUIComponent self, GameObject go, long formId)
        {
            if (self.IsDisposed)
            {
                GameObject.Destroy(go);
                return;
            }

            UICommonHelper.SetParent(go, self.GameObject);
            go.transform.localPosition = new Vector3(-0.5f, 0f, -0.5f);
            go.transform.localScale = Vector3.one * 10f;
            self.PlanModelObj = go;
            go.SetActive(true);

            self.UIPosition = go.transform.Find("Head");
            string path = ABPathHelper.GetUGUIPath("Battle/UIEnergyTable");
            GameObject prefab =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
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

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.JiaYuanPlant.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            self.HeadBar.Get<GameObject>("Lal_Name").GetComponent<TextMeshProUGUI>().text = jiaYuanFarmConfig.Name;
            self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().color = new Color(230f / 255f, 230f / 255f, 230f / 255f);
            self.HeadBar.transform.SetAsFirstSibling();
            self.UpdateShouHuoTime();
        }
    }
}