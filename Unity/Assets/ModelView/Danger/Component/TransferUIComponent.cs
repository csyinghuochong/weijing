using UnityEngine;

namespace ET
{
    public class TransferUIComponent : Entity, IAwake, IDestroy
    {
        public GameObject HeadBar;

        public Camera UICamera;
        public Camera MainCamera;

        public Transform UIPosition;

        public HeadBarUI HeadBarUI;
    }
}
