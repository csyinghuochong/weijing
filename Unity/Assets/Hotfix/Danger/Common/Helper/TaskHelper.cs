using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{
    public static class TaskHelper
    {

#if !SERVER
        public static float NpcSpeakDistance = 2f;

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

        public static Unit GetNpcByConfigId(Scene zongScene, Vector3 position, int npcid)
        {
            Unit npc = null;
            float distance = -1f;
            List<Unit> units = zongScene.CurrentScene().GetComponent<UnitComponent>().GetAll();
            UnitInfoComponent unitInfoComponent;
            for (int i = 0; i < units.Count; i++)
            {
                unitInfoComponent = units[i].GetComponent<UnitInfoComponent>();
                if (units[i].Type != UnitType.Npc)
                {
                    continue;
                }
                if (units[i].ConfigId != npcid)
                {
                    continue;
                }
                if (Vector3.Distance( position, units[i].Position ) < distance || distance < 0f) 
                {
                    npc = units[i];
                    distance = Vector3.Distance(position, units[i].Position);
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
#endif


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


        public static int GetChapterSection(int chapterId)
        {
            List<ChapterSectionConfig> chapterSectionConfigs = ChapterSectionConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < chapterSectionConfigs.Count; i++)
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

        /// <summary>
        /// 赏金任务
        /// </summary>
        /// <param name="roleLv"></param>
        /// <returns></returns>
        public static int GetLoopTaskId(int roleLv)
        {
            List<int> allTaskIds = new List<int>();
            Dictionary<int, TaskConfig> keyValuePairs = TaskConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TaskType == TaskTypeEnum.EveryDay
                    && roleLv >= item.Value.TaskLv
                    && roleLv <= item.Value.TaskMaxLv)
                {
                    allTaskIds.Add(item.Key);
                }
            }
            if (allTaskIds.Count == 0)
            {
                return 0;
            }
            return allTaskIds[RandomHelper.RandomNumber(0, allTaskIds.Count)];
        }

        //家族任务
        public static int GetUnionTaskId(int roleLv)
        {
            List<int> allTaskIds = new List<int>();
            Dictionary<int, TaskConfig> keyValuePairs = TaskConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TaskType == TaskTypeEnum.Union
                    && roleLv >= item.Value.TaskLv
                    && roleLv <= item.Value.TaskMaxLv)
                {
                    allTaskIds.Add(item.Key);
                }
            }
            if (allTaskIds.Count == 0)
            {
                return 0;
            }
            return allTaskIds[RandomHelper.RandomNumber(0, allTaskIds.Count)];
        }

        public static int GetWeeklyTaskId()
        {
            List<int> taskids = new List<int>();
            Dictionary<int, TaskConfig> taskConfigs = TaskConfigCategory.Instance.GetAll();
            foreach (var item in taskConfigs)
            {
                int id = item.Key;
                TaskConfig TaskConfig = item.Value;
                if (TaskConfig.TaskType == TaskTypeEnum.Weekly)
                {
                    taskids.Add(id);
                }
            }
            return taskids[RandomHelper.RandomNumber(0, taskids.Count)];
        }

        /// <summary>
        /// 活跃任务
        /// </summary>
        /// <returns></returns>
        public static List<int> GetTaskCountrys(Unit unit)
        {
            //活跃任务
            int playerLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;

            List<int> taskCountryList = new List<int>();
            string[] dayTaskID = GlobalValueConfigCategory.Instance.Get(8).Value.Split(';');
            for (int i = 0; i < dayTaskID.Length; i++)
            {

                //获取任务概率
                float taskRandValue = RandomHelper.RandFloat01();
                int writeTaskID = int.Parse(dayTaskID[i]);
                int writeTaskID_Next = writeTaskID;
                TaskCountryConfig taskCountryConfig = null;
                double triggerPro = 0;
                do
                {
                    writeTaskID = writeTaskID_Next;
                    taskCountryConfig = TaskCountryConfigCategory.Instance.Get(writeTaskID);

                    if (taskCountryConfig.TriggerType == 1 && playerLv < taskCountryConfig.TargetValue)
                    {
                        //条件不满足
                        if (taskCountryConfig.NextTask == 0)
                        {
                            break;
                        }
                        else
                        {
                            writeTaskID_Next = taskCountryConfig.NextTask;
                            continue;
                        }
                    }


                    triggerPro = taskCountryConfig.TriggerPro;
                    writeTaskID_Next = taskCountryConfig.NextTask;


                    if (writeTaskID_Next == 0)
                    {
                        taskRandValue = -1;
                    }

                } while (taskRandValue >= triggerPro);

                taskCountryList.Add(writeTaskID);
            }

            return taskCountryList;
        }


        public static List<int> GetBattleTask()
        {
            List<int> taskIds = new List<int>();
            Dictionary<int, TaskCountryConfig> keyValuePairs = TaskCountryConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TaskType == TaskCountryType.Battle)
                {
                    taskIds.Add(item.Key);
                }
            }
            return taskIds;
        }

        public static List<int> GetShowLieTask()
        {
            List<int> taskIds = new List<int>();
            Dictionary<int, TaskCountryConfig> keyValuePairs = TaskCountryConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TaskType == TaskCountryType.ShowLie)
                {
                    taskIds.Add(item.Key);
                }
            }
            return taskIds;
        }

        public static List<int> GetUnionRaceTask()
        {
            List<int> taskIds = new List<int>();
            Dictionary<int, TaskCountryConfig> keyValuePairs = TaskCountryConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TaskType == TaskCountryType.UnionRace)
                {
                    taskIds.Add(item.Key);
                }
            }
            return taskIds;
        }

        public static List<int> GetMineTask()
        {
            List<int> taskIds = new List<int>();
            Dictionary<int, TaskCountryConfig> keyValuePairs = TaskCountryConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TaskType == TaskCountryType.Mine)
                {
                    taskIds.Add(item.Key);
                }
            }
            return taskIds;
        }

        public static List<int> GetSeasonTask()
        {
            List<int> taskIds = new List<int>();
            Dictionary<int, TaskCountryConfig> keyValuePairs = TaskCountryConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TaskType == TaskCountryType.Season)
                {
                    taskIds.Add(item.Key);
                }
            }
            return taskIds;
        }

        public static List<RewardItem> GetTaskRewards(int taskid, TaskConfig taskConfig = null)
        {
            if (taskConfig == null)
            {
                taskConfig = TaskConfigCategory.Instance.Get(taskid);
            }

            List<RewardItem> taskRewards = new List<RewardItem>();
            string ItemIDs = taskConfig.ItemID;
            string ItemNum = taskConfig.ItemNum;
            string[] ids = ItemIDs.Split(';');
            string[] nums = ItemNum.Split(';');
            for (int i = 0; i < ids.Length; i++)
            {
                if (ids[i] == "0" || ids[i] == "")
                {
                    continue;
                }
                RewardItem taskReward = new RewardItem();
                taskReward.ItemID = int.Parse(ids[i]);
                taskReward.ItemNum = int.Parse(nums[i]);
                taskRewards.Add(taskReward);
            }
            return taskRewards;
        }

        //目标类型为10：
        //支持多个 比如Target字段配置1,3 TargetValue字段配置10,3 就是找一个10级以上,品质为蓝色以上的道具。
        //            目标值配对应的值
        //1.道具等级
        //2.道具部位
        //3.道具品质
        //4:具体道具ID
        //105101.装备鉴定属性力量
        //105201.装备鉴定属性敏捷
        //105301.装备鉴定属性智力
        //105401.装备鉴定属性耐力
        //105501.装备鉴定属性体质
        public static bool IsTaskGiveItem(int taskId, BagInfo bagInfo)
        {
            if (bagInfo == null)
            {
                return false;
            }

            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskId);
            if (taskConfig.TargetType != (int)TaskTargetType.GiveItem_10)
            {
                return false;
            }

            if (taskConfig.Target == null || taskConfig.TargetValue == null)
            {
                return false;
            }

            if (taskConfig.Target.Length != taskConfig.TargetValue.Length)
            {
                return false;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            if (itemConfig.ItemType != ItemTypeEnum.Equipment)
            {
                return false;
            }

            for (int i = 0; i < taskConfig.Target.Length; i++)
            {
                bool value = false;
                int targetType = taskConfig.Target[i];
                int targetValue = taskConfig.TargetValue[i];

                switch (targetType)
                {
                    case 1:
                        value = itemConfig.UseLv >= targetValue;
                        break;
                    case 2:
                        value = itemConfig.ItemSubType == targetValue;
                        break;
                    case 3:
                        value = itemConfig.ItemQuality >= targetValue;
                        break;
                    case 105101:
                    case 105201:
                    case 105301:
                    case 105401:
                    case 105501:
                        value = GetJianDingValue(bagInfo, targetType) >= targetValue;
                        break;
                }

                if (!value)
                {
                    return false;
                }
            }

            return true;
        }

        public static long GetJianDingValue(BagInfo bagInfo, int type)
        {
            for (int i = 0; i < bagInfo.HideProLists.Count; i++)
            {
                if (type == bagInfo.HideProLists[i].HideID)
                {
                    return bagInfo.HideProLists[i].HideValue;
                }
            }

            return 0;
        }
    }
}
