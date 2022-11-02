
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [ObjectSystem]
    public class NpcMoveComponentAwakeSystem : AwakeSystem<NpcMoveComponent, string>
    {
        public override void Awake(NpcMoveComponent self, string movepos)
        {
            self.MovePositionList = new List<Vector3>();

            string[] arr1 = movepos.Split(';');
            for (int i = 0; i < arr1.Length; i++)
            { 
                string[] pos = arr1[i].Split(',');

                self.MovePositionList.Add(new Vector3(int.Parse(pos[0])*0.01f, int.Parse(pos[1]) * 0.01f, int.Parse(pos[2]) * 0.01f));
            }
        }
    }

    public static class NpcMoveComponentSystem
    {
        public static void UpdateMoveIndex(this NpcMoveComponent self)
        {
            self.MoveIndex++;
            self.MoveIndex = self.MoveIndex >= self.MovePositionList.Count -1 ? 0 : self.MoveIndex;
        }

        public static Vector3 GetTargetPosition(this NpcMoveComponent self)
        {
            return self.MovePositionList[self.MoveIndex];
        }
       
    }
}
