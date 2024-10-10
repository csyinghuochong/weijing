using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class MoveHelper
    {

        // 可以多次调用，多次调用的话会取消上一次的协程
        public static async ETTask<int> FindPathMoveToAsync(this Unit unit, Vector3 target, ETCancellationToken cancellationToken = null, bool yaogan = false)
        {
            ///以防止怪物再引力波的作用下不移动
            if (unit.GetComponent<StateComponent>().ServerCanMove()!= ErrorCode.ERR_Success)
            {
                return -1;
            }

            MapComponent mapComponent = unit.Domain.GetComponent<MapComponent>();
            using (ListComponent<Vector3> list = ListComponent<Vector3>.Create())
            {
                mapComponent.SearchPath(unit, target, list);
                List<Vector3> path = list;
                if (path.Count == 0)
                {
                    //if (unit.Type == UnitType.Player)
                    //{
                    //    Log.Debug($"玩家寻路失败： {unit.DomainZone()} {unit.Id} mapid: {mapComponent.SceneId}  x:{target.x}  y:{target.y} z:{target.z}");
                    //}
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
                if (path.Count >= 1000)
                {
                    unit.SendStop(-1);
                    return -1;
                }

                // 广播寻路路径
                M2C_PathfindingRequest m2CPathfindingResult = new M2C_PathfindingRequest();
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
                    LogHelper.LogWarning("path.Count < 2");
                }

                if (mapComponent.SceneTypeEnum == SceneTypeEnum.MainCityScene)
                {
                    MessageHelper.BroadcastMainCity(unit, m2CPathfindingResult);
                }
                else
                {
                    MessageHelper.Broadcast(unit, m2CPathfindingResult);
                }

                float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
                MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
                bool ret = await moveComponent.MoveToAsync(path, speed, 0, cancellationToken);
                if (ret) // 如果返回false，说明被其它移动取消了，这时候不需要通知客户端stop
                {
                    unit.SendStop(0);
                    return 0;
                }
                return -1;
            }
        }


        public static async ETTask FindPathResultToAsync(this Unit unit, List<Vector3> positonsss)
        {
            float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
            bool ret = await unit.GetComponent<MoveComponent>().MoveToAsync(positonsss, speed);
            if (ret) // 如果返回false，说明被其它移动取消了，这时候不需要通知客户端stop
            {
                //Console.WriteLine($"PathResultToAsync  unit.SendStop(0):  {TimeHelper.ServerNow()}");
                //unit.SendStop(0);
            }
            await ETTask.CompletedTask;
        }

        // 可以多次调用，多次调用的话会取消上一次的协程
        public static async ETTask<int> BulletMoveToAsync(this Unit unit, Vector3 target)
        {
            float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
            if (speed < 0.01)
            {
                unit.SendStop(-1);
                return -1;
            }

            using var list = ListComponent<Vector3>.Create();
            list.Clear();
            list.Add(unit.Position);
            list.Add(unit.Position + (target - unit.Position) * 0.5f);
            list.Add(target);

            // 广播寻路路径
            Vector3 lastvector = new Vector3(-100f, -100f, -100f);
            M2C_PathfindingRequest m2CPathfindingResult = new M2C_PathfindingRequest();
            m2CPathfindingResult.Id = unit.Id;
            for (int i = 0; i < list.Count; ++i)
            {
                Vector3 vector3 = list[i];
                m2CPathfindingResult.Xs.Add(vector3.x);
                m2CPathfindingResult.Ys.Add(vector3.y);
                m2CPathfindingResult.Zs.Add(vector3.z);
            }

            MessageHelper.Broadcast(unit, m2CPathfindingResult);
            MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
            bool ret = await moveComponent.MoveToAsync(list, speed, 0, null);
            if (ret) // 如果返回false，说明被其它移动取消了，这时候不需要通知客户端stop
            {
                unit.SendStop(0);
                return 0;
            }
            return -1;
        }

        public static void StopResult(this Unit unit, Vector3 position, int error)
        {
            unit.GetComponent<MoveComponent>().Stop();
            unit.Position = position;
            M2C_StopResult m2CStop = new  M2C_StopResult();
            m2CStop.Error = error;
            m2CStop.Id = unit.Id;
            m2CStop.X = position.x;
            m2CStop.Y = position.y;
            m2CStop.Z = position.z;

            m2CStop.A = unit.Rotation.x;
            m2CStop.B = unit.Rotation.y;
            m2CStop.C = unit.Rotation.z;
            m2CStop.W = unit.Rotation.w;
            MessageHelper.Broadcast(unit, m2CStop);
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