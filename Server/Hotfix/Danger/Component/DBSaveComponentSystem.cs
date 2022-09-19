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

        public static async ETTask OnDisconnect(this DBSaveComponent self, int domainZone, long userId)
        {
            long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(domainZone, Enum.GetName(SceneType.Chat)).InstanceId;
            long teamServerId = StartSceneConfigCategory.Instance.GetBySceneName(domainZone, Enum.GetName(SceneType.Team)).InstanceId;

            A2M_ChangeStatusResponse g_SendChatRequest1 = (A2M_ChangeStatusResponse)await ActorMessageSenderComponent.Instance.Call
                (chatServerId, new M2A_ChangeStatusRequest() { SceneType = (int)SceneType.Chat, UserID = userId, UnitId = 0 });
            A2M_ChangeStatusResponse g_SendChatRequest2 = (A2M_ChangeStatusResponse)await ActorMessageSenderComponent.Instance.Call
                (teamServerId, new M2A_ChangeStatusRequest() { SceneType = (int)SceneType.Team, UserID = userId, UnitId = 0 });
        }

        public static async ETTask OnRelogin(this DBSaveComponent self, long gateSessionId)
        {
            Unit unit = self.GetParent<Unit>();

            long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), Enum.GetName(SceneType.Chat)).InstanceId;
            A2M_ChangeStatusResponse g_SendChatRequest1 = (A2M_ChangeStatusResponse)await ActorMessageSenderComponent.Instance.Call
                (chatServerId, new M2A_ChangeStatusRequest()
                {
                    UnitId = unit.Id,
                    SceneType = (int)SceneType.Chat,
                    UserID = unit.GetComponent<UserInfoComponent>().UserInfo.UserId,
                    GateSessionId = gateSessionId
                });
        }

        public static async ETTask OnOffLine(this DBSaveComponent self)
        {
            DBHelper.UpdateCacheDB(self.GetParent<Unit>()).Coroutine();
            
            long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), Enum.GetName(SceneType.Chat)).InstanceId;
            A2M_ChangeStatusResponse g_SendChatRequest1 = (A2M_ChangeStatusResponse)await ActorMessageSenderComponent.Instance.Call
                (chatServerId, new M2A_ChangeStatusRequest()
                {
                    SceneType = (int)SceneType.Chat,
                    UserID = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.UserId,
                    UnitId = self.GetParent<Unit>().Id,
                    GateSessionId = 0
                });
        }

        public static void OnLogin(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            ComHelp.LoginInfo($"{unit.DomainZone()}区： " +
                $" {unit.GetComponent<UserInfoComponent>().UserInfo.Name} : " +
                $"{  TimeHelper.DateTimeNow().ToString()}  {unit.GetComponent<UserInfoComponent>().RemoteAddress} 登录");

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsLong(NumericType.LastGameTime) == 0)
            {
                numericComponent.ApplyValue(NumericType.LastGameTime, TimeHelper.ServerNow(), false);
            }
        }

        public static async ETTask OnDisconnect(this DBSaveComponent self)
        {
            Unit unit = self.GetParent<Unit>();

            ComHelp.LoginInfo($"{unit.DomainZone()}区： " +
             $" {unit.GetComponent<UserInfoComponent>().UserInfo.Name} : " +
             $"{  TimeHelper.DateTimeNow().ToString()}  {unit.GetComponent<UserInfoComponent>().RemoteAddress} 离线");

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            numericComponent.ApplyValue(NumericType.LastGameTime, TimeHelper.ServerNow(), false); 

            unit.RecordPostion();
            unit.GetComponent<EnergyComponent>().OnDisconnect();
            int sceneTypeEnum = unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
            DBHelper.UpdateCacheDB(unit).Coroutine();

            long unitId = unit.Id;
            //通知其他服务器
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            int domainZone = unit.DomainZone();
            long userId = userInfo.UserId;

            await self.OnDisconnect(domainZone, userInfo.UserId);
            Log.Debug($"unitid: {unitId.ToString()} playerId:{unit.GetComponent<UserInfoComponent>().UserInfo.UserId.ToString()}已移除");

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
                //Scene scene = Game.Scene.Get(sceneid);
                bool haveplayer = scene.GetComponent<TeamDungeonComponent>().IsHavePlayer();
                if (!haveplayer)
                {
                    TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                    scene.GetComponent<TeamDungeonComponent>().OnDungeonOff(userId).Coroutine();
                    scene.Dispose();
                }
            }
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
