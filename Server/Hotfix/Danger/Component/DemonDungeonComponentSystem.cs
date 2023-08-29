using System.Collections.Generic;

namespace ET
{
    public static class DemonDungeonComponentSystem
    {

        public static void OnClose(this DemonDungeonComponent self)
        {
            Log.Console("生成恶魔");

            List<Unit> destlist = new List<Unit>();
            List<Unit> sourcelist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);

            ///开始后会根据当前场景的人数随机生成X个 恶魔
            int demonNumber = 0;

            RandomHelper.GetRandListByCount(sourcelist, destlist, demonNumber);

            for (int i = 0; i < destlist.Count; i++)
            {
                destlist[i].GetComponent<NumericComponent>().ApplyValue(NumericType.RunRaceMonster, 90000017);
                Function_Fight.GetInstance().UnitUpdateProperty_DemonBig(destlist[i], true);
            }

            ///创建个恶魔怪作为测试90000017
            Unit unit = UnitFactory.CreateMonster(self.DomainScene(), 90000017, sourcelist[0].Position, new CreateMonsterInfo()
            { Camp = CampEnum.CampPlayer_2, MasterID = 0 });
        }

        public static void OnOver(this DemonDungeonComponent self)
        { 
            
        }

        public static void OnKillEvent(this DemonDungeonComponent self, Unit defend, Unit attack)
        {
            int monsterId = defend.GetComponent<NumericComponent>().GetAsInt(NumericType.RunRaceMonster);

            //1被恶魔打败的玩家会变成小恶魔,
            if (defend.Type == UnitType.Player && monsterId == 0)
            {
                defend.GetComponent<HeroDataComponent>().OnRevive();

                defend.GetComponent<NumericComponent>().ApplyValue(NumericType.BattleCamp, CampEnum.CampPlayer_2 );
                defend.GetComponent<NumericComponent>().ApplyValue(NumericType.RunRaceMonster, 90000018);
                Function_Fight.GetInstance().UnitUpdateProperty_DemonBig(defend, true);
            }

            //如果小恶魔被击败将进入幽灵模式,幽灵模式不能放任何技能，其他玩家也玩不见自己,只能移动.  添加一个隐身buff
            if (defend.Type == UnitType.Player && monsterId == 90000018)
            {
                defend.GetComponent<NumericComponent>().ApplyValue(NumericType.RunRaceMonster, 90000019);
                BuffData buffData_1 = new BuffData();
                buffData_1.SkillId = 67000278;
                buffData_1.BuffId = 90001081;
                defend.GetComponent<BuffManagerComponent>().BuffFactory(buffData_1, defend, null, true);
                Function_Fight.GetInstance().UnitUpdateProperty_DemonBig(defend, true);
            }
        }

    }
}
