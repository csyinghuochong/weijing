using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class MoveHelper
    {

        public static M2C_Stop m2C_Stop = new M2C_Stop();   
        public static M2C_PathfindingResult m2CPathfindingResult = new M2C_PathfindingResult();

        // 可以多次调用，多次调用的话会取消上一次的协程
        public static async ETTask<int> FindPathMoveToAsync(this Unit unit, Vector3 target, ETCancellationToken cancellationToken = null, bool yaogan = false)
        {
            float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
            if (speed < 0.01)
            {
                unit.SendStop(-1);
                return -1;
            }

            using var list = ListComponent<Vector3>.Create();
            unit.Domain.GetComponent<MapComponent>().SearchPath(unit, target, list);

            List<Vector3> path = list;
            if (path.Count == 0)
            {
                if (unit.Type == UnitType.Player)
                {
                    Log.Debug($"玩家寻路失败： {unit.DomainZone()} {unit.Id}  x:{target.x}  y:{target.y} z:{target.z}");
                }
                return -1;
            }
            if (path.Count < 2 && yaogan)
            {
                unit.SendStop(-1);
                return -1;
            }
            if (path.Count < 2 && !yaogan)
            {
                list.Clear();
                list.Add(unit.Position + (target - unit.Position) * 0.5f);
                list.Add(target);
                path = list;
            }

            // 广播寻路路径
            M2C_PathfindingResult m2CPathfindingResult = new M2C_PathfindingResult();
            m2CPathfindingResult.Xs.Clear();
            m2CPathfindingResult.Ys.Clear();
            m2CPathfindingResult.Zs.Clear();
            m2CPathfindingResult.Id = unit.Id;
            for (int i = 0; i < list.Count; ++i)
            {
                Vector3 vector3 = list[i];
                m2CPathfindingResult.Xs.Add(vector3.x);
                m2CPathfindingResult.Ys.Add(vector3.y);
                m2CPathfindingResult.Zs.Add(vector3.z);
            }

            if (path.Count < 2)
            {
                Log.Warning("path.Count < 2");
            }
            MessageHelper.Broadcast(unit, m2CPathfindingResult);
            bool ret = await unit.GetComponent<MoveComponent>().MoveToAsync(path, speed, 100, cancellationToken);
            if (ret) // 如果返回false，说明被其它移动取消了，这时候不需要通知客户端stop
            {
                unit.SendStop(0);
                return 0;
            }
            return -1;
        }

        public static void Stop(this Unit unit, int error)
        {
            unit.GetComponent<MoveComponent>().Stop();
            unit.SendStop(error);
        }

        public static void SendStop(this Unit unit, int error)
        {
            MessageHelper.Broadcast(unit, new M2C_Stop()
            {
                Error = error,
                Id = unit.Id, 
                X = unit.Position.x,
                Y = unit.Position.y,
                Z = unit.Position.z,
						
                A = unit.Rotation.x,
                B = unit.Rotation.y,
                C = unit.Rotation.z,
                W = unit.Rotation.w,
            });
        }
    }
}