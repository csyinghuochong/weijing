using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{
    public class UISkillMakeComponent : Entity, IAwake
    {

        public GameObject Lab_ShuLianDu;
        public GameObject Img_ShuLianPro;

        public GameObject Btn_Reset;
        public GameObject Select;
        public GameObject Left;
        public GameObject Right;

        public GameObject Text_Current;
        public GameObject TextVitality;

        public GameObject ImageSelect;
        public GameObject Btn_Make;

        public GameObject NeedListNode;
        public GameObject UIItemMake;
        public GameObject MakeINeedNode;
        public GameObject MakeListNode;

        public GameObject Obj_Lab_MakeName;
        public GameObject Obj_Lab_MakeNum;

        public List<UIMakeItemComponent> MakeListUI = new List<UIMakeItemComponent>();
        public List<UIMakeNeedComponent> NeedListUI = new List<UIMakeNeedComponent>();
        public UIItemComponent MakeItemUI;
        public int MakeId;
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

            self.TextVitality = rc.Get<GameObject>("Lab_HuoLi");
            self.Btn_Make = rc.Get<GameObject>("Btn_Make");
            ButtonHelp.AddListenerEx(self.Btn_Make, () => { self.OnBtn_Make().Coroutine(); });

            self.NeedListNode = rc.Get<GameObject>("NeedListNode");

            self.UIItemMake = rc.Get<GameObject>("UIItemMake");

            self.MakeINeedNode = rc.Get<GameObject>("MakeINeedNode");
            self.MakeListNode = rc.Get<GameObject>("MakeListNode");

            self.Obj_Lab_MakeName = rc.Get<GameObject>("Lab_MakeName");
            self.Obj_Lab_MakeNum = rc.Get<GameObject>("Lab_MakeNum");

            GameObject Button_Select_1 = rc.Get<GameObject>("Button_Select_1");
            GameObject Button_Select_2 = rc.Get<GameObject>("Button_Select_2");
            GameObject Button_Select_3 = rc.Get<GameObject>("Button_Select_3");
            ButtonHelp.AddListenerEx(Button_Select_1, () => { self.RequestMakeSelect(1).Coroutine(); });
            ButtonHelp.AddListenerEx(Button_Select_2, () => { self.RequestMakeSelect(2).Coroutine(); });
            ButtonHelp.AddListenerEx(Button_Select_3, () => { self.RequestMakeSelect(3).Coroutine(); });

            self.Btn_Reset = rc.Get<GameObject>("Btn_Reset");
            ButtonHelp.AddListenerEx(self.Btn_Reset, () => { self.OnBtn_Reset(); });

            self.OnInitUI().Coroutine();
            self.OnUpdateMakeType();
            self.UpdateShuLianDu();
        }
    }

    public static class UISkillMakeComponentSystem
    {

        public static void OnBtn_Reset(this UISkillMakeComponent self)
        {
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "制造", "是否重新学习", ()=>
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

        public static async ETTask OnInitUI(this UISkillMakeComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
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
            if (makeId > 0)
            {
                self.UpdateMakeList(makeId).Coroutine();
            }
        }

        public static async ETTask OnBtn_Make(this UISkillMakeComponent self)
        {
            if (self.MakeId == 0)
            {
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

            C2M_MakeEquipRequest m_ItemOperateWear = new C2M_MakeEquipRequest() { MakeId = self.MakeId };
            M2C_MakeEquipResponse r2c_roleEquip = (M2C_MakeEquipResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
            if (r2c_roleEquip.ItemId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("制作失败！");
            }
            if (r2c_roleEquip.NewMakeId != 0)
            {
                equipMakeConfig = EquipMakeConfigCategory.Instance.Get(r2c_roleEquip.NewMakeId);
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equipMakeConfig.MakeItemID);
                FloatTipManager.Instance.ShowFloatTip($"恭喜你领悟到新的制作技能 {itemConfig.ItemName}");
                self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.MakeList.Add(r2c_roleEquip.NewMakeId);
                self.OnUpdateMakeType();
            }

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
            self.Obj_Lab_MakeName.GetComponent<Text>().text = ItemConfigCategory.Instance.Get(equipMakeConfig.MakeItemID).ItemName;
            self.Obj_Lab_MakeName.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(ItemConfigCategory.Instance.Get(equipMakeConfig.MakeItemID).ItemQuality);
            self.Obj_Lab_MakeNum.GetComponent<Text>().text = equipMakeConfig.MakeEquipNum.ToString();

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

        public static void OnSelectMakeItem(this UISkillMakeComponent self, int makeid)
        {
            self.MakeId = makeid;
            if (makeid == 0)
            {
                self.MakeINeedNode.SetActive(false);
                return;
            }

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
