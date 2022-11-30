using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class UnitHelper
    {
        public static bool LoadingScene = false;

        public static long GetMyUnitId(Scene zoneScene)
        {
            AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
            return playerComponent.MyId;    
        }

        public static Unit GetMyUnitFromZoneScene(Scene zoneScene)
        {
            AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
            Scene currentScene = zoneScene.GetComponent<CurrentScenesComponent>().Scene;
            return currentScene.GetComponent<UnitComponent>().Get(playerComponent.MyId);
        }
        
        public static Unit GetMyUnitFromCurrentScene(Scene currentScene)
        {
            AccountInfoComponent playerComponent = currentScene.Parent.Parent.GetComponent<AccountInfoComponent>();
            return currentScene.GetComponent<UnitComponent>().Get(playerComponent.MyId);
        }

        public static Unit GetUnitFromZoneSceneByID(Scene zoneScene, long id)
        {
            Scene currentScene = zoneScene.GetComponent<CurrentScenesComponent>().Scene;
            return currentScene.GetComponent<UnitComponent>().Get(id);
        }

        public static TeamPlayerInfo GetSelfTeamPlayerInfo(Scene zoneScene)
        {
            UserInfoComponent userInfoComponent = zoneScene.GetComponent<UserInfoComponent>();
            BagInfo bagInfo = zoneScene.GetComponent<BagComponent>().GetEquipBySubType((int)ItemSubTypeEnum.Wuqi);
        
            return new TeamPlayerInfo()
            {
                UserID = userInfoComponent.UserInfo.UserId,
                PlayerLv = userInfoComponent.UserInfo.Lv,
                PlayerName = userInfoComponent.UserInfo.Name,
                WeaponId = bagInfo != null ? bagInfo.ItemID : 0,
                Occ = userInfoComponent.UserInfo.Occ,
                Combat = userInfoComponent.UserInfo.Combat,
                RobotId = userInfoComponent.UserInfo.RobotId,
                OccTwo = userInfoComponent.UserInfo.OccTwo, 
            };
        }

        //public static bool IsRobot(this Unit self)
        //{
        //    AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
        //    return self.MainHero && accountInfoComponent.Password == ComHelp.RobotPassWord;
        //}

        public static bool IsRobot(this Unit self)
        {
            return self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.RobotId > 0;
        }

        public static bool IsCanChangeEquip(this Unit self)
        {
            int configId = self.ConfigId;
            return OccupationConfigCategory.Instance.Get(configId).ChangeEquip == 1;
        }

        public static void ShowAllUnit(Scene zoneScene)
        {
            List<Unit> units = zoneScene.CurrentScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (!unit.WaitLoad)
                {
                    continue;
                }
                OnAfterCreateUnit(unit);
                unit.WaitLoad = false;
            }
        }

        public static void OnAfterCreateUnit(this Unit self)
        {
            if (LoadingScene)
            {
                self.WaitLoad = true;
                return;
            }
            EventType.AfterUnitCreate.Instance.Unit = self;
            Game.EventSystem.PublishClass(EventType.AfterUnitCreate.Instance);
        }

        public static int GetTeamId(this Unit self)
        {
            return self.GetComponent<NumericComponent>().GetAsInt(NumericType.TeamId);
        }

        public static bool IsSameTeam(this Unit self, Unit other)
        { 
            return self.GetTeamId()== other.GetTeamId() && self.GetTeamId()!=0;    
        }

        public static bool IsMasterOrPet(this Unit self, Unit other, PetComponent petComponent)
        {
            if (self.Type == UnitType.Pet && self.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId) == other.Id)
            {
                return true;
            }
            if (self.Type == UnitType.Player && petComponent.GetFightPetId() == other.Id)
            {
                return true;
            }
            return false;
        }

        public static int GetBattleCamp(this Unit self)
        {
            return self.GetComponent<NumericComponent>().GetAsInt(NumericType.BattleCamp);
        }

        public static Vector3 GetBornPostion(this Unit self)
        {
            NumericComponent numericComponent = self.GetComponent<NumericComponent>();
            return new Vector3(numericComponent.GetAsFloat(NumericType.Born_X),
                numericComponent.GetAsFloat(NumericType.Born_Y),
                numericComponent.GetAsFloat(NumericType.Born_Z));
        }
    }
}