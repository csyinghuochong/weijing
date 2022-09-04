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
			SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
			if (sceneId == 1)	//主城
			{
				self.SetMapInfo((int)SceneTypeEnum.MainCityScene, ComHelp.MainCityID(), 0);
				self.NavMeshId = sceneConfig.MapID.ToString();
			}
			else
			{
				self.SetMapInfo((int)SceneTypeEnum.YeWaiScene, sceneConfig.MapID, 0);
				self.NavMeshId = sceneConfig.MapID.ToString();
			}
		}

		public static Vector3 GetCanChongJiPath(this MapComponent self, Vector3 start, Vector3 target)
		{
			using var list = ListComponent<Vector3>.Create();
			Vector3 dir = (target - start).normalized;
			Vector3 tmm = start;

			while (true)
			{
				tmm = tmm + (0.5f * dir);
				Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), start, tmm, list);
				if (list.Count == 0)
				{
					break;
				}
				if (list.Count > 1 && list[list.Count - 1].x != tmm.x && list[list.Count - 1].z != tmm.z)
				{
					break;
				}
				if (Vector3.Distance(tmm, target) <= 0.5f)
				{
					break;
				}
			}

			return tmm;
		}

		public static Vector3 GetCanReachPath(this MapComponent self, Vector3 start, Vector3 target)
		{
			using var list = ListComponent<Vector3>.Create();
			Vector3 dir = (start - target).normalized;

			while (true)
			{
				Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), start, target, list);
				if (list.Count >= 2)
				{
					target = list[list.Count - 1];
					break;
				}
				if (Vector3.Distance(start, target) < 0.2f)
				{
					break;
				}
				target = target + (0.2f * dir);
			}
			return target;
		}

		public static void SearchPath(this MapComponent self, Unit unit, Vector3 target, List<Vector3> result)
		{
			if (self.OldNavMesh)
			{
				Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), unit.Position, target, result);
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
