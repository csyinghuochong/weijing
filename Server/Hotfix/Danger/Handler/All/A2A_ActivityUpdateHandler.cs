using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public  class A2A_ActivityUpdateHandler : AMActorRpcHandler<Scene, A2A_ActivityUpdateRequest, A2A_ActivityUpdateResponse>
    {
        protected override async ETTask Run(Scene scene, A2A_ActivityUpdateRequest request, A2A_ActivityUpdateResponse response, Action reply)
        {
            int hour = request.Hour;
            switch (scene.SceneType)
            {
                case SceneType.Gate:
                    Log.Console($"Gate定时刷新: {scene.DomainZone()} {hour} ");
                    LogHelper.LogWarning($"Gate定时刷新: {scene.DomainZone()} {hour} ", true);
                    if (hour == 0)
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
                        ActorLocationSenderComponent.Instance.Send(players[i].UnitId, new G2M_ActivityUpdate() { ActivityType = hour });
                    }
                    break;
                case SceneType.Map:

                    Log.Console($"{scene.Name}  {scene.DomainZone()}  request.FunctionType: {request.FunctionId} {request.FunctionType}");

                    if (request.FunctionId == 1057 && request.FunctionType == 1)
                    {
                        for (int npcid = 20099007; npcid <= 20099010; npcid++ )
                        {
                            UnitFactory.CreateNpc(scene, npcid);
                        }
                    }
                    if (request.FunctionId == 1057 && request.FunctionType == 2)
                    {
                        List<Unit> units = UnitHelper.GetUnitList( scene, UnitType.Npc );
                        for (int i = units.Count - 1; i >= 0; i--)
                        {
                            if (units[i].ConfigId >= 20099007 && units[i].ConfigId <= 20099010)
                            {
                                scene.GetComponent<UnitComponent>().Remove(units[i].Id);
                            }
                        }

                        for (int i = 0; i < ConfigHelper.TurtleList.Count; i++)
                        {
                            UnitFactory.CreateNpc(scene, ConfigHelper.TurtleList[i]);
                        }
                       
                        //UnitFactory.CreateMonster(scene, 90000014, new UnityEngine.Vector3(-5.29f, -7.65f, -52.06f), new CreateMonsterInfo());
                        //UnitFactory.CreateMonster(scene, 90000015, new UnityEngine.Vector3(-2.02f, -7.65f, -52.06f), new CreateMonsterInfo());
                        //UnitFactory.CreateMonster(scene, 90000016, new UnityEngine.Vector3(-0.56f, -7.65f, -52.06f), new CreateMonsterInfo());
                    }
                    break;
                case SceneType.Happy:
                    if (request.FunctionId == 1055 && request.FunctionType == 1)
                    {
                        scene.GetComponent<HappySceneComponent>().OnHappyBegin();
                    }
                    if (request.FunctionId == 1055 && request.FunctionType == 2)
                    {
                        scene.GetComponent<HappySceneComponent>().OnHappyOver();
                    }
                    break;
                case SceneType.Rank:
                    Log.Console($"排行榜定时刷新: {scene.DomainZone()} {hour}");
                    LogHelper.LogWarning($"排行榜定时刷新: {scene.DomainZone()} {hour}", true);
                    if (hour == 0)
                    {
                        scene.GetComponent<RankSceneComponent>().OnZeroClockUpdate();
                    }
                    if (hour == 12)
                    {
                        scene.GetComponent<RankSceneComponent>().OnHour12Update();
                    }
                    if (request.FunctionId == 1052 && request.FunctionType == 1)
                    {
                        scene.GetComponent<RankSceneComponent>().OnShowLieBegin();
                    }
                    if (request.FunctionId == 1052 && request.FunctionType == 2)
                    {
                        scene.GetComponent<RankSceneComponent>().OnShowLieOver().Coroutine();
                    }
                    if(request.FunctionId == 1044 && request.FunctionType == 2)
                    {
                        scene.GetComponent<RankSceneComponent>().OnUnionRaceOver().Coroutine();
                    }
                    break;
                case SceneType.Arena:
                    Log.Console($"Arena定时刷新: {scene.DomainZone()} {hour}");
                    LogHelper.LogWarning($"Arena定时刷新: {scene.DomainZone()} {hour}", true);
                    if (hour == 0)
                    {
                        scene.GetComponent<ArenaSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.Union:
                    Log.Console($"Union定时刷新: {scene.DomainZone()} {hour}");
                    LogHelper.LogWarning($"Union定时刷新: {scene.DomainZone()} {hour}", true);
                    if (hour == 0)
                    {
                        scene.GetComponent<UnionSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.Battle:
                    Log.Console($"Battle定时刷新: {scene.DomainZone()} {hour}");
                    LogHelper.LogWarning($"Battle定时刷新: {scene.DomainZone()} {hour}", true);
                    if (hour == 0)
                    {
                        scene.GetComponent<BattleSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.PaiMai:
                    //更新快捷购买列表价格
                    Log.Console($"PaiMai定时刷新: {scene.DomainZone()} {hour}");
                    LogHelper.LogWarning($"PaiMai定时刷新: {scene.DomainZone()} {hour}", true);
                    if (hour == 0)
                    {
                        scene.GetComponent<PaiMaiSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.DBCache:
                    if (!ComHelp.IsInnerNet())
                    {
                        scene.GetComponent<DBCacheComponent>().CheckUnitCacheList();
                    }
                    break;
                case SceneType.Solo:
                    if (hour == 0)
                    {
                        scene.GetComponent<SoloSceneComponent>().OnZeroClockUpdate();
                    }
                    break;
                case SceneType.FubenCenter:
                    if (hour == 0)
                    {
                        Log.Console("FubenCenter定时刷新: {scene.DomainZone()} {hour}");
                        LogHelper.LogWarning($"FubenCenter定时刷新: {scene.DomainZone()} {hour}", true);
                        FubenCenterComponent fubenCenter = scene.GetComponent<FubenCenterComponent>();
                        foreach (var item in fubenCenter.Children)
                        {
                            item.Value.GetComponent<YeWaiRefreshComponent>().OnZeroClockUpdate(request.OpenDay);
                        }
                    }
                    break;
                case SceneType.AccountCenter:
                    if (hour == 0)
                    {
                        scene.GetComponent<FangChenMiComponent>().CheckHoliday().Coroutine();
                    }

                    LogHelper.CheckLogSize();
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
