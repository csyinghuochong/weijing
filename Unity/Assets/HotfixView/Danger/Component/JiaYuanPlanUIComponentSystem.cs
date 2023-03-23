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
            self.PlanStage = self.GetPlanStage(jiaYuanPlan);

            self.UpdateModel();
        }

        public static int GetPlanStage(this JiaYuanPlanUIComponent self, JiaYuanPlant jiaYuanPlan)
        {
            int stage = 0;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlan.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            long passTime = TimeHelper.ServerNow() - jiaYuanPlan.StartTime;
            for (int i = 0;  i < jiaYuanFarmConfig.UpTime.Length; i++)
            {
                if (passTime >= jiaYuanFarmConfig.UpTime[i] * 1000)
                {
                    stage =  i + 1;
                    break;
                }
            }

            //收货上限才为第四个阶段 0[种子] 1 2 3 4[废柴]
            if (stage < 3)
            {
                return stage;
            }
            if (jiaYuanPlan.GatherNumber >= jiaYuanFarmConfig.GetItemNum)
            {
                return stage;
            }
            else
            {
                return 3;
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
            int planStage = self.GetPlanStage(jiaYuanPlan);
            if (planStage == self.PlanStage)
            {
                return;
            }

            self.PlanStage = self.GetPlanStage(jiaYuanPlan);
            self.UpdateModel();
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
            go.transform.localScale = Vector3.one * 20f;
            self.PlanModelObj = go;
            go.SetActive(true);

            self.UIPosition = go.transform;
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
            self.HeadBar.Get<GameObject>("Lal_Desc").GetComponent<TextMeshProUGUI>().text = string.Empty;
        }
    }
}