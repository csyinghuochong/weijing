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

        public long Interval = 500;     //匀速
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
            self.OnStopTurn = false;
            self.TargetIndex = 0;
            self.CurrentIndex = 0;
            self.Interval = 500;
            self.AcceTime = 100;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonStop = rc.Get<GameObject>("ButtonStop");
            ButtonHelp.AddListenerEx(self.ButtonStop, () => { self.OnButtonStop().Coroutine(); });

            self.ButtonOpen = rc.Get<GameObject>("ButtonOpen");
            ButtonHelp.AddListenerEx(self.ButtonOpen, () => { self.OnButtonOpen().Coroutine(); });

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UITreasureOpen); });

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

            // $"{dungeonid}@{"TaskMove_6"}@{dropId}";
            //self.BagInfo.ItemPar.Split('@')[1]

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            List<RewardItem> rewardItems = DropHelper.DropIDToShowItem(int.Parse(self.BagInfo.ItemPar.Split('@')[2]));

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < rewardItems.Count; i++)
            {
                GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(itemSpace, self.BuildingList);
                UI ui_2 = self.AddChild<UI, string, GameObject>("UICommonItem_" + i, itemSpace);
                UIItemComponent uIItemComponent = ui_2.AddComponent<UIItemComponent>();
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = rewardItems[i].ItemID, ItemNum = rewardItems[i].ItemNum }, ItemOperateEnum.None);
                uIItemComponent.Label_ItemName.SetActive(false);
                uIItemComponent.Label_ItemNum.SetActive(false);
                itemSpace.transform.localScale = Vector3.one * 1f;

                self.UIItems.Add(uIItemComponent);
            }
        }

        public static async ETTask OnStartTurn(this UITreasureOpenComponent self)
        {
            long instanceId = self.InstanceId;
            self.CurrentIndex = 0;

            while(!self.OnStopTurn)
            {
                self.ImageSelect.SetActive(true);
                UICommonHelper.SetParent( self.ImageSelect, self.UIItems[self.CurrentIndex].GameObject);
                self.CurrentIndex++;
                if (self.CurrentIndex == self.UIItems.Count)
                {
                    self.CurrentIndex = 0;
                }
                await TimerComponent.Instance.WaitAsync(self.Interval);
                if (instanceId != self.InstanceId)
                {
                    return;
                }
            }
        }

        public static async ETTask OnButtonStop(this UITreasureOpenComponent self)
        {
            self.OnStopTurn = true;
            int targetItem = self.BagInfo.HideProLists[0].HideID;
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
                self.Interval -= self.AcceTime;
                self.Interval = Math.Max(1, self.Interval);
                self.ImageSelect.SetActive(true);
                UICommonHelper.SetParent(self.ImageSelect, self.UIItems[self.CurrentIndex].GameObject);
                self.CurrentIndex++;
                if (self.CurrentIndex == self.UIItems.Count)
                {
                    self.CurrentIndex = 0;
                }
                moveNumber--;
                await TimerComponent.Instance.WaitAsync(self.Interval);
                if (instanceId != self.InstanceId)
                {
                    return;
                }
            }

            self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.BagInfo).Coroutine();
        }

        public static async ETTask OnButtonOpen(this UITreasureOpenComponent self)
        {
            C2M_ItemTreasureOpenRequest request = new C2M_ItemTreasureOpenRequest() { OperateBagID = self.BagInfo.BagInfoID };
            M2C_ItemTreasureOpenResponse response = (M2C_ItemTreasureOpenResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            self.BagInfo.HideProLists.Clear();
            self.BagInfo.HideProLists.Add(new HideProList() { HideID = response.ReardItem.ItemID, HideValue = response.ReardItem.ItemNum });
            self.OnStartTurn().Coroutine();
        }
    }
}