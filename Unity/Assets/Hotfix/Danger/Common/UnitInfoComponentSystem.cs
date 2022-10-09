using System;
using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class UnitInfoComponentAwakeSystem : AwakeSystem<UnitInfoComponent>
    {
        public override void Awake(UnitInfoComponent self)
        {
            self.ZhaohuanIds.Clear();
        }
    }

    [ObjectSystem]
    public class UnitInfoComponentDestroySystem : DestroySystem<UnitInfoComponent>
    {
        public override void Destroy(UnitInfoComponent self)
        {
            self.ZhaohuanIds.Clear();
        }
    }

    public static class UnitInfoComponentSystem
    {

        public static bool IsMonster(this UnitInfoComponent self)
        {
            return self.Type == UnitType.Monster;
        }

        public static bool IsPlayer(this UnitInfoComponent self)
        {
            return self.Type == UnitType.Player;
        }

        public static bool IsPet(this UnitInfoComponent self)
        {
            return self.Type == UnitType.Pet;
        }

        public static bool IsChest(this UnitInfoComponent self)
        {
            return self.IsMonster() && MonsterConfigCategory.Instance.Get(self.UnitCondigID).MonsterSonType == 55;
        }

        public static int GetMonsterType(this UnitInfoComponent self)
        {
            return MonsterConfigCategory.Instance.Get(self.UnitCondigID).MonsterType;
        }

        public static int GetMonsterSonType(this UnitInfoComponent self)
        {
            return MonsterConfigCategory.Instance.Get(self.UnitCondigID).MonsterSonType;
        }

        public static bool IsMonsterHaveAI(this UnitInfoComponent self)
        {
            return MonsterConfigCategory.Instance.Get(self.UnitCondigID).AI > 0;
        }

        public static bool IsCanBeAttack(this UnitInfoComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.GetComponent<MoveComponent>() == null)
                return false;
            if (self.Type == UnitType.Npc || self.Type == UnitType.DropItem
                || self.Type == UnitType.Chuansong)
                return false;

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsLong((int)NumericType.Now_Hp) <= 0
                || numericComponent.GetAsLong((int)NumericType.Now_Dead) == 1)
                return false;
            if (self.IsMonster() && (self.GetMonsterType() == (int)MonsterTypeEnum.SceneItem))
                return false;
            return true;
        }

        public static bool IsCanBeAttackByUnit(this UnitInfoComponent self, Unit unit)
        {
            if (self.GetParent<Unit>().Id == unit.Id)
                return false;
            ////怪物不能攻击怪物
            //if (self.IsMonster() && unit.GetComponent<UnitInfoComponent>().IsMonster())
            //    return false;
            MapComponent mapComponent = null;
#if SERVER
            mapComponent = unit.DomainScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetDungeon
                || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetTianTi)
            {
                if (self.GetParent<Unit>().Type == UnitType.Player ||  unit.Type == UnitType.Player)
                {
                    return false;
                }
            }

            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.YeWaiScene)
            {
                //除了宠物都可以攻击
                if (self.IsPet() && self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsLong(NumericType.Master_ID) == unit.Id)
                {
                    return false;
                }
                if (self.IsPlayer() && self.GetParent<Unit>().GetComponent<PetComponent>().GetFightPet() != null
                     && self.GetParent<Unit>().GetComponent<PetComponent>().GetFightPet().Id == unit.Id)
                {
                    return false;
                }
            }
            else
            {
                if (self.RoleCamp == unit.GetComponent<UnitInfoComponent>().RoleCamp)
                {
                    return false;
                }
            }
#else
            mapComponent = unit.ZoneScene().GetComponent<MapComponent>();
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetFightPetInfo();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.YeWaiScene)
            {
                if (rolePetInfo != null && self.IsPet() && self.GetParent<Unit>().Id == rolePetInfo.Id)
                {
                    return false;
                }
                if (rolePetInfo != null && self.IsPlayer() && rolePetInfo.Id == unit.Id)
                {
                    return false;
                }
            }
            else
            {
                if (self.RoleCamp == unit.GetComponent<UnitInfoComponent>().RoleCamp)
                {
                    return false;
                }
            }
#endif

            return self.IsCanBeAttack();
        }
    }
}
