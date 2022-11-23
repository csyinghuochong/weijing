using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRankPetRewardComponent: Entity, IAwake
    {
        public GameObject CloseButton;
        public GameObject RewardListNode;
        public Action ClickOnClose;
    }

    [ObjectSystem]
    public class UIRankPetRewardComponentAwake : AwakeSystem<UIRankPetRewardComponent>
    {
        public override void Awake(UIRankPetRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseButton(); });

            self.RewardListNode = rc.Get<GameObject>("RewardListNode");

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIRankPetRewardComponentSytstem
    {
        public static void OnCloseButton(this UIRankPetRewardComponent self)
        {
            self.ClickOnClose?.Invoke();
            UIHelper.Remove(self.ZoneScene(), UIType.UIRankReward);
        }

        public static async ETTask OnInitUI(this UIRankPetRewardComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Rank/UIRankRewardItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            List<RankRewardConfig> rankRewardConfigs = RankHelper.GetTypeRankRewards(2);
            for (int i = 0; i < rankRewardConfigs.Count; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.RewardListNode);
                self.AddChild<UIRankRewardItemComponent, GameObject>(go, true).OnUpdateUI(rankRewardConfigs[i]);
            }
        }
    }
}
