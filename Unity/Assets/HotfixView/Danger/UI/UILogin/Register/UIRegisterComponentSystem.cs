using UnityEngine;
using UnityEngine.UI;

namespace ET
{


    public class UIRegisterComponentAwakeSystem : AwakeSystem<UIRegisterComponent>
    {

        public override void Awake(UIRegisterComponent self)
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

    public static class UIRegisterComponentSystem
    {
        public static async ETTask OnSendRegister(this UIRegisterComponent self)
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
            if (length < 5|| length > 20)
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

            int errorCode = await LoginHelper.Register(self.DomainScene(),GlobalHelp.IsOutNetMode, GlobalHelp.VersionMode, account, password);
            if (errorCode == ErrorCore.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTipDi("注册成功！");
                UIHelper.Remove(self.ZoneScene(), UIType.UIRegister);
            }
        }

        //关闭界面
        public static void OnCloseEquip(this UIRegisterComponent self)
        {
            UIHelper.Remove(self.DomainScene(),UIType.UIRegister);
        }
    }

}
