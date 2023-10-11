using UnityEngine;

namespace ET
{
    public class UIPetMiningItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
    }

    public class UIPetMiningItemComponentAwake : AwakeSystem<UIPetMiningItemComponent, GameObject>
    {
        public override void Awake(UIPetMiningItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
        }
    }
}