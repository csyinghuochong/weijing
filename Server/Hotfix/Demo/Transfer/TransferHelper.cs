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
            long mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), $"Map{ComHelp.MainCityID()}").InstanceId;
            long oldsceneid = unit.DomainScene().Id;
            //动态删除副本
            Scene scene = unit.DomainScene();
            TransferHelper.BeforeTransfer(unit);
            await TransferHelper.Transfer(unit, mapInstanceId, (int)SceneTypeEnum.MainCityScene, ComHelp.MainCityID(), 0, "0");
            if (SceneConfigHelper.IsSingleFuben(sceneTypeEnum))
            {
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                scene.Dispose();
            }
            if (sceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                TeamSceneComponent teamSceneComponent = scene.GetParent<TeamSceneComponent>();
                teamSceneComponent.OnUnitReturn(scene, userId);
            }
            if (sceneTypeEnum == SceneTypeEnum.JiaYuan)
            {
                JiaYuanSceneComponent jiayuanSceneComponent = scene.GetParent<JiaYuanSceneComponent>();
                jiayuanSceneComponent.OnUnitLeave(scene);
            }
        }

        public static async ETTask LocalDungeonTransfer(Unit unit, int sceneId, int transferId, int difficulty)
        {
            long oldsceneid = unit.DomainScene().Id;

            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "LocalDungeon" + fubenid.ToString(), SceneType.Fuben);
            LocalDungeonComponent localDungeon = fubnescene.AddComponent<LocalDungeonComponent>();
            localDungeon.FubenDifficulty = difficulty;
            sceneId = transferId != 0 ? DungeonTransferConfigCategory.Instance.Get(transferId).MapID : sceneId;
            fubnescene.GetComponent<MapComponent>().SetMapInfo((int)SceneTypeEnum.LocalDungeon, sceneId, 0);
            TransferHelper.BeforeTransfer(unit);
            await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.LocalDungeon, sceneId, difficulty, transferId.ToString());
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();

            Scene scene = Game.Scene.Get(oldsceneid);
            MapComponent mapComponent = scene.GetComponent<MapComponent>(); 
            if (transferId != 0 && mapComponent.SceneTypeEnum != SceneTypeEnum.LocalDungeon)
            {
                Log.Error($"transferId != 0:   {transferId} {mapComponent.SceneTypeEnum}");
            }
            if (transferId != 0 && scene.GetComponent<LocalDungeonComponent>()!=null)
            {
                //动态删除副本
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
                scene.Dispose();
            }
        }

        /// <summary>
        /// 必须等待返回才能执行销毁场景的操作
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="sceneInstanceId"></param>
        /// <param name="sceneType"></param>
        /// <param name="sceneId"></param>
        /// <param name="sonId"></param>
        /// <param name="paramInfoId"></param>
        /// <returns></returns>
        public static async ETTask Transfer(Unit unit, long sceneInstanceId, int sceneType, int sceneId, int fubenDifficulty,  string paramInfo)
        {
            // 通知客户端开始切场景
            M2C_StartSceneChange m2CStartSceneChange = new M2C_StartSceneChange() {SceneInstanceId = sceneInstanceId, SceneType = sceneType, ChapterId = sceneId, Difficulty = fubenDifficulty, ParamInfo = paramInfo };
            MessageHelper.SendToClient(unit, m2CStartSceneChange);
            
            M2M_UnitTransferRequest request = new M2M_UnitTransferRequest();
            request.Unit = unit;
            foreach (Entity entity in unit.Components.Values)
            {
                if (entity is ITransfer)
                {
                    //request.Entitys.Add(entity);
                    request.EntityBytes.Add(MongoHelper.ToBson(entity));
                }
            }
            request.SceneType = sceneType;
            request.ChapterId = sceneId;
            request.Difficulty = fubenDifficulty;
            request.ParamInfo = paramInfo;
            // 删除Mailbox,让发给Unit的ActorLocation消息重发
            unit.RemoveComponent<MailBoxComponent>();

            // location加锁
            long oldInstanceId = unit.InstanceId;
            await LocationProxyComponent.Instance.Lock(unit.Id, unit.InstanceId);
            UnitComponent unitComponent = unit.GetParent<UnitComponent>();
            M2M_UnitTransferResponse response = await ActorMessageSenderComponent.Instance.Call(sceneInstanceId, request) as M2M_UnitTransferResponse;
            await LocationProxyComponent.Instance.UnLock(unit.Id, oldInstanceId, response.NewInstanceId);
            if (oldInstanceId == unit.InstanceId)
            {
                unitComponent.Remove(unit.Id);
            }
            //unit.Dispose();
        }

        public static void AfterTransfer(Unit unit)
        {
            RolePetInfo fightId = unit.GetComponent<PetComponent>().GetFightPet();
            if (fightId != null)
            {
                UnitFactory.CreatePet(unit, fightId);
            }
            int jinglingid  = unit.GetComponent<ChengJiuComponent>().JingLingId;
            if (jinglingid != 0)
            {
                unit.GetComponent<ChengJiuComponent>().JingLingUnitId = UnitFactory.CreateJingLing(unit, jinglingid).Id;
            }
        }

        public static void BeforeTransfer(Unit unit)
        {
            //删除unit,让其它进程发送过来的消息找不到actor，重发
            //Game.EventSystem.Remove(unitId);
            // 删除Mailbox,让发给Unit的ActorLocation消息重发
            unit.RemoveComponent<MailBoxComponent>();
            unit.GetComponent<SkillPassiveComponent>()?.Stop();
            unit.GetComponent<BuffManagerComponent>().BeforeTransfer();

            EventType.NumericChangeEvent.Instance.Attack = null;
            unit.GetComponent<HeroDataComponent>().OnKillZhaoHuan(EventType.NumericChangeEvent.Instance);
            UnitComponent unitComponent = unit.DomainScene().GetComponent<UnitComponent>();
            RolePetInfo fightId = unit.GetComponent<PetComponent>().GetFightPet();
            if (fightId != null)
            {
                unitComponent.Remove(fightId.Id);
            }
            long jinglingUnitId = unit.GetComponent<ChengJiuComponent>().JingLingUnitId;
            if (jinglingUnitId != 0 && unitComponent.Get(jinglingUnitId)!=null)
            {
                unitComponent.Remove(jinglingUnitId);
            }
            unit.GetComponent<ChengJiuComponent>().JingLingUnitId = 0;
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