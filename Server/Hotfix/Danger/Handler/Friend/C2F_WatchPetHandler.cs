using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2F_WatchPetHandler : AMActorRpcHandler<Scene, C2F_WatchPetRequest, F2C_WatchPetResponse>
    {
        protected override async ETTask Run(Scene scene, C2F_WatchPetRequest request, F2C_WatchPetResponse response, Action reply)
        {
            long dbCacheId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;
            D2G_GetComponent d2GGetUnit_1 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UnitID, Component = DBHelper.PetComponent });
            PetComponent petComponent = d2GGetUnit_1.Component as PetComponent;
            if (petComponent == null)
            {
                response.Error = ErrorCode.ERR_Error;
                reply();
                return;
            }


            D2G_GetComponent d2GGetUnit_2 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UnitID, Component = DBHelper.BagComponent });
            BagComponent bagComponents = d2GGetUnit_2.Component as BagComponent;

            response.RolePetInfos = petComponent.GetPetInfo( request.PetId );
            response.PetHeXinList = bagComponents.PetHeXinList;


            reply();
            await ETTask.CompletedTask;
        }
    }
}
