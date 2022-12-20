using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIEnterMapHintComponent : Entity, IAwake
    {
        public GameObject titleText;
    }

    [ObjectSystem]
    public class UIEnterMapHintComponentAwake : AwakeSystem<UIEnterMapHintComponent>
    {
        public override void Awake(UIEnterMapHintComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.titleText = rc.Get<GameObject>("titleText");

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIEnterMapHintComponentSystem
    {
        public static async ETTask OnInitUI(this UIEnterMapHintComponent self)
        {
            int dungeonId = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            self.titleText.GetComponent<Text>().text = DungeonConfigCategory.Instance.Get(dungeonId).ChapterName;

            long instanceId = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(3000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            UIHelper.Remove(self.ZoneScene(), UIType.UIEnterMapHint);
        }
    }
}
