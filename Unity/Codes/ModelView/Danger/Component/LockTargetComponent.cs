using UnityEngine;

namespace ET
{
    public class LockTargetComponent : Entity, IAwake, IUpdate, IDestroy
    {
        public GameObject LockUnitEffect;
        public int LastLockIndex = -1;
        public long LastLockId = 0;
        public long FrameTimer = 0;
    }

}
