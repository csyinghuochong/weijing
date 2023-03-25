using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class JiaYuanPlanUIComponent : Entity, IAwake, IDestroy
    {

        public string PlanModelPath;
        public GameObject PlanModelObj;

        public string PlanEffectPath;
        public GameObject PlanEffectObj;

        public GameObject HeadBar;
        public Camera UICamera;
        public Camera MainCamera;
        public Transform UIPosition;

        public HeadBarUI HeadBarUI;

        public GameObject GameObject;

        public JiaYuanPlant JiaYuanPlant;

        public int PlanStage = -1;
    }
}
