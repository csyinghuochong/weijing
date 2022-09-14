namespace ET
{
    public static class TransferHelper
    {
        public static async ETTask MainCityTransfer(Unit unit)
        {
            MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();
            int sceneTypeEnum = mapComponent.SceneTypeEnum;
            long userId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId;
            //传送回主场景
            long mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), "Map1").InstanceId;
            long oldsceneid = unit.DomainScene().Id;
            TransferHelper.BeforeReturnMainScene(unit);
            await  TransferHelper.Transfer(unit, mapInstanceId, (int)SceneTypeEnum.MainCityScene, ComHelp.MainCityID(), 0);
            //动态删除副本
            Scene scene = Game.Scene.Get(oldsceneid);
            if (sceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                bool haveplayer = scene.GetComponent<TeamDungeonComponent>().IsHavePlayer();
                if (!haveplayer)
                {
                    TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                    scene.GetComponent<TeamDungeonComponent>().OnDungeonOff(userId).Coroutine();
                    scene.Dispose();
                }
            }
            else
            {
                if (sceneTypeEnum != SceneTypeEnum.YeWaiScene)
                {
                    TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                    scene.Dispose();
                }
            }
        }

        public static void DungeonTransfer(Unit unit, int sceneId, int transferId, int difficulty = 0)
        {
            long oldsceneid = unit.DomainScene().Id;

            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "LocalDungeon" + fubenid.ToString(), SceneType.Fuben);
            fubnescene.AddComponent<WaitReviveComponent>();
            fubnescene.AddComponent<LocalDungeonComponent>();
            sceneId = transferId != 0 ? DungeonTransferConfigCategory.Instance.Get(transferId).MapID : sceneId;
            TransferHelper.BeforeTransfer(unit);
            TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.LocalDungeon, sceneId, 0, transferId).Coroutine();
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            if (transferId != 0)
            {
                //动态删除副本
                Scene scene = Game.Scene.Get(oldsceneid);
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                scene.Dispose();
            }
        }

        public static async ETTask Transfer(Unit unit, long sceneInstanceId, int sceneType, int chapterId, int sonId, int transferId=0)
        {
            // 通知客户端开始切场景
            M2C_StartSceneChange m2CStartSceneChange = new M2C_StartSceneChange() {SceneInstanceId = sceneInstanceId, SceneType = sceneType, ChapterId = chapterId, SonId = sonId};
            MessageHelper.SendToClient(unit, m2CStartSceneChange);
            
            M2M_UnitTransferRequest request = new M2M_UnitTransferRequest();
            request.Unit = unit;
            foreach (Entity entity in unit.Components.Values)
            {
                if (entity is ITransfer)
                {
                    request.Entitys.Add(entity);
                }
            }
            request.SceneType = sceneType;
            request.ChapterId = chapterId;
            request.TransferId = transferId;
            request.SonId = sonId;
            // 删除Mailbox,让发给Unit的ActorLocation消息重发
            unit.RemoveComponent<MailBoxComponent>();

            // location加锁
            long oldInstanceId = unit.InstanceId;
            await LocationProxyComponent.Instance.Lock(unit.Id, unit.InstanceId);
            M2M_UnitTransferResponse response = await ActorMessageSenderComponent.Instance.Call(sceneInstanceId, request) as M2M_UnitTransferResponse;
            await LocationProxyComponent.Instance.UnLock(unit.Id, oldInstanceId, response.NewInstanceId);
            if (oldInstanceId == unit.InstanceId)
            {
                unit.GetParent<UnitComponent>().Remove(unit.Id);
            }
            //unit.Dispose();
        }

        public static void BeforeTransfer(Unit unit)
        {
            //删除unit,让其它进程发送过来的消息找不到actor，重发
            //Game.EventSystem.Remove(unitId);
            // 删除Mailbox,让发给Unit的ActorLocation消息重发
            unit.RemoveComponent<MailBoxComponent>();

            RolePetInfo fightId = unit.GetComponent<PetComponent>().GetFightPet();
            if (fightId != null)
            {
                unit.DomainScene().GetComponent<UnitComponent>().Remove(fightId.Id);
            }
        }

        public static void BeforeReturnMainScene(Unit unit)
        {
            //删除unit,让其它进程发送过来的消息找不到actor，重发
            //Game.EventSystem.Remove(unitId);
            // 删除Mailbox,让发给Unit的ActorLocation消息重发
            unit.RemoveComponent<MailBoxComponent>();
            //清除玩家当前状态，不然序列化报错
            unit.RecordPostion();
            unit.GetComponent<BuffManagerComponent>().RecordBuff();
            RolePetInfo fightId = unit.GetComponent<PetComponent>().GetFightPet();
            if (fightId != null)
            {
                unit.DomainScene().GetComponent<UnitComponent>().Remove(fightId.Id);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="operateType">1创建副本 2销毁副本</param>
        /// <returns></returns>
        public static async ETTask NoticeFubenCenter(Scene scene, int operateType)
        {
            long fubencenterId = DBHelper.GetFubenCenterId(scene.DomainZone());
            M2F_FubenCenterOperateRequest request = new M2F_FubenCenterOperateRequest()
            {
                OperateType = operateType,
                FubenInstanceId = scene.InstanceId
            };
            F2M_FubenCenterOpenResponse response = (F2M_FubenCenterOpenResponse)await ActorMessageSenderComponent.Instance.Call(fubencenterId, request);
            if (operateType == 1 )
            { 
                scene.GetComponent<ServerInfoComponent>().ServerInfo = response.ServerInfo;
            }
        }
    }
}