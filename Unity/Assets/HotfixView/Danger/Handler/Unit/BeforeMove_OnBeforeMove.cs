using UnityEngine;

namespace ET
{
    public class BeforeMove_OnBeforeMove : AEventClass<EventType.BeforeMove>
    {
        protected override void Run(object cls)
        {
            EventType.BeforeMove args = (EventType.BeforeMove)cls;
            UI uI = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
            uI.GetComponent<UIMainComponent>()?.OnMoveStart();

            MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.JiaYuan)
            {
                UIHelper.Remove(args.ZoneScene, UIType.UIJiaYuanMenu);
                JiaYuanViewComponent jiaYuanViewComponent = args.ZoneScene.CurrentScene().GetComponent<JiaYuanViewComponent>();
                jiaYuanViewComponent.OnSelectCancel();
            }
        }
    }
}
