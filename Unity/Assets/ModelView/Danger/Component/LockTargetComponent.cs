using UnityEngine;

namespace ET
{
    public class LockTargetComponent : Entity, IAwake, IUpdate, IDestroy
    {
        public GameObject LockUnitEffect;
        public MyCamera_1 MyCamera_1;
        public int LastLockIndex = -1;
        public long LastLockId = 0;
    }

}
