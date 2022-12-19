using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{

    public class UITaskViewHelp : Singleton<UITaskViewHelp>
    {

        public delegate bool TaskExcuteDelegate(Scene scene, TaskPro taskPro, TaskConfig taskConfig);
        public delegate string TaskDescDelegate(TaskPro taskPro, TaskConfig taskConfig);

        public class TaskLogic
        {
            public TaskExcuteDelegate taskExcute;
            public TaskDescDelegate taskProgess;
        }
        public Dictionary<TaskTargetType, TaskLogic> TaskTypeLogic;

        protected override void InternalInit()
        {
            base.InternalInit();

            TaskTypeLogic = new Dictionary<TaskTargetType, TaskLogic>();

            TaskTypeLogic.Add(TaskTargetType.KillMonsterID_1, new TaskLogic() { taskExcute = ExcuteKillMonsterID, taskProgess = GetDescKillMonsterID } );
            TaskTypeLogic.Add(TaskTargetType.ItemID_Number_2, new TaskLogic() { taskExcute = ExcuteItemId, taskProgess = GetDescItemId });
            TaskTypeLogic.Add(TaskTargetType.LookingFor_3, new TaskLogic() { taskExcute = ExcuteLookingFor, taskProgess = GetDescLookingFor });
            TaskTypeLogic.Add(TaskTargetType.PlayerLv_4, new TaskLogic() { taskExcute = ExcutePlayerLv, taskProgess = GetDescPlayerLv });
            TaskTypeLogic.Add(TaskTargetType.KillMonster_5, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillMonster });
            TaskTypeLogic.Add(TaskTargetType.KillBOSS_6, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillBOSS });
            TaskTypeLogic.Add(TaskTargetType.PassFubenID_7, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescPassFubenID });
            TaskTypeLogic.Add(TaskTargetType.ChangeOcc_8, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetChangeOcc });
            TaskTypeLogic.Add(TaskTargetType.KillTiaoZhanMonsterID_101, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillChallengeMonsterID });
            TaskTypeLogic.Add(TaskTargetType.KillDiYuMonsterID_102, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillInfernalMonsterID });
            TaskTypeLogic.Add(TaskTargetType.PassTianZhanFubenID_111, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescPassChallengeFubenID }); 
            TaskTypeLogic.Add(TaskTargetType.PassDiYuFubenID_112, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescPassInfernalFubenID });
            TaskTypeLogic.Add(TaskTargetType.KillTianZhanMonsterNumber_121, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillChallengeMonsterNumber });
            TaskTypeLogic.Add(TaskTargetType.KillDiYuMonsterNumber_122, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillInfernalMonsterNumber });
            TaskTypeLogic.Add(TaskTargetType.KillTianZhanBossNumber_131, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillChallengeBossNumber });
            TaskTypeLogic.Add(TaskTargetType.KillDiYuBossNumber_132, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillInfernalBossNumber });
        }

        public bool ExcutePlayerLv(Scene domainscene, TaskPro taskPro, TaskConfig taskConfig)
        {
            FloatTipManager.Instance.ShowFloatTip("请提升到相对的等级");
            return true;
        }

        public bool ExcuteDoNothing(Scene domainscene, TaskPro taskPro, TaskConfig taskConfig)
        {
            return true;
        }

        public bool ExcuteKillMonsterID(Scene domainscene, TaskPro taskPro, TaskConfig taskConfig)
        {
            int monsterId = taskConfig.Target[0];
            int fubenId = GetFubenByMonster(monsterId);
            if (fubenId == 0)
            {
                return false;
            }
            FloatTipManager.Instance.ShowFloatTip($"请前往 {DungeonConfigCategory.Instance.Get(fubenId).ChapterName}");
            return true;
        }
        public bool ExcuteItemId(Scene domainscene, TaskPro taskPro, TaskConfig taskConfig)
        {
            return true;
        }

        public bool ExcuteLookingFor(Scene zoneScene, TaskPro taskPro, TaskConfig taskConfig)
        {
            int fubenId = GetFubenByNpc(taskConfig.Target[0]);
            if (fubenId == 0)
            {
                return false;
            }
            FloatTipManager.Instance.ShowFloatTip($"请前往 {DungeonConfigCategory.Instance.Get(fubenId).ChapterName}");
            return true;
        }

        public async ETTask OpenStoryView(Scene domainscene, int taskid)
        {
            await UIHelper.Create(domainscene, UIType.UIStorySpeak);
            UI uistory = domainscene.GetComponent<UIComponent>().Get(UIType.UIStorySpeak);
            uistory.GetComponent<UIRoleStoryComponent>().OnUpdateInfo(taskid);
        }

        public string GetTaskProgessDesc(TaskPro taskPro)
        {
            int taskId = taskPro.taskID;
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskId);
            TaskTargetType TargetType = (TaskTargetType)taskConfig.TargetType;
            return TaskTypeLogic[TargetType].taskProgess(taskPro, taskConfig);
        }

        public bool MoveToTask(Scene zoneScene, int positionId)
        {
            TaskPositionConfig taskPositionConfig = TaskPositionConfigCategory.Instance.Get(positionId);
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != (int)SceneTypeEnum.LocalDungeon)
            {
                return false;
            }
            if (mapComponent.SceneId == taskPositionConfig.MapID)
            {
                MoveToTaskPosition(zoneScene, positionId);
                return true;
            }
            string[] otherMapMoves = taskPositionConfig.OtherMapMove.Split(';');
            if (otherMapMoves == null)
            {
                return false;
            }
            for (int i = 0; i < otherMapMoves.Length; i++)
            {
                if (otherMapMoves[i] == "0")
                {
                    continue;
                }
                string[] positionIds = otherMapMoves[i].Split(',');
                if (int.Parse(positionIds[0]) == mapComponent.SceneId)
                {
                    MoveToTaskPosition(zoneScene,int.Parse(positionIds[1]));
                    return true ;
                }
            }
            return false;
        }

        public void MoveToTaskPosition(Scene zoneScene, int taskPositionId)
        {
            TaskPositionConfig taskPositionConfig = TaskPositionConfigCategory.Instance.Get(taskPositionId);
            GameObject gameObject = GameObject.Find($"ScenceRosePositionSet/{taskPositionConfig.PositionName}");
            if (gameObject == null)
            {
                return;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            EventType.BeforeMove.Instance.ZoneScene = zoneScene;
            Game.EventSystem.PublishClass(EventType.BeforeMove.Instance);
            unit.MoveToAsync2(gameObject.transform.position, true).Coroutine();
        }

        public int GetFubenByNpc(int npcId)
        {
            if (npcId == 0)
            {
                return 0;
            }
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

        public  int GetFubenByMonster(int monsterId)
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

        public string GetDescKillMonsterID(TaskPro taskPro, TaskConfig taskConfig)
        {
            string desc = "";
            string progress = "击败{0} {1}/{2} {3}";
            
            for (int i = 0; i < taskConfig.Target.Length; i++)
            {
                int monsterId = taskConfig.Target[i];
                int fubenId = GetFubenByMonster(monsterId);
                string fubenName = fubenId > 0 ? "      (出现在:" + DungeonConfigCategory.Instance.Get(fubenId).ChapterName + ")" : "";
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterId);

                string text1 = "";
                if (i == 0)
                {
                    text1 = string.Format(progress, monsterConfig.MonsterName, taskPro.taskTargetNum_1, taskConfig.TargetValue[i], fubenName);
                }
                if (i == 1)
                {
                    text1 = string.Format(progress, monsterConfig.MonsterName, taskPro.taskTargetNum_2, taskConfig.TargetValue[i], fubenName);
                }
                 
                desc = desc + text1 + "\n";
            }

            return desc;
        }

        public string GetDescLookingFor(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("找 {0} 谈一谈 {1}");

            int fubenId = GetFubenByNpc(taskConfig.Target[0]);
            string fubenName = fubenId > 0 ? "      (出现在:" + DungeonConfigCategory.Instance.Get(fubenId).ChapterName + ")" : "";

            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(taskConfig.Target[0]);
            string text1 = string.Format(progress, npcConfig.Name,  fubenName);
            return text1;
        }

        public string GetDescPlayerLv(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("等级提升至{0}级 {1}/{2}");
            string text1 = string.Format(progress, taskConfig.TargetValue[0], taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string  GetDescKillMonster(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("击败任意怪物 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescKillBOSS(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("击败任意领主级怪物 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescPassFubenID(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("通关副本{0} {1}/{2}");
            string fubenName = ChapterConfigCategory.Instance.Get(taskConfig.Target[0]).ChapterName;
            string text1 = string.Format(progress, fubenName, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetChangeOcc(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("进行转职{0} {1}/{2}");
            string fubenName = "";
            string text1 = string.Format(progress, fubenName, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescKillChallengeMonsterID(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("击败挑战级的 {0} {1}/{2}");
            string monsterName = MonsterConfigCategory.Instance.Get(taskConfig.Target[0]).MonsterName;
            string text1 = string.Format(progress, monsterName, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescKillInfernalMonsterID(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("击败地狱级的 {0} {1}/{2}");
            string monsterName = MonsterConfigCategory.Instance.Get(taskConfig.Target[0]).MonsterName;
            string text1 = string.Format(progress, monsterName, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescPassChallengeFubenID(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("通关挑战级-{0}副本 {1}/{2}");
            string chapterName = ChapterConfigCategory.Instance.Get(taskConfig.Target[0]).ChapterName;
            string text1 = string.Format(progress, chapterName, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescPassInfernalFubenID(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("通关地狱级-{0}副本 {1}/{2}");
            string chapterName = ChapterConfigCategory.Instance.Get(taskConfig.Target[0]).ChapterName;
            string text1 = string.Format(progress, chapterName, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescKillChallengeMonsterNumber(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("击败挑战级任意怪物{0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescKillInfernalMonsterNumber(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("击败地狱级任意怪物{0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescKillChallengeBossNumber(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("击败挑战级任意领主怪物{0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescKillInfernalBossNumber(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("击败地狱级任意领主怪物{0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetDescItemId(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("寻找道具{0} {1}/{2}");
            int itemId = taskConfig.Target[0];
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
            string text1 = string.Format(progress, itemConfig.ItemName, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public void OnGoToNpc(Scene scene, int npc)
        {
            MapComponent mapComponent = scene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != (int)SceneTypeEnum.MainCityScene)
            {
                FloatTipManager.Instance.ShowFloatTipDi("请前往主城!");
                return;
            }
            scene.CurrentScene().GetComponent<OperaComponent>().OnClickNpc(npc);
        }
    }
}
