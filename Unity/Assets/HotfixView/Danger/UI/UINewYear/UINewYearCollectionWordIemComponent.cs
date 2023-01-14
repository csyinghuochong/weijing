using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public  class UINewYearCollectionWordIemComponent : Entity, IAwake<GameObject>
    {
        public GameObject WordList;
        public GameObject RewardList;
        public GameObject LabDuiHuan;
        public GameObject ButtonDuiHuan;

        public ActivityConfig ActivityConfig;
        public List<UIItemComponent> WordItems = new List<UIItemComponent>();
    }

    [ObjectSystem]
    public class UINewYearCollectionWordIemComponentAwake : AwakeSystem<UINewYearCollectionWordIemComponent, GameObject>
    {
        public override void Awake(UINewYearCollectionWordIemComponent self, GameObject a)
        {
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();
            self.WordList = rc.Get<GameObject>("WordList");
            self.RewardList = rc.Get<GameObject>("RewardList");
            self.LabDuiHuan = rc.Get<GameObject>("LabDuiHuan");
            self.ButtonDuiHuan = rc.Get<GameObject>("ButtonDuiHuan");
            ButtonHelp.AddListenerEx(self.ButtonDuiHuan, () => { self.OnButtonDuiHuan().Coroutine(); });
        }
    }

    public static class UINewYearCollectionWordIemComponentSystem
    {
        public static void OnInitUI(this UINewYearCollectionWordIemComponent self, ActivityConfig  activityConfig)
        {
            self.ActivityConfig = activityConfig;
            string[] wordItems = activityConfig.Par_2.Split('@');
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i =0; i < wordItems.Length; i++)
            {
                string[] itemInfo = wordItems[i].Split(';');
                int itemId = int.Parse(itemInfo[0]);
                GameObject itemObject = GameObject.Instantiate(bundleGameObject);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemObject);
                uIItemComponent.UpdateItem(new BagInfo() {ItemID = itemId });
                uIItemComponent.Label_ItemNum.SetActive(false);
                uIItemComponent.Label_ItemName.SetActive(false);
                self.WordItems.Add(uIItemComponent);
                UICommonHelper.SetParent(itemObject, self.WordList);
            }

            UICommonHelper.ShowItemList(activityConfig.Par_3, self.RewardList, self);
        }

        public static void OnUpdateUI(this UINewYearCollectionWordIemComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            for (int i = 0; i < self.WordItems.Count; i++)
            {
                bool gray = bagComponent.GetItemNumber(self.WordItems[i].Baginfo.ItemID) <= 0;
                UICommonHelper.SetImageGray(self.WordItems[i].Image_ItemIcon, gray);
                UICommonHelper.SetImageGray(self.WordItems[i].Image_ItemQuality, gray);
            }

            ActivityConfig activityConfig = self.ActivityConfig;
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            int receiveNumber = 0;
            for (int i = 0; i < activityComponent.ActivityReceiveIds.Count; i++)
            {
                if (activityComponent.ActivityReceiveIds[i] == self.ActivityConfig.Id)
                {
                    receiveNumber++;
                }
            }
            //显示兑换次数
            self.LabDuiHuan.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization($"兑换次数:{receiveNumber}/{activityConfig.Par_1}");
        }

        public static async ETTask OnButtonDuiHuan(this UINewYearCollectionWordIemComponent self)
        { 
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            bool receiveMax = ActivityHelper.HaveReceiveTimes(activityComponent.ActivityReceiveIds, self.ActivityConfig.Id);
            if (!receiveMax)
            {
                FloatTipManager.Instance.ShowFloatTip("已达到最大领取上限！");
                return;
            }
            if (!self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem(self.ActivityConfig.Par_2))
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足！");
                return;
            }
            await activityComponent.GetActivityReward(self.ActivityConfig.ActivityType, self.ActivityConfig.Id);
            self.OnUpdateUI();
        }
    }
}
