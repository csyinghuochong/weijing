using UnityEngine;

namespace ET
{
    [Event]
    public class HappyInfo_OnHappyInfo : AEventClass<EventType.HappyInfo>
    {
        protected override void Run(object cls)
        {
            EventType.HappyInfo args = cls as EventType.HappyInfo;

            UI uihappyMain = UIHelper.GetUI(args.ZoneScene, UIType.UIHappyMain);
            if (uihappyMain == null)
            {
                return;
            }
            uihappyMain.GetComponent<UIHappyMainComponent>().OnUpdateUI(args.m2C_Battle);
        }
    }
}