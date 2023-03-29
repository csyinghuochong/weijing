using UnityEngine;

namespace ET
{

    [Event]
    public class JiaYuan_OnJiaYuanOpen : AEventClass<EventType.JiaYuanOpen>
    {
        protected override void Run(object cls)
        {
            EventType.JiaYuanOpen args = cls as EventType.JiaYuanOpen;
            Scene zoneScene = args.ZoneScene;
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.JiaYuan)
            {
                return;
            }

            Scene curscene = zoneScene.CurrentScene();
            curscene.GetComponent<JiaYuanViewComponent>()?.OnOpenPlan(args.CellIndex);
        }
    }
}
