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

        public static async ETTask OnExitTeam(this DBSaveComponent self, int domainZone, long userId)
        {
            long teamServerId = StartSceneConfigCategory.Instance.GetBySceneName(domainZone, Enum.GetName(SceneType.Team)).InstanceId;
            A2M_ChangeStatusResponse g_SendChatRequest2 = (A2M_ChangeStatusResponse)await ActorMessageSenderComponent.Instance.Call
                (teamServerId, new M2A_ChangeStatusRequest() { SceneType = (int)SceneType.Team,  UnitId = userId });
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
            int domainZone = unit.DomainZone();
            long userId = userInfo.UserId;

            self.OnExitTeam(domainZone, userInfo.UserId).Coroutine();

            Scene scene = unit.DomainScene();
            //TransferHelper.BeforeTransfer(unit);
            RolePetInfo fightId = unit.GetComponent<PetComponent>().GetFightPet();
            unit.RemoveComponent<MailBoxComponent>();
            unit.RecordPostion();
            unit.GetParent<UnitComponent>().Remove(unitId);
            if (fightId != null)
            {
                scene.GetComponent<UnitComponent>().Remove(fightId.Id);
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.CellDungeon
                || sceneTypeEnum == (int)SceneTypeEnum.PetTianTi
                || sceneTypeEnum == (int)SceneTypeEnum.Tower
                || sceneTypeEnum == (int)SceneTypeEnum.RandomTower
                || sceneTypeEnum == (int)SceneTypeEnum.LocalDungeon
                || sceneTypeEnum == (int)SceneTypeEnum.PetDungeon)
            {
                //动态删除副本
                //Scene scene = Game.Scene.Get(sceneid);
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                scene.Dispose();
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.TeamDungeon)
            {
                bool haveplayer = scene.GetComponent<TeamDungeonComponent>().IsHavePlayer();
                if (!haveplayer)
                {
                    TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                    scene.GetComponent<TeamDungeonComponent>().OnDungeonOff(userId).Coroutine();
                    scene.Dispose();
                }
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
            unit.GetComponent<NumericComponent>().Check();
            return false;
        }
    }
}
