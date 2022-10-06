using System;
using UnityEngine;

namespace ET
{
    public class UICampShouLieItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject ButtonReceived;
        public GameObject ButtonReward;
        public GameObject TextNumber;
        public GameObject TextRank;
    }

    [ObjectSystem]
    public class UICampShouLieItemComponentAwakeSystem : AwakeSystem<UICampShouLieItemComponent, GameObject>
    {
        public override void Awake(UICampShouLieItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ButtonReceived = rc.Get<GameObject>("ButtonReceived");
            self.ButtonReward = rc.Get<GameObject>("ButtonReward");
            self.TextNumber = rc.Get<GameObject>("TextNumber");
            self.TextRank = rc.Get<GameObject>("TextRank");
        }
    }

    public static class UICampShouLieItemComponentSystem
    {

        public static void OnInitUI(this UICampShouLieItemComponent self, TaskPro taskPro)
        { 
            
        }

        public static void SetReceived(this UICampShouLieItemComponent self, bool received)
        { 
            
        }
    }
}
