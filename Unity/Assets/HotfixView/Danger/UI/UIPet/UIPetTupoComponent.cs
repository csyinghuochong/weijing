using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetTupoComponent : Entity, IAwake
    {
        public GameObject UICommonItem;
        public GameObject CostItemListNode;
        public GameObject XiuLianName;
        public GameObject XiuLianImageIcon;
        public GameObject Button_Donation;
        public GameObject Pro_1;
        public GameObject Pro_0;

        public List<UIItemComponent> UIItemComponentList = new List<UIItemComponent>();
        public List<UIUnionXiuLianItemComponent> UIUnionXiuLianItemList = new List<UIUnionXiuLianItemComponent>();
        public int Position;
    }

    public class UIPetTupoComponentAwake : AwakeSystem<UIPetTupoComponent>
    {
        public override void Awake(UIPetTupoComponent self)
        {
            self.Position = 0;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem.SetActive(false);
            self.CostItemListNode = rc.Get<GameObject>("CostItemListNode");
            self.Button_Donation = rc.Get<GameObject>("Button_Donation");
            ButtonHelp.AddListenerEx(self.Button_Donation, () => { self.OnButton_Tupo().Coroutine(); });

            self.Pro_1 = rc.Get<GameObject>("Pro_1");
            self.Pro_0 = rc.Get<GameObject>("Pro_0");
            self.XiuLianName = rc.Get<GameObject>("XiuLianName");

            self.XiuLianImageIcon = rc.Get<GameObject>("XiuLianImageIcon");
            self.UIUnionXiuLianItemList.Clear();
            for (int i = 0; i < 5; i++)
            {
                UIUnionXiuLianItemComponent uIUnionXiuLianItem =
                        self.AddChild<UIUnionXiuLianItemComponent, GameObject>(rc.Get<GameObject>($"XiuLian_{i}"));
                uIUnionXiuLianItem.Position = i;
                uIUnionXiuLianItem.ClickHandler = self.OnClickHandler;
                self.UIUnionXiuLianItemList.Add(uIUnionXiuLianItem);
            }

            self.UIUnionXiuLianItemList[0].ClickHandler?.Invoke(0);
        }
    }

    public static class UIPetTupoComponentSystem
    {
        public static void OnClickHandler(this UIPetTupoComponent self, int position)
        {
            self.Position = position;
            for (int i = 0; i < self.UIUnionXiuLianItemList.Count; i++)
            {
                self.UIUnionXiuLianItemList[i].ImageSelect.SetActive(position == i);
            }

            for (int i = 0; i < self.XiuLianImageIcon.transform.childCount; i++)
            {
                self.XiuLianImageIcon.transform.GetChild(i).gameObject.SetActive(position == i);
            }

            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIPetTupoComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            for (int i = 0; i < self.UIUnionXiuLianItemList.Count; i++)
            {
                int itemNumericType = PetTupoHelper.GetTupoNumericType(i);
                int itemTupoId = numericComponent.GetAsInt(itemNumericType);
                if (!PetTupoConfigCategory.Instance.Contain(itemTupoId))
                {
                    continue;
                }
                PetTupoConfig itemConfig = PetTupoConfigCategory.Instance.Get(itemTupoId);
                self.UIUnionXiuLianItemList[i].Text_Tip_1.GetComponent<Text>().text = itemConfig.GetEquipSpaceName();
            }

            int numerType = PetTupoHelper.GetTupoNumericType(self.Position);
            int tupoId = numericComponent.GetAsInt(numerType);
            if (!PetTupoConfigCategory.Instance.Contain(tupoId))
            {
                return;
            }

            PetTupoConfig petTupoConfig = PetTupoConfigCategory.Instance.Get(tupoId);
            self.XiuLianName.GetComponent<Text>().text = petTupoConfig.GetEquipSpaceName();
            self.Pro_0.transform.Find("Text_Tip_Pro_0").GetComponent<Text>().text = ItemViewHelp.GetAttributeDesc(petTupoConfig.EquipPropreAdd);

            if (petTupoConfig.NextID == 0)
            {
                self.Pro_1.SetActive(false);
                for (int i = 0; i < self.UIItemComponentList.Count; i++)
                {
                    self.UIItemComponentList[i].GameObject.SetActive(false);
                }
                return;
            }

            self.Pro_1.SetActive(true);
            PetTupoConfig nextPetTupoConfig = PetTupoConfigCategory.Instance.Get(petTupoConfig.NextID);
            self.Pro_1.transform.Find("Text_Tip_Pro_0").GetComponent<Text>().text =
                    ItemViewHelp.GetAttributeDesc(nextPetTupoConfig.EquipPropreAdd);

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<string> itemList = new List<string>();
            if (petTupoConfig.CostGold > 0)
            {
                itemList.Add($"1;{petTupoConfig.CostGold}");
            }
            if (!ComHelp.IfNull(petTupoConfig.CostItem) && petTupoConfig.CostItem != "0")
            {
                itemList.AddRange(petTupoConfig.CostItem.Split('@'));
            }

            int num = 0;
            foreach (string item in itemList)
            {
                string[] str = item.Split(';');
                if (str.Length < 2)
                {
                    continue;
                }
                int itemConfigId = int.Parse(str[0]);
                int itemNum = int.Parse(str[1]);
                long havedNum = bagComponent.GetItemNumber(itemConfigId);
                if (num >= self.UIItemComponentList.Count)
                {
                    GameObject go = UnityEngine.Object.Instantiate(self.UICommonItem);
                    UIItemComponent uiItemComponent = self.AddChild<UIItemComponent, GameObject>(go);
                    UICommonHelper.SetParent(go, self.CostItemListNode);
                    go.SetActive(true);
                    self.UIItemComponentList.Add(uiItemComponent);
                }

                UIItemComponent itemComponent = self.UIItemComponentList[num];
                itemComponent.GameObject.SetActive(true);
                itemComponent.UpdateItem(new BagInfo() { ItemID = itemConfigId }, ItemOperateEnum.None);
                itemComponent.Label_ItemNum.GetComponent<Text>().text = itemConfigId == 1
                        ? $"{ItemViewHelp.ReturnNumStr(itemNum)}/{ItemViewHelp.ReturnNumStr(havedNum)}"
                        : $"{itemNum}/{havedNum}";
                itemComponent.Label_ItemNum.GetComponent<Text>().color =
                        havedNum >= itemNum ? new Color(0, 1, 0) : new Color(245f / 255f, 43f / 255f, 96f / 255f);
                num++;
            }

            for (int i = num; i < self.UIItemComponentList.Count; i++)
            {
                self.UIItemComponentList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask OnButton_Tupo(this UIPetTupoComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int numerType = PetTupoHelper.GetTupoNumericType(self.Position);
            int tupoId = unit.GetComponent<NumericComponent>().GetAsInt(numerType);
            if (!PetTupoConfigCategory.Instance.Contain(tupoId))
            {
                return;
            }

            PetTupoConfig petTupoConfig = PetTupoConfigCategory.Instance.Get(tupoId);
            if (petTupoConfig.NextID == 0)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("已达突破上限！"));
                return;
            }

            if (petTupoConfig.UpLvLimit > 0 && self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv < petTupoConfig.UpLvLimit)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("角色等级不足！"));
                return;
            }

            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Gold < petTupoConfig.CostGold)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("金币不足！"));
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (!ComHelp.IfNull(petTupoConfig.CostItem) && petTupoConfig.CostItem != "0" && !bagComponent.CheckNeedItem(petTupoConfig.CostItem))
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("道具不足！"));
                return;
            }

            C2M_PetTupoRequest request = new C2M_PetTupoRequest() { Position = self.Position };
            M2C_PetTupoResponse response =
                    (M2C_PetTupoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error == ErrorCode.ERR_Success)
            {
                PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
                if (response.RolePetInfos != null)
                {
                    for (int i = 0; i < response.RolePetInfos.Count; i++)
                    {
                        petComponent.OnRolePetUpdate(response.RolePetInfos[i]);
                    }
                }

                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("突破成功！"));

                UI uiPet = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
                UIPetComponent uiPetComponent = uiPet?.GetComponent<UIPetComponent>();
                UI petListUI = uiPetComponent?.UIPageView?.UISubViewList[(int)PetPageEnum.PetList];
                petListUI?.GetComponent<UIPetListComponent>()?.OnPetTupoSuccess();
            }
            else
            {
                ErrorHelp.Instance.ErrorHint(response.Error);
            }

            self.OnUpdateUI();
        }
    }
}
