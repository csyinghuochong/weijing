namespace ET
{
    public static class UnitTypeHelper
    {
        public static bool IsCanBeAttackByUnit(this Unit self, Unit attack)
        {
            if (self.Id == attack.Id)
            {
                return false;
            }
            if (!self.IsCanBeAttack())
            {
                return false;
            }

            MapComponent mapComponent = null;
            PetComponent petComponent = null;
#if SERVER
            mapComponent = self.DomainScene().GetComponent<MapComponent>();
            petComponent = self.GetComponent<PetComponent>();
#else
            mapComponent = attack.ZoneScene().GetComponent<MapComponent>();
            petComponent = self.ZoneScene().GetComponent<PetComponent>();
#endif

            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetDungeon
             || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetTianTi)
            {
                return self.Type != UnitType.Player && attack.Type == UnitType.Player;
            }

            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.YeWaiScene)
            {
                //除了宠物都可以攻击
                if (self.Type == UnitType.Pet && self.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId) == attack.Id)
                {
                    return false;
                }
                if (self.Type == UnitType.Player && petComponent.GetFightPetId() == attack.Id)
                {
                    return false;
                }
                return SceneConfigCategory.Instance.Get(mapComponent.SceneId).IfPVP == 1;
            }

            return self.GetBattleCamp() != attack.GetBattleCamp();
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
