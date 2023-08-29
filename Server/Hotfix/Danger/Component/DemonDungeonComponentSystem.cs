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
            int demonNumber = 1;

            RandomHelper.GetRandListByCount(sourcelist, destlist, demonNumber);

            for (int i = 0; i < destlist.Count; i++)
            { 
                
            }
        }

        public static void OnOver(this DemonDungeonComponent self)
        { 
            
        }

    }
}
