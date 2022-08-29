//using System;

//namespace ET
//{
//    [MessageHandler]
//    public class C2G_ReEnterMapHandler : AMRpcHandler<C2G_ReEnterMap, G2C_ReEnterMap>
//    {
//        protected override async ETTask Run(Session session, C2G_ReEnterMap request, G2C_ReEnterMap response, Action reply)
//        {
//            Player player = session.GetComponent<SessionPlayerComponent>().GetMyPlayer();

//            GateUnitInfo gateUnitInfo = null;
//            session.Domain.GetComponent<GateUnitComponent>().GateUnitList.TryGetValue(request.UserID, out gateUnitInfo);
//            if (gateUnitInfo == null || gateUnitInfo.SceneInstanceId == 0)
//            {
//                response.Error = ErrorCore.ERR_Error;
//                reply();
//                return;
//            }

//            M2G_ReCreateUnit createUnit = (M2G_ReCreateUnit)await ActorMessageSenderComponent.Instance.Call(
//                   gateUnitInfo.SceneInstanceId, new G2M_ReCreateUnit()
//                   {
//                       GateSessionId = session.InstanceId,
//                       UserID = request.UserID
//                   });
//            if (createUnit.Error != ErrorCore.ERR_Success)
//            {
//                response.Error = createUnit.Error;
//                reply();
//                return;
//            }
         
//            player.UnitId = createUnit.UnitId;
//            player.DBCacheId = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;;
//            player.ChatServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Chat)).InstanceId;
//            player.MailServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;
//            player.ChargetServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.ReCharge)).InstanceId;
//            player.RankServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Rank)).InstanceId;
//            player.PaiMaiServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.PaiMai)).InstanceId;
//            player.ActivityServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Activity)).InstanceId;
//            player.TeamServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Team)).InstanceId;
//            player.FriendServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Friend)).InstanceId;
//            player.UnionServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Union)).InstanceId;

//            reply();
//        }
//    }
//}
