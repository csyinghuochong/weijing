namespace ET
{
    public static class ActivityTipHelper
    {

        public static void OnActiviyTip(Scene ZoneScene, int function)
        {
            Unit unitmain = UnitHelper.GetMyUnitFromZoneScene(ZoneScene);
            long stallId = unitmain.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Stall);
            if (stallId > 0)
            {
                return;
            }

            switch (function)
            {
                case 1031:
                    //FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(function);
                    //PopupTipHelp.OpenPopupTip(ZoneScene, "角斗场", "是否立即前往角斗场？", () =>
                    //{
                    //    RequestEnterArena(ZoneScene).Coroutine();
                    //}, null).Coroutine();
                    break;
                case 1055:
                    FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(function);
                    PopupTipHelp.OpenPopupTip(ZoneScene, "喜从天降", "是否立即前往喜从天降？",  ()  =>
                    {
                        if (!FunctionHelp.IsInTime(1055))
                        {
                            FloatTipManager.Instance.ShowFloatTip("不在活动时间内！");
                            return;
                        }
                        EnterFubenHelp.RequestTransfer(ZoneScene, SceneTypeEnum.Happy, BattleHelper.GetSceneIdByType(SceneTypeEnum.Happy)).Coroutine();
                    }, null).Coroutine();
                    break;
                case 1058:
                    funtionConfig = FuntionConfigCategory.Instance.Get(function);
                    PopupTipHelp.OpenPopupTip(ZoneScene, "奔跑大赛", "是否立即前往奔跑大赛？", () =>
                    {
                        if (!FunctionHelp.IsInTime(1058))
                        {
                            FloatTipManager.Instance.ShowFloatTip("不在活动时间内！");
                            return;
                        }
                        EnterFubenHelp.RequestTransfer(ZoneScene, SceneTypeEnum.RunRace, BattleHelper.GetSceneIdByType(SceneTypeEnum.RunRace)).Coroutine();
                    }, null).Coroutine();
                    break;
                case 1059:
                    funtionConfig = FuntionConfigCategory.Instance.Get(function);
                    PopupTipHelp.OpenPopupTip(ZoneScene, "恶魔活动", "是否立即前往恶魔活动？", () =>
                    {
                        if (!FunctionHelp.IsInTime(1059))
                        {
                            FloatTipManager.Instance.ShowFloatTip("不在活动时间内！");
                            return;
                        }
                        EnterFubenHelp.RequestTransfer(ZoneScene, SceneTypeEnum.Demon, BattleHelper.GetSceneIdByType(SceneTypeEnum.Demon)).Coroutine();
                    }, null).Coroutine();
                    break;
                default:
                    break;
            }
        }

        //竞技场
        public static async ETTask<int> RequestEnterArena(Scene ZoneScene)
        {
            int sceneId = 6000001;
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
            int sceneType = sceneConfig.MapType;
            if (sceneType != SceneTypeEnum.Arena)
            {
                return ErrorCode.ERR_Error;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(ZoneScene);
            if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.ArenaNumber) > 0)
            {
                FloatTipManager.Instance.ShowFloatTip("次数不足！");
                return ErrorCode.ERR_TimesIsNot;
            }
            if (!FunctionHelp.IsInTime(1031))
            {
                FloatTipManager.Instance.ShowFloatTip("不在活动时间内！");
                return ErrorCode.ERR_AlreadyFinish;
            }
            int errorCode = await EnterFubenHelp.RequestTransfer(ZoneScene, sceneType, sceneId);
            return errorCode;
        }

    }
}
