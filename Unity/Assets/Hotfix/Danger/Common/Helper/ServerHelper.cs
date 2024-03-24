using System;
using System.Collections.Generic;

namespace ET
{
    public static class ServerHelper
    {
        public static int UpdateServerList = 0;  //改成int
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
            List<ServerItem> serverItems = ServerHelper.GetServerList(innerNet);
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
        public const string LogicServerBanHao = "47.94.107.92";

        public static string GetLogicServer(bool innerNet, VersionMode versionMode)
        {
            return innerNet ? ComHelp.LocalIp : LogicServer;
            //switch (versionMode)
            //{
            //    case VersionMode.BanHao:
            //        return innerNet ? ComHelp.LocalIp : LogicServerBanHao;
            //    default:
            //        return innerNet ? ComHelp.LocalIp : LogicServer;

            //}
        }

        /// <summary>
        /// 合区后的区
        /// </summary>
        /// <param name="banhao"></param>
        /// <param name="zone"></param>
        /// <returns></returns>
        public static int GetNewServerId(int zone)
        {
            List<ServerItem> serverItems_1 = GetServerList(false);
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
        public static int GetOldServerId(int zone)
        {
            List<ServerItem> serverItems_1 = GetServerList(false);

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
            List<ServerItem> serverItems_1 = GetServerList(false);
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
                }
            }
            return servernumber > 1;
        }

        public static List<ServerItem> GetServerList(bool innerNet)
        {
            if (ServerItems.Count > 0 && UpdateServerList == 1)
            { 
                return ServerItems;
            }
            //Log.Debug("UpdateServerList");
            UpdateServerList = 1;
            ServerItems.Clear();

            string ip =  GetLogicServer(innerNet, VersionMode.Beta);
            List<ServerItem> serverItems_1 = ServerItems;

            //serverItems_1.Add(new ServerItem() { ServerId = 2, ServerIp = $"{ip}:20325", ServerName = "审核专区", ServerOpenTime = 1662189906681, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 3, ServerIp = $"{ip}:20325", ServerName = "审核专区", ServerOpenTime = 1662189906681, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 4, ServerIp = $"{ip}:20325", ServerName = "审核专区", ServerOpenTime = 1662189906681, New = 0, Show = 0 });

            serverItems_1.Add(new ServerItem() { ServerId = 5, ServerIp = $"{ip}:20335", ServerName = "先锋一区", ServerOpenTime = 1669435366360, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 6, ServerIp = $"{ip}:20335", ServerName = "先锋二区", ServerOpenTime = 1669435366360, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 7, ServerIp = $"{ip}:20335", ServerName = "先锋三区", ServerOpenTime = 1669435366360, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 8, ServerIp = $"{ip}:20335", ServerName = "先锋四区", ServerOpenTime = 1669435366360, New = 0, Show = 0 });

            serverItems_1.Add(new ServerItem() { ServerId = 9, ServerIp = $"{ip}:20345", ServerName = "先锋五区", ServerOpenTime = 1671793200000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 10, ServerIp = $"{ip}:20345", ServerName = "先锋六区", ServerOpenTime = 1671793200000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 11, ServerIp = $"{ip}:20345", ServerName = "先锋七区", ServerOpenTime = 1671793200000, New = 0, Show = 0 });

            serverItems_1.Add(new ServerItem() { ServerId = 12, ServerIp = $"{ip}:20355", ServerName = "兔年大吉", ServerOpenTime = 1676012400000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 13, ServerIp = $"{ip}:20355", ServerName = "玉兔新春", ServerOpenTime = 1676012400000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 14, ServerIp = $"{ip}:20355", ServerName = "元宵佳节", ServerOpenTime = 1676012400000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 15, ServerIp = $"{ip}:20355", ServerName = "金戈铁马", ServerOpenTime = 1676012400000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 16, ServerIp = $"{ip}:20355", ServerName = "世外桃源", ServerOpenTime = 1676012400000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 17, ServerIp = $"{ip}:20355", ServerName = "名扬四海", ServerOpenTime = 1674212400000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 18, ServerIp = $"{ip}:20355", ServerName = "华灯初上", ServerOpenTime = 1677841200000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 19, ServerIp = $"{ip}:20355", ServerName = "灯火阑珊", ServerOpenTime = 1678446000000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 20, ServerIp = $"{ip}:20355", ServerName = "似水流年", ServerOpenTime = 1679050800000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 21, ServerIp = $"{ip}:20355", ServerName = "秋水人家", ServerOpenTime = 1679655600000, New = 0, Show = 0 });

            serverItems_1.Add(new ServerItem() { ServerId = 22, ServerIp = $"{ip}:20425", ServerName = "烟雨云烟", ServerOpenTime = 1680260400000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 23, ServerIp = $"{ip}:20425", ServerName = "繁星之梦", ServerOpenTime = 1680850800000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 24, ServerIp = $"{ip}:20425", ServerName = "碧空之歌", ServerOpenTime = 1681470000000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 25, ServerIp = $"{ip}:20425", ServerName = "灰烬使者", ServerOpenTime = 1682074800000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 26, ServerIp = $"{ip}:20425", ServerName = "劳动光荣", ServerOpenTime = 1682679600000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 27, ServerIp = $"{ip}:20425", ServerName = "逐风者", ServerOpenTime = 1683284400000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 28, ServerIp = $"{ip}:20425", ServerName = "命运之剑", ServerOpenTime = 1683889200000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 29, ServerIp = $"{ip}:20425", ServerName = "紫禁之巅", ServerOpenTime = 1684494000000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 30, ServerIp = $"{ip}:20425", ServerName = "天空之城", ServerOpenTime = 1685073900000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 31, ServerIp = $"{ip}:20425", ServerName = "遗忘之海", ServerOpenTime = 1685703600000, New = 0, Show = 0 });

            serverItems_1.Add(new ServerItem() { ServerId = 32, ServerIp = $"{ip}:20385", ServerName = "金榜题名", ServerOpenTime = 1686308400000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 33, ServerIp = $"{ip}:20385", ServerName = "鱼跃龙门", ServerOpenTime = 1686913200000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 34, ServerIp = $"{ip}:20385", ServerName = "龙舟竞渡", ServerOpenTime = 1687494600000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 35, ServerIp = $"{ip}:20385", ServerName = "梦境之地", ServerOpenTime = 1688122800000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 36, ServerIp = $"{ip}:20385", ServerName = "叹息森林", ServerOpenTime = 1688702700000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 37, ServerIp = $"{ip}:20385", ServerName = "风之国度", ServerOpenTime = 1688789100000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 38, ServerIp = $"{ip}:20385", ServerName = "燃烧之刃", ServerOpenTime = 1689314400000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 39, ServerIp = $"{ip}:20385", ServerName = "北海之都", ServerOpenTime = 1689937200000, New = 0, Show = 0 });

            //2024-1-5 合区曙光之城合天涯海角  40/44
            serverItems_1.Add(new ServerItem() { ServerId = 40, ServerIp = $"{ip}:20465", ServerName = "曙光之城", ServerOpenTime = 1690542000000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 41, ServerIp = $"{ip}:20465", ServerName = "世界之树", ServerOpenTime = 1691146800000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 42, ServerIp = $"{ip}:20465", ServerName = "雷霆之路", ServerOpenTime = 1691730000000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 43, ServerIp = $"{ip}:20465", ServerName = "花开彼岸", ServerOpenTime = 1692356400000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 44, ServerIp = $"{ip}:20465", ServerName = "天涯海角", ServerOpenTime = 1692937800000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 45, ServerIp = $"{ip}:20465", ServerName = "长相思", ServerOpenTime = 1693566000000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 46, ServerIp = $"{ip}:20465", ServerName = "执子之手", ServerOpenTime = 1694170800000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 47, ServerIp = $"{ip}:20465", ServerName = "与子偕老", ServerOpenTime = 1694752200000, New = 0, Show = 0 });

            serverItems_1.Add(new ServerItem() { ServerId = 48, ServerIp = $"{ip}:20365", ServerName = "流云若梦", ServerOpenTime = 1695380400000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 49, ServerIp = $"{ip}:20365", ServerName = "欢度国庆", ServerOpenTime = 1695961800000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 50, ServerIp = $"{ip}:20365", ServerName = "金戈铁马", ServerOpenTime = 1696566600000, New = 0, Show = 0 });
            serverItems_1.Add(new ServerItem() { ServerId = 51, ServerIp = $"{ip}:20365", ServerName = "迷雾森林", ServerOpenTime = 1697171400000, New = 0, Show = 0 });

            serverItems_1.Add(new ServerItem() { ServerId = 52, ServerIp = $"{ip}:20445", ServerName = "希望之树", ServerOpenTime = 1697799600000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 53, ServerIp = $"{ip}:20445", ServerName = "梦境之海", ServerOpenTime = 1698381000000, New = 0, Show = 0 });

            serverItems_1.Add(new ServerItem() { ServerId = 54, ServerIp = $"{ip}:20395", ServerName = "百年风华", ServerOpenTime = 1698985800000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 55, ServerIp = $"{ip}:20395", ServerName = "盛世如愿", ServerOpenTime = 1699590600000, New = 0, Show = 0 });

            ///2023-12-29 合区精灵国度合梦回华夏  56 / 57
            serverItems_1.Add(new ServerItem() { ServerId = 56, ServerIp = $"{ip}:20455", ServerName = "精灵国度", ServerOpenTime = 1700195400000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 57, ServerIp = $"{ip}:20455", ServerName = "梦回华夏", ServerOpenTime = 1700800200000, New = 0, Show = 0 });

            //2024-1-5 合区璀璨之境合遗忘森林  58/59
            serverItems_1.Add(new ServerItem() { ServerId = 58, ServerIp = $"{ip}:20475", ServerName = "璀璨之境", ServerOpenTime = 1701405000000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 59, ServerIp = $"{ip}:20475", ServerName = "遗忘森林", ServerOpenTime = 1702009800000, New = 0, Show = 0 });

            //2024-1-19 合区希望之光合斗战胜佛 60/61
            serverItems_1.Add(new ServerItem() { ServerId = 60, ServerIp = $"{ip}:20405", ServerName = "希望之光", ServerOpenTime = 1702614600000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 61, ServerIp = $"{ip}:20405", ServerName = "斗战胜佛", ServerOpenTime = 1703242800000, New = 0, Show = 0, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });

            //2024/2/23 合区新年快乐合万里华夏 62/63
            serverItems_1.Add(new ServerItem() { ServerId = 62, ServerIp = $"{ip}:20375", ServerName = "万里华夏", ServerOpenTime = 1703847600000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 63, ServerIp = $"{ip}:20375", ServerName = "万里华夏", ServerOpenTime = 1704427200000, New = 0, Show = 0, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });

            //2024/2/26 19:00 合区繁星之梦-天下无双64/65
            serverItems_1.Add(new ServerItem() { ServerId = 64, ServerIp = $"{ip}:20485", ServerName = "繁星之梦", ServerOpenTime = 1705057200000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 65, ServerIp = $"{ip}:20485", ServerName = "天下无双", ServerOpenTime = 1705662000000, New = 0, Show = 0, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });

            //2024/3/1 万里冰封-天空之城 66/67
            serverItems_1.Add(new ServerItem() { ServerId = 66, ServerIp = $"{ip}:20505", ServerName = "万里冰封", ServerOpenTime = 1705914000000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 67, ServerIp = $"{ip}:20505", ServerName = "天空之城", ServerOpenTime = 1706243400000, New = 0, Show = 0, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });


            //2024/3/8  合区 梦境森林 - 勇者之路 68/69
            serverItems_1.Add(new ServerItem() { ServerId = 68, ServerIp = $"{ip}:20525", ServerName = "梦境森林", ServerOpenTime = 1706589000000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 69, ServerIp = $"{ip}:20525", ServerName = "勇者之路", ServerOpenTime = 1706871600000, New = 0, Show = 0, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });

            //2024/3/8  合区 碧蓝之海 - 龙年大吉 70/71
            serverItems_1.Add(new ServerItem() { ServerId = 70, ServerIp = $"{ip}:20545", ServerName = "碧蓝之海", ServerOpenTime = 1707217200000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 71, ServerIp = $"{ip}:20545", ServerName = "龙年大吉", ServerOpenTime = 1707476400000, New = 0, Show = 0, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            
            //2024/3/25  合区：新年快乐-恭喜发财 72/73
            serverItems_1.Add(new ServerItem() { ServerId = 72, ServerIp = $"{ip}:20565", ServerName = "新年快乐", ServerOpenTime = 1707735600000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 73, ServerIp = $"{ip}:20565", ServerName = "恭喜发财", ServerOpenTime = 1708081200000, New = 0, Show = 0, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            
            serverItems_1.Add(new ServerItem() { ServerId = 74, ServerIp = $"{ip}:20585", ServerName = "龙凤呈祥", ServerOpenTime = 1708340400000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 75, ServerIp = $"{ip}:20415", ServerName = "万家灯火", ServerOpenTime = 1708686000000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 76, ServerIp = $"{ip}:20595", ServerName = "花好月圆", ServerOpenTime = 1708945200000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 77, ServerIp = $"{ip}:20435", ServerName = "名扬四海", ServerOpenTime = 1709290800000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 78, ServerIp = $"{ip}:20495", ServerName = "烟雨云烟", ServerOpenTime = 1709550000000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 79, ServerIp = $"{ip}:20515", ServerName = "九霄云外", ServerOpenTime = 1709895600000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 80, ServerIp = $"{ip}:20535", ServerName = "烽烟四起", ServerOpenTime = 1710154800000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 81, ServerIp = $"{ip}:20555", ServerName = "燃烧之地", ServerOpenTime = 1710500400000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 82, ServerIp = $"{ip}:20605", ServerName = "万水千山", ServerOpenTime = 1710824400000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            serverItems_1.Add(new ServerItem() { ServerId = 83, ServerIp = $"{ip}:20615", ServerName = "梦想之城", ServerOpenTime = 1711105200000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });

            
            //梦想之城 2024-03-25 19:00:00  1711364400000
            serverItems_1.Add(new ServerItem() { ServerId = 84, ServerIp = $"{ip}:20625", ServerName = "龙的传人", ServerOpenTime = 1711364400000, New = 0, Show = 1, PlatformList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 20001 } });
            
            ///PlatformHelper.GetPlatformName(); 所有渠道ID定义
            List<int> allserverId = new List<int>();
            for (int i = 0; i < serverItems_1.Count; i++)
            {
                if (allserverId.Contains(serverItems_1[i].ServerId))
                {
                    Console.WriteLine($"服务器ID冲突： {serverItems_1[i].ServerId}");
                }
                else
                {
                    allserverId.Add(serverItems_1[i].ServerId);
                }
            }
            
            return serverItems_1;
        }
    }
}
