using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICampRewardItemComponent:Entity, IAwake<GameObject>
    {
        public GameObject TextRank;
        public GameObject ItemListNode_2;
        public GameObject ItemListNode_1;

        public GameObject GameObject;
    }


    public class UICampRewardItemComponentAwakeSystem : AwakeSystem<UICampRewardItemComponent, GameObject>
    {
        public override void Awake(UICampRewardItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextRank = rc.Get<GameObject>("TextRank");
            self.ItemListNode_2 = rc.Get<GameObject>("ItemListNode_2");
            self.ItemListNode_1 = rc.Get<GameObject>("ItemListNode_1");
        }
    }

    public static class UICampRewardItemComponentSystem
    {
        public static void OnInitUI(this UICampRewardItemComponent self, CampRewardConfig config)
        {
            self.TextRank.GetComponent<Text>().text = $"第{config.RankRange[0]}-{config.RankRange[1]}名";
            UICommonHelper.ShowItemList(config.Win_RewardList,  self.ItemListNode_1, self, 0.8f);
            UICommonHelper.ShowItemList(config.Fail_RewardList, self.ItemListNode_2, self, 0.8f);
        }
    }
}

