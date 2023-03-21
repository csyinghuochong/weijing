using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

namespace ET
{

    [Timer(TimerType.ShenQiMakeTimer)]
    public class ShenQiMakeTimer : ATimer<UIGemMakeComponent>
    {
        public override void Run(UIGemMakeComponent self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIShenQiMakeComponent : Entity, IAwake, IDestroy
    {
        public GameObject TextVitality;
        public GameObject Text_Current;
        public GameObject Lab_MakeNum;
        public GameObject Lab_MakeName;
        public GameObject UIItemMake;
        public GameObject Btn_Make;
        public GameObject NeedListNode;
        public GameObject MakeINeedNode;
        public GameObject MakeListNode;
        public GameObject Lab_MakeCDTime;

        public List<UIMakeNeedComponent> NeedListUI = new List<UIMakeNeedComponent>();
        public List<UIShenQiChapterComponent> ChapterListUI = new List<UIShenQiChapterComponent>();

        public UIItemComponent MakeItemUI;
        public int MakeId;
        public long Timer;
    }

    [ObjectSystem]
    public class UIShenQiMakeComponentDestroy: DestroySystem<UIShenQiMakeComponent>
    {
        public override void Destroy(UIShenQiMakeComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [ObjectSystem]
    public class UIShenQiMakeComponentAwake : AwakeSystem<UIShenQiMakeComponent>
    {
        public override void Awake(UIShenQiMakeComponent self)
        {
            self.MakeId = 0;
            self.MakeItemUI = null;
            self.NeedListUI.Clear();
            self.ChapterListUI.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Text_Current = rc.Get<GameObject>("Text_Current");
            self.TextVitality = rc.Get<GameObject>("TextVitality");
            self.Lab_MakeName = rc.Get<GameObject>("Lab_MakeName");
            self.Lab_MakeNum = rc.Get<GameObject>("Lab_MakeNum"); self.Lab_MakeCDTime = rc.Get<GameObject>("Lab_MakeCDTime");
            self.Lab_MakeCDTime = rc.Get<GameObject>("Lab_MakeCDTime");

            self.Btn_Make = rc.Get<GameObject>("Btn_Make");
            ButtonHelp.AddListenerEx(self.Btn_Make, () => { self.OnBtn_Make().Coroutine(); });

            self.NeedListNode = rc.Get<GameObject>("NeedListNode");

            self.UIItemMake = rc.Get<GameObject>("UIItemMake");

            self.MakeINeedNode = rc.Get<GameObject>("MakeINeedNode");
            self.MakeListNode = rc.Get<GameObject>("MakeListNode");

            self.OnInitUI();
            int showValue = NpcConfigCategory.Instance.Get(UIHelper.CurrentNpcId).ShopValue;
            self.InitMakeList(showValue).Coroutine();
        }
    }

    public static class UIShenQiMakeComponentSystem
    {

        public static void OnInitUI(this UIShenQiMakeComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(bagSpace, self.UIItemMake);
            UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(bagSpace);
            uIItemComponent.Label_ItemNum.SetActive(false);
            uIItemComponent.Label_ItemName.SetActive(false);
            self.MakeItemUI = uIItemComponent;
            self.UpateMakeItemUI();
        }

        public static async ETTask OnBtn_Make(this UIShenQiMakeComponent self)
        {
            if (self.MakeId == 0)
            {
                return;
            }
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            long cdEndTime = userInfoComponent.GetMakeTime(self.MakeId);
            if (cdEndTime > TimeHelper.ServerNow())
            {
                FloatTipManager.Instance.ShowFloatTip(ErrorHelp.Instance.ErrorHintList[ErrorCore.ERR_InMakeCD]);
                return;
            }

            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(self.MakeId);
            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Gold < equipMakeConfig.MakeNeedGold)
            {
                FloatTipManager.Instance.ShowFloatTip("金币不足！");
                return;
            }

            bool success = self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem(equipMakeConfig.NeedItems);
            if (!success)
            {
                FloatTipManager.Instance.ShowFloatTip("材料不足！");
                return;
            }

            await NetHelper.RequestEquipMake(self.ZoneScene(), 0, self.MakeId);
            self.OnCostItemUpdate().Coroutine();
        }

        public static void UpateMakeItemUI(this UIShenQiMakeComponent self)
        {
            if (self.MakeId == 0)
            {
                self.MakeItemUI.GameObject.SetActive(false);
                return;
            }
            self.MakeItemUI.GameObject.SetActive(true);
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(self.MakeId);
            if (self.MakeItemUI != null)
            {
                self.MakeItemUI.UpdateItem(new BagInfo() { ItemID = equipMakeConfig.MakeItemID }, ItemOperateEnum.MakeItem);
                self.MakeItemUI.Label_ItemNum.SetActive(false);
            }
        }

        public static async ETTask OnCostItemUpdate(this UIShenQiMakeComponent self)
        {
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(self.MakeId);
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Make/UIMakeNeed");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            string needItems = equipMakeConfig.NeedItems;
            string[] itemsList = needItems.Split('@');

            //显示名称
            self.Lab_MakeName.GetComponent<Text>().text = ItemConfigCategory.Instance.Get(equipMakeConfig.MakeItemID).ItemName;
            self.Lab_MakeName.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(ItemConfigCategory.Instance.Get(equipMakeConfig.MakeItemID).ItemQuality);
            self.Lab_MakeNum.GetComponent<Text>().text = equipMakeConfig.MakeEquipNum.ToString();

            //显示消耗活力
            self.TextVitality.GetComponent<Text>().text = equipMakeConfig.MakeNeedGold.ToString();
            self.Text_Current.GetComponent<Text>().text = $"当前金币:  {self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Gold}";

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

        public static void OnUpdate(this UIShenQiMakeComponent self)
        {
            int makeId = self.MakeId;
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            long cdEndTime = userInfoComponent.GetMakeTime(makeId);
            if (cdEndTime <= TimeHelper.ServerNow())
            {
                self.Lab_MakeCDTime.SetActive(false);
                TimerComponent.Instance?.Remove(ref self.Timer);
                return;
            }
            self.Lab_MakeCDTime.GetComponent<Text>().text = TimeHelper.ShowLeftTime(cdEndTime - TimeHelper.ServerNow());
        }

        public static void ShowCDTime(this UIShenQiMakeComponent self)
        {
            self.Lab_MakeCDTime.SetActive(false);
            TimerComponent.Instance?.Remove(ref self.Timer);
            int makeId = self.MakeId;
            if (makeId == 0)
            {
                return;
            }
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            long cdEndTime = userInfoComponent.GetMakeTime(makeId);
            if (cdEndTime <= TimeHelper.ServerNow())
            {
                return;
            }
            self.Lab_MakeCDTime.SetActive(true);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.ShenQiMakeTimer, self);
            self.OnUpdate();
        }


        public static void OnSelectMakeItem(this UIShenQiMakeComponent self, int makeid)
        {
            self.MakeId = makeid;
            self.MakeINeedNode.SetActive(makeid != 0);
            self.ShowCDTime();
            self.UpateMakeItemUI();
            self.OnCostItemUpdate().Coroutine();

            //设置选中框
            for (int k = 0; k < self.ChapterListUI.Count; k++)
            {
                self.ChapterListUI[k].OnSelectMakeItem(makeid);
            }
        }

        public static async ETTask InitMakeList(this UIShenQiMakeComponent self, int makeType)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Make/UIShenQiChapter");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            List<EquipMakeConfig> makeList = EquipMakeConfigCategory.Instance.GetAll().Values.ToList();
            Dictionary<int, List<int>> chapterMakeids = new Dictionary<int, List<int>>();
            chapterMakeids.Add(0, new List<int>());  //<=20
            chapterMakeids.Add(1, new List<int>());  //<=30
            chapterMakeids.Add(2, new List<int>());  //<= 40
            chapterMakeids.Add(3, new List<int>());   //<= 50
            chapterMakeids.Add(4, new List<int>());  //<= 100
            chapterMakeids.Add(5, new List<int>());   //消耗性道具

            for (int i = 0; i < makeList.Count; i++)
            {
                EquipMakeConfig equipMakeConfig = makeList[i];
                if (equipMakeConfig.ProficiencyType != makeType)
                {
                    continue;
                }

                int chapterindex = -1;
                int itemid = equipMakeConfig.MakeItemID;
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemid);
                if (itemConfig.ItemType == 1)
                {
                    chapterindex = 5;
                }
                else if (equipMakeConfig.LearnLv <= 20)
                {
                    chapterindex = 0;
                }
                else if (equipMakeConfig.LearnLv <= 30)
                {
                    chapterindex = 1;
                }
                else if (equipMakeConfig.LearnLv <= 40)
                {
                    chapterindex = 2;
                }
                else if (equipMakeConfig.LearnLv <= 50)
                {
                    chapterindex = 3;
                }
                else
                {
                    chapterindex = 4;
                }


                chapterMakeids[chapterindex].Add(equipMakeConfig.Id);

            };

            foreach (var item in chapterMakeids)
            {
                GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.MakeListNode);
                UIShenQiChapterComponent ui_2 = self.AddChild<UIShenQiChapterComponent, GameObject>(itemSpace);
                ui_2.SetClickAction(self.OnSelectMakeItem);
                ui_2.OnInitUI(item.Key, item.Value);
                self.ChapterListUI.Add(ui_2);

                await TimerComponent.Instance.WaitFrameAsync();
            }
        }
    }
}
