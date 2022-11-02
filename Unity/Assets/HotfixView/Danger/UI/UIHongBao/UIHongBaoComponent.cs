using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIHongBaoComponent : Entity, IAwake
    {
        public GameObject Button_Back;
        public GameObject Text_Amount;
        public GameObject Button_Open;
        public GameObject JiaGeSet;
        public GameObject DiSet;
        
    }

    [ObjectSystem]
    public class UIHongBaoComponentAwakeSystem : AwakeSystem<UIHongBaoComponent>
    {
        public override void Awake(UIHongBaoComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Button_Open = rc.Get<GameObject>("Button_Open");
            ButtonHelp.AddListenerEx(self.Button_Open, () => { self.OnButton_Open().Coroutine(); });

            self.Button_Back = rc.Get<GameObject>("Button_Back");
            self.Button_Back.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIHongBao);  });

            self.Text_Amount = rc.Get<GameObject>("Text_Amount");

            self.JiaGeSet = rc.Get<GameObject>("JiaGeSet");
            self.DiSet = rc.Get<GameObject>("DiSet");
            
        }
    }

    public static class UIHongBaoComponentSystem
    {
        public static async ETTask OnButton_Open(this UIHongBaoComponent self)
        {
            C2M_HongBaoOpenRequest c2M_HongBaoOpenRequest = new C2M_HongBaoOpenRequest();
            M2C_HongBaoOpenResponse m2C_HongBaoOpenResponse = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_HongBaoOpenRequest) as M2C_HongBaoOpenResponse;

            self.JiaGeSet.SetActive(true);
            self.DiSet.SetActive(false);
            self.Text_Amount.GetComponent<Text>().text = m2C_HongBaoOpenResponse.HongbaoAmount.ToString();
            self.Button_Open.SetActive(false);
        }
    }
}
