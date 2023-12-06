using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIOpenChestComponent: Entity, IAwake
    {
        public GameObject UICommonItem;
        public GameObject OpenBtn;
        public GameObject Btn_Close;

        public Unit Box;
    }

    public class UIOpenChestComponentAwakeSystem: AwakeSystem<UIOpenChestComponent>
    {
        public override void Awake(UIOpenChestComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.OpenBtn = rc.Get<GameObject>("OpenBtn");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");

            self.OpenBtn.GetComponent<Button>().onClick.AddListener(self.OnOpenBtn);
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIOpenChest); });
        }
    }

    public static class UIOpenChestComponentSystem
    {
        public static void UpdateInfo(this UIOpenChestComponent self, Unit Box)
        {
            self.Box = Box;
            int monsterid = Box.ConfigId;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterid);
            UIItemComponent uI = null;
            uI = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem);
            uI.UpdateItem(new BagInfo() { ItemID = monsterConfig.Parameter[0], ItemNum = monsterConfig.Parameter[1] }, ItemOperateEnum.None);
        }

        public static  void OnOpenBtn(this UIOpenChestComponent self)
        {
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uI.GetComponent<UIMainComponent>().UIOpenBoxComponent.OnOpenBox(self.Box);
            UIHelper.Remove(self.ZoneScene(), UIType.UIOpenChest);
        }
    }
}