using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFirstWinRewardComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImageButton;
        public GameObject RewardListNode3;
        public GameObject RewardListNode2;
        public GameObject RewardListNode1;

        public GameObject GameObject;
    }


    public class UIFirstWinRewardComponentAwakeSystem : AwakeSystem<UIFirstWinRewardComponent, GameObject>
    {
        public override void Awake(UIFirstWinRewardComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.RewardListNode3 = rc.Get<GameObject>("RewardListNode3");
            self.RewardListNode2 = rc.Get<GameObject>("RewardListNode2");
            self.RewardListNode1 = rc.Get<GameObject>("RewardListNode1");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.GameObject.SetActive(false); });
        }
    }

    public static class UIFirstWinRewardComponentSystem
    {


        public static void OnUpdateUI(this UIFirstWinRewardComponent self, int firstWinId)
        {
            self.GameObject.SetActive(true);

            UICommonHelper.DestoryChild(self.RewardListNode1);
            UICommonHelper.DestoryChild(self.RewardListNode2);
            UICommonHelper.DestoryChild(self.RewardListNode3);

            FirstWinConfig firstWin = FirstWinConfigCategory.Instance.Get(firstWinId);
            UICommonHelper.ShowItemList(firstWin.RewardList_1, self.RewardListNode1, self, 0.9f, true);
            UICommonHelper.ShowItemList(firstWin.RewardList_2, self.RewardListNode2, self, 0.9f, true);
            UICommonHelper.ShowItemList(firstWin.RewardList_3, self.RewardListNode3, self, 0.9f, true);
        }

    }
}
