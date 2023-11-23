using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{

    public class TaskViewHelp : Singleton<TaskViewHelp>
    {

        public delegate bool TaskExcuteDelegate(Scene scene, TaskPro taskPro, TaskConfig taskConfig);
        public delegate string TaskDescDelegate(TaskPro taskPro, TaskConfig taskConfig);

        public class TaskLogic
        {
            public TaskExcuteDelegate taskExcute;
            public TaskDescDelegate taskProgess;
        }
        public Dictionary<TaskTargetType, TaskLogic> TaskTypeLogic = new Dictionary<TaskTargetType, TaskLogic>();


        protected override void InternalInit()
        {
            base.InternalInit();

            TaskTypeLogic.Add(TaskTargetType.KillMonsterID_1, new TaskLogic() { taskExcute = ExcuteKillMonsterID, taskProgess = GetDescKillMonsterID } );
            TaskTypeLogic.Add(TaskTargetType.ItemID_Number_2, new TaskLogic() { taskExcute = ExcuteItemId, taskProgess = GetDescItemId });
            TaskTypeLogic.Add(TaskTargetType.LookingFor_3, new TaskLogic() { taskExcute = ExcuteLookingFor, taskProgess = GetDescLookingFor });
            TaskTypeLogic.Add(TaskTargetType.PlayerLv_4, new TaskLogic() { taskExcute = ExcutePlayerLv, taskProgess = GetDescPlayerLv });
            TaskTypeLogic.Add(TaskTargetType.KillMonster_5, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillMonster });
            TaskTypeLogic.Add(TaskTargetType.KillBOSS_6, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillBOSS });
            TaskTypeLogic.Add(TaskTargetType.PassFubenID_7, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescPassFubenID });
            TaskTypeLogic.Add(TaskTargetType.ChangeOcc_8, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetChangeOcc });
            TaskTypeLogic.Add(TaskTargetType.JoinUnion_9, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetJoinUnion });
            TaskTypeLogic.Add(TaskTargetType.GiveItem_10, new TaskLogic() { taskExcute = this.ExcuteMoveTo, taskProgess = GetGiveItem });

            TaskTypeLogic.Add(TaskTargetType.PetNumber1_11, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetNumber1_11 });
            TaskTypeLogic.Add(TaskTargetType.MakeNumber_12, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = MakeNumber_12 });
            TaskTypeLogic.Add(TaskTargetType.EquipXiLian_13, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = EquipXiLian_13 });
            TaskTypeLogic.Add(TaskTargetType.PetTianTiNumber_14, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetTianTiNumber_14 });
            TaskTypeLogic.Add(TaskTargetType.DuiHuanGold_15, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = DuiHuanGold_15 });
            TaskTypeLogic.Add(TaskTargetType.EquipHuiShou_16, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = EquipHuiShou_16 });
            TaskTypeLogic.Add(TaskTargetType.QiangHuaLevel_17, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = QiangHuaLevel_17 });
            TaskTypeLogic.Add(TaskTargetType.PetNSkill_18, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetNSkill_18 });
            TaskTypeLogic.Add(TaskTargetType.PetFubenId_19, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetFubenId_19 });
            TaskTypeLogic.Add(TaskTargetType.TotalCostGold_20, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = TotalCostGold_20 });
            TaskTypeLogic.Add(TaskTargetType.KillPlayer_21, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = KillPlayer_21 });
            TaskTypeLogic.Add(TaskTargetType.JiaYuanLevel_22, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = JiaYuanLevel_22 });
            TaskTypeLogic.Add(TaskTargetType.PetHeCheng_23, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetHeCheng_23 });
            TaskTypeLogic.Add(TaskTargetType.PetNumber2_24, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetNumber2_24 });
            TaskTypeLogic.Add(TaskTargetType.GivePet_25, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = GivePet_25 });
            TaskTypeLogic.Add(TaskTargetType.TreasureMapNormal_26, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = TreasureMapNormal_26 });
            TaskTypeLogic.Add(TaskTargetType.TreasureMapHigh_27, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = TreasureMapHigh_27 });
            TaskTypeLogic.Add(TaskTargetType.TowerOfSeal_28, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = TowerOfSeal_28 });
            TaskTypeLogic.Add(TaskTargetType.MakeQulityNumber_29, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = MakeQulityNumber_29 });

            TaskTypeLogic.Add(TaskTargetType.PetNumber_31, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetNumber_31 });
            TaskTypeLogic.Add(TaskTargetType.PetHeChengCombat_32, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetHeChengCombat_32 });
            TaskTypeLogic.Add(TaskTargetType.PetXiLian10010086_33, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetXiLian10010086_33 });
            TaskTypeLogic.Add(TaskTargetType.PetFuHuaNumber_34, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetFuHuaNumber_34 });
            TaskTypeLogic.Add(TaskTargetType.PetFuHuaId_35, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetFuHuaId_35 });

            TaskTypeLogic.Add(TaskTargetType.FuMoQulity_41, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = FuMoQulity_41 });
            TaskTypeLogic.Add(TaskTargetType.JianDingQulity_42, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = JianDingQulity_42 });
            TaskTypeLogic.Add(TaskTargetType.JianDingAttrNumber_43, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = JianDingAttrNumber_43 });
            TaskTypeLogic.Add(TaskTargetType.XiLianSkillNumber_44, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = XiLianSkillNumber_44 });
            TaskTypeLogic.Add(TaskTargetType.XiLianAttriId_45, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = XiLianAttriId_45 });

            TaskTypeLogic.Add(TaskTargetType.TrialRank_81, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = TrialRank_81 });
            TaskTypeLogic.Add(TaskTargetType.PetTianTiRank_82, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = PetTianTiRank_82 });
            TaskTypeLogic.Add(TaskTargetType.CombatRank_83, new TaskLogic() { taskExcute = this.ExcuteDoNothing, taskProgess = CombatRank_83 });
            
            TaskTypeLogic.Add(TaskTargetType.KillTiaoZhanMonsterID_101, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillChallengeMonsterID });
            TaskTypeLogic.Add(TaskTargetType.KillDiYuMonsterID_102, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillInfernalMonsterID });
            TaskTypeLogic.Add(TaskTargetType.PassTianZhanFubenID_111, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescPassChallengeFubenID }); 
            TaskTypeLogic.Add(TaskTargetType.PassDiYuFubenID_112, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescPassInfernalFubenID });
            TaskTypeLogic.Add(TaskTargetType.KillTianZhanMonsterNumber_121, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillChallengeMonsterNumber });
            TaskTypeLogic.Add(TaskTargetType.KillDiYuMonsterNumber_122, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillInfernalMonsterNumber });
            TaskTypeLogic.Add(TaskTargetType.KillTianZhanBossNumber_131, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillChallengeBossNumber });
            TaskTypeLogic.Add(TaskTargetType.KillDiYuBossNumber_132, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescKillInfernalBossNumber });
            TaskTypeLogic.Add(TaskTargetType.CombatToValue_133, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetDescCombatToValue });
            TaskTypeLogic.Add(TaskTargetType.TrialTowerCeng_134, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = GetTrialTowerCeng });
            
            TaskTypeLogic.Add(TaskTargetType.ShenYuanNumber_135, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = ShenYuanNumber_135 });
            TaskTypeLogic.Add(TaskTargetType.TeamDungeonHurt_136, new TaskLogic() { taskExcute = ExcuteDoNothing, taskProgess = TeamDungeonHurt_136 });
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
            int fubenId = SceneConfigHelper.GetFubenByMonster(monsterId);
            fubenId = taskPro.FubenId > 0 ? taskPro.FubenId : fubenId;

            
            MapComponent mapComponent = domainscene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.LocalDungeon )
            {
                if (fubenId == 0)
                {
                    return false;
                }
                FloatTipManager.Instance.ShowFloatTip($"请前往 {DungeonConfigCategory.Instance.Get(fubenId).ChapterName}");
                return false;
            }
            if (mapComponent.SceneId != fubenId)
            {
                if (GeToOtherFuben(domainscene, fubenId, mapComponent.SceneId))
                {
                    return true;
                }
            }
            int wave = taskPro.FubenId > 0 ? taskPro.WaveId : -1;
            string[] position = SceneConfigHelper.GetPostionMonster(fubenId, monsterId, wave);
            if (position == null)
            {
                FloatTipManager.Instance.ShowFloatTip("请手动前往");
                return false;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(domainscene);
            Vector3 target = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));
            Vector3 dir = unit.Position - target;
            Vector3 ttt = target + dir.normalized * 1f;
            unit.MoveToAsync2(ttt).Coroutine();
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

        public bool ExcuteMoveTo(Scene zoneScene, TaskPro taskPro, TaskConfig taskConfig)
        {
            int curdungeonid = zoneScene.GetComponent<MapComponent>().SceneId;
            int npcid = taskConfig.CompleteNpcID;
            string fubenname = "副本";
            if (!TaskHelper.HaveNpc(zoneScene, npcid))
            {
                int fubenId = TaskViewHelp.Instance.GetFubenByNpc(npcid);

                if (fubenId >= 0 && fubenId != curdungeonid)
                {
                    if (GeToOtherFuben(zoneScene, fubenId, curdungeonid))
                    {
                        return true;
                    }
                }

                //再查找其他scene
                if (fubenId == 0)
                {
                    fubenId = TaskViewHelp.Instance.GetSceneByNpc(taskConfig.CompleteNpcID);
                    if (fubenId > 0)
                    {
                        fubenname = SceneConfigCategory.Instance.Get(fubenId).Name;
                    }
                }
                else
                {
                    fubenname = DungeonConfigCategory.Instance.Get(fubenId).ChapterName;
                }

                FloatTipManager.Instance.ShowFloatTip($"请前往{fubenname}");
                return true;
            }

            FloatTipManager.Instance.ShowFloatTip("正在前往任务目标点");
            TaskViewHelp.Instance.MoveToNpc(zoneScene, npcid).Coroutine();
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
            EventType.DataUpdate.Instance.DataType = DataType.BeforeMove;
            EventType.DataUpdate.Instance.DataParamString = string.Empty;
            Game.EventSystem.PublishClass(EventType.DataUpdate.Instance);
            unit.MoveToAsync2(gameObject.transform.position, true).Coroutine();
        }

        public bool GeToOtherFuben(Scene zoneScene,  int fubenId, int curdungeonid)
        {
            int transformid = DungeonConfigCategory.Instance.GetTransformId(fubenId, curdungeonid);
            if (transformid > 0)
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
                DungeonTransferConfig transferConfig = DungeonTransferConfigCategory.Instance.Get(transformid);
                Vector3 vector3 = new Vector3(transferConfig.Position[0] * 0.01f, transferConfig.Position[1] * 0.01f, transferConfig.Position[2] * 0.01f);
                unit.MoveToAsync2(vector3, false).Coroutine();
                return true;
            }
            return false;
        }

        public  async ETTask<int> MoveToNpc(Scene zoneScene, int npcid)
        {
            if (!TaskHelper.HaveNpc(zoneScene, npcid))
            {
                return ErrorCode.ERR_NotFindNpc;
            }
            Vector3 targetPos;
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcid);
            targetPos = new Vector3(npcConfig.Position[0] * 0.01f, npcConfig.Position[1] * 0.01f, npcConfig.Position[2] * 0.01f);
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            long instanceid = unit.InstanceId;
            targetPos.y = unit.Position.y;

            int ret = 0;
            if (Vector3.Distance(unit.Position, targetPos) > TaskHelper.NpcSpeakDistance + 0.1f)
            {
                Vector3 dir = (unit.Position - targetPos).normalized;
                targetPos += dir * TaskHelper.NpcSpeakDistance;
                EventType.DataUpdate.Instance.DataType = DataType.BeforeMove;
                EventType.DataUpdate.Instance.DataParamString = "1";
                Game.EventSystem.PublishClass(EventType.DataUpdate.Instance);

                ret = await unit.MoveToAsync2(targetPos, false);
            }
            if (instanceid != unit.InstanceId || Vector3.Distance(unit.Position, targetPos) > TaskHelper.NpcSpeakDistance)
            {
                return -1;
            }
            EventType.TaskNpcDialog.Instance.NpcId = npcid;
            EventType.TaskNpcDialog.Instance.zoneScene = zoneScene;
            EventType.TaskNpcDialog.Instance.ErrorCode = ret;
            EventSystem.Instance.PublishClass(EventType.TaskNpcDialog.Instance);
            return ret;
        }


        public bool ExcuteTask(Scene zoneScene, TaskPro taskPro)
        {
            int curdungeonid = zoneScene.GetComponent<MapComponent>().SceneId;
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get( taskPro.taskID );
            int target = taskConfig.TargetType;
            int npcid = taskConfig.CompleteNpcID;
            string fubenname = "副本";
            if (taskPro.taskStatus == (int)TaskStatuEnum.Completed)
            {
                if (!TaskHelper.HaveNpc(zoneScene, npcid))
                {
                    int fubenId = TaskViewHelp.Instance.GetFubenByNpc(npcid);
       
                    if (fubenId >= 0 && fubenId != curdungeonid)
                    {
                        if (GeToOtherFuben(zoneScene, fubenId, curdungeonid))
                        {
                            return true;
                        }
                    }

                    //再查找其他scene
                    if (fubenId == 0)
                    {
                        fubenId = TaskViewHelp.Instance.GetSceneByNpc(taskConfig.CompleteNpcID);
                        if (fubenId > 0)
                        {
                            fubenname = SceneConfigCategory.Instance.Get(fubenId).Name;
                        }
                    }
                    else
                    {
                        fubenname = DungeonConfigCategory.Instance.Get(fubenId).ChapterName;
                    }
                   
                    FloatTipManager.Instance.ShowFloatTip($"请前往{fubenname}");
                    return true;
                }
                FloatTipManager.Instance.ShowFloatTip("正在前往任务目标点");
                TaskViewHelp.Instance.MoveToNpc(zoneScene, npcid).Coroutine();
                return false;
            }
            if (taskConfig.TargetPosition != 0)
            {
                bool excuteVAlue = TaskViewHelp.Instance.MoveToTask(zoneScene,taskConfig.TargetPosition);
                if (excuteVAlue)
                {
                    FloatTipManager.Instance.ShowFloatTip("正在前往任务目标点");
                    return true;
                }
            }
            TaskViewHelp.Instance.TaskTypeLogic[(TaskTargetType)target].taskExcute(zoneScene, taskPro, taskConfig);
            return true;
        }

        public int GetSceneByNpc(int npcId)
        {
            if (npcId == 0)
            {
                return 0;
            }
            List<SceneConfig> dungeonConfigs = SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < dungeonConfigs.Count; i++)
            {
                SceneConfig dungeonConfig = dungeonConfigs[i];
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

        public string GetDescKillMonsterID(TaskPro taskPro, TaskConfig taskConfig)
        {
            string desc = "";
            string progress = "击败{0} {1}/{2} {3}";
            
            for (int i = 0; i < taskConfig.Target.Length; i++)
            {
                int monsterId = taskConfig.Target[i];
                int fubenId = SceneConfigHelper.GetFubenByMonster(monsterId);
                fubenId = taskPro.FubenId > 0 ? taskPro.FubenId : fubenId;
                string fubenName = fubenId > 0 ? " (地图:" + DungeonConfigCategory.Instance.Get(fubenId).ChapterName + ")" : "";
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
            string fubenName = fubenId > 0 ? " (地图:" + DungeonConfigCategory.Instance.Get(fubenId).ChapterName + ")" : "";

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

        public string GetGiveItem(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("给予一件道具 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetNumber1_11(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("获得宠物数量 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string MakeNumber_12(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("制造道具数量 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

      
        public string EquipXiLian_13(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("装备洗练次数 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetTianTiNumber_14(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("宠物天梯次数 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string DuiHuanGold_15(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("兑换金币次数 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string EquipHuiShou_16(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("装备回收次数 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string QiangHuaLevel_17(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("最大强化等级 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetNSkill_18(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization(taskConfig.TargetValue[0] + "技能宠物 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetFubenId_19(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("宠物探险通关{0} {1}/{2}");

            string text1 = string.Format(progress, taskConfig.TargetValue[0], taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string TotalCostGold_20(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("消耗金币 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string KillPlayer_21(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("击杀玩家数量 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string JiaYuanLevel_22(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("家园等级 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetHeCheng_23(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("宠物合成次数 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetNumber2_24(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("拥有宠物数量 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string GivePet_25(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("给予一个宠物 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string TreasureMapNormal_26(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("使用普通藏宝图 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string TreasureMapHigh_27(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("使用高级藏宝图 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string TowerOfSeal_28(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("封印之塔挑战 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string MakeQulityNumber_29(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("制造道具数量 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetNumber_31(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("获得X只新的宠物 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetHeChengCombat_32(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("合成1只战力达到X点的宠物 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetXiLian10010086_33(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("宠物使用宠之晶洗炼宠物次数 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetFuHuaNumber_34(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("在孵化系统中孵化成功宠物 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetFuHuaId_35(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("在孵化系统中孵化指定的宠物蛋成功 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string FuMoQulity_41(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("使用N点品质的鉴定附魔道具给装备附魔 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string JianDingQulity_42(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("使用N点品质的鉴定道具给装备鉴定 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string JianDingAttrNumber_43(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("鉴定装备时出一个大于N条属性的装备 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string XiLianSkillNumber_44(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("洗炼出带有任何隐藏技能的装备 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string XiLianAttriId_45(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("洗炼出带有指定属性的装备 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string TrialRank_81(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("试炼之地的输出排行榜进入前 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string PetTianTiRank_82(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("宠物天梯进入排行榜前 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string CombatRank_83(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("战力排行榜进入前 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, 1);
            return text1;
        }

        public string GetJoinUnion(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("加入家族 {0}/{1}");
            string text1 = string.Format(progress,  taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
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

        public string GetDescCombatToValue(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("战力提升至{0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string GetTrialTowerCeng(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("通关试练塔{0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string ShenYuanNumber_135(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("挑战深渊模式的副本 {0}/{1}");
            string text1 = string.Format(progress, taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            return text1;
        }

        public string TeamDungeonHurt_136(TaskPro taskPro, TaskConfig taskConfig)
        {
            string progress = GameSettingLanguge.LoadLocalization("组队副本伤害值 {0}/{1}");
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
            scene.CurrentScene().GetComponent<OperaComponent>().OnClickNpc(npc).Coroutine();
        }
    }
}
