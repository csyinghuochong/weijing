using System.Collections.Generic;

namespace ET
{
    public static class UnitHelper
    {
        public static bool LoadingScene = false;

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
            BagInfo bagInfo = zoneScene.GetComponent<BagComponent>().GetEquipByWeizhi((int)ItemSubTypeEnum.Wuqi);
        
            return new TeamPlayerInfo()
            {
                UserID = userInfoComponent.UserInfo.UserId,
                PlayerLv = userInfoComponent.UserInfo.Lv,
                PlayerName = userInfoComponent.UserInfo.Name,
                WeaponId = bagInfo != null ? bagInfo.ItemID : 0,
                Occ = userInfoComponent.UserInfo.Occ,
                Combat = zoneScene.GetComponent<UserInfoComponent>().UserInfo.Combat,
            };
        }

        public static bool IsRobot(this Unit self)
        {
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            return self.MainHero && accountInfoComponent.Password == ComHelp.RobotPassWord;
        }


        public static bool IsCanChangeEquip(this Unit self)
        {
            int configId = self.GetComponent<UnitInfoComponent>().UnitCondigID;
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
            UnitInfoComponent unitInfoComponent = self.GetComponent<UnitInfoComponent>();
            switch (unitInfoComponent.Type)
            {
                case UnitType.Player:
                    EventType.AfterUnitCreate.Instance.Unit = self;
                    Game.EventSystem.PublishClass(EventType.AfterUnitCreate.Instance);
                    break;
                case UnitType.Monster:
                    EventType.AfterSpilingCreate.Instance.Unit = self;
                    Game.EventSystem.PublishClass(EventType.AfterSpilingCreate.Instance);
                    break;
                case UnitType.Pet:
                    EventType.AfterPetCreate.Instance.Unit = self;
                    Game.EventSystem.PublishClass(EventType.AfterPetCreate.Instance);
                    break;
                case UnitType.DropItem:
                    EventType.AfterDropCreate.Instance.Unit = self;
                    Game.EventSystem.PublishClass(EventType.AfterDropCreate.Instance);
                    break;
                case UnitType.Chuansong:
                    EventType.AfterTransferCreate.Instance.Unit = self;
                    Game.EventSystem.PublishClass(EventType.AfterTransferCreate.Instance);
                    break;
                case UnitType.Npc:
                    EventType.AfterNpcCreate.Instance.Unit = self;
                    Game.EventSystem.PublishClass(EventType.AfterNpcCreate.Instance);
                    break;
            }
        }
    }
}