using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEngine.UI.CanvasScaler;
using System.Xml.Linq;

namespace ET
{
    public class UIRoleXiLianTransferComponent : Entity, IAwake
    {
        public GameObject ButtonTransfer;
        public GameObject UICommonCostItem;
        public GameObject UICommonItem_2;
        public GameObject UICommonItem_1;
        public GameObject UICommonItem_Copy;
        public GameObject ItemListNode;

        public BagInfo[] BagInfo_Transfer;
        public UIItemComponent[] UIItem_Transfer;
        public UICommonCostItemComponent UICommonCostItem_1;

        public List<UIItemComponent> UIEquipList = new List<UIItemComponent>();
        public Vector2 localPoint;
        public bool IsHoldDown;
    }


    public class UIRoleXiLianTransferComponentAwakeSystem : AwakeSystem<UIRoleXiLianTransferComponent>
    {
        public override void Awake(UIRoleXiLianTransferComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.IsHoldDown = false;
            self.BagInfo_Transfer = new BagInfo[2];
            self.UIItem_Transfer = new UIItemComponent[2];
            self.ButtonTransfer = rc.Get<GameObject>("ButtonTransfer");
            ButtonHelp.AddListenerEx( self.ButtonTransfer, () => { self.OnButtonTransfer().Coroutine(); } );

            self.UICommonCostItem = rc.Get<GameObject>("UICommonCostItem");
            self.UICommonItem_2 = rc.Get<GameObject>("UICommonItem_2");
            self.UICommonItem_1 = rc.Get<GameObject>("UICommonItem_1");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.OnInitUI();

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UIRoleXiLianTransferComponentSystem
    {
        public static async ETTask OnButtonTransfer(this UIRoleXiLianTransferComponent self)
        {
            string costItem = GlobalValueConfigCategory.Instance.Get(51).Value;
            if (!self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem(costItem))
            {
                FloatTipManager.Instance.ShowFloatTip("材料不足！");
                return;
            }

            if (self.BagInfo_Transfer[0] == null || self.BagInfo_Transfer[1] == null)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择合适的装备转移！");
                return;
            }

            //圣光装备洗练继承功能 布甲只能继承布甲 同类型只能继承同类型
            ItemConfig itemConfig_0 = ItemConfigCategory.Instance.Get(self.BagInfo_Transfer[0].ItemID);
            ItemConfig itemConfig_1 = ItemConfigCategory.Instance.Get(self.BagInfo_Transfer[1].ItemID);
            if (itemConfig_0.EquipType != itemConfig_1.EquipType)
            {
                FloatTipManager.Instance.ShowFloatTip("只有护甲类型相同的装备才能转移！");
                return;
            }


            //紫色品质以上才可以转移
            if (itemConfig_0.ItemQuality < 4 || itemConfig_1.ItemQuality < 4) {
                FloatTipManager.Instance.ShowFloatTip("只有紫色及以上品质的装备才能转移！");
                return;
            }

            C2M_ItemXiLianTransferRequest request = new C2M_ItemXiLianTransferRequest()
            {
                OperateBagID_1 = self.BagInfo_Transfer[0].BagInfoID,
                OperateBagID_2 = self.BagInfo_Transfer[1].BagInfoID
            };
            M2C_ItemXiLianTransferResponse response = (M2C_ItemXiLianTransferResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            FloatTipManager.Instance.ShowFloatTip("装备属性转移成功！");
            self.OnUpdateUI();
        }

        public static void OnInitUI(this UIRoleXiLianTransferComponent self)
        {
            self.UICommonCostItem_1 = self.AddChild<UICommonCostItemComponent, GameObject>(self.UICommonCostItem);
            self.UpdateCost();

            self.UIItem_Transfer[0] = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem_1);
            self.UIItem_Transfer[1] = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem_2);
            self.UIItem_Transfer[0].GameObject.SetActive(false);
            self.UIItem_Transfer[1].GameObject.SetActive(false);
        }

        public static void OnUpdateUI(this UIRoleXiLianTransferComponent self)
        {
            self.UpdateCost();
            self.ResetSelect();
            self.UpdateSelected();
            self.UpdateEquipItemUI().Coroutine();
        }

        public static void UpdateCost(this UIRoleXiLianTransferComponent self)
        {
            string[] costItem = GlobalValueConfigCategory.Instance.Get(51).Value.Split(';');
            self.UICommonCostItem_1.UpdateItem(int.Parse(costItem[0]), int.Parse(costItem[1]));
        }

        public static void ResetSelect(this UIRoleXiLianTransferComponent self)
        {
            self.BagInfo_Transfer[0] = null;
            self.BagInfo_Transfer[1] = null;
            self.UIItem_Transfer[0].GameObject.SetActive(false);
            self.UIItem_Transfer[1].GameObject.SetActive(false);
        }

        public static void UpdateSelect(this UIRoleXiLianTransferComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            BagInfo bagInfo_1 = bagComponent.GetBagInfo(self.BagInfo_Transfer[0].BagInfoID);
            BagInfo bagInfo_2 = bagComponent.GetBagInfo(self.BagInfo_Transfer[1].BagInfoID);
            self.UIItem_Transfer[0].UpdateItem(bagInfo_1, ItemOperateEnum.None);
            self.UIItem_Transfer[1].UpdateItem(bagInfo_2, ItemOperateEnum.None);
        }

        public static async ETTask UpdateEquipItemUI(this UIRoleXiLianTransferComponent self)
        {
            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            int number = 0;
            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetBagList();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                int itemID = bagInfos[i].ItemID;
                ItemConfig itemconf = ItemConfigCategory.Instance.Get(itemID);
                if (itemconf.ItemType != (int)ItemTypeEnum.Equipment || bagInfos[i].IfJianDing)
                {
                    continue;
                }

                if (itemconf.ItemQuality < 4) {
                    continue;
                }

                UIItemComponent uIItemComponent = null;
                if (number < self.UIEquipList.Count)
                {
                    uIItemComponent = self.UIEquipList[number];
                    uIItemComponent.GameObject.SetActive(true);
                }
                else
                {
                    GameObject skillItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(skillItem, self.ItemListNode);
                    uIItemComponent = self.AddChild<UIItemComponent, GameObject>(skillItem);
                    self.UIEquipList.Add(uIItemComponent);
                    uIItemComponent.SetEventTrigger(true);
                    uIItemComponent.BeginDragHandler = (BagInfo binfo, PointerEventData pdata) => { self.BeginDrag(binfo, pdata); };
                    uIItemComponent.DragingHandler = (BagInfo binfo, PointerEventData pdata) => { self.Draging(binfo, pdata); };
                    uIItemComponent.EndDragHandler = (BagInfo binfo, PointerEventData pdata) => { self.EndDrag(binfo, pdata); };
                    uIItemComponent.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerDown(binfo, pdata).Coroutine(); };
                    uIItemComponent.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerUp(binfo, pdata); };
                }
                uIItemComponent.UpdateItem(bagInfos[i], ItemOperateEnum.SkillSet);
                uIItemComponent.Image_XuanZhong.SetActive(false);
                number++;
            }

            for (int i = number; i < self.UIEquipList.Count; i++)
            {
                self.UIEquipList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask OnPointerDown(this UIRoleXiLianTransferComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = true;
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"1_{binfo.BagInfoID}");
            await TimerComponent.Instance.WaitAsync(400);
            if (!self.IsHoldDown)
                return;
            EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            EventType.ShowItemTips.Instance.bagInfo = binfo;
            EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
            EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static void OnPointerUp(this UIRoleXiLianTransferComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips);
        }

        public static void BeginDrag(this UIRoleXiLianTransferComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            self.UICommonItem_Copy = GameObject.Instantiate(self.UICommonItem_1);
            self.UICommonItem_Copy.SetActive(true);
            UICommonHelper.SetParent(self.UICommonItem_Copy, UIEventComponent.Instance.UILayers[(int)UILayer.Low].gameObject);

            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(binfo.ItemID);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            self.UICommonItem_Copy.transform.Find("Image_ItemIcon").GetComponent<Image>().sprite = sp;
            self.UICommonItem_Copy.transform.Find("Image_ItemQuality").gameObject.SetActive(false);
            self.UICommonItem_Copy.transform.Find("Image_Binding").gameObject.SetActive(false);
        }

        public static void Draging(this UIRoleXiLianTransferComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            RectTransform canvas = self.UICommonItem_Copy.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out self.localPoint);

            self.UICommonItem_Copy.transform.localPosition = new Vector3(self.localPoint.x, self.localPoint.y, 0f);
        }

        public static bool IsSelcted(this UIRoleXiLianTransferComponent self, long baginfoId)
        {
            long selctedId_1 = self.BagInfo_Transfer[0] != null ? self.BagInfo_Transfer[0].BagInfoID : 0;
            long selctedId_2 = self.BagInfo_Transfer[1] != null ? self.BagInfo_Transfer[1].BagInfoID : 0;
            return baginfoId == selctedId_1 || baginfoId == selctedId_2;
        }

        public static void UpdateSelected(this UIRoleXiLianTransferComponent self)
        {
            for (int i = 0; i < self.UIEquipList.Count; i++)
            {
                long bagInfoId  = self.UIEquipList[i].Baginfo.BagInfoID;
                bool selected = self.IsSelcted(bagInfoId);
                self.UIEquipList[i].Image_XuanZhong.SetActive(selected);
            }
        }

        public static void EndDrag(this UIRoleXiLianTransferComponent self, BagInfo binfo, PointerEventData pdata)
        {
            RectTransform canvas = self.UICommonItem_Copy.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;
                if (!name.Contains("UIRoleXiLianTransferItem_"))
                {
                    continue;
                }
                if (self.IsSelcted(binfo.BagInfoID))
                {
                    self.ResetSelect();
                }
                int index = int.Parse(name.Split('_')[1]);
                self.BagInfo_Transfer[index] = binfo;
                self.UIItem_Transfer[index].GameObject.SetActive(true);
                self.UIItem_Transfer[index].UpdateItem(binfo, ItemOperateEnum.None);
                break;
            }

            if (self.UICommonItem_Copy != null)
            {
                GameObject.Destroy(self.UICommonItem_Copy);
                self.UICommonItem_Copy = null;
            }
            self.UpdateSelected();
        }
    }
}