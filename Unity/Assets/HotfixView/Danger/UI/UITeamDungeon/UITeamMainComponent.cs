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

        public int LeftTime;
        public DropInfo CurDrop;
        public UIItemComponent UIItem;
        public List<DropInfo> DropInfos = new List<DropInfo>(); 
    }

    [ObjectSystem]
    public class UITeamMainComponentDestroySystem : DestroySystem<UITeamMainComponent>
    {
        public override void Destroy(UITeamMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [ObjectSystem]
    public class UITeamMainComponentAwakeSystem : AwakeSystem<UITeamMainComponent>
    {
        public override void Awake(UITeamMainComponent self)
        {
            self.LeftTime = 0;
            self.CurDrop = null;
            self.DropInfos.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Label_LeftTime = rc.Get<GameObject>("Label_LeftTime");

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            ButtonHelp.AddListenerEx( self.Btn_Close, () => { } );

            self.Btn_Need = rc.Get<GameObject>("Btn_Need");
            ButtonHelp.AddListenerEx(self.Btn_Need, () => { });

            self.BottomNode = rc.Get<GameObject>("BottomNode");
            self.BottomNode.SetActive(false);

            GameObject UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UIItem = self.AddChild<UIItemComponent, GameObject>(UICommonItem);
        }
    }

    public static class UITeamMainComponentSystem
    {
        public static void OnTeamPickNotice(this UITeamMainComponent self, List<DropInfo> dropInfos)
        {
            self.DropInfos.AddRange(dropInfos);
            if (self.CurDrop == null)
            {
                self.UpdateDropItem();
            }
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.TeamDropTimer, self);
            }
        }

        public static void UpdateDropItem(this UITeamMainComponent self)
        {
            self.CurDrop = self.DropInfos[0];
            self.LeftTime = 20;
            self.DropInfos.RemoveAt(0);
        }

        public static async ETTask SendTeamPick(this UITeamMainComponent self, int needType)
        {
            DropInfo dropInfo = self.CurDrop;


            self.LeftTime = 0;
            self.CurDrop = null;
        }

        public static void OnBtn_Close(this UITeamMainComponent self)
        {
            self.SendTeamPick(2).Coroutine();
        }

        public static void OnBtn_Need(this UITeamMainComponent self)
        {
            self.SendTeamPick(1).Coroutine();
        }

        public static void Check(this UITeamMainComponent self)
        {
            if (self.LeftTime  < 0)
            {
                if (self.DropInfos.Count > 0)
                {
                    self.UpdateDropItem();
                    return;
                }
                TimerComponent.Instance.Remove(ref self.Timer);
            }
            self.LeftTime--;
            self.Label_LeftTime.GetComponent<Text>().text = $"{self.LeftTime}秒";
        }
    }
}
