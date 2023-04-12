using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UISkillLifeShieldComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_ShieldDesc;
        public GameObject Text_Progess;
        public GameObject Text_ShieldName;
        public GameObject ImageProgess;
        public GameObject BuildingList;

        public GameObject Btn_ZhuRu;

        public List<UISkillLifeShieldItemComponent> ShieldUIList = new List<UISkillLifeShieldItemComponent>();
        public List<UIItemComponent> HuiShoulist = new List<UIItemComponent>();
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();

        public BagComponent BagComponent;

        public int ShieldType;

        public bool IsHoldDown;
    }


    public class UISkillLifeShieldComponentAwake : AwakeSystem<UISkillLifeShieldComponent>
    {
        public override void Awake(UISkillLifeShieldComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_ShieldDesc = rc.Get<GameObject>("Text_ShieldDesc");
            self.Text_Progess = rc.Get<GameObject>("Text_Progess");
            self.Text_ShieldName = rc.Get<GameObject>("Text_ShieldName");
            self.ImageProgess = rc.Get<GameObject>("ImageProgess");
            self.BuildingList = rc.Get<GameObject>("BuildingList");

            for (int i = 0; i < 6; i++)
            {
                UISkillLifeShieldItemComponent uISkillLifeShieldItem = self.AddChild<UISkillLifeShieldItemComponent, GameObject>(rc.Get<GameObject>($"Shield_{i + 1}"));
                uISkillLifeShieldItem.OnInitUI(i + 1);
                uISkillLifeShieldItem.SetClickHandler(self.OnClickShieldHandler);
                self.ShieldUIList.Add(uISkillLifeShieldItem);
            }
            self.ShieldUIList[0].OnButtonClick();

            for (int i = 0; i < 5; i++)
            {
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(rc.Get<GameObject>($"UICommonItem_{i + 1}"));
                uIItemComponent.UpdateItem(null, ItemOperateEnum.None);
                self.HuiShoulist.Add(uIItemComponent);
            }

            self.Btn_ZhuRu = rc.Get<GameObject>("Btn_ZhuRu");
            ButtonHelp.AddListenerEx(self.Btn_ZhuRu, () => { self.OnBtn_ZhuRu().Coroutine(); });
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
            DataUpdateComponent.Instance.AddListener(DataType.HuiShouSelect, self);
        }
    }


    public class UISkillLifeShieldComponentDestroy : DestroySystem<UISkillLifeShieldComponent>
    {
        public override void Destroy(UISkillLifeShieldComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.HuiShouSelect, self);
        }
    }


    public static class UISkillLifeShieldComponentSystem
    {

        public static void OnUpdateUI(this UISkillLifeShieldComponent self)
        {
            self.UpdateBagUI();
            self.OnUpdateShieldUI();

            for (int i = 0; i < self.HuiShoulist.Count; i++)
            {
                self.HuiShoulist[i].UpdateItem(null, ItemOperateEnum.None);
                self.HuiShoulist[i].HideItemName();
            }
        }

        public static void OnUpdateShieldUI(this UISkillLifeShieldComponent self)
        {
            for (int i = 0; i < self.ShieldUIList.Count; i++)
            {
                self.ShieldUIList[i].OnUpdateUI();
            }
        }

        public static void OnHuiShouSelect(this UISkillLifeShieldComponent self, string dataparams)
        {
            self.UpdateHuiShouInfo(dataparams);
            self.UpdateBagSelected();
        }

        public static void UpdateHuiShouInfo(this UISkillLifeShieldComponent self, string dataparams)
        {
            string[] huishouInfo = dataparams.Split('_');
            BagInfo bagInfo = self.BagComponent.GetBagInfo(long.Parse(huishouInfo[1]));
            if (bagInfo == null)
            {
                return;
            }

            //1新增  2移除 
            if (huishouInfo[0] == "1")
            {
                for (int i = 0; i < self.HuiShoulist.Count; i++)
                {
                    if (self.HuiShoulist[i].Baginfo == null)
                    {
                        continue;
                    }
                    if (self.HuiShoulist[i].Baginfo.BagInfoID == bagInfo.BagInfoID)
                    {
                        return;
                    }
                }
                for (int i = 0; i < self.HuiShoulist.Count; i++)
                {
                    if (self.HuiShoulist[i].Baginfo == null)
                    {
                        self.HuiShoulist[i].UpdateItem(bagInfo, ItemOperateEnum.HuishouShow);
                        self.HuiShoulist[i].Label_ItemName.SetActive(true);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < self.HuiShoulist.Count; i++)
                {
                    if (self.HuiShoulist[i].Baginfo == null)
                    {
                        continue;
                    }
                    if (self.HuiShoulist[i].Baginfo.BagInfoID == bagInfo.BagInfoID)
                    {
                        self.HuiShoulist[i].UpdateItem(null, ItemOperateEnum.None);
                        self.HuiShoulist[i].Label_ItemName.SetActive(false);
                    }
                }
            }
        }

        public static void UpdateBagSelected(this UISkillLifeShieldComponent self)
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
                for (int h = 0; h < self.HuiShoulist.Count; h++)
                {
                    if (self.HuiShoulist[h].Baginfo != null && self.HuiShoulist[h].Baginfo == bagInfo)
                    {
                        have = true;
                    }
                }
                uIItemComponent.Image_XuanZhong.SetActive(have);
            }
        }

        public static void OnClickShieldHandler(this UISkillLifeShieldComponent self, int shieldType)
        {
            self.ShieldType = shieldType;
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            int curLv = skillSetComponent.GetLifeShieldLevel(shieldType);
            int maxLv = LifeShieldConfigCategory.Instance.LifeShieldList[shieldType].Count;
            int nextlifeId = skillSetComponent.GetLifeShieldShowId(shieldType);
           
            LifeShieldConfig lifeShieldConfig = LifeShieldConfigCategory.Instance.Get(nextlifeId);
            self.Text_ShieldName.GetComponent<Text>().text = $"{lifeShieldConfig.ShieldName}";
            self.Text_ShieldDesc.GetComponent<Text>().text = lifeShieldConfig.Des;

            LifeShieldInfo lifeShieldInfo = skillSetComponent.GetLifeShieldByType(shieldType);
            int curExp = lifeShieldInfo != null ? lifeShieldInfo.Exp : 0;

            if (curLv == maxLv)
            { 
                self.Text_Progess.GetComponent<Text>().text = $"已满级";
            }
            else
            {
                self.Text_Progess.GetComponent<Text>().text = $"{curExp}/{lifeShieldConfig.ShieldExp}";
                self.ImageProgess.GetComponent<Image>().fillAmount = (float)(curExp) / (float)(lifeShieldConfig.ShieldExp);
            }
             
            for (int i = 0; i < self.ShieldUIList.Count; i++)
            {
                self.ShieldUIList[i].SetSelected(shieldType);
            }
        }

        public static async ETTask OnBtn_ZhuRu(this UISkillLifeShieldComponent self)
        {
            List<long> costs = self.GetConstItems ();
            if (costs.Count == 0 || self.ShieldType == 0)
            {
                return;
            }

            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            if (self.ShieldType == 6)
            {
                int hplv = skillSetComponent.GetLifeShieldLevel(self.ShieldType);
                int otlv = skillSetComponent.GetOtherMinLevel();
                if (otlv <= hplv)
                {
                    FloatTipManager.Instance.ShowFloatTip("请先升级其他护盾！");
                    return;
                }
            }

            C2M_LifeShieldCostRequest  request = new C2M_LifeShieldCostRequest() { OperateType = self.ShieldType, OperateBagID = costs };
            M2C_LifeShieldCostResponse response = (M2C_LifeShieldCostResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.AddExp > 0)
            {
                FloatTipManager.Instance.ShowFloatTip("注入成功!本次增加" + response.AddExp + "点魂值");
            }
            self.ZoneScene().GetComponent<SkillSetComponent>().LifeShieldList = response.ShieldList;
            self.OnClickShieldHandler(self.ShieldType);
            self.OnUpdateUI();
        }

        public static void UpdateBagUI(this UISkillLifeShieldComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<BagInfo> allInfos = new List<BagInfo>();
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            //allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Consume));
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Material));
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Equipment));

            int number = 0;
            for (int i = 0; i < allInfos.Count; i++)
            {
                if (!ConfigHelper.ItemAddShieldExp.ContainsKey(allInfos[i].ItemID))
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
                    UICommonHelper.SetParent(go, self.BuildingList);
                    go.transform.localScale = Vector3.one;

                    uI_1 = self.AddChild<UIItemComponent, GameObject>(go);
                    uI_1.SetEventTrigger(true);
                    uI_1.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerDown(binfo, pdata).Coroutine(); };
                    uI_1.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerUp(binfo, pdata); };

                    self.ItemUIlist.Add(uI_1);
                }
                uI_1.UpdateItem(allInfos[i], ItemOperateEnum.HuishouBag);
                uI_1.HideItemName();
                number++;
            }

            for (int i = number; i < self.ItemUIlist.Count; i++)
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
            List<long> constids = new List<long>();
            for (int h = 0; h < self.HuiShoulist.Count; h++)
            {
                if (self.HuiShoulist[h].Baginfo != null)
                {
                    constids.Add(self.HuiShoulist[h].Baginfo.BagInfoID);
                }
            }
            return constids;
        }

    }
}
