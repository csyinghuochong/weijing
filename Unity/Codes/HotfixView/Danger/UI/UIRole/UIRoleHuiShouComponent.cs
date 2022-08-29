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
        public const int HuiShouMaxNumber = 8;

        public UI[] HuiShouUIList = new UI[HuiShouMaxNumber];
        public BagInfo[] HuiShouInfos = new BagInfo[HuiShouMaxNumber];

        public List<UI> ItemUIlist = new List<UI>();
        public List<UI> GetUIList = new List<UI>();

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
            self.Button_HuiShou.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_HuiShou(); });

            self.Img_YiJianZiSe = rc.Get<GameObject>("Img_YiJianZiSe");
            self.BagListNode = rc.Get<GameObject>("BagListNode");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.Img_YiJianZiSe.SetActive(false);

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.InitHuiShouList().Coroutine();
            self.UpdateBagUI().Coroutine();

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
        }
    }


    public static class UIHuiShouComponentSystem
    {

        public static async ETTask InitHuiShouList(this UIRoleHuiShouComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            for (int i = 0; i < UIRoleHuiShouComponent.HuiShouMaxNumber; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, rc.Get<GameObject>("IconDi_" + (i+1)));
                go.transform.localScale = Vector3.one;
                UI uiitem = self.AddChild<UI, string, GameObject>("UIItem_" + i, go);
                UIItemComponent  uIItemComponent = uiitem.AddComponent<UIItemComponent>();
                uIItemComponent.Label_ItemName.SetActive(false);
                uIItemComponent.UpdateItem(null);
                self.HuiShouUIList[i] = uiitem;
            }
        }

        public static void OnHuiShouSelect(this UIRoleHuiShouComponent self, string dataparams)
        {
            self.OnUpdateSelect(dataparams);
            self.OnUpdateHuiShou();
            self.OnUpdateGetList().Coroutine();
            self.UpdateSelected();
        }

        public static void OnUpdateUI(this UIRoleHuiShouComponent self) 
        {
            self.HuiShouInfos = new BagInfo[UIRoleHuiShouComponent.HuiShouMaxNumber];
            self.UpdateBagUI().Coroutine();
            self.OnUpdateHuiShou();
            self.OnUpdateGetList().Coroutine();
            self.UpdateSelected();
        }

        public static void OnEquipHuiShow(this UIRoleHuiShouComponent self)
        {
            self.OnUpdateUI();
        }

        public static void OnUpdateSelect(this UIRoleHuiShouComponent self, string dataparams)
        {
            BagInfo bagInfo = self.BagComponent.HuiShouSelect;
            if (dataparams == "1")
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

        public static void OnUpdateHuiShou(this UIRoleHuiShouComponent self)
        {
            for (int i = 0; i < self.HuiShouInfos.Length; i++)
            {
                self.HuiShouUIList[i].GetComponent<UIItemComponent>().UpdateItem(self.HuiShouInfos[i], ItemOperateEnum.HuishouShow);
            }
        }

        public static async ETTask OnUpdateGetList(this UIRoleHuiShouComponent self)
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

                        if (huishouGet.ContainsKey(itemId))
                        {
                            huishouGet[itemId].ItemNum += int.Parse(itemInfo[1]);
                        }
                        else
                        {
                            huishouGet.Add(itemId, new BagInfo() { ItemID = itemId, ItemNum = int.Parse(itemInfo[1]) });
                        }
                    }
                }
            }

            List<BagInfo> bagInfos = huishouGet.Values.ToList();
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            await ETTask.CompletedTask;
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < bagInfos.Count; i++)
            {
                UI uI_1 = null;
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

                    uI_1 = self.AddChild<UI, string, GameObject>( "UIItem_" + i, go);
                    UIItemComponent uIItemComponent = uI_1.AddComponent<UIItemComponent>();
                    uIItemComponent.Label_ItemNum.SetActive(true);
                    self.GetUIList.Add(uI_1);
                }
                uI_1.GetComponent<UIItemComponent>().UpdateItem(bagInfos[i]);
            }
            for (int i = bagInfos.Count; i < self.GetUIList.Count; i++)
            {
                self.GetUIList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask UpdateBagUI(this UIRoleHuiShouComponent self, int itemType = -1)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            await ETTask.CompletedTask;
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByType(ItemTypeEnum.Equipment);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                UI uI_1 = null;
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

                    uI_1 = self.AddChild<UI, string, GameObject>("UIItem_" + i, go);
                    UIItemComponent uIItemComponent =  uI_1.AddComponent<UIItemComponent>();

                    uIItemComponent.SetEventTrigger(true);
                    uIItemComponent.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerDown(binfo, pdata).Coroutine(); };
                    uIItemComponent.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerUp(binfo, pdata); };

                    self.ItemUIlist.Add(uI_1);
                }
                uI_1.GetComponent<UIItemComponent>().UpdateItem(bagInfos[i], ItemOperateEnum.HuishouBag);
                uI_1.GetComponent<UIItemComponent>().Label_ItemName.SetActive(true);
            }

            for (int i = bagInfos.Count; i< self.ItemUIlist.Count; i++ )
            {
                self.ItemUIlist[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask OnPointerDown(this UIRoleHuiShouComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = true;
            self.BagComponent.HuiShouSelect = binfo;
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, "1");
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
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips).Coroutine();
        }

        public static void UpdateSelected(this UIRoleHuiShouComponent self)
        {
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                UIItemComponent uIItemComponent = self.ItemUIlist[i].GetComponent<UIItemComponent>();
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
            self.HuiShouInfos = new BagInfo[UIRoleHuiShouComponent.HuiShouMaxNumber];

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

                if (number >= 5)
                {
                    break;
                }
            }

            self.OnUpdateHuiShou();
            self.OnUpdateGetList().Coroutine();
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
