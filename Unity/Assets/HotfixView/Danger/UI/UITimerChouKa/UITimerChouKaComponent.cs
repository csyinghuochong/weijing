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
        public long CDTime;
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
                string itemvalue = ConfigHelper.TimerChouKaRewardList[i].Value;
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
                bool rece = activityComponent.TimerChouKaReceiveIds.Contains(i);
                self.UIItemList[i].GameObject.transform.Find("Image_Recvived").gameObject.SetActive(rece);
            }
            int receNum = activityComponent.TimerChouKaReceiveIds.Count;
            if (receNum >= ConfigHelper.TimerChouKaRewardList.Count)
            {
                self.TextTip.text = string.Empty;
                return;
            }

            long serverTime = TimeHelper.ServerNow();
            long lastTime = activityComponent.TimerChouKaLastTime;
            long validTime = lastTime + ConfigHelper.TimerChouKaRewardList[receNum].KeyId * 1000;
            if (serverTime >= validTime)
            {
                self.TextTip.text = GameSettingLanguge.LoadLocalization("可抽奖!");
                self.CDTime = 0;
            }
            else
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.UITimerChouKaTimer, self);
                self.CDTime = validTime - serverTime;
                self.OnTimer();
            }
        }

        public static void OnTimer(this UITimerChouKaComponent self)
        {
            if (self.CDTime < 0)
            {
                self.CDTime = 0;
                self.TextTip.text = GameSettingLanguge.LoadLocalization("可抽奖!");
                TimerComponent.Instance?.Remove(ref self.Timer);
                return;
            }
            string nexttime = UICommonHelper.ShowLeftTime(self.CDTime, GameSettingLanguge.Language);
            self.TextTip.text = GameSettingLanguge.LoadLocalization("下次抽奖时间:") + nexttime;
            self.CDTime -= 1000;
        }

        public static async ETTask OnButton_TimerChouKa(this UITimerChouKaComponent self)
        {
            if (self.CDTime > 0)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("还未到领取时间！"));
                return;
            }

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            if (activityComponent.TimerChouKaReceiveIds.Count >= ConfigHelper.TimerChouKaRewardList.Count)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("活动已经结束"));
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