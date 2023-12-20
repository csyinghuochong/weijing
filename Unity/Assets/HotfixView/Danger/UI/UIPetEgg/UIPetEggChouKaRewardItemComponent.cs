using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetEggChouKaRewardItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject RewardListNode;
        public GameObject TextZuanshi;
        public GameObject Btn_Reward;
        public GameObject TextNeedTimes;
        public int RewardKey;
    }

    public class UIPetEggChouKaRewardItemComponentAwakeSystem: AwakeSystem<UIPetEggChouKaRewardItemComponent, GameObject>
    {
        public override void Awake(UIPetEggChouKaRewardItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.TextZuanshi = rc.Get<GameObject>("TextZuanshi");

            self.Btn_Reward = rc.Get<GameObject>("Btn_Reward");
            ButtonHelp.AddListenerEx(self.Btn_Reward, () => { self.OnBtn_Reward().Coroutine(); });

            self.TextNeedTimes = rc.Get<GameObject>("TextNeedTimes");
        }
    }

    public static class UIPetEggChouKaRewardItemComponentSystem
    {
        public static async ETTask OnBtn_Reward(this UIPetEggChouKaRewardItemComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            bool received = userInfoComponent.UserInfo.PetExploreRewardIds.Contains(self.RewardKey);
            if (received)
            {
                return;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.PetExploreNumber) < self.RewardKey)
            {
                FloatTipManager.Instance.ShowFloatTip("条件未达到！");
                return;
            }

            if (self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace() < ConfigHelper.PetExploreReward[self.RewardKey].Split('@').Length - 1)
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足！");
                return;
            }

            C2M_PetExploreReward request = new C2M_PetExploreReward() { RewardId = self.RewardKey };
            M2C_PetExploreReward response =
                    (M2C_PetExploreReward)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error == ErrorCode.ERR_Success)
            {
                userInfoComponent.UserInfo.ChouKaRewardIds.Add(self.RewardKey);
            }

            self.UpdateButton();
        }

        public static void UpdateButton(this UIPetEggChouKaRewardItemComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            bool received = userInfoComponent.UserInfo.PetExploreRewardIds.Contains(self.RewardKey);
            self.Btn_Reward.SetActive(!received);
        }

        public static void OnUpdateUI(this UIPetEggChouKaRewardItemComponent self, int key)
        {
            self.RewardKey = key;
            string[] reward = ConfigHelper.PetExploreReward[key].Split('$');
            string[] items = reward[0].Split('@');
            List<RewardItem> rewardItems = new List<RewardItem>();
            foreach (string item in items)
            {
                string[] it = item.Split(';');
                rewardItems.Add(new RewardItem() { ItemID = int.Parse(it[0]), ItemNum = int.Parse(it[1]) });
            }

            UICommonHelper.ShowItemList(rewardItems, self.RewardListNode, self, 0.8f);
            string[] diamond = reward[1].Split(';')[1].Split(',');
            self.TextZuanshi.GetComponent<Text>().text = $"{diamond[0]}-{diamond[1]}";
            self.TextNeedTimes.GetComponent<Text>().text = $"探索次数达到{key}次";

            self.UpdateButton();
        }
    }
}