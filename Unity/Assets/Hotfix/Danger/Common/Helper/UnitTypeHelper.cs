namespace ET
{
    public static class UnitTypeHelper
    {
        public static bool IsCanAttackUnit(this Unit self, Unit defend)
        {
            if (self.Id == defend.Id)
            {
                return false;
            }
            if (!defend.IsCanBeAttack())
            {
                return false;
            }

            MapComponent mapComponent = null;
            PetComponent petComponent = null;
#if SERVER
            mapComponent = self.DomainScene().GetComponent<MapComponent>();
            petComponent = self.GetComponent<PetComponent>();
#else
            mapComponent = defend.ZoneScene().GetComponent<MapComponent>();
            petComponent = self.ZoneScene().GetComponent<PetComponent>();
#endif

            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetDungeon
             || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetTianTi)
            {
                if (self.Type == UnitType.Player)
                {
                    return self.GetBattleCamp() != defend.GetBattleCamp();
                }
                else
                {
                    return defend.Type != UnitType.Player && self.GetBattleCamp() != defend.GetBattleCamp();
                }
            }

            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.BaoZang 
             || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.MiJing)
            {
                if (SceneConfigCategory.Instance.Get(mapComponent.SceneId).IfPVP == 1)
                { 
                    //允许pk地图
                    return !self.IsSameTeam(defend) && !self.IsMasterOrPet(defend, petComponent);
                }
            }
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.Battle)
            {
                return self.GetBattleCamp() != defend.GetBattleCamp();
            }
            return self.GetBattleCamp() != defend.GetBattleCamp() && !self.IsSameTeam(defend);
        }

        public static int GetTeamId(this Unit self)
        {
            return self.GetComponent<NumericComponent>().GetAsInt(NumericType.TeamId);
        }

        public static bool IsSameTeam(this Unit self, Unit other)
        {
            return self.GetTeamId() == other.GetTeamId() && self.GetTeamId() != 0;
        }

        public static bool IsMasterOrPet(this Unit self, Unit defend, PetComponent petComponent)
        {
            long masterId = self.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            long othermaster = defend.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            if (self.Type != UnitType.Player && masterId == defend.Id)
            {
                return true;
            }
            if (self.Type == UnitType.Player && othermaster == self.Id)
            {
                return true;
            }
            if (masterId > 0 && masterId == othermaster)
            {
                return true;
            }
            if (self.Type == UnitType.Player && petComponent.GetFightPetId() == defend.Id)
            {
                return true;
            }
            return self.Id == defend.Id;
        }

        public static long GetMasterId(this Unit self)
        {
            if (self.Type == UnitType.Player)
            {
                return self.Id;
            }
            if (self.Type == UnitType.Pet || self.Type == UnitType.Monster)
            {
                return self.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            }
            return 0;
        }

        public static int GetBattleCamp(this Unit self)
        {
            return self.GetComponent<NumericComponent>().GetAsInt(NumericType.BattleCamp);
        }

        public static bool IsCanBeAttack(this Unit self)
        {
            if (self.GetComponent<MoveComponent>() == null)
                return false;
            if (self.Type == UnitType.Npc || self.Type == UnitType.DropItem
                || self.Type == UnitType.Chuansong)
                return false;

            NumericComponent numericComponent = self.GetComponent<NumericComponent>();
            if (numericComponent.GetAsLong((int)NumericType.Now_Hp) <= 0
                || numericComponent.GetAsLong((int)NumericType.Now_Dead) == 1)
                return false;
            if (self.Type == UnitType.Monster && (self.GetMonsterType() == (int)MonsterTypeEnum.SceneItem))
                return false;
            return true;
        }

        public static int GetMonsterType(this Unit self)
        {
            return MonsterConfigCategory.Instance.Get(self.ConfigId).MonsterType;
        }

        public static bool IsSceneItem(this Unit self)
        {
            if (self.Type != UnitType.Monster)
            {
                return false;
            }
            return self.GetMonsterType() == MonsterTypeEnum.SceneItem;
        }

        public static bool IsBoss(this Unit self)
        {
            if (self.Type != UnitType.Monster)
            {
                return false;
            }
            return self.GetMonsterType() == MonsterTypeEnum.Boss;
        }

        public static bool IsChest(this Unit self)
        {
            if (self.Type != UnitType.Monster)
            {
                return false;
            }
            int sonType = MonsterConfigCategory.Instance.Get(self.ConfigId).MonsterSonType;
            return sonType == 55 || sonType == 56;
        }
    }
}
