using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ET
{

    public class ClientPathfinding2ComponentAwake : AwakeSystem<ClientPathfinding2Component>
    {
        public override void Awake(ClientPathfinding2Component self)
        {
            self.NavMeshAgent = self.GetParent<Unit>().GetComponent<GameObjectComponent>().GameObject.GetComponent<NavMeshAgent>();
            self.NavMeshAgent.enabled = false;
            self.NavMeshAgent.enabled = true;
        }
    }

    public class ClientPathfinding2ComponentDestroy : DestroySystem<ClientPathfinding2Component>
    {
        public override void Destroy(ClientPathfinding2Component self)
        {
            self.NavMeshAgent = null;
        }
    }

    public static partial class ClientPathfinding2ComponentSystem
    {
        public static void Find(this ClientPathfinding2Component self, Vector3 target, List<Vector3> result)
        {
            NavMeshPath path = new NavMeshPath();

            if (self.NavMeshAgent.CalculatePath(target, path))
            {
                for (int i = 0; i < path.corners.Length; i++)
                {
                    result.Add(path.corners[i]);
                }
            }
        }
    }
}