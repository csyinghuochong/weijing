using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanCookingComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonMake;
        public UIItemComponent[] CostItemList = new UIItemComponent[4];
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();

        public GameObject BuildingList;
        public GameObject ScrollView_2;

        public BagComponent BagComponent;

        public bool IsHoldDown = false;
    }

    public class UIJiaYuanCookingComponentAwake : AwakeSystem<UIJiaYuanCookingComponent>
    {
        public override void Awake(UIJiaYuanCookingComponent self)
        {
            self.ItemUIlist.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonMake = rc.Get<GameObject>("ButtonMake");
            ButtonHelp.AddListenerEx(self.ButtonMake, ()=>{ self.OnButtonMake().Coroutine();  });

            self.BuildingList = rc.Get<GameObject>("BuildingList");
            self.ScrollView_2 = rc.Get<GameObject>("ScrollView_2");

            for (int i = 0; i < self.CostItemList.Length; i++)
            {
                self.CostItemList[i] = self.AddChild<UIItemComponent, GameObject>(rc.Get<GameObject>($"UICommonItem_{i}"));
            }

            DataUpdateComponent.Instance.AddListener(DataType.HuiShouSelect, self);
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            self.OnUpdateUI();
        }
    }

    public class UIJiaYuanCookingComponentDestroy : DestroySystem<UIJiaYuanCookingComponent>
    {
        public override void Destroy(UIJiaYuanCookingComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.HuiShouSelect, self);
        }
    }

    public static class UIJiaYuanCookingComponentSystem
    {

        public static async ETTask OnButtonMake(this UIJiaYuanCookingComponent self)
        {
            C2M_JiaYuanCookRequest request = new C2M_JiaYuanCookRequest() { BagInfoIds = self.GetSelectIds()};
            M2C_JiaYuanCookResponse response = (M2C_JiaYuanCookResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            if (response.ItemId  != 0)
            {
                UI ui = await UIHelper.Create(self.DomainScene(), UIType.UICommonReward);
                List<RewardItem> rewardItems = new List<RewardItem>();
                rewardItems.Add(new RewardItem() { ItemID = response.ItemId, ItemNum = 1 });
                ui.GetComponent<UICommonRewardComponent>().OnUpdateUI(rewardItems);
            }
          
            self.OnUpdateUI();
        }

        public static List<long> GetSelectIds(this UIJiaYuanCookingComponent self)
        { 
            List<long> ids = new List<long>();
            for (int i= 0;  i < self.CostItemList.Length; i++)
            {
                if (self.CostItemList[i].Baginfo == null)
                {
                    continue;
                }
                ids.Add(self.CostItemList[i].Baginfo.BagInfoID);
            }
            return ids;    
        }

        public static void ResetUiItem(this UIJiaYuanCookingComponent self)
        {
            for (int i = 0; i < self.CostItemList.Length; i++)
            {
                self.CostItemList[i].UpdateItem(null, ItemOperateEnum.None);
            }
        }

        public static void UpdateBagUI(this UIJiaYuanCookingComponent self, int itemType = -1)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            List<BagInfo> allInfos = new List<BagInfo>();
            List<BagInfo> baglist = bagComponent.GetBagList();
            for (int i = 0; i < baglist.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(baglist[i].ItemID);
                if (itemConfig.ItemType == 2 &&(itemConfig.ItemSubType == 201 || itemConfig.ItemSubType == 301))
                {
                    allInfos.Add(baglist[i]);
                }
            }

            for (int i = 0; i < bagComponent.GetTotalSpace(); i++)
            {
                UIItemComponent uI_1 = null;
                if (i < self.ItemUIlist.Count)
                {
                    uI_1 = self.ItemUIlist[i];
                    uI_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BuildingList);
                    go.transform.localScale = Vector3.one;

                    uI_1 = self.AddChild<UIItemComponent, GameObject>(go);
                    uI_1.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerDown(binfo, pdata).Coroutine(); };
                    uI_1.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerUp(binfo, pdata); };

                    self.ItemUIlist.Add(uI_1);
                }
                uI_1.UpdateItem(i <allInfos.Count ? allInfos[i] : null, ItemOperateEnum.HuishouBag);
                uI_1.SetEventTrigger(i < allInfos.Count);
                uI_1.Label_ItemName.SetActive(false);
            }
        }

        public static void UpdateSelected(this UIJiaYuanCookingComponent self)
        {
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                UIItemComponent uIItemComponent = self.ItemUIlist[i];
                BagInfo bagInfo = uIItemComponent.Baginfo;
                if (bagInfo == null)
                {
                    continue;
                }
                bool have = false;
                for (int h = 0; h < self.CostItemList.Length; h++)
                {
                    if (self.CostItemList[h].Baginfo == bagInfo)
                    {
                        have = true;
                    }
                }
                uIItemComponent.Image_XuanZhong.SetActive(have);
            }
        }

        public static void OnHuiShouSelect(this UIJiaYuanCookingComponent self, string dataparams)
        {
            int curNumber = 0;
            string[] huishouInfo = dataparams.Split('_');
            BagInfo bagInfo = self.BagComponent.GetBagInfo(long.Parse(huishouInfo[1]));
            if (huishouInfo[0] == "1")
            {
                for (int i = 0; i < self.CostItemList.Length; i++)
                {
                    BagInfo bagInfo1 = self.CostItemList[i].Baginfo;
                    if (bagInfo1 != null && bagInfo1.ItemID == bagInfo.ItemID)
                    {
                        curNumber++;
                    }
                }
                if (curNumber >= bagInfo.ItemNum)
                {
                    return;
                }

                for (int i = 0; i < self.CostItemList.Length; i++)
                {
                    if (self.CostItemList[i].Baginfo != null)
                    {
                        continue;
                    }
                    self.CostItemList[i].UpdateItem(new BagInfo()
                    {
                        ItemID = bagInfo.ItemID,
                        BagInfoID = bagInfo.BagInfoID,
                        ItemNum = 1,
                        RpcId =i,
                    }, ItemOperateEnum.HuishouShow);
                    self.CostItemList[i].Label_ItemNum.GetComponent<Text>().text = "1";
                    self.CostItemList[i].Label_ItemName.SetActive(false);
                    break;
                }
            }
            else
            {
                for (int i = self.CostItemList.Length - 1; i >= 0; i--)
                {
                    BagInfo bagInfo1 = self.CostItemList[i].Baginfo;
                    if (bagInfo1 == null)
                    {
                        continue;
                    }
                    if (bagInfo1.BagInfoID == bagInfo.BagInfoID)
                    {
                        self.CostItemList[i].UpdateItem(null, ItemOperateEnum.HuishouShow);
                        self.CostItemList[i].Label_ItemNum.GetComponent<Text>().text = "1";
                        self.CostItemList[i].Label_ItemName.SetActive(false);
                        break;
                    }
                }
            }

            self.UpdateSelected();
        }

        public static async ETTask OnPointerDown(this UIJiaYuanCookingComponent self, BagInfo binfo, PointerEventData pdata)
        {
            if (binfo == null)
            {
                return;
            }

            self.IsHoldDown = true;
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"1_{binfo.BagInfoID}");
            await TimerComponent.Instance.WaitAsync(500);
            if (!self.IsHoldDown)
            {
                return;
            }
            EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            EventType.ShowItemTips.Instance.bagInfo = binfo;
            EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
            EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static void OnPointerUp(this UIJiaYuanCookingComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips);
        }

        public static void OnUpdateUI(this UIJiaYuanCookingComponent self)
        {
            self.ResetUiItem();
            self.UpdateBagUI();
            self.UpdateSelected();
        }
    }
}
