using UnityEngine;

namespace ET
{

    [Event]
    public class OneChallenge_OnApply : AEventClass<EventType.UIOneChallenge>
    {
        protected override void Run(object cls)
        {
            EventType.UIOneChallenge args = cls as EventType.UIOneChallenge;

            if (args.m2C_OneChallenge.Operatate == 1)
            {
                PopupTipHelp.OpenPopupTip(args.ZoneScene, "挑战", $"{args.m2C_OneChallenge.OtherName}向你发起挑战，是否接受?", () =>
                {
                    RunAsync(args).Coroutine();
                }, null).Coroutine();
            }
            if (args.m2C_OneChallenge.Operatate == 2)
            {
                MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();
                if (mapComponent.SceneTypeEnum != SceneTypeEnum.MainCityScene)
                {
                    return;
                }
                int sceneId = BattleHelper.GetSceneIdByType(SceneTypeEnum.OneChallenge);
                EnterFubenHelp.RequestTransfer(  args.ZoneScene, SceneTypeEnum.OneChallenge, sceneId, 0, args.m2C_OneChallenge.OtherId.ToString()).Coroutine();
            }
        }

        private async ETTask RunAsync(EventType.UIOneChallenge args)
        { 
            MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.MainCityScene)
            {
                return;
            }
            C2M_OneChallengeRequest request = new C2M_OneChallengeRequest() { Operatate = 2, OtherId = args.m2C_OneChallenge.OtherId };
            M2C_OneChallengeResponse response = (M2C_OneChallengeResponse)await args.ZoneScene.GetComponent<SessionComponent>().Session.Call(request);
            await ETTask.CompletedTask;
        }
    }

}