using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{
    public static class TaskHelper
    {

        public static float NpcSpeakDistance = 1.5f;

        public static bool HaveNpc(Scene zoneScene, int npcId)
        {
            List<int> npcList = new List<int>();
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.MainCityScene)
            {
                SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(mapComponent.SceneId);
                npcList = new List<int>(sceneConfig.NpcList);
               
            }
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
            {
                DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(mapComponent.SceneId);
                npcList = new List<int>(dungeonConfig.NpcList);
            }
            return npcList.Contains(npcId);
        }

        public static async ETTask<int> MoveToNpc(Scene zoneScene, TaskPro taskPro)
        {
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
            Vector3 targetPos;
            if (!HaveNpc(zoneScene, taskConfig.CompleteNpcID))
            {
                return ErrorCore.ERR_NotFindNpc;
            }
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(taskConfig.CompleteNpcID);
            targetPos = new Vector3(npcConfig.Position[0] * 0.01f, npcConfig.Position[1] * 0.01f, npcConfig.Position[2] * 0.01f );
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            long instanceid = unit.InstanceId;
            targetPos.y = unit.Position.y;
            if (Vector3.Distance(unit.Position, targetPos) < NpcSpeakDistance + 0.1f)
            {
                return ErrorCore.ERR_Success;
            }
            Vector3 dir = (unit.Position - targetPos).normalized;
            targetPos += dir * NpcSpeakDistance;
            int ret = await unit.MoveToAsync2(targetPos, false);
            if (instanceid != unit.InstanceId)
            {
                return -1;
            }
            EventType.TaskNpcDialog.Instance.TaskPro = taskPro;
            EventType.TaskNpcDialog.Instance.zoneScene = zoneScene;
            EventType.TaskNpcDialog.Instance.ErrorCode = ret;
            EventSystem.Instance.PublishClass(EventType.TaskNpcDialog.Instance);
            return ret;
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
                    npc = units[i] as Unit;
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
