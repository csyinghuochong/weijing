using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonJingHeComponent: Entity, IAwake, IDestroy
    {
        public GameObject TakeOffBtn;
        public GameObject Btn_TianFu_2;
        public GameObject Btn_TianFu_1;
        public GameObject JingHeListNode;
        public GameObject UISeasonJingHeItem;
        public GameObject NameText;
        public GameObject DesText;
        public GameObject ItemListNode;
        public GameObject NeedItem;
        public GameObject OpenBtn;
        public GameObject EquipBtn;

        public List<UISeasonJingHeItemComponent> UISeasonJingHeItemComponentList = new List<UISeasonJingHeItemComponent>();
        public List<UIItemComponent> ItemList = new List<UIItemComponent>();
        public List<string> AssetPath = new List<string>();

        public BagInfo BagInfo;
        public int JingHeId;
    }

    public class UISeasonJingHeComponentAwakeSystem: AwakeSystem<UISeasonJingHeComponent>
    {
        public override void Awake(UISeasonJingHeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.JingHeListNode = rc.Get<GameObject>("JingHeListNode");
            self.UISeasonJingHeItem = rc.Get<GameObject>("UISeasonJingHeItem");
            self.NameText = rc.Get<GameObject>("NameText");
            self.DesText = rc.Get<GameObject>("DesText");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.NeedItem = rc.Get<GameObject>("NeedItem");
            self.OpenBtn = rc.Get<GameObject>("OpenBtn");
            self.EquipBtn = rc.Get<GameObject>("EquipBtn");
            self.TakeOffBtn = rc.Get<GameObject>("TakeOffBtn");

            self.UISeasonJingHeItem.SetActive(false);
            self.OpenBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenBtn().Coroutine(); });
            self.EquipBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnEquipBtn().Coroutine(); });
            self.TakeOffBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnTakeOffBtn().Coroutine(); });
            self.TakeOffBtn.SetActive(false);

            self.Btn_TianFu_2 = rc.Get<GameObject>("Btn_TianFu_2");
            self.Btn_TianFu_1 = rc.Get<GameObject>("Btn_TianFu_1");
            ButtonHelp.AddListenerEx(self.Btn_TianFu_2, () => { self.OnBtn_TianFuPlan(1).Coroutine(); });
            ButtonHelp.AddListenerEx(self.Btn_TianFu_1, () => { self.OnBtn_TianFuPlan(0).Coroutine(); });

            self.InitCell();
            self.UpdatePlanButton();
        }
    }

    public class UISeasonJingHeComponentDestroy: DestroySystem<UISeasonJingHeComponent>
    {

        public override void Destroy(UISeasonJingHeComponent self)
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

    public static class UISeasonJingHeComponentSystem
    {

        public static async ETTask OnBtn_TianFuPlan(this UISeasonJingHeComponent self, int plan)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.SeasonJingHePlan == plan)
            {
                return;
            }
            C2M_JingHePlanRequest c2M_JingHePlanRequest = new C2M_JingHePlanRequest() { JingHePlan = plan };
            M2C_JingHePlanResponse m2C_JingHePlan = (M2C_JingHePlanResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_JingHePlanRequest);
            bagComponent.SeasonJingHePlan = plan;

            if (self.IsDisposed)
            {
                return;
            }
            self.UpdatePlanButton();
            self.UpdateInfo(self.JingHeId).Coroutine();
        }

        public static void UpdatePlanButton(this UISeasonJingHeComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            self.Btn_TianFu_1.transform.Find("Image").gameObject.SetActive(bagComponent.SeasonJingHePlan == 0);
            self.Btn_TianFu_2.transform.Find("Image").gameObject.SetActive(bagComponent.SeasonJingHePlan == 1);
        }

        public static void InitCell(this UISeasonJingHeComponent self)
        {
            foreach (SeasonJingHeConfig seasonJingHeConfig in SeasonJingHeConfigCategory.Instance.GetAll().Values)
            {
                UISeasonJingHeItemComponent ui = null;

                GameObject jingHeItem = GameObject.Instantiate(self.UISeasonJingHeItem);
                jingHeItem.SetActive(true);
                UICommonHelper.SetParent(jingHeItem, self.JingHeListNode);
                ui = self.AddChild<UISeasonJingHeItemComponent, GameObject>(jingHeItem);
                self.UISeasonJingHeItemComponentList.Add(ui);

                ui.JingHeId = seasonJingHeConfig.Id;
            }

            self.UpdateInfo(1).Coroutine();
        }

        public static async ETTask UpdateInfo(this UISeasonJingHeComponent self, int jingHeId)
        {
            // 更新孔位信息
            self.JingHeId = jingHeId;

            self.TakeOffBtn.SetActive(self.ZoneScene().GetComponent<BagComponent>().GetJingHeByWeiZhi(jingHeId) != null);

            foreach (UISeasonJingHeItemComponent uiSeasonJingHeItemComponent in self.UISeasonJingHeItemComponentList)
            {
                uiSeasonJingHeItemComponent.OnUpdateData();
                // 高亮
                uiSeasonJingHeItemComponent.OutLineImg.SetActive(false);
                if (uiSeasonJingHeItemComponent.JingHeId == jingHeId)
                {
                    uiSeasonJingHeItemComponent.OutLineImg.SetActive(true);
                }
            }

            SeasonJingHeConfig seasonJingHeConfig = SeasonJingHeConfigCategory.Instance.Get(jingHeId);
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            // 更新右侧面板信息
            if (!userInfoComponent.UserInfo.OpenJingHeIds.Contains(seasonJingHeConfig.Id)) // 未解锁的孔位
            {
                self.NameText.GetComponent<Text>().text = "赛季晶核孔位";
                self.DesText.GetComponent<Text>().text = "可以让玩家在本赛季拥有额外的赛季能力";

                int costItemId = int.Parse(seasonJingHeConfig.Cost.Split(';')[0]);
                int cosrItemNum = int.Parse(seasonJingHeConfig.Cost.Split(';')[1]);
                long havedNum = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(costItemId);
                ReferenceCollector rc = self.NeedItem.GetComponent<ReferenceCollector>();
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(costItemId);

                string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemConfig.Icon);
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }
                rc.Get<GameObject>("IconImg").GetComponent<Image>().sprite = sp;
                
                string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemConfig.ItemQuality);
                string path1 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
                Sprite sp1 = ResourcesComponent.Instance.LoadAsset<Sprite>(path1);
                if (!self.AssetPath.Contains(path1))
                {
                    self.AssetPath.Add(path1);
                }
                rc.Get<GameObject>("Back").GetComponent<Image>().sprite = sp1;
                
                
                rc.Get<GameObject>("ItemNameText").GetComponent<Text>().text = itemConfig.ItemName;
                rc.Get<GameObject>("ItemNameText").GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColorDi(itemConfig.ItemQuality);
                rc.Get<GameObject>("ItemNumText").GetComponent<Text>().text = $"{havedNum}/{cosrItemNum}";
                rc.Get<GameObject>("ItemNumText").GetComponent<Text>().color =
                        havedNum >= cosrItemNum? new Color(0, 1, 0) : new Color(245f / 255f, 43f / 255f, 96f / 255f);

                self.ItemListNode.SetActive(false);
                self.NeedItem.SetActive(true);

                self.OpenBtn.SetActive(true);
                self.EquipBtn.SetActive(false);
            }
            else // 解锁的孔位
            {
                self.NameText.GetComponent<Text>().text = "赏金能力";
                self.DesText.GetComponent<Text>().text = ItemViewHelp.GetAttributeDesc(seasonJingHeConfig.AddProperty);

                BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
                int number = 0;
                var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
                var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

                if (self.ItemList.Count < 12)
                {
                    // 先生成12个格子
                    for (int i = 0; i < 12; i++)
                    {
                        UIItemComponent uI = null;
                        GameObject go = GameObject.Instantiate(bundleGameObject);
                        UICommonHelper.SetParent(go, self.ItemListNode);
                        go.SetActive(true);
                        uI = self.AddChild<UIItemComponent, GameObject>(go);
                        uI.SetClickHandler((bagInfo) => { self.OnSelect(bagInfo); });
                        self.ItemList.Add(uI);
                        uI.UpdateItem(null, ItemOperateEnum.None);
                    }
                }

                List<BagInfo> bagInfos = bagComponent.GetItemsByLoc(ItemLocType.ItemLocBag);
                for (int i = 0; i < bagInfos.Count; i++)
                {
                    ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                    if (bagInfos[i].IfJianDing == false && itemConfig.ItemType == ItemTypeEnum.Equipment && itemConfig.EquipType == 201 )
                    {
                        UIItemComponent uI = null;
                        if (number < self.ItemList.Count)
                        {
                            uI = self.ItemList[number];
                            uI.GameObject.SetActive(true);
                        }
                        else
                        {
                            GameObject go = GameObject.Instantiate(bundleGameObject);
                            UICommonHelper.SetParent(go, self.ItemListNode);
                            uI = self.AddChild<UIItemComponent, GameObject>(go);
                            uI.SetClickHandler((bagInfo) => { self.OnSelect(bagInfo); });
                            self.ItemList.Add(uI);
                        }

                        number++;
                        uI.UpdateItem(bagInfos[i], ItemOperateEnum.None);
                    }
                }

                for (int i = number; i < self.ItemList.Count; i++)
                {
                    self.ItemList[i].UpdateItem(null, ItemOperateEnum.None);
                    // self.ItemList[i].GameObject.SetActive(false);
                }

                self.ItemListNode.SetActive(true);
                self.NeedItem.SetActive(false);

                self.OpenBtn.SetActive(false);
                self.EquipBtn.SetActive(true);
            }
        }

        public static void OnSelect(this UISeasonJingHeComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);

            for (int i = 0; i < self.ItemList.Count; i++)
            {
                self.ItemList[i].SetSelected(bagInfo);
            }
        }

        public static async ETTask OnOpenBtn(this UISeasonJingHeComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.OpenJingHeIds.Contains(self.JingHeId))
            {
                FloatTipManager.Instance.ShowFloatTip("孔位已开启！");
                return;
            }

            if (!SeasonJingHeConfigCategory.Instance.Contain(self.JingHeId))
            {
                FloatTipManager.Instance.ShowFloatTip("无效孔位！");
                return;
            }

            SeasonJingHeConfig seasonJingHeConfig = SeasonJingHeConfigCategory.Instance.Get(self.JingHeId);
            int costItemId = int.Parse(seasonJingHeConfig.Cost.Split(';')[0]);
            int cosrItemNum = int.Parse(seasonJingHeConfig.Cost.Split(';')[1]);
            long havedNum = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(costItemId);
            if (havedNum < cosrItemNum)
            {
                FloatTipManager.Instance.ShowFloatTip("道具数量不足！");
                return;
            }

            C2M_SeasonOpenJingHeRequest request = new C2M_SeasonOpenJingHeRequest() { JingHeId = self.JingHeId };
            M2C_SeasonOpenJingHeResponse response =
                    (M2C_SeasonOpenJingHeResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error == ErrorCode.ERR_Success)
            {
                userInfoComponent.UserInfo.OpenJingHeIds.Add(self.JingHeId);
                self.UpdateInfo(self.JingHeId).Coroutine();
            }
        }

        /// <summary>
        /// 卸下晶核
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static async ETTask OnTakeOffBtn(this UISeasonJingHeComponent self)
        {
            if (self.JingHeId == 0)
            {
                return;
            }
            BagInfo bagInfo = self.ZoneScene().GetComponent<BagComponent>().GetJingHeByWeiZhi(self.JingHeId);
            if (bagInfo == null)
            {
                return;
            }

            C2M_JingHeWearRequest request = new C2M_JingHeWearRequest() { OperateBagID = bagInfo.BagInfoID, OperateType = 2, OperatePar= self.JingHeId.ToString() };
            M2C_JingHeWearResponse response = (M2C_JingHeWearResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (self.InstanceId == 0)
            {
                return;
            }

            self.UpdateInfo(self.JingHeId).Coroutine();
        }

        public static async ETTask OnEquipBtn(this UISeasonJingHeComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (self.BagInfo == null || self.JingHeId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("未选择道具！");
                return;
            }

            //装备晶体（类似于生肖），  客户端根据孔位显示对应的装备 ItemConfig.ItemType == 3 EquipType = 201  ItemSubType2001 +
            int page = 0;

            await bagComponent.SendWearJingHe(self.BagInfo, 1, self.JingHeId.ToString());
            self.BagInfo = null;
            self.UpdateInfo(self.JingHeId).Coroutine();
        }
    }
}