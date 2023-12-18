using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetEquipSetComponent: Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;
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
        public BagInfo EquipdBagInfo;
        public RolePetInfo RolePetInfo;
        public List<UIItemComponent> uIItems = new List<UIItemComponent>();
        public List<string> AssetPath = new List<string>();
    }

    public class UIPetEquipSetComponentAwakeSystem: AwakeSystem<UIPetEquipSetComponent, GameObject>
    {
        public override void Awake(UIPetEquipSetComponent self, GameObject gameObject)
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
        }
    }

    public class UIPetEquipSetComponentDestroy: DestroySystem<UIPetEquipSetComponent>
    {
        public override void Destroy(UIPetEquipSetComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }

    public static class UIPetEquipSetComponentSystem
    {
        public static void OnUpdateUI(this UIPetEquipSetComponent self, RolePetInfo rolePetInfo, int position)
        {
            self.BagInfo = null;
            self.EquipdBagInfo = null;
            self.Position = position;
            self.RolePetInfo = rolePetInfo;
        }

        public static void UpdatePetEquipItem(this UIPetEquipSetComponent self, List<BagInfo> bagInfos)
        {
            self.ButtonHeXinHeCheng.SetActive(false);
            self.ButtonEquipXieXia.GetComponent<Button>().onClick.RemoveAllListeners();
            ButtonHelp.AddListenerEx(self.ButtonEquipXieXia, () => { self.OnButtonEquipXieXia().Coroutine(); });
            List<string> TypeNames = new List<string>() { "项圈", "铠甲", "护腕" };
            self.TextType.GetComponent<Text>().text = TypeNames[self.Position];

            UICommonHelper.DestoryChild(self.AttributeListNode);
            // 当前宠物装备的属性
            long baginfoId = 0;

            foreach (long l in self.RolePetInfo.PetEquipList)
            {
                BagInfo bagInfo1 = null;
                foreach (BagInfo info in bagInfos)
                {
                    if (info.BagInfoID == l)
                    {
                        bagInfo1 = info;
                        break;
                    }
                }

                if (bagInfo1 == null)
                {
                    continue;
                }

                ItemConfig itemConfig1 = ItemConfigCategory.Instance.Get(bagInfo1.ItemID);
                if (itemConfig1.ItemSubType - 3001 == self.Position)
                {
                    baginfoId = l;
                }
            }

            BagInfo bagInfo = null;
            for (int i = 0; i < bagInfos.Count; i++)
            {
                if (bagInfos[i].BagInfoID == baginfoId)
                {
                    bagInfo = bagInfos[i];
                }
            }

            self.EquipdBagInfo = bagInfo;
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
            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }

            self.ImageIcon.GetComponent<Image>().sprite = sp;

            // 显示属性，暂时不显示
            // self.ShowAttributeItemList(itemConfig.ItemUsePar, self.AttributeListNode, self.TextAttributeItem);
        }

        public static void ShowAttributeItemList(this UIPetEquipSetComponent self, string itemList, GameObject itemNodeList, GameObject attributeItem)
        {
            string[] attributeinfos = itemList.Split('@');
            for (int i = 0; i < attributeinfos.Length; i++)
            {
                if (string.IsNullOrEmpty(attributeinfos[i]))
                {
                    continue;
                }

                string[] attributeInfo = attributeinfos[i].Split(';');
                int numberType = int.Parse(attributeInfo[0]);
                float numberValue = float.Parse(attributeInfo[1]);
                GameObject gameObject = UnityEngine.Object.Instantiate(attributeItem);
                gameObject.SetActive(true);
                UICommonHelper.SetParent(gameObject, itemNodeList);
                string icon = ItemViewHelp.GetAttributeIcon(numberType);
                if (!string.IsNullOrEmpty(icon))
                {
                    string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PropertyIcon, icon);
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }

                    gameObject.transform.Find("Img_Icon").GetComponent<Image>().sprite = sp;
                }

                int showType = NumericHelp.GetNumericValueType(numberType);
                string attribute;
                if (showType == 2)
                {
                    attribute = $"{ItemViewHelp.GetAttributeName(numberType)} + {numberValue * 100}%";
                }
                else
                {
                    attribute = $"{ItemViewHelp.GetAttributeName(numberType)} + {numberValue}";
                }

                gameObject.transform.Find("Lab_ProTypeValue").GetComponent<Text>().text = attribute;
            }
        }

        public static void OnUpdateItemList(this UIPetEquipSetComponent self, List<BagInfo> bagInfos)
        {
            self.BagInfo = null;
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            int number = 0;
            self.uIItems.Clear();
            UICommonHelper.DestoryChild(self.PetHeXinListNode);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);

                if (itemConfig.ItemSubType - 3001 != self.Position)
                {
                    continue;
                }

                UIItemComponent uIItemComponent = null;
                if (number < self.uIItems.Count)
                {
                    uIItemComponent = self.uIItems[number];
                    uIItemComponent.GameObject.SetActive(true);
                }
                else
                {
                    GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(gameObject, self.PetHeXinListNode);
                    gameObject.transform.localScale = Vector3.one;
                    uIItemComponent = self.AddChild<UIItemComponent, GameObject>(gameObject);
                    uIItemComponent.HideItemName();
                    self.uIItems.Add(uIItemComponent);
                }

                uIItemComponent.UpdateItem(bagInfos[i], ItemOperateEnum.PetEquipBag);
                uIItemComponent.SetClickHandler(self.SelectItemHandlder);
                number++;
            }

            for (int i = number; i < self.uIItems.Count; i++)
            {
                self.uIItems[i].GameObject.SetActive(false);
            }
        }

        public static void SelectItemHandlder(this UIPetEquipSetComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            for (int i = 0; i < self.uIItems.Count; i++)
            {
                self.uIItems[i].SetSelected(bagInfo);
            }
        }

        public static async ETTask OnButtonEquipXieXia(this UIPetEquipSetComponent self)
        {
            long instanceid = self.InstanceId;
            if (self.EquipdBagInfo == null)
            {
                return;
            }

            C2M_PetEquipRequest request =
                    new C2M_PetEquipRequest() { BagInfoId = self.EquipdBagInfo.BagInfoID, PetInfoId = self.RolePetInfo.Id, OperateType = 2 };
            M2C_PetEquipResponse response =
                    (M2C_PetEquipResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            if (instanceid != self.InstanceId)
            {
                return;
            }

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            petComponent.OnRolePetUpdate(response.RolePetInfo);

            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
            uI.GetComponent<UIPetComponent>().OnEquipPetEquip();
        }

        public static async ETTask<int> OnButtonEquipHeXin(this UIPetEquipSetComponent self)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
            if (itemConfig.ItemSubType - 3001 != self.Position)
            {
                FloatTipManager.Instance.ShowFloatTip("孔位不符！");
                return -1;
            }

            long instanceid = self.InstanceId;

            C2M_PetEquipRequest request =
                    new C2M_PetEquipRequest() { BagInfoId = self.BagInfo.BagInfoID, PetInfoId = self.RolePetInfo.Id, OperateType = 1 };
            M2C_PetEquipResponse response =
                    (M2C_PetEquipResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success)
            {
                return -1;
            }

            if (instanceid != self.InstanceId)
            {
                return -1;
            }

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            petComponent.OnRolePetUpdate(response.RolePetInfo);

            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
            uI.GetComponent<UIPetComponent>().OnEquipPetEquip();
            return 0;
        }
    }
}