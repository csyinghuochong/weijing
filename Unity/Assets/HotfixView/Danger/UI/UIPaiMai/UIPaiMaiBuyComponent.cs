using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiBuyComponent : Entity, IAwake
    {
        public GameObject Btn_Refresh;
        public GameObject TypeListNode;
        public GameObject Btn_Search;
        public GameObject InputField;
        public GameObject ItemListNode;

        public List<UIPaiMaiBuyItemComponent> PaiMaiList = new List<UIPaiMaiBuyItemComponent>();
        public UITypeViewComponent UITypeViewComponent;
        public int PageIndex;

        //当前用到的
        public List<PaiMaiItemInfo> PaiMaiIteminfos_Now = new List<PaiMaiItemInfo>();

        //-----------拍卖行缓存----------
        //消耗品
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Consume = new List<PaiMaiItemInfo>();
        //材料
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Material = new List<PaiMaiItemInfo>();
        //装备
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Equipment = new List<PaiMaiItemInfo>();
        //宝石
        public List<PaiMaiItemInfo> PaiMaiItemInfos_Gemstone = new List<PaiMaiItemInfo>();
    }


    public class UIPaiMaiBuyComponentAwakeSystem : AwakeSystem<UIPaiMaiBuyComponent>
    {
        public override void Awake(UIPaiMaiBuyComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TypeListNode = rc.Get<GameObject>("TypeListNode");
            self.UITypeViewComponent = self.AddChild<UITypeViewComponent, GameObject>(self.TypeListNode);
            self.UITypeViewComponent.TypeButtonItemAsset = ABPathHelper.GetUGUIPath("Main/Common/UITypeItem");
            self.UITypeViewComponent.TypeButtonAsset = ABPathHelper.GetUGUIPath("Main/Common/UITypeButton");
            self.UITypeViewComponent.ClickTypeItemHandler = (int typeid, int subtypeid) => { self.OnClickTypeItem(typeid, subtypeid); };

            self.UITypeViewComponent.TypeButtonInfos = self.InitTypeButtonInfos();
            self.UITypeViewComponent.OnInitUI().Coroutine();

            self.Btn_Search = rc.Get<GameObject>("Btn_Search");
            self.Btn_Search.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn_Search(); });

            self.Btn_Refresh = rc.Get<GameObject>("Btn_Refresh");
            self.Btn_Refresh.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn_Refresh(); });

            self.InputField = rc.Get<GameObject>("InputField");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.PaiMaiList.Clear();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            //初始化数据显示
            //self.PaiMaiBuyInit(1).Coroutine();
            //展示列表数据
            self.InitShow().Coroutine();
        }
    }

    public static class UIPaiMaiBuyComponentSystem
    {
        //初始化数据列表
        public static List<TypeButtonInfo> InitTypeButtonInfos(this UIPaiMaiBuyComponent self)
        {

            //显示列表
            TypeButtonInfo typeButtonInfo = new TypeButtonInfo();
            List<TypeButtonInfo> typeButtonInfos = new List<TypeButtonInfo>();
            typeButtonInfo = new TypeButtonInfo();
            foreach (int key in ItemViewHelp.ItemSubType1Name.Keys) 
            {

                typeButtonInfo.typeButtonItems.Add(new TypeButtonItem() { SubTypeId = key, ItemName = ItemViewHelp.ItemSubType1Name[key] });
            }

            typeButtonInfo.TypeId = 1;
            typeButtonInfo.TypeName = ItemViewHelp.ItemTypeName[ItemTypeEnum.Consume];
            typeButtonInfos.Add(typeButtonInfo);

            typeButtonInfo = new TypeButtonInfo();
            foreach (int key in ItemViewHelp.ItemSubType2Name.Keys)
            {
                typeButtonInfo.typeButtonItems.Add(new TypeButtonItem() { SubTypeId = key, ItemName = ItemViewHelp.ItemSubType2Name[key] });
            }


            typeButtonInfo.TypeId = 2;
            typeButtonInfo.TypeName = ItemViewHelp.ItemTypeName[ItemTypeEnum.Material];
            typeButtonInfos.Add(typeButtonInfo);

            typeButtonInfo = new TypeButtonInfo();
            foreach (int key in ItemViewHelp.ItemSubType3Name.Keys)
            {
                typeButtonInfo.typeButtonItems.Add(new TypeButtonItem() { SubTypeId = key, ItemName = ItemViewHelp.ItemSubType3Name[key] });
            }


            typeButtonInfo.TypeId = 3;
            typeButtonInfo.TypeName = ItemViewHelp.ItemTypeName[ItemTypeEnum.Equipment];
            typeButtonInfos.Add(typeButtonInfo);


            typeButtonInfo = new TypeButtonInfo();
            foreach (int key in ItemViewHelp.ItemSubType4Name.Keys)
            {
                typeButtonInfo.typeButtonItems.Add(new TypeButtonItem() { SubTypeId = key, ItemName = ItemViewHelp.ItemSubType4Name[key] });
            }

            typeButtonInfo.TypeId = 4;
            typeButtonInfo.TypeName = ItemViewHelp.ItemTypeName[ItemTypeEnum.Gemstone];
            typeButtonInfos.Add(typeButtonInfo);

            return typeButtonInfos;
        }

        public static async void OnClickTypeItem(this UIPaiMaiBuyComponent self, int typeid, int subtypeid)
        {

            Debug.Log("点击OnClickTypeItem...." + typeid);
            self.PaiMaiIteminfos_Now.Clear();
            switch (typeid)
            {
                case 1:
                    if (self.PaiMaiItemInfos_Consume.Count>0) 
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Consume;
                    }
                    break;

                case 2:
                    if (self.PaiMaiItemInfos_Material.Count > 0)
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Material;
                    }
                    break;

                case 3:

                    if (self.PaiMaiItemInfos_Equipment.Count > 0)
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Equipment;
                    }
                    break;

                case 4:

                    if (self.PaiMaiItemInfos_Gemstone.Count > 0)
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Gemstone;
                    }
                    break;
            }

            //每次点击进行清理
            if (self.ItemListNode != null)
            {
                FunctionUI.GetInstance().DestoryTargetObj(self.ItemListNode);
            }
            self.PaiMaiList.Clear();
            if (self.PaiMaiIteminfos_Now.Count <= 0)
            {
                self.PaiMaiList.Clear();
                //去服务器读取数据
                await self.PaiMaiBuyInit(typeid);
            }

            //展示列表数据
            await self.ShowPaiMaiList();

            Debug.Log("self.PaiMaiIteminfos_Now.Count...." + self.PaiMaiIteminfos_Now.Count + ";self.PaiMaiList = " + self.PaiMaiList.Count);

            for (int i = 0; i < self.PaiMaiList.Count; i++)
            {
                UIPaiMaiBuyItemComponent paimaibuy = self.PaiMaiList[i];
                if (paimaibuy.PaiMaiItemInfo == null)
                {
                    paimaibuy.GameObject.SetActive(false);
                    continue;
                }

                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paimaibuy.PaiMaiItemInfo.BagInfo.ItemID);
                //显示   0表示通用
                if (itemConfig.ItemType == typeid && subtypeid == 0)
                {
                    paimaibuy.GameObject.SetActive(true);
                }
                else
                {
                    //子类符合对应关系
                    int itemSubType = itemConfig.ItemSubType;
                    //生肖特殊处理
                    if (itemConfig.ItemType == 3 && itemConfig.ItemSubType >= 1101 && itemConfig.ItemSubType < 1600)
                    {
                        itemSubType = 1100;
                    }
                    paimaibuy.GameObject.SetActive(itemConfig.ItemType == typeid && itemSubType == subtypeid);
                }
            }
        }

        public static void OnUpdateUI(this UIPaiMaiBuyComponent self)
        {
            //Debug.Log("OnUpdateUI...");
            //self.PageIndex = 1;
            //self.RequestAllPaiMaiList().Coroutine();
        }

        //下一页
        public static void OnClickBtn_Refresh(this UIPaiMaiBuyComponent self)
        {
            //Debug.Log("OnClickBtn_Refresh...");
            self.PageIndex++;
            self.RequestAllPaiMaiList().Coroutine();
        }

        //查询按钮
        public static void OnClickBtn_Search(this UIPaiMaiBuyComponent self)
        {
            string text = self.InputField.GetComponent<InputField>().text;

            for (int i = 0; i < self.PaiMaiList.Count; i++)
            {
                UIPaiMaiBuyItemComponent uIPaiMaiBuy = self.PaiMaiList[i];
                if (uIPaiMaiBuy.PaiMaiItemInfo == null)
                {
                    uIPaiMaiBuy.GameObject.SetActive(false);
                    continue;
                }
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(uIPaiMaiBuy.PaiMaiItemInfo.BagInfo.ItemID);
                uIPaiMaiBuy.GameObject.SetActive(itemConfig.ItemName.Contains(text));
            }
        }

        public static async ETTask InitShow(this UIPaiMaiBuyComponent self) {

            //初始化数据显示
            await self.PaiMaiBuyInit(1);
            //展示列表数据
            self.OnClickTypeItem(1,0);

        }


        //初始化,拍卖数据
        public static async ETTask PaiMaiBuyInit(this UIPaiMaiBuyComponent self,int showType) {

            long instanceId = self.InstanceId;

            C2P_PaiMaiListRequest c2M_PaiMaiBuyRequest = new C2P_PaiMaiListRequest() 
            { 
                ActorId = self.PageIndex,
                PaiMaiType = 2,
                PaiMaiShowType = showType,
                UserId = UnitHelper.GetMyUnitId(self.ZoneScene()),
            
            };
            P2C_PaiMaiListResponse m2C_PaiMaiBuyResponse = (P2C_PaiMaiListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

            //因为是异步不加这里,消息来了玩家关闭界面会报错
            if (instanceId != self.InstanceId)
            {
                return;
            }

            if (m2C_PaiMaiBuyResponse.Error == ErrorCode.ERR_Success) {
                self.PaiMaiItemInfos_Consume = m2C_PaiMaiBuyResponse.PaiMaiItemInfos;
                //赋值当前显示
                self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Consume;
            }
        }

        public static async ETTask ShowPaiMaiList(this UIPaiMaiBuyComponent self)
        {
            //Debug.Log("self.PageIndex = " + self.PageIndex);

            //self.Btn_Refresh.SetActive(m2C_PaiMaiBuyResponse.Message.Equals("0"));

            if (self.PaiMaiIteminfos_Now.Count <= 0) {
                return;
            }

            self.PaiMaiList.Clear();

            long instanceId = self.InstanceId;

            var path = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiBuyItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            //因为是异步不加这里,消息来了玩家关闭界面会报错
            if (instanceId != self.InstanceId)
            {
                return;
            }

            int number = 0;
            List<PaiMaiItemInfo> PaiMaiItemInfos = self.PaiMaiIteminfos_Now;
            for (int i = 0; i < PaiMaiItemInfos.Count; i++)
            {
                PaiMaiItemInfo paiMaiItemInfo = PaiMaiItemInfos[i];
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
                if (!ComHelp.IsShowPaiMai(itemConfig.ItemType, itemConfig.ItemSubType))
                {
                    continue;
                }

                UIPaiMaiBuyItemComponent uI = null;
                /*
                if (number < self.PaiMaiList.Count)
                {
                    uI = self.PaiMaiList[number];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                */
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.ItemListNode);
                    go.transform.localScale = Vector3.one * 1f;
                    uI = self.AddChild<UIPaiMaiBuyItemComponent, GameObject>(go);
                    self.PaiMaiList.Add(uI);
                //}

                uI.OnUpdateItem(paiMaiItemInfo);
                number++;
            }

            
            //刷新列表  默认不显示全部
            /*
            for (int i = number; i < self.PaiMaiList.Count; i++)
            {
                self.PaiMaiList[i].OnUpdateItem(null);
                self.PaiMaiList[i].GameObject.SetActive(false);
            }
            */
            //选择刷新列表
            //self.UITypeViewComponent.TypeButtonComponents[0].OnClickTypeButton();
        }


        //因为不显示全部,此函数暂时废弃
        public static async ETTask RequestAllPaiMaiList(this UIPaiMaiBuyComponent self)
        {
            //Debug.Log("self.PageIndex = " + self.PageIndex);

            long instanceId = self.InstanceId;
            C2P_PaiMaiListRequest c2M_PaiMaiBuyRequest = new C2P_PaiMaiListRequest()
            {
                ActorId = self.PageIndex,
                PaiMaiType = 2,
                PaiMaiShowType = self.PageIndex,
                UserId = UnitHelper.GetMyUnitId(self.ZoneScene()),
            };
            P2C_PaiMaiListResponse m2C_PaiMaiBuyResponse = (P2C_PaiMaiListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            self.Btn_Refresh.SetActive(m2C_PaiMaiBuyResponse.Message.Equals("0"));

            instanceId = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiBuyItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }

            int number = 0;
            List<PaiMaiItemInfo> PaiMaiItemInfos = m2C_PaiMaiBuyResponse.PaiMaiItemInfos;
            for (int i = 0; i < PaiMaiItemInfos.Count; i++)
            {
                PaiMaiItemInfo paiMaiItemInfo = PaiMaiItemInfos[i];
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
                if (!ComHelp.IsShowPaiMai(itemConfig.ItemType, itemConfig.ItemSubType))
                {
                    continue;
                }

                UIPaiMaiBuyItemComponent uI = null;
                if (number < self.PaiMaiList.Count)
                {
                    uI = self.PaiMaiList[number];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.ItemListNode);
                    go.transform.localScale = Vector3.one * 1f;
                    uI = self.AddChild<UIPaiMaiBuyItemComponent, GameObject>( go);
                    self.PaiMaiList.Add(uI);
                }

                uI.OnUpdateItem(paiMaiItemInfo);
                number++;
            }
            //刷新列表
            for (int i = number; i < self.PaiMaiList.Count; i++)
            {
                self.PaiMaiList[i].OnUpdateItem(null);
                self.PaiMaiList[i].GameObject.SetActive(false);
            }
            //选择刷新列表
            self.UITypeViewComponent.TypeButtonComponents[0].OnClickTypeButton();
        }
    }
}
