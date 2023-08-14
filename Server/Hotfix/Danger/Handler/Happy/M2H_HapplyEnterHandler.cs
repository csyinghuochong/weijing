using Alipay.AopSdk.Core.Domain;
using System;


namespace ET
{

    [ActorMessageHandler]
    public class M2H_HapplyEnterHandler : AMActorRpcHandler<Scene, M2H_HapplyEnterRequest, H2M_HapplyEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2H_HapplyEnterRequest request, H2M_HapplyEnterResponse response, Action reply)
        {
            HappySceneComponent happySceneComponent = scene.GetComponent<HappySceneComponent>();

            if (happySceneComponent.FubenInstanceId == 0)
            {
                int sceneId = request.SceneId;
                long fubenid = IdGenerater.Instance.GenerateId();
                long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
                Scene fubnescene = SceneFactory.Create(scene, fubenid, fubenInstanceId, scene.DomainZone(), "Happy" + fubenid.ToString(), SceneType.Fuben);
                TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
                MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
                mapComponent.SetMapInfo((int)SceneTypeEnum.Happy, sceneId, 0);
                mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(sceneId).MapID.ToString();
                Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
                FubenHelp.CreateNpc(fubnescene, sceneId);

                happySceneComponent.FubenInstanceId = fubenInstanceId;
            }

            response.FubenInstanceId = happySceneComponent.FubenInstanceId;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
