using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIPetHeXinBagComponent : Entity, IAwake, IDestroy
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

        public List<string> AssetPath = new List<string>();
    }


    public class UIPetHeXinBagComponentAwake : AwakeSystem<UIPetHeXinBagComponent>
    {
        public override void Awake(UIPetHeXinBagComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ImagePetHexinItemIcon = rc.Get<GameObject>("ImagePetHexinItemIcon");
            //self.Button_OneKey = rc.Get<GameObject>("Button_OneKey");
            //ButtonHelp.AddListenerEx(self.Button_OneKey, () => { self.Button_OneKey().Coroutine(); });

            self.ImagePetHexinItemIcon.SetActive(false);
            self.PetListNode = rc.Get<GameObject>("PetListNode");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPetHeXinBag); });
            self.IsHoldDown = false;
            self.uIItems.Clear();

            self.OnUpdateUI().Coroutine();
        }
    }
    public class UIPetHeXinBagComponentDestroy : DestroySystem<UIPetHeXinBagComponent>
    {
        public override void Destroy(UIPetHeXinBagComponent self)
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
    public static class UIPetHeXinBagComponentSystem
    {
        
        public static async ETTask OnUpdateUI(this UIPetHeXinBagComponent self)
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

        public static async ETTask PointerDown(this UIPetHeXinBagComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = true;
            self.BagInfo = binfo;
            self.cancellationToken?.Cancel();
            self.cancellationToken = new ETCancellationToken();
            long instanceId = self.InstanceId;
            bool ret = await TimerComponent.Instance.WaitAsync(200, self.cancellationToken);
            if (instanceId != self.InstanceId)
            {
                return;
            }
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

    }
}
