using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{
    public static class MapHelper
    {
        public static void  SendZhaoHuan(Scene zoneScene)
        {
            try
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
                if (unit == null)
                {
                    return;
                }
                C2M_CreateSpiling zhaohuancmd = new C2M_CreateSpiling()
                {
                    X = unit.Position.x,
                    Y = unit.Position.y,
                    Z = unit.Position.z,
                    ParentUnitId = unit.Id
                };
                zoneScene.GetComponent<SessionComponent>().Session.Send(zhaohuancmd);
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }

        public static Unit GetNearestUnit(Unit unit)
        {
            List<Entity> units = unit.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Children.Values.ToList();
            Unit nearest = null;
            float distance = -1f;
            for (int i = 0; i < units.Count; i++)
            {
                Unit uu = units[i] as Unit;
                if (unit.Id == uu.Id)
                    continue;
                if (!uu.GetComponent<UnitInfoComponent>().IsCanBeAttackByUnit(unit))
                    continue;
                float dd = Vector3.Distance(unit.Position, uu.Position);
                if (distance < 0f || dd < distance)
                {
                    nearest = uu;
                    distance = dd;
                }
            }
            return nearest;
        }

        public static Unit GetNearItem(Scene zoneScene)
        {
            float distance = 10f;
            Unit unit = null;
            Unit main = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            List<Unit> units = zoneScene.CurrentScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit uu = units[i] as Unit;
                if (uu.GetComponent<UnitInfoComponent>().Type != UnitType.DropItem)
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(main, uu);
                if (dd < distance)
                {
                    unit = uu;
                    distance = dd;
                }
            }
            return unit;
        }

        public static long GetChestBox(Scene zoneScene)
        {
            List<Unit> units = zoneScene.CurrentScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit uu = units[i];
                if (!uu.GetComponent<UnitInfoComponent>().IsChest())
                {
                    continue;
                }
                if (PositionHelper.Distance2D(UnitHelper.GetMyUnitFromZoneScene(zoneScene), uu) < 10f)
                {
                    return uu.Id;
                }
            }
            return 0;
        }

        public static List<DropInfo> GetCanShiQu(Scene zoneScene)
        {
            List<DropInfo> ids = new List<DropInfo>();
            List<Entity> units = zoneScene.CurrentScene().GetComponent<UnitComponent>().Children.Values.ToList();
            for (int i = 0; i < units.Count; i++)
            {
                Unit uu = units[i] as Unit;
                if (uu.GetComponent<UnitInfoComponent>().Type != UnitType.DropItem)
                {
                    continue;
                }
                if (PositionHelper.Distance2D(UnitHelper.GetMyUnitFromZoneScene(zoneScene), uu) < 3f)
                {
                    ids.Add(uu.GetComponent<DropComponent>().DropInfo);
                }
            }
            return ids;
        }

        public static async ETTask SendShiquItem(Scene zoneScene, List<DropInfo> ids)
        {
            try
            {
                Actor_PickItemRequest actor_PickItemRequest = new Actor_PickItemRequest() { ItemIds = ids };
                Actor_PickItemResponse actor_PickItemResponse = await zoneScene.GetComponent<SessionComponent>().Session.Call(actor_PickItemRequest) as Actor_PickItemResponse;

                for (int i = 0; i < ids.Count; i++)
                {
                    if (ids[i].DropType == 0)
                    {
                        continue;
                    }
                    zoneScene.CurrentScene().GetComponent<UnitComponent>().Remove(ids[i].UnitId);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="zoneScene"></param>
        /// <param name="operatype">1新增  2移除</param>
        /// <param name="stateType"></param>
        /// <param name="stateValue"></param>
        public static void SendUpdateState(Scene zoneScene, int operatype, long stateType,  string stateValue)
        {
            C2M_UnitStateUpdate c2M_UnitStateUpdate = new C2M_UnitStateUpdate() { StateOperateType = operatype, StateType = stateType, StateValue = stateValue };
            zoneScene.GetComponent<SessionComponent>().Session.Send(c2M_UnitStateUpdate);

            if (operatype == 2 && stateType == (long)StateTypeEnum.Singing)
            {
                return;
            }
            if (operatype == 1 && stateType == (long)StateTypeEnum.Singing)
            {
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(int.Parse(stateValue));
                WaitUseSkill(zoneScene, (long)(skillConfig.SkillFrontSingTime * 1000)).Coroutine();
            }
        }

        public static async ETTask  WaitUseSkill(Scene zoneScene, long waitTime)
        {
            await TimerComponent.Instance.WaitAsync(waitTime);
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            if (!unit.GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.Singing))
            {
                return;
            }
            SendUseSkill(zoneScene, SkillCmd.SkillID, SkillCmd.TargetAngle, SkillCmd.TargetID, SkillCmd.TargetDistance, false).Coroutine();
        }

        public static  readonly C2M_SkillCmd SkillCmd = new C2M_SkillCmd();

        public static async ETTask<int> SendUseSkill(Scene zoneScene, int skillid, int angle, long targetId, float distance, bool checksing = true)
        {
            try
            {
                SkillCmd.SkillID = skillid;
                SkillCmd.TargetAngle = angle;
                SkillCmd.TargetID = targetId;
                SkillCmd.TargetDistance = distance;
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
                int errorCode = unit.GetComponent<SkillManagerComponent>().CanUseSkill(skillid);
                if (errorCode != ErrorCore.ERR_Success)
                {
                    return errorCode;
                }
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillid);
                if (skillConfig.SkillFrontSingTime == 0f)
                {
                    checksing = false;
                }
                if (checksing && skillConfig.SkillFrontSingTime > 0)
                {
                    if (unit.GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.Singing))
                    {
                        return errorCode;
                    }
                    SendUpdateState(zoneScene, 1, (int)StateTypeEnum.Singing, SkillCmd.SkillID.ToString());
                    return ErrorCore.ERR_Success;
                }
                unit.GetComponent<StateComponent>().BeginMoveOrSkill();
                unit.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.SkillRigidity);
                M2C_SkillCmd m2C_SkillCmd = await zoneScene.GetComponent<SessionComponent>().Session.Call(SkillCmd) as M2C_SkillCmd;
                unit.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.SkillRigidity);
                if (m2C_SkillCmd.Error != 0)
                {
                    unit.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.SkillRigidity);
                }
                else
                {
                    unit.GetComponent<SkillManagerComponent>().AddSkillCD(skillid, skillConfig, m2C_SkillCmd.CDEndTime);
                    unit.GetComponent<StateComponent>().RigidityEndTime = (long)(skillConfig.SkillRigidity * 1000) + TimeHelper.ServerNow();
                }
                return m2C_SkillCmd.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

    }
}
