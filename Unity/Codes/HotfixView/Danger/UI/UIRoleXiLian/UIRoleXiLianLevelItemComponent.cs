using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleXiLianLevelItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextShuLianDu;
        public GameObject TextLevelTip;
        public GameObject TextAttribute;
        public GameObject TextTitle;

        public GameObject Image_Acvityed;
        public GameObject GameObject;
        public float PostionY;
    }

    [ObjectSystem]
    public class UIRoleXiLianLevelItemComponentAwakeSystem : AwakeSystem<UIRoleXiLianLevelItemComponent, GameObject>
    {
        public override void Awake(UIRoleXiLianLevelItemComponent self, GameObject go)
        {
            self.GameObject = go;

            ReferenceCollector rc = go.GetComponent<ReferenceCollector>();
            self.TextShuLianDu = rc.Get<GameObject>("TextShuLianDu");
            self.TextLevelTip = rc.Get<GameObject>("TextLevelTip");
            self.TextAttribute = rc.Get<GameObject>("TextAttribute");
            self.TextTitle = rc.Get<GameObject>("TextTitle");
            self.Image_Acvityed = rc.Get<GameObject>("Image_Acvityed");
        }
    }

    public static class UIRoleXiLianLevelItemComponentSystem
    {
        public static void OnUpdateUI(this UIRoleXiLianLevelItemComponent self, int xilianId)
        {
            EquipXiLianConfig equipXiLianConfig = EquipXiLianConfigCategory.Instance.Get(xilianId);
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            int shuliandu = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.XiLianLevel);

            bool actived = shuliandu >= equipXiLianConfig.NeedShuLianDu;
            self.TextShuLianDu.GetComponent<Text>().text = $"需要洗练熟练度 {shuliandu}/{equipXiLianConfig.NeedShuLianDu}";
            self.TextShuLianDu.GetComponent<Text>().color = actived ? Color.green : Color.red;
            self.TextTitle.GetComponent<Text>().text = equipXiLianConfig.Title;

            self.Image_Acvityed.SetActive(actived);
        }
    }
}
