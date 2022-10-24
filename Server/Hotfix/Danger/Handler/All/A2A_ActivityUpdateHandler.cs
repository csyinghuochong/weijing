using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public  class A2A_ActivityUpdateHandler : AMActorRpcHandler<Scene, A2A_ActivityUpdateRequest, A2A_ActivityUpdateResponse>
    {
        protected override async ETTask Run(Scene scene, A2A_ActivityUpdateRequest request, A2A_ActivityUpdateResponse response, Action reply)
        {
            if (request.ActivityType == 0)
            {
                ActivityUpdate_Day(scene);
            }
            if (request.ActivityType > 0)
            {
                ActivityUpdate_Hour(scene, request.ActivityType);
            }

            reply();
            await ETTask.CompletedTask;
        }

        private void PrintAllEntity()
        {
            Log.Info("PrintAllEntity");
            Log.Info(EventSystem.Instance.ToString());
        }

        private void ActivityUpdate_Hour(Scene scene, int activityType)
        {
            switch (scene.SceneType)
            {
                case SceneType.Gate:
                    Player[] players = scene.GetComponent<PlayerComponent>().GetAll();
                    for (int i = 0; i < players.Length; i++)
                    {
                        if (players[i].PlayerState != PlayerState.Game)
                        {
                            continue;
                        }
                        ActorLocationSenderComponent.Instance.Send(players[i].UnitId, new G2M_ActivityUpdate() { ActivityType = activityType });
                    }
                    break;
                case SceneType.Rank:
                    if (activityType == 12)
                    {
                        scene.GetComponent<RankSceneComponent>().OnHour12Update();
                    }
                    break;
                default:
                    break;
            }
        }

        private void ActivityUpdate_Day(Scene scene)
        {
            switch (scene.SceneType)
            {
                case SceneType.Map:
                    PrintAllEntity();
                    break;
                case SceneType.Gate:
                    PrintAllEntity();
                    Player[] players = scene.GetComponent<PlayerComponent>().GetAll();
                    for (int i = 0; i < players.Length; i++)
                    {
                        if (players[i].PlayerState != PlayerState.Game)
                        {
                            continue;
                        }
                        ActorLocationSenderComponent.Instance.Send(players[i].UnitId, new G2M_ActivityUpdate() { ActivityType = 0 });
                    }
                    break;
                case SceneType.PaiMai:
                    //更新快捷购买列表价格
                    scene.GetComponent<PaiMaiSceneComponent>().OnZeroClockUpdate();
                    break;
                case SceneType.Rank:
                    scene.GetComponent<RankSceneComponent>().OnZeroClockUpdate();
                    break;
                case SceneType.Account:
                    scene.GetComponent<FangChenMiComponent>().CheckHoliday().Coroutine();
                    break;
            }
        }

    }
}
