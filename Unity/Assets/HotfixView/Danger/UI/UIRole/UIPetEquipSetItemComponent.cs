using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    [Timer(TimerType.PetEquipSetItemTimer)]
    public class PetEquipSetItemTimer : ATimer<UIPetEquipSetItemComponent>
    {
        public override void Run(UIPetEquipSetItemComponent self)
        {
            try
            {
                self.ShowEquipItemTips();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }


    public class UIPetEquipSetItemComponent: Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Img_EquipBack;
        public GameObject Img_EquipIcon;
        public GameObject Img_EquipQuality;
        public GameObject Btn_Equip;
        public GameObject Img_EquipBangDing;
        public List<BagInfo> EquipIdList = new List<BagInfo>();
        public GameObject GameObject;
        public BagInfo BagInfo;
        public long PointDownTime;
        public bool ShowEquiTip;

        public Action<int> OnClickAction;

        public ItemOperateEnum itemOperateEnum = ItemOperateEnum.None;
        public List<string> AssetPath = new List<string>();
    }

    public class UIPetEquipSetItemComponentAwakeSystem: AwakeSystem<UIPetEquipSetItemComponent, GameObject>
    {
        public override void Awake(UIPetEquipSetItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            Transform tf = gameObject.transform;
            self.Img_EquipIcon = tf.Find("Img_EquipIcon").gameObject;
            self.Btn_Equip = tf.Find("Btn_Equip").gameObject;
            self.Img_EquipQuality = tf.Find("Img_EquipQuality").gameObject;
            self.Img_EquipBangDing = tf.Find("Img_BangDing").gameObject;
            self.Img_EquipBack = tf.Find("Img_EquipBack").gameObject;
            //self.Btn_Equip.GetComponent<Button>().onClick.AddListener(() => { self.OnClickEquip(); });

            //ButtonHelp.AddEventTriggers(self.Btn_Equip, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            //ButtonHelp.AddEventTriggers(self.Btn_Equip, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            //ButtonHelp.AddEventTriggers(self.Btn_Equip, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(self.Btn_Equip, (PointerEventData pdata) => { self.PointerDown(pdata); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_Equip, (PointerEventData pdata) => { self.PointerUp(pdata); }, EventTriggerType.PointerUp);
        }
    }

    public class UIPetEquipSetItemComponentDestroy: DestroySystem<UIPetEquipSetItemComponent>
    {
        public override void Destroy(UIPetEquipSetItemComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.PointDownTime);
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


    public static class UIPetEquipSetItemComponentSystem
    {
        public static void PointerDown(this UIPetEquipSetItemComponent self, PointerEventData pdata)
        {
            self.ShowEquiTip = true;
            TimerComponent.Instance.Remove(ref self.PointDownTime);
            self.PointDownTime = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + 300, TimerType.PetEquipSetItemTimer, self);
            self.OnClickEquip();
        }


        public static void ShowEquipItemTips(this UIPetEquipSetItemComponent self)
        {
            self.ShowEquiTip = false;

            if (self.BagInfo == null)
                return;
            //弹出Tips
            EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            EventType.ShowItemTips.Instance.bagInfo = self.BagInfo;
            EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
            EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static void PointerUp(this UIPetEquipSetItemComponent self, PointerEventData pdata)
        {
            self.ShowEquiTip = false;
            TimerComponent.Instance.Remove(ref self.PointDownTime);
        }

        public static void OnClickEquip(this UIPetEquipSetItemComponent self)
        {
            if (self.BagInfo == null)
                return;

            if (self.OnClickAction != null)
            {
                // self.OnClickAction.Invoke(self.BagInfo);
                return;
            }

            // EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            // EventType.ShowItemTips.Instance.bagInfo = self.BagInfo;
            // EventType.ShowItemTips.Instance.itemOperateEnum = self.itemOperateEnum;
            // EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            // EventType.ShowItemTips.Instance.EquipList = self.EquipIdList;
            // Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static void InitUI(this UIPetEquipSetItemComponent self, int subType)
        {
            self.BagInfo = null;

            self.Img_EquipIcon.SetActive(false);
            self.Img_EquipQuality.SetActive(false);
            self.Img_EquipBangDing.SetActive(false);

            // if (subType < 100)
            // {
            //     string qianghuaName = ItemViewHelp.EquipWeiZhiToName[subType].Icon;
            //     string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, qianghuaName);
            //     Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            //     if (!self.AssetPath.Contains(path))
            //     {
            //         self.AssetPath.Add(path);
            //     }
            //
            //     self.Img_EquipBack.GetComponent<Image>().sprite = sp;
            // }
        }

        public static void UpdateData(this UIPetEquipSetItemComponent self, BagInfo bagInfo, ItemOperateEnum itemOperateEnum,
        List<BagInfo> equipIdList)
        {
            try
            {
                self.BagInfo = bagInfo;
                self.itemOperateEnum = itemOperateEnum;
                self.EquipIdList = equipIdList;
                ItemConfig itemconfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);

                string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemconfig.Icon);
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }

                self.Img_EquipIcon.SetActive(true);
                self.Img_EquipIcon.GetComponent<Image>().sprite = sp;

                //设置品质
                string ItemQuality = FunctionUI.GetInstance().ItemQualiytoPath(itemconfig.ItemQuality);
                self.Img_EquipQuality.SetActive(true);
                string path2 = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, ItemQuality);
                Sprite sp2 = ResourcesComponent.Instance.LoadAsset<Sprite>(path2);
                if (!self.AssetPath.Contains(path2))
                {
                    self.AssetPath.Add(path2);
                }

                self.Img_EquipQuality.GetComponent<Image>().sprite = sp2;

                //显示绑定
                if (bagInfo.isBinging)
                {
                    self.Img_EquipBangDing.SetActive(true);
                }
                else
                {
                    self.Img_EquipBangDing.SetActive(false);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
        }
    }
}