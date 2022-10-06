using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    // 客户端挂在ZoneScene上，服务端挂在Unit上
    public class AIComponent: Entity, IAwake<int>, IDestroy
    {
        public bool IsBoss;

        public bool IsRetreat;

        public int AIConfigId;
        
        public ETCancellationToken CancellationToken;

        public long Timer;

        public int Current;

        /// <summary>
        /// 攻击间隔
        /// </summary>
        public long ActInterValTime;

        /// <summary>
        /// 攻击范围
        /// </summary>
        public double ActRange;

        /// <summary>
        /// 
        /// </summary>
        public double ChaseRange;

        public double PatrolRange;

        public List<int> AISkillIDList = new List<int>();     //当前所有技能

        //攻击距离
        public double ActDistance;

        //技能僵直时间
        public long RigidityTime;

        //攻击目标
        public long TargetID;

        public long LastBeAttack = 0;
        public long BeAttackTime = 0;

        public Vector3 BornPostion;

        public bool StopAI;

        public List<long> BeAttackList = new List<long>();

        public C2M_SkillCmd c2M_SkillCmd = new C2M_SkillCmd();
    }
}