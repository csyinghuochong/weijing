using System;
using System.Linq;

namespace ET
{
    [Timer(TimerType.TowerTimer)]
    public class TowerTimer : ATimer<TowerComponent>
    {
        public override void Run(TowerComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"playerOffline timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class TowerComponentAwakeSystem : AwakeSystem<TowerComponent>
    {
        public override void Awake(TowerComponent self)
        {
            self.TowerId = 0;
        }
    }

    [ObjectSystem]
    public class TowerComponentDestroySystem : DestroySystem<TowerComponent>
    {
        public override void Destroy(TowerComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public  static class TowerComponentSystem
    {

        public static void OnKillEvent(this TowerComponent self, Unit defend)
        {
            if (FubenHelp.IsAllMonsterDead(self.DomainScene()))
            {
                self.OnTowerOver();
                return;
            }
            if (defend.Type == UnitType.Player)
            {
                self.OnTowerOver();
                return;
            }
            self.OnTimer();
        }

        public static void OnTowerOver(this TowerComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);

            string[] ids = GlobalValueConfigCategory.Instance.Get(65).Value.Split(';');
            //int startTowerId = int.Parse(ids[self.FubenDifficulty - 1]); //起始波
            //self.TowerId; //当前波

            M2C_FubenSettlement message = new M2C_FubenSettlement();
            message.BattleResult = 1;
            message.RewardExp = 2000;
            message.RewardGold = 2000;
            MessageHelper.SendToClient(self.MainUnit, message);
        }

        public static void OnTimer(this TowerComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
            //奖励
            int nextTowerId = self.TowerId + 1;
            if (TowerHelper.GetLastTowerId(SceneTypeEnum.Tower) < nextTowerId)
            {
                self.OnTowerOver();
                return;
            }
            self.TowerId = nextTowerId;
            self.CreateMonster().Coroutine();
        }

        public static async ETTask CreateMonster(this TowerComponent self)
        {
            long instanceId = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(3000);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            if (self.MainUnit == null || self.MainUnit.IsDisposed)
            {
                return;
            }
            self.MainUnit.GetComponent<NumericComponent>().ApplyValue(NumericType.TowerId, self.TowerId, true);
            Scene scene = self.DomainScene();
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(self.TowerId);
            self.WaveTime = towerConfig.NextTime * 1000;
            FubenHelp.CreateMonsterList(scene, towerConfig.MonsterSet);

            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewOnceTimer( TimeHelper.ServerNow() + self.WaveTime, TimerType.TowerTimer, self );
        }

        public static void BeginTower(this TowerComponent self)
        {
            string[] ids = GlobalValueConfigCategory.Instance.Get(65).Value.Split(';');
            self.TowerId = int.Parse(ids[self.FubenDifficulty - 1]);
            self.CreateMonster().Coroutine();
        }
    }
}
