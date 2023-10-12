using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UITrialRewardComponent : Entity, IAwake
    {
        public GameObject CloseButton;
        public GameObject RewardListNode;
        public Action ClickOnClose;
        public GameObject UIRankRewardItem;
    }


    public class UITrialRewardComponentAwake : AwakeSystem<UITrialRewardComponent>
    {
        public override void Awake(UITrialRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseButton(); });

            self.UIRankRewardItem = rc.Get<GameObject>("UIRankRewardItem");
            self.UIRankRewardItem.SetActive(false);

            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
        }
    }

    public static class UITrialRewardComponentSytstem
    {
        public static void OnCloseButton(this UITrialRewardComponent self)
        {
            self.ClickOnClose?.Invoke();
            UIHelper.Remove(self.ZoneScene(), UIType.UITrialReward);
        }

        public static void OnInitUI(this UITrialRewardComponent self, int rankType)
        {
            List<RankRewardConfig> rankRewardConfigs = RankHelper.GetTypeRankRewards(1);
            for (int i = 0; i < rankRewardConfigs.Count; i++)
            {
                GameObject go = GameObject.Instantiate(self.UIRankRewardItem);
                UICommonHelper.SetParent(go, self.RewardListNode);
                self.AddChild<UIRankRewardItemComponent, GameObject>(go, true).OnUpdateUI(rankRewardConfigs[i]);
            }
        }
    }
}
