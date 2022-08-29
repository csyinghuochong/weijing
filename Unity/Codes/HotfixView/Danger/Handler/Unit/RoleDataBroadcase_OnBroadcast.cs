using UnityEngine;

namespace ET
{

    [Event]
    public class RoleDataBroadcase_OnBroadcast : AEventClass<EventType.RoleDataBroadcase>
    {
        protected override void  Run(object cls)
        {
            EventType.RoleDataBroadcase args = cls as EventType.RoleDataBroadcase;
            switch (args.UserDataType)
            {
                case UserDataType.Name:
                case UserDataType.UnionName:
                case UserDataType.Lv:
                    args.Unit.GetComponent<HeroHeadBarComponent>().UpdateShow();
                    break;
                case UserDataType.StallName:
                    args.Unit.GetComponent<HeroHeadBarComponent>().UpdateStallName(args.UserDataValue);
                    break;
            }
        }
    }
}
