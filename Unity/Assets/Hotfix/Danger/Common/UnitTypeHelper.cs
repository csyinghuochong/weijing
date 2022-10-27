using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class UnitTypeHelper
    {

        public static int GetMonsterType(this Unit self)
        {
            return MonsterConfigCategory.Instance.Get(self.ConfigId).MonsterType;
        }

        public static int GetMonsterSonType(this Unit self)
        {
            return MonsterConfigCategory.Instance.Get(self.ConfigId).MonsterSonType;
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
            return self.Type == UnitType.Monster && MonsterConfigCategory.Instance.Get(self.ConfigId).MonsterSonType == 55;
        }
    }
}
