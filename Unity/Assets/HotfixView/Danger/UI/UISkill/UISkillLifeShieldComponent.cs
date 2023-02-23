using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UISkillLifeShieldComponent : Entity, IAwake
    {
        public GameObject Text_ShieldDesc;
        public GameObject Text_Progess;
        public GameObject Text_ShieldName;
        public GameObject ImageProgess;

        public GameObject[] Shield_List = new GameObject[6];

        public GameObject BuildingList;

        public GameObject[] UICommonItem_List = new GameObject[5];

        public GameObject Btn_ZhuRu;

        public int ShieldType;

        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();

        public bool IsHoldDown;
    }

    [ObjectSystem]
    public class UISkillLifeShieldComponentAwake : AwakeSystem<UISkillLifeShieldComponent>
    {
        public override void Awake(UISkillLifeShieldComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_ShieldDesc = rc.Get<GameObject>("Text_ShieldDesc");
            self.Text_Progess = rc.Get<GameObject>("Text_Progess");
            self.Text_ShieldName = rc.Get<GameObject>("Text_ShieldName");
            self.ImageProgess = rc.Get<GameObject>("ImageProgess");

            for (int i = 0; i < 6; i++)
            {
                self.Shield_List[i] = rc.Get<GameObject>($"Shield_{i+1}");
            }

            self.BuildingList = rc.Get<GameObject>("BuildingList");

            for (int i = 0; i < 5; i++)
            { 
                self.UICommonItem_List[i] = rc.Get<GameObject>($"UICommonItem_{i+1}");
            }

            self.Btn_ZhuRu = rc.Get<GameObject>("Btn_ZhuRu");


            self.UpdateBagUI();
        }
    }

    public static class UISkillLifeShieldComponentSystem
    {

        public static async ETTask OnBtn_ZhuRu(this UISkillLifeShieldComponent self)
        {
            List<long> costs = self.GetConstItems ();
            C2M_LifeShieldCostRequest  request = new C2M_LifeShieldCostRequest() { OperateType = self.ShieldType, OperateBagID = costs };
            M2C_LifeShieldCostResponse response = (M2C_LifeShieldCostResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.ZoneScene().GetComponent<TitleComponent>().ShieldList = response.ShieldList;   
        }

        public static void UpdateBagUI(this UISkillLifeShieldComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<BagInfo> allInfos = new List<BagInfo>();
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Consume));
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Material));
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Equipment));

            for (int i = 0; i < allInfos.Count; i++)
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
                    UICommonHelper.SetParent(go, self.BuildingList);
                    go.transform.localScale = Vector3.one;

                    uI_1 = self.AddChild<UIItemComponent, GameObject>(go);
                    uI_1.SetEventTrigger(true);
                    uI_1.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerDown(binfo, pdata).Coroutine(); };
                    uI_1.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerUp(binfo, pdata); };

                    self.ItemUIlist.Add(uI_1);
                }
                uI_1.UpdateItem(allInfos[i], ItemOperateEnum.HuishouBag);
                uI_1.Label_ItemName.SetActive(true);
            }

            for (int i = allInfos.Count; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask OnPointerDown(this UISkillLifeShieldComponent self, BagInfo binfo, PointerEventData pdata)
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

        public static void OnPointerUp(this UISkillLifeShieldComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }

        public static List<long> GetConstItems(this UISkillLifeShieldComponent self)
        {
            return new List<long>();
        }

    }
}
