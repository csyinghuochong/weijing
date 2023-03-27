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

            go.SetActive(false);
            self.PlanEffectObj = go;
        }

        public static void UpdatePosition(this GameObjectPlantComponent self)
        {
            JiaYuanViewComponent jiaYuanView = self.ZoneScene().CurrentScene().GetComponent<JiaYuanViewComponent>();
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            int cellindex = numericComponent.GetAsInt(NumericType.CellIndex);
            if (jiaYuanView== null || !jiaYuanView.JianYuanPlanUIs.ContainsKey(cellindex))
            {
                return;
            }

            if (self.PlanModelObj != null)
            {
                UICommonHelper.SetParent(self.PlanModelObj, GlobalComponent.Instance.Unit.gameObject);
                self.PlanModelObj.transform.localPosition = new Vector3(-0.5f, 0f, -0.5f);
                self.PlanModelObj.transform.localScale = Vector3.one * 10f;
                self.PlanModelObj.SetActive(true);
            }

            if (self.PlanEffectObj != null)
            {
                UICommonHelper.SetParent(self.PlanEffectObj, GlobalComponent.Instance.Unit.gameObject);
                self.PlanEffectObj.transform.localPosition = new Vector3(-0.5f, 0f, -0.5f);
                self.PlanEffectObj.transform.localScale = Vector3.one * 10f;
                self.PlanEffectObj.SetActive(true);
            }
        }

        public static void OnLoadGameObject(this GameObjectPlantComponent self, GameObject go, long formId)
        {
            if (self.IsDisposed)
            {
                GameObject.Destroy(go);
                return;
            }
            go.SetActive(false);
            self.PlanModelObj = go;
            Unit unit = self.GetParent<Unit>();
            unit.AddComponent<JiaYuanPlanUIComponent>();
        }

        public static void UpdateModel(this GameObjectPlantComponent self)
        {
            self.RecoverGameObject();

            Unit unit = self.GetParent<Unit>();
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(unit.ConfigId);
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