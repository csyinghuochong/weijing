using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class ServerHelper
    {

        //Alpha = 0,              //仅内部人员使用。一般不向外部发布
        //Beta = 1,               //公开测试版
        //BanHao = 2,
        public static string GetServerIpList(bool innernet, int serverid)
        {
            ServerItem serverItem = null;
            List<ServerItem> serverItems = ServerHelper.GetServerList(innernet, serverid);
            for (int i = 0; i < serverItems.Count; i++)
            {
                if (serverItems[i].ServerId == serverid)
                {
                    serverItem = serverItems[i];
                }
            }
            return serverItem.ServerIp;
        }


        public static List<ServerItem> GetServerList(bool innerNet, int zone)
        {
            List<ServerItem> serverItems_1 = new List<ServerItem>();
            if (innerNet)
            {
                if (ComHelp.IsBanHaoZone(zone))
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 201, ServerIp = "127.0.0.1:20105", ServerName = "封测1区", ServerOpenTime = 0 });
                }
                else
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 1, ServerIp = "127.0.0.1:20305", ServerName = "封测一区", ServerOpenTime = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 2, ServerIp = "127.0.0.1:20325", ServerName = "封测二区", ServerOpenTime = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 3, ServerIp = "127.0.0.1:20325", ServerName = "封测三区", ServerOpenTime = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 4, ServerIp = "127.0.0.1:20335", ServerName = "封测四区", ServerOpenTime = 0 });
                }
            }
            else
            {
                if (ComHelp.IsBanHaoZone(zone))
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 201, ServerIp = "39.96.194.143:20105", ServerName = "封测1区", ServerOpenTime = 0 });
                }
                else
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 1, ServerIp = "39.96.194.143:20305", ServerName = "封测一区", ServerOpenTime = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 2, ServerIp = "39.96.194.143:20325", ServerName = "封测二区", ServerOpenTime = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 3, ServerIp = "39.96.194.143:20325", ServerName = "封测三区", ServerOpenTime = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 4, ServerIp = "39.96.194.143:20335", ServerName = "封测四区", ServerOpenTime = 0 });
                }
            }

            return serverItems_1;
        }
    }
}
