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
			
			if (sceneId == 1)	//主城
			{
				SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(ComHelp.MainCityID());
				self.SetMapInfo((int)SceneTypeEnum.MainCityScene, sceneConfig.MapID, 0);
				self.NavMeshId = sceneConfig.MapID.ToString();
			}
			else
			{
				SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
				self.SetMapInfo(sceneConfig.MapType, sceneConfig.MapID, 0);
				self.NavMeshId = sceneConfig.MapID.ToString();
			}
		}

		public static Vector3 GetCanChongJiPath(this MapComponent self, Vector3 start, Vector3 target)
		{
			using var list = ListComponent<Vector3>.Create();
			Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), start, target, list, 2);
			Vector3 dir = (target - start);
			float ange_1 = Mathf.Rad2Deg(Mathf.Atan2(dir.x, dir.z));

			if (list.Count > 2)
			{
				for (int i = 1; i < list.Count; i++)
				{ 
					Vector3 dirteamp = (list[i] - start);
					float ange_2 = Mathf.Rad2Deg(Mathf.Atan2(dirteamp.x, dirteamp.z));
					if (Mathf.Abs(ange_1 - ange_2) >= 10)
					{
						return list[i];
					}
				}

				return list[list.Count - 1];
			}
			else
			{
				return start;
			}

			//old
			//using var list = ListComponent<Vector3>.Create();
			//Vector3 dir = (target - start).normalized;
			//Vector3 tmm = start;
			//while (true)
			//{
			//	tmm = tmm + (0.5f * dir);
			//	Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), start, tmm, list, 2);
			//	if (list.Count == 0)
			//	{
			//		break;
			//	}
			//	if (list.Count > 1 && list[list.Count - 1].x != tmm.x && list[list.Count - 1].z != tmm.z)
			//	{
			//		break;
			//	}
			//	if (Vector3.Distance(tmm, target) <= 0.5f)
			//	{
			//		break;
			//	}
			//}
			//return tmm;
		}

		public static Vector3 GetCanReachPath(this MapComponent self, Vector3 start, Vector3 target)
		{
			using var list = ListComponent<Vector3>.Create();
			Vector3 dir = (start - target).normalized;
            while (true)
            {
                Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), start, target, list, 2);
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
            return target;
		}

		public static void SearchPath(this MapComponent self, Unit unit, Vector3 target, List<Vector3> result)
		{
			if (self.OldNavMesh)
			{
				Game.Scene.GetComponent<RecastPathComponent>().SearchPath(int.Parse(self.NavMeshId), unit.Position, target, result, unit.Type);
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
