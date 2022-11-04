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
            self.DBInterval = 0;
            self.ChangeComponent.Clear();
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

        public static void AddChange(this DBSaveComponent self, Type type)
        {
            if (!self.ChangeComponent.Contains(type.Name))
            {
                self.ChangeComponent.Add(type.Name);
            }
        }

        public static void OnRelogin(this DBSaveComponent self, long gateSessionId)
        {
            Unit unit = self.GetParent<Unit>();
            string offLineInfo = $"{unit.DomainZone()}区： " +
               $"unit.id: {unit.GetComponent<UserInfoComponent>().Id} : " +
               $" {unit.GetComponent<UserInfoComponent>().UserInfo.Name} : " +
               $"{  TimeHelper.DateTimeNow().ToString()}   二次登录";
            ComHelp.LoginInfo(offLineInfo);
            //需要通知其他服务器吗？
            Log.Debug(offLineInfo);
        }

        public static  void OnOffLine(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            string offLineInfo = $"{unit.DomainZone()}区： " +
                $"unit.id: {unit.GetComponent<UserInfoComponent>().Id} : " +
                $" {unit.GetComponent<UserInfoComponent>().UserInfo.Name} : " +
                $"{  TimeHelper.DateTimeNow().ToString()}   离线";
            ComHelp.LoginInfo(offLineInfo);
            Log.Debug(offLineInfo);

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            numericComponent.ApplyValue(NumericType.LastGameTime, TimeHelper.ServerNow(), false);
            unit.GetComponent<UserInfoComponent>().LastLoginTime = TimeHelper.ServerNow();
            DBHelper.UpdateCacheDB(self.GetParent<Unit>()).Coroutine();
        }

        public static void OnLogin(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            string offLineInfo = $"{unit.DomainZone()}区： " +
               $"unit.id: {unit.GetComponent<UserInfoComponent>().Id} : " +
               $" {unit.GetComponent<UserInfoComponent>().UserInfo.Name} : " +
               $"{  TimeHelper.DateTimeNow().ToString()}   登录";
            ComHelp.LoginInfo(offLineInfo);
            Log.Debug(offLineInfo);

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsLong(NumericType.LastGameTime) == 0)
            {
                numericComponent.ApplyValue(NumericType.LastGameTime, TimeHelper.ServerNow(), false);
            }
        }

        public static int OnDisconnect(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            string offLineInfo = $"{unit.DomainZone()}区： " +
              $"unit.id: {unit.GetComponent<UserInfoComponent>().Id} : " +
              $" {unit.GetComponent<UserInfoComponent>().UserInfo.Name} : " +
              $"{  TimeHelper.DateTimeNow().ToString()}  移除";
            ComHelp.LoginInfo(offLineInfo);
            Log.Debug(offLineInfo);

            unit.RecordPostion();
            unit.GetComponent<EnergyComponent>().OnDisconnect();
            int sceneTypeEnum = unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
            DBHelper.UpdateCacheDB(unit).Coroutine();

            long unitId = unit.Id;
            //通知其他服务器
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            long userId = userInfo.UserId;
            Scene scene = unit.DomainScene();
            RolePetInfo fightId = unit.GetComponent<PetComponent>().GetFightPet();
            unit.RemoveComponent<MailBoxComponent>();
            unit.GetParent<UnitComponent>().Remove(unitId);
            if (fightId != null)
            {
                scene.GetComponent<UnitComponent>().Remove(fightId.Id);
            }
           
            if (ComHelp.IsSingleFuben(sceneTypeEnum))
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
            return ErrorCode.ERR_Success;
        }

        public static bool Check(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            self.DBInterval++;
            if (self.DBInterval >= 5)
            {
                self.DBInterval = 0;
                DBHelper.UpdateCacheDB(unit).Coroutine();
            }
            unit.GetComponent<TaskComponent>().Check();
            unit.GetComponent<UserInfoComponent>().Check();
            return false;
        }
    }
}
