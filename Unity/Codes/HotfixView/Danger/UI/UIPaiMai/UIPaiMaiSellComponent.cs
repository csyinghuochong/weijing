using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace ET
{
    public class UIPaiMaiSellComponent : Entity, IAwake
    {

        public GameObject Btn_Stall;
        public GameObject Lab_ShengYuTime;
        public GameObject Text_SellTime;
        public GameObject Btn_XiaJia;
        public GameObject Btn_ShangJia;
        public GameObject ItemListNode;
        public GameObject PaiMaiListNode;

        public List<UI> BagItemUILIist = new List<UI>();
        public List<UI> SellItemUILIist = new List<UI>();

        public List<PaiMaiItemInfo> PaiMaiItemInfos = new List<PaiMaiItemInfo>();
        public long PaiMaiItemInfoId;

        public BagComponent BagComponent;
        public BagInfo BagInfo;

        public bool IsHoldDown;
    }

    [ObjectSystem]
    public class UIPaiMaiSellComponentAwakeSystem : AwakeSystem<UIPaiMaiSellComponent>
    {
        public override void Awake(UIPaiMaiSellComponent self)
        {
            self.BagItemUILIist.Clear();
            self.SellItemUILIist.Clear();
            self.PaiMaiItemInfos.Clear();
            self.PaiMaiItemInfoId = 0;
            self.BagInfo = null;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Lab_ShengYuTime = rc.Get<GameObject>("Lab_ShengYuTime");
            self.Text_SellTime = rc.Get<GameObject>("Text_SellTime");

            self.Btn_XiaJia = rc.Get<GameObject>("Btn_XiaJia");
            self.Btn_XiaJia.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_XiaJia().Coroutine(); });

            self.Btn_ShangJia = rc.Get<GameObject>("Btn_ShangJia");
            self.Btn_ShangJia.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ShangJia().Coroutine(); });

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.PaiMaiListNode = rc.Get<GameObject>("PaiMaiListNode");

            self.Btn_Stall = rc.Get<GameObject>("Btn_Stall");
            self.Btn_Stall.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Stall(); });

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            self.RequestSelfPaiMaiList().Coroutine();
        }
    }

    public static class UIPaiMaiSellComponentSystem
    {

        public static void OnBtn_Stall(this UIPaiMaiSellComponent self)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.MainCityScene)
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
                Vector3 vector3 = unit.Position;
                int x = Mathf.FloorToInt(vector3.x * 100);
                int z = Mathf.FloorToInt(vector3.z * 100);
                SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(mapComponent.SceneId);
                int[] stallarea = sceneConfig.StallArea;
                if (Mathf.Abs(x -stallarea[0]) < stallarea[3] && Mathf.Abs(z - stallarea[2]) < stallarea[3])
                {
                    NetHelper.PaiMaiStallRequest(self.DomainScene(), 1).Coroutine();
                    UIHelper.Remove(self.DomainScene(), UIType.UIPaiMai).Coroutine();
                }
                else
                {
                    FloatTipManager.Instance.ShowFloatTip("请前往摆摊区域!");
                    PopupTipHelp.OpenPopupTip_2(self.ZoneScene(), "摆摊提示", "是否前往摆摊区域进行摆摊?", () => { self.OnRun(); }).Coroutine();
                }
            }
            else
            {
                //弹出提示
                FloatTipManager.Instance.ShowFloatTip("请前往主城摆摊!");
            }
        }

        public static void  OnRun(this UIPaiMaiSellComponent self)
        {
            // ETTask.CompletedTask;
            //FloatTipManager.Instance.ShowFloatTip("请前往主城摆摊222!");
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            unit.MoveToAsync2(new Vector3(-48,1.5f,-34), false).Coroutine();
        }

        public static async ETTask OnBtn_XiaJia(this UIPaiMaiSellComponent self)
        {
            if (self.PaiMaiItemInfoId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选中道具");
                return;
            }

            C2M_PaiMaiXiaJiaRequest c2M_PaiMaiBuyRequest = new C2M_PaiMaiXiaJiaRequest() {  PaiMaiItemInfoId = self.PaiMaiItemInfoId };
            M2C_PaiMaiXiaJiaResponse m2C_PaiMaiBuyResponse = (M2C_PaiMaiXiaJiaResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

            for (int i = self.PaiMaiItemInfos.Count - 1; i >= 0; i--)
            {
                if (self.PaiMaiItemInfos[i].Id == self.PaiMaiItemInfoId)
                {
                    self.PaiMaiItemInfos.RemoveAt(i);
                }
            }
            self.PaiMaiItemInfoId = 0;

            self.OnUpdateUI();
        }

        public static async ETTask OnBtn_ShangJia(this UIPaiMaiSellComponent self)
        {
            if (self.BagInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip("请选中道具！");
                return;
            }
            if (self.PaiMaiItemInfos.Count >= GlobalValueConfigCategory.Instance.Get(50).Value2)
            {
                FloatTipManager.Instance.ShowFloatTip("已经达到最大上架数量！");
                return;
            }

            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIPaiMaiSellPrice);
            uI.GetComponent<UIPaiMaiSellPriceComponent>().InitPriceUI(self.BagInfo);
        }

        public static void OnUpdateUI(this UIPaiMaiSellComponent self)
        {
            self.UpdateBagItemUIList().Coroutine();
            self.UpdateSellItemUILIist().Coroutine();
        }

        public static async ETTask RequestSelfPaiMaiList(this UIPaiMaiSellComponent self)
        {
            C2P_PaiMaiListRequest c2M_PaiMaiBuyRequest = new C2P_PaiMaiListRequest() {  PaiMaiType = 1,
                UserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId };
            P2C_PaiMaiListResponse m2C_PaiMaiBuyResponse = (P2C_PaiMaiListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);
            self.PaiMaiItemInfos = m2C_PaiMaiBuyResponse.PaiMaiItemInfos;

            self.UpdateSellItemUILIist().Coroutine();
        }

        public static async ETTask UpdateBagItemUIList(this UIPaiMaiSellComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            await ETTask.CompletedTask;
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            int number = 0;
            List<BagInfo> equipInfos = self.BagComponent.GetBagList();
            for (int i = 0; i < equipInfos.Count; i++)
            {
                if (equipInfos[i].isBinging)
                {
                    continue;
                }

                UI uI = null;
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
                    uI = self.AddChild<UI, string, GameObject>( "BagItemUILIist_" + number, go);
                    UIItemComponent uIItemComponent = uI.AddComponent<UIItemComponent>();
                    uIItemComponent.HideItemName();
                 
                    uIItemComponent.SetEventTrigger(true);
                    uIItemComponent.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerDown(binfo, pdata).Coroutine(); };
                    uIItemComponent.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerUp(binfo, pdata); };

                    self.BagItemUILIist.Add(uI);
                }
                number++;
                uI.GetComponent<UIItemComponent>().UpdateItem(equipInfos[i], ItemOperateEnum.PaiMaiSell);
            }
            for (int i = number; i < self.BagItemUILIist.Count; i++)
            {
                self.BagItemUILIist[i].GameObject.SetActive(false);
            }
        }

        public static void OnPaiBuyShangJia(this UIPaiMaiSellComponent self, PaiMaiItemInfo paiMaiItemInfo)
        {
            self.PaiMaiItemInfos.Add(paiMaiItemInfo);       //增加拍卖行出售的列表
            self.BagInfo = null;                            //选中置空
            self.OnUpdateUI();
        }

        public static void OnSelectItem(this UIPaiMaiSellComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;

            //增加选中状态
            for (int i = 0; i < self.BagItemUILIist.Count; i++)
            {
                self.BagItemUILIist[i].GetComponent<UIItemComponent>().SetSelected(bagInfo);
            }
        }

        public static void OnSelectSellItem(this UIPaiMaiSellComponent self, PaiMaiItemInfo paiMaiItemInfo)
        {
            self.PaiMaiItemInfoId = paiMaiItemInfo.Id;

            for (int i = 0; i < self.SellItemUILIist.Count; i++)
            {
                self.SellItemUILIist[i].GetComponent<UIPaiMaiSellItemComponent>().SetSelected(paiMaiItemInfo.Id);
            }
        }

        public static async ETTask UpdateSellItemUILIist(this UIPaiMaiSellComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiSellItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            for (int i = 0; i < self.PaiMaiItemInfos.Count; i++)
            {
                UI uI = null;
                if (i < self.SellItemUILIist.Count)
                {
                    uI = self.SellItemUILIist[i];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.PaiMaiListNode);
                    go.transform.localScale = Vector3.one * 1f;
                    uI = self.AddChild<UI, string, GameObject>( "BagItemUILIist_" + i, go);
                    UIPaiMaiSellItemComponent uIItemComponent = uI.AddComponent<UIPaiMaiSellItemComponent>();
                    uIItemComponent.SetClickHandler((PaiMaiItemInfo bagInfo) => { self.OnSelectSellItem(bagInfo); });
                    self.SellItemUILIist.Add(uI);
                }
                uI.GetComponent<UIPaiMaiSellItemComponent>().OnUpdateUI(self.PaiMaiItemInfos[i]);
            }
            for (int i = self.PaiMaiItemInfos.Count; i < self.SellItemUILIist.Count; i++)
            {
                self.SellItemUILIist[i].GameObject.SetActive(false);
            }
        }
        
        public static async ETTask OnPointerDown(this UIPaiMaiSellComponent self, BagInfo binfo, PointerEventData pdata)
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
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips).Coroutine();
        }
        
    }

}
