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
            if (serverItem == null)
            {
                Log.Debug($"serverItem == null {zone}");
                return 0;
            }
            return serverItem.ServerOpenTime;   
        }

        public static int GetOpenServerDay(bool innerNet, int zone)
        {
            long serverNow = TimeHelper.ServerNow();
            long openSerTime = GetOpenServerTime(innerNet, zone);
            if (openSerTime == 0 || serverNow < openSerTime)
            {
                return 0;
            }

            int openserverDay = ComHelp.DateDiff_Time(serverNow, openSerTime);
            return openserverDay;
        }

        public static List<ServerItem> GetServerList(bool innerNet, int zone)
        {
            string ip = innerNet ?  "127.0.0.1" : "39.96.194.143";
            //string ip = innerNet ? "127.0.0.1" : "weijinggame.weijinggame.com";
            List<ServerItem> serverItems_1 = new List<ServerItem>();

            if (ComHelp.IsBanHaoZone(zone))
            {
                serverItems_1.Add(new ServerItem() { ServerId = 201, ServerIp = $"{ip}:20105", ServerName = "封测1区", ServerOpenTime = 1662189906681, Show = 0 });
            }
            else
            {
                serverItems_1.Add(new ServerItem() { ServerId = 1, ServerIp = $"{ip}:20305", ServerName = "封测一区", ServerOpenTime = 1662189906681, Show = 0 });

                serverItems_1.Add(new ServerItem() { ServerId = 2, ServerIp = $"{ip}:20325", ServerName = "封测区", ServerOpenTime = 1662189906681, Show = 0 });
                serverItems_1.Add(new ServerItem() { ServerId = 3, ServerIp = $"{ip}:20325", ServerName = "封测区", ServerOpenTime = 1662189906681, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 4, ServerIp = $"{ip}:20325", ServerName = "封测区", ServerOpenTime = 1662189906681, Show = 0 });

                serverItems_1.Add(new ServerItem() { ServerId = 5, ServerIp = $"{ip}:20335", ServerName = "先锋一区", ServerOpenTime = 1669435366360, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 6, ServerIp = $"{ip}:20335", ServerName = "先锋二区", ServerOpenTime = 1669435366360, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 7, ServerIp = $"{ip}:20335", ServerName = "先锋三区", ServerOpenTime = 1669435366360, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 8, ServerIp = $"{ip}:20335", ServerName = "先锋四区", ServerOpenTime = 1669435366360, Show = 1 });

                serverItems_1.Add(new ServerItem() { ServerId = 9, ServerIp = $"{ip}:20375", ServerName = "先锋五区", ServerOpenTime = 1671793200000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 10, ServerIp = $"{ip}:20375", ServerName = "先锋六区", ServerOpenTime = 1671793200000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 11, ServerIp = $"{ip}:20375", ServerName = "先锋七区", ServerOpenTime = 1671793200000, Show = 1 });

                serverItems_1.Add(new ServerItem() { ServerId = 12, ServerIp = $"{ip}:20405", ServerName = "兔年大吉", ServerOpenTime = 1674212400000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 13, ServerIp = $"{ip}:20405", ServerName = "玉兔新春", ServerOpenTime = 1674903600000, Show = 1 });

                serverItems_1.Add(new ServerItem() { ServerId = 14, ServerIp = $"{ip}:20425", ServerName = "元宵佳节", ServerOpenTime = 1675580400000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 15, ServerIp = $"{ip}:20425", ServerName = "金戈铁马", ServerOpenTime = 1675580400000, Show = 1 });
                
                serverItems_1.Add(new ServerItem() { ServerId = 16, ServerIp = $"{ip}:20445", ServerName = "世外桃源", ServerOpenTime = 1676631600000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 17, ServerIp = $"{ip}:20445", ServerName = "名扬四海", ServerOpenTime = 1676631600000, Show = 1 });

                serverItems_1.Add(new ServerItem() { ServerId = 18, ServerIp = $"{ip}:20465", ServerName = "华灯初上", ServerOpenTime = 1677841200000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 19, ServerIp = $"{ip}:20475", ServerName = "灯火阑珊", ServerOpenTime = 1678446000000, Show = 1 });

                serverItems_1.Add(new ServerItem() { ServerId = 20, ServerIp = $"{ip}:20485", ServerName = "似水流年", ServerOpenTime = 1679050800000, Show = 1 });
            }

            return serverItems_1;
        }
    }
}
