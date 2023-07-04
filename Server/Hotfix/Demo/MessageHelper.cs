using MongoDB.Driver.Linq;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel.Channels;

namespace ET
{
    public static class MessageHelper
    {
        public static long messagelenght;
        public static long num;
        public static long timechar;

        public static Dictionary<long, M2C_PathfindingResult> MoveMessageList = new Dictionary<long, M2C_PathfindingResult>();  

        public static void Broadcast(Unit unit, IActorMessage message)
        {
            Dictionary<long, AOIEntity> dict = unit.GetBeSeePlayers();
            UnitComponent unitComponent = unit.GetParent<UnitComponent>();

            (ushort opcode, MemoryStream stream) = MessageSerializeHelper.MessageToStream(message);

            foreach (AOIEntity u in dict.Values)
            {
                if(u.Unit.Id != unit.Id && !unitComponent.AoI.Contains(u.Unit.Id))
                {
                    continue;
                }
                SendToClientNew(u.Unit, message, opcode, stream);

                messagelenght += stream.Length;
                num++;
                if (TimeHelper.ServerNow() >= timechar + 1000)
                {
                    timechar = TimeHelper.ServerNow();
                    Log.Console(TimeHelper.DateTimeNow().ToString() + "messagelenght:" + messagelenght + " num:" + num);
                    messagelenght = 0;
                    num = 0;
                }
            }
        }

        public static async ETTask BroadcastMoveAsync(Scene zoneScene)
        {
            while (true)
            {
                
                await TimerComponent.Instance.WaitAsync(100);

                if (zoneScene.DomainZone() == 3)
                {
                    //Log.Debug("MoveMessageList:   " + MoveMessageList.Count);
                }
                 if (zoneScene.DomainZone() == 3 &&  MoveMessageList.Count > 0)
                {
                    
                    List<Unit> allplayers = UnitHelper.GetUnitList(zoneScene, UnitType.Player);
                    for (int i = 0; i < allplayers.Count; i++)
                    {
                        
                        List<M2C_PathfindingResult> m2C_Pathfindings = new List<M2C_PathfindingResult>();

                        Dictionary<long, AOIEntity> dict = allplayers[i].GetBeSeePlayers();


                        //获取该玩家视野内的移动包
                        foreach (AOIEntity u in dict.Values)
                        {
                            if (u.Unit.Id != allplayers[i].Id &&  MoveMessageList.ContainsKey(u.Unit.Id) )
                            {
                                m2C_Pathfindings.Add(MoveMessageList[u.Unit.Id]);
                            }
                        }

                        //一次最多十个移动包

                        while (m2C_Pathfindings.Count > 0)
                        {
                            M2C_PathfindingListResult message = new M2C_PathfindingListResult();

                            int maxnumber = Math.Min(10, m2C_Pathfindings.Count);
                          
                            message.PathList.AddRange(m2C_Pathfindings.GetRange(0, maxnumber));
                            m2C_Pathfindings.RemoveRange(0,maxnumber);

                            SendToClient(allplayers[i], message);
                        }

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

        public static void SendToClientNew(Unit unit, IActorMessage message, ushort opcode, MemoryStream stream)
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
            SendActorNew(unitGateComponent.GateSessionActorId, message, opcode, stream);
        }

        /// <summary>
        /// 发送协议给Actor
        /// </summary>
        /// <param name="actorId">注册Actor的InstanceId</param>
        /// <param name="message"></param>
        public static void SendActorNew(long actorId, IActorMessage message, ushort opcode, MemoryStream stream)
        {
            ActorMessageSenderComponent.Instance.SendNew(actorId, message, opcode, stream);
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