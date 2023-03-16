using UnityEngine;

namespace ET
{

    [Event]
    public class JingLing_OnJingLingGet : AEventClass<EventType.JingLingGet>
    {
        protected override void Run(object cls)
        {
            EventType.JingLingGet args = cls as EventType.JingLingGet;
            RunAnsyc(args.ZoneScene, args.JingLingId).Coroutine();
        }

        private async ETTask RunAnsyc(Scene zoneScene, int jinginglid)
        {
            UI uijget = UIHelper.GetUI(zoneScene, UIType.UIJingLingGet);
            if (uijget != null)
            {
                return;
            }
            uijget = await UIHelper.Create(zoneScene, UIType.UIJingLingGet);
            uijget.GetComponent<UIJingLingGetComponent>().OnInitUI(jinginglid);
        }
    }
}
