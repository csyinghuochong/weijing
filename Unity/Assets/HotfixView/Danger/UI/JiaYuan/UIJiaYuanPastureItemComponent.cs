using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPastureItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Text_RenKou;
        public GameObject Text_Name;
        public GameObject Text_value2;
        public GameObject Text_value;
        public GameObject ButtonBuy;
        public GameObject RawImage;

        public GameObject GameObject;
        public MysteryItemInfo MysteryItemInfo;
    }

    [ObjectSystem]
    public class UIJiaYuanPastureItemComponentAwake : AwakeSystem<UIJiaYuanPastureItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanPastureItemComponent self, GameObject a)
        {
            self.GameObject = a;
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Text_RenKou = rc.Get<GameObject>("Text_RenKou");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_value2 = rc.Get<GameObject>("Text_value2");
            self.Text_value = rc.Get<GameObject>("Text_value");
            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            self.RawImage = rc.Get<GameObject>("RawImage");

            ButtonHelp.AddListenerEx(self.ButtonBuy, () => { self.OnButtonBuy().Coroutine(); });
        }
    }

    public static class UIJiaYuanPastureItemComponentSystem
    {
        public static void OnUpdateUI(this UIJiaYuanPastureItemComponent self, MysteryItemInfo mysteryItemInfo)
        { 
            
        }

        public static async ETTask OnButtonBuy(this UIJiaYuanPastureItemComponent self)
        {
            int leftSpace = self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace();
            if (leftSpace < 1)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_BagIsFull);
                return;
            }

            JiaYuanPastureConfig mysteryConfig = JiaYuanPastureConfigCategory.Instance.Get(self.MysteryItemInfo.MysteryId);
            if (!self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem($"13;{mysteryConfig.BuyGold}"))
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_HouBiNotEnough);
                return;
            }

            MysteryItemInfo mysteryItemInfo = new MysteryItemInfo() { MysteryId = self.MysteryItemInfo.MysteryId };
            C2M_JiaYuanPastureBuyRequest c2M_MysteryBuyRequest = new C2M_JiaYuanPastureBuyRequest() { MysteryItemInfo = mysteryItemInfo };
            M2C_JiaYuanPastureBuyResponse r2c_roleEquip = (M2C_JiaYuanPastureBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_MysteryBuyRequest);

            UI uI = UIHelper.GetUI(self.DomainScene(), UIType.UIJiaYuanPasture);
            uI.GetComponent<UIJiaYuanPastureComponent>().RequestMystery().Coroutine();
        }

    }
}
