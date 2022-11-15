using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{
    /// <summary>
    /// 熔炼组件
    /// </summary>
    public class UISkillMeltingComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Btn_MeltBegin;
        public GameObject BagListNode;
        public GameObject GameObject;

        public UIItemComponent UIGetItem;
        public BagInfo[] HuiShouInfos = new BagInfo[5];
        public UIItemComponent[] HuiShouUIList = new UIItemComponent[5];
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();
        public BagComponent BagComponent;

        public bool IsHoldDown = false;
    }

    [ObjectSystem]
    public class UISkillMeltingComponentDestroySystem : DestroySystem<UISkillMeltingComponent>
    {
        public override void Destroy(UISkillMeltingComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.HuiShouSelect, self);
        }
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
            ButtonHelp.AddListenerEx(self.Btn_MeltBegin, () => { self.OnBtn_MeltBegin().Coroutine();  });

            self.BagListNode = rc.Get<GameObject>("BagListNode");

            self.UIGetItem = self.AddChild<UIItemComponent, GameObject>(rc.Get<GameObject>("UIGetItem"));

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int makeType = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.MakeType);

            self.UIGetItem.UpdateItem(new BagInfo() { ItemID = ComHelp.ReturnMeltingItem(makeType) });
            self.UIGetItem.Label_ItemNum.SetActive(false);

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

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
            DataUpdateComponent.Instance.AddListener(DataType.HuiShouSelect, self);
        }
    }

    public static class UISkillMeltingComponentSystem
    {
        public static void OnUpdateUI(this UISkillMeltingComponent self)
        {
            self.HuiShouInfos = new BagInfo[self.HuiShouInfos.Length];
            self.UpdateBagUI();
            self.UpdateHuiShouUI();
            self.UpdateSelected();
        }

        public static void OnHuiShouSelect(this UISkillMeltingComponent self, string dataparams)
        {
            self.UpdateHuiShouInfo(dataparams);
            self.UpdateHuiShouUI();
            self.UpdateSelected();
        }

        public static void UpdateHuiShouInfo(this UISkillMeltingComponent self, string dataparams)
        {
            string[] huishouInfo = dataparams.Split('_');
            BagInfo bagInfo = self.BagComponent.GetBagInfo(long.Parse(huishouInfo[1]));
            if (huishouInfo[0] == "1")
            {
                for (int i = 0; i < self.HuiShouInfos.Length; i++)
                {
                    if (self.HuiShouInfos[i] == bagInfo)
                    {
                        return;
                    }
                }
                for (int i = 0; i < self.HuiShouInfos.Length; i++)
                {
                    if (self.HuiShouInfos[i] == null)
                    {
                        self.HuiShouInfos[i] = bagInfo;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < self.HuiShouInfos.Length; i++)
                {
                    if (self.HuiShouInfos[i] == bagInfo)
                    {
                        self.HuiShouInfos[i] = null;
                        break;
                    }
                }
            }
        }

        public static async ETTask OnBtn_MeltBegin(this UISkillMeltingComponent self)
        {
            List<long> huishouList = new List<long>();
            for (int i = 0; i < self.HuiShouInfos.Length; i++)
            {
                if (self.HuiShouInfos[i] != null)
                {
                    huishouList.Add(self.HuiShouInfos[i].BagInfoID);
                }
            }
            if (huishouList.Count == 0)
            {
                return;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int makeId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.MakeType);
            C2M_ItemMeltingRequest request = new C2M_ItemMeltingRequest() { OperateBagID = huishouList, MakeType = makeId };
            M2C_ItemMeltingResponse response = (M2C_ItemMeltingResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);

            self.OnUpdateUI();
        }

        public static void UpdateSelected(this UISkillMeltingComponent self)
        {
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                UIItemComponent uIItemComponent = self.ItemUIlist[i];
                BagInfo bagInfo = uIItemComponent.Baginfo;
                if (bagInfo == null)
                {
                    continue;
                }
                bool have = false;
                for (int h = 0; h < self.HuiShouInfos.Length; h++)
                {
                    if (self.HuiShouInfos[h] != null && self.HuiShouInfos[h].BagInfoID == bagInfo.BagInfoID)
                    {
                        have = true;
                    }
                }
                uIItemComponent.Image_XuanZhong.SetActive(have);
            }
        }

        public static void UpdateHuiShouUI(this UISkillMeltingComponent self)
        {
            for (int i = 0; i < self.HuiShouInfos.Length; i++)
            {
                self.HuiShouUIList[i].UpdateItem(self.HuiShouInfos[i], ItemOperateEnum.HuishouShow);
            }
        }

        public static void UpdateBagUI(this UISkillMeltingComponent self, int itemType = -1)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            int number = 0;
            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByType(ItemTypeEnum.Equipment);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemQuality < 4)
                {
                    continue;
                }

                UIItemComponent uI_1 = null;
                if (number < self.ItemUIlist.Count)
                {
                    uI_1 = self.ItemUIlist[number];
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
                number++;
            }

            for (int i = number; i < self.ItemUIlist.Count; i++)
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
