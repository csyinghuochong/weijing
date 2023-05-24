using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISettingFrameComponent : Entity, IAwake
    {
        public GameObject ButtonClose;
        public GameObject ButtonHigh;
        public GameObject ButtonNormal;
        public GameObject ImageDiClose;
    }

    public class UISettingFrameComponentAwake : AwakeSystem<UISettingFrameComponent>
    {
        public override void Awake(UISettingFrameComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonHigh = rc.Get<GameObject>("ButtonHigh");
            self.ButtonNormal = rc.Get<GameObject>("ButtonNormal");
            self.ImageDiClose = rc.Get<GameObject>("ImageDiClose");

            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UISettingFrame ); } );
            self.ImageDiClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UISettingFrame); });
            ButtonHelp.AddListenerEx(self.ButtonHigh, () => { self.OnButtonSetting("1").Coroutine();  });
            ButtonHelp.AddListenerEx(self.ButtonNormal, () => { self.OnButtonSetting("0").Coroutine();  });
        }
    }

    public static class UISettingFrameComponentSystem
    { 
        
        public static async ETTask OnButtonSetting(this UISettingFrameComponent self, string setvalue)
        {
             List<KeyValuePair> gameSettingInfos = new List<KeyValuePair>();
             gameSettingInfos.Add( new KeyValuePair() { KeyId = (int)GameSettingEnum.Smooth, Value = setvalue } );
             self.ZoneScene().GetComponent<UserInfoComponent>().UpdateGameSetting(gameSettingInfos);

             C2M_GameSettingRequest c2M_GameSettingRequest = new C2M_GameSettingRequest() { GameSettingInfos = gameSettingInfos };
             M2C_GameSettingResponse r2c_roleEquip = (M2C_GameSettingResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_GameSettingRequest);
             Application.targetFrameRate = setvalue == "1" ? 60 : 30;

            PlayerPrefsHelp.SetInt(PlayerPrefsHelp.LastFrame, 1);


            if (setvalue == "1")
            {
                FloatTipManager.Instance.ShowFloatTip("你开启了高帧模式");
            }

            if (setvalue == "0")
            {
                FloatTipManager.Instance.ShowFloatTip("你开启了普通模式");
            }

            //移除界面
            UIHelper.Remove(self.ZoneScene(), UIType.UISettingFrame);


        }
    }
}
