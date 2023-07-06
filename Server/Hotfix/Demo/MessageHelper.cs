using MongoDB.Bson;
using SharpCompress.Compressors.Xz;
using System;
using System.Collections.Generic;
using System.IO;

namespace ET
{
    public static class MessageHelper
    {
        public static bool LogStatus = true;
        public static long num;
        public static long num222;
        public static long timechar;
        public static long messagelenght;
        public static long messagelenght222;
        public static long playerBroadcast;
        public static long playerBroadcast222;
        //public static Dictionary<string>

        public static void Broadcast(Unit unit, IActorMessage message)
        {
            Dictionary<long, AOIEntity> dict = unit.GetBeSeePlayers();
            UnitComponent unitComponent = unit.GetParent<UnitComponent>();
            (ushort opcode, MemoryStream stream) = MessageSerializeHelper.MessageToStream(message);

            foreach (AOIEntity u in dict.Values)
            {
                //bool isself = false;
                //if (unit.Type == UnitType.Player)
                //{
                //    isself = u.Unit.Id == unit.Id;
                //}
                //else
                //{
                //    isself = u.Unit.Id == unit.Id || u.Unit.Id == unit.MasterId;
                //}
                //if (!isself && !unitComponent.AoI.Contains(u.Unit.Id))
                //{
                //    continue;
                //}
              
                SendToClientNew(u.Unit, message, opcode, stream);
                
                //数据量日志打印
                if (LogStatus)
                {
                    num222++;
                    messagelenght222 += stream.Length;
                }

            }
            playerBroadcast222++;
        }

        //主城移动广播
        public static void BroadcastMainCity(Unit unit, IActorMessage message)
        {
            Dictionary<long, AOIEntity> dict = unit.GetBeSeePlayers();
            UnitComponent unitComponent = unit.GetParent<UnitComponent>();
            (ushort opcode, MemoryStream stream) = MessageSerializeHelper.MessageToStream(message);

            //数据量日志打印
            if (LogStatus)
            {
                playerBroadcast++;
            }

            int playernumber = 0;
            int broadCast = 30;
            foreach (AOIEntity u in dict.Values)
            {
                bool isself = false;

                if (unit.Type == UnitType.Player)
                {
                    isself = u.Unit.Id == unit.Id;
                }
                else
                {
                    isself = u.Unit.Id == unit.Id || u.Unit.Id == unit.MasterId;
                }

                //最多给50个人同步自身移动数据,当主城每秒超过给20000同步数据就开始丢包 不处理其他人的数据
                if (messagelenght > 20000000 || num > 20000)
                {
                    broadCast = 0;
                }

                //最多给50个人同步自身移动数据
                if (isself  || playernumber < broadCast)
                {
                    playernumber++;
                    SendToClientNew(u.Unit, message, opcode, stream);

                    //数据量日志打印
                    if (LogStatus)
                    {
                        num++;
                        messagelenght += stream.Length;

                        if (TimeHelper.ServerNow() >= timechar + 1000)
                        {
                            timechar = TimeHelper.ServerNow();
                            Log.Console(TimeHelper.DateTimeNow().ToString() + " 总数据:" + (messagelenght + messagelenght222).ToString() + " 移动数据:" + messagelenght + " 其他数据:" + messagelenght222 + " 广播人数:" + num + " 其他广播" + num222 + " 移动源数:" + playerBroadcast + " 其他源数:" + playerBroadcast222);
                            messagelenght = 0;
                            num = 0;
                            num222 = 0;
                            playerBroadcast = 0;
                            messagelenght222 = 0;
                            playerBroadcast222 = 0;
                        }
                    }
                } 
            }
        }



        public static void BroadcastBuff(Unit unit, IActorMessage message, SkillBuffConfig buffConfig, int sceneType)
        {
            //主城只给自己广播
            if (unit.Type == UnitType.Player &&  sceneType == SceneTypeEnum.MainCityScene)
            {
                SendToClient(unit, message);
                return;
            }

            ///0 全部 1 队友
            Dictionary<long, AOIEntity> dict = unit.GetBeSeePlayers();
            (ushort opcode, MemoryStream stream) = MessageSerializeHelper.MessageToStream(message);

            foreach (AOIEntity u in dict.Values)
            {
                bool broadcast = unit.Id == u.Unit.Id;

                if (!broadcast)
                {
                    if (buffConfig.BroadcastType == 0)
                    {
                        broadcast = true;
                    }
                    if (buffConfig.BroadcastType == 1)  //队友
                    {
                        broadcast = unit.IsSameTeam(u.Unit);
                    }
                }

                if (!broadcast)
                {
                    continue;
                }

                SendToClientNew(u.Unit, message, opcode, stream);
                
                num++;
                messagelenght += stream.Length;
            }
        }


        /// <summary>
        /// 只广播自己的
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="message"></param>
        public static void BroadcastMove(Unit unit, MapComponent mapComponent, M2C_PathfindingResult message)
        {
            //这里是否可以增加宠物？
            if (unit.Type == UnitType.Player)
            {
                Dictionary<long, M2C_PathfindingResult> MoveMessageList = mapComponent.MoveMessageList;
                if (MoveMessageList.ContainsKey(unit.Id))
                {
                    MoveMessageList[unit.Id] = message;
                }
                else
                {
                    MoveMessageList.Add(unit.Id, message);
                }

                //给自己发送移动数据,实时同步
                SendToClientMove(unit, message);
            }
            else
            {
                //非怪物正常发送移动数据
                Dictionary<long, AOIEntity> dict = unit.GetBeSeePlayers();
                UnitComponent unitComponent = unit.GetParent<UnitComponent>();
                (ushort opcode, MemoryStream stream) = MessageSerializeHelper.MessageToStream(message);

                foreach (AOIEntity u in dict.Values)
                {
                    SendToClientNew(u.Unit, message, opcode, stream);
                }
            }
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

            num++;
            messagelenght += message.ToBson().Length;
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