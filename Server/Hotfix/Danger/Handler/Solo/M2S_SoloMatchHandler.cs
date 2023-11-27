using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2S_SoloMatchHandler : AMActorRpcHandler<Scene, M2S_SoloMatchRequest, S2M_SoloMatchResponse>
    {
        protected override async ETTask Run(Scene scene, M2S_SoloMatchRequest request, S2M_SoloMatchResponse response, Action reply)
        {
            //收到匹配服务器发来的消息进行匹配处理


            //给当前solo场景加入匹配的玩家
            SoloSceneComponent soloSceneComponent = scene.GetComponent<SoloSceneComponent>();

            response.Error = soloSceneComponent.OnJoinMatch(request.SoloPlayerInfo);


            //添加数据缓存
            soloSceneComponent.OnAddSoloDateList(request.SoloPlayerInfo.UnitId, request.SoloPlayerInfo.Name, request.SoloPlayerInfo.Occ);

            if (!soloSceneComponent.PlayerCombatList.ContainsKey(request.SoloPlayerInfo.UnitId))
            {
                soloSceneComponent.PlayerCombatList.Add(request.SoloPlayerInfo.UnitId, request.SoloPlayerInfo.Combat);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
