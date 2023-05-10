using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIUnionXiuLianComponent : Entity, IAwake
    {
        public GameObject XiuLianName;
        public GameObject XiuLianImageIcon;
        public GameObject FunctionSetBtn;
        public GameObject Button_Donation;
        public GameObject Pro_1;
        public GameObject Pro_0;
        public UIPageButtonComponent UIPageButton;

        public List<UIUnionXiuLianItemComponent> UIUnionXiuLianItemList = new List<UIUnionXiuLianItemComponent>();
        public int Position;
    }

    public class UIUnionXiuLianComponentAwake : AwakeSystem<UIUnionXiuLianComponent>
    {
        public override void Awake(UIUnionXiuLianComponent self)
        {
            self.Position = 0;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Button_Donation = rc.Get<GameObject>("Button_Donation");
            ButtonHelp.AddListenerEx(self.Button_Donation, () => { self.OnButton_Donation().Coroutine(); });

            self.Pro_1 = rc.Get<GameObject>("Pro_1");
            self.Pro_0 = rc.Get<GameObject>("Pro_0");
            self.XiuLianName = rc.Get<GameObject>("XiuLianName");

            self.XiuLianImageIcon = rc.Get<GameObject>("XiuLianImageIcon");
            self.UIUnionXiuLianItemList.Clear();
            for (int i = 0; i < 4; i++)
            {
                UIUnionXiuLianItemComponent uIUnionXiuLianItem = self.AddChild<UIUnionXiuLianItemComponent, GameObject>(rc.Get<GameObject>($"XiuLian_{i}"));
                uIUnionXiuLianItem.Position = i;
                uIUnionXiuLianItem.ClickHandler = self.OnClickHandler;
                self.UIUnionXiuLianItemList.Add(uIUnionXiuLianItem);
            }
            self.UIUnionXiuLianItemList[0].ClickHandler?.Invoke(0);

            self.FunctionSetBtn = rc.Get<GameObject>("FunctionSetBtn");
            UI pageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.FunctionSetBtn);
            self.UIPageButton = pageButton.AddComponent<UIPageButtonComponent>();
            self.UIPageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton.OnSelectIndex(0);
        }
    }

    public static class UIUnionXiuLianComponentSystem
    {

        public static void OnClickPageButton(this UIUnionXiuLianComponent self, int index)
        { 
            
        }

        public static void OnClickHandler(this UIUnionXiuLianComponent self, int position)
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

        public static void OnUpdateUI(this UIUnionXiuLianComponent self)
        {
            for (int i = 0; i < self.UIUnionXiuLianItemList.Count; i++)
            {
                self.UIUnionXiuLianItemList[i].OnUpdateUI(i);
            }

            int numerType = UnionHelper.GetXiuLianId(self.Position);

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
            //self.Pro_1.transform.Find("Text_Tip_1").GetComponent<Text>().text = $"下一等级: {nextunionQiangHuaConfig.QiangHuaLv}";
            self.Pro_1.transform.Find("Text_Tip_Pro_0").GetComponent<Text>().text = ItemViewHelp.GetAttributeDesc(nextunionQiangHuaConfig.EquipPropreAdd);
            self.Pro_1.transform.parent.transform.Find("Text_Tip_Pro_1").GetComponent<Text>().text = $"消耗:{unionQiangHuaConfig.CostGold}点家族贡献";
        }

        public static async ETTask OnButton_Donation(this UIUnionXiuLianComponent self)
        {
            //家族等级

            C2M_UnionXiuLianRequest request = new C2M_UnionXiuLianRequest() { Position = self.Position };
            M2C_UnionXiuLianResponse response = (M2C_UnionXiuLianResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.OnUpdateUI();
        }
    }

}
