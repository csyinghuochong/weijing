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

        public static Dictionary<string, Type> keyValuePairs = new Dictionary<string, Type>()
        {
                { "UserInfoComponent", typeof(UserInfoComponent) },
                { "BagComponent", typeof(BagComponent) },
                { "TaskComponent", typeof(TaskComponent) },
                { "ChengJiuComponent", typeof(ChengJiuComponent) },
                { "PetComponent", typeof(PetComponent) },
                { "SkillSetComponent", typeof(SkillSetComponent) },
                { "EnergyComponent", typeof(EnergyComponent) },
                { "ActivityComponent", typeof(ActivityComponent) },
                { "NumericComponent", typeof(NumericComponent) },
                { "RechargeComponent", typeof(RechargeComponent) },
                { "ReddotComponent", typeof(ReddotComponent) },
                { "ShoujiComponent", typeof(ShoujiComponent) },
        };

        public static async ETTask UpdateCacheDB(Unit unit)
        {
            try
            {
                List<Entity> components = new List<Entity>();

                DBSaveComponent dBSaveComponent = unit.GetComponent<DBSaveComponent>();
                for (int i = 0; i < dBSaveComponent.ChangeComponent.Count; i++)
                {
                    string changeComponet = dBSaveComponent.ChangeComponent[i];
                    components.Add(unit.GetComponent(keyValuePairs[changeComponet]));
                }
                dBSaveComponent.ChangeComponent.Clear();
                long dbCacheId = DBHelper.GetDbCacheId(unit.DomainZone());
                D2M_SaveUnit response = (D2M_SaveUnit)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveUnit() { CharacterId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId, Components = components });
                if (response.Error != ErrorCore.ERR_Success)
                {
                    Log.Error("更新缓存服Unit数据出错");
                }
            }
            catch (Exception ex)
            {
                Log.Error("更新缓存服Unit数据出错: " + ex.ToString());
            }
        }

        public static async ETTask<Entity> AddDataComponent<K>(int zone, long userID, string componentType) where K : Entity, new()
        {
            Type type = typeof(K);
            Entity entity = (Entity)Activator.CreateInstance(type);
            entity.Id = userID;
            long dBCacheId = DBHelper.GetDbCacheId(zone);
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dBCacheId, new M2D_SaveComponent()
            {
                CharacterId = userID,
                Component = entity,
                ComponentType = componentType
            });
            return entity;
        }


        public static async ETTask<bool> AddDataComponent<K>(Unit unit, long userID, string componentType) where K : Entity, new()
        {
            long dbCacheId = DBHelper.GetDbCacheId(unit.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = userID, Component = componentType });
            if (d2GGetUnit.Component != null)
            {
                unit.AddComponent(d2GGetUnit.Component);
                return false;
            }
            else
            {
                switch (componentType)
                {
                    case DBHelper.UserInfoComponent:
                        unit.AddComponent<UserInfoComponent>().Id = userID;
                        break;
                    case DBHelper.BagComponent:
                        unit.AddComponent<BagComponent>().Id = userID;
                        break;
                    case DBHelper.TaskComponent:
                        unit.AddComponent<TaskComponent>().Id = userID;
                        break;
                    case DBHelper.ChengJiuComponent:
                        unit.AddComponent<ChengJiuComponent>().Id = userID;
                        break;
                    case DBHelper.PetComponent:
                        unit.AddComponent<PetComponent>().Id = userID;
                        break;
                    case DBHelper.SkillSetComponent:
                        unit.AddComponent<SkillSetComponent>().Id = userID;
                        break;
                    case DBHelper.EnergyComponent:
                        unit.AddComponent<EnergyComponent>().Id = userID;
                        break;
                    case DBHelper.ActivityComponent:
                        unit.AddComponent<ActivityComponent>().Id = userID;
                        break;
                    case DBHelper.NumericComponent:
                        unit.AddComponent<NumericComponent>().Id = userID;
                        Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, false);
                        break;
                    case DBHelper.RechargeComponent:
                        unit.AddComponent<RechargeComponent>().Id = userID;
                        break;
                    case DBHelper.ReddotComponent:
                        unit.AddComponent<ReddotComponent>().Id = userID;
                        break;
                    case DBHelper.ShoujiComponent:
                        unit.AddComponent<ShoujiComponent>().Id = userID;
                        break;
                }
               
                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = userID, Component = unit.GetComponent<K>(), ComponentType = componentType });
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

        public static long GetQueueServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Queue)).InstanceId;
        }

        public static long GetGateServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, "Gate1").InstanceId;
        }

        public static long GetRankServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Rank)).InstanceId;
        }

        public static long GetActivityServerId(int zone)
        {
            return StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Activity)).InstanceId;
        }

        public static long GetAccountCenter()
        {
            return StartSceneConfigCategory.Instance.AccountCenterConfig.InstanceId;
        }

        public static long GetRechargeCenter()
        {
            return StartSceneConfigCategory.Instance.RechargeConfig.InstanceId;
        }

        public static async ETTask<long> GetOpenServerTime( int zone)
        {
            long dbCacheId = DBHelper.GetDbCacheId(zone);
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = zone, Component = DBHelper.DBServerInfo });
            long serverOpenTime = d2GGetUnit.Component != null ? (d2GGetUnit.Component as DBServerInfo).ServerInfo.OpenServerTime : 0;
            serverOpenTime = serverOpenTime != 0 ? serverOpenTime : TimeHelper.ServerNow();
            return serverOpenTime;
        }

    }
}
