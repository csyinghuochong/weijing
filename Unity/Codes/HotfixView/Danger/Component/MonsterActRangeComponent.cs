using System;
using UnityEngine;

namespace ET
{
    public class MonsterActRangeComponent : Entity, IAwake, IDestroy
    {
        public bool IsInAck;
        public Vector3 BornPositon;
        public float AckRange;
        public GameObject MonsterActRange;
    }

    [ObjectSystem]
    public class MonsterActRangeComponentAwakeSystem : AwakeSystem<MonsterActRangeComponent>
    {
        public override void Awake(MonsterActRangeComponent self)
        {
            self.IsInAck = false;
            self.MonsterActRange = null;
        }
    }

    [ObjectSystem]
    public class MonsterActRangeComponentDestroySystem : DestroySystem<MonsterActRangeComponent>
    {
        public override void Destroy(MonsterActRangeComponent self)
        {
            if (self.MonsterActRange!=null)
            { 
                GameObject.Destroy(self.MonsterActRange);
                self.MonsterActRange = null;
            }
        }
    }

    public static class MonsterActRangeComponentSystem
    {

        public static async ETTask ShowActRange(this MonsterActRangeComponent self)
        {
            await ETTask.CompletedTask;   
        }

        public static void OnUpdate(this MonsterActRangeComponent self)
        {
            if (self.MonsterActRange == null)
            {
                return;
            }
            
            //bool isinack = Vector3.Distance( self.BornPositon, self.GetParent<Unit>().Position) < self.AckRange;
        }
    }
}
