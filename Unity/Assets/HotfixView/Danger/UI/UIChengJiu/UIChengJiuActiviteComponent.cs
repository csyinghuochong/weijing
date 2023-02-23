using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChengJiuActiviteComponent : Entity,IAwake
    {
        public GameObject Text_ChengJiuDesc;
        public GameObject Text_ChengJiuPoint;
        public GameObject Text_ChengJiuName;
    }

    [ObjectSystem]
    public class UIChengJiuActiviteComponentAwake : AwakeSystem<UIChengJiuActiviteComponent>
    {
        public override void Awake(UIChengJiuActiviteComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_ChengJiuDesc = rc.Get<GameObject>("Text_ChengJiuDesc");
            self.Text_ChengJiuPoint = rc.Get<GameObject>("Text_ChengJiuPoint");
            self.Text_ChengJiuName = rc.Get<GameObject>("Text_ChengJiuName");
        }
    }

    public static class UIChengJiuActiviteComponentSystem
    {
        public static async ETTask OnInitUI(this UIChengJiuActiviteComponent self, int chengjiuId)
        {
            ChengJiuConfig chengJiuConfig = ChengJiuConfigCategory.Instance.Get(chengjiuId);
            self.Text_ChengJiuDesc.GetComponent<Text>().text = chengJiuConfig.Des;
            self.Text_ChengJiuPoint.GetComponent<Text>().text = chengJiuConfig.RewardNum.ToString();
            self.Text_ChengJiuName.GetComponent<Text>().text = chengJiuConfig.Name;

            long instanceId = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(3000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            UIHelper.Remove(self.ZoneScene(), UIType.UIChengJiuActivite);
        }
    }
}
