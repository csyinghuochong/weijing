using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMagickaSlotItemComponent : Entity, IAwake<GameObject>, IDestroy
    {

        public int Position;
        public GameObject GameObject;
        public GameObject Image_Lock;
        public GameObject XuanZhong;
        public GameObject DiButton_1;
        public UIItemComponent UICommonItem;

        public Action<int, int> ClickLockHandler;
    }

    public class UIMagickaSlotItemComponentAwake : AwakeSystem<UIMagickaSlotItemComponent, GameObject>
    {

        public override void Awake(UIMagickaSlotItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;

            self.Image_Lock = gameObject.transform.Find("Image_Lock").gameObject;
            self.XuanZhong = gameObject.transform.Find("XuanZhong").gameObject;
            self.DiButton_1 = gameObject.transform.Find("DiButton_1").gameObject;

            GameObject uICommonItem = gameObject.transform.Find("UICommonItem").gameObject;
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(uICommonItem);
            self.UICommonItem.GameObject.SetActive(false);

            self.DiButton_1.GetComponent<Button>().onClick.AddListener(self.OnClickImage_Lock);
            self.Image_Lock.GetComponent<Button>().onClick.AddListener(self.OnClickImage_Lock);
        }
    }

    public static class UIMagickaSlotItemComponentSystem
    {

        public static void InitData(this UIMagickaSlotItemComponent self, int position, Action<int, int> click)
        {
            self.Position = position;
            self.ClickLockHandler = click;

            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIMagickaSlotItemComponent self)
        {
            int curid = self.ZoneScene().GetComponent<ChengJiuComponent>().GetCurrentMagickaSlotIdByPosition(self.Position);
            self.Image_Lock.SetActive(curid == 0);

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            BagInfo bagInfo = bagComponent.GetMagicEquipBySubType( ItemLocType.ItemLocEquip, self.Position);
            if (bagInfo == null)
            {
                self.UICommonItem.GameObject.SetActive(false);
                return;
            }
            self.UICommonItem.GameObject.SetActive(true);
            self.UICommonItem.UpdateItem(bagInfo, ItemOperateEnum.MagicSlot);

        }

        public static void OnClickImage_Lock(this UIMagickaSlotItemComponent self)
        {
            self.ClickLockHandler?.Invoke( self.Position, -2 );
         }

        public static void SetSelected(this UIMagickaSlotItemComponent self, bool active)
        {
            self.XuanZhong.SetActive(active);
        }

    }
}