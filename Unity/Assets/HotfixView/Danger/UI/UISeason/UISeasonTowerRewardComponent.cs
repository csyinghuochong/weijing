using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonTowerRewardComponent: Entity, IAwake
    {
        public GameObject CloseButton;
        public GameObject RewardListNode;
        public GameObject UIRankRewardItem;
    }

    public class UISeasonTowerRewardComponentAwake: AwakeSystem<UISeasonTowerRewardComponent>
    {
        public override void Awake(UISeasonTowerRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseButton(); });

            self.UIRankRewardItem = rc.Get<GameObject>("UIRankRewardItem");
            self.UIRankRewardItem.SetActive(false);

            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
        }
    }

    public static class UISeasonTowerRewardComponentSytstem
    {
        public static void OnCloseButton(this UISeasonTowerRewardComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UISeasonTowerReward);
        }

        public static void OnInitUI(this UISeasonTowerRewardComponent self, int rankType)
        {
            List<RankRewardConfig> rankRewardConfigs = RankHelper.GetTypeRankRewards(6);
            for (int i = 0; i < rankRewardConfigs.Count; i++)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIRankRewardItem);
                go.SetActive(true);
                UICommonHelper.SetParent(go, self.RewardListNode);
                self.AddChild<UIRankRewardItemComponent, GameObject>(go, true).OnUpdateUI(rankRewardConfigs[i]);
            }
        }
    }
}