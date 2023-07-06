using System.Collections.Generic;
using System.Text;

namespace ET
{
    public static class OpcodeHelper
    {

        public static bool ShowMessage = true;

        public static long LastLogTime = 0;

        public static Dictionary<long, List<long>> OuterMessageLength = new Dictionary<long, List<long>>();

        public static Dictionary<long, List<long>> InnerMessageLength = new Dictionary<long, List<long>>();


        private static readonly HashSet<ushort> ignoreDebugLogMessageSet = new HashSet<ushort>
        {
            OuterOpcode.C2G_Ping,
            OuterOpcode.G2C_Ping,
        };

        private static bool IsNeedLogMessage(ushort opcode)
        {
            if (ignoreDebugLogMessageSet.Contains(opcode))
            {
                return false;
            }

            return true;
        }

        public static bool IsOuterMessage(ushort opcode)
        {
            return opcode < OpcodeRangeDefine.OuterMaxOpcode;
        }

        public static bool IsInnerMessage(ushort opcode)
        {
            return opcode >= OpcodeRangeDefine.InnerMinOpcode;
        }

        public static void OnMessageLength(int zone, ushort opcode, object message)
        {
#if SERVER
            long serverTime = TimeHelper.ServerNow();
            if (serverTime - LastLogTime >= 5000)
            {
                StringBuilder sb = new StringBuilder();
                long totalNumber = 0;
                long totalLength = 0;
                foreach (var item in OuterMessageLength)
                {
                    totalNumber += item.Value[0];
                    totalLength += item.Value[1];
        
                    sb.AppendLine($"\tID: {item.Key}:  \tNumber:  {item.Value[0]}  \tLength:  {item.Value[1]}");
                }
                foreach (var item in InnerMessageLength)
                {
                    totalNumber += item.Value[0];
                    totalLength += item.Value[1];
                    sb.AppendLine($"\tID: {item.Key}:  \tNumber:  {item.Value[0]}  \tLength:  {item.Value[1]}");
                }

                Log.Console($"\t当前消息:  \tNumber:  {totalNumber}  \tLength:  {totalLength} \n" +  sb.ToString());
                OuterMessageLength.Clear();
                InnerMessageLength.Clear();

                LastLogTime = serverTime;
            }

            if (ShowMessage)
            {
                if (!OuterMessageLength.ContainsKey(opcode))
                {
                    OuterMessageLength.Add(opcode, new List<long>() {0,0});
                }
                OuterMessageLength[opcode][0] += 1;
                OuterMessageLength[opcode][1] += MongoHelper.ToBson(message).Length;
            }

            if (ShowMessage && zone == -1) //内网
            {
                if (!InnerMessageLength.ContainsKey(opcode))
                {
                    InnerMessageLength.Add(opcode, new List<long>() { 0, 0 });
                }
                InnerMessageLength[opcode][0] += 1;
                InnerMessageLength[opcode][1] += MongoHelper.ToBson(message).Length;
            }
#endif
        }

        public static void LogMsg(int zone, ushort opcode, object message)
        {

            OnMessageLength(zone, opcode, message);

            if (Game.Options.Develop == 0)
            {
                return;
            }
            
            if (!IsNeedLogMessage(opcode))
            {
                return;
            }
            
            Log.ILog.Debug("zone: {0} {1}", zone, message);
        }

        public static void LogMsg(ushort opcode, long actorId, object message)
        {
            OnMessageLength(-1, opcode, message);

            if (Game.Options.Develop == 0)
            {
                return;
            }
            
            if (!IsNeedLogMessage(opcode))
            {
                return;
            }
            
            Log.ILog.Debug("actorId: {0} {1}", actorId, message);
        }
    }
}