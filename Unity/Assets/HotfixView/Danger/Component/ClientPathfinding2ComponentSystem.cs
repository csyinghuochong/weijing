using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ET
{

    public static partial class ClientPathfinding2ComponentSystem
    {
      
        private static void Awake(this ClientPathfinding2Component self)
        {
            self.NavMeshAgent = self.GetParent<Unit>().GetComponent<GameObjectComponent>().GameObject.GetComponent<NavMeshAgent>();
        }


        private static void Destroy(this ClientPathfinding2Component self)
        {
            self.NavMeshAgent = null;
        }

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