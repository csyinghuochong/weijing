using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    // 路径位置状态枚举
    public enum PathPosition
    {
        Behind,     // 在路径后方
        Middle,      // 在路径中间
        Ahead        // 在路径前方
    }


    public class MoveComponent: Entity, IAwake, IDestroy
    {
        public Vector3 PreTarget
        {
            get
            {
                return this.Targets[this.N - 1];
            }
        }

        public Vector3 NextTarget
        {
            get
            {
                return this.Targets[this.N];
            }
        }

        // 开启移动协程的时间
        public long BeginTime;

        // 每个点的开始时间
        public long StartTime { get; set; }

        // 开启移动协程的Unit的位置
        public Vector3 StartPos;

        public Vector3 RealPos
        {
            get
            {
                return this.Targets[0];
            }
        }

        private long needTime;

        public long NeedTime
        {
            get
            {
                return this.needTime;
            }
            set
            {
                this.needTime = value;
            }
        }

        public long MoveTimer;

        public float Speed; // m/s

        public Action<bool> Callback;

        public List<Vector3> Targets = new List<Vector3>();

        public Vector3 FinalTarget
        {
            get
            {
                return this.Targets[this.Targets.Count - 1];
            }
        }

        public int N;

        public int TurnTime;

        public bool IsTurnHorizontal;

        public Quaternion From;

        public Quaternion To;

       
        /// <summary>
        /// 等待继续移动
        /// </summary>
        public bool WaitMove;   

        /// <summary>
        /// 是否支持继续移动
        /// </summary>
        public bool WaitMode;
        public Vector3 TargetPosition;

        public float C2SDistance;
        public long LastRecvTime;
        public int SceneTypeEnum;

        public List<int> UploadSkill = new List<int>(); 
    }
}