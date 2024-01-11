using UnityEngine;

namespace ET
{

    [Event]
    public class OneChallenge_OnApply : AEventClass<EventType.UIOneChallenge>
    {
        protected override void Run(object cls)
        {
            EventType.UIOneChallenge args = cls as EventType.UIOneChallenge;
            PopupTipHelp.OpenPopupTip( args.ZoneScene, "挑战", $"{args.m2C_OneChallenge.OtherName}向你发起挑战，是否接受?", ()=>
            {
                RunAsync(args).Coroutine();
            }, null).Coroutine();
        }


        private async ETTask RunAsync(EventType.UIOneChallenge args)
        { 
            MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.MainCityScene)
            {
                return;
            }
            await ETTask.CompletedTask;
        }
    }

}