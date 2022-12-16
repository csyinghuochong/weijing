using System.Collections.Generic;

namespace ET
{
    public static class ServerHelper
    {

        public const int ServerVersion = 0;

        //Alpha = 0,              //仅内部人员使用。一般不向外部发布
        //Beta = 1,               //公开测试版
        //BanHao = 2,
        public static string GetServerIpList(bool innerNet, int zone)
        {
            ServerItem serverItem = GetGetServerItem(innerNet, zone);
            return serverItem.ServerIp;
        }

        public static ServerItem GetGetServerItem(bool innerNet, int zone)
        {
            ServerItem serverItem = null;
            List<ServerItem> serverItems = ServerHelper.GetServerList(innerNet, zone);
            for (int i = 0; i < serverItems.Count; i++)
            {
                if (serverItems[i].ServerId == zone)
                {
                    serverItem = serverItems[i];
                }
            }
            return serverItem;
        }

        public static long GetOpenServerTime(bool innerNet, int zone)
        { 
            ServerItem serverItem = GetGetServerItem(innerNet, zone);   
            return serverItem.ServerOpenTime;   
        }

        public static int GetOpenServerDay(bool innerNet, int zone)
        {
            long openSerTime = GetOpenServerTime(innerNet, zone);
            if (openSerTime == 0)
            {
                return 0;
            }

            long serverNow = TimeHelper.ServerNow();
            int openserverDay = ComHelp.DateDiff_Time(serverNow, openSerTime);
            return openserverDay;
        }

        public static List<ServerItem> GetServerList(bool innerNet, int zone)
        {
            List<ServerItem> serverItems_1 = new List<ServerItem>();
            if (innerNet)
            {
                if (ComHelp.IsBanHaoZone(zone))
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 201, ServerIp = "127.0.0.1:20105", ServerName = "封测1区", ServerOpenTime = 1662189906681 });
                }
                else
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 1, ServerIp = "127.0.0.1:20305", ServerName = "封测一区", ServerOpenTime = 1662189906681, Show = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 2, ServerIp = "127.0.0.1:20325", ServerName = "封测区", ServerOpenTime = 1662189906681, Show = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 3, ServerIp = "127.0.0.1:20325", ServerName = "封测区", ServerOpenTime = 1662189906681, Show = 1 });
                    serverItems_1.Add(new ServerItem() { ServerId = 4, ServerIp = "127.0.0.1:20325", ServerName = "封测区", ServerOpenTime = 1662189906681, Show = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 5, ServerIp = "127.0.0.1:20335", ServerName = "先锋一区", ServerOpenTime = 1669435366360, Show = 1 });
                    serverItems_1.Add(new ServerItem() { ServerId = 6, ServerIp = "127.0.0.1:20345", ServerName = "先锋二区", ServerOpenTime = 1669975200000, Show = 1 });
                    serverItems_1.Add(new ServerItem() { ServerId = 7, ServerIp = "127.0.0.1:20355", ServerName = "先锋三区", ServerOpenTime = 1670580000000, Show = 1 });
                    serverItems_1.Add(new ServerItem() { ServerId = 8, ServerIp = "127.0.0.1:20365", ServerName = "先锋四区", ServerOpenTime = 1671188400000, Show = 1 });
                    
                    serverItems_1.Add(new ServerItem() { ServerId = 9, ServerIp = "127.0.0.1:20375", ServerName = "先锋五区", ServerOpenTime = 0, Show = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 10, ServerIp = "127.0.0.1:20385", ServerName = "先锋六区", ServerOpenTime = 0, Show = 0 });
                }
            }
            else
            {
                if (ComHelp.IsBanHaoZone(zone))
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 201, ServerIp = "39.96.194.143:20105", ServerName = "封测1区", ServerOpenTime = 1662189906681 });
                }
                else
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 1, ServerIp = "39.96.194.143:20305", ServerName = "封测一区", ServerOpenTime = 1662189906681,Show = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 2, ServerIp = "39.96.194.143:20325", ServerName = "封测区", ServerOpenTime = 1662189906681, Show = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 3, ServerIp = "39.96.194.143:20325", ServerName = "封测区", ServerOpenTime = 1662189906681, Show = 1 });
                    serverItems_1.Add(new ServerItem() { ServerId = 4, ServerIp = "39.96.194.143:20325", ServerName = "封测区", ServerOpenTime = 1662189906681, Show = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 5, ServerIp = "39.96.194.143:20335", ServerName = "先锋一区", ServerOpenTime = 1669435366360, Show = 1 });
                    serverItems_1.Add(new ServerItem() { ServerId = 6, ServerIp = "39.96.194.143:20345", ServerName = "先锋二区", ServerOpenTime = 1669975200000 ,Show = 1 });
                    serverItems_1.Add(new ServerItem() { ServerId = 7, ServerIp = "39.96.194.143:20355", ServerName = "先锋三区", ServerOpenTime = 1670580000000, Show = 1 });
                    serverItems_1.Add(new ServerItem() { ServerId = 8, ServerIp = "39.96.194.143:20365", ServerName = "先锋四区", ServerOpenTime = 1671188400000, Show = 1 });
                    
                    serverItems_1.Add(new ServerItem() { ServerId = 9, ServerIp = "39.96.194.143:20375", ServerName = "先锋五区", ServerOpenTime = 0, Show = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId =10, ServerIp = "39.96.194.143:20385", ServerName = "先锋六区", ServerOpenTime = 0, Show = 0 });
                }
            }

            return serverItems_1;
        }
    }
}
