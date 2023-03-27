using ET;
using UnityEngine;

namespace ET
{

    [ObjectSystem]
    public class JiaYuanPlanEffectComponentAwake : AwakeSystem<JiaYuanPlanEffectComponent>
    {
        public override void Awake(JiaYuanPlanEffectComponent self)
        {
            self.PlanEffectPath = string.Empty;
            self.PlanEffectObj = null;
        }
    }

    [ObjectSystem]
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
            go.SetActive(false);
            self.UpdatePosition();
        }

        public static void UpdatePosition(this JiaYuanPlanEffectComponent self)
        {
            if (self.PlanEffectObj != null)
            {
                UICommonHelper.SetParent(self.PlanEffectObj, GlobalComponent.Instance.Unit.gameObject);
                self.PlanEffectObj.transform.localPosition = self.GetParent<Unit>().Position;
                self.PlanEffectObj.transform.localScale = Vector3.one * 10f;
                self.PlanEffectObj.SetActive(true);
            }
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