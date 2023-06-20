using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    public  class RoleBullet2Componnet : Entity, IAwake, IDestroy
    {
        public long BeginTime;
        public long PassTime;
        public long DelayTime;
        public long BuffEndTime;
        public float StartAngle;
        public float Angle;
        public float Radius;
        public float DamageRange;
        public long Timer;
        public long MasterId;
        public BuffState BuffState;
        public Unit TheUnitBelongto;
        public long InterValTimeSum;
        public Vector3 StartPosition;
        public SkillHandler SkillHandler;
        public List<long> HurtIds = new List<long>();
    }
}
