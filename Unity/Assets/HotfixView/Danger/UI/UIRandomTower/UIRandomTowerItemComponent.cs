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

        public TowerConfig TowerConfig;
    }


    public class UIRandomTowerItemComponentAwakeSystem : AwakeSystem<UIRandomTowerItemComponent, GameObject>
    {
        public override void Awake(UIRandomTowerItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            
            self.TextLevel = rc.Get<GameObject>("TextLevel");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.ButtonReward = rc.Get<GameObject>("ButtonReward");
            ButtonHelp.AddListenerEx( self.ButtonReward, self.OnButtonReward);
        }
    }

    public static class UIRandomTowerItemComponentSystem
    {
        public static void OnInitUI(this UIRandomTowerItemComponent self, TowerConfig towerRewardConfig)
        {
            self.TowerConfig = towerRewardConfig;
            self.TextLevel.GetComponent<Text>().text =  $"{towerRewardConfig.CengNum} 层";
            UICommonHelper.ShowItemList(towerRewardConfig.DropShow, self.ItemListNode, self);

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            self.SetRewarded( userInfo.TowerRewardIds.Contains(towerRewardConfig.Id) );
        }

        public static void  OnButtonReward(this UIRandomTowerItemComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.TowerRewardIds.Contains(self.TowerConfig.Id))
            {
                FloatTipManager.Instance.ShowFloatTip("已领取过该奖励！");
                return;
            }
            int randomTowerId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RandomTowerId);
            if (randomTowerId < self.TowerConfig.Id )
            {
                FloatTipManager.Instance.ShowFloatTip("为达到领取条件！");
                return;
            }
            NetHelper.RequestTowerReward(self.ZoneScene(), self.TowerConfig.Id).Coroutine();
            self.SetRewarded(true);
        }

        public static void SetRewarded(this UIRandomTowerItemComponent self, bool reward)
        {
            self.ButtonReward.SetActive(!reward);
        }
    }
}
