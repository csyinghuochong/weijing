using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIGuideEquipComponent: Entity, IAwake
    {
        public GameObject CloseBtn;
        public GameObject UICommonItem;
        public GameObject EquipBtn;

        public BagInfo BagInfo;
    }

    public class UIGuideEquipComponentAwakeSystem: AwakeSystem<UIGuideEquipComponent>
    {
        public override void Awake(UIGuideEquipComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.CloseBtn = rc.Get<GameObject>("CloseBtn");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.EquipBtn = rc.Get<GameObject>("EquipBtn");

            self.CloseBtn.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIGuideEquip); });
            self.EquipBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnEquipBtn(); });
        }
    }

    public static class UIGuideEquipComponentSystem
    {
        public static void UpdateInfo(this UIGuideEquipComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;

            UIItemComponent uI = null;
            uI = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem);
            uI.UpdateItem(bagInfo, ItemOperateEnum.None);
        }

        public static void OnEquipBtn(this UIGuideEquipComponent self)
        {
            self.ZoneScene().GetComponent<BagComponent>().SendWearEquip(self.BagInfo).Coroutine();
            UIHelper.Remove(self.ZoneScene(), UIType.UIGuideEquip);
        }
    }
}