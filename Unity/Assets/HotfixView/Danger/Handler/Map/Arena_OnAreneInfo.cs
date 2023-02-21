using UnityEngine;

namespace ET
{

    [Event]
    public class Arena_OnAreneInfo : AEventClass<EventType.AreneInfo>
    {
        protected override void Run(object cls)
        {
            EventType.AreneInfo args = cls as EventType.AreneInfo;

            UI uiBattleMain = UIHelper.GetUI(args.ZoneScene, UIType.UIArenaMain);
            if (uiBattleMain == null)
            {
                return;
            }
            uiBattleMain.GetComponent<UIArenaMainComponent>().OnUpdateUI(args.m2C_Battle);
        }
    }
}
