using UnityEngine;

namespace ET
{

    [Event]
    public class OneChallenge_OnApply : AEventClass<EventType.UIOneChallenge>
    {
        protected override  void  Run(object cls)
        {
            EventType.UIOneChallenge args = cls as EventType.UIOneChallenge;

            if (args.m2C_OneChallenge.Operatate == 1)
            {
                //被挑战的人晚一秒进入角斗场。。。
                args.ZoneScene.GetComponent<BattleMessageComponent>().OneChallengeOtherId = args.m2C_OneChallenge.OtherId;
                PopupTipHelp.OpenPopupTip(args.ZoneScene, GameSettingLanguge.LoadLocalization("挑战"), string.Format(GameSettingLanguge.LoadLocalization("{0}向你发起挑战，是否接受?"), args.m2C_OneChallenge.OtherName), () =>
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
                RunAsync_2(args).Coroutine();
            }
        }

        private async ETTask RunAsync_2(EventType.UIOneChallenge args)
        {
            int sceneId = BattleHelper.GetSceneIdByType(SceneTypeEnum.OneChallenge);
            long waittimer = args.ZoneScene.GetComponent<BattleMessageComponent>().OneChallengeOtherId > 0 ? 1000 : 0;
            args.ZoneScene.GetComponent<BattleMessageComponent>().OneChallengeOtherId = 0;
            await TimerComponent.Instance.WaitAsync(waittimer);
            EnterFubenHelp.RequestTransfer(args.ZoneScene, SceneTypeEnum.OneChallenge, sceneId, 0, args.m2C_OneChallenge.OtherId.ToString()).Coroutine();
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