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

            AccountInfoComponent accountInfoComponent = zoneScene.GetComponent<AccountInfoComponent>();
            string info = PlayerPrefsHelp.GetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString());
            if (!string.IsNullOrEmpty(info))
            {
                NetHelper.SendIOSPayVerifyRequest(zoneScene, info);
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), string.Empty);
                FloatTipManager.Instance.ShowFloatTip("重连成功_IOS！");
            }
            else
            {
                FloatTipManager.Instance.ShowFloatTip("重连成功！");
            }

            UI uIMain = UIHelper.GetUI(zoneScene, UIType.UIMain);
            if (uIMain != null)
            {
                uIMain.GetComponent<UIMainComponent>().OnRelinkUpdate();
            }
            //UI uiRecharge = UIHelper.GetUI(zoneScene, UIType.UIRecharge);
            //if (uiRecharge != null)
            //{
            //    uiRecharge.GetComponent<UIRechargeComponent>().OnRelinkUpdate();
            //}
        }
    }
}
