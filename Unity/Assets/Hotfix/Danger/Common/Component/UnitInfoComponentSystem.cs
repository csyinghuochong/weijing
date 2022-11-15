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
            if (unit.Type == UnitType.Monster && (unit.GetMonsterType() == (int)MonsterTypeEnum.SceneItem))
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
                return unit.Type != UnitType.Player && beattack.Type == UnitType.Player;
            }

            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.YeWaiScene)
            {
                //除了宠物都可以攻击
                if (unit.Type == UnitType.Pet && unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId) == beattack.Id)
                {
                    return false;
                }
                if (unit.Type == UnitType.Player && petComponent.GetFightPetId() == beattack.Id)
                {
                    return false;
                }
                return true;
            }

            return unit.GetBattleCamp() != beattack.GetBattleCamp();
        }
    }
}
