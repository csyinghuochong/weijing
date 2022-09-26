using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiShopComponent : Entity, IAwake
    {
        public GameObject Btn_BuyItem;
        public GameObject TypeListNode;
        public GameObject ItemListNode;
        public GameObject Obj_Lab_BuyPrice;
        public GameObject Obj_Lab_BuyNum;
        public GameObject Btn_BuyNum_jia1;
        public GameObject Btn_BuyNum_jia10;
        public GameObject Btn_BuyNum_jian1;
        public GameObject Btn_BuyNum_jian10;

        public List<UI> TypeItemUIList = new List<UI>();
        public List<UI> ItemUIList = new List<UI>();
        public int PaiMaiTypeId;
        public int PaiMaiSellId;
        public int BuyNum;

        public Dictionary<long, PaiMaiShopItemInfo> PaiMaiShopItemInfos = new Dictionary<long, PaiMaiShopItemInfo>();       //快捷存储列表
    }

    [ObjectSystem]
    public class UIPaiMaiShopComponentAwakeSystem : AwakeSystem<UIPaiMaiShopComponent>
    {
        public override async void Awake(UIPaiMaiShopComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_BuyItem = rc.Get<GameObject>("Btn_BuyItem");
            self.Btn_BuyItem.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_BuyItem().Coroutine(); });

            self.Btn_BuyNum_jia1 = rc.Get<GameObject>("Btn_BuyNum_jia1");
            self.Btn_BuyNum_jia1.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(1); });

            self.Btn_BuyNum_jia10 = rc.Get<GameObject>("Btn_BuyNum_jia10");
            self.Btn_BuyNum_jia10.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(10); });

            self.Btn_BuyNum_jian1 = rc.Get<GameObject>("Btn_BuyNum_jian1");
            self.Btn_BuyNum_jian1.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(-1); });

            self.Btn_BuyNum_jian10 = rc.Get<GameObject>("Btn_BuyNum_jian10");
            self.Btn_BuyNum_jian10.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(-10); });

            self.TypeListNode = rc.Get<GameObject>("TypeListNode");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.Obj_Lab_BuyPrice = rc.Get<GameObject>("Lab_BuyPrice");
            self.Obj_Lab_BuyNum = rc.Get<GameObject>("Lab_BuyNum");

            self.PaiMaiTypeId = 0;
            self.ItemUIList.Clear();
            self.TypeItemUIList.Clear();

            await self.RequestPaiMaiShopData();    //初始化数据
            self.InitPaiMaiType().Coroutine();    //初始化显示
        }
    }

    public static class UIPaiMaiShopComponentSystem
    {

        public static async ETTask RequestPaiMaiShopData(this UIPaiMaiShopComponent self) {

            //请求当前快捷拍卖的对应价格
            C2P_PaiMaiShopShowListRequest c2P_PaiMaiShopShowListRequest = new C2P_PaiMaiShopShowListRequest() { };
            P2C_PaiMaiShopShowListResponse p2C_PaiMaiShopShowListResponse = (P2C_PaiMaiShopShowListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2P_PaiMaiShopShowListRequest);

            //添加缓存
            foreach (PaiMaiShopItemInfo data in p2C_PaiMaiShopShowListResponse.PaiMaiShopItemInfos) {
                self.PaiMaiShopItemInfos.Add(data.Id, data);
            }

            //缓存存储
            UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UIPaiMai);
            if (ui != null)
            {
                ui.GetComponent<UIPaiMaiComponent>().PaiMaiShopItemInfos = self.PaiMaiShopItemInfos;
            }
        }

        public static async ETTask InitPaiMaiType(this UIPaiMaiShopComponent self)
        {
            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiShopType");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            for (int i = (int)PaiMaiTypeEnum.CaiLiao; i < (int)PaiMaiTypeEnum.Number; i++)
            {
                GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(taskTypeItem, self.TypeListNode);

                UI ui_1 = self.AddChild<UI, string, GameObject>( "paimaiTypeItem_" + i.ToString(), taskTypeItem);
                UIPaiMaiShopTypeComponent uIItemComponent = ui_1.AddComponent<UIPaiMaiShopTypeComponent>();
                uIItemComponent.OnUpdateData(i);
                uIItemComponent.SetClickTypeHandler((int typeid) => { self.OnClickType(typeid); });
                uIItemComponent.SetClickTypeItemHandler((int typeid, int chapterId) => { self.OnClickTypeItem(typeid, chapterId).Coroutine(); });

                self.TypeItemUIList.Add(ui_1);
            }

            self.TypeItemUIList[0].GetComponent<UIPaiMaiShopTypeComponent>().OnClickTypeButton();
        }

        public static async ETTask OnBtn_BuyItem(this UIPaiMaiShopComponent self)
        {
            if (self.PaiMaiSellId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选中要拍卖的商品！");
                return;
            }

            C2M_PaiMaiShopRequest c2M_PaiMaiBuyRequest = new C2M_PaiMaiShopRequest() { PaiMaiId = self.PaiMaiSellId ,BuyNum = self.BuyNum};
            M2C_PaiMaiShopResponse m2C_PaiMaiBuyResponse = (M2C_PaiMaiShopResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);
        }

        public static void OnClickType(this UIPaiMaiShopComponent self, int typeid)
        {
            self.PaiMaiTypeId = typeid;
            for (int i = 0; i < self.TypeItemUIList.Count; i++)
            {
                UIPaiMaiShopTypeComponent uIChengJiuTypeComponent = self.TypeItemUIList[i].GetComponent<UIPaiMaiShopTypeComponent>();
                uIChengJiuTypeComponent.SetSelected(typeid).Coroutine();
            }
        }

        //快捷购买点击类型展示列表
        public static async ETTask OnClickTypeItem(this UIPaiMaiShopComponent self, int typeid, int chapterId)
        {
            self.PaiMaiTypeId = typeid;
            long instanceid = self.InstanceId;
            List<int> ids = PaiMaiHelper.Instance.GetItemsByChapter(typeid, chapterId);
            string path = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiShopItem");
            await ETTask.CompletedTask;
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            List<int> caoLiaoShow = new List<int>() { 1, 2};
            int number = 0;
            for (int i = 0; i < ids.Count; i++)
            {
                PaiMaiSellConfig paiMaiSellConfig = PaiMaiSellConfigCategory.Instance.Get(ids[i]);
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiSellConfig.ItemID);
                if (typeid == (int)PaiMaiTypeEnum.CaiLiao)
                {
                    if (!caoLiaoShow.Contains(itemConfig.ItemSubType))
                    {
                        continue;
                    }
                }

                UI ui_1;
                if (number < self.ItemUIList.Count)
                {
                    ui_1 = self.ItemUIList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject uiChengJiuShowItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(uiChengJiuShowItem, self.ItemListNode);
                    ui_1 = self.AddChild<UI, string, GameObject>( "uiChengJiuShowItem_" + i.ToString(), uiChengJiuShowItem);
                    UIPaiMaiShopItemComponent uIPaiMaiBuyItemComponent = ui_1.AddComponent<UIPaiMaiShopItemComponent>();
                    uIPaiMaiBuyItemComponent.SetClickHandler((int paimaiId) => { self.OnClickPaiMaiBuyItem(paimaiId); });
                    self.ItemUIList.Add(ui_1);
                }
                Log.Info("self.PaiMaiShopItemInfos = " + self.PaiMaiShopItemInfos.Count + "ids[i] = " + ids[i]);
                ui_1.GetComponent<UIPaiMaiShopItemComponent>().OnUpdateData(ids[i],self.PaiMaiShopItemInfos[PaiMaiSellConfigCategory.Instance.Get(ids[i]).ItemID]);
                number++;
            }

            if (number > 0)
            {
                self.ItemUIList[0].GetComponent<UIPaiMaiShopItemComponent>().ImageButton();
            }

            for (int i = number; i < self.ItemUIList.Count; i++)
            {
                self.ItemUIList[i].GameObject.SetActive(false);
            }
        }

        public static void OnClickPaiMaiBuyItem(this UIPaiMaiShopComponent self, int paimaiId)
        {
            self.PaiMaiSellId = paimaiId;
            for (int i = 0; i < self.ItemUIList.Count; i++)
            {
                self.ItemUIList[i].GetComponent<UIPaiMaiShopItemComponent>().SetSelected(paimaiId);
            }

            //更新显示
            PaiMaiShopItemInfo shopInfo = self.PaiMaiShopItemInfos[(long)(PaiMaiSellConfigCategory.Instance.Get(paimaiId).ItemID)];
            self.Obj_Lab_BuyPrice.GetComponent<Text>().text = shopInfo.Price.ToString();

            self.BuyNum = 1;
            self.Obj_Lab_BuyNum.GetComponent<Text>().text = self.BuyNum.ToString();
        }

        //改变当前购买数量
        public static void OnClickChangeBuyNum(this UIPaiMaiShopComponent self, int num) {

            self.BuyNum += num;
            if (self.BuyNum <= 1) {
                self.BuyNum = 1;
            }

            //数量显示
            self.Obj_Lab_BuyNum.GetComponent<Text>().text = self.BuyNum.ToString();

            PaiMaiShopItemInfo shopInfo = self.PaiMaiShopItemInfos[(long)(PaiMaiSellConfigCategory.Instance.Get(self.PaiMaiSellId).ItemID)];

            //价格显示
            self.Obj_Lab_BuyPrice.GetComponent<Text>().text = (shopInfo.Price * self.BuyNum).ToString();
        }
    }
}
