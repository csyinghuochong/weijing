using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public class UICampRewardComponent : Entity, IAwake
    {
        public GameObject RewardNodeList;
    }

    [ObjectSystem]
    public class UICampRewardComponentAwakeSystem : AwakeSystem<UICampRewardComponent>
    {
        public override void Awake(UICampRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.RewardNodeList = rc.Get<GameObject>("RewardNodeList");
            self.OnInitUI().Coroutine();
        }
    }

    public static class UICampRewardComponentSystem
    {
        public static async ETTask OnInitUI(this UICampRewardComponent self)
        {
            string path = ABPathHelper.GetUGUIPath("Main/Camp/UICampRewardItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            List<CampRewardConfig> configs = CampRewardConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < configs.Count; i++)
            {
                GameObject gameObject = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(gameObject, self.RewardNodeList);
                UICampRewardItemComponent itemComponent = self.AddChild<UICampRewardItemComponent, GameObject>(gameObject);
                itemComponent.OnInitUI(configs[i]);
            }
        }
    }
}
