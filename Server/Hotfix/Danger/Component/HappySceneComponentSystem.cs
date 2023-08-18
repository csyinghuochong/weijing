using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.HappySceneTimer)]
    public class HappySceneTimer : ATimer<HappySceneComponent>
    {
        public override void Run(HappySceneComponent self)
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


    public static class HappySceneComponentSystem
    {

        public static long GetFubenInstanceId(this HappySceneComponent self, int sceneId)
        {
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(self, fubenid, fubenInstanceId, self.DomainZone(), "Happy" + fubenid.ToString(), SceneType.Fuben);
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo((int)SceneTypeEnum.Happy, sceneId, 0);
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(sceneId).MapID.ToString();
            Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
            FubenHelp.CreateNpc(fubnescene, sceneId);

            self.FubenUnitId = fubenid;
            self.FubenInstanceId = fubenInstanceId;

            return fubenInstanceId;
        }

        public static int GetDropId(this HappySceneComponent self,int openDay)
        {
            string dropinfo = GlobalValueConfigCategory.Instance.Get(96).Value;
            string[] dropList = dropinfo.Split('@');

            for (int i = dropList.Length - 1; i >= 0; i--)
            {
                string[] dropitem = dropList[i].Split(';');
                int day = int.Parse(dropitem[0] );
                int dropid = int.Parse((dropitem[1]));

                if (openDay >= day)
                {
                    return dropid;
                }
            }
            return int.Parse(dropList[0].Split(';')[1]);
        }

        public static void OnTimer(this HappySceneComponent self)
        {
            if (self.FubenUnitId == 0)
            {
                return;
            }

            Scene fubnescene = self.GetChild<Scene>(self.FubenUnitId);
            if (fubnescene == null)
            {
                return;
            }

            List<int> dropcells = new List<int>();
            List<Unit> droplist = UnitHelper.GetUnitList(fubnescene, UnitType.DropItem);
            for (int i = 0; i < droplist.Count; i++)
            {
                int dropindex = droplist[i].GetComponent<DropComponent>().CellIndex;
                if (!dropcells.Contains(dropindex))
                {
                    dropcells.Add(dropindex);
                }
            }

            int openDay = ServerHelper.GetOpenServerDay( false, self.DomainZone());
            int dropid = self.GetDropId(openDay);

            for (int p = 0; p < HappyHelper.PositionList.Count; p++)
            { 
                //空格子的概率
                if(RandomHelper.RandFloat01() < 0.5f )
                {
                    continue;
                }
                //该格子有道具
                if(dropcells.Contains(p + 1))
                {
                    continue;   
                }

                List<RewardItem> rewardist = new List<RewardItem>();
                DropHelper.DropIDToDropItem(dropid, rewardist);

                for (int i = 0; i < rewardist.Count; i++)
                {
                    UnitComponent unitComponent = fubnescene.GetComponent<UnitComponent>();
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

            List<Unit> unitlist = UnitHelper.GetUnitList(fubnescene, UnitType.Player);
            self.M2C_HappyInfoResult.NextRefreshTime = TimeHelper.ServerNow() + TimeHelper.Minute;
            MessageHelper.SendToClient(unitlist, self.M2C_HappyInfoResult);
        }

        public static void NoticeRefreshTime(this HappySceneComponent self, Unit unit)
        {
            MessageHelper.SendToClient(unit, self.M2C_HappyInfoResult);
        }

        public static void OnHappyBegin(this HappySceneComponent self)
        {

            Log.Console($"OnHappyBegin： {self.FubenUnitId}");

            if (self.FubenInstanceId != 0)
            {
                return;
            }

            self.GetFubenInstanceId(8000001);
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer( 5 *  TimeHelper.Minute, TimerType.HappySceneTimer, self );

            //先刷新一次
            self.OnTimer();
        }

        public static void OnHappyOver(this HappySceneComponent self)
        {
            Log.Console($"OnHappyOver111： {self.FubenUnitId}");

            TimerComponent.Instance.Remove(ref self.Timer);

            Scene fubnescene = self.GetChild<Scene>(self.FubenUnitId);
            Actor_TransferRequest actor_Transfer = new Actor_TransferRequest()
            {
                SceneType = SceneTypeEnum.MainCityScene,
            };
            if (fubnescene != null)
            {
                Log.Console($"OnHappyOver222： {self.FubenUnitId}");

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
                    TransferHelper.TransferUnit(units[i], actor_Transfer).Coroutine();
                }

                TransferHelper.NoticeFubenCenter(fubnescene, 2).Coroutine();
                fubnescene.Dispose();
            }

            self.FubenUnitId = 0;
            self.FubenInstanceId = 0;
        }

    }
}
