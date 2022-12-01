using System;

using UnityEngine;

namespace ET
{
	public class OperaComponent: Entity,IDestroy, IAwake//, IUpdate
    {
        public float LastSendTime;

        public int mapMask;
        public int npcMask;
        public int boxMask;
        public int playerMask;
        public int monsterMask;

        public int NpcId;
        public Vector3 UnitStartPosition;

        public Camera mainCamera;

        public bool ClickMode;
        public bool EditorMode;

        public Unit MainUnit;
    }
}
