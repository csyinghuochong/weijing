

using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class NpcMoveComponent : Entity, IAwake<string>
    {

        public float IdleTime = 3f;
        public int MoveIndex = 0;
        public List<Vector3> MovePositionList;

        public ETCancellationToken CancellationToken;
    }
}
