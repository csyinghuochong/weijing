using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{
    public static class TaskHelper
    {

        public static float NpcSpeakDistance = 2f;

        public static bool HaveNpc(Scene zoneScene, int npcId)
        {
            List<int> npcList = new List<int>();
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (SceneConfigHelper.UseSceneConfig(mapComponent.SceneTypeEnum))
            {
                SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(mapComponent.SceneId);
                npcList = new List<int>(sceneConfig.NpcList);
               
            }
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
            {
                DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(mapComponent.SceneId);
                if (dungeonConfig.NpcList != null)
                {
                    npcList = new List<int>(dungeonConfig.NpcList);
                }
            }
            return npcList.Contains(npcId);
        }

        public static Unit GetNpcByConfigId(Scene zongScene, int npcid)
        {
            Unit npc = null;
            List<Unit> units = zongScene.CurrentScene().GetComponent<UnitComponent>().GetAll();
            UnitInfoComponent unitInfoComponent;
            for (int i = 0; i < units.Count; i++)
            {
                unitInfoComponent = units[i].GetComponent<UnitInfoComponent>();
                if (units[i].Type != UnitType.Npc)
                {
                    continue;
                }
                if (units[i].ConfigId == npcid)
                {
                    npc = units[i];
                    break;
                }
            }
            return npc;
        }

        public static int GetChapterByNpc(int npcId)
        {
            List<ChapterConfig> chapterList = ChapterConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < chapterList.Count; i++)
            {
                int startArea = chapterList[i].StartArea;
                ChapterSonConfig chapterSonConfig = ChapterSonConfigCategory.Instance.Get(startArea);
                if (chapterSonConfig.NpcList.Contains(npcId))
                {
                    return chapterList[i].Id;
                }
            }
            return 0;
        }

        public static int GetChapterSection( int chapterId)
        {
            List<ChapterSectionConfig> chapterSectionConfigs = ChapterSectionConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < chapterSectionConfigs.Count; i++ )
            {
                List<int> RandomArea = new List<int>(chapterSectionConfigs[i].RandomArea);
                if (RandomArea.Contains(chapterId))
                {
                    return chapterSectionConfigs[i].Id;
                }
            }
            if (chapterId != 0)
            {
                Log.Error("GetChapterSection:   return 0");
            }
            return 0;
        }

        public static int GetLevelIdByMonster(int monster)
        {
            List<ChapterConfig> chapterList = ChapterConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < chapterList.Count; i++)
            { 
                int startArea = chapterList[i].StartArea;
                ChapterSonConfig chapterSonConfig = ChapterSonConfigCategory.Instance.Get(startArea);
                if (chapterSonConfig.CreateMonster.Contains(monster.ToString()))
                {
                    return chapterList[i].Id;
                }
            }

            return 0;
        }
    }
}
