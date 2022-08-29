using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class CenterSceneComponentSystemAwakeSystem : AwakeSystem<CenterServerComponent>
    {
        public override void Awake(CenterServerComponent self)
        {
            self.UpdateServerInfo().Coroutine();
        }
    }

    public static class CenterServerComponentSystem
    {
        public static async ETTask UpdateServerInfo(this CenterServerComponent self)
        {
            DBCenterServerInfo dBServerInfo = null;
            List<DBCenterServerInfo> result = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterServerInfo>(self.DomainZone(), d => d.Id == self.DomainZone());
            if (result.Count == 0)
            {
                dBServerInfo = new DBCenterServerInfo();
                dBServerInfo.Id = self.DomainZone();
                StartMachineConfig startMachineConfig = StartMachineConfigCategory.Instance.Get(1);
                if (startMachineConfig.InnerIP.Contains("127.0.0.1"))
                {
                    dBServerInfo.ServerItems.Add(new ServerItem() { ServerId = 1, ServerIp = "127.0.0.1:20105", ServerName = "内侧一区", ServerOpenTime = 0 });
                    dBServerInfo.ServerItems.Add(new ServerItem() { ServerId = 2, ServerIp = "127.0.0.1:20115", ServerName = "内侧二区", ServerOpenTime = 0 });
                    dBServerInfo.ServerItems.Add(new ServerItem() { ServerId = 201, ServerIp = "127.0.0.1:20125", ServerName = "审核区", ServerOpenTime = 0 });
                }
                else
                {
                    dBServerInfo.ServerItems.Add(new ServerItem() { ServerId = 1, ServerIp = "39.96.194.143:20105", ServerName = "封侧一区", ServerOpenTime = 0 });
                    dBServerInfo.ServerItems.Add(new ServerItem() { ServerId = 2, ServerIp = "39.96.194.143:20115", ServerName = "封侧二区", ServerOpenTime = 0 });
                    dBServerInfo.ServerItems.Add(new ServerItem() { ServerId = 201, ServerIp = "39.96.194.143:20125", ServerName = "审核区", ServerOpenTime = 0 });
                }
            }
            else
            {
                dBServerInfo = result[0];
            }

            await Game.Scene.GetComponent<DBComponent>().Save(self.DomainZone(), dBServerInfo);
        }

    }
}
