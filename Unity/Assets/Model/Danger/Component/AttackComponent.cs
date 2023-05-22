using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public  class AttackComponent : Entity, IAwake, IDestroy
    {
        public int SkillId;
        public int ComboSkillId;
        public long LastSkillTime;
        public long ComboStartTime;
        public long CombatEndTime;

        public float AttackDistance;
        public List<int> Weights = new List<int>();
        public List<int> SkillList = new List<int> { };
        public List<int> SkillCDs = new List<int>();
        public readonly C2M_SkillCmd c2mSkillCmd = new C2M_SkillCmd();
        public long CDTime = 800;
        public long CDEndTime;

        public long MoveAttackTime = 0;
        public long MoveAttackId = 0;
        public long Timer;

        public List<string> AnimationList = new List<string>() { "Act_1", "Act_2", "Act_3", "Act_11", "Act_12", "Act_13" };
    }

}
