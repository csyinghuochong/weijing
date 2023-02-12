using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{


    public class UITreasureOpenComponent : Entity, IAwake, IDestroy
    {
        public GameObject ImageSelect;
        public GameObject ButtonStop;
        public GameObject ButtonOpen;

        public GameObject ButtonClose;
        public GameObject BuildingList;

        public List<UIItemComponent> UIItems = new List<UIItemComponent>();

        public BagInfo BagInfo;

        public long Interval = 1000;     //匀速
        public long AcceTime = 100;   //加速

        public int TargetIndex = 0; 
        public int CurrentIndex = 0;
        public bool OnStopTurn;
    }

    [ObjectSystem]
    public class UITreasureOpenComponentAwake : AwakeSystem<UITreasureOpenComponent>
    {
        public override void Awake(UITreasureOpenComponent self)
        {
            self.UIItems.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonStop = rc.Get<GameObject>("ButtonStop");
            ButtonHelp.AddListenerEx(self.ButtonStop, () => { self.OnButtonStop().Coroutine(); });

            self.ButtonOpen = rc.Get<GameObject>("ButtonOpen");
            ButtonHelp.AddListenerEx(self.ButtonOpen, () => { self.OnButtonOpen().Coroutine(); });

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");

            self.BuildingList = rc.Get<GameObject>("BuildingList");

            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.ImageSelect.SetActive(false);
        }
    }

    public static class UITreasureOpenComponentSystem
    {
        public static void OnInitUI(this UITreasureOpenComponent self, BagInfo bagInfo)
        { 
            self.BagInfo = bagInfo; 


        }

        public static async ETTask OnStartTurn(this UITreasureOpenComponent self)
        {
            long instanceId = self.InstanceId;
            self.CurrentIndex = 0;

            while(!self.OnStopTurn)
            {
                await TimerComponent.Instance.WaitAsync(self.Interval);
                if (instanceId != self.InstanceId)
                {
                    return;
                }

                self.ImageSelect.SetActive(true);
                UICommonHelper.SetParent( self.ImageSelect, self.UIItems[self.CurrentIndex].GameObject);
                if (self.CurrentIndex == self.UIItems.Count - 1)
                {
                    self.CurrentIndex = 0;
                }
            }
        }

        public static async ETTask OnButtonStop(this UITreasureOpenComponent self)
        {
            self.OnStopTurn = true;
            int targetItem = int.Parse(self.BagInfo.ItemPar.Split(';')[0]);
            for (int i = 0; i < self.UIItems.Count; i++)
            {
                if (self.UIItems[i].Baginfo.ItemID == targetItem)
                {
                    self.TargetIndex = i;
                    break;
                }
            }

            int moveNumber = 0;
            if (self.TargetIndex > self.CurrentIndex)
            {
                moveNumber = self.TargetIndex - self.CurrentIndex;
            }
            else
            {
                moveNumber = self.TargetIndex + self.UIItems.Count - self.CurrentIndex;
            }
            self.AcceTime = (long)(self.Interval * 1f / moveNumber);

            long instanceId = self.InstanceId;
            while (moveNumber > 0)
            {
                await TimerComponent.Instance.WaitAsync(self.Interval);
                if (instanceId != self.InstanceId)
                {
                    return;
                }

                self.Interval -= self.AcceTime;
                self.Interval = Math.Max(1, self.Interval);
                self.ImageSelect.SetActive(true);
                UICommonHelper.SetParent(self.ImageSelect, self.UIItems[self.CurrentIndex].GameObject);
                self.CurrentIndex++;
                if (self.CurrentIndex == self.UIItems.Count - 1)
                {
                    self.CurrentIndex = 0;
                }
                moveNumber--;
            }
        }

        public static async ETTask OnButtonOpen(this UITreasureOpenComponent self)
        {
            C2M_ItemTreasureOpenRequest request = new C2M_ItemTreasureOpenRequest() { OperateBagID = self.BagInfo.BagInfoID };
            M2C_ItemTreasureOpenResponse response = (M2C_ItemTreasureOpenResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            self.BagInfo.ItemPar = $"{response.ReardItem.ItemID};{response.ReardItem.ItemNum}";
            self.OnStartTurn().Coroutine();
        }
    }
}