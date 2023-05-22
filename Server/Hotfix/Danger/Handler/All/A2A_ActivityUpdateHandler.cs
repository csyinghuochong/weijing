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
                    LogHelper.LogWarning($"Gate定时刷新: {activityType}", true);
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
                    LogHelper.LogWarning($"排行榜定时刷新: {activityType}", true);
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
                    LogHelper.LogWarning($"Arena定时刷新: {activityType}", true);
                    if (activityType == 0)
                    {
                        scene.GetComponent<ArenaSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.Union:
                    LogHelper.LogWarning($"Union定时刷新: {activityType}", true);
                    if (activityType == 0)
                    {
                        scene.GetComponent<UnionSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.Battle:
                    LogHelper.LogWarning($"Battle定时刷新: {activityType}", true);
                    if (activityType == 0)
                    {
                        scene.GetComponent<BattleSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.PaiMai:
                    //更新快捷购买列表价格
                    LogHelper.LogWarning($"PaiMai定时刷新: {activityType}", true);
                    if (activityType == 0)
                    {
                        scene.GetComponent<PaiMaiSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.Solo:
                    if (activityType == 0)
                    {
                        scene.GetComponent<SoloSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.FubenCenter:
                    if (activityType == 0)
                    {
                        LogHelper.LogWarning($"FubenCenter定时刷新: {activityType}", true);
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
