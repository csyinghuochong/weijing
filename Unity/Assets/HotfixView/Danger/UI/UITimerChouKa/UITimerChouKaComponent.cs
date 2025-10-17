using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.UITimerChouKaTimer)]
    public class UITimerChouKaTimer : ATimer<UITimerChouKaComponent>
    {
        public override void Run(UITimerChouKaComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }


    public class UITimerChouKaComponent : Entity, IAwake, IDestroy
    {
        public Text TextTip;
        public Button OpenBtn;
        public Button ImageDi;
        public GameObject RewardItemListNode;
        public GameObject UICommonItem;
        public List<UIItemComponent> UIItemList = new List<UIItemComponent>();

        public long Timer;
    }

    public class UITimerChouKaComponentAwake : AwakeSystem<UITimerChouKaComponent>
    {
        public override void Awake(UITimerChouKaComponent self)
        {
            self.Awake();
        }
    }

    public class UITimerChouKaComponentDestroy : DestroySystem<UITimerChouKaComponent>
    {
        public override void Destroy(UITimerChouKaComponent self)
        {
            self.Destroy();
        }
    }

    public static class UITimerChouKaComponentSystem
    {
        public static void Awake(this UITimerChouKaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem.SetActive(false);

            self.TextTip = rc.Get<GameObject>("TextTip").GetComponent<Text>();
            self.OpenBtn = rc.Get<GameObject>("OpenBtn").GetComponent<Button>();
            ButtonHelp.AddListenerEx(self.OpenBtn.gameObject, () => { self.OnButton_TimerChouKa().Coroutine();  });

            self.RewardItemListNode = rc.Get<GameObject>("RewardItemListNode");
          
            self.ImageDi = rc.Get<GameObject>("ImageDi").GetComponent<Button>();
            self.ImageDi.onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UITimerChouKa );  });

            self.ShowRewardList();
            self.OnUpdateUI();

        }

        public static void ShowRewardList(this UITimerChouKaComponent self)
        {
            for (int i = 0; i < ConfigHelper.TimerChouKaRewardList.Count; i++)
            {
                string itemvalue = ConfigHelper.TimerChouKaRewardList[i].ItemInfo;
                string[] iteminfo = itemvalue.Split(';');
                int ItemID = int.Parse(iteminfo[0]);
                int ItemNum = int.Parse(iteminfo[1]);

                GameObject itemSpace = GameObject.Instantiate(self.UICommonItem);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.RewardItemListNode);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = ItemID, ItemNum = ItemNum }, ItemOperateEnum.None);
                uIItemComponent.Label_ItemName.SetActive(false);
                uIItemComponent.Label_ItemNum.SetActive(false);
                uIItemComponent.Image_Binding.SetActive(true);
                itemSpace.transform.localScale = Vector3.one * 1f;

                self.UIItemList.Add(uIItemComponent);
            }
        }

        public static void OnUpdateUI(this UITimerChouKaComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            for (int i = 0; i < self.UIItemList.Count; i++)
            {
                bool recv = activityComponent.TimerChouKaReceiveIndex > i;
                self.UIItemList[i].GameObject.transform.Find("Image_Recvived").gameObject.SetActive(recv);

                GameObject Label_ItemName = self.UIItemList[i].Label_ItemName;
                Label_ItemName.gameObject.SetActive(true);

                string strtext = recv ? "已领取" : "待领取";
                strtext = GameSettingLanguge.LoadLocalization(strtext);
                //B0FF0E  待领取切换颜色值    已领取色值：959595
                Color color_2 = recv ? new Color(176 / 255f, 255 / 255f, 14 / 255f) : new Color(149 / 255f, 149 / 255f, 149 / 255f);

                GameObject Label_ItemStatus = self.UIItemList[i].GameObject.transform.Find("Label_ItemStatus").gameObject;
                Label_ItemStatus.GetComponent<Text>().text = strtext;
                Label_ItemStatus.GetComponent<Text>().color = color_2;

                UICommonHelper.SetImageGray(self.UIItemList[i].Image_ItemIcon, recv);
            }
            int receNum = activityComponent.TimerChouKaReceiveIndex;
            if (receNum >= ConfigHelper.TimerChouKaRewardList.Count)
            {
                self.TextTip.text = string.Empty;
                return;
            }

            long passTime = activityComponent.LastTimerChouKaPassTime;
            long validTime = ConfigHelper.TimerChouKaRewardList[receNum].Interval *TimeHelper.Minute; 
            if (passTime >= validTime)
            {
                self.TextTip.text = GameSettingLanguge.LoadLocalization("可抽奖!");
            }
            else
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.UITimerChouKaTimer, self);
                self.OnTimer();
            }
        }

        public static void OnTimer(this UITimerChouKaComponent self)
        {
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            int receNum = activityComponent.TimerChouKaReceiveIndex;
            long passtime = activityComponent.LastTimerChouKaPassTime;
            long validTime = ConfigHelper.TimerChouKaRewardList[receNum].Interval * TimeHelper.Minute;

            if (passtime >= validTime)
            {
                self.TextTip.text = GameSettingLanguge.LoadLocalization("可抽奖!");
                TimerComponent.Instance?.Remove(ref self.Timer);
                return;
            }
            long leftTime = validTime - passtime;
            string nexttime = UICommonHelper.ShowLeftTime_2(leftTime, GameSettingLanguge.Language);
            self.TextTip.text = string.Format(GameSettingLanguge.LoadLocalization("{0}后领取"), nexttime);
        }

        public static async ETTask OnButton_TimerChouKa(this UITimerChouKaComponent self)
        {
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            
            if (activityComponent.TimerChouKaReceiveIndex >= ConfigHelper.TimerChouKaRewardList.Count)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("活动已经结束"));
                return;
            }

            int receNum = activityComponent.TimerChouKaReceiveIndex;
            long passtime = activityComponent.LastTimerChouKaPassTime;
            long validTime = ConfigHelper.TimerChouKaRewardList[receNum].Interval * TimeHelper.Minute;

            if (passtime < validTime)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("还未到领取时间！"));
                return;
            }

            long instanceid = self.InstanceId;
            int errorcode = await activityComponent.SendTimerChouKaRequest();
            if (errorcode != ErrorCode.ERR_Success)
            {
                return;
            }
            if (instanceid != self.InstanceId)
            {
                return;
            }

            self.OnUpdateUI();
            await ETTask.CompletedTask;
        }

        public static void Destroy(this UITimerChouKaComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }
}