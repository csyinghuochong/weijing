using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    // 客户端挂在ZoneScene上，服务端挂在Unit上
    public class AIComponent: Entity, IAwake<int>, IDestroy
    {

        public bool IsRetreat;

        public int AIConfigId;
        
        public ETCancellationToken CancellationToken;

        public long Timer;

        public int Current;

        /// <summary>
        /// 索敌范围，范围内追击
        /// </summary>
        public float ActRange;

        /// <summary>
        /// 追击范围，超出则撤退
        /// </summary>
        public float ChaseRange;

        /// <summary>
        /// 巡逻范围
        /// </summary>
        public float PatrolRange;

        /// <summary>
        /// 攻击范围，范围内攻击
        /// </summary>
        public float ActDistance;

        public List<int> AISkillIDList = new List<int>();     //当前所有技能

        //攻击目标
        public Unit LocalDungeonUnit;
        public UnitComponent UnitComponent;
        public PetComponent LocalDungeonUnitPetComponent;

        public long LastChangeTime;
        public long TargetID;

        public C2M_SkillCmd c2M_SkillCmd = new C2M_SkillCmd();

        public List<Vector3> TargetPoint = new List<Vector3>();

        public long LastZhuiJiTime;
        public Vector3 TargetZhuiJi;

        public int SceneTypeEnum;
        public Unit Unit;
        public bool noCheckStatus;            //检测状态  true 就是不检测 待机除外
        public int CheckJianGeTimeNum;          //检测间隔时间次数

        public long AIDelay;
    }
}