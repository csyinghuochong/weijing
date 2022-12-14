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
        }
    }
}
