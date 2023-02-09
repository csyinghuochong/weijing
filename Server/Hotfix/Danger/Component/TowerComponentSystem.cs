using System;
using System.Linq;

namespace ET
{

    [ObjectSystem]
    public class TowerComponentAwakeSystem : AwakeSystem<TowerComponent>
    {
        public override void Awake(TowerComponent self)
        {
            self.TowerId = 0;
            self.Timer = 0;
        }
    }

    [ObjectSystem]
    public class TowerComponentDestroySystem : DestroySystem<TowerComponent>
    {
        public override void Destroy(TowerComponent self)
        {
        }
    }

    public  static class TowerComponentSystem
    {

        public static void OnKillEvent(this TowerComponent self, Unit defend)
        {
            if (FubenHelp.IsAllMonsterDead(self.DomainScene(), self.MainUnit))
            {
                self.OnTimer();
                return;
            }
            if (defend.Type == UnitType.Player)
            {
                self.OnTowerOver();
                return;
            }
        }

        public static void OnTowerOver(this TowerComponent self)
        {
            if (self.TowerId == 0)
            {
                return;
            }
            TimerComponent.Instance.Remove(ref self.Timer);

            string[] ids = GlobalValueConfigCategory.Instance.Get(65).Value.Split(';');
            int startTowerId = int.Parse(ids[self.FubenDifficulty - 1]); //起始波
            int endId =  self.TowerId; //当前波

            M2C_FubenSettlement message = new M2C_FubenSettlement();
            message.BattleResult = 1;
            message.RewardExp = 0;
            message.RewardGold = 0;
            if (endId != 0)
            {
                int cengNum = TowerConfigCategory.Instance.Get(endId).CengNum;
                if (self.TowerId >= 100101 && self.TowerId <= 100199)
                {
                    message.RewardExp = 10000 + cengNum * 3000;
                    message.RewardGold = 1000 + cengNum * 500;
                }

                if (self.TowerId >= 100201 && self.TowerId <= 100299)
                {
                    message.RewardExp = 50000 + cengNum * 5000;
                    message.RewardGold = 2000 + cengNum * 750;
                }

                if (self.TowerId >= 100301 && self.TowerId <= 100399)
                {
                    message.RewardExp = 75000 + cengNum * 7500;
                    message.RewardGold = 3000 + cengNum * 1000;
                }
           
                int itemNum = (int)(cengNum / 5f);
                self.MainUnit.GetComponent<BagComponent>().OnAddItemData("10000148;" + itemNum, $"{ItemGetWay.TiaoZhan}_{TimeHelper.ServerNow()}");
            }
            
            MessageHelper.SendToClient(self.MainUnit, message);

            UserInfoComponent userInfoComponent = self.MainUnit.GetComponent<UserInfoComponent>();
            userInfoComponent.UpdateRoleData(UserDataType.Exp, message.RewardExp.ToString());
            userInfoComponent.UpdateRoleMoneyAdd(UserDataType.Gold, message.RewardGold.ToString(), true, ItemGetWay.TiaoZhan);
            self.TowerId = 0;
        }

        public static void OnTimer(this TowerComponent self)
        {
            //奖励
            self.TowerId = self.MainUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.TowerId);
            if (TowerHelper.GetLastTower(self.FubenDifficulty) == self.TowerId)
            {
                self.OnTowerOver();
                return;
            }
            self.CreateMonster(self.TowerId + 1).Coroutine();
        }

        public static async ETTask CreateMonster(this TowerComponent self, int towerId)
        {
            long instanceId = self.InstanceId;
            self.MainUnit.GetComponent<NumericComponent>().ApplyValue(NumericType.TowerId, towerId, true);
            await TimerComponent.Instance.WaitAsync(2000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            if (self.MainUnit == null || self.MainUnit.IsDisposed)
            {
                return;
            }
            Scene scene = self.DomainScene();
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(towerId);
            self.WaveTime = towerConfig.NextTime * 1000;
            FubenHelp.CreateMonsterList(scene, towerConfig.MonsterSet);
        }

        public static void BeginTower(this TowerComponent self)
        {
            string[] ids = GlobalValueConfigCategory.Instance.Get(65).Value.Split(';');
            int index = self.FubenDifficulty - 1;

            if (index < 0)
            {
                index = 0;
            }
            if (index > 2)
            {
                index = 2;
            }
            self.CreateMonster(int.Parse(ids[index])).Coroutine();
        }
    }
}
