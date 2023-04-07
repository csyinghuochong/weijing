using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UISerialComponent : Entity, IAwake
    {
        public GameObject InputField_Code;
        public GameObject ButtonGet;
        public GameObject ButtonOk;

        public float LastTime;
    }

    public class UISerialComponentAwake : AwakeSystem<UISerialComponent>
    {
        public override void Awake(UISerialComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.InputField_Code = rc.Get<GameObject>("InputField_Code");

            self.ButtonGet = rc.Get<GameObject>("ButtonGet");
            ButtonHelp.AddListenerEx(self.ButtonGet, () => { self.OnButtonGet().Coroutine(); });

            self.ButtonOk = rc.Get<GameObject>("ButtonOk");
            ButtonHelp.AddListenerEx(self.ButtonOk, self.OnButtonOk);
        }
    }

    public static class UISerialComponentSystem
    {

        public static async ETTask OnButtonGet(this UISerialComponent self)
        {
            if (Time.time - self.LastTime < 1f)
            {
                return;
            }

            string serial = self.InputField_Code.GetComponent<InputField>().text;
            if (string.IsNullOrEmpty(serial))
            {
                return;
            }
            self.LastTime = Time.time;
            C2M_SerialReardRequest  request = new C2M_SerialReardRequest() { SerialNumber = serial };
            M2C_SerialReardResponse response = (M2C_SerialReardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
        }

        public static HotVersion GetHotVersion(this UISerialComponent self)
        {
            var path_1 = ABPathHelper.GetTextPath("Version");
            var request = libx.Assets.LoadAsset(path_1, typeof(TextAsset));
            TextAsset textAsset3 = request.asset as TextAsset;
            return JsonHelper.FromJson<HotVersion>(textAsset3.text);
        }

        public static void OnButtonOk(this UISerialComponent self)
        {
            HotVersion hotVersion = self.GetHotVersion();

#if UNITY_IPHONE || UNITY_IOS
            Application.OpenURL(hotVersion.IOS_URL);
#else
            Application.OpenURL(hotVersion.Apk_URL);
#endif
        }

    }
}
