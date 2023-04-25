using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionXiuLianItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImageIcon;
        public GameObject ImageSelect;
        public GameObject Text_Tip_1;

        public Action<int> ClickHandler;
        public int Position;
    }

    public class UIUnionYiuLianItemComponentAwake : AwakeSystem<UIUnionXiuLianItemComponent, GameObject>
    {
        public override void Awake(UIUnionXiuLianItemComponent self, GameObject a)
        {
            self.ImageIcon = a.transform.Find("ImageIcon").gameObject;
            self.ImageSelect = a.transform.Find("ImageSelect").gameObject;
            self.Text_Tip_1 = a.transform.Find("Text_Tip_1").gameObject;

            self.ImageIcon.GetComponent<Button>().onClick.AddListener(() => { self.ClickHandler(self.Position); });
        }
    }

    public static class UIUnionXiuLianItemComponentSystem
    {
        public static void OnUpdateUI(this UIUnionXiuLianItemComponent self, int postion)
        {
            int numerType = UnionHelper.GetXiuLianId(postion);
            
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int xiulianid = numericComponent.GetAsInt(numerType);
            UnionQiangHuaConfig unionQiangHuaConfig = UnionQiangHuaConfigCategory.Instance.Get(xiulianid);
            self.Text_Tip_1.GetComponent<Text>().text = unionQiangHuaConfig.EquipSpaceName;
        }
    }
}
