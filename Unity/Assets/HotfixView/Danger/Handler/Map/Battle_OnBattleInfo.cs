using UnityEngine;

namespace ET
{

    [Event]
    public class Battle_OnBattleInfo : AEventClass<EventType.BattleInfo>
    {
        protected override void Run(object cls)
        {
            EventType.BattleInfo args = cls as EventType.BattleInfo;

            UI uiBattleMain = UIHelper.GetUI(args.ZoneScene, UIType.UIBattleMain);
            if (uiBattleMain == null)
            {
                return;
            }
            uiBattleMain.GetComponent<UIBattleMainComponent>().OnUpdateUI(args.m2C_Battle);
        }
    }
}
