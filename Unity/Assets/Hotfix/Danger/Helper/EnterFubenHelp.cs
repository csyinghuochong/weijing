using System;

namespace ET
{
    public static class EnterFubenHelp
    {

        public static async ETTask<int> RequestTransfer(Scene zoneScene, int newsceneType, int sceneId, int difficulty = FubenDifficulty.None, string paraminfo = "0")
        {
            try
            {
                MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
                if (TimeHelper.ServerNow() - mapComponent.LastQuitTime < 2000)
                {
                    return ErrorCore.ERR_OperationOften;
                }
                mapComponent.LastQuitTime = TimeHelper.ServerNow();
                int oldSceneType = mapComponent.SceneTypeEnum;
                if (oldSceneType == newsceneType && newsceneType!= SceneTypeEnum.LocalDungeon)
                {
                    return ErrorCore.ERR_RequestRepeatedly;
                }
                if (oldSceneType != newsceneType
                    && oldSceneType > SceneTypeEnum.MainCityScene
                    && newsceneType > SceneTypeEnum.MainCityScene)
                {
                    return ErrorCore.ERR_RequestRepeatedly;
                }
                UserInfoComponent userInfoComponent = zoneScene.GetComponent<UserInfoComponent>();
                if (SceneConfigHelper.UseSceneConfig(newsceneType) && sceneId > 0)
                {
                    SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
                    if (sceneConfig.DayEnterNum > 0 && sceneConfig.DayEnterNum <= userInfoComponent.GetSceneFubenTimes(sceneId))
                    {
                        HintHelp.GetInstance().ShowHint("次数不足！");
                        return ErrorCore.ERR_TimesIsNot;
                    }
                }
              
                Actor_TransferRequest c2M_ItemHuiShouRequest = new Actor_TransferRequest() { SceneType = newsceneType, SceneId = sceneId,  Difficulty = difficulty, paramInfo = paraminfo };
                Actor_TransferResponse r2c_roleEquip = (Actor_TransferResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
                userInfoComponent.AddSceneFubenTimes(sceneId);
                return r2c_roleEquip.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

        /// <summary>
        /// 进入副本
        /// </summary>
        /// <param name="zoneScene"></param>
        /// <param name="difficulty"></param>
        /// <param name="chapterid"></param>
        /// <param name="repeatenter"></param>
        /// <returns></returns>
        public static async ETTask<int> EnterFubenRequest(Scene zoneScene, int difficulty, int chapterid, int repeatenter = 0)
        {
            try
            {
                int errorCode = zoneScene.GetComponent<CellDungeonComponent>().CheckEnterLevel(FubenDifficulty.None, chapterid);
                if (errorCode != ErrorCore.ERR_Success)
                {
                    return errorCode;
                }
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
                unit.GetComponent<MoveComponent>().Stop();
                if (repeatenter == 1)
                {
                    UnitHelper.LoadingScene = true;
                }

                Actor_EnterFubenRequest actor_EnterFubenRequest = new Actor_EnterFubenRequest() { ChapterId = chapterid, Difficulty = (int)difficulty, RepeatEnter = repeatenter };
                Actor_EnterFubenResponse actor_EnterFubenResponse = await zoneScene.GetComponent<SessionComponent>().Session.Call(actor_EnterFubenRequest) as Actor_EnterFubenResponse;
                if (actor_EnterFubenResponse.Error != ErrorCore.ERR_Success)
                {
                    return actor_EnterFubenResponse.Error;
                }
                CellDungeonComponent fubenComponent = zoneScene.GetComponent<CellDungeonComponent>();
                fubenComponent.InitFubenCell(chapterid);
                fubenComponent.FubenDifficulty = difficulty;
                fubenComponent.FubenInfo = actor_EnterFubenResponse.FubenInfo;
                fubenComponent.SonFubenInfo = actor_EnterFubenResponse.SonFubenInfo;

                fubenComponent.SetStartedFlag(fubenComponent.FubenInfo.StartCell);
                fubenComponent.SetEndedFlag(fubenComponent.FubenInfo.EndCell);
                fubenComponent.UpdateCellType(fubenComponent.SonFubenInfo.CurrentCell, fubenComponent.SonFubenInfo.PassableFlag);

                if (repeatenter == 1)
                {
                    zoneScene.GetComponent<MapComponent>().SetSubLevel(fubenComponent.SonFubenInfo.SonSceneId);
                    EventType.AfterEnterFuben.Instance.EnterSonScene = true;
                    EventType.AfterEnterFuben.Instance.ZoneScene = zoneScene;
                    EventType.AfterEnterFuben.Instance.DirectionType = 0;
                    Game.EventSystem.PublishClass(EventType.AfterEnterFuben.Instance);
                }

                return actor_EnterFubenResponse.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

        public static async ETTask EnterSonFubenRequest(Scene zoneScene, int cellindex, int direction)
        {
            if (zoneScene.GetComponent<UserInfoComponent>().UserInfo.PiLao <= 0)
            {
                HintHelp.GetInstance().ShowHint("体力不足！");
                return;
            }
            EventType.BeforeEnterSonFuben.Instance.ZoneScene = zoneScene;
            Game.EventSystem.PublishClass(EventType.BeforeEnterSonFuben.Instance);

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            unit.GetComponent<MoveComponent>().Stop();
            unit.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.NetWait);
            UnitHelper.LoadingScene = true;

            Actor_EnterSonFubenRequest actor_EnterFubenRequest = new Actor_EnterSonFubenRequest() { CurrentCell = cellindex, DirectionType = direction };
            Actor_EnterSonFubenResponse actor_EnterSonFubenResponse = await zoneScene.GetComponent<SessionComponent>().Session.Call(actor_EnterFubenRequest) as Actor_EnterSonFubenResponse;
            zoneScene.GetComponent<MapComponent>().SetSubLevel(actor_EnterSonFubenResponse.SonFubenInfo.SonSceneId);
            unit.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.NetWait);
            if (actor_EnterSonFubenResponse.Error != 0)
            {
                return;
            }
            CellDungeonComponent fubenComponent = zoneScene.GetComponent<CellDungeonComponent>();
            //记录之前通关的子关卡
            fubenComponent.SonFubenInfo = actor_EnterSonFubenResponse.SonFubenInfo;
            fubenComponent.SetWalkedFlag(fubenComponent.SonFubenInfo.CurrentCell);
            fubenComponent.UpdateCellType(fubenComponent.SonFubenInfo.CurrentCell, fubenComponent.SonFubenInfo.PassableFlag);

            EventType.AfterEnterFuben.Instance.EnterSonScene = true;
            EventType.AfterEnterFuben.Instance.ZoneScene = zoneScene;
            EventType.AfterEnterFuben.Instance.DirectionType = direction;
            Game.EventSystem.PublishClass(EventType.AfterEnterFuben.Instance);
        }

        public static async ETTask SendReviveRequest(Scene zoneScene)
        {
            Actor_SendReviveRequest actor_SendReviveRequest = new Actor_SendReviveRequest();
            Actor_SendReviveResponse actor_QuitFubenResponse = await zoneScene.GetComponent<SessionComponent>().Session.Call(actor_SendReviveRequest) as Actor_SendReviveResponse;
        }

        public static void RequestQuitFuben(Scene zoneScene)
        {
             RequestTransfer(zoneScene, (int)SceneTypeEnum.MainCityScene, ComHelp.MainCityID()).Coroutine();
        }
    }
}
