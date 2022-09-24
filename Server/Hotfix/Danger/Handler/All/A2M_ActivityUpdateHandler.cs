using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public  class A2M_ActivityUpdateHandler : AMActorRpcHandler<Scene, A2M_ActivityUpdateRequest, M2A_ActivityUpdateResponse>
    {

        private void PrintAllEntity()
        {
            Log.Info("PrintAllEntity");
            Log.Info(EventSystem.Instance.ToString());
        }

        private void ActivityUpdate_Hour(Scene scene)
        {
            switch (scene.SceneType)
            {
                case SceneType.Gate:
                    PrintAllEntity();
                    Player[] players = scene.GetComponent<PlayerComponent>().GetAll();
                    for (int i = 0; i < players.Length; i++)
                    {
                        if (players[i].PlayerState != PlayerState.Game)
                        {
                            continue;
                        }
                        ActorLocationSenderComponent.Instance.Send(players[i].UnitId, new G2M_ActivityUpdate() {  ActivityType = 12 });
                    }
                    break;
                case SceneType.Rank:
                    scene.GetComponent<RankSceneComponent>().OnHour12Update();
                    break;
                default:
                    break;
            }
        }

        private void ActivityUpdate_WorldLv(Scene scene)
        {
            switch (scene.SceneType)
            {
                case SceneType.Map:
                    Dictionary<long, Entity> sceneList = scene.Parent.Children;
                    foreach (var key in sceneList)
                    {
                        Scene sceneItem = key.Value as Scene;
                        if (sceneItem == null)
                        {
                            continue;
                        }
                        if (sceneItem.SceneType == SceneType.Map
                            || sceneItem.SceneType == SceneType.Fuben)
                        {
                            Log.Info($"{sceneItem.SceneType}  {sceneItem.InstanceId}");
                        }
                    }
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

        protected override async ETTask Run(Scene scene, A2M_ActivityUpdateRequest request, M2A_ActivityUpdateResponse response, Action reply)
        {
            if (request.ActivityType == 0)
            {
                ActivityUpdate_Day(scene);
            }
            if (request.ActivityType == 1)
            {
                ActivityUpdate_WorldLv(scene);
            }
            if (request.ActivityType == 12)
            {
                ActivityUpdate_Hour(scene);
            }

            reply();
            await ETTask.CompletedTask;
        }

    }
}
