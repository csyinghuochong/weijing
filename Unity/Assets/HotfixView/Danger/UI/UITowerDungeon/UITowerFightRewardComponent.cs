using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITowerFightRewardComponent : Entity, IAwake
    {
        public GameObject Btn_Return;
        public GameObject ItemListNode;
    }

    public class UITowerFightRewardComponentAwake : AwakeSystem<UITowerFightRewardComponent>
    {
        public override void Awake(UITowerFightRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Return = rc.Get<GameObject>("Btn_Return");
            self.Btn_Return.GetComponent<Button>().onClick.AddListener(self.OnBtn_Return);

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
        }
    }

    public static class UITowerFightRewardComponentSystem
    {

        public static void OnUpdateUI(this UITowerFightRewardComponent self, M2C_FubenSettlement message)
        {
            string rewardList = $"1;{message.RewardGold}@2;{message.RewardExp}";
            UICommonHelper.ShowItemList(rewardList, self.ItemListNode, self, 1);
        }

        public static void OnBtn_Return(this UITowerFightRewardComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UITowerFightReward);
        }
    }

}
