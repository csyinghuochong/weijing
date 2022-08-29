using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityLvLiBaoItemComponent : Entity, IAwake
    {
        public GameObject Lab_BuyValue;
        public GameObject ItemNodeList;
        public GameObject Btn_Buy;
        public GameObject Img_LingQu;
        public GameObject Img_XuanZhong;
        public GameObject Lab_LvDes;
        public GameObject Lab_Name;

        public ActivityConfig ActivityConfig;
    }


    [ObjectSystem]
    public class UIActivityLvLiBaoItemComponentAwakeSystem : AwakeSystem<UIActivityLvLiBaoItemComponent>
    {
        public override void Awake(UIActivityLvLiBaoItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");

            self.Btn_Buy = rc.Get<GameObject>("Btn_Buy");
            self.Btn_Buy.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn_Buy().Coroutine(); });

            self.Img_LingQu = rc.Get<GameObject>("Img_LingQu");
            self.Img_XuanZhong = rc.Get<GameObject>("Img_XuanZhong");
            self.Lab_LvDes = rc.Get<GameObject>("Lab_LvDes");
            self.Lab_Name = rc.Get<GameObject>("Lab_Name");
            self.Lab_BuyValue = rc.Get<GameObject>("Lab_BuyValue");

            self.Img_XuanZhong.SetActive(false);
            self.Img_LingQu.SetActive(false);
        }
    }

    public static class UIActivityLvLiBaoItemComponentSystem
    {

        public static async ETTask OnClickBtn_Buy(this UIActivityLvLiBaoItemComponent self)
        {
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            if (activityComponent.ActivityReceiveIds.Contains(self.ActivityConfig.Id))
            {
                return;
            }

            int playerLv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            int openLevel = int.Parse(self.ActivityConfig.Par_1);
            if (playerLv < openLevel)
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }

            if (!self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem(self.ActivityConfig.Par_2))
            {
                FloatTipManager.Instance.ShowFloatTip("货币不足！");
                return;
            }

            C2M_ActivityReceiveRequest c2M_ItemHuiShouRequest = new C2M_ActivityReceiveRequest() { ActivityType = self.ActivityConfig.ActivityType, ActivityId = self.ActivityConfig.Id };
            M2C_ActivityReceiveResponse r2c_roleEquip = (M2C_ActivityReceiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
            activityComponent.ActivityReceiveIds.Add(self.ActivityConfig.Id);
            self.SetReceived(true);
        }

        public static void OnUpdateUI(this UIActivityLvLiBaoItemComponent self, ActivityConfig activityConfig)
        {
            self.ActivityConfig = activityConfig;
            self.Lab_Name.GetComponent<Text>().text = $"{activityConfig.Par_1}级礼包";
            self.Lab_LvDes.GetComponent<Text>().text = $"{activityConfig.Par_1}级开启";
            self.Lab_BuyValue.GetComponent<Text>().text = activityConfig.Par_2.Split(';')[1];

            UICommonHelper.ShowItemList(activityConfig.Par_3, self.ItemNodeList, self, 0.8f).Coroutine();
        }

        public static void SetSelected(this UIActivityLvLiBaoItemComponent self, bool value)
        {
            self.Img_XuanZhong.SetActive(value);
        }

        public static void SetReceived(this UIActivityLvLiBaoItemComponent self, bool value)
        {
            self.Img_LingQu.SetActive( value );
            self.Btn_Buy.SetActive(!value);
            self.Lab_BuyValue.SetActive(!value);
        }

    }

}
