using ET;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [ObjectSystem]
    public class GameObjectPlantComponentAwake : AwakeSystem<GameObjectPlantComponent>
    {
        public override void Awake(GameObjectPlantComponent self)
        {
            self.PlanModelPath = string.Empty;
            self.PlanModelObj = null;
            self.PlanEffectPath = string.Empty;
            self.PlanEffectObj = null;
        }
    }

    [ObjectSystem]
    public class GameObjectPlantComponentDestroy : DestroySystem<GameObjectPlantComponent>
    {
        public override void Destroy(GameObjectPlantComponent self)
        {
            self.RecoverGameObject();
        }
    }

    public static class GameObjectPlantComponentSystem
    {

        public static void OnUprootPlan(this GameObjectPlantComponent self)
        {
            self.RecoverGameObject();
        }

        public static void RecoverGameObject(this GameObjectPlantComponent self)
        {
            if (self.PlanModelObj != null)
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(self.PlanModelPath, self.PlanModelObj, false);
                self.PlanModelObj = null;
            }
            if (self.PlanEffectObj != null)
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(self.PlanEffectPath, self.PlanEffectObj, false);
                self.PlanEffectObj = null;
            }
        }

        public static void UpdateEffect(this GameObjectPlantComponent self)
        {
            if (self.JiaYuanPlant == null)
            {
                return;
            }
            if (self.PlanStage == 4)
            {
                return;
            }

            self.PlanEffectPath = ABPathHelper.GetEffetPath($"ScenceEffect/Eff_JiaYuan_Zhong");
            GameObjectPoolComponent.Instance.AddLoadQueue(self.PlanEffectPath, self.InstanceId, self.OnLoadEffect);
        }

        public static void OnLoadEffect(this GameObjectPlantComponent self, GameObject go, long formId)
        {
            if (self.IsDisposed)
            {
                GameObject.Destroy(go);
                return;
            }

            UICommonHelper.SetParent(go, GlobalComponent.Instance.Unit.gameObject);
            go.transform.localPosition = new Vector3(-0.5f, 0f, -0.5f);
            self.PlanEffectObj = go;
            go.SetActive(true);
        }

        public static void UpdatePosition(this GameObjectPlantComponent self)
        {
            JiaYuanViewComponent jiaYuanView = self.ZoneScene().CurrentScene().GetComponent<JiaYuanViewComponent>();
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();    

        }

        public static void OnLoadGameObject(this GameObjectPlantComponent self, GameObject go, long formId)
        {
            if (self.IsDisposed)
            {
                GameObject.Destroy(go);
                return;
            }

            UICommonHelper.SetParent(go, GlobalComponent.Instance.Unit.gameObject);
            go.transform.localPosition = new Vector3(-0.5f, 0f, -0.5f);
            go.transform.localScale = Vector3.one * 10f;
            self.PlanModelObj = go;
            go.SetActive(true);
            Unit unit = self.GetParent<Unit>();
            unit.AddComponent<JiaYuanPlanUIComponent>();
        }

        public static void UpdateModel(this GameObjectPlantComponent self)
        {
            JiaYuanPlant jiaYuanPlant = self.JiaYuanPlant;

            self.RecoverGameObject();

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlant.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            self.PlanModelPath = ABPathHelper.GetUnitPath($"JiaYuan/{jiaYuanFarmConfig.ModelID + self.PlanStage}");
            GameObjectPoolComponent.Instance.AddLoadQueue(self.PlanModelPath, self.InstanceId, self.OnLoadGameObject);
        }

        public static void OnUpdateUI(this GameObjectPlantComponent self, int planStage)
        {
            self.PlanStage = planStage;
            self.UpdateModel();
            self.UpdateEffect();
        }
    }
}