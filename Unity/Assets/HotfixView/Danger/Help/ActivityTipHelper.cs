using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class ActivityTipHelper
    {

        public static void OnActiviyTip(Scene ZoneScene, int function)
        {
            switch (function)
            {
                case 1031:
                    FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(function);
                    PopupTipHelp.OpenPopupTip(ZoneScene, "角斗场", "是否立即前往角斗场？", () =>
                    {
                        RequestEnterArena(ZoneScene).Coroutine();
                    }, null).Coroutine();
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
                return ErrorCore.ERR_Error;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(ZoneScene);
            if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.ArenaNumber) > 0)
            {
                FloatTipManager.Instance.ShowFloatTip("次数不足！");
                return ErrorCore.ERR_TimesIsNot;
            }
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1031);
            if (!FunctionHelp.IsInTime(funtionConfig.OpenTime))
            {
                FloatTipManager.Instance.ShowFloatTip("不在活动时间内！");
                return ErrorCore.ERR_AlreadyFinish;
            }
            int errorCode = await EnterFubenHelp.RequestTransfer(ZoneScene, sceneType, sceneId);
            return errorCode;
        }

    }
}
