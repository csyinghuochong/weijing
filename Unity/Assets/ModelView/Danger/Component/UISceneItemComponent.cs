using UnityEngine;

namespace ET
{
    public class UISceneItemComponent : Entity, IAwake, IDestroy
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
