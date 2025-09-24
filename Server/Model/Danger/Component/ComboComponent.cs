
using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    public  class ComboComponent : Entity, IAwake, IDestroy
    {
        //连击用到的数据
        public int EquipType;
        public int SkillId;
        public int ComboSkillId;
        public long LastSkillTime;
        public long ComboStartTime;
        public long CombatEndTime;

        public List<int> Weights = new List<int>();
        public List<int> SkillList = new List<int> { };
        public List<int> SkillCDs = new List<int>();

        public long CDTime = 800;
        public long CDEndTime;

        //连击用到的数据
    }
}
