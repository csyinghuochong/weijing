using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIWearWeaponComponent : Entity, IAwake, IDestroy
    {
        public GameObject TextTip3;
        public GameObject RawImage;
        public GameObject ButtonClose;
    }

    public class UIWearWeaponComponentAwake : AwakeSystem<UIWearWeaponComponent>
    {
        public override void Awake(UIWearWeaponComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextTip3 = rc.Get<GameObject>("TextTip3");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            ButtonHelp.AddListenerEx(self.ButtonClose, self.OnButtonClose);

            self.OnInitUI();
        }
    }

    public static class UIWearWeaponComponentSystem
    {

        public static void OnButtonClose(this UIWearWeaponComponent self)
        {
            UIHelper.Remove( self.ZoneScene(), UIType.UIWearWeapon );
        }

        public static void OnInitUI(this UIWearWeaponComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            int weaponid = unit.GetComponent<NumericComponent>().GetAsInt( NumericType.Now_Weapon );
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(weaponid);

            string tip = string.Empty;

            tip = itemConfig.ItemName;
            self.TextTip3.GetComponent<Text>().text = $"恭喜你获得了自己的{tip}";
        }
    }
}
