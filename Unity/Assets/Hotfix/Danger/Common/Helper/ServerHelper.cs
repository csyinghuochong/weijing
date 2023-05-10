using System;
using System.Collections.Generic;

namespace ET
{
    public static class ServerHelper
    {

        public const int ServerVersion = 1;
        public static List<ServerItem> ServerItems = new List<ServerItem>();   

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

            int openserverDay = DateDiff_Time(serverNow, openSerTime);
            return openserverDay;
        }

        public static int DateDiff_Time(long time1, long time2)
        {
            DateTime d1 = TimeInfo.Instance.ToDateTime(time1);
            DateTime d2 = TimeInfo.Instance.ToDateTime(time2);
            DateTime d3 = Convert.ToDateTime(string.Format("{0}-{1}-{2}", d1.Year, d1.Month, d1.Day));

            DateTime d4 = Convert.ToDateTime(string.Format("{0}-{1}-{2}", d2.Year, d2.Month, d2.Day));
            int days = (d3 - d4).Days + 1;
            return days;
        }

        public const string LogicServer = "weijinggameserver.weijinggame.com";//"weijinggameserver.weijinggame.com"


        /// <summary>
        /// 合区后的区
        /// </summary>
        /// <param name="banhao"></param>
        /// <param name="zone"></param>
        /// <returns></returns>
        public static int GetNewServerId(bool banhao, int zone)
        {
            List<ServerItem> serverItems_1 = new List<ServerItem>();
            if (banhao)
            {
                serverItems_1 = GetServerList(false, 201);
            }
            else
            {
                serverItems_1 = GetServerList(false, 1);
            }

            string serverip = string.Empty;
            for (int i = 0; i < serverItems_1.Count; i++)
            {
                if (serverItems_1[i].ServerId == zone)
                {
                    serverip = serverItems_1[i].ServerIp;
                    break;
                }
            }
            for (int i = 0; i < serverItems_1.Count; i++)
            {
                if (serverItems_1[i].ServerIp == serverip && serverItems_1[i].Show == 1)
                {
                    zone = serverItems_1[i].ServerId;
                    break;
                }
            }
            return zone;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="innerNet"></param>
        /// <param name="zone"></param>
        /// <returns></returns>
        public static int GetOldServerId(bool banhao, int zone)
        {
            List<ServerItem> serverItems_1 = new List<ServerItem>();
            if (banhao)
            {
                serverItems_1 = GetServerList(false, 201);
            }
            else
            {
                serverItems_1 = GetServerList(false, 1);
            }

            string serverip = string.Empty;
            for (int i = 0; i < serverItems_1.Count; i++)
            {
                if (serverItems_1[i].ServerId == zone)
                {
                    serverip = serverItems_1[i].ServerIp;
                    break;
                }
            }
            for (int i = 0; i < serverItems_1.Count; i++)
            {
                if (serverItems_1[i].ServerIp == serverip)
                {
                    zone = serverItems_1[i].ServerId;
                }
            }
            return zone;
        }

        public static bool IsOldServer(int zone)
        {
            List<ServerItem> serverItems_1 = GetServerList(false, 1);
            string serverip = string.Empty;
            for (int i = 0; i < serverItems_1.Count; i++)
            {
                if (serverItems_1[i].ServerId == zone)
                {
                    serverip = serverItems_1[i].ServerIp;
                    break;
                }
            }

            int servernumber = 0;
            for (int i = 0; i < serverItems_1.Count; i++)
            {
                if (serverItems_1[i].ServerIp == serverip)
                {
                    servernumber++;
                    break;
                }
            }
            return servernumber > 1;
        }

        public static List<ServerItem> GetServerList(bool innerNet, int zone)
        {
            if (ServerItems.Count > 0 && ServerVersion == 1)
            { 
                return ServerItems;
            }
            Log.Debug("UpdateServerList");
            ServerItems.Clear();
            string ip = innerNet ?  "127.0.0.1" : LogicServer;
            List<ServerItem> serverItems_1 = ServerItems;

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
                serverItems_1.Add(new ServerItem() { ServerId = 6, ServerIp = $"{ip}:20335", ServerName = "先锋二区", ServerOpenTime = 1669435366360, Show = 0 });
                serverItems_1.Add(new ServerItem() { ServerId = 7, ServerIp = $"{ip}:20335", ServerName = "先锋三区", ServerOpenTime = 1669435366360, Show = 0 });
                serverItems_1.Add(new ServerItem() { ServerId = 8, ServerIp = $"{ip}:20335", ServerName = "先锋四区", ServerOpenTime = 1669435366360, Show = 0 });

                serverItems_1.Add(new ServerItem() { ServerId = 9, ServerIp = $"{ip}:20345", ServerName = "先锋五区", ServerOpenTime = 1671793200000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 10, ServerIp = $"{ip}:20345", ServerName = "先锋六区", ServerOpenTime = 1671793200000, Show = 0 });
                serverItems_1.Add(new ServerItem() { ServerId = 11, ServerIp = $"{ip}:20345", ServerName = "先锋七区", ServerOpenTime = 1671793200000, Show = 0 });

                serverItems_1.Add(new ServerItem() { ServerId = 12, ServerIp = $"{ip}:20355", ServerName = "兔年大吉", ServerOpenTime = 1676012400000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 13, ServerIp = $"{ip}:20355", ServerName = "玉兔新春", ServerOpenTime = 1676012400000, Show = 0 });
                serverItems_1.Add(new ServerItem() { ServerId = 14, ServerIp = $"{ip}:20355", ServerName = "元宵佳节", ServerOpenTime = 1676012400000, Show = 0 });
                serverItems_1.Add(new ServerItem() { ServerId = 15, ServerIp = $"{ip}:20355", ServerName = "金戈铁马", ServerOpenTime = 1676012400000, Show = 0 });
                serverItems_1.Add(new ServerItem() { ServerId = 16, ServerIp = $"{ip}:20355", ServerName = "世外桃源", ServerOpenTime = 1676012400000, Show = 0 });
                serverItems_1.Add(new ServerItem() { ServerId = 17, ServerIp = $"{ip}:20355", ServerName = "名扬四海", ServerOpenTime = 1674212400000, Show = 0 });

                serverItems_1.Add(new ServerItem() { ServerId = 18, ServerIp = $"{ip}:20385", ServerName = "华灯初上", ServerOpenTime = 1677841200000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 19, ServerIp = $"{ip}:20385", ServerName = "灯火阑珊", ServerOpenTime = 1678446000000, Show = 0 });

                serverItems_1.Add(new ServerItem() { ServerId = 20, ServerIp = $"{ip}:20405", ServerName = "似水流年", ServerOpenTime = 1679050800000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 21, ServerIp = $"{ip}:20405", ServerName = "秋水人家", ServerOpenTime = 1679655600000, Show = 0 });

                serverItems_1.Add(new ServerItem() { ServerId = 22, ServerIp = $"{ip}:20425", ServerName = "烟雨云烟", ServerOpenTime = 1680260400000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 23, ServerIp = $"{ip}:20425", ServerName = "繁星之梦", ServerOpenTime = 1680850800000, Show = 0 });
               
                serverItems_1.Add(new ServerItem() { ServerId = 24, ServerIp = $"{ip}:20375", ServerName = "碧空之歌", ServerOpenTime = 1681470000000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 25, ServerIp = $"{ip}:20395", ServerName = "灰烬使者", ServerOpenTime = 1682074800000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 26, ServerIp = $"{ip}:20415", ServerName = "劳动光荣", ServerOpenTime = 1682679600000, Show = 1 });
                serverItems_1.Add(new ServerItem() { ServerId = 27, ServerIp = $"{ip}:20435", ServerName = "逐风者", ServerOpenTime = 1683284400000, Show = 1 });
            }

            return serverItems_1;
        }
    }
}
