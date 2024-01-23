using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [Timer(TimerType.HappyDungeonTimer)]
    public class HappyDungeonTimer : ATimer<HappyDungeonComponent>
    {
        public override void Run(HappyDungeonComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class HappyDungeonComponentDestory : DestroySystem<HappyDungeonComponent>
    {
        public override void Destroy(HappyDungeonComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public static class HappyDungeonComponentSystem
    {

        public static int GetDropId(this HappyDungeonComponent self, int openDay)
        {
            string dropinfo = GlobalValueConfigCategory.Instance.Get(96).Value;
            string[] dropList = dropinfo.Split('@');

            for (int i = dropList.Length - 1; i >= 0; i--)
            {
                string[] dropitem = dropList[i].Split(';');
                int day = int.Parse(dropitem[0]);
                int dropid = int.Parse((dropitem[1]));

                if (openDay >= day)
                {
                    return dropid;
                }
            }
            return int.Parse(dropList[0].Split(';')[1]);
        }

        public static void OnHappyBegin(this HappyDungeonComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(HappyHelper.ItemFreshTime, TimerType.HappyDungeonTimer, self);

            //先刷新一次
            self.OnTimer();
        }

        public static async ETTask OnHappyOver(this HappyDungeonComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
            Scene fubnescene = self.DomainScene();
            Actor_TransferRequest actor_Transfer = new Actor_TransferRequest()
            {
                SceneType = SceneTypeEnum.MainCityScene,
            };

            await TimerComponent.Instance.WaitAsync(TimeHelper.Minute);
            List<Unit> units = fubnescene.GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Type != UnitType.Player)
                {
                    continue;
                }
                if (units[i].IsDisposed || units[i].IsRobot())
                {
                    continue;
                }
                await TransferHelper.TransferUnit(units[i], actor_Transfer);
            }
            await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(10000, 20000));
            TransferHelper.NoticeFubenCenter(fubnescene, 2).Coroutine();
            fubnescene.Dispose();
        }

        public static void OnTimer(this HappyDungeonComponent self)
        {
           
            List<int> dropcells = new List<int>();
            List<Unit> droplist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.DropItem);
            for (int i = 0; i < droplist.Count; i++)
            {
                int dropindex = droplist[i].GetComponent<DropComponent>().CellIndex;
                if (!dropcells.Contains(dropindex))
                {
                    dropcells.Add(dropindex);
                }
            }

            int openDay = ServerHelper.GetOpenServerDay(false, self.DomainZone());
            int dropid = self.GetDropId(openDay);

            for (int p = 0; p < HappyHelper.PositionList.Count; p++)
            {
                //空格子的概率
                if (RandomHelper.RandFloat01() < 0.3f)
                {
                    continue;
                }
                //该格子有道具
                if (dropcells.Contains(p + 1))
                {
                    continue;
                }

                List<RewardItem> rewardist = new List<RewardItem>();
                DropHelper.DropIDToDropItem(dropid, rewardist);
                if (rewardist.Count > 100)
                {
                    Log.Error($"rewardist.Count > 100:   {dropid}");
                    break;
                }

                UnitComponent unitComponent = self.DomainScene().GetComponent<UnitComponent>();
                for (int i = 0; i < rewardist.Count; i++)
                {
                    Unit dropitem = unitComponent.AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1);
                    unitComponent.Add(dropitem);
                    dropitem.AddComponent<UnitInfoComponent>();
                    dropitem.Type = UnitType.DropItem;
                    DropComponent dropComponent = dropitem.AddComponent<DropComponent>();
                    dropComponent.SetItemInfo(rewardist[i].ItemID, rewardist[i].ItemNum);
                    dropComponent.CellIndex = p + 1;

                    Vector3 vector3 = HappyHelper.PositionList[p];
                    dropitem.Position = vector3;
                    dropitem.AddComponent<AOIEntity, int, Vector3>(2 * 1000, dropitem.Position);
                    dropComponent.DropType = 0;
                }
            }

            List<Unit> unitlist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);
            self.M2C_HappyInfoResult.NextRefreshTime = TimeHelper.ServerNow() + HappyHelper.ItemFreshTime;
            MessageHelper.SendToClient(unitlist, self.M2C_HappyInfoResult);
        }

        public static void NoticeRefreshTime(this HappyDungeonComponent self, Unit unit)
        {
            MessageHelper.SendToClient(unit, self.M2C_HappyInfoResult);
        }
    }
}
