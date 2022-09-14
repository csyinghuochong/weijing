using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityTokenItemComponent : Entity, IAwake
    {
        public GameObject LingQuHint_3;
        public GameObject LingQuHint_2;
        public GameObject LingQuHint_1;

        public GameObject UIItemShow_3;
        public GameObject UIItemShow_2;
        public GameObject UIItemShow_1;

        public GameObject Btn_LingQu_3;
        public GameObject Btn_LingQu_2;
        public GameObject Btn_LingQu_1;

        public GameObject TextName;

        public ActivityConfig ActivityConfig;
    }

    [ObjectSystem]
    public class UIActivityTokenItemAwakeSystem : AwakeSystem<UIActivityTokenItemComponent>
    {
        public override void Awake(UIActivityTokenItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.LingQuHint_3 = rc.Get<GameObject>("LingQuHint_3");
            self.LingQuHint_2 = rc.Get<GameObject>("LingQuHint_2");
            self.LingQuHint_1 = rc.Get<GameObject>("LingQuHint_1");
            self.LingQuHint_3.SetActive(false);
            self.LingQuHint_2.SetActive(false);
            self.LingQuHint_1.SetActive(false);

            self.UIItemShow_3 = rc.Get<GameObject>("UIItemShow_3");
            self.UIItemShow_2 = rc.Get<GameObject>("UIItemShow_2");
            self.UIItemShow_1 = rc.Get<GameObject>("UIItemShow_1");

            self.Btn_LingQu_3 = rc.Get<GameObject>("Btn_LingQu_3");
            self.Btn_LingQu_2 = rc.Get<GameObject>("Btn_LingQu_2");
            self.Btn_LingQu_1 = rc.Get<GameObject>("Btn_LingQu_1");
         
            ButtonHelp.AddListenerEx(self.Btn_LingQu_3, () => { self.On_Btn_LingQu(3).Coroutine(); });
            ButtonHelp.AddListenerEx(self.Btn_LingQu_2, () => { self.On_Btn_LingQu(2).Coroutine(); });
            ButtonHelp.AddListenerEx(self.Btn_LingQu_1, () => { self.On_Btn_LingQu(1).Coroutine(); });

            self.TextName = rc.Get<GameObject>("TextName");
        }
    }

    public static class UIZhanQuTokenItemComponentSystem
    {
        public static async ETTask On_Btn_LingQu(this UIActivityTokenItemComponent self, int index)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.Lv < int.Parse(self.ActivityConfig.Par_1))
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int selfRechage = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RechargeNumber);
            //int selfRechage = self.ZoneScene().GetComponent<AccountInfoComponent>().GetRechargeNumber(userInfoComponent.UserInfo.UserId);
            if (index == 3 && selfRechage < 198)
            {
                FloatTipManager.Instance.ShowFloatTip("未达到领取条件！");
                return;
            }
            if (index == 2 && selfRechage < 98)
            {
                FloatTipManager.Instance.ShowFloatTip("未达到领取条件！");
                return;
            }

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            List<TokenRecvive> zhanQuTokenRecvives = activityComponent.QuTokenRecvive;
            for (int i = 0; i < zhanQuTokenRecvives.Count; i++)
            {
                if (zhanQuTokenRecvives[i].ActivityId == self.ActivityConfig.Id
                    && zhanQuTokenRecvives[i].ReceiveIndex == index)
                {
                    return;
                }
            }

            C2M_ActivityReceiveRequest c2M_ItemHuiShouRequest = new C2M_ActivityReceiveRequest() { ActivityType = 24, ActivityId = self.ActivityConfig.Id, ReceiveIndex = index };
            M2C_ActivityReceiveResponse r2c_roleEquip = (M2C_ActivityReceiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
            if (r2c_roleEquip.Error != ErrorCore.ERR_Success)
            {
                return;
            }

            zhanQuTokenRecvives.Add(new TokenRecvive() { ActivityId = self.ActivityConfig.Id, ReceiveIndex = index });
            self.SetReceiced(self.LingQuHint_3, 3);
            self.SetReceiced(self.LingQuHint_2, 2);
            self.SetReceiced(self.LingQuHint_1, 1);
        }

        public static void OnInitUI(this UIActivityTokenItemComponent self, ActivityConfig activityConfig)
        {
            self.ActivityConfig = activityConfig;
            self.TextName.GetComponent<Text>().text = $"{activityConfig.Par_1}级";

            self.UpdateItemUI(self.UIItemShow_1, activityConfig.Par_2);
            self.UpdateItemUI(self.UIItemShow_2, activityConfig.Par_3);
            self.UpdateItemUI(self.UIItemShow_3, activityConfig.Par_4);

            self.SetReceiced(self.LingQuHint_3, 3);
            self.SetReceiced(self.LingQuHint_2, 2);
            self.SetReceiced(self.LingQuHint_1, 1);
        }

        public static void UpdateItemUI(this UIActivityTokenItemComponent self, GameObject uiItemShow, string itemInfo)
        {
            ItemConfig itemconfig1 = ItemConfigCategory.Instance.Get(int.Parse(itemInfo.Split(';')[0]));
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemconfig1.Icon);
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemconfig1.ItemQuality);

            uiItemShow.transform.Find("Image_ItemIcon").GetComponent<Image>().sprite = sp;
            uiItemShow.transform.Find("Image_ItemQuality").GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
            uiItemShow.transform.Find("Label_ItemNum").GetComponent<Text>().text = itemInfo.Split(';')[1];
            uiItemShow.transform.Find("Label_ItemName").GetComponent<Text>().text = itemconfig1.ItemName;
        }

        public static void SetReceiced(this UIActivityTokenItemComponent self, GameObject gameObject, int index)
        {

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            List<TokenRecvive> zhanQuTokenRecvives = activityComponent.QuTokenRecvive;
            for (int i = 0; i < zhanQuTokenRecvives.Count; i++)
            {
                if (zhanQuTokenRecvives[i].ActivityId == self.ActivityConfig.Id
                    && zhanQuTokenRecvives[i].ReceiveIndex == index)
                {
                    gameObject.SetActive(true);
                    return;
                }
            }

            gameObject.SetActive(false);
        }
    }

}
