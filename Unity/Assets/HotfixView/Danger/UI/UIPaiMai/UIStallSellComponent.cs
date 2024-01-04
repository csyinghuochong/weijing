using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIStallSellComponent: Entity, IAwake
    {
        public GameObject Btn_ChangeName;
        public GameObject Lab_Name;
        public GameObject SellTypeButton;
        public GameObject Btn_Stall;
        public GameObject Lab_ShengYuTime;
        public GameObject Text_SellTime;
        public GameObject Btn_XiaJia;
        public GameObject Btn_ShangJia;
        public GameObject ItemListNode;
        public GameObject PaiMaiListNode;
        public GameObject UIPaiMaiSellItem;

        public List<UIItemComponent> BagItemUILIist = new List<UIItemComponent>();
        public List<UIPaiMaiSellItemComponent> SellItemUILIist = new List<UIPaiMaiSellItemComponent>();

        public UIPageButtonComponent UIPageButton;

        public List<PaiMaiItemInfo> PaiMaiItemInfos = new List<PaiMaiItemInfo>();
        public long PaiMaiItemInfoId;

        public BagComponent BagComponent;
        public BagInfo BagInfo;

        public bool IsHoldDown;
    }

    public class UIStallSellComponentAwakeSystem: AwakeSystem<UIStallSellComponent>
    {
        public override void Awake(UIStallSellComponent self)
        {
            self.BagItemUILIist.Clear();
            self.SellItemUILIist.Clear();
            self.PaiMaiItemInfos.Clear();
            self.PaiMaiItemInfoId = 0;
            self.BagInfo = null;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_ChangeName = rc.Get<GameObject>("Btn_ChangeName");
            ButtonHelp.AddListenerEx(self.Btn_ChangeName, () => { self.OnBtn_ChangeName().Coroutine(); });
            self.Lab_Name = rc.Get<GameObject>("Lab_Name");
            self.Lab_Name.GetComponent<InputField>().onValueChanged.AddListener((string text) => { self.CheckSensitiveWords(); });
            self.Lab_ShengYuTime = rc.Get<GameObject>("Lab_ShengYuTime");
            self.Text_SellTime = rc.Get<GameObject>("Text_SellTime");

            self.Btn_XiaJia = rc.Get<GameObject>("Btn_XiaJia");
            self.Btn_XiaJia.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_XiaJia().Coroutine(); });

            self.Btn_ShangJia = rc.Get<GameObject>("Btn_ShangJia");
            self.Btn_ShangJia.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ShangJia().Coroutine(); });

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.PaiMaiListNode = rc.Get<GameObject>("PaiMaiListNode");
            self.UIPaiMaiSellItem = rc.Get<GameObject>("UIPaiMaiSellItem");
            self.UIPaiMaiSellItem.SetActive(false);

            self.Btn_Stall = rc.Get<GameObject>("Btn_Stall");
            self.Btn_Stall.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Stall(); });

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            self.SellTypeButton = rc.Get<GameObject>("SellTypeButton");
            UI uIPageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", self.SellTypeButton);
            UIPageButtonComponent uIPageButtonComponent = uIPageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
            self.UIPageButton = uIPageButtonComponent;

            string name = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.StallName;
            if (string.IsNullOrEmpty(name))
            {
                name = "商品摊位";
            }

            self.Lab_Name.GetComponent<InputField>().text = name;
            self.RequestSelfPaiMaiList().Coroutine();
        }
    }

    public static class UIStallSellComponentSystem
    {
        public static void CheckSensitiveWords(this UIStallSellComponent self)
        {
            string text_new = "";
            string text_old = self.Lab_Name.GetComponent<InputField>().text;
            MaskWordHelper.Instance.IsContainSensitiveWords(ref text_old, out text_new);
            self.Lab_Name.GetComponent<InputField>().text = text_old;
        }
        
        public static async ETTask OnBtn_ChangeName(this UIStallSellComponent self)
        {
            string name = self.Lab_Name.GetComponent<InputField>().text;
            bool mask = MaskWordHelper.Instance.IsContainSensitiveWords(name);
            if (mask)
            {
                FloatTipManager.Instance.ShowFloatTip("请重新输入！");
                return;
            }

            C2M_StallOperationRequest c2M_StallOperationRequest = new C2M_StallOperationRequest() { StallType = 2, Value = name };
            M2C_StallOperationResponse m2C_PaiMaiBuyResponse =
                    (M2C_StallOperationResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_StallOperationRequest);
            self.Lab_Name.GetComponent<InputField>().text = name;
        }
        
        public static async ETTask RequestSelfPaiMaiList(this UIStallSellComponent self)
        {
            long instanceid = self.InstanceId;
            C2P_StallListRequest c2PStallListRequest = new C2P_StallListRequest()
            {
                UserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId
            };
            P2C_StallListResponse p2CStallListResponse =
                    (P2C_StallListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2PStallListRequest);
            if (self.IsDisposed || instanceid != self.InstanceId)
            {
                return;
            }

            self.PaiMaiItemInfos = p2CStallListResponse.PaiMaiItemInfos;
            self.UpdateSellItemUILIist(self.UIPageButton.CurrentIndex);
        }

        public static void OnUpdateUI(this UIStallSellComponent self)
        {
            self.UpdateBagItemUIList().Coroutine();
            self.UIPageButton.OnSelectIndex(0);
        }

        public static void OnClickPageButton(this UIStallSellComponent self, int page)
        {
            self.UpdateSellItemUILIist(page);
        }

        public static void OnBtn_Stall(this UIStallSellComponent self)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != (int)SceneTypeEnum.MainCityScene)
            {
                //弹出提示
                FloatTipManager.Instance.ShowFloatTip("请前往主城摆摊!");
                return;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (UnitHelper.GetUnitListByDis(unit.DomainScene(), unit.Position, UnitType.Npc, 5f).Count > 0)
            {
                PopupTipHelp.OpenPopupTip_2(self.ZoneScene(), "摆摊提示", "NPC附近不得摆摊, 是否前往摆摊区域进行摆摊?", () => { self.OnRun(); }).Coroutine();
                return;
            }

            Vector3 vector3 = unit.Position;
            int x = Mathf.FloorToInt(vector3.x * 100);
            int z = Mathf.FloorToInt(vector3.z * 100);
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(mapComponent.SceneId);
            int[] stallarea = sceneConfig.StallArea;

            float distance = stallarea[3] > 100 ? stallarea[3] : 300;

            if (Mathf.Abs(x - stallarea[0]) > distance || Mathf.Abs(z - stallarea[2]) > distance)
            {
                PopupTipHelp.OpenPopupTip_2(self.ZoneScene(), "摆摊提示", "是否前往摆摊区域进行摆摊?", () => { self.OnRun(); }).Coroutine();
                return;
            }

            NetHelper.PaiMaiStallRequest(self.DomainScene(), 1).Coroutine();
            UIHelper.Remove(self.DomainScene(), UIType.UIPaiMai);
        }

        public static void OnRun(this UIStallSellComponent self)
        {
            // ETTask.CompletedTask;
            //FloatTipManager.Instance.ShowFloatTip("请前往主城摆摊222!");
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(mapComponent.SceneId);
            int[] stallarea = sceneConfig.StallArea;

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            unit.MoveToAsync2(new Vector3(stallarea[0] * 0.01f, stallarea[1] * 0.01f, stallarea[2] * 0.01f), true).Coroutine();

            UIHelper.Remove(self.DomainScene(), UIType.UIPaiMai);
        }

        public static async ETTask OnBtn_XiaJia(this UIStallSellComponent self)
        {
            if (self.PaiMaiItemInfoId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选中道具");
                return;
            }

            for (int i = self.PaiMaiItemInfos.Count - 1; i >= 0; i--)
            {
                if (self.PaiMaiItemInfos[i].Id == self.PaiMaiItemInfoId)
                {
                    if (self.PaiMaiItemInfos[i].UserId != self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId)
                    {
                        FloatTipManager.Instance.ShowFloatTip("数据错误!");
                        return;
                    }
                }
            }

            C2M_StallXiaJiaRequest c2MStallXiaJiaRequest = new C2M_StallXiaJiaRequest() { PaiMaiItemInfoId = self.PaiMaiItemInfoId };
            M2C_StallXiaJiaResponse m2CStallXiaJiaResponse =
                    (M2C_StallXiaJiaResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2MStallXiaJiaRequest);
            if (self.IsDisposed)
            {
                return;
            }

            for (int i = self.PaiMaiItemInfos.Count - 1; i >= 0; i--)
            {
                if (self.PaiMaiItemInfos[i].Id == self.PaiMaiItemInfoId)
                {
                    self.PaiMaiItemInfos.RemoveAt(i);
                }
            }

            self.PaiMaiItemInfoId = 0;

            self.UpdateBagItemUIList().Coroutine();
            self.UpdateSellItemUILIist(self.UIPageButton.CurrentIndex);
        }

        public static async ETTask OnBtn_ShangJia(this UIStallSellComponent self)
        {
            if (self.BagInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip("请选中道具！");
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
            if (itemConfig.IfStopPaiMai == 1)
            {
                FloatTipManager.Instance.ShowFloatTip("此道具禁止上架！");
                return;
            }
            if (!ComHelp.IsShowPaiMai(itemConfig.ItemType, itemConfig.ItemSubType))
            {
                FloatTipManager.Instance.ShowFloatTip("此道具不能上架！");
                return;
            }
            if (self.PaiMaiItemInfos.Count >= GlobalValueConfigCategory.Instance.Get(50).Value2)
            {
                FloatTipManager.Instance.ShowFloatTip("已经达到最大上架数量！");
                return;
            }

            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIStallSellPrice);
            uI.GetComponent<UIStallSellPriceComponent>().InitPriceUI(self.BagInfo);
        }

        public static async ETTask UpdateBagItemUIList(this UIStallSellComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            int number = 0;
            List<BagInfo> equipInfos = self.BagComponent.GetBagList();
            for (int i = 0; i < equipInfos.Count; i++)
            {
                if (equipInfos[i].isBinging || equipInfos[i].IsProtect)
                {
                    continue;
                }

                UIItemComponent uI = null;
                if (number < self.BagItemUILIist.Count)
                {
                    uI = self.BagItemUILIist[number];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.ItemListNode);
                    go.transform.localScale = Vector3.one * 1f;
                    uI = self.AddChild<UIItemComponent, GameObject>(go);
                    uI.HideItemName();
                    uI.SetClickHandler((BagInfo baginfo) => { self.OnSelectItem(baginfo); });
                    self.BagItemUILIist.Add(uI);
                }

                number++;
                uI.UpdateItem(equipInfos[i], ItemOperateEnum.PaiMaiSell);
            }

            for (int i = number; i < self.BagItemUILIist.Count; i++)
            {
                self.BagItemUILIist[i].GameObject.SetActive(false);
            }
        }

        public static void OnPaiBuyShangJia(this UIStallSellComponent self, PaiMaiItemInfo paiMaiItemInfo)
        {
            self.BagInfo = null; //选中置空
            self.PaiMaiItemInfos.Add(paiMaiItemInfo); //增加拍卖行出售的列表

            self.UpdateBagItemUIList().Coroutine();
            self.UpdateSellItemUILIist(self.UIPageButton.CurrentIndex);
        }

        public static void OnSelectItem(this UIStallSellComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;

            //增加选中状态
            for (int i = 0; i < self.BagItemUILIist.Count; i++)
            {
                self.BagItemUILIist[i].SetSelected(bagInfo);
            }
        }

        public static void OnSelectSellItem(this UIStallSellComponent self, PaiMaiItemInfo paiMaiItemInfo)
        {
            self.PaiMaiItemInfoId = paiMaiItemInfo.Id;

            for (int i = 0; i < self.SellItemUILIist.Count; i++)
            {
                self.SellItemUILIist[i].SetSelected(paiMaiItemInfo.Id);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="subType">0 装备   1其他</param>
        /// <returns></returns>
        public static void UpdateSellItemUILIist(this UIStallSellComponent self, int subType)
        {
            int number = 0;
            for (int i = 0; i < self.PaiMaiItemInfos.Count; i++)
            {
                PaiMaiItemInfo paiMaiItemInfo = self.PaiMaiItemInfos[i];
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
                if (subType == 1 && itemConfig.ItemType != ItemTypeEnum.Equipment)
                {
                    continue;
                }

                if (subType == 2 && itemConfig.ItemType == ItemTypeEnum.Equipment)
                {
                    continue;
                }

                UIPaiMaiSellItemComponent uI = null;
                if (number < self.SellItemUILIist.Count)
                {
                    uI = self.SellItemUILIist[number];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.UIPaiMaiSellItem);
                    go.SetActive(true);
                    UICommonHelper.SetParent(go, self.PaiMaiListNode);
                    go.transform.localScale = Vector3.one * 1f;
                    uI = self.AddChild<UIPaiMaiSellItemComponent, GameObject>(go);
                    uI.SetClickHandler((PaiMaiItemInfo bagInfo) => { self.OnSelectSellItem(bagInfo); });
                    self.SellItemUILIist.Add(uI);
                }

                uI.OnUpdateUI(paiMaiItemInfo);
                number++;
            }

            for (int i = number; i < self.SellItemUILIist.Count; i++)
            {
                self.SellItemUILIist[i].GameObject.SetActive(false);
            }

            //显示上架数量
            int maxNum = GlobalValueConfigCategory.Instance.Get(50).Value2;
            self.Text_SellTime.GetComponent<Text>().text = "已上架:"  + $"{self.PaiMaiItemInfos.Count}/{maxNum}";
        }

        public static async ETTask OnPointerDown(this UIStallSellComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = true;
            self.OnSelectItem(binfo);

            long instanceId = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(100);
            if (instanceId != self.InstanceId || !self.IsHoldDown)
                return;
            EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            EventType.ShowItemTips.Instance.bagInfo = binfo;
            EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
            EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static void OnPointerUp(this UIPaiMaiSellComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips);
        }
    }
}