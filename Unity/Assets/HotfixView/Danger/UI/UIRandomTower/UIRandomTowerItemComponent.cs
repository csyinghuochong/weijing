using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRandomTowerItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextLevel;
        public GameObject ItemListNode;
        public GameObject ButtonReward;

        public RandomTowerRewardConfig TowerRewardConfig;
    }

    [ObjectSystem]
    public class UIRandomTowerItemComponentAwakeSystem : AwakeSystem<UIRandomTowerItemComponent, GameObject>
    {
        public override void Awake(UIRandomTowerItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            
            self.TextLevel = rc.Get<GameObject>("TextLevel");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.ButtonReward = rc.Get<GameObject>("ButtonReward");
            ButtonHelp.AddListenerEx( self.ButtonReward, () => { self.OnButtonReward().Coroutine();  } );
        }
    }

    public static class UIRandomTowerItemComponentSystem
    {
        public static void OnInitUI(this UIRandomTowerItemComponent self, RandomTowerRewardConfig towerRewardConfig)
        {
            self.TowerRewardConfig = towerRewardConfig;
            self.TextLevel.GetComponent<Text>().text =  $"{towerRewardConfig.CengNum[1]} 层";
            UICommonHelper.ShowItemList(towerRewardConfig.RewardList, self.ItemListNode, self);

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            self.SetRewarded( userInfo.TowerRewardIds.Contains(towerRewardConfig.Id) );
        }

        public static async ETTask OnButtonReward(this UIRandomTowerItemComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.TowerRewardIds.Contains(self.TowerRewardConfig.Id))
            {
                FloatTipManager.Instance.ShowFloatTip("已领取过该奖励！");
                return;
            }
            int cengNum = 0;
            int randomTowerId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RandomTowerId);
            if (randomTowerId != 0)
            {
                cengNum = RandomTowerConfigCategory.Instance.Get(randomTowerId).CengNum;
            }
            if (cengNum < self.TowerRewardConfig.CengNum[1] )
            {
                FloatTipManager.Instance.ShowFloatTip("为达到领取条件！");
                return;
            }

            C2M_RandomTowerRewardRequest c2M_RandomTowerRewardRequest = new C2M_RandomTowerRewardRequest() {  RewardId  =self.TowerRewardConfig.Id };
            M2C_RandomTowerRewardResponse m2C_RandomTowerRewardResponse = (M2C_RandomTowerRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RandomTowerRewardRequest);

            userInfo.TowerRewardIds.Add( self.TowerRewardConfig.Id);
            self.SetRewarded(true);
        }

        public static void SetRewarded(this UIRandomTowerItemComponent self, bool reward)
        {
            self.ButtonReward.SetActive(!reward);
        }
    }
}
