using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [Timer(TimerType.MakeCDTimer)]
    public class SkillMakeTimer : ATimer<UISkillMakeComponent>
    {
        public override void Run(UISkillMakeComponent self)
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

    public class UISkillMakeComponent : Entity, IAwake,IDestroy
    {

        public GameObject Lab_ShuLianDu;
        public GameObject Img_ShuLianPro;

        public GameObject Btn_Reset;
        public GameObject Select;
        public GameObject Left;
        public GameObject Right;
        public GameObject Melt;

        public GameObject Text_Current;
        public GameObject TextVitality;

        public GameObject ImageSelect;
        public GameObject Btn_Make;
        public GameObject Btn_Melt;

        public GameObject NeedListNode;
        public GameObject UIItemMake;
        public GameObject MakeINeedNode;
        public GameObject MakeListNode;

        public GameObject Lab_MakeName;
        public GameObject Lab_MakeNum;
        public GameObject Lab_MakeCDTime;

        public List<UIMakeItemComponent> MakeListUI = new List<UIMakeItemComponent>();
        public List<UIMakeNeedComponent> NeedListUI = new List<UIMakeNeedComponent>();
        public UISkillMeltingComponent MeltingComponent;
        public UIItemComponent MakeItemUI;
        public int MakeId;
        public long Timer;
    }

    [ObjectSystem]
    public class UISkillMakeComponentDestroySystem : DestroySystem<UISkillMakeComponent>
    {
        public override void Destroy(UISkillMakeComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [ObjectSystem]
    public class UISkillMakeComponentAwakeSystem : AwakeSystem<UISkillMakeComponent>
    {
        public override void Awake(UISkillMakeComponent self)
        {
            self.MakeId = 0;
            self.MakeItemUI = null;
            self.NeedListUI.Clear();
            self.MakeListUI.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.Text_Current = rc.Get<GameObject>("Text_Current");

            self.Lab_ShuLianDu = rc.Get<GameObject>("Lab_ShuLianDu");
            self.Img_ShuLianPro = rc.Get<GameObject>("Img_ShuLianPro");

            self.Right = rc.Get<GameObject>("Right");
            self.Left = rc.Get<GameObject>("Left");
            self.Select = rc.Get<GameObject>("Select");
            self.Btn_Melt = rc.Get<GameObject>("Btn_Melt");

            self.TextVitality = rc.Get<GameObject>("Lab_HuoLi");
            self.Btn_Make = rc.Get<GameObject>("Btn_Make");
            ButtonHelp.AddListenerEx(self.Btn_Make, () => { self.OnBtn_Make().Coroutine(); });
            ButtonHelp.AddListenerEx(self.Btn_Melt, self.OnBtn_Melt);

            self.NeedListNode = rc.Get<GameObject>("NeedListNode");

            self.UIItemMake = rc.Get<GameObject>("UIItemMake");

            self.MakeINeedNode = rc.Get<GameObject>("MakeINeedNode");
            self.MakeListNode = rc.Get<GameObject>("MakeListNode");

            self.Lab_MakeName = rc.Get<GameObject>("Lab_MakeName");
            self.Lab_MakeNum = rc.Get<GameObject>("Lab_MakeNum");

            self.Lab_MakeCDTime = rc.Get<GameObject>("Lab_MakeCDTime");

            GameObject Button_Select_1 = rc.Get<GameObject>("Button_Select_1");
            GameObject Button_Select_2 = rc.Get<GameObject>("Button_Select_2");
            GameObject Button_Select_3 = rc.Get<GameObject>("Button_Select_3");
            GameObject Button_Select_4 = rc.Get<GameObject>("Button_Select_4");
            ButtonHelp.AddListenerEx(Button_Select_1, () => { self.RequestMakeSelect(1).Coroutine(); });
            ButtonHelp.AddListenerEx(Button_Select_2, () => { self.RequestMakeSelect(2).Coroutine(); });
            ButtonHelp.AddListenerEx(Button_Select_3, () => { self.RequestMakeSelect(3).Coroutine(); });
            ButtonHelp.AddListenerEx(Button_Select_4, () => { self.RequestMakeSelect(6).Coroutine(); });

            self.Btn_Reset = rc.Get<GameObject>("Btn_Reset");
            ButtonHelp.AddListenerEx(self.Btn_Reset, () => { self.OnBtn_Reset(); });

            self.Melt = rc.Get<GameObject>("Melt");
            self.MeltingComponent = self.AddChild<UISkillMeltingComponent, GameObject>(self.Melt);

            self.OnInitUI();
            self.OnUpdateMakeType();
            self.UpdateShuLianDu();
        }
    }

    public static class UISkillMakeComponentSystem
    {

        public static void OnBtn_Reset(this UISkillMakeComponent self)
        {
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "遗忘技能", "遗忘后将可以重新学习其他的生活技能，之前学习的所有技能将重置,请谨慎选择", ()=>
            {
                self.Right.SetActive(false);
                self.Left.SetActive(false);
                self.Select.SetActive(true);
            }, null).Coroutine();
        }

        public static async ETTask RequestMakeSelect(this UISkillMakeComponent self, int makeId)
        {
            C2M_MakeSelectRequest  request  = new C2M_MakeSelectRequest() { MakeType = makeId };
            M2C_MakeSelectResponse response = (M2C_MakeSelectResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.MakeList.Clear();
            self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.MakeList = response.MakeList;
            self.OnUpdateMakeType();
        }

        public static  void OnInitUI(this UISkillMakeComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(bagSpace, self.UIItemMake);
            UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(bagSpace);
            uIItemComponent.Label_ItemNum.SetActive(false);
            uIItemComponent.Label_ItemName.SetActive(false);
            self.MakeItemUI = uIItemComponent;
            if (self.MakeId != 0)
            {
                EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(self.MakeId);
                self.MakeItemUI.UpdateItem(new BagInfo() { ItemID = equipMakeConfig.MakeItemID }, ItemOperateEnum.MakeItem);
                self.MakeItemUI.Label_ItemNum.SetActive(false);
            }
        }

        public static void OnUpdateMakeType(this UISkillMakeComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int makeId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.MakeType);
            self.Right.SetActive(makeId != 0);
            self.Left.SetActive(makeId != 0);
            self.Select.SetActive(makeId == 0);
            self.Melt.SetActive(false);
            if (makeId > 0)
            {
                self.UpdateMakeList(makeId).Coroutine();
            }
        }

        public static void OnBtn_Melt(this UISkillMakeComponent self)
        {
            self.Right.SetActive(false);
            self.Select.SetActive(false);
            self.Melt.SetActive(true);
            self.MeltingComponent.OnUpdateUI();
        }

        public static async ETTask OnBtn_Make(this UISkillMakeComponent self)
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
            await NetHelper.RequestEquipMake(self.ZoneScene(), 0, self.MakeId);

            self.OnUpdateMakeType();
            self.UpdateShuLianDu();
            self.OnBagItemUpdate().Coroutine();
        }

        public static void UpdateShuLianDu(this UISkillMakeComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            int maxValue = ComHelp.MaxShuLianDu();
            int curValue = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.MakeShuLianDu);

            self.Lab_ShuLianDu.GetComponent<Text>().text = $"{curValue}/{maxValue}";
            self.Img_ShuLianPro.GetComponent<Image>().fillAmount = curValue * 1f / maxValue;
        }

        public static async ETTask OnBagItemUpdate(this UISkillMakeComponent self)
        {
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(self.MakeId);

            if (self.MakeItemUI != null)
            {
                self.MakeItemUI.UpdateItem(new BagInfo() { ItemID = equipMakeConfig.MakeItemID }, ItemOperateEnum.MakeItem);
                self.MakeItemUI.Label_ItemNum.SetActive(false);
            }

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

            //self.TextVitality.GetComponent<Text>().text = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Vitality.ToString();
            //显示消耗活力
            self.TextVitality.GetComponent<Text>().text = equipMakeConfig.CostVitality.ToString();
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

        public static void OnUpdate(this UISkillMakeComponent self)
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

        public static void ShowCDTime(this UISkillMakeComponent self)
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
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.MakeCDTimer, self);
            self.OnUpdate();
        }

        public static void OnSelectMakeItem(this UISkillMakeComponent self, int makeid)
        {
            self.MakeId = makeid;
            if (makeid == 0)
            {
                self.MakeINeedNode.SetActive(false);
                return;
            }

            self.ShowCDTime();
            self.Right.SetActive(true);
            self.Select.SetActive(false);
            self.Melt.SetActive(false);
            self.MakeINeedNode.SetActive(true);
            self.OnBagItemUpdate().Coroutine();

            //设置选中框
            for (int k = 0; k < self.MakeListUI.Count; k++)
            {
                if (self.MakeListUI[k].MakeID == makeid)
                {
                    self.ImageSelect.SetActive(true);
                    UICommonHelper.SetParent(self.ImageSelect, self.MakeListUI[k].GameObject);
                    self.ImageSelect.transform.localPosition = new Vector3(0f, 12f, 0f);
                    break;
                }
            }
        }

        public static async ETTask UpdateMakeList(this UISkillMakeComponent self, int makeType)
        {
            int number = 0;
            //List<int> makeList = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.MakeList;
            var path = ABPathHelper.GetUGUIPath("Main/Make/UIMakeItem");
            var bundleGameObject =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            //List<EquipMakeConfig> equipConfigs = EquipMakeConfigCategory.Instance.GetAll().Values.ToList();
            List<int> makeList = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.MakeList;
            
            for (int k = 0; k < self.MakeListUI.Count; k++)
            {
                self.MakeListUI[k].GameObject.SetActive(false);
            }
            for (int i = 0; i < makeList.Count; i++)
            {
                if (!EquipMakeConfigCategory.Instance.Contain(makeList[i]))
                {
                    continue;
                }
                EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeList[i]);
                if (equipMakeConfig.ProficiencyType != makeType)
                {
                    continue;
                }
                UIMakeItemComponent ui_2 = null;
                if (i < self.MakeListUI.Count)
                {
                    ui_2 = self.MakeListUI[number];
                    ui_2.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                    itemSpace.SetActive(true);
                    UICommonHelper.SetParent(itemSpace, self.MakeListNode);
                    ui_2 = self.AddChild<UIMakeItemComponent, GameObject>( itemSpace);
                    ui_2.SetClickAction((int itemid) => { self.OnSelectMakeItem(itemid); });
                    self.MakeListUI.Add(ui_2);
                }
                number++;
                ui_2.OnUpdateUI(equipMakeConfig.Id);
            }

            self.OnSelectMakeItem(number == 0 ? 0 : self.MakeListUI[0].MakeID);
        }
    }
}
