using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public  class A2A_ActivityUpdateHandler : AMActorRpcHandler<Scene, A2A_ActivityUpdateRequest, A2A_ActivityUpdateResponse>
    {
        protected override async ETTask Run(Scene scene, A2A_ActivityUpdateRequest request, A2A_ActivityUpdateResponse response, Action reply)
        {
            int activityType = request.ActivityType;
            switch (scene.SceneType)
            {
                case SceneType.Gate:
                    if (activityType == 0)
                    {
                        PrintAllEntity();
                    }
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
                    if (activityType == 0)
                    {
                        scene.GetComponent<RankSceneComponent>().OnZeroClockUpdate();
                    }
                    if (activityType == 12)
                    {
                        scene.GetComponent<RankSceneComponent>().OnHour12Update();
                    }
                    break;
                case SceneType.Arena:
                    if (activityType == 0)
                    {
                        scene.GetComponent<ArenaSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.Union:
                    break;
                case SceneType.Battle:
                    if (activityType == 0)
                    {
                        scene.GetComponent<BattleSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.PaiMai:
                    //更新快捷购买列表价格
                    if (activityType == 0)
                    {
                        scene.GetComponent<PaiMaiSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.FubenCenter:
                    if (activityType == 0)
                    {
                        FubenCenterComponent fubenCenter = scene.GetComponent<FubenCenterComponent>();
                        foreach (var item in fubenCenter.Children)
                        {
                            item.Value.GetComponent<YeWaiRefreshComponent>().OnZeroClockUpdate(request.OpenDay);
                        }
                    }
                    break;
                case SceneType.AccountCenter:
                    if (activityType == 0)
                    {
                        scene.GetComponent<FangChenMiComponent>().CheckHoliday().Coroutine();
                    }
                    if (activityType == 1)
                    {
                        scene.GetComponent<AccountCenterComponent>().GenerateSerials(1);
                    }
                    break;
                default:
                    break;
            }

            reply();
            await ETTask.CompletedTask;
        }

        private void PrintAllEntity()
        {
            Log.Info("PrintAllEntity");
            Log.Info(EventSystem.Instance.ToString());
            Log.Info(ObjectPool.Instance.ToString());
        }
    }
}
