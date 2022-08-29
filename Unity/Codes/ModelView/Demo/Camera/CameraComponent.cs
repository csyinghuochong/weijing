using System;
using UnityEngine;

namespace ET
{
	public enum CameraMoveType
	{
		Normal = 0,
		NpcStoreEnter = 1,
		NpcStoreExit = 2,
		PetRank = 3,
	}

	public class CameraComponent : Entity, IAwake, ILateUpdate, IDestroy
	{
		// 战斗摄像机
		public Camera MainCamera;

		//渲染摄像机
		public GameObject MainRoleCamera;

		public Vector3 OffsetPostion;

		//0正常 1商店npc
		public Unit NpcUnit;

		public CameraMoveType CameraMoveType;

		public float CameraMoveTime;

		public Vector3 TargetPosition;
		public Vector3 OldCameraPostion;

		public Action OnBuildEnter;
		public Unit MainUnit;
	}
}
