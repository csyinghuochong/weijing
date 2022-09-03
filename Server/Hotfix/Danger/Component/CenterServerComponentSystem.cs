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
            }
            else
            {
                dBServerInfo = result[0];
            }

            await Game.Scene.GetComponent<DBComponent>().Save(self.DomainZone(), dBServerInfo);
        }

    }
}
