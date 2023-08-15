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

            List<RewardItem> droplist = new List<RewardItem>();
            DropHelper.DropIDToDropItem(60500201, droplist);
          
            for (int i = 0; i < droplist.Count; i++)
            {
                UnitComponent unitComponent = fubnescene.GetComponent<UnitComponent>();
                Unit dropitem = unitComponent.AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1);
                dropitem.AddComponent<UnitInfoComponent>();
                dropitem.Type = UnitType.DropItem;
                DropComponent dropComponent = dropitem.AddComponent<DropComponent>();
                dropComponent.SetItemInfo(droplist[i].ItemID, droplist[i].ItemNum);
                Vector3 vector3 = HappyHelper.PositionList[0];
                dropitem.Position = vector3;
                dropitem.AddComponent<AOIEntity, int, Vector3>(9 * 1000, dropitem.Position);
                dropComponent.DropType = 0;
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
            if (self.FubenInstanceId != 0)
            {
                return;
            }

            self.GetFubenInstanceId(8000001);
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(  TimeHelper.Minute, TimerType.HappySceneTimer, self );

            //先刷新一次
            self.OnTimer();
        }

        public static void OnHappyOver(this HappySceneComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);

            Scene fubnescene = self.GetChild<Scene>(self.FubenUnitId);
            if (fubnescene != null)
            {
                TransferHelper.NoticeFubenCenter(fubnescene, 2).Coroutine();
            }

            self.FubenUnitId = 0;
            self.FubenInstanceId = 0;
        }

    }
}
