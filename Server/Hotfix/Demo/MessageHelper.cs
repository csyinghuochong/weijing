using MongoDB.Driver.Linq;
using System.Collections.Generic;
using System.ServiceModel.Channels;

namespace ET
{
    public static class MessageHelper
    {
         
        public static Dictionary<long, M2C_PathfindingResult> MoveMessageList = new Dictionary<long, M2C_PathfindingResult>();  

        public static void Broadcast(Unit unit, IActorMessage message)
        {
            Dictionary<long, AOIEntity> dict = unit.GetBeSeePlayers();
            foreach (AOIEntity u in dict.Values)
            {
                SendToClient(u.Unit, message);
            }
        }

        public static async ETTask BroadcastMoveAsync(Scene zoneScene)
        {
            while (true)
            {
                await TimerComponent.Instance.WaitAsync(100);

                if (zoneScene.DomainZone() == 3)
                {
                    Log.Debug("MoveMessageList:   " + MoveMessageList.Count);
                }
                 if (zoneScene.DomainZone() == 3 &&  MoveMessageList.Count > 0)
                {
                    M2C_PathfindingListResult message = new M2C_PathfindingListResult();

                    List<Unit> allplayers = UnitHelper.GetUnitList(zoneScene, UnitType.Player);
                    for (int i = 0; i < allplayers.Count; i++)
                    {
                        Dictionary<long, AOIEntity> dict = allplayers[i].GetBeSeePlayers();

                        foreach (AOIEntity u in dict.Values)
                        {
                            if (u.Unit.Id != allplayers[i].Id &&  MoveMessageList.ContainsKey(u.Unit.Id) )
                            {
                                message.PathList.Add(MoveMessageList[u.Unit.Id]);
                            }
                        }

                        SendToClient(allplayers[i], message);
                    }

                    MoveMessageList.Clear();
                }
            }
        }

        public static void BroadcastMove(Unit unit, M2C_PathfindingResult message)
        {
            if (MoveMessageList.ContainsKey(unit.Id))
            {
                MoveMessageList[unit.Id] = message; 
            }
            else
            {
                MoveMessageList.Add(unit.Id, message);
            }

            SendToClientMove(unit, message);
        }

        /// <summary>
        /// 发送协议给Actor
        /// </summary>
        /// <param name="actorId">注册Actor的InstanceId</param>
        /// <param name="message"></param>
        public static void SendActorMove(long actorId, IActorMessage message)
        {
            ActorMessageSenderComponent.Instance.Send(actorId, message);
        }

        public static void SendToClientMove(Unit unit, IActorMessage message)
        {
            if (unit.IsDisposed)
            {
                return;
            }
            UnitGateComponent unitGateComponent = unit.GetComponent<UnitGateComponent>();
            if (unitGateComponent.PlayerState != PlayerState.Game)
            {
                return;
            }
            SendActorMove(unitGateComponent.GateSessionActorId, message);
        }


        public static void SendToClient(List<Unit> units, IActorMessage message)
        {
            for (int i = 0; i < units.Count; i++)
            {
                SendToClient(units[i], message);
            }
        }

        public static void SendToClient(Unit unit, IActorMessage message)
        {
            if (unit.IsDisposed)
            {
                return;
            }
            UnitGateComponent unitGateComponent = unit.GetComponent<UnitGateComponent>();
            if (unitGateComponent.PlayerState != PlayerState.Game)
            {
                return;
            }
            SendActor(unitGateComponent.GateSessionActorId, message);
        }

        /// <summary>
        /// 发送协议给ActorLocation
        /// </summary>
        /// <param name="id">注册Actor的Id</param>
        /// <param name="message"></param>
        public static void SendToLocationActor(long id, IActorLocationMessage message)
        {
            ActorLocationSenderComponent.Instance.Send(id, message);
        }
        
        /// <summary>
        /// 发送协议给Actor
        /// </summary>
        /// <param name="actorId">注册Actor的InstanceId</param>
        /// <param name="message"></param>
        public static void SendActor(long actorId, IActorMessage message)
        {
            ActorMessageSenderComponent.Instance.Send(actorId, message);
        }
        
        /// <summary>
        /// 发送RPC协议给Actor
        /// </summary>
        /// <param name="actorId">注册Actor的InstanceId</param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static async ETTask<IActorResponse> CallActor(long actorId, IActorRequest message)
        {
            return await ActorMessageSenderComponent.Instance.Call(actorId, message);
        }
        
        /// <summary>
        /// 发送RPC协议给ActorLocation
        /// </summary>
        /// <param name="id">注册Actor的Id</param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static async ETTask<IActorResponse> CallLocationActor(long id, IActorLocationRequest message)
        {
            return await ActorLocationSenderComponent.Instance.Call(id, message);
        }
    }
}