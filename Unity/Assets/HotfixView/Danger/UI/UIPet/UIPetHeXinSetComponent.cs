using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetHeXinSetComponent : Entity, IAwake<GameObject>
    {
        public GameObject ButtonEquipXieXia;
        public GameObject ButtonHeXinHeCheng;
        public GameObject TextAttributeItem;
        public GameObject ImageIcon;
        public GameObject PetHeXinListNode;
        public GameObject ButtonEquipHeXin;
        public GameObject AttributeListNode;
        public GameObject TextLevel;
        public GameObject TextName;
        public GameObject TextType;

        public int Position;
        public BagInfo BagInfo;
        public GameObject GameObject;
        public RolePetInfo RolePetInfo;
        public List<UIItemComponent> uIItems = new List<UIItemComponent> ();
    }

    [ObjectSystem]
    public class UIPetHeXinSetComponentAwakeSystem : AwakeSystem<UIPetHeXinSetComponent, GameObject>
    {
        public override void Awake(UIPetHeXinSetComponent self, GameObject gameObject)
        {
            self.uIItems.Clear();
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextAttributeItem = rc.Get<GameObject>("TextAttributeItem");
            self.TextAttributeItem.SetActive(false);

            self.ButtonEquipXieXia = rc.Get<GameObject>("ButtonEquipXieXia");
            self.PetHeXinListNode = rc.Get<GameObject>("PetHeXinListNode");
            self.ButtonEquipHeXin = rc.Get<GameObject>("ButtonEquipHeXin");
            self.AttributeListNode = rc.Get<GameObject>("AttributeListNode");
            self.ButtonHeXinHeCheng = rc.Get<GameObject>("ButtonHeXinHeCheng");
            self.TextLevel = rc.Get<GameObject>("TextLevel");
            self.TextName = rc.Get<GameObject>("TextName");
            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
            self.TextType = rc.Get<GameObject>("TextType");

            ButtonHelp.AddListenerEx(self.ButtonEquipHeXin, () => { self.OnButtonEquipHeXin().Coroutine(); });
            ButtonHelp.AddListenerEx(self.ButtonHeXinHeCheng, () => { self.OnButtonHeXinHeCheng(); });
            ButtonHelp.AddListenerEx( self.ButtonEquipXieXia, () => { self.OnButtonEquipXieXia().Coroutine();  });
        }
    }

    public static class UIPetHeXinSetComponentSystem
    {

        public static void OnUpdateUI(this UIPetHeXinSetComponent self, RolePetInfo rolePetInfo, int position)
        {
            self.BagInfo = null;
            self.Position = position;
            self.RolePetInfo = rolePetInfo;
        }

        public static void OnButtonHeXinHeCheng(this UIPetHeXinSetComponent self)
        {
            UIHelper.Create( self.ZoneScene(), UIType.UIPetHeXinHeCheng ).Coroutine();
        }

        public static void UpdatePetHexinItem(this UIPetHeXinSetComponent self, List<BagInfo> bagInfos)
        {
            List<string> TypeNames = new List<string>() { "进攻能量", "守护能量", "生命能量" };
            self.TextType.GetComponent<Text>().text = TypeNames[self.Position];

            UICommonHelper.DestoryChild(self.AttributeListNode);
            long baginfoId = self.RolePetInfo.PetHeXinList[self.Position];
            BagInfo bagInfo = null;
            for (int i = 0; i < bagInfos.Count; i++)
            {
                if (bagInfos[i].BagInfoID == baginfoId)
                {
                    bagInfo = bagInfos[i];
                }
            }
            self.ImageIcon.SetActive(bagInfo != null);
            self.ButtonEquipXieXia.SetActive(bagInfo != null);
            if (bagInfo == null)
            {
                self.TextName.GetComponent<Text>().text = "空";
                self.TextLevel.GetComponent<Text>().text = "等级: 0";
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            self.TextName.GetComponent<Text>().text = itemConfig.ItemName;
            self.TextLevel.GetComponent<Text>().text = $"等级: {itemConfig.UseLv}";
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            self.ImageIcon.GetComponent<Image>().sprite = sp;

            UICommonHelper.ShowAttributeItemList(itemConfig.ItemUsePar, self.AttributeListNode, self.TextAttributeItem);
        }

        public static void  OnUpdateItemList(this UIPetHeXinSetComponent self, List<BagInfo> bagInfos)
        {
            self.BagInfo = null;
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            int number = 0;
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get( bagInfos[i].ItemID );
                UIItemComponent uIItemComponent = null;
                if (number < self.uIItems.Count)
                {
                    uIItemComponent = self.uIItems[number];
                    uIItemComponent.GameObject.SetActive(true);
                }
                else
                {
                    GameObject gameObject = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(gameObject, self.PetHeXinListNode);
                    gameObject.transform.localScale = Vector3.one;
                    uIItemComponent = self.AddChild<UIItemComponent, GameObject>(gameObject);
                    uIItemComponent.HideItemName();
                    self.uIItems.Add(uIItemComponent);
                }
                uIItemComponent.UpdateItem(bagInfos[i], ItemOperateEnum.PetHeXinBag);
                uIItemComponent.SetClickHandler(self.SelectItemHandlder);
                uIItemComponent.Label_ItemNum.GetComponent<Text>().text = $"{itemConfig.UseLv}级";
                number++;
            }

            for (int i = number; i < self.uIItems.Count; i++)
            {
                self.uIItems[i].GameObject.SetActive(false);
            }
        }

        public static void SelectItemHandlder(this UIPetHeXinSetComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            for (int i = 0; i < self.uIItems.Count; i++)
            {
                self.uIItems[i].SetSelected(bagInfo);
            }
        }

        public static async ETTask OnButtonEquipXieXia(this UIPetHeXinSetComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            long baginfoId = self.RolePetInfo.PetHeXinList[self.Position];
            BagInfo bagInfo = bagComponent.GetBagInfo(baginfoId);

            C2M_RolePetHeXin c2M_RolePetHeXin = new C2M_RolePetHeXin() { OperateType = 2, BagInfoId = bagInfo.BagInfoID, PetInfoId = self.RolePetInfo.Id, Position = self.Position };
            M2C_RolePetHeXin m2C_RolePetHeXin = (M2C_RolePetHeXin)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetHeXin);
            self.ZoneScene().GetComponent<PetComponent>().OnRolePetUpdate(m2C_RolePetHeXin.RolePetInfo);
            self.RolePetInfo = m2C_RolePetHeXin.RolePetInfo;
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
            uI.GetComponent<UIPetComponent>().OnEquipPetHeXin();
        }

        public static async ETTask<int> OnButtonEquipHeXin(this UIPetHeXinSetComponent self)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
            if (itemConfig.ItemType != (int)ItemTypeEnum.PetHeXin)
            {
                return -1;
            }
            if (itemConfig.ItemSubType -1 != self.Position)
            {
                FloatTipManager.Instance.ShowFloatTip("孔位不符！");
                return -1;
            }
            C2M_RolePetHeXin c2M_RolePetHeXin = new C2M_RolePetHeXin() { OperateType = 1,  BagInfoId = self.BagInfo.BagInfoID, PetInfoId = self.RolePetInfo.Id, Position = self.Position };
            M2C_RolePetHeXin m2C_RolePetHeXin = (M2C_RolePetHeXin)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetHeXin);
            if (m2C_RolePetHeXin.Error != ErrorCore.ERR_Success)
            {
                return -1;
            }

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            petComponent.OnRolePetUpdate( m2C_RolePetHeXin.RolePetInfo);

            UI uI = UIHelper.GetUI( self.ZoneScene(), UIType.UIPet );
            uI.GetComponent<UIPetComponent>().OnEquipPetHeXin();
            return 0;
        }
    }
}