using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityTokenComponent : Entity, IAwake
    {

        public GameObject Btn_GoPay;
        public GameObject TextRecharge;
        public GameObject ItemNodeList;
    }

    [ObjectSystem]
    public class UIActivityTokenComponentAwakeSystem : AwakeSystem<UIActivityTokenComponent >
    {
        public override void Awake(UIActivityTokenComponent  self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextRecharge = rc.Get<GameObject>("TextRecharge");
            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
            self.Btn_GoPay = rc.Get<GameObject>("Btn_GoPay");
            ButtonHelp.AddListenerEx( self.Btn_GoPay, () => { self.OnBtn_GoPay();  } );

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIActivityTokenComponentSystem
    {

        public static void OnBtn_GoPay(this UIActivityTokenComponent  self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIRecharge).Coroutine() ;
            UIHelper.Remove( self.ZoneScene(), UIType.UIActivity ).Coroutine();
        }

        public static async ETTask OnInitUI(this UIActivityTokenComponent  self)
        {
            var path =  ABPathHelper.GetUGUIPath("Main/Activity/UIActivityTokenItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 24)
                {
                    continue;
                }

                GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(bagSpace, self.ItemNodeList);

                UI ui_item = self.AddChild<UI, string, GameObject>( "UIItem_" + i.ToString(), bagSpace);
                UIActivityTokenItemComponent uIItemComponent = ui_item.AddComponent<UIActivityTokenItemComponent>();

                uIItemComponent.OnInitUI(activityConfigs[i]);
            }

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            int selfRechage = self.ZoneScene().GetComponent<AccountInfoComponent>().GetRechargeNumber(userInfoComponent.UserInfo.UserId);
            self.TextRecharge.GetComponent<Text>().text = $"当前额度：{selfRechage}/298";
            self.TextRecharge.SetActive(selfRechage < 298);
        }
    }
}
