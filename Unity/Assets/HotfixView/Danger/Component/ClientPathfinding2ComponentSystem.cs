using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ET
{

    public class ClientPathfinding2ComponentAwake : AwakeSystem<ClientPathfinding2Component>
    {
        public override void Awake(ClientPathfinding2Component self)
        {
            GameObject gameObject = self.GetParent<Unit>().GetComponent<GameObjectComponent>().GameObject;
            if (gameObject.transform.Find("NavMeshAgent") == null)
            {
                GameObject navemeshagent = new GameObject("NavMeshAgent");
                navemeshagent.AddComponent<NavMeshAgent>();   
                UICommonHelper.SetParent(navemeshagent, gameObject);
            }
            self.NavMeshAgent = gameObject.transform.Find("NavMeshAgent").GetComponent<NavMeshAgent>();
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

        public static void OnShangMa(this ClientPathfinding2Component self, GameObject go, int horseId)
        {

        }

        public static void OnXiaMa(this ClientPathfinding2Component self, GameObject go, int horseId)
        {
        }


        public static void Find(this ClientPathfinding2Component self, Vector3 target, List<Vector3> result)
        {
            NavMeshPath path = new NavMeshPath();
            self.NavMeshAgent.transform.localPosition = Vector3.zero;
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