using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [ObjectSystem]
    public class MapComponentAwakeSystem : AwakeSystem<MapComponent>
    {
		public override void Awake(MapComponent self)
		{
#if SERVER
			self.InitMapInfo();
#endif
		}
    }

    [ObjectSystem]
    public class MapComponentDestroy : DestroySystem<MapComponent>
    {
        public override void Destroy(MapComponent self)
        {
        }
    }


    public static class MapComponentSystem
	{
#if SERVER
        public static void InitMapInfo(this MapComponent self, StartSceneConfig startSceneConfig=null)
		{
            Scene scene = self.DomainScene();
			if (!scene.Name.Contains("Map"))
			{
				return;
			}
			string map = scene.Name.Substring(3, scene.Name.Length - 3);
			int sceneId = int.Parse(map);
			
			if (sceneId == 101)	//主城
			{
				SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(ComHelp.MainCityID());
				self.SetMapInfo((int)SceneTypeEnum.MainCityScene, sceneConfig.MapID, 0);
				self.NavMeshId = sceneConfig.MapID;
            }
			else
			{
				SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
				self.SetMapInfo(sceneConfig.MapType, sceneConfig.MapID, 0);
				self.NavMeshId = sceneConfig.MapID;
			}
		}

		public static Vector3 GetCanChongJiPath(this MapComponent self, Unit unit, Vector3 start, Vector3 target)
		{
           
            using var list = ListComponent<Vector3>.Create();
            Vector3 dir = (target - start).normalized;
            Vector3 tmm = start;
            while (true)
            {
                Vector3 next = tmm + (1f * dir);

                //Game.Scene.GetComponent<RecastPathComponent>().SearchPath(self.NavMeshId, start, next, list, 2);
                self.SearchPath(unit, next, list);

                if (list.Count == 0 || list.Count == 1)
                {
                    break;
                }
				if (Mathf.Abs(list[list.Count - 1].x - next.x) > 0.1f || Mathf.Abs(list[list.Count - 1].z - next.z) > 0.1f)
                {
                    break;
                }
                if (Vector3.Distance(next, target) <= 1f)
                {
                    break;
                }
                tmm = next;
            }

            if (self.SceneId == 6000001 && tmm.x >= 22f)
            {
                Console.WriteLine($"角斗场target3.x >= 22f:  start:{start.x} {start.z}    target:{target.x}  {target.z}");
            }
            return tmm;
        }

		public static Vector3 GetCanReachPath(this MapComponent self, Unit unit, Vector3 start, Vector3 target)
		{
            using var list = ListComponent<Vector3>.Create();
            Vector3 dir = (start - target).normalized;
            while (true)
            {
                //Game.Scene.GetComponent<RecastPathComponent>().SearchPath(self.NavMeshId, start, target, list, 2);
                self.SearchPath( unit, target, list);

                if (list.Count >= 2)
                {
                    target = list[list.Count - 1];
                    break;
                }
                if (Vector3.Distance(start, target) < 0.5f)
                {
                    break;
                }
                target = target + (0.5f * dir);
            }

            if (self.SceneId == 6000001 && target.x >= 22f)
            {
                Console.WriteLine($"角斗场target3.x >= 22f:  start:{start.x} {start.z}    target:{target.x}  {target.z}");
            }
            return target;
        }

		public static void SearchPath(this MapComponent self, Unit unit, Vector3 target, List<Vector3> result)
		{
            //喜从天降XXX
            if (self.NavMeshId == 0 || self.NavMeshId == 2000010)
            {
                return;
            }
			if (ConfigData.OldNavMesh)
			{
				Game.Scene.GetComponent<RecastPathComponent>().SearchPath(self.NavMeshId, unit.Position, target, result, unit.Type);
			}
			else
			{
				unit.GetComponent<PathfindingComponent>().Find(unit.Position, target, result);
			}
		}
#endif

		public static void SetMapInfo(this MapComponent self, int sceneTypeEnum, int mapid, int sonMapid)
		{
			self.SceneTypeEnum = sceneTypeEnum;
			self.SceneId = mapid;
			self.SonSceneId = sonMapid;
		}

		public static void SetSubLevel(this MapComponent self, int sonMapid)
		{
			self.SonSceneId = sonMapid;
		}

		public static int GetMapId(this MapComponent self)
		{
			return self.SceneId;
		}

		public static int GetSubLevelId(this MapComponent self)
		{
			return self.SonSceneId;
		}
	}


}
