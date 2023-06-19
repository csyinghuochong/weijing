using UnityEngine;

namespace ET
{
    public class SceneItemUIComponent : Entity, IAwake, IDestroy
    {
        public Unit MyUnit;
        public GameObject GameObject;
        public Transform UIPosition;

        public HeadBarUI HeadBarUI;
    }
}
