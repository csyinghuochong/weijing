using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1WeeklyCardComponent : Entity, IAwake
    {
        public GameObject Text_Number;
        public GameObject ButtonOpen;
        public GameObject UIActivityV1WeeklyCardItem;
        public GameObject TaskListNode;
        public GameObject BtnItemTypeSet;
    }

    public class UIActivityV1WeeklyCardComponentAwake : AwakeSystem<UIActivityV1WeeklyCardComponent>
    {
        public override void Awake(UIActivityV1WeeklyCardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UpdateInfo();
        }
    }

    public static class UIActivityV1WeeklyCardComponentSystem
    {
        public static void UpdateInfo(this UIActivityV1WeeklyCardComponent self)
        {
            List<string> rewardlist = ActivityConfigHelper.ActivityV1WeeklyCardReward[ 0 ];
            foreach (string rewarditem in rewardlist)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1WeeklyCardItem);
               
                UICommonHelper.SetParent(go, self.TaskListNode);
                go.SetActive(true);
            }
        }
    }
}