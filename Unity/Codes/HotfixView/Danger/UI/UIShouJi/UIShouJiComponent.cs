using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace ET
{

    public class UIShouJiComponent : Entity, IAwake
    {
        public GameObject ShoujiContent;
        public GameObject ScrollView;

    }

    [ObjectSystem]
    public class UIShouJiComponentAwakeSystem : AwakeSystem<UIShouJiComponent>
    {
        public override void Awake(UIShouJiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ShoujiContent = rc.Get<GameObject>("ShoujiContent");
            self.ScrollView = rc.Get<GameObject>("ScrollView");

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIShouJiComponentSystem
    {
        public static async ETTask OnUpdateUI(this UIShouJiComponent self)
        {
            await ETTask.CompletedTask;
            var path = ABPathHelper.GetUGUIPath("Main/ShouJi/UIShouJiChapter");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            List<ShouJiConfig> shouJiConfigs = ShouJiConfigCategory.Instance.GetAll().Values.ToList();
            long instanceId = self.InstanceId;
            for (int i = 0; i < shouJiConfigs.Count; i++)
            {
                if (instanceId != self.InstanceId)
                {
                    return;
                }
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.ShoujiContent);
                self.AddChild<UIShouJiChapterComponent, GameObject>(go).OnInitUI(shouJiConfigs[i]).Coroutine();
                await TimerComponent.Instance.WaitAsync(200);
            }
        }
    }
}
