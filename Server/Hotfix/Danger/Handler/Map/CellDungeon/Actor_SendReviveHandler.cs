using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_SendReviveHandler : AMActorLocationRpcHandler<Unit, Actor_SendReviveRequest, Actor_SendReviveResponse>
    {
        protected override async ETTask Run(Unit unit, Actor_SendReviveRequest request, Actor_SendReviveResponse response, Action reply)
        {
            MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();

            if (request.Revive)
            {
                string reviveCost = GlobalValueConfigCategory.Instance.Get(5).Value;
                bool success = unit.GetComponent<BagComponent>().OnCostItemData(reviveCost);
                if (!success)
                {
                    response.Error = ErrorCode.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }


                unit.SetBornPosition(unit.Position, true);
                unit.GetComponent<HeroDataComponent>().OnRevive();
                unit.GetComponent<ChengJiuComponent>().OnRevive();
            }
            else
            {
                if (mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon)
                {
                    TeamDungeonComponent teamDungeonComponent = unit.DomainScene().GetComponent<TeamDungeonComponent>();
                    unit.SetBornPosition(teamDungeonComponent.BossDeadPosition, true);
                }
                else
                {
                    SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(mapComponent.SceneId);

                    if (unit.GetBattleCamp() == CampEnum.CampPlayer_1)
                    {
                        unit.SetBornPosition(new Vector3(sceneConfig.InitPos[0] * 0.01f, sceneConfig.InitPos[1] * 0.01f, sceneConfig.InitPos[2] * 0.01f), true);
                    }
                    else
                    {
                        unit.SetBornPosition(new Vector3(sceneConfig.InitPos[3] * 0.01f, sceneConfig.InitPos[4] * 0.01f, sceneConfig.InitPos[5] * 0.01f), true);
                    }
                }

                unit.GetComponent<HeroDataComponent>().OnRevive();
            }

            unit.TriggerTeamBuff(mapComponent.SceneTypeEnum);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
