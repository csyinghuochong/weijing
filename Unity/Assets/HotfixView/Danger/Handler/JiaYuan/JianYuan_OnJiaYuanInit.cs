using UnityEngine;

namespace ET
{

    [Event]
    public class JianYuan_OnJiaYuanInit : AEventClass<EventType.JiaYuanInit>
    {
        protected override void Run(object cls)
        {
            EventType.JiaYuanInit args = cls as EventType.JiaYuanInit;
            Scene zoneScene = args.ZoneScene;
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.JiaYuan)
            {
                return;
            }

            Scene curscene = zoneScene.CurrentScene();
            curscene.GetComponent<JiaYuanViewComponent>().OnInitUI();
        }
    }
}
