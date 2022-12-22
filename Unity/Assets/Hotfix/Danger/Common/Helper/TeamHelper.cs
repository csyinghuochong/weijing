namespace ET
{
    public static class TeamHelper
    {

        public static int CheckTimesAndLevel(Unit unit, UserInfo userInfo, int fubenId, int fubenType)
        {
            if (fubenType == TeamFubenType.Normal || fubenType == TeamFubenType.ShenYuan)
            {
                int totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value);
                int times = unit.GetTeamDungeonTimes();
                if (totalTimes - times <= 0)
                {
                    return ErrorCore.ERR_TimesIsNot;
                }
            }
            else
            {
                int totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value);
                int times = unit.GetTeamDungeonTimes();

                int totalTimes_2 = int.Parse(GlobalValueConfigCategory.Instance.Get(74).Value);
                int times_2 = unit.GetTeamDungeonXieZhu();

                if (totalTimes - times <= 0 && totalTimes_2 - times_2 <= 0)
                {
                    return ErrorCore.ERR_TimesIsNot;
                }
            }

            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(fubenId);
            if (userInfo.Lv < sceneConfig.CreateLv)
            {
                return ErrorCore.ERR_LevelIsNot;
            }
            return ErrorCore.ERR_Success;
        }

    }
}
