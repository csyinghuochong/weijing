using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static class BattleHelper
    {

        public static int GetFubenByNpc(int npcId)
        {
            List<DungeonConfig> dungeonConfigs = DungeonConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < dungeonConfigs.Count; i++)
            {
                DungeonConfig dungeonConfig = dungeonConfigs[i];
                if (dungeonConfig.NpcList == null)
                {
                    continue;
                }
                if (dungeonConfig.NpcList.Contains(npcId))
                {
                    return dungeonConfig.Id;
                }
            }
            return 0;
        }

        public static int GetFubenByMonster(int monsterId)
        { 
            List<DungeonConfig> dungeonConfigs = DungeonConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < dungeonConfigs.Count; i++)
            {
                DungeonConfig dungeonConfig = dungeonConfigs[i];    
                if (dungeonConfig.CreateMonster.Contains(monsterId.ToString()))
                {
                    return dungeonConfig.Id;
                }
                int monsterGroup = dungeonConfig.MonsterGroup;
                if (monsterGroup == 0)
                {
                    continue;
                }
                MonsterGroupConfig monsterGroupConfig = MonsterGroupConfigCategory.Instance.Get(monsterGroup);
                if (monsterGroupConfig.CreateMonster.Contains(monsterId.ToString()))
                {
                    return dungeonConfig.Id;
                }
            }
            return 0;
        }

        public static int GetYaoShuiItemID(int level)
        {
            if (level < 20)
                return 10010001;
            if (level < 30)
                return 10010002;
            if (level < 40)
                return 10010003;
            if (level < 50)
                return 10010004;
            return 10010005;
        }

        public static int GetSceneIdByType(int sceneType)
        {
            List<SceneConfig> sceneConfigs = SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < sceneConfigs.Count; i++)
            {
                if (sceneConfigs[i].MapType != sceneType)
                {
                    continue;
                }
                return sceneConfigs[i].Id;
            }
            return 0;
        }

        public static int GetBattFubenId(int level)
        {
            List<SceneConfig> sceneConfigs = SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < sceneConfigs.Count; i++)
            {
                if (sceneConfigs[i].MapType != SceneTypeEnum.Battle)
                {
                    continue;
                }
                if (sceneConfigs[i].TuiJianLv[0] <= level && sceneConfigs[i].TuiJianLv[1] >= level)
                {
                    return sceneConfigs[i].Id;
                }
            }
            return 0;
        }

        public static int GetPetTianTiId()
        {
            List<SceneConfig> sceneConfigs = SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < sceneConfigs.Count; i++)
            {
                if (sceneConfigs[i].MapType != SceneTypeEnum.PetTianTi)
                {
                    continue;
                }
                return sceneConfigs[i].Id;
            }
            return 0;
        }

        public static int GetPetFubenId()
        {
            List<SceneConfig> sceneConfigs = SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < sceneConfigs.Count; i++)
            {
                if (sceneConfigs[i].MapType != SceneTypeEnum.PetDungeon)
                {
                    continue;
                }
                return sceneConfigs[i].Id;
            }
            return 0;
        }
        public static int GetBattleRobotId(int behaviour, int behaviourId)
        {
            List<int> ids = new List<int>();
            List<RobotConfig> robots = RobotConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < robots.Count; i++)
            {
                if (robots[i].Behaviour == behaviour && robots[i].BehaviourID == behaviourId)
                {
                    ids.Add(robots[i].Id);
                }
            }
            if (ids.Count == 0)
            {
                return 0;
            }
            return ids[RandomHelper.RandomNumber(0, ids.Count)];
        }

        public static int GetTeamRobotId(int fubenId)
        {
            List<int> ids = new List<int>();
            List<RobotConfig> robots = RobotConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < robots.Count; i++)
            {
                if (robots[i].Behaviour == 2 && robots[i].BehaviourID == fubenId)
                {
                    ids.Add(robots[i].Id);
                }
            }
            return ids[RandomHelper.RandomNumber(0, ids.Count)];
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
