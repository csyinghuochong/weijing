using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIPetHeXinHeChengComponent : Entity, IAwake
    {
        public GameObject Button_OneKey;
        public GameObject PetListNode;
        public GameObject Btn_Close;
        public GameObject BagItemCopy;
        public GameObject ImagePetHexinItemIcon;
        public List<UIItemComponent> uIItems = new List<UIItemComponent>();
        public ETCancellationToken cancellationToken;

        public bool IsHoldDown;
        public BagInfo BagInfo;
    }

    [ObjectSystem]
    public class UIPetHeXinHeChengComponentAwakeSystem : AwakeSystem<UIPetHeXinHeChengComponent>
    {
        public override void Awake(UIPetHeXinHeChengComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ImagePetHexinItemIcon = rc.Get<GameObject>("ImagePetHexinItemIcon");
            self.Button_OneKey = rc.Get<GameObject>("Button_OneKey");
            ButtonHelp.AddListenerEx( self.Button_OneKey, () => { self.Button_OneKey().Coroutine();  } );

            self.ImagePetHexinItemIcon.SetActive(false);
            self.PetListNode = rc.Get<GameObject>("PetListNode");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPetHeXinHeCheng );  });
            self.IsHoldDown = false;
            self.uIItems.Clear();

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIPetHeXinHeChengComponentSystem
    {
        public static async ETTask Button_OneKey(this UIPetHeXinHeChengComponent self)
        {
            C2M_PetHeXinHeChengQuickRequest c2M_PetHeXinHeChengRewardRequest = new C2M_PetHeXinHeChengQuickRequest()
            {
            };
            M2C_PetHeXinHeChengQuickResponse m2C_PetHeXinHeChengResponse = (M2C_PetHeXinHeChengQuickResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_PetHeXinHeChengRewardRequest);
            if (m2C_PetHeXinHeChengResponse.Error == 0)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("宠物之核合成成功！"));
            }
            self.OnUpdateUI().Coroutine();
            UI uIpet = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
            uIpet.GetComponent<UIPetComponent>().OnEquipPetHeXin();
        }

        public static async ETTask OnUpdateUI(this UIPetHeXinHeChengComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            int number = 0;
            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByLoc(ItemLocType.ItemPetHeXinBag);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                UIItemComponent uIItemComponent = null;
                if (number < self.uIItems.Count)
                {
                    uIItemComponent = self.uIItems[number];
                }
                else
                {
                    GameObject gameObject = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(gameObject, self.PetListNode);
                    uIItemComponent = self.AddChild<UIItemComponent, GameObject>(gameObject);
                    uIItemComponent.HideItemName();
                    uIItemComponent.SetEventTrigger(true);

                    uIItemComponent.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.PointerDown(binfo, pdata).Coroutine(); };
                    uIItemComponent.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.PointerUp(binfo, pdata); };
                    uIItemComponent.BeginDragHandler = (BagInfo binfo, PointerEventData pdata) => { self.BeginDrag(binfo, pdata); };
                    uIItemComponent.DragingHandler = (BagInfo binfo, PointerEventData pdata) => { self.Draging(binfo, pdata); };
                    uIItemComponent.EndDragHandler = (BagInfo binfo, PointerEventData pdata) => { self.EndDrag(binfo, pdata); };
                    self.uIItems.Add(uIItemComponent);
                }
                uIItemComponent.UpdateItem(bagInfos[i], ItemOperateEnum.None);
                uIItemComponent.Image_ItemButton.name = $"PetHeXinHeCheng_Image_ItemButton@{bagInfos[i].BagInfoID}";
                uIItemComponent.Label_ItemNum.GetComponent<Text>().text = $"{itemConfig.UseLv}级";
                number++;
            }

            for (int i = number; i < self.uIItems.Count; i++)
            {
                self.uIItems[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask PointerDown(this UIPetHeXinHeChengComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = true;
            self.BagInfo = binfo;
            self.cancellationToken?.Cancel();
            self.cancellationToken = new ETCancellationToken();
            bool ret = await TimerComponent.Instance.WaitAsync(200, self.cancellationToken);
            if (ret && self.IsHoldDown)
            {
                EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
                EventType.ShowItemTips.Instance.bagInfo = self.BagInfo;
                EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
                EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
                EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
                Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
            }
        }

        public static  void PointerUp(this UIPetHeXinHeChengComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            self.BagInfo = null;
            UIHelper.Remove( self.ZoneScene(), UIType.UIItemTips );
        }

        public static void BeginDrag(this UIPetHeXinHeChengComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            self.BagInfo = null;
            UIHelper.Remove(self.ZoneScene(), UIType.UIItemTips);
            self.BagItemCopy = GameObject.Instantiate(self.ImagePetHexinItemIcon);
            self.BagItemCopy.SetActive(true);
            UICommonHelper.SetParent(self.BagItemCopy, UIEventComponent.Instance.UILayers[(int)UILayer.Low].gameObject);

            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(binfo.ItemID);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            self.BagItemCopy.GetComponent<Image>().sprite = sp;
        }

        public static void Draging(this UIPetHeXinHeChengComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            self.BagInfo = null;
            Vector2 localPoint;
            RectTransform canvas = self.BagItemCopy.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);

            self.BagItemCopy.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
        }

        public static void EndDrag(this UIPetHeXinHeChengComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            self.BagInfo = null;
            RectTransform canvas = self.BagItemCopy.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;
                if (!name.Contains("PetHeXinHeCheng_Image_ItemButton"))
                {
                    continue;
                }
                long baginfoId = long.Parse( name.Split('@')[1] );
                self.RequestPetHeXinHeCheng(binfo, self.ZoneScene().GetComponent<BagComponent>().GetBagInfo(baginfoId)).Coroutine();
                break;
            }

            if (self.BagItemCopy != null)
            {
                GameObject.Destroy(self.BagItemCopy);
                self.BagItemCopy = null;
            }
        }

        public static async ETTask RequestPetHeXinHeCheng(this UIPetHeXinHeChengComponent self, BagInfo bagInfo1, BagInfo bagInfo2)
        {
            if (bagInfo1.BagInfoID == bagInfo2.BagInfoID)
            {
                return;
            }

            if (bagInfo1.ItemID != bagInfo2.ItemID)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("同类型和同等级的宠物之核才能合成！"));
                return;
            }
            C2M_PetHeXinHeChengRequest c2M_PetHeXinHeChengRewardRequest = new C2M_PetHeXinHeChengRequest()
            {
                BagInfoID_1 = bagInfo1.BagInfoID,
                BagInfoID_2 = bagInfo2.BagInfoID,
            };
            M2C_PetHeXinHeChengResponse m2C_PetHeXinHeChengResponse = (M2C_PetHeXinHeChengResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_PetHeXinHeChengRewardRequest);
            if (m2C_PetHeXinHeChengResponse.Error == 0)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("宠物之核合成成功！"));
            }

            self.OnUpdateUI().Coroutine();
            UI uIpet = UIHelper.GetUI( self.ZoneScene(), UIType.UIPet );
            uIpet.GetComponent<UIPetComponent>().OnEquipPetHeXin();
        }
    }
}
