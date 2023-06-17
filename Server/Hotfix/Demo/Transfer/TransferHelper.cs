using Alipay.AopSdk.Core.Domain;
using System;

namespace ET
{
    public static class TransferHelper
    {
        public static async ETTask<int> TransferUnit(Unit unit, Actor_TransferRequest request)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Transfer, unit.Id))
            {
                int oldScene = unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
                if (!SceneConfigHelper.CanTransfer(oldScene, request.SceneType))
                {
                    Log.Debug($"LoginTest1  Actor_Transfer unitId{unit.Id} oldScene:{oldScene}  requestscene{request.SceneType}");
                    return ErrorCore.ERR_RequestRepeatedly;
                }
                UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
                if (SceneConfigHelper.UseSceneConfig(request.SceneType) && request.SceneId > 0)
                {
                    SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(request.SceneId);
                    if (sceneConfig.DayEnterNum > 0 && sceneConfig.DayEnterNum <= userInfoComponent.GetSceneFubenTimes(request.SceneId))
                    {
                        return ErrorCore.ERR_TimesIsNot;
                    }
                    if (sceneConfig.EnterLv > userInfoComponent.UserInfo.Lv)
                    {
                        return ErrorCore.ERR_LevelIsNot;
                    }
                    userInfoComponent.AddSceneFubenTimes(request.SceneId);
                }
                if (oldScene == SceneTypeEnum.MainCityScene && request.SceneType > SceneTypeEnum.MainCityScene)
                {
                    unit.RecordPostion(request.SceneType, request.SceneId);
                }

                switch (request.SceneType)
                {
                    case SceneTypeEnum.MainCityScene:
                        await TransferHelper.MainCityTransfer(unit);
                        break;
                    case (int)SceneTypeEnum.CellDungeon:
                        break;
                    //宠物闯关
                    case (int)SceneTypeEnum.PetDungeon:
                        int petfubenid = int.Parse(request.paramInfo);
                        if (!PetFubenConfigCategory.Instance.Contain(petfubenid))
                        {
                            return ErrorCore.ERR_ModifyData;
                        }
                        Scene oldscene = unit.DomainScene();
                        MapComponent mapComponent = oldscene.GetComponent<MapComponent>();
                        int sceneTypeEnum = mapComponent.SceneTypeEnum;
                        long fubenid = IdGenerater.Instance.GenerateId();
                        long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
                        Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "PetFuben" + fubenid.ToString(), SceneType.Fuben);
                        fubnescene.AddComponent<PetFubenSceneComponent>();
                        fubnescene.GetComponent<MapComponent>().SetMapInfo((int)SceneTypeEnum.PetDungeon, request.SceneId, int.Parse(request.paramInfo));
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.PetDungeon, request.SceneId, FubenDifficulty.None, request.paramInfo);
                        TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
                        if (SceneConfigHelper.IsSingleFuben(sceneTypeEnum))
                        {
                            TransferHelper.NoticeFubenCenter(oldscene, 2).Coroutine();
                            oldscene.Dispose();
                        }
                        break;
                    case (int)SceneTypeEnum.TrialDungeon:
                        fubenid = IdGenerater.Instance.GenerateId();
                        fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
                        fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "TrialDungeon" + fubenid.ToString(), SceneType.Fuben);
                        fubnescene.AddComponent<TrialDungeonComponent>();
                        mapComponent = fubnescene.GetComponent<MapComponent>();
                        mapComponent.SetMapInfo((int)SceneTypeEnum.TrialDungeon, request.SceneId, int.Parse(request.paramInfo));
                        mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(request.SceneId).MapID.ToString();
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.TrialDungeon, request.SceneId, FubenDifficulty.None, request.paramInfo);
                        TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
                        break;
                    case (int)SceneTypeEnum.RandomTower:
                        //2200001
                        fubenid = IdGenerater.Instance.GenerateId();
                        fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
                        fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "RandomTower" + fubenid.ToString(), SceneType.Fuben);
                        fubnescene.AddComponent<RandomTowerComponent>();
                        mapComponent = fubnescene.GetComponent<MapComponent>();
                        mapComponent.SetMapInfo((int)SceneTypeEnum.RandomTower, request.SceneId, 0);
                        mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(request.SceneId).MapID.ToString();
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.RandomTower, request.SceneId, 0, "0");
                        TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
                        break;
                    case (int)SceneTypeEnum.Union:
                        long unionid = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0);
                        if (unionid == 0)
                        {
                            return ErrorCore.ERR_Union_Not_Exist;
                        }
                        long mapInstanceId = DBHelper.GetUnionServerId(unit.DomainZone());
                        U2M_UnionEnterResponse responseUnionEnter = (U2M_UnionEnterResponse)await ActorMessageSenderComponent.Instance.Call(
                        mapInstanceId, new M2U_UnionEnterRequest() { UnionId = unionid, UnitId = unit.Id, SceneId = request.SceneId });
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, responseUnionEnter.FubenInstanceId, (int)SceneTypeEnum.Union, request.SceneId, request.Difficulty, "0");
                        break;
                    case (int)SceneTypeEnum.JiaYuan:
                        //动态创建副本
                        Scene scene = unit.DomainScene();
                        mapInstanceId = DBHelper.GetJiaYuanServerId(unit.DomainZone());
                        ///进入之前先刷新一下
                        if (long.Parse(request.paramInfo) == unit.Id)
                        {
                            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
                            jiaYuanComponent.OnBeforEnter();
                            await DBHelper.SaveComponent(unit.DomainZone(), unit.Id, jiaYuanComponent);
                        }
                        J2M_JiaYuanEnterResponse j2M_JianYuanEnterResponse = (J2M_JiaYuanEnterResponse)await ActorMessageSenderComponent.Instance.Call(
                        mapInstanceId, new M2J_JiaYuanEnterRequest() { MasterId = long.Parse(request.paramInfo), UnitId = unit.Id, SceneId = request.SceneId });
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, j2M_JianYuanEnterResponse.FubenInstanceId, (int)SceneTypeEnum.JiaYuan, request.SceneId, request.Difficulty, "0");

                        if (oldScene == SceneTypeEnum.JiaYuan)
                        {
                            JiaYuanSceneComponent jiayuanSceneComponent = scene.GetParent<JiaYuanSceneComponent>();
                            jiayuanSceneComponent.OnUnitLeave(scene);
                        }
                        break;
                    case (int)SceneTypeEnum.Tower:
                        //动态创建副本
                        fubenid = IdGenerater.Instance.GenerateId();
                        fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
                        fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "Tower" + fubenid.ToString(), SceneType.Fuben);
                        fubnescene.AddComponent<TowerComponent>().FubenDifficulty = request.Difficulty;
                        mapComponent = fubnescene.GetComponent<MapComponent>();
                        mapComponent.SetMapInfo((int)SceneTypeEnum.Tower, request.SceneId, 0);
                        mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(request.SceneId).MapID.ToString();
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.Tower, request.SceneId, request.Difficulty, "0");
                        TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
                        break;
                    case (int)SceneTypeEnum.PetTianTi:
                        ////动态创建副本
                        long enemyId = long.Parse(request.paramInfo);
                        fubenid = IdGenerater.Instance.GenerateId();
                        fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
                        fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "Fuben" + fubenid.ToString(), SceneType.Fuben);
                        fubnescene.AddComponent<PetTianTiComponent>().EnemyId = enemyId;
                        fubnescene.GetComponent<MapComponent>().SetMapInfo((int)SceneTypeEnum.PetTianTi, request.SceneId, 0);
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.PetTianTi, request.SceneId, 0, "0");
                        TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
                        break;
                    case (int)SceneTypeEnum.LocalDungeon:
                        if (request.Difficulty < 1 || request.Difficulty > 3)
                        {
                            request.Difficulty = 1;
                        }
                        if (request.SceneId > 0)
                        {
                            int chaptierd = 1;
                            if (DungeonSectionConfigCategory.Instance.DungeonToChapter.ContainsKey(request.SceneId))
                            {
                                chaptierd = DungeonSectionConfigCategory.Instance.DungeonToChapter[request.SceneId];
                            }

                            DungeonSectionConfig dungeonSectionConfig = DungeonSectionConfigCategory.Instance.Get(chaptierd);
                            int openLv = dungeonSectionConfig.OpenLevel[request.Difficulty - 1];
                            int enterlv = DungeonConfigCategory.Instance.Get(request.SceneId).EnterLv;
                            enterlv = Math.Max(enterlv, openLv);
                            if (userInfoComponent.UserInfo.Lv < enterlv)
                            {
                                return ErrorCore.ERR_LevelIsNot;
                            }
                        }

                        LocalDungeonComponent localDungeon = unit.DomainScene().GetComponent<LocalDungeonComponent>();
                        request.Difficulty = localDungeon != null ? localDungeon.FubenDifficulty : request.Difficulty;
                        unit.GetComponent<SkillManagerComponent>()?.OnFinish(false);
                        await TransferHelper.LocalDungeonTransfer(unit, request.SceneId, int.Parse(request.paramInfo), request.Difficulty);
                        break;
                    case SceneTypeEnum.BaoZang:
                    case SceneTypeEnum.MiJing:
                        SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(request.SceneId);
                        int curPlayerNum = UnitHelper.GetUnitList(unit.DomainScene(), UnitType.Player).Count;
                        if (sceneConfig.PlayerLimit > 0 && sceneConfig.PlayerLimit <= curPlayerNum)
                        {
                            return ErrorCore.ERR_MapLimit;
                        }
                        TransferHelper.BeforeTransfer(unit);

                        F2M_YeWaiSceneIdResponse f2M_YeWaiSceneIdResponse = (F2M_YeWaiSceneIdResponse)await ActorMessageSenderComponent.Instance.Call(
                        DBHelper.GetFubenCenterId(unit.DomainZone()), new M2F_YeWaiSceneIdRequest() { SceneId = request.SceneId });

                        await TransferHelper.Transfer(unit, f2M_YeWaiSceneIdResponse.FubenInstanceId, sceneConfig.MapType, request.SceneId, 0, "0");
                        break;
                    case SceneTypeEnum.Solo:
                        long soloServerId = DBHelper.GetSoloServerId(unit.DomainZone());
                        S2M_SoloEnterResponse d2GGetUnit = (S2M_SoloEnterResponse)await ActorMessageSenderComponent.Instance.Call(soloServerId, new M2S_SoloEnterRequest()
                        {
                            FubenId = long.Parse(request.paramInfo)
                        });

                        if (d2GGetUnit.Error != ErrorCore.ERR_Success)
                        {
                            return d2GGetUnit.Error;
                        }
                        if (d2GGetUnit.FubenInstanceId == 0)
                        {
                            return ErrorCore.ERR_ModifyData;
                        }
                        FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1045);
                        if (!FunctionHelp.IsInTime(funtionConfig.OpenTime))
                        {
                            return ErrorCore.ERR_AlreadyFinish;
                        }
                        oldscene = unit.DomainScene();
                        mapComponent = oldscene.GetComponent<MapComponent>();
                        sceneTypeEnum = mapComponent.SceneTypeEnum;
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, d2GGetUnit.FubenInstanceId, SceneTypeEnum.Solo, request.SceneId, 0, "0");
                        if (SceneConfigHelper.IsSingleFuben(sceneTypeEnum))
                        {
                            TransferHelper.NoticeFubenCenter(oldscene, 2).Coroutine();
                            oldscene.Dispose();
                        }
                        break;
                    case SceneTypeEnum.UnionRace:
                        unionid = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0);
                        if (unionid == 0)
                        {
                            return ErrorCore.ERR_Union_Not_Exist;
                        }
                        if (!FunctionHelp.IsInUnionRaceTime())
                        {
                            return ErrorCore.ERR_AlreadyFinish;
                        }
                        mapInstanceId = DBHelper.GetUnionServerId(unit.DomainZone());
                        responseUnionEnter = (U2M_UnionEnterResponse)await ActorMessageSenderComponent.Instance.Call(
                        mapInstanceId, new M2U_UnionEnterRequest() { OperateType = 1, UnionId = unionid, UnitId = unit.Id, SceneId = request.SceneId });
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, responseUnionEnter.FubenInstanceId, SceneTypeEnum.UnionRace, request.SceneId, 0, "0");
                        break;
                    case SceneTypeEnum.Battle:
                        mapComponent = unit.DomainScene().GetComponent<MapComponent>();
                        sceneTypeEnum = mapComponent.SceneTypeEnum;
                        mapInstanceId = DBHelper.GetBattleServerId(unit.DomainZone());
                        B2M_BattleEnterResponse battleEnter = (B2M_BattleEnterResponse)await ActorMessageSenderComponent.Instance.Call(
                        mapInstanceId, new M2B_BattleEnterRequest() { UserID = unit.Id, SceneId = request.SceneId });
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, battleEnter.FubenInstanceId, (int)SceneTypeEnum.Battle, request.SceneId, FubenDifficulty.Normal, battleEnter.Camp.ToString());
                        break;
                    case SceneTypeEnum.Arena:
                        userInfoComponent = unit.GetComponent<UserInfoComponent>();
                        sceneConfig = SceneConfigCategory.Instance.Get(request.SceneId);
                        if (userInfoComponent.UserInfo.Lv < sceneConfig.EnterLv)
                        {
                            return ErrorCore.ERR_LevelIsNot;
                        }

                        mapInstanceId = DBHelper.GetArenaServerId(unit.DomainZone());
                        Arena2M_ArenaEnterResponse areneEnter = (Arena2M_ArenaEnterResponse)await ActorMessageSenderComponent.Instance.Call(
                        mapInstanceId, new M2Arena_ArenaEnterRequest() { UserID = unit.Id, SceneId = request.SceneId });
                        if (areneEnter.Error != ErrorCore.ERR_Success || areneEnter.FubenInstanceId == 0)
                        {
                            return ErrorCore.ERR_AlreadyFinish;
                        }
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, areneEnter.FubenInstanceId, (int)SceneTypeEnum.Arena, request.SceneId, FubenDifficulty.Normal, "0");
                        break;
                    case (int)SceneTypeEnum.TeamDungeon:
                        oldscene = unit.DomainScene();
                        mapComponent = oldscene.GetComponent<MapComponent>();
                        sceneTypeEnum = mapComponent.SceneTypeEnum;
                        mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.Team)).InstanceId;
                        //[创建副本Scene]
                        T2M_TeamDungeonEnterResponse createUnit = (T2M_TeamDungeonEnterResponse)await ActorMessageSenderComponent.Instance.Call(
                        mapInstanceId, new M2T_TeamDungeonEnterRequest() { UserID = unit.GetComponent<UserInfoComponent>().UserInfo.UserId });
                        if (createUnit.Error != ErrorCore.ERR_Success)
                        {
                            return ErrorCore.ERR_TransferFailError;
                        }
                        TransferHelper.BeforeTransfer(unit);
                        await TransferHelper.Transfer(unit, createUnit.FubenInstanceId, (int)SceneTypeEnum.TeamDungeon, createUnit.FubenId, createUnit.FubenType, "0");
                        if (SceneConfigHelper.IsSingleFuben(sceneTypeEnum))
                        {
                            TransferHelper.NoticeFubenCenter(oldscene, 2).Coroutine();
                            oldscene.Dispose();
                        }
                        break;
                    default:
                        break;
                }
            }
            return ErrorCore.ERR_Success;
        }

        public static async ETTask MainCityTransfer(Unit unit)
        {
            MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();
            int sceneTypeEnum = mapComponent.SceneTypeEnum;
            long userId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId;
            //传送回主场景
            long mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), $"Map{ComHelp.MainCityID()}").InstanceId;
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
            if (sceneTypeEnum == (int)SceneTypeEnum.Arena)
            {
                ArenaDungeonComponent areneSceneComponent = scene.GetComponent<ArenaDungeonComponent>();
                areneSceneComponent.OnUnitDisconnect(userId);
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

        public static async ETTask<int> TransferComponent(Unit unit, long sceneInstanceId, string component)
        {
            M2M_UnitTransfer_0_Request request_0 = new M2M_UnitTransfer_0_Request();
            request_0.Unit = unit;
            foreach ((Type key, Entity entity) in unit.Components)
            {
                if (!(entity is ITransfer))
                {
                    continue;
                }

                //request.Entitys.Add(entity);
                if (key.Name.Equals(component))
                {
                    request_0.EntityBytes.Add(MongoHelper.ToBson(entity));
                }
            }
            request_0.ParamInfo = component;
            M2M_UnitTransfer_0_Response response_0 = await ActorMessageSenderComponent.Instance.Call(sceneInstanceId, request_0) as M2M_UnitTransfer_0_Response;
            return response_0.Error;
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

            await TimerComponent.Instance.WaitFrameAsync();
            await TransferComponent(unit, sceneInstanceId, DBHelper.BagComponent);
            await TransferComponent(unit, sceneInstanceId, DBHelper.ChengJiuComponent);

            M2M_UnitTransferRequest request = new M2M_UnitTransferRequest();
            request.Unit = unit;
            foreach ((Type key, Entity entity) in unit.Components)
            {
                if (!(entity is ITransfer))
                {
                    continue;
                }
                if (key.Name.Equals(DBHelper.BagComponent)
                 || key.Name.Equals(DBHelper.ChengJiuComponent))
                {
                    continue;
                }
                //request.Entitys.Add(entity);
                request.EntityBytes.Add(MongoHelper.ToBson(entity));
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