

using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static class BattleHelper
    {

        public static async ETTask<int> OnButtonEnter(Scene zoneScene)
        {
            int sceneId = BattleHelper.GetBattFubenId();
            //Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            //NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            //if (numericComponent.GetAsInt(NumericType.BattleNumber) > 0)
            //{
            //    return ErrorCore.ERR_BattleJoined;
            //}
            //FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1025);
            //bool intime = TimeHelper.IsInTime(funtionConfig.OpenTime);
            //if (!intime)
            //{
            //    return ErrorCore.ERR_AlreadyFinish;
            //}
            int errorCode = await EnterFubenHelp.RequestTransfer(zoneScene, SceneTypeEnum.Battle, sceneId);
            return errorCode;
        }

        public static int GetBattFubenId()
        {
            List<SceneConfig> sceneConfigs = SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < sceneConfigs.Count; i++)
            {
                if (sceneConfigs[i].MapType == SceneTypeEnum.Battle)
                {
                    return sceneConfigs[i].Id;
                }
            }
            return 0;
        }

        public static int GetTeamFubenId(int lv)
        {
            int fubenId = 0;
            List<SceneConfig> sceneConfigs = SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < sceneConfigs.Count; i++)
            {
                if (sceneConfigs[i].MapType == SceneTypeEnum.TeamDungeon
                    && sceneConfigs[i].CreateLv <= lv)
                {
                    fubenId = sceneConfigs[i].Id;
                }
            }
            return fubenId;
        }
    }
}
