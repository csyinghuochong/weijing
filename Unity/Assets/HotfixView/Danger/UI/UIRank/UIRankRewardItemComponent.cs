using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRankRewardItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ItemListNode;
        public GameObject Text_Rank;
        public GameObject Rank_1;
        public GameObject Rank_2;
        public GameObject Rank_3;
    }


    public class UIRankRewardItemComponentAwakeSystem : AwakeSystem<UIRankRewardItemComponent, GameObject>
    {
        public override void Awake(UIRankRewardItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Text_Rank = rc.Get<GameObject>("Text_Rank");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.Rank_1 = rc.Get<GameObject>("Rank_1");
            self.Rank_2 = rc.Get<GameObject>("Rank_2");
            self.Rank_3 = rc.Get<GameObject>("Rank_3");
        }
    }

    public static class UIRankRewardItemComponentSystem
    {
        public static void OnUpdateUI(this UIRankRewardItemComponent self, RankRewardConfig rankRewardConfig)
        {

            self.Text_Rank.GetComponent<Text>().text = $"{rankRewardConfig.NeedPoint[0]}-{rankRewardConfig.NeedPoint[1]}名";
            UICommonHelper.ShowItemList(rankRewardConfig.RewardItems, self.ItemListNode, self, 0.9f);

            if (rankRewardConfig.NeedPoint[0] == 1) 
            {
                self.Rank_1.SetActive(true);
                self.Text_Rank.SetActive(false);
            }
            if (rankRewardConfig.NeedPoint[0] == 2)
            {
                self.Rank_2.SetActive(true);
                self.Text_Rank.SetActive(false);
            }
            if (rankRewardConfig.NeedPoint[0] == 3)
            {
                self.Rank_3.SetActive(true);
                self.Text_Rank.SetActive(false);
            }
        }
    }
}
