using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    // 客户端挂在ZoneScene上，服务端挂在Unit上
    public class BehaviourComponent : Entity, IAwake<int>, IDestroy
    {

        public List<KeyValuePair> Behaviours = new List<KeyValuePair>();

        public ETCancellationToken CancellationToken;

        public long Timer;

        public int Current;

        public int NewBehaviour;

        public long TargetID;

        public string MessageValue;

        public Vector3 TargetPosition;

        public RobotConfig RobotConfig;

        public long CreateTime;

        /// <summary>
        /// 攻击范围，范围内攻击
        /// </summary>
        public float ActDistance = 3;

        public readonly C2M_SkillCmd c2mSkillCmd = new C2M_SkillCmd();
    }
}
