using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{
    public class UIActivitySingInComponent : Entity, IAwake
    {

        public GameObject ItemListNode;
        public GameObject Btn_Com;
        public GameObject Img_lingQu;
        public GameObject RewardListNode;

        public List<UI> ItemUIList = new List<UI>();
        public int ActivityId;
    }


    [ObjectSystem]
    public class UIActivitySingInComponentAwakeSystem : AwakeSystem<UIActivitySingInComponent>
    {
        public override void Awake(UIActivitySingInComponent self)
        {
            self.ItemUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.Img_lingQu = rc.Get<GameObject>("Img_lingQu");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");

            self.Btn_Com = rc.Get<GameObject>("Btn_Com");
            ButtonHelp.AddListenerEx(  self.Btn_Com, ()=> { self.OnBtn_Com_Sign().Coroutine();  } );

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIActivitySingInComponentSystem
    {

        public static async ETTask OnInitUI(this UIActivitySingInComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Activity/UIActivitySingInItem");
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();

            int curDay = 0;
            long serverNow = TimeHelper.ServerNow();
            bool isSign = ComHelp.GetDateByTime(serverNow) == ComHelp.GetDateByTime(activityComponent.LastSignTime);
            curDay = activityComponent.TotalSignNumber;
            if (activityComponent.TotalSignNumber < 30 && !isSign)
            {
                curDay++;
            }

            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 23)
                {
                    continue;
                }

                GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(bagSpace, self.ItemListNode);

                UI ui_item = self.AddChild<UI, string, GameObject>( "UIItem_" + i.ToString(), bagSpace);
                UIActivitySingInItemComponent uIItemComponent = ui_item.AddComponent<UIActivitySingInItemComponent>();
                uIItemComponent.OnUpdateUI(activityConfigs[i], (int activityId) => { self.OnClickSignItem(activityId);  });
                uIItemComponent.SetSignState(curDay, isSign);
                self.ItemUIList.Add( ui_item );
            }
            self.Img_lingQu.SetActive(isSign);
            self.Btn_Com.SetActive(!isSign);
            self.ItemUIList[curDay-1].GetComponent<UIActivitySingInItemComponent>().OnImage_ItemButton();
        }

        public static void OnClickSignItem(this UIActivitySingInComponent self, int activityId)
        {
            self.ActivityId = activityId;

            ActivityConfig ActivityConfig = null;
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 23)
                {
                    continue;
                }
                if (activityConfigs[i].Id == activityId)
                {
                    ActivityConfig = activityConfigs[i];
                }
            }
            for (int i = 0; i < self.ItemUIList.Count; i++)
            {
                self.ItemUIList[i].GetComponent<UIActivitySingInItemComponent>().SetSelected(ActivityConfig.Id);
            }


            UICommonHelper.DestoryChild(self.RewardListNode);
            UICommonHelper.ShowItemList(ActivityConfig.Par_3,  self.RewardListNode, self, 1f).Coroutine();

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            long serverNow = TimeHelper.ServerNow();
            bool isSign = ComHelp.GetDateByTime(serverNow) == ComHelp.GetDateByTime(activityComponent.LastSignTime);
            bool ifShow = int.Parse(ActivityConfig.Par_1) <= activityComponent.TotalSignNumber || isSign;
            self.Img_lingQu.SetActive(ifShow);
            self.Btn_Com.SetActive(!ifShow);
        }

        public static async ETTask OnBtn_Com_Sign(this UIActivitySingInComponent self)
        {

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            if (activityComponent.TotalSignNumber == 30)
            {
                FloatTipManager.Instance.ShowFloatTip("已领完全部奖励！");
                return;
            }
            long serverNow = TimeHelper.ServerNow();
            if (ComHelp.GetDateByTime(serverNow) == ComHelp.GetDateByTime(activityComponent.LastSignTime))
            {
                FloatTipManager.Instance.ShowFloatTip("当日奖励已领取！");
                return;
            }

            C2M_ActivityReceiveRequest c2M_ItemHuiShouRequest = new C2M_ActivityReceiveRequest() { ActivityType = 23, ActivityId = self.ActivityId };
            M2C_ActivityReceiveResponse r2c_roleEquip = (M2C_ActivityReceiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
            if (r2c_roleEquip.Error != ErrorCore.ERR_Success)
            {
                return;
            }

            activityComponent.TotalSignNumber++;
            activityComponent.LastSignTime = serverNow;
            activityComponent.ActivityReceiveIds.Add(self.ActivityId);

            self.OnClickSignItem(self.ActivityId);
        }
    }
}
