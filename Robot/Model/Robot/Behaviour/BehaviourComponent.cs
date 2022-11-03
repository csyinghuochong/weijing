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

        public readonly C2M_SkillCmd c2mSkillCmd = new C2M_SkillCmd();

        public static List<Vector3> StrollPositionList = new List<Vector3>()
        {
            new Vector3(){ x = -13.30f, y = -0.23f, z = 42.28f },
            new Vector3(){ x = -45.79f, y = -0.84f, z = 34.22f },
            new Vector3(){ x = -51.8f, y = -2.44f, z =-33.37f },
            new Vector3(){ x =-4.48f, y = -7.69f, z = -50.94f },
            new Vector3(){ x = 52.29f, y = -4.24f, z = -23.01f },
        };
    }
}
