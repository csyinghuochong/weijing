using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class JiaYuanPlanLockComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject HeadBar;
        public Camera UICamera;
        public Camera MainCamera;
        public Transform UIPosition;
        public HeadBarUI HeadBarUI;

        public GameObject GameObject;
    }
}
