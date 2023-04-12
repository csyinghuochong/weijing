using UnityEngine;

namespace ET
{

    public class JiaYuanPlanEffectComponentAwake : AwakeSystem<JiaYuanPlanEffectComponent>
    {
        public override void Awake(JiaYuanPlanEffectComponent self)
        {
            self.PlanEffectPath = string.Empty;
            self.PlanEffectObj = null;

            self.OnInitUI();
        }
    }


    public class JiaYuanPlanEffectComponentDestroy : DestroySystem<JiaYuanPlanEffectComponent>
    {
        public override void Destroy(JiaYuanPlanEffectComponent self)
        {
            self.RecoverGameObject();
        }
    }

    public static class JiaYuanPlanEffectComponentSystem
    {

        public static void OnUprootPlan(this JiaYuanPlanEffectComponent self)
        {
            self.RecoverGameObject();
        }

        public static void RecoverGameObject(this JiaYuanPlanEffectComponent self)
        {
            if (self.PlanEffectObj != null)
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(self.PlanEffectPath, self.PlanEffectObj, false);
                self.PlanEffectObj = null;
            }
        }

        public static void UpdateEffect(this JiaYuanPlanEffectComponent self, int planStage)
        {
            if (planStage == 4)
            {
                return;
            }

            self.PlanEffectPath = ABPathHelper.GetEffetPath($"ScenceEffect/Eff_JiaYuan_Zhong");
            GameObjectPoolComponent.Instance.AddLoadQueue(self.PlanEffectPath, self.InstanceId, self.OnLoadEffect);
        }

        public static void OnLoadEffect(this JiaYuanPlanEffectComponent self, GameObject go, long formId)
        {
            if (self.IsDisposed)
            {
                GameObject.Destroy(go);
                return;
            }

            self.PlanEffectObj = go;
            UICommonHelper.SetParent(go, GlobalComponent.Instance.Unit.gameObject);
            go.transform.localPosition = self.GetParent<Unit>().Position;
            go.transform.localScale = Vector3.one;
            go.SetActive(true);
        }

        public static void OnInitUI(this JiaYuanPlanEffectComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int planStage = JiaYuanHelper.GetPlanStage(unit.ConfigId, numericComponent.GetAsLong(NumericType.StartTime), numericComponent.GetAsInt(NumericType.GatherNumber));
            self.OnUpdateUI(planStage);
        }

        public static void OnUpdateUI(this JiaYuanPlanEffectComponent self, int planStage)
        {
            self.RecoverGameObject();
            self.UpdateEffect(planStage);
        }
    }
}