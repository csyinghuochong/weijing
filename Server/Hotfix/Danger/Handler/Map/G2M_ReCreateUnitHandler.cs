//using System;
//using UnityEngine;


//namespace ET
//{

//    [ActorMessageHandler]
//    public class G2M_ReCreateUnitHandler : AMActorRpcHandler<Scene, G2M_ReCreateUnit, M2G_ReCreateUnit>
//    {

//        protected override async ETTask Run(Scene scene, G2M_ReCreateUnit request, M2G_ReCreateUnit response, Action reply)
//        {
//            Entity unit = null;
//            foreach ((long id, Entity value) in scene.GetComponent<UnitComponent>().Children)
//            {
//                if (value.GetComponent<UnitInfoComponent>().Type != UnitType.Player)
//                {
//                    continue;
//                }
//                if (value.GetComponent<UserInfoComponent>().UserInfo.UserId == request.UserID)
//                {
//                    unit = value;
//                    break;
//                }
//            }

//            //踢下线
//            if (unit != null)
//            {
//                if (request.GateSessionId == 0)
//                {
//                    unit.GetComponent<DBSaveComponent>().OnDisconnect();
//                }
//                else
//                {
//                    if (unit.GetComponent<UnitGateComponent>() != null)
//                    {
//                        unit.RemoveComponent<UnitGateComponent>();
//                        Log.Info("unit.GetComponent<UnitGateComponent>() != null:" + unit.GetComponent<UnitInfoComponent>().PlayerName);
//                    }
//                    unit.AddComponent<UnitGateComponent, long>(request.GateSessionId);
//                    unit.GetComponent<DBSaveComponent>().OnRelogin().Coroutine();
//                    response.UnitId = unit.Id;
//                }

//            }
//            else
//            {
//                Log.Info("G2M_ReCreateUnit unit == null: " + scene.Name);
//                response.Error = ErrorCore.ERR_Error;
//            }
           
//            reply();
//            await ETTask.CompletedTask;
//        }
//    }
//}
