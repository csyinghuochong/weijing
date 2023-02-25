using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class SceneConfigHelper
    {
        public static bool ShowRightTopButton(int sceneType)
        {
            return sceneType != SceneTypeEnum.Battle
                && sceneType != SceneTypeEnum.TrialDungeon
                && sceneType != SceneTypeEnum.Tower
                && sceneType != SceneTypeEnum.Arena;
        }

        public static bool ShowLeftButton(int sceneType)
        {
            return sceneType != SceneTypeEnum.TrialDungeon
                && sceneType != SceneTypeEnum.MiJing;
        }

        public static bool UseSceneConfig(int sceneType)
        {
            return sceneType != SceneTypeEnum.LocalDungeon
                 && sceneType != SceneTypeEnum.CellDungeon;
        }

        public static bool IfCanRevive(int sceneType, int sceneId)
        {
            if (!UseSceneConfig(sceneType))
            {
                return true;
            }
            return SceneConfigCategory.Instance.Get(sceneId).IfUseRes == 0;
        }

        public static bool ShowMiniMap(int sceneType, int sceneId)
        {
            if (!UseSceneConfig(sceneType))
            {
                return true;
            }
            return SceneConfigCategory.Instance.Get(sceneId).ifShowMinMap == 1;
        }

		public static List<int> CreateMonsterList( string createMonster)
		{
			List<int> monsterId = new List<int>();
			if (ComHelp.IfNull(createMonster))
			{
				return monsterId;
			}

			string[] monsters = createMonster.Split('@');
			for (int i = 0; i < monsters.Length; i++)
			{
				if (monsters[i] == "0")
				{
					continue;
				}
				string[] mondels = monsters[i].Split(';');
				int monsterid = int.Parse(mondels[2]);
				if (!MonsterConfigCategory.Instance.Contain(monsterid))
				{
					Log.Error($"monsterid==null {monsterid}");
					continue;
				}
                monsterId.Add(monsterid);
            }
            return monsterId;

        }

        public static List<int> CreateMonsterList(int[] monsterPos)
        {
            List<int> monsterIds = new List<int>();
            if (monsterPos == null || monsterPos.Length == 0)
            {
                return monsterIds;
            }
            for (int i = 0; i < monsterPos.Length; i++)
            {
                int posid = monsterPos[i];
                while (posid != 0)
                {
                    posid = CreateMonsterByPos(posid, monsterIds);
                }
            }
            return monsterIds;
        }

		public static int CreateMonsterByPos(int monsterPos, List<int> monsterIds)
		{
			if (monsterPos == 0)
			{
				return 0;
			}
			
			MonsterPositionConfig monsterPosition = MonsterPositionConfigCategory.Instance.Get(monsterPos);
            monsterIds.Add(monsterPosition.MonsterID);

            return monsterPosition.NextID;
		}

		public static List<int> GetSceneMonsterList( int sceneId)
        {
            List<int> monsterid = new List<int>();

            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
            if (sceneConfig == null)
            {
                return monsterid;
            }


            monsterid.AddRange(CreateMonsterList(sceneConfig.CreateMonster));
            monsterid.AddRange(CreateMonsterList(sceneConfig.CreateMonsterPosi));
            return monsterid;
        }


        public static List<int> GetLocalDungeonMonsters(int mapid)
        {
            List<int> monsterIds = new List<int>();
            DungeonConfig chapterSonConfig = DungeonConfigCategory.Instance.Get(mapid);
            string createMonster = chapterSonConfig.CreateMonster;
            if (chapterSonConfig.MonsterGroup != 0)
            {
                MonsterGroupConfig monsterGroupConfig = MonsterGroupConfigCategory.Instance.Get(chapterSonConfig.MonsterGroup);
                createMonster = createMonster + "@" + monsterGroupConfig.CreateMonster;
            }

            string[] monsters = createMonster.Split('@');
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i] == "0")
                {
                    continue;
                }
                string[] mondels = monsters[i].Split(';');
                string[] monsterid = mondels[2].Split(',');
                monsterIds.Add(int.Parse(monsterid[0]));
            }
            return monsterIds;
        }
    }
}
