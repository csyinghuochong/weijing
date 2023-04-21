using System.Collections.Generic;

namespace ET
{

    /// <summary>
    /// 删档前先备份
    /// </summary>
    public static class DeleteZoneHelper
    {
        public static async ETTask DeletionZone(int zone)
        {
            var startZoneConfig = StartZoneConfigCategory.Instance.Get(zone);
            Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);

            //中心区
            startZoneConfig = StartZoneConfigCategory.Instance.Get(202);
            Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);

            List<DBAccountInfo> dBAccountInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(zone, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_old)
            {
                //删除的账号在中心区做个记录
                List<DBCenterAccountInfo> dBAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id == entity.Id);
                dBAccountInfos[0].PlayerInfo.DeleteUserList.Clear();

                for (int i = 0; i < entity.UserList.Count; i++)
                {
                    List<UserInfoComponent> dbuserinfo_old = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(zone, d => d.Id > 0);
                    dBAccountInfos[0].PlayerInfo.DeleteUserList.Add(new KeyValuePair()
                    {
                        Value = dbuserinfo_old[0].Id.ToString(),
                        Value2 = dbuserinfo_old[0].UserInfo.Name
                    });
                }


                await Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(202, dBAccountInfos[0]);
            }

            await ETTask.CompletedTask;
        }

    }
}
