using UnityEngine;

namespace ET
{
    public class BeforeSkill_OnBeforeSkill : AEventClass<EventType.BeforeSkill>
    {
        protected override void Run(object cls)
        {
            EventType.BeforeSkill args = (EventType.BeforeSkill)cls;
            UI uI = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
            uI.GetComponent<UIMainComponent>().OnBeforeSkill();
        }
    }
}
