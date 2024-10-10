using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class MoveHelper
    {
        public static C2M_PathfindingRequest c2M_PathfindingRequest = new C2M_PathfindingRequest();


        public static int IfCanMove(this Unit unit)
        {
            StateComponent stateComponent = unit.GetComponent<StateComponent>();
            int errorCode = stateComponent.CanMove();
            if (ErrorCode.ERR_Success != errorCode)
            {
                stateComponent.CheckSilence();
            }

            return errorCode;
        }

        /// <summary>
        /// 主角移动
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="targetPos"></param>
        /// <param name="yangan"></param>
        /// <returns></returns>
        public static async ETTask<int> MoveByYaoGan(this Unit unit, Vector3 targetPos, int direction, float distance,  ETCancellationToken cancellationToken = null)
        {
            MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
            moveComponent.MoveWait = false;
            moveComponent.YaoganMove = true;
            C2M_PathfindingRequest msg = c2M_PathfindingRequest;
          
            msg.YaoGan = true;
            msg.UnitId = unit.Id;
            msg.Direction = direction;
            msg.Distance = distance;
            msg.X = targetPos.x;
            msg.Y = targetPos.y;
            msg.Z = targetPos.z;
            unit.ZoneScene().GetComponent<SessionComponent>().Session.Send(msg);

            ObjectWait objectWait = unit.GetComponent<ObjectWait>();

            // 要取消上一次的移动协程
            objectWait.Notify(new WaitType.Wait_UnitStop() { Error = WaitTypeError.Cancel });

            // 一直等到unit发送stop
            WaitType.Wait_UnitStop waitUnitStop = await objectWait.Wait<WaitType.Wait_UnitStop>(cancellationToken);
            return waitUnitStop.Error;
        }


        // 可以多次调用，多次调用的话会取消上一次的协程
        public static async ETTask<int> MoveResultToAsync(this Unit unit, List<Vector3> pathlist, ETCancellationToken cancellationToken = null)
        {
            C2M_PathfindingResult msg = new C2M_PathfindingResult();
            for (int i = 0; i < pathlist.Count; i++ )
            {
                msg.Xs.Add(pathlist[i].x);
                msg.Ys.Add(pathlist[i].y);
                msg.Zs.Add(pathlist[i].z);
            }
            unit.ZoneScene().GetComponent<SessionComponent>().Session.Send(msg);

            ObjectWait objectWait = unit.GetComponent<ObjectWait>();

            // 要取消上一次的移动协程
            objectWait.Notify(new WaitType.Wait_UnitStop() { Error = WaitTypeError.Cancel });

            // 一直等到unit发送stop
            WaitType.Wait_UnitStop waitUnitStop = await objectWait.Wait<WaitType.Wait_UnitStop>(cancellationToken);
            return waitUnitStop.Error;
        }


        /// <summary>
        /// 主角移动
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="targetPos"></param>
        /// <param name="yangan"></param>
        /// <returns></returns>
        public static async ETTask<int> MoveToAsync2(this Unit unit, Vector3 targetPos,bool yangan=true, ETCancellationToken cancellationToken = null, int direction = 0)
        {
            int errorCode = MoveHelper.IfCanMove(unit);
            if (errorCode != ErrorCode.ERR_Success)
            {
                HintHelp.GetInstance().ShowHintError(errorCode, unit.ZoneScene());
                return errorCode;
            }

            MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
            moveComponent.MoveWait = false;
            moveComponent.YaoganMove = yangan;
            C2M_PathfindingRequest msg = c2M_PathfindingRequest;
            msg.X = targetPos.x;
            msg.Y = targetPos.y;
            msg.Z = targetPos.z;    
            msg.YaoGan = yangan;
            msg.UnitId = direction;
            msg.Direction = 0;
            msg.Distance = 0;
            unit.ZoneScene().GetComponent<SessionComponent>().Session.Send(msg);

            ObjectWait objectWait = unit.GetComponent<ObjectWait>();

            // 要取消上一次的移动协程
            objectWait.Notify(new WaitType.Wait_UnitStop() { Error = WaitTypeError.Cancel });

            // 一直等到unit发送stop
            WaitType.Wait_UnitStop waitUnitStop = await objectWait.Wait<WaitType.Wait_UnitStop>(cancellationToken);
            return waitUnitStop.Error;
        }


        /// <summary>
        /// 机器人移动
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="targetPos"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        // 可以多次调用，多次调用的话会取消上一次的协程
        public static async ETTask<int> MoveToAsync(this Unit unit, Vector3 targetPos, ETCancellationToken cancellationToken = null)
        {
            C2M_PathfindingRequest msg = c2M_PathfindingRequest;
            msg.X = targetPos.x;
            msg.Y = targetPos.y;
            msg.Z = targetPos.z;
            msg.Distance = 0;
            msg.Direction = 0;
            unit.ZoneScene().GetComponent<SessionComponent>().Session.Send(msg);

            ObjectWait objectWait = unit.GetComponent<ObjectWait>();
            
            // 要取消上一次的移动协程
            objectWait.Notify(new WaitType.Wait_UnitStop() { Error = WaitTypeError.Cancel });
            
            // 一直等到unit发送stop
            WaitType.Wait_UnitStop waitUnitStop = await objectWait.Wait<WaitType.Wait_UnitStop>(cancellationToken);
            return waitUnitStop.Error;
        }
        
        public static async ETTask<bool> MoveToAsync(this Unit unit, List<Vector3> path)
        {
            float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
            MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
            bool ret = await moveComponent.MoveToAsync(path, speed);
            return ret;
        }

        public static void Stop(this Unit unit)
        {
            unit.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
        }

        public static void StopResult(this Unit unit)
        {
            MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
            moveComponent.Stop();
            C2M_StopResult result = new C2M_StopResult();
            result.X = unit.Position.x;
            result.Y = unit.Position.y;
            result.Z = unit.Position.z;
            unit.ZoneScene().GetComponent<SessionComponent>().Session.Send(result);
        }

    }
}