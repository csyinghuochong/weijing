using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{
    public class UILingDiRewardComponent:Entity, IAwake
    {
        public GameObject ShoujiContent;
        public GameObject ScrollView; 
    }



    [ObjectSystem]
    public class UILingDiRewardComponentAwakeSystem : AwakeSystem<UILingDiRewardComponent>
    {
        public override void Awake(UILingDiRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ShoujiContent = rc.Get<GameObject>("ShoujiContent");
            self.ScrollView = rc.Get<GameObject>("ScrollView");

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UILingDiRewardComponentSystem
    {

        public static Dictionary<int, List<LingDiRewardConfig>> GetRewardList(this UILingDiRewardComponent self)
        {
            Dictionary<int, List<LingDiRewardConfig>> keyValuePairs = new Dictionary<int, List<LingDiRewardConfig>>();

            List<LingDiRewardConfig> lingDiRewards = LingDiRewardConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < lingDiRewards.Count; i++)
            {
                List<LingDiRewardConfig> vs;
                keyValuePairs.TryGetValue(lingDiRewards[i].CountryLvlimit, out vs);
                if (vs == null)
                {
                    vs = new List<LingDiRewardConfig>();
                    keyValuePairs.Add(lingDiRewards[i].CountryLvlimit, vs);
                }
                vs.Add(lingDiRewards[i]);
            }
            return keyValuePairs;
        }

        public static async ETTask OnUpdateUI(this UILingDiRewardComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/LingDi/UILingDiRewardLevel");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            Dictionary<int, List<LingDiRewardConfig>> keyValuePairs = self.GetRewardList();
            long instanceId = self.InstanceId;
            foreach(var item in keyValuePairs)
            {
                if (instanceId != self.InstanceId)
                {
                    return;
                }
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.ShoujiContent);
                self.AddChild<UILingDiRewardLevelComponent, GameObject>(go).OnInitUI(item.Value).Coroutine();
                await TimerComponent.Instance.WaitAsync(200);
            }
        }
    }
}
