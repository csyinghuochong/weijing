using UnityEngine;

namespace ET
{
    [Event]
    public class Login_OnRelinkSucess : AEventClass<EventType.RelinkSucess>
    {
        protected override void Run(object cls)
        {
            EventType.RelinkSucess relinkSucess = cls as EventType.RelinkSucess;
            RunAsync(relinkSucess).Coroutine();
        }

        private async ETTask RunAsync(EventType.RelinkSucess relinkSucess)
        {
            Scene zoneScene = relinkSucess.ZoneScene;
            zoneScene.GetComponent<SessionComponent>().Session.Send(new C2M_RefreshUnitRequest());
            await NetHelper.RequestUserInfo(zoneScene, true);
            await NetHelper.RequestUnitInfo(zoneScene, true);

            UI uIMain = UIHelper.GetUI(zoneScene, UIType.UIMain);
            if (uIMain != null)
            {
                uIMain.GetComponent<UIMainComponent>().OnRelinkUpdate();
            }
            UI uiRecharge = UIHelper.GetUI(zoneScene, UIType.UIRecharge);
            if (uiRecharge != null)
            {
                uiRecharge.GetComponent<UIRechargeComponent>().OnRelinkUpdate();
            }
        }
    }
}
