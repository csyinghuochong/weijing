using System;
using UnityEngine;

namespace ET
{
    public class MonsterActRangeComponent : Entity, IAwake<int>, IDestroy
    {
        public bool IsInAck;
        public float AckRange;
        public Vector3 BornPositon;
        public GameObject MonsterActRange;
    }

    [ObjectSystem]
    public class MonsterActRangeComponentAwakeSystem : AwakeSystem<MonsterActRangeComponent, int>
    {
        public override void Awake(MonsterActRangeComponent self, int configId)
        {
            self.IsInAck = false;
            self.MonsterActRange = null;
            self.AckRange = (float)MonsterConfigCategory.Instance.Get(configId).ChaseRange;

            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            self.BornPositon = new Vector3(
                    numericComponent.GetAsFloat(NumericType.Born_X),
                    numericComponent.GetAsFloat(NumericType.Born_Y),
                    numericComponent.GetAsFloat(NumericType.Born_Z)
                );
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

        public static void OnBossInCombat(this MonsterActRangeComponent self, int combat)
        {
            if (combat == 0)
            {
                self.MonsterActRange?.SetActive(false);
            }
            else
            {
                if (self.MonsterActRange != null)
                {
                    self.MonsterActRange.SetActive(true);
                }
                else
                {
                    self.LoadEffect().Coroutine();
                }
            }
        }

        public static async ETTask LoadEffect(this MonsterActRangeComponent self)
        {
            string path = ABPathHelper.GetEffetPath("MonsterActRange");
            self.MonsterActRange = await GameObjectPoolComponent.Instance.GetExternal(path);
            self.MonsterActRange.SetActive(true);
            self.MonsterActRange.Get<GameObject>("MonsterActRange").GetComponent<Projector>().orthographicSize = self.AckRange;
            self.MonsterActRange.transform.position = self.BornPositon;
            self.MonsterActRange.transform.localScale = self.AckRange * Vector3.one;
        }
    }
}
