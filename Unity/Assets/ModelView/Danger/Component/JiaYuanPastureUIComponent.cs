using UnityEngine;

namespace ET
{
    public class JiaYuanPastureUIComponent : Entity, IAwake, IDestroy
    {
        public Unit MyUnit;
        public GameObject HeadBar;

        public Camera UICamera;
        public Camera MainCamera;

        public Transform UIPosition;

        public HeadBarUI HeadBarUI;

        public NumericComponent NumericComponent;

        public long Timer;

        public int PlanStage = -1;

        public bool MainUnitEnter;
        public bool MainUnitExit;
        public float EnterPassTime;
    }
}
