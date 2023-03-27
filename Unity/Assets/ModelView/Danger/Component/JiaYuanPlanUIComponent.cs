using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class JiaYuanPlanUIComponent : Entity, IAwake, IDestroy
    {
        public GameObject HeadBar;
        public Camera UICamera;
        public Camera MainCamera;
        public Transform UIPosition;
        public HeadBarUI HeadBarUI;
        public NumericComponent NumericComponent;

        public int PlanStage = -1;
        public long Timer;
    }
}
