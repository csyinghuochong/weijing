using System;

namespace ET
{
    [Timer(TimerType.DBSaveTimer)]
    public class DBSaveTimer : ATimer<DBSaveComponent>
    {
        public override void Run(DBSaveComponent self)
        {
            try
            {
                self.Check();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class DBSaveComponentAwakeSystem : AwakeSystem<DBSaveComponent>
    {
        public override void Awake(DBSaveComponent self)
        {
            self.DBInterval = -1;
            self.EntityChangeTypeSet.Clear();
        }
    }

    [ObjectSystem]
    public class DBSaveComponentDestroySystem : DestroySystem<DBSaveComponent>
    {
        public override void Destroy(DBSaveComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [ObjectSystem]
    public class UnitGetComponentSystem : GetComponentSystem<Unit>
    {
        public override void GetComponent(Unit unit, Entity componet)
        {
            Type type = componet.GetType();
            
            if (!typeof(IUnitCache).IsAssignableFrom(type))
            {
                return;
            }
            unit.GetComponent<DBSaveComponent>()?.AddChange(type);
        }
    }

    public static class DBSaveComponentSystem
    {
        public static void Activeted(this DBSaveComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(60000, TimerType.DBSaveTimer, self);
        }

        public static void AddChange(this DBSaveComponent self, Type t)
        {
            self.EntityChangeTypeSet.Add(t);
        }

        public static void UpdateCacheDB(this DBSaveComponent self)
        {
            try
            {
                if (self.EntityChangeTypeSet.Count <= 0)
                {
                    return;
                }
                Unit unit = self.GetParent<Unit>();
                if (unit.IsRobot())
                {
                    return;
                }

                long dbCacheId = DBHelper.GetDbCacheId(unit.DomainZone());
                M2D_SaveUnit message = new M2D_SaveUnit() { UnitId = unit.Id };
                foreach (Type type in self.EntityChangeTypeSet)
                {
                    Entity entity = unit.GetComponent(type);
                    if (entity == null || entity.IsDisposed)
                    {
                        continue;
                    }
                    message.EntityTypes.Add(type.FullName);
                    message.EntityBytes.Add(MongoHelper.ToBson(entity));
                }
                self.EntityChangeTypeSet.Clear();
                MessageHelper.CallActor(dbCacheId, message).Coroutine();
            }
            catch (Exception ex)
            {
                Log.Error("更新缓存服Unit数据出错: " + ex.ToString());
            }
        }

        public static void OnRelogin(this DBSaveComponent self, long gateSessionId)
        {
            Unit unit = self.GetParent<Unit>();
            string offLineInfo = $"{unit.DomainZone()}区： " +
               $"unit.id: {unit.GetComponent<UserInfoComponent>().Id} : " +
               $" {unit.GetComponent<UserInfoComponent>().UserInfo.Name} : " +
               $"{  TimeHelper.DateTimeNow().ToString()}   二次登录";
            LogHelper.LoginInfo(offLineInfo);
            //需要通知其他服务器吗？
            Log.Debug(offLineInfo);
           
            unit.GetComponent<UnitGateComponent>().PlayerState = PlayerState.Game;
        }

        public static  void OnOffLine(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            string offLineInfo = $"{unit.DomainZone()}区： " +
                $"unit.id: {unit.GetComponent<UserInfoComponent>().Id} : " +
                $" {unit.GetComponent<UserInfoComponent>().UserInfo.Name} : " +
                $"{  TimeHelper.DateTimeNow().ToString()}   离线";
            LogHelper.LoginInfo(offLineInfo);
            Log.Debug(offLineInfo);

            unit.GetComponent<UserInfoComponent>().OnOffLine();
            unit.GetComponent<UnitGateComponent>().PlayerState = PlayerState.None;
            self.UpdateCacheDB();
        }

        public static void OnLogin(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            string offLineInfo = $"{unit.DomainZone()}区： " +
               $"unit.id: {unit.GetComponent<UserInfoComponent>().Id} : " +
               $" {unit.GetComponent<UserInfoComponent>().UserInfo.Name} : " +
               $"{  TimeHelper.DateTimeNow().ToString()}   登录";
            LogHelper.LoginInfo(offLineInfo);
            Log.Debug(offLineInfo);

            self.LogTest();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsLong(NumericType.LastGameTime) == 0)
            {
                numericComponent.ApplyValue(NumericType.LastGameTime, TimeHelper.ServerNow(), false);
            }
            unit.GetComponent<UnitGateComponent>().PlayerState = PlayerState.Game;
        }

        public static void LogTest(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.IsRobot())
            {
                return;
            }
            ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();
            LogHelper.LogDebug($"活动领取： {activityComponent.ActivityReceiveIds.Count}  {activityComponent.QuTokenRecvive.Count}");
            LogHelper.LogDebug($"活跃任务： {unit.GetComponent<TaskComponent>().TaskCountryList.Count}");
        }

        public static int OnDisconnect(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            string offLineInfo = $"{unit.DomainZone()}区： " +
              $"unit.id: {unit.GetComponent<UserInfoComponent>().Id} : " +
              $" {unit.GetComponent<UserInfoComponent>().UserInfo.Name} : " +
              $"{  TimeHelper.DateTimeNow().ToString()}  移除";
            LogHelper.LoginInfo(offLineInfo);
            LogHelper.LogDebug(offLineInfo);
            int sceneTypeEnum = unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
            if (sceneTypeEnum == SceneTypeEnum.MainCityScene)
            {
                unit.RecordPostion(sceneTypeEnum, ComHelp.MainCityID());
            }
            unit.GetComponent<EnergyComponent>().OnDisconnect();
            self.LogTest();
            self.UpdateCacheDB();

            long unitId = unit.Id;
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            long userId = userInfo.UserId;
            Scene scene = unit.DomainScene();
            //RolePetInfo fightId = unit.GetComponent<PetComponent>().GetFightPet();
            //unit.RemoveComponent<MailBoxComponent>();
            //unit.GetParent<UnitComponent>().Remove(unitId);
            //if (fightId != null)
            //{
            //    scene.GetComponent<UnitComponent>().Remove(fightId.Id);
            //}

            TransferHelper.BeforeTransfer(unit);
            unit.GetParent<UnitComponent>().Remove(unitId);

            if (SceneConfigHelper.IsSingleFuben(sceneTypeEnum))
            {
                //动态删除副本
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                scene.Dispose();
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.TeamDungeon)
            {
                TeamSceneComponent teamSceneComponent = scene.GetParent<TeamSceneComponent>();
                teamSceneComponent.OnUnitDisconnect(scene, userId);
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.Arena)
            {
                ArenaDungeonComponent areneSceneComponent = scene.GetComponent<ArenaDungeonComponent>();
                areneSceneComponent.OnUnitDisconnect(userId);
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.JiaYuan)
            {
                JiaYuanSceneComponent jiayuanSceneComponent = scene.GetParent<JiaYuanSceneComponent>();
                jiayuanSceneComponent.OnUnitLeave(scene);
            }
            return ErrorCode.ERR_Success;
        }

        public static bool Check(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            if (self.DBInterval == -1 || self.DBInterval >= 5)
            {
                self.DBInterval = 0;
                self.UpdateCacheDB();
            }
            self.DBInterval++;
            unit.GetComponent<TaskComponent>().Check();
            unit.GetComponent<UserInfoComponent>().Check();
            unit.GetComponent<TitleComponent>().OnCheckTitle(true);
            return false;
        }
    }
}
