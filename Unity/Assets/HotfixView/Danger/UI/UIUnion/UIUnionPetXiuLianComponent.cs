using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionPetXiuLianComponent: Entity, IAwake
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

    public class UIUnionPetXiuLianComponentAwake: AwakeSystem<UIUnionPetXiuLianComponent>
    {
        public override void Awake(UIUnionPetXiuLianComponent self)
        {
            self.Position = 0;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem.SetActive(false);
            self.CostItemListNode = rc.Get<GameObject>("CostItemListNode");
            self.Button_Donation = rc.Get<GameObject>("Button_Donation");
            ButtonHelp.AddListenerEx(self.Button_Donation, () => { self.OnButton_Donation().Coroutine(); });

            self.Pro_1 = rc.Get<GameObject>("Pro_1");
            self.Pro_0 = rc.Get<GameObject>("Pro_0");
            self.XiuLianName = rc.Get<GameObject>("XiuLianName");

            self.XiuLianImageIcon = rc.Get<GameObject>("XiuLianImageIcon");
            self.UIUnionXiuLianItemList.Clear();
            for (int i = 0; i < 4; i++)
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

    public static class UIUnionPetXiuLianComponentSystem
    {
        public static void OnClickHandler(this UIUnionPetXiuLianComponent self, int position)
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

        public static void OnUpdateUI(this UIUnionPetXiuLianComponent self)
        {
            for (int i = 0; i < self.UIUnionXiuLianItemList.Count; i++)
            {
                self.UIUnionXiuLianItemList[i].OnUpdateUI(i, 1);
            }

            int numerType = UnionHelper.GetXiuLianId(self.Position, 1);

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int xiulianid = numericComponent.GetAsInt(numerType);
            UnionQiangHuaConfig unionQiangHuaConfig = UnionQiangHuaConfigCategory.Instance.Get(xiulianid);
            self.XiuLianName.GetComponent<Text>().text = unionQiangHuaConfig.EquipSpaceName;
            //self.Pro_0.transform.Find("Text_Tip_1").GetComponent<Text>().text = $"当前等级: {unionQiangHuaConfig.QiangHuaLv}";

            self.Pro_0.transform.Find("Text_Tip_Pro_0").GetComponent<Text>().text = ItemViewHelp.GetAttributeDesc(unionQiangHuaConfig.EquipPropreAdd);

            if (unionQiangHuaConfig.NextID == 0)
            {
                self.Pro_1.SetActive(false);
                return;
            }

            self.Pro_1.SetActive(true);
            int nextxiulianid = numericComponent.GetAsInt(numerType) + 1;
            UnionQiangHuaConfig nextunionQiangHuaConfig = UnionQiangHuaConfigCategory.Instance.Get(nextxiulianid);
            self.Pro_1.transform.Find("Text_Tip_Pro_0").GetComponent<Text>().text =
                    ItemViewHelp.GetAttributeDesc(nextunionQiangHuaConfig.EquipPropreAdd);

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            string[] items1 = new[] { $"16;{unionQiangHuaConfig.CostGold}" };
            string[] items2 = unionQiangHuaConfig.CostItem.Split('@');
            string[] items = items1.Concat(items2).ToArray();
            int num = 0;
            foreach (string item in items)
            {
                string[] str = item.Split(';');
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
                itemComponent.Label_ItemNum.GetComponent<Text>().text = $"{itemNum}/{havedNum}";
                itemComponent.Label_ItemNum.GetComponent<Text>().color =
                        havedNum >= itemNum? new Color(0, 1, 0) : new Color(245f / 255f, 43f / 255f, 96f / 255f);
                num++;
            }

            for (int i = num; i < self.UIItemComponentList.Count; i++)
            {
                self.UIItemComponentList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask OnButton_Donation(this UIUnionPetXiuLianComponent self)
        {
            //家族等级
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long unionid = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0);
            C2U_UnionMyInfoRequest c2U_UnionMyInfo = new C2U_UnionMyInfoRequest() { UnionId = unionid };
            U2C_UnionMyInfoResponse respose =
                    (U2C_UnionMyInfoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2U_UnionMyInfo);
            if (respose.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            int unitonlevel = respose.UnionMyInfo.Level;
            UnionConfig unionConfig = UnionConfigCategory.Instance.Get(unitonlevel);
            int numerType = UnionHelper.GetXiuLianId(self.Position, 1);
            int xiulianid = unit.GetComponent<NumericComponent>().GetAsInt(numerType);
            UnionQiangHuaConfig unionQiangHuaConfig = UnionQiangHuaConfigCategory.Instance.Get(xiulianid);
            if (unionQiangHuaConfig.QiangHuaLv >= unionConfig.XiuLianLevel)
            {
                FloatTipManager.Instance.ShowFloatTip("请先提升家族等级！");
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (!bagComponent.CheckNeedItem(unionQiangHuaConfig.CostItem))
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足！");
                return;
            }

            C2M_UnionXiuLianRequest request = new C2M_UnionXiuLianRequest() { Position = self.Position, Type = 1 };
            M2C_UnionXiuLianResponse response =
                    (M2C_UnionXiuLianResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.OnUpdateUI();
        }
    }
}