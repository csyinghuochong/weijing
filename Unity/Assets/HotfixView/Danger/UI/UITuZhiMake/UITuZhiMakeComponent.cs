using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITuZhiMakeComponent : Entity, IAwake
    {
        public GameObject UIItemMake;
        public GameObject Text_Current;
        public GameObject Lab_HuoLi;
        public GameObject Lab_MakeNum;
        public GameObject Lab_MakeName;
        public GameObject Btn_CloseUI;
        public GameObject Btn_Make;
        public GameObject NeedListNode;
        public GameObject MakeINeedNode;

        public List<UIMakeNeedComponent> NeedListUI = new List<UIMakeNeedComponent>();
        public BagInfo BagInfo;
        public int MakeId;
    }

    [ObjectSystem]
    public class UITuZhiMakeComponentAwakeSystem : AwakeSystem<UITuZhiMakeComponent>
    {
        public override void Awake(UITuZhiMakeComponent self)
        {
            self.MakeId = 0;
            self.NeedListUI.Clear();
           
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIItemMake = rc.Get<GameObject>("UIItemMake");
            self.Text_Current = rc.Get<GameObject>("Text_Current");
            self.Lab_HuoLi = rc.Get<GameObject>("Lab_HuoLi");
            self.Lab_MakeNum = rc.Get<GameObject>("Lab_MakeNum");
            self.Lab_MakeName = rc.Get<GameObject>("Lab_MakeName");
            self.Btn_Make = rc.Get<GameObject>("Btn_Make");
            self.Btn_CloseUI = rc.Get<GameObject>("Btn_CloseUI");
            self.Btn_CloseUI.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseMake(); });
            self.Btn_Make.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Make(); });

            self.NeedListNode = rc.Get<GameObject>("NeedListNode");
            self.MakeINeedNode = rc.Get<GameObject>("MakeINeedNode");
        }
    }

    public static class UITuZhiMakeComponentSystem
    {
        public static async ETTask OnInitUI(this UITuZhiMakeComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            self.MakeId = int.Parse(itemConfig.ItemUsePar);
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(bagSpace, self.UIItemMake);
            UI ui_1 = self.AddChild<UI, string, GameObject>("NeedUIItem", bagSpace);
            UIItemComponent uIItemComponent = ui_1.AddComponent<UIItemComponent>();
            uIItemComponent.Label_ItemNum.SetActive(false);
            uIItemComponent.Label_ItemName.SetActive(false);
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(self.MakeId);
            uIItemComponent.UpdateItem(new BagInfo() { ItemID = equipMakeConfig.MakeItemID }, ItemOperateEnum.MakeItem);
            uIItemComponent.Label_ItemNum.SetActive(false);

            self.OnBagItemUpdate().Coroutine();
        }

        public static void OnCloseMake(this UITuZhiMakeComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UITuZhiMake);
        }

        public static void OnBtn_Make(this UITuZhiMakeComponent self)
        {
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(self.MakeId);
            List<RewardItem> costItems = new List<RewardItem>();
            string neadItems = equipMakeConfig.NeedItems;
            string[] needList = neadItems.Split('@');
            for (int i = 0; i < needList.Length; i++)
            {
                string[] itemInfo = needList[i].Split(';');
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);
                costItems.Add(new RewardItem() { ItemID = itemId, ItemNum = itemNum });
            }
            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Vitality < equipMakeConfig.CostVitality)
            {
                FloatTipManager.Instance.ShowFloatTip("活力不足！");
                return;
            }

            bool success = self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem(costItems);
            if (!success)
            {
                FloatTipManager.Instance.ShowFloatTip("材料不足！");
                return;
            }

            //检测装备宝石
            bool haveGem = false;
            for (int i = 0; i < costItems.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(costItems[i].ItemID);
                if (itemConfig.ItemType != ItemTypeEnum.Equipment)
                {
                    continue;
                }
                BagInfo bagInfo = self.ZoneScene().GetComponent<BagComponent>().GetBagInfo(costItems[i].ItemID);
                string[] gemids = bagInfo.GemIDNew.Split('_');

                for (int g = 0; g < gemids.Length; g++)
                {
                    if (gemids[g] != "0")
                    {
                        haveGem = true;
                        break;
                    }
                }
            }

            if (haveGem)
            {
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "系统提示", "制造道具的装备材料中包含宝石,请问是否继续制造此道具",
                    () =>
                    {
                        self.RequestEquipMake().Coroutine();
                    }, null).Coroutine();
            }
            else
            {
                self.RequestEquipMake().Coroutine();
            }
        }

        public static async ETTask RequestEquipMake(this UITuZhiMakeComponent self)
        {
            await NetHelper.RequestEquipMake(self.ZoneScene(), self.BagInfo.BagInfoID, self.MakeId);
            self.OnBagItemUpdate().Coroutine();
            //关闭制造界面
            self.OnCloseMake();
        }

        public static async ETTask OnBagItemUpdate(this UITuZhiMakeComponent self)
        {
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(self.MakeId);

            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/TuZhiMake/UITuZhiMakeNeed");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            string needItems = equipMakeConfig.NeedItems;
            string[] itemsList = needItems.Split('@');

            //显示名称
            self.Lab_MakeName.GetComponent<Text>().text = ItemConfigCategory.Instance.Get(equipMakeConfig.MakeItemID).ItemName;
            self.Lab_MakeNum.GetComponent<Text>().text = equipMakeConfig.MakeEquipNum.ToString();

            //self.TextVitality.GetComponent<Text>().text = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Vitality.ToString();
            //显示消耗活力
            self.Lab_HuoLi.GetComponent<Text>().text = equipMakeConfig.CostVitality.ToString();
            self.Text_Current.GetComponent<Text>().text = $"当前活力:  {self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Vitality}";

            for (int i = 0; i < itemsList.Length; i++)
            {
                UIMakeNeedComponent ui_2 = null;
                if (i < self.NeedListUI.Count)
                {
                    ui_2 = self.NeedListUI[i];
                    ui_2.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                    itemSpace.SetActive(true);
                    UICommonHelper.SetParent(itemSpace, self.NeedListNode);
                    ui_2 = self.AddChild<UIMakeNeedComponent, GameObject>(itemSpace);
                    self.NeedListUI.Add(ui_2);
                }

                string[] itemInfo = itemsList[i].Split(';');
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);
                ui_2.UpdateItem(itemId, itemNum);
            }

            for (int k = itemsList.Length; k < self.NeedListUI.Count; k++)
            {
                self.NeedListUI[k].GameObject.SetActive(false);
            }
        }
    }
}
