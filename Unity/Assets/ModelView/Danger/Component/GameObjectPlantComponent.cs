using UnityEngine;

namespace ET
{
    public class GameObjectPlantComponent : Entity, IAwake, IDestroy
    {
        public string PlanModelPath;
        public GameObject PlanModelObj;

        public string PlanEffectPath;
        public GameObject PlanEffectObj;

        public int PlanStage;
    }
}
