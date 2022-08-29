using System;


namespace ET
{
    public static class EnterMapHelper
    {
        //public static async ETTask EnterMapAsync(Scene zoneScene, long accountid, long useid)   //登录
        //{
        //    try
        //    {
        //        G2C_EnterMap g2CEnterMap = await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2G_EnterMap() {
        //            MapId = 1,
        //            UserID = useid,
        //            AccountId = accountid,
        //        }) as G2C_EnterMap;
        //        zoneScene.GetComponent<AccountInfoComponent>().MyId = g2CEnterMap.UnitId;

        //        // 等待场景切换完成[创建了主Unit]
        //        await zoneScene.GetComponent<ObjectWait>().Wait<WaitType.Wait_SceneChangeFinish>();
               
        //        //请求角色数据
        //        await NetHelper.RequestUserInfo(zoneScene);
        //        //请求背包数据
        //        await NetHelper.RequestBagInfo(zoneScene);
        //        //请求宠物数据
        //        await NetHelper.RequestAllPets(zoneScene);
        //        //请求任务数据
        //        await NetHelper.RequestIniTask(zoneScene);
        //        //请求技能设置
        //        await NetHelper.RequestSkillSet(zoneScene);
        //        //请求好友数据
        //        await NetHelper.RequestFriendInfo(zoneScene);

        //        Game.EventSystem.Publish(new EventType.EnterMapFinish() {ZoneScene = zoneScene});
        //    }

        //    catch (Exception e)
        //    {
        //        Log.Error(e);
        //    }	
        //}
    }
}