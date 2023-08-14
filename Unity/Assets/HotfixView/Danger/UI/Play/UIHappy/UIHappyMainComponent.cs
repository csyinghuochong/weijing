using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{


    public class UIHappyMainComponent : Entity, IAwake, IDestroy
    {

        public GameObject TextCoundown;

        public GameObject TextTip_3;
        public GameObject TextTip_2;
        public GameObject TextTip_1;

        public GameObject ButtonMove_3;
        public GameObject ButtonMove_2;
        public GameObject ButtonMove_1;
    }

    public class UIHappyMainComponentAwake : AwakeSystem<UIHappyMainComponent>
    {
        public override void Awake(UIHappyMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextCoundown = rc.Get<GameObject>("TextCoundown");

            self.TextTip_3 = rc.Get<GameObject>("TextTip_3");
            self.TextTip_2 = rc.Get<GameObject>("TextTip_2");
            self.TextTip_1 = rc.Get<GameObject>("TextTip_1");

            self.ButtonMove_3 = rc.Get<GameObject>("ButtonMove_3");
            self.ButtonMove_2 = rc.Get<GameObject>("ButtonMove_2");
            self.ButtonMove_1 = rc.Get<GameObject>("ButtonMove_1");
        }
    }

    public static class UIHappyMainComponentSystem
    {

        public static async ETTask OnButtonMove(this UIHappyMainComponent self, int moveType)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            if (moveType == 1)
            {
                //非免费时间则返回
                ;
            }
            if (moveType == 2)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(94);
                if (userInfoComponent.UserInfo.Gold < globalValueConfig.Value2)
                {
                    FloatTipManager.Instance.ShowFloatTip(ErrorHelp.Instance.GetHint(ErrorCore.ERR_GoldNotEnoughError));
                    return;
                }
            }
            if (moveType == 3)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(95);
                if (userInfoComponent.UserInfo.Diamond < globalValueConfig.Value2)
                {
                    FloatTipManager.Instance.ShowFloatTip(ErrorHelp.Instance.GetHint(ErrorCore.ERR_DiamondNotEnoughError));
                    return;
                }
            }

            long instanceId = self.InstanceId;
            C2M_HappyMoveRequest request = new C2M_HappyMoveRequest() { OperatateType = 1 };
            M2C_HappyMoveResponse response = (M2C_HappyMoveResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (instanceId != self.InstanceId || response.Error == ErrorCore.ERR_Success)
            {
                return;
            }


        }
    }
}