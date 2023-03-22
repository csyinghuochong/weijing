using UnityEngine;

namespace ET
{

    [Event]
    public class JiaYuan_OnJiaYuanUpdate : AEventClass<EventType.JiaYuanUpdate>
    {
        protected override void Run(object cls)
        {
            EventType.JiaYuanUpdate args = cls as EventType.JiaYuanUpdate;
            Scene zoneScene = args.ZoneScene;
            MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.JiaYuan)
            {
                return;
            }

            Scene curscene = zoneScene.CurrentScene();
            curscene.GetComponent<JiaYuanViewComponent>().OnUpdateUI();

            UI ui = UIHelper.GetUI(zoneScene, UIType.UIJiaYuanBag);
            if (ui!=null)
            {
                ui.GetComponent<UIJiaYuanBagComponent>().OnUpdateUI();
            }
        }
    }
}
