using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [Timer(TimerType.TeamDropTimer)]
    public class TeamDropTimer : ATimer<UITeamMainComponent>
    {
        public override void Run(UITeamMainComponent self)
        {
            try
            {
                self.Check();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UITeamMainComponent : Entity, IAwake, IDestroy
    {
        public long Timer;
        public GameObject BottomNode;
        public GameObject Label_LeftTime;
        public GameObject Btn_Close;
        public GameObject Btn_Need;
        public GameObject TeamDropItem;

        public int LeftTime;
        public DropInfo CurDrop;
        public UIItemComponent UIItem;
        public List<DropInfo> DropInfos = new List<DropInfo>(); 
    }


    public class UITeamMainComponentDestroySystem : DestroySystem<UITeamMainComponent>
    {
        public override void Destroy(UITeamMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }


    public class UITeamMainComponentAwakeSystem : AwakeSystem<UITeamMainComponent>
    {
        public override void Awake(UITeamMainComponent self)
        {
            self.LeftTime = 0;
            self.CurDrop = null;
            self.DropInfos.Clear();

            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Label_LeftTime = rc.Get<GameObject>("Label_LeftTime");

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            ButtonHelp.AddListenerEx( self.Btn_Close, self.OnBtn_Close);

            self.Btn_Need = rc.Get<GameObject>("Btn_Need");
            ButtonHelp.AddListenerEx(self.Btn_Need, self.OnBtn_Need);

            self.BottomNode = rc.Get<GameObject>("BottomNode");

            self.TeamDropItem = rc.Get<GameObject>("TeamDropItem");
            self.TeamDropItem.SetActive(false);

            GameObject UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UIItem = self.AddChild<UIItemComponent, GameObject>(UICommonItem);
        }
    }

    public static class UITeamMainComponentSystem
    {
        public static void OnTeamPickNotice(this UITeamMainComponent self, List<DropInfo> dropInfos)
        {
            for (int i = 0; i < dropInfos.Count; i++)
            {
                dropInfos[i].BeKillId = TimeHelper.ServerNow() + TimeHelper.Second * 100 + self.DropInfos.Count;
            }

            self.DropInfos.AddRange(dropInfos);
           
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.TeamDropTimer, self);
            }
        }

        public static void UpdateDropItem(this UITeamMainComponent self)
        {
            self.CurDrop = self.DropInfos[0];
            self.LeftTime = (int)( self.CurDrop.BeKillId - TimeHelper.ServerNow() ) / 1000;
            self.DropInfos.RemoveAt(0);
            self.TeamDropItem.SetActive(true);
            self.UIItem.UpdateItem(new BagInfo() { ItemID = self.CurDrop.ItemID, ItemNum = self.CurDrop.ItemNum }, ItemOperateEnum.None);
            Log.Debug($"self.DropInfos {self.DropInfos.Count}");
        }

        public static  void SendTeamPick(this UITeamMainComponent self, DropInfo dropInfo, int needType)
        {
            if (dropInfo == null)
            {
                return;
            }
            C2M_TeamPickRequest request = new C2M_TeamPickRequest() { DropItem = dropInfo, Need = needType };
            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(request);
        }

        public static void OnBtn_Close(this UITeamMainComponent self)
        {
            self.SendTeamPick(self.CurDrop, 2);
            self.LeftTime = 0;
            self.CurDrop = null;
            self.TeamDropItem.SetActive(false);
        }

        public static void OnBtn_Need(this UITeamMainComponent self)
        {
            self.SendTeamPick(self.CurDrop, 1);
            self.LeftTime = 0;
            self.CurDrop = null;
            self.TeamDropItem.SetActive(false);
        }

        public static void Check(this UITeamMainComponent self)
        {
            long serverTime = TimeHelper.ServerNow();
            for (int i = self.DropInfos.Count - 1; i >= 0; i--)
            {
                if (serverTime >= self.DropInfos[i].BeKillId)
                {
                    self.SendTeamPick(self.DropInfos[i], 2);
                    self.DropInfos.RemoveAt(i); 
                }
            }

            if (self.LeftTime  < 0 )
            {
                self.SendTeamPick(self.CurDrop, 2);
                self.CurDrop = null;
                self.TeamDropItem.SetActive(false);
            }

            if (self.CurDrop == null && self.DropInfos.Count == 0)
            {
                TimerComponent.Instance.Remove(ref self.Timer);
            }
            if (self.CurDrop == null && self.DropInfos.Count > 0)
            {
                self.UpdateDropItem();  
            }

            self.LeftTime--;
            int timeStr = self.LeftTime;
            if (self.LeftTime < 0) 
            {
                timeStr = 0;
            }
            self.Label_LeftTime.GetComponent<Text>().text = $"拾取剩余:{timeStr}秒";
        }
    }
}
