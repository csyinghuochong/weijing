using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITowerFightRewardComponent : Entity, IAwake
    {
        public GameObject Text_Ceng;
        public GameObject Btn_Return;
        public GameObject ItemListNode;
    }

    public class UITowerFightRewardComponentAwake : AwakeSystem<UITowerFightRewardComponent>
    {
        public override void Awake(UITowerFightRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Ceng = rc.Get<GameObject>("Text_Ceng");
            self.Btn_Return = rc.Get<GameObject>("Btn_Return");
            self.Btn_Return.GetComponent<Button>().onClick.AddListener(self.OnBtn_Return);

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
        }
    }

    public static class UITowerFightRewardComponentSystem
    {

        public static void OnUpdateUI(this UITowerFightRewardComponent self, M2C_FubenSettlement message)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int towerId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.TowerId);
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(towerId);

            if (message.BattleResult == CombatResultEnum.Fail)
            {
                self.Text_Ceng.GetComponent<Text>().text = $"挑战失败";
            }
            else
            {
                self.Text_Ceng.GetComponent<Text>().text = $"你当前成功完成挑战{towerConfig.CengNum}波,获得奖励如下:";
            }

            string rewardList = $"1;{message.RewardGold}@2;{message.RewardExp}";
            UICommonHelper.ShowItemList(rewardList, self.ItemListNode, self, 1);
        }

        public static void OnBtn_Return(this UITowerFightRewardComponent self)
        {
            //EnterFubenHelp.RequestQuitFuben(self.ZoneScene());
            UIHelper.Remove(self.ZoneScene(), UIType.UITowerFightReward);
        }
    }

}
