using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{
    /// <summary>
    /// 熔炼组件
    /// </summary>
    public class UISkillMeltingComponent : Entity, IAwake<GameObject>
    {
        public GameObject Btn_MeltBegin;
        public GameObject BagListNode;
        public GameObject GameObject;

        public UIItemComponent UIGetItem;
        public UIItemComponent[] HuiShouUIList = new UIItemComponent[5];
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();

        public bool IsHoldDown = false;
    }

    [ObjectSystem]
    public class UISkillMeltingComponentAwakeSystem : AwakeSystem<UISkillMeltingComponent, GameObject>
    {
        public override void Awake(UISkillMeltingComponent self, GameObject gameObject)
        {
            self.ItemUIlist.Clear();

            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Btn_MeltBegin = rc.Get<GameObject>("Btn_MeltBegin");
            ButtonHelp.AddListenerEx(self.Btn_MeltBegin, () => {   });

            self.BagListNode = rc.Get<GameObject>("BuildingList");

            self.UIGetItem = self.AddChild<UIItemComponent, GameObject>(rc.Get<GameObject>("UIGetItem"));
            self.UIGetItem.UpdateItem(new BagInfo() { ItemID = ComHelp.MeltingItemId });

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < self.HuiShouUIList.Length; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, rc.Get<GameObject>("IconDi_" + (i + 1)));
                go.transform.localScale = Vector3.one;
                UIItemComponent uiitem = self.AddChild<UIItemComponent, GameObject>(go);
                uiitem.Label_ItemName.SetActive(false);
                uiitem.UpdateItem(null);
                self.HuiShouUIList[i] = uiitem;
            }
        }
    }

    public static class UISkillMeltingComponentSystem
    {
        public static void UpdateBagUI(this UISkillMeltingComponent self, int itemType = -1)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByType(ItemTypeEnum.Equipment);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                UIItemComponent uI_1 = null;
                if (i < self.ItemUIlist.Count)
                {
                    uI_1 = self.ItemUIlist[i];
                    uI_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BagListNode);
                    go.transform.localScale = Vector3.one;

                    uI_1 = self.AddChild<UIItemComponent, GameObject>(go);
                    uI_1.SetEventTrigger(true);
                    uI_1.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerDown(binfo, pdata).Coroutine(); };
                    uI_1.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerUp(binfo, pdata); };

                    self.ItemUIlist.Add(uI_1);
                }
                uI_1.UpdateItem(bagInfos[i], ItemOperateEnum.HuishouBag);
                uI_1.Label_ItemName.SetActive(true);
            }

            for (int i = bagInfos.Count; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask OnPointerDown(this UISkillMeltingComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = true;
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"1_{binfo.BagInfoID}");
            await TimerComponent.Instance.WaitAsync(500);
            if (!self.IsHoldDown)
                return;
            EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            EventType.ShowItemTips.Instance.bagInfo = binfo;
            EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
            EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static void OnPointerUp(this UISkillMeltingComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips);
        }

    }
}
