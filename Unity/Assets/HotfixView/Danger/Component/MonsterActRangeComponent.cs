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
            self.BornPositon = self.GetParent<Unit>().GetBornPostion();
        }
    }

    [ObjectSystem]
    public class MonsterActRangeComponentDestroySystem : DestroySystem<MonsterActRangeComponent>
    {
        public override void Destroy(MonsterActRangeComponent self)
        {
            string path = ABPathHelper.GetEffetPath("MonsterActRange");
            GameObjectPoolComponent.Instance.RecoverGameObject(path, self.MonsterActRange);
        }
    }

    public static class MonsterActRangeComponentSystem
    {

        public static void OnDead(this MonsterActRangeComponent self)
        {
            self.MonsterActRange?.SetActive(false);
        }

        public static void OnBossInCombat(this MonsterActRangeComponent self, int combat)
        {
            Scene zoneScene = self.ZoneScene();
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.PetDungeon
             || mapComponent.SceneTypeEnum == SceneTypeEnum.PetTianTi)
            {
                return;
            }

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
                    self.LoadEffect();
                }
            }
        }

        public static void OnLoadGameObject(this MonsterActRangeComponent self, GameObject gameObject, long formId)
        {
            if (self.IsDisposed)
            {
                string path = ABPathHelper.GetEffetPath("MonsterActRange");
                GameObjectPoolComponent.Instance.RecoverGameObject(path, self.MonsterActRange);
                return;
            }
            self.MonsterActRange = gameObject;
            self.MonsterActRange.SetActive(true);
            self.MonsterActRange.Get<GameObject>("MonsterActRange").GetComponent<Projector>().orthographicSize = self.AckRange * 1.2f;
            self.MonsterActRange.transform.position = self.BornPositon;
            self.MonsterActRange.transform.localScale = self.AckRange * Vector3.one;
        }

        public static  void LoadEffect(this MonsterActRangeComponent self)
        {
            string path = ABPathHelper.GetEffetPath("MonsterActRange");
            GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
        }
    }
}
