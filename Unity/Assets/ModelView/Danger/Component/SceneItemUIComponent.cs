using UnityEngine;

namespace ET
{
    public class SceneItemUIComponent : Entity, IAwake, IDestroy
    {
        public Unit MyUnit;
        public GameObject HeadBar;

        public Camera UICamera;
        public Camera MainCamera;

        public Transform UIPosition;
        public float LastTime;

        public HeadBarUI HeadBarUI;
    }
}
