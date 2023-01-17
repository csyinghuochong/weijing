using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIDeleteAccountComponent : Entity, IAwake
    {
        public GameObject account;
        public GameObject password;
        public GameObject registerButton;
        public GameObject Btn_Close;

    }

    [ObjectSystem]
    public class UIDeleteAccountComponentAwake : AwakeSystem<UIDeleteAccountComponent>
    {

        public override void Awake(UIDeleteAccountComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();


            self.account = rc.Get<GameObject>("InputField");
            self.password = rc.Get<GameObject>("InputField2");
            self.registerButton = rc.Get<GameObject>("BtnCreate");
            self.Btn_Close = rc.Get<GameObject>("BtnCloseUI");
            self.registerButton.GetComponent<Button>().onClick.AddListener(() => { self.OnSendRegister().Coroutine(); });
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseEquip(); });
        }
    }

    public static class UIDeleteAccountComponentSystem
    {
        public static async ETTask OnSendRegister(this UIDeleteAccountComponent self)
        {
            string account = self.account.GetComponent<InputField>().text;
            account = account.Replace(" ", "");
            string password = self.password.GetComponent<InputField>().text;
            password = password.Replace(" ", "");

            if (!StringHelper.IsSpecialChar(account))
            {
                FloatTipManager.Instance.ShowFloatTip("请重新输入账号！");
                return;
            }
            int length = account.Length;
            if (length < 5 || length > 20)
            {
                FloatTipManager.Instance.ShowFloatTip("账号长度为5-20！");
                return;
            }

            if (!StringHelper.IsSpecialChar(password))
            {
                FloatTipManager.Instance.ShowFloatTip("请重新输入密码！");
                return;
            }
            length = password.Length;
            if (length < 5 || length > 20)
            {
                FloatTipManager.Instance.ShowFloatTip("密码长度为5-20！");
                return;
            }

            C2A_DeleteAccountRequest request = new C2A_DeleteAccountRequest() {  Account = account, Password = password };
            A2C_DeleteAccountResponse response = (A2C_DeleteAccountResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                
            UIHelper.Remove(self.ZoneScene(), UIType.UIDeleteAccount);
        }

        //关闭界面
        public static void OnCloseEquip(this UIDeleteAccountComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIDeleteAccount);
        }
    }

}
