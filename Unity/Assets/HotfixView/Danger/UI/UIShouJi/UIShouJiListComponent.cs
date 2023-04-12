using UnityEngine;
using System.Linq;
using System.Collections.Generic;


namespace ET
{
    public class UIShouJiListComponent : Entity, IAwake
    {
        public GameObject ShoujiContent;
        public GameObject ScrollView;

    }


    public class UIShouJiListComponentAwake : AwakeSystem<UIShouJiListComponent>
    {
        public override void Awake(UIShouJiListComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ShoujiContent = rc.Get<GameObject>("ShoujiContent");
            self.ScrollView = rc.Get<GameObject>("ScrollView");

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIShouJiListComponentSystem
    {
        public static async ETTask OnUpdateUI(this UIShouJiListComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/ShouJi/UIShouJiChapter");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
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
