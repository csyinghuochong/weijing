using System.Collections.Generic;

namespace ET
{
    public static class DemonDungeonComponentSystem
    {

        public static void OnBegin(this DemonDungeonComponent self)
        {
            if (self.DomainZone() == 5)
            {
                long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
                MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest()
                {
                    Zone = self.DomainZone(),
                    MessageType = NoticeType.Demon,
                    Message = string.Empty
                });
            }
        }

        public static void OnClose(this DemonDungeonComponent self)
        {
            Log.Console("生成恶魔");

            List<Unit> destlist = new List<Unit>();
            List<Unit> sourcelist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.Player);

            ///开始后会根据当前场景的人数随机生成X个 恶魔
            int demonNumber = 1;

            RandomHelper.GetRandListByCount(sourcelist, destlist, demonNumber);

            for (int i = 0; i < destlist.Count; i++)
            {
                destlist[i].GetComponent<NumericComponent>().ApplyValue(NumericType.BattleCamp, CampEnum.CampPlayer_2);
                destlist[i].GetComponent<NumericComponent>().ApplyValue(NumericType.TransformId, 90000017);
                Function_Fight.GetInstance().UnitUpdateProperty_DemonBig(destlist[i], true);
            }

        }

        public static void OnOver(this DemonDungeonComponent self)
        { 
            
        }

        public static void OnKillEvent(this DemonDungeonComponent self, Unit defend, Unit attack)
        {
            //90000017大恶魔   90000018小恶魔   90000019幽灵

            int monsterId = defend.GetComponent<NumericComponent>().GetAsInt(NumericType.TransformId);

            //1被恶魔打败的玩家会变成小恶魔,
            if (defend.Type == UnitType.Player && monsterId == 0)
            {
                defend.SetBornPosition(defend.Position, true);
                defend.GetComponent<HeroDataComponent>().OnRevive();

                defend.GetComponent<NumericComponent>().ApplyValue(NumericType.BattleCamp, CampEnum.CampPlayer_2 );
                defend.GetComponent<NumericComponent>().ApplyValue(NumericType.TransformId, 90000018);
                Function_Fight.GetInstance().UnitUpdateProperty_DemonBig(defend, true);
            }

            //如果大恶魔 / 小恶魔被击败将进入幽灵模式,幽灵模式不能放任何技能，其他玩家也玩不见自己,只能移动.  添加一个隐身buff
            if (defend.Type == UnitType.Player && (monsterId == 90000017 || monsterId == 90000018))
            {
                defend.SetBornPosition(defend.Position, true);
                defend.GetComponent<HeroDataComponent>().OnRevive();
                defend.GetComponent<NumericComponent>().ApplyValue(NumericType.TransformId, 90000019);
                Function_Fight.GetInstance().UnitUpdateProperty_DemonBig(defend, true);
                BuffData buffData_1 = new BuffData();
                buffData_1.SkillId = 67000278;
                buffData_1.BuffId = 90001081;
                defend.GetComponent<BuffManagerComponent>().BuffFactory(buffData_1, defend, null, true);
            }
        }

    }
}
