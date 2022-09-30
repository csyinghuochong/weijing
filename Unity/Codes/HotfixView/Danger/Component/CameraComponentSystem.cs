using System;
using UnityEngine;

namespace ET
{
    [ObjectSystem]
	public class CameraComponentAwakeSystem : AwakeSystem<CameraComponent>
	{
		public override void Awake(CameraComponent self)
		{
			self.Awake();
		}
	}

	[ObjectSystem]
	public class CameraComponentLateUpdateSystem : LateUpdateSystem<CameraComponent>
	{
		public override void LateUpdate(CameraComponent self)
		{
			self.LateUpdate();
		}
	}

	[ObjectSystem]
	public class CameraComponentDestroySystem : DestroySystem<CameraComponent>
	{
		public override void Destroy(CameraComponent self)
		{
			if (self.MainRoleCamera != null)
			{
				GameObject.Destroy(self.MainRoleCamera);
				self.MainRoleCamera = null;
			}
		}
	}

	public static class CameraComponentSystem 
	{
		
		public static void Awake(this CameraComponent self)
		{
			self.MainCamera = GameObject.Find("Global/Main Camera").GetComponent<Camera>();
			self.OffsetPostion = new Vector3(0, 10f, -6f);
			self.CameraMoveType = CameraMoveType.Normal;
			self.MainRoleCamera = null;
			self.MainUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
			
			self.OnEnterScene(self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum ).Coroutine();
		}

		//== SceneTypeEnum.MainCityScene
		public static async ETTask OnEnterScene(this CameraComponent self, int sceneTypeEnum)
		{
			Log.Debug("InitMainRoleCamera : " + sceneTypeEnum);
			if (!UICommonHelper.ShowBigMap((int)sceneTypeEnum) && self.MainRoleCamera != null)
			{
				GameObject.Destroy(self.MainRoleCamera);
				self.MainRoleCamera = null;
			}
			if (UICommonHelper.ShowBigMap((int)sceneTypeEnum) && self.MainRoleCamera == null)
			{
				var path = ABPathHelper.GetUnitPath("Component/MainRoleCamera");
				await ETTask.CompletedTask;
				GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
				//GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
				self.MainRoleCamera = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
			}

			switch (sceneTypeEnum)
			{
				case SceneTypeEnum.PetTianTi:
					self.CameraMoveType = CameraMoveType.PetFuben;
					self.MainCamera.transform.position = AIHelp.FuBenCameraPosition;
					self.MainCamera.transform.localRotation = AIHelp.FuBenCameraRotation;
					break;
				case SceneTypeEnum.PetDungeon:
					self.CameraMoveType = CameraMoveType.PetFuben;
					self.MainCamera.transform.position = AIHelp.FuBenCameraPosition;
					self.MainCamera.transform.localRotation = AIHelp.FuBenCameraRotation;
					break;
				default:
					self.CameraMoveType = CameraMoveType.Normal;
					break;
			}
		}

		//摄像机镜头处理
		public static void SetBuildEnter(this CameraComponent self, Unit npc, Action action)
		{
			self.NpcUnit = npc;
			self.CameraMoveTime = 0f;
			self.CameraMoveType = (npc != null) ? CameraMoveType.NpcStoreEnter : CameraMoveType.Normal;

			self.TargetPosition = npc.Position + npc.Forward * 4f;
			self.TargetPosition.y += 2f;

			Vector3 temp1 = npc.Position + new Vector3(0f, 1f, 0f);
			//Vector3 forward = temp1 - self.TargetPosition;
			
			self.OldCameraPostion = self.MainCamera.transform.position;
			self.OnBuildEnter = action;

			UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<HeroHeadBarComponent>().HeadBar.SetActive(false);
		}


		public static void SetBuildExit(this CameraComponent self)
		{
			Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
			self.CameraMoveTime = 0f;
			self.CameraMoveType = CameraMoveType.NpcStoreExit;
			self.OldCameraPostion = self.MainCamera.transform.localPosition;
			self.TargetPosition = unit.Position + self.OffsetPostion;
		}

		public static void BuildEnterMove(this CameraComponent self)
		{
			if (self.CameraMoveTime > 0.8f && self.OnBuildEnter != null)
			{
				self.OnBuildEnter();
				self.OnBuildEnter = null;
			}
			if (self.CameraMoveTime > 1f)
			{
				return;
			}

			Vector3 chaV3 = self.OldCameraPostion + (self.TargetPosition - self.OldCameraPostion) * self.CameraMoveTime;
			self.MainCamera.transform.localPosition = chaV3;
			self.MainCamera.transform.LookAt(self.NpcUnit.Position + Vector3.up) ;
		}

		public static void BuildExitMove(this CameraComponent self)
		{
			if (self.CameraMoveTime > 1f)
			{
				self.CameraMoveType = CameraMoveType.Normal;
				UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<HeroHeadBarComponent>().HeadBar.SetActive(true);
				return;
			}
			Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
			if (unit == null)
			{
				return;
			}
			Vector3 chaV3 = self.OldCameraPostion + (self.TargetPosition - self.OldCameraPostion) * self.CameraMoveTime;
			self.MainCamera.transform.position = chaV3;
			Vector3 lookPosition = self.NpcUnit.Position + (unit.Position - self.NpcUnit.Position) * self.CameraMoveTime;
			self.MainCamera.transform.LookAt(lookPosition);
		}

		public static void LateUpdate(this CameraComponent self)
		{
			if (self.CameraMoveType == CameraMoveType.PetFuben)
			{
				return;
			}
			if (self.CameraMoveType == CameraMoveType.NpcStoreEnter)
			{
				self.CameraMoveTime += Time.deltaTime * 2f;
				self.BuildEnterMove();
				return;
			}
			if (self.CameraMoveType == CameraMoveType.NpcStoreExit)
			{
				self.CameraMoveTime += Time.deltaTime * 2f;
				self.BuildExitMove();
				return;
			}

			if (self.MainRoleCamera != null)
			{
				self.MainRoleCamera.transform.position = self.MainUnit.Position;
			}
			//if (self.MainCamera.GetComponent<CameraFollow>() != null)
			//{
			//	self.OffsetPostion = self.MainCamera.GetComponent<CameraFollow>().OffsetPostion;
			//}
			self.MainCamera.transform.position = self.MainUnit.Position + self.OffsetPostion;
			self.MainCamera.transform.LookAt(self.MainUnit.Position); 
		}
	}
}
