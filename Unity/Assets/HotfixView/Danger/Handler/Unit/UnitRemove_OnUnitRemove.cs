using UnityEngine;


namespace ET
{
    [Event]
    public class UnitRemove_OnUnitRemove : AEventClass<EventType.UnitRemove>
    {

        protected override void Run(object cls)
        {
            EventType.UnitRemove args = cls as EventType.UnitRemove;
            bool removelock = args.ZoneScene.GetComponent<LockTargetComponent>().OnUnitRemove(args.RemoveIds);

            if (removelock)
            {
                UI uimain = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
                uimain.GetComponent<UIMainComponent>().UIMainSkillComponent.UpdateButton_ZhuaPu(false);
            }
        }

    }
}