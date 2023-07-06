using System.Collections.Generic;
using System.Text;

namespace ET
{
    public static class OpcodeHelper
    {

        public static bool ShowMessage = true;

        public static long LastLogTime = 0;

        public static Dictionary<long, long> OuterMessageLength = new Dictionary<long, long>();

        public static Dictionary<long, long> InnerMessageLength = new Dictionary<long, long>();


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
                long totalLength = 0;
                foreach (var item in OuterMessageLength)
                {
                    totalLength += item.Value;
                    sb.AppendLine($"\tID: {item.Key}:   \tLength:  {item.Value}");
                }
                foreach (var item in InnerMessageLength)
                {
                    sb.AppendLine($"\tID: {item.Key}:   \tLength:  {item.Value}");
                }

                Log.Console($"\t当前消息： {totalLength} \n" +  sb.ToString());
                OuterMessageLength.Clear();
                InnerMessageLength.Clear();
            }

            if (ShowMessage)
            {
                if (!OuterMessageLength.ContainsKey(opcode))
                {
                    OuterMessageLength.Add(opcode, 0);
                }
                OuterMessageLength[opcode] += MongoHelper.ToBson(message).Length;
            }

            if (ShowMessage && zone == -1) //内网
            {
                if (!InnerMessageLength.ContainsKey(opcode))
                {
                    InnerMessageLength.Add(opcode, 0);
                }
                InnerMessageLength[opcode] += MongoHelper.ToBson(message).Length;
            }

            LastLogTime = serverTime;
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