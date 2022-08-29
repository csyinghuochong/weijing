using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    // 客户端挂在ZoneScene上，服务端挂在Unit上
    public class BehaviourComponent : Entity, IAwake, IDestroy
    {

        public List<string> Behaviours = new List<string>();

        public ETCancellationToken CancellationToken;

        public long Timer;

        public string Current;

        public string NewBehaviour;

        public long TargetID;

        public List<Vector3> PositionList = new List<Vector3>()
        {
            new Vector3(){ x = 11.82f, y = 0.158f, z = -17.62f },
            new Vector3(){ x = 20.98f, y = 0.15f, z = -0.21f },
            new Vector3(){ x = 14.08f, y = 0.15f, z =25.84f },
            new Vector3(){ x =-2.01f, y = 0.16f, z = 21.27f },
            new Vector3(){ x = -12.66f, y = 0.15f, z = -17.05f },
             new Vector3(){ x = -12.66f, y = 0.15f, z = -17.05f },
             new Vector3(){ x = 9.91f, y = 0.15f, z = -13.8f },
        };

        public readonly C2M_SkillCmd c2mSkillCmd = new C2M_SkillCmd();
    }
}
