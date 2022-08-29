using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIItemComponent : Entity, IAwake, IAwake<GameObject>
    {

        public GameObject GameObject;
        public string BagPosition;             
        public string SpaceType;
        public GameObject Label_ItemName;
        public GameObject Image_ItemButton;
        public GameObject Image_ItemIcon;
        public GameObject Label_ItemNum;
        public GameObject Image_ItemQuality;
        public GameObject Image_XuanZhong;
        public GameObject UI_ItemEffect;
        public GameObject UI_SclectImg;
        public GameObject Image_EventTrigger;
        public GameObject Obj_Image_ItemDi;
        public GameObject Image_Binding;
        public bool UpdataItemShow;
        public int ItemID;
        public string ItemNum;
        public string ItemIcon;
        public int ItemQuality;
        public GameObject obj_ItemTips;
        public GameObject moveIconObj;
        public Sprite itemIcon;
        public GameObject SellItemObj;
        public GameObject SellItemTextObj;

        public bool MoveBagStatus = true;
        public float lastMovePosition_Y;
        public int lastItemID;
        public long PaiMaiId;
        public BagInfo Baginfo;

        public ItemOperateEnum ItemOperateEnum;
        public Action<long> ClickPaiMaiHandler;
        public Action<BagInfo> ClickItemHandler;
        public Action<BagInfo, PointerEventData> BeginDragHandler;
        public Action<BagInfo, PointerEventData> DragingHandler;
        public Action<BagInfo, PointerEventData> EndDragHandler;
        public Action<BagInfo, PointerEventData> PointerDownHandler;
        public Action<BagInfo, PointerEventData> PointerUpHandler;
    }

    [ObjectSystem]
    public class UIItemComponentAwakeSystem1 : AwakeSystem<UIItemComponent, GameObject>
    {
        public override void Awake(UIItemComponent self, GameObject gameObject)
        {
            self.OnAwake(gameObject);
        }
    }

    [ObjectSystem]
    public class UIItemComponentAwakeSystem : AwakeSystem<UIItemComponent>
    {
        public override void Awake(UIItemComponent self)
        {
            self.OnAwake(self.GetParent<UI>().GameObject);
        }
    }

    public static class UIItemComponentSystem
    {
        public static void OnAwake(this UIItemComponent self, GameObject go)
        {
            ReferenceCollector  rc = go.GetComponent<ReferenceCollector>();
            self.GameObject = go;
            self.ItemID = 0;
            self.ClickItemHandler = null;
            self.ClickPaiMaiHandler = null;
            self.Image_ItemQuality = rc.Get<GameObject>("Image_ItemQuality");
            self.Image_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");
            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum");
            self.Image_ItemButton = rc.Get<GameObject>("Image_ItemButton");
            self.Image_EventTrigger = rc.Get<GameObject>("Image_EventTrigger");
            self.Label_ItemName = rc.Get<GameObject>("Label_ItemName");
            self.Image_XuanZhong = rc.Get<GameObject>("Image_XuanZhong");
            self.Obj_Image_ItemDi = rc.Get<GameObject>("Image_ItemDi");
            self.Image_Binding = rc.Get<GameObject>("Image_Binding");


            if (self.Image_Binding != null)
            {
                self.Image_Binding.SetActive(false);
            }

            self.Image_EventTrigger.SetActive(false);
            self.Image_XuanZhong.SetActive(false);
            self.Image_ItemButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickUIItem(); });
        }

        public static void SetSelected(this UIItemComponent self, BagInfo bagInfo)
        {
            self.Image_XuanZhong.SetActive(self.Baginfo == bagInfo && self.Baginfo!=null);
        }

        public static void BeginDrag(this UIItemComponent self, PointerEventData pdata)
        {
            self.BeginDragHandler?.Invoke(self.Baginfo, pdata);
        }

        public static void Draging(this UIItemComponent self, PointerEventData pdata)
        {
            self.DragingHandler?.Invoke(self.Baginfo, pdata);
        }

        public static void EndDrag(this UIItemComponent self, PointerEventData pdata)
        {
            self.EndDragHandler?.Invoke(self.Baginfo, pdata);
        }

        public static void PointerDown(this UIItemComponent self, PointerEventData pdata)
        {
            self.PointerDownHandler?.Invoke(self.Baginfo, pdata);
        }

        public static void PointerUp(this UIItemComponent self, PointerEventData pdata)
        {
            self.PointerUpHandler?.Invoke(self.Baginfo, pdata);
        }

        public static void SetEventTrigger(this UIItemComponent self, bool value = true)
        {
            self.Image_EventTrigger.SetActive(value);

            ButtonHelp.AddEventTriggers(self.Image_EventTrigger, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.Image_EventTrigger, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.Image_EventTrigger, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(self.Image_EventTrigger, (PointerEventData pdata) => { self.PointerDown(pdata); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Image_EventTrigger, (PointerEventData pdata) => { self.PointerUp(pdata); }, EventTriggerType.PointerUp);
        }

        public static void SetClickHandler(this UIItemComponent self, Action<BagInfo> action)
        {
            self.ClickItemHandler = action;
        }

        public static void OnClickUIItem(this UIItemComponent self)
        {
            if (self.Baginfo == null)
            {
                return;
            }

            if (self.ClickItemHandler != null)
            {
                self.ClickItemHandler(self.Baginfo);
            }
            if (self.ClickPaiMaiHandler != null)
            {
                self.ClickPaiMaiHandler(self.PaiMaiId);
            }

            if (self.ItemOperateEnum != ItemOperateEnum.ItemXiLian
                && self.ItemOperateEnum != ItemOperateEnum.PaiMaiSell)
            {
                //弹出Tips
                EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
                EventType.ShowItemTips.Instance.bagInfo = self.Baginfo;
                EventType.ShowItemTips.Instance.itemOperateEnum = self.ItemOperateEnum;
                EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
                EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
                Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
            }
        }

        public static BagInfo GetBagInfo(this UIItemComponent self)
        {
            return self.Baginfo;
        }

        //隐藏道具名称显示
        public static void HideItemName(this UIItemComponent self) {

            self.Label_ItemName.SetActive(false);
        }

        public static  void ShowIcon(this UIItemComponent self)
        {
            Sprite sp =  ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, self.ItemIcon);
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;
        }

        //更新显示
        public static void UpdateItem(this UIItemComponent self, BagInfo bagInfo, ItemOperateEnum itemOperateEnum = ItemOperateEnum.None )
        {

            self.Baginfo = bagInfo;
            self.ItemOperateEnum = itemOperateEnum;
            if (bagInfo != null)
            {
                self.ItemID = bagInfo.ItemID;
            }
            else
            {
                self.ItemID = 0;
            }
    
            bool ifShowImg = true;
            //if (self.ItemID == self.lastItemID)
            //{
            //    ifShowImg = false;
            //}
            
            self.lastItemID = self.ItemID;
            if (self.ItemID != 0)
            {
                self.Image_ItemQuality.SetActive(true);
                self.Image_ItemIcon.SetActive(true);

                ItemConfig itemconfig = ItemConfigCategory.Instance.Get(self.ItemID);

                if (itemOperateEnum != ItemOperateEnum.Shop && itemOperateEnum != ItemOperateEnum.TaskItem)
                {
                    self.Label_ItemNum.SetActive(true);
                    self.ItemNum = bagInfo.ItemNum.ToString();
                    self.Label_ItemNum.GetComponent<Text>().text = self.ItemNum;
                }

                if (self.Label_ItemName != null)
                {
                    self.Label_ItemName.GetComponent<Text>().text = itemconfig.ItemName;
                    self.Label_ItemName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemconfig.ItemQuality);
                }

                if (self.Image_Binding != null)
                {
                    self.Image_Binding.SetActive(bagInfo.isBinging);
                }

                if (ifShowImg)
                {
                    self.ItemIcon = itemconfig.Icon;
                    self.ItemQuality = itemconfig.ItemQuality;

                    self.ShowIcon();
                    string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(self.ItemQuality);
                    self.Image_ItemQuality.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
                    int itemType = itemconfig.ItemType;
                    if (itemType == 3)
                    {
                        self.Label_ItemNum.GetComponent<Text>().text = "";
                    }

                    if (self.Obj_Image_ItemDi != null)
                    {
                        self.Obj_Image_ItemDi.SetActive(false);
                    }
                }

                //显示道具数量
                if (ComHelp.IfNull(self.ItemNum) == false)
                {
                    if (long.Parse(self.ItemNum) >= 1 && itemconfig.ItemType != 3)
                    {
                        self.Label_ItemNum.GetComponent<Text>().text = ComHelp.ReturnNumStr(long.Parse(self.ItemNum));
                    }
                    else
                    {
                        self.Label_ItemNum.SetActive(false);
                    }
                }
            }
            else
            {
                //空格子
                self.Image_ItemQuality.SetActive(false);
                self.Image_ItemIcon.SetActive(false);
                self.Label_ItemNum.SetActive(false);
                if (self.Obj_Image_ItemDi != null)
                {
                    self.Obj_Image_ItemDi.SetActive(true);
                }
                if (self.Image_Binding != null)
                {
                    self.Image_Binding.SetActive(false);
                }
            }

            //清空选中
            self.Image_XuanZhong.SetActive(false);
        }
    }
}
