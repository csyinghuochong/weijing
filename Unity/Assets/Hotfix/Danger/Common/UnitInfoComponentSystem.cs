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
            return self.GetParent<Unit>().Type == UnitType.Monster;
        }

        public static bool IsPlayer(this UnitInfoComponent self)
        {
            return self.GetParent<Unit>().Type == UnitType.Player;
        }

        public static bool IsPet(this UnitInfoComponent self)
        {
            return self.GetParent<Unit>().Type == UnitType.Pet;
        }

        public static bool IsChest(this UnitInfoComponent self)
        {
            return self.IsMonster() && MonsterConfigCategory.Instance.Get(self.GetParent<Unit>().ConfigId).MonsterSonType == 55;
        }

        public static int GetMonsterType(this UnitInfoComponent self)
        {
            return MonsterConfigCategory.Instance.Get(self.GetParent<Unit>().ConfigId).MonsterType;
        }

        public static int GetMonsterSonType(this UnitInfoComponent self)
        {
            return MonsterConfigCategory.Instance.Get(self.GetParent<Unit>().ConfigId).MonsterSonType;
        }

        public static bool IsMonsterHaveAI(this UnitInfoComponent self)
        {
            return MonsterConfigCategory.Instance.Get(self.GetParent<Unit>().ConfigId).AI > 0;
        }

        public static bool IsCanBeAttack(this UnitInfoComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.GetComponent<MoveComponent>() == null)
                return false;
            if (unit.Type == UnitType.Npc || unit.Type == UnitType.DropItem
                || unit.Type == UnitType.Chuansong)
                return false;

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsLong((int)NumericType.Now_Hp) <= 0
                || numericComponent.GetAsLong((int)NumericType.Now_Dead) == 1)
                return false;
            if (self.IsMonster() && (self.GetMonsterType() == (int)MonsterTypeEnum.SceneItem))
                return false;
            return true;
        }

        public static bool IsCanBeAttackByUnit(this UnitInfoComponent self, Unit beattack)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.Id == beattack.Id)
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
            mapComponent = unit.DomainScene().GetComponent<MapComponent>();
            petComponent = unit.GetComponent<PetComponent>();
#else
            mapComponent = beattack.ZoneScene().GetComponent<MapComponent>();
            petComponent = self.ZoneScene().GetComponent<PetComponent>();
#endif

            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetDungeon
                || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetTianTi)
            {
                if (unit.Type == UnitType.Player || beattack.Type == UnitType.Player)
                {
                    return false;
                }
            }

            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.YeWaiScene)
            {
                //除了宠物都可以攻击
                if (self.IsPet() && unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId) == beattack.Id)
                {
                    return false;
                }
                if (self.IsPlayer() && petComponent.GetFightPetId() == beattack.Id)
                {
                    return false;
                }
            }

            return unit.GetBattleCamp() != beattack.GetBattleCamp();
        }
    }
}
