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
        public GameObject ButtonDi;

        public List<UIItemComponent> UIItems = new List<UIItemComponent>();

        public BagInfo BagInfo;

        public long Interval = 0;     //匀速
        public int TargetIndex = 0;
        public int CurrentIndex = 0;
        public bool OnStopTurn;
        public bool ifStop;
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
            self.Interval = 100;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonStop = rc.Get<GameObject>("ButtonStop");
            ButtonHelp.AddListenerEx(self.ButtonStop, () => { self.OnButtonStop().Coroutine(); });

            self.ButtonOpen = rc.Get<GameObject>("ButtonOpen");
            ButtonHelp.AddListenerEx(self.ButtonOpen, () => { self.OnButtonOpen(); });

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(self.OnButtonClose);

            self.BuildingList = rc.Get<GameObject>("BuildingList");

            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.ImageSelect.SetActive(false);

            self.ButtonDi = rc.Get<GameObject>("ButtonDi");
            self.ButtonDi.GetComponent<Button>().onClick.AddListener(self.OnButtonClose);
        }
    }

    public static class UITreasureOpenComponentSystem
    {

        public static void OnButtonClose(this UITreasureOpenComponent self)
        {
            if (self.ifStop == true)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITreasureOpen);
            }
        }

        public static void ShotTip(this UITreasureOpenComponent self)
        {
            if (self.ifStop == false)
            {
                self.ifStop = true;
                string itemInfo = self.BagInfo.ItemPar.Split('@')[2];
                int itemId = int.Parse(itemInfo.Split(';')[0]);
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
                FloatTipManager.Instance.ShowFloatTip($"获得物品 {itemConfig.ItemName} x{itemInfo.Split(';')[1]}");
            }
        }

        public static void OnInitUI(this UITreasureOpenComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;

            // $"{dungeonid}@{"TaskMove_6"}@{11;1}";
            //self.BagInfo.ItemPar.Split('@')[1]

            string rewardStr = bagInfo.ItemPar.Split('@')[2];
            string rewardItemID = rewardStr.Split(';')[0];

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            int num = RandomHelper.NextInt(10, 15);
            List<int> rewardItems = DropHelper.TreasureDropItmeShow(int.Parse(itemConfig.ItemUsePar), num);

            int dungeonid = int.Parse(bagInfo.ItemPar.Split('@')[0]);
            int dropID2 = ComHelp.TreasureToDropID(dungeonid);
            List<int> rewardItemsTeShu = DropHelper.TreasureDropItmeShow(dropID2, 27 - num);
            rewardItems.AddRange(rewardItemsTeShu);

            //Log.Info("rewardItems = " + rewardItems.Count);
            var path = ABPathHelper.GetUGUIPath("Main/Role/UITreasureItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            bool ifAddStatus = false;

            List<int> rewardShowItems = new List<int>();
            for (int i = 0; i < rewardItems.Count; i++)
            {
                //每次添加5%概率添加
                if (RandomHelper.RandFloat01() <= 0.05f && ifAddStatus == false)
                {
                    ifAddStatus = true;
                    rewardShowItems.Add(int.Parse(rewardItemID));
                    //Log.Info("rewardItemID = " + rewardItemID);
                }
                rewardShowItems.Add(rewardItems[i]);
            }

            if (ifAddStatus == false)
            {
                ifAddStatus = true;
                rewardShowItems.Add(int.Parse(rewardItemID));
                //Log.Info("rewardItemID222 = " + rewardItemID);
            }
            //Log.Info("rewardShowItems.Count = " + rewardShowItems.Count);
            for (int i = 0; i < rewardShowItems.Count; i++)
            {
                if (!ItemConfigCategory.Instance.Contain(rewardShowItems[i]))
                {
                    continue;
                }

                GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(itemSpace, self.BuildingList);
                UI ui_2 = self.AddChild<UI, string, GameObject>("UICommonItem_" + i, itemSpace);
                UIItemComponent uIItemComponent = ui_2.AddComponent<UIItemComponent>();
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = rewardShowItems[i], ItemNum = 0 }, ItemOperateEnum.None);
                //uIItemComponent.Label_ItemName.SetActive(false);
                uIItemComponent.Label_ItemNum.SetActive(false);
                itemSpace.transform.localScale = Vector3.one * 1f;

                self.UIItems.Add(uIItemComponent);
            }

            //开始触发
            self.OnButtonOpen();
        }

        public static async ETTask OnStartTurn(this UITreasureOpenComponent self)
        {
            long instanceId = self.InstanceId;
            self.CurrentIndex = 0;

            while (!self.OnStopTurn)
            {
                self.ImageSelect.SetActive(true);
                UICommonHelper.SetParent(self.ImageSelect, self.UIItems[self.CurrentIndex].GameObject);
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
            if (self.OnStopTurn)
            {
                return;
            }


            self.ButtonStop.SetActive(false);
            self.OnStopTurn = true;
            int targetItem = int.Parse(self.BagInfo.ItemPar.Split('@')[2].Split(';')[0]);
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

            long instanceId = self.InstanceId;
            while (moveNumber >= 0)
            {
                if (moveNumber < 5)
                {
                    self.Interval += 50;
                }

                self.ImageSelect.SetActive(true);
                UICommonHelper.SetParent(self.ImageSelect, self.UIItems[self.CurrentIndex].GameObject);
                self.CurrentIndex++;
                if (self.CurrentIndex == self.UIItems.Count)
                {
                    self.CurrentIndex = 0;
                }
                moveNumber--;
                await TimerComponent.Instance.WaitAsync(self.Interval);
                //Log.Debug($" self.Interval:  {self.Interval}   {moveNumber}");
                if (instanceId != self.InstanceId)
                {
                    return;
                }
            }

            self.ShotTip();

            await TimerComponent.Instance.WaitAsync(3000);
            //Log.Debug($" self.Interval:  {self.Interval}   {moveNumber}");
            if (instanceId != self.InstanceId)
            {
                return;
            }
            self.OnButtonClose();
        }

        public static void  OnButtonOpen(this UITreasureOpenComponent self)
        {
            //C2M_ItemTreasureOpenRequest request = new C2M_ItemTreasureOpenRequest() { OperateBagID = self.BagInfo.BagInfoID };
            //M2C_ItemTreasureOpenResponse response = (M2C_ItemTreasureOpenResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            //if (response.Error != ErrorCode.ERR_Success)
            //{
            //    return;
            //}
            //self.BagInfo.HideProLists.Clear();
            //self.BagInfo.HideProLists.Add(new HideProList() { HideID = response.ReardItem.ItemID, HideValue = response.ReardItem.ItemNum });
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetLeftSpace() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足！");
                return;
            }
            
            self.OnStartTurn().Coroutine();
            self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.BagInfo).Coroutine();
        }
    }
}