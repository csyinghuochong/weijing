using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.EventSystems;

namespace ET
{
    public class UIRoleHuiShouComponent : Entity, IAwake, IDestroy
    {

        public GameObject Btn_Close;
        public GameObject Button_QulitySet;
        public GameObject Button_YiJianInput;
        public GameObject Button_HuiShou;
        public GameObject Img_YiJianZiSe;

        public GameObject BagListNode;
        public GameObject RewardListNode;

        public BagInfo[] HuiShouInfos = new BagInfo[8];
        public UIItemComponent[] HuiShouUIList = new UIItemComponent[8];
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();
        public List<UIItemComponent> GetUIList = new List<UIItemComponent>();

        public BagComponent BagComponent;

        public bool IsHoldDown = false;
    }

    [ObjectSystem]
    public class UIHuiShouComponentDestroySystem : DestroySystem<UIRoleHuiShouComponent>
    {
        public override void Destroy(UIRoleHuiShouComponent self)
        {
            for (int i = 0; i < self.HuiShouUIList.Length; i++)
            {
                self.HuiShouUIList[i] = null;
            }
        }
    }

    [ObjectSystem]
    public class UIHuiShouComponentAwakeSystem : AwakeSystem<UIRoleHuiShouComponent>
    {
        public override void Awake(UIRoleHuiShouComponent self)
        {
            self.ItemUIlist.Clear();
            self.GetUIList.Clear();
            self.IsHoldDown = false;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Button_QulitySet = rc.Get<GameObject>("Button_QulitySet");
            self.Button_QulitySet.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_QulitySet(); });
            self.Button_YiJianInput = rc.Get<GameObject>("Button_YiJianInput");
            self.Button_YiJianInput.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_YiJianInput(); });
            self.Button_HuiShou = rc.Get<GameObject>("Button_HuiShou");
            ButtonHelp.AddListenerEx(self.Button_HuiShou, self.OnButton_HuiShou);     

            self.Img_YiJianZiSe = rc.Get<GameObject>("Img_YiJianZiSe");
            self.BagListNode = rc.Get<GameObject>("BagListNode");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.Img_YiJianZiSe.SetActive(false);

            self.InitHuiShouList();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
        }
    }

    public static class UIHuiShouComponentSystem
    {

        public static void  InitHuiShouList(this UIRoleHuiShouComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            for (int i = 0; i < self.HuiShouUIList.Length; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, rc.Get<GameObject>("IconDi_" + (i+1)));
                go.transform.localScale = Vector3.one;
                UIItemComponent uiitem = self.AddChild<UIItemComponent, GameObject>( go);
                uiitem.Label_ItemName.SetActive(false);
                uiitem.UpdateItem(null, ItemOperateEnum.None);
                self.HuiShouUIList[i] = uiitem;
            }
        }

        public static void OnHuiShouSelect(this UIRoleHuiShouComponent self, string dataparams)
        {
            self.UpdateHuiShouInfo(dataparams);
            self.UpdateHuiShouUI();
            self.OnUpdateGetList();
            self.UpdateSelected();
        }

        public static void OnUpdateUI(this UIRoleHuiShouComponent self) 
        {
            self.HuiShouInfos = new BagInfo[self.HuiShouInfos.Length];
            self.UpdateBagUI();
            self.UpdateHuiShouUI();
            self.OnUpdateGetList();
            self.UpdateSelected();
        }

        public static void OnEquipHuiShow(this UIRoleHuiShouComponent self)
        {
            self.OnUpdateUI();
        }

        public static void UpdateHuiShouInfo(this UIRoleHuiShouComponent self, string dataparams)
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

        public static void UpdateHuiShouUI(this UIRoleHuiShouComponent self)
        {
            for (int i = 0; i < self.HuiShouInfos.Length; i++)
            {
                self.HuiShouUIList[i].UpdateItem(self.HuiShouInfos[i], ItemOperateEnum.HuishouShow);
            }
        }

        public static void  OnUpdateGetList(this UIRoleHuiShouComponent self)
        {
            Dictionary<int, BagInfo> huishouGet = new Dictionary<int, BagInfo>();
            for (int i = 0; i < self.HuiShouInfos.Length; i++)
            {
                string huishouItem = "";
                if (self.HuiShouInfos[i] != null)
                {
                    huishouItem = ItemConfigCategory.Instance.Get(self.HuiShouInfos[i].ItemID).HuiShouGetItem;
                }
                if (huishouItem.Length > 0)
                {
                    string[] itemList = huishouItem.Split(';');
                    for (int k = 0; k < itemList.Length; k++)
                    {
                        string[] itemInfo = itemList[k].Split(',');
                        int itemId = int.Parse(itemInfo[0]);
                        int itemNum = int.Parse(itemInfo[1]) * self.HuiShouInfos[i].ItemNum;

                        if (huishouGet.ContainsKey(itemId))
                        {
                            huishouGet[itemId].ItemNum += itemNum;
                        }
                        else
                        {
                            huishouGet.Add(itemId, new BagInfo() { ItemID = itemId, ItemNum = itemNum });
                        }
                    }
                }
            }

            List<BagInfo> bagInfos = huishouGet.Values.ToList();
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < bagInfos.Count; i++)
            {
                UIItemComponent uI_1 = null;
                if (i < self.GetUIList.Count)
                {
                    uI_1 = self.GetUIList[i];
                    uI_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.RewardListNode);
                    go.transform.localScale = Vector3.one;

                    uI_1 = self.AddChild<UIItemComponent, GameObject>( go);
                    uI_1.Label_ItemNum.SetActive(true);
                    self.GetUIList.Add(uI_1);
                }
                uI_1.UpdateItem(bagInfos[i], ItemOperateEnum.None);
            }
            for (int i = bagInfos.Count; i < self.GetUIList.Count; i++)
            {
                self.GetUIList[i].GameObject.SetActive(false);
            }
        }

        public static  void UpdateBagUI(this UIRoleHuiShouComponent self, int itemType = -1)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<BagInfo> allInfos = new List<BagInfo>();
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Equipment));
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Gemstone));
            allInfos.AddRange(bagComponent.GetItemsByLoc(ItemLocType.ItemPetHeXinBag));

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
                    UICommonHelper.SetParent(go, self.BagListNode);
                    go.transform.localScale = Vector3.one;

                    uI_1 = self.AddChild<UIItemComponent, GameObject>( go);
                    uI_1.SetEventTrigger(true);
                    uI_1.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerDown(binfo, pdata).Coroutine(); };
                    uI_1.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerUp(binfo, pdata); };

                    self.ItemUIlist.Add(uI_1);
                }
                uI_1.UpdateItem(allInfos[i], ItemOperateEnum.HuishouBag);
                uI_1.Label_ItemName.SetActive(true);
            }

            for (int i = allInfos.Count; i< self.ItemUIlist.Count; i++ )
            {
                self.ItemUIlist[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask OnPointerDown(this UIRoleHuiShouComponent self, BagInfo binfo, PointerEventData pdata)
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

        public static void OnPointerUp(this UIRoleHuiShouComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips);
        }

        public static void UpdateSelected(this UIRoleHuiShouComponent self)
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
                    if (self.HuiShouInfos[h]!=null && self.HuiShouInfos[h].BagInfoID== bagInfo.BagInfoID)
                    {
                        have = true;
                    }
                }
                uIItemComponent.Image_XuanZhong.SetActive(have);
            }
        }

        public static void OnButton_QulitySet(this UIRoleHuiShouComponent self)
        {
            self.Img_YiJianZiSe.SetActive(!self.Img_YiJianZiSe.activeSelf);
        }

        public static void OnButton_YiJianInput(this UIRoleHuiShouComponent self)
        {
            bool qulity_set = self.Img_YiJianZiSe.activeSelf;

            //最多选取五个
            self.HuiShouInfos = new BagInfo[self.HuiShouInfos.Length];

            int number = 0;
            List<BagInfo> bagInfos = self.BagComponent.GetItemsByType(ItemTypeEnum.Equipment);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if ( (qulity_set && itemConfig.ItemQuality >= (int)ItemQualityEnem.Quality4) 
                    || (!qulity_set && itemConfig.ItemQuality < (int)ItemQualityEnem.Quality4))
                {
                    self.HuiShouInfos[number] = bagInfos[i];
                    number++;
                }

                if (number >= 8)
                {
                    break;
                }
            }

            self.UpdateHuiShouUI();
            self.OnUpdateGetList();
            self.UpdateSelected();
        }

        public static void OnButton_HuiShou(this UIRoleHuiShouComponent self)
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
            self.BagComponent.SendHuiShou(huishouList).Coroutine() ;
        }
    }

}
