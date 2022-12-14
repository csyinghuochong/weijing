/****************************************************
     * 作    者：Leng
     * 邮    箱：2947672@qq.com
     * 文件名称：DBHelper
     * 创建时间：2021/7/18 星期日 20:27:59
     * 功    能：
*****************************************************/
using System;
using System.Collections.Generic;

namespace ET
{
    public static class DBHelper
    {
        public const string UserInfoComponent = "UserInfoComponent";
        public const string BagComponent = "BagComponent";
        public const string TaskComponent = "TaskComponent";
        public const string ChengJiuComponent = "ChengJiuComponent";
        public const string PetComponent = "PetComponent";
        public const string SkillSetComponent = "SkillSetComponent";
        public const string EnergyComponent = "EnergyComponent";
        public const string ActivityComponent = "ActivityComponent";
        public const string NumericComponent = "NumericComponent";
        public const string RechargeComponent = "RechargeComponent";
        public const string ReddotComponent = "ReddotComponent";
        public const string ShoujiComponent = "ShoujiComponent";

        public const string DBFriendInfo = "DBFriendInfo";
        public const string DBMailInfo = "DBMailInfo";
        public const string DBServerInfo = "DBServerInfo";
        public const string DBDayActivityInfo = "DBDayActivityInfo";
        public const string DBPaiMainInfo = "DBPaiMainInfo";
        public const string DBRankInfo = "DBRankInfo";
        public const string DBUnionInfo = "DBUnionInfo";
        public const string DBAccountInfo = "DBAccountInfo";
        public const string DBCenterAccountInfo = "DBCenterAccountInfo";

        public static List<string> UnitCacheKeyList = new List<string>();

        public static List<string> GetAllUnitComponent()
        {
            if (UnitCacheKeyList.Count == 0)
            {
                foreach (Type type in Game.EventSystem.GetTypes().Values)
                {
                    if (type != typeof(IUnitCache) && typeof(IUnitCache).IsAssignableFrom(type))
                    {
                        UnitCacheKeyList.Add(type.Name);
                    }
                }

                UnitCacheKeyList.Add(DBMailInfo);
                UnitCacheKeyList.Add(DBFriendInfo);
            }
            return UnitCacheKeyList;
        }

        public static async ETTask<Entity> AddDataComponent<K>(int zone, long userID, string componentType) where K : Entity, new()
        {
            Type type = typeof(K);
            Entity entity = (Entity)Activator.CreateInstance(type);
            entity.Id = userID;
            long dBCacheId = DBHelper.GetDbCacheId(zone);
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dBCacheId, new M2D_SaveComponent()
            {
                UnitId = userID,
                Component = entity,
                ComponentType = componentType
            });
            return entity;
        }

        public static async ETTask<bool> AddDataComponent<K>(Unit unit, long userID, string componentType) where K : Entity, new()
        {
            long dbCacheId = DBHelper.GetDbCacheId(unit.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userID, Component = componentType });
            if (d2GGetUnit.Component != null)
            {
                unit.AddComponent(d2GGetUnit.Component);
                return false;
            }
            else
            {
                Entity entity =  unit.AddComponent(typeof(K));
                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = userID, Component = entity, ComponentType = componentType });
                return true;
            }
        }

        public static long GetCenterServerId()
        {
            return StartSceneConfigCategory.Instance.CenterConfig.InstanceId;
        }

        public static long GetDbCacheId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.DBCache)).InstanceId;
        }

        public static long GetFubenCenterId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.FubenCenter)).InstanceId;
        }

        public static long GetUnionServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Union)).InstanceId;
        }

        public static long GetAccountServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Account)).InstanceId;
        }

        public static long GetChatServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, "Chat").InstanceId;
        }

        public static long GetQueueServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Queue)).InstanceId;
        }

        public static long GetGateServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, "Gate1").InstanceId;
        }

        public static long GetPaiMaiServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, "PaiMai").InstanceId;
        }

        public static long GetRankServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Rank)).InstanceId;
        }

        public static long GetActivityServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Activity)).InstanceId;
        }

        public static long GetTeamServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Team)).InstanceId;
        }

        public static long GetBattleServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Battle)).InstanceId;
        }

        public static long GetRobotServerId()
        {
            long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
            return robotSceneId;
        }

        public static long GetAccountCenter()
        {
            return StartSceneConfigCategory.Instance.AccountCenterConfig.InstanceId;
        }

        public static long GetRechargeCenter()
        {
            return StartSceneConfigCategory.Instance.RechargeConfig.InstanceId;
        }

        public static int GetOpenServerDay(int zone)
        {
            return ServerHelper.GetOpenServerDay(true, zone);
            //long openSerTime = GetOpenServerTime(zone);
            //if (openSerTime == 0)
            //{
            //    return 0;
            //}

            //long serverNow = TimeHelper.ServerNow();
            //int openserverDay = ComHelp.DateDiff_Time(serverNow, openSerTime);
            //return openserverDay;
        }

        /// <summary>
        /// 获取玩家缓存
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static async ETTask<Unit> GetUnitCache(Scene scene, Unit unit)
        {
            long instanceId = DBHelper.GetDbCacheId(scene.DomainZone());
            G2D_GetUnit message = new G2D_GetUnit() { UnitId = unit.Id };
            D2G_GetUnit queryUnit = (D2G_GetUnit)await MessageHelper.CallActor(instanceId, message);
           
            for (int i = 0; i < queryUnit.EntityList.Count; i++)
            {
                Entity entity = queryUnit.EntityList[i];
                if (entity == null)
                {

                }
                else
                {
                    unit.AddComponent(entity);
                }
            }
            return unit;
        }

        /// <summary>
        /// 删除玩家缓存
        /// </summary>
        /// <param name="unitId"></param>
        public static async ETTask DeleteUnitCache(int zone, long unitId)
        {
            M2D_DeleteUnit message = new M2D_DeleteUnit() { UnitId = unitId };
            long instanceId = DBHelper.GetDbCacheId(zone);
            await MessageHelper.CallActor(instanceId, message);
        }

        public static async ETTask SaveUnitComponentCache(int zone, long unitId, Entity entity)
        {
            long dbCacheId = DBHelper.GetDbCacheId(zone);
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() {
                UnitId = unitId,
                Component = entity
            });
        }

        public static long GetUnitCacheConfig(long unitId)
        {
            int zone = UnitIdStruct.GetUnitZone(unitId);
            return GetDbCacheId(zone);
        }

        /// <summary>
        /// 获取玩家组件缓存
        /// </summary>
        /// <param name="unitId"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async ETTask<T> GetComponentCache<T>(int zone, long unitId) where T : Entity
        {
            G2D_GetComponent message = new G2D_GetComponent() { UnitId = unitId };
            message.Component = typeof(T).Name;
            long instanceId = DBHelper.GetDbCacheId(zone);
            D2G_GetComponent queryUnit = (D2G_GetComponent)await MessageHelper.CallActor(instanceId, message);
            if (queryUnit.Error == ErrorCode.ERR_Success && queryUnit.Component!=null)
            {
                return queryUnit.Component as T;
            }
            return null;
        }
    }
}
