using UnityEngine;

namespace ET
{

    [Event]
    public class JiaYuan_OnJiaYuanUproot : AEventClass<EventType.JiaYuanUproot>
    {
        protected override void Run(object cls)
        {
            EventType.JiaYuanUproot args = cls as EventType.JiaYuanUproot;
            Scene zoneScene = args.ZoneScene;
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.JiaYuan)
            {
                return;
            }
            Scene curscene = zoneScene.CurrentScene();
            curscene.GetComponent<JiaYuanViewComponent>().OnUprootPlan(args.CellIndex);
        }
    }
}
