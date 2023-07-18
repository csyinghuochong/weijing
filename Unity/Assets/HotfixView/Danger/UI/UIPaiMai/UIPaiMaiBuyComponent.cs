using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
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
        public GameObject Btn_UpPage;
        public GameObject Text_PageShow;
        public GameObject ShowPage;

        public List<UIPaiMaiBuyItemComponent> PaiMaiList = new List<UIPaiMaiBuyItemComponent>();
        public UITypeViewComponent UITypeViewComponent;
        public int PageIndex = 1;
        public int NowTypeid;
        public int NowServerNum;
        public Dictionary<int, ItemConfig> allitemCof;

        //当前用到的显示用的
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

        //有页数的缓存
        public Dictionary<int, List<PaiMaiItemInfo>> PaiMaiItemInfosAll_Consume = new Dictionary<int, List<PaiMaiItemInfo>>();
        public Dictionary<int, List<PaiMaiItemInfo>> PaiMaiItemInfosAll_Material = new Dictionary<int, List<PaiMaiItemInfo>>();
        public Dictionary<int, List<PaiMaiItemInfo>> PaiMaiItemInfosAll_Equipment = new Dictionary<int, List<PaiMaiItemInfo>>();
        public Dictionary<int, List<PaiMaiItemInfo>> PaiMaiItemInfosAll_Gemstone = new Dictionary<int, List<PaiMaiItemInfo>>();

        //记录
        public int Next_Consume = 0;
        public int Next_Material = 0;
        public int Next_Equipment = 0;
        public int Next_Gemstone = 0;

        public int ShowNum_Consume = 1;
        public int ShowNum_Material = 1;
        public int ShowNum_Equipment = 1;
        public int ShowNum_Gemstone = 1;
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
            self.UITypeViewComponent.ClickTypeItemHandler = (int typeid, int subtypeid) => { self.OnClickTypeItem(typeid, subtypeid).Coroutine(); };

            self.UITypeViewComponent.TypeButtonInfos = self.InitTypeButtonInfos();
            self.UITypeViewComponent.OnInitUI().Coroutine();

            self.Btn_Search = rc.Get<GameObject>("Btn_Search");
            self.Btn_Search.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn_Search(); });

            self.Btn_Refresh = rc.Get<GameObject>("Btn_Refresh");
            self.Btn_Refresh.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn_Next().Coroutine(); });

            self.Btn_UpPage = rc.Get<GameObject>("Btn_UpPage");
            self.Btn_UpPage.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn_UpPage().Coroutine(); });

            self.InputField = rc.Get<GameObject>("InputField");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.Text_PageShow = rc.Get<GameObject>("Text_PageShow");
            self.ShowPage = rc.Get<GameObject>("ShowPage");

            self.PaiMaiList.Clear();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            //初始化数据显示
            //self.PaiMaiBuyInit(1).Coroutine();
            //展示列表数据
            //self.InitShow().Coroutine();
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

        public static async ETTask OnClickTypeItem(this UIPaiMaiBuyComponent self, int typeid, int subtypeid)
        {

            //Debug.Log("点击OnClickTypeItem...." + typeid + " subtypeid:" + subtypeid);
            self.OnClearnNowList();

            //重置页数
            if (self.NowTypeid != typeid) {
                self.PageIndex = 1;
                //初始化数量
                self.ShowNum_Consume = 1;
                self.ShowNum_Material = 1;
                self.ShowNum_Equipment = 1;
                self.ShowNum_Gemstone = 1;
            }

            //是否子页,子页不显示下一页按钮
            switch (typeid)
            {
                case 1:
                    if (self.PaiMaiItemInfos_Consume.Count>0) 
                    {
                        //self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Consume;
                        if (self.PaiMaiItemInfosAll_Consume.ContainsKey(self.PageIndex) && subtypeid == 0)
                        {
                            self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Consume[self.PageIndex];
                        }
                        else
                        {
                            if (subtypeid != 0)
                            {
                                self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Consume;
                            }
                        }
                    }
                    break;

                case 2:
                    if (self.PaiMaiItemInfos_Material.Count > 0)
                    {
                        //self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Material;
                        if (self.PaiMaiItemInfosAll_Material.ContainsKey(self.PageIndex) && subtypeid == 0)
                        {
                            self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Material[self.PageIndex];
                        }
                        else {
                            if (subtypeid != 0)
                            {
                                self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Material;
                            }
                        }
                    }
                    break;

                case 3:
                    if (self.PaiMaiItemInfos_Equipment.Count > 0)
                    {
                        //self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Equipment;
                        if (self.PaiMaiItemInfosAll_Equipment.ContainsKey(self.PageIndex) && subtypeid == 0)
                        {
                            self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Equipment[self.PageIndex];
                        }
                        else
                        {
                            if (subtypeid != 0)
                            {
                                self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Equipment;
                            }
                        }
                    }
                    break;

                case 4:
                    if (self.PaiMaiItemInfos_Gemstone.Count > 0)
                    {
                        //self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Gemstone;
                        if (self.PaiMaiItemInfosAll_Gemstone.ContainsKey(self.PageIndex) && subtypeid == 0)
                        {
                            self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Gemstone[self.PageIndex];
                        }
                        else
                        {
                            if (subtypeid != 0)
                            {
                                self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Gemstone;
                            }
                        }
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

            //Debug.Log("self.PaiMaiIteminfos_Now.Count...." + self.PaiMaiIteminfos_Now.Count + ";self.PaiMaiList = " + self.PaiMaiList.Count);

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

            //显示下一页
            switch (typeid)
            {
                case 1:

                    if (self.Next_Consume == 0 && subtypeid == 0)
                    {
                        self.ShowPage.SetActive(true);
                        self.Btn_Refresh.SetActive(true);
                    }
                    else
                    {
                        //self.Btn_Refresh.SetActive(false);
                        if (subtypeid != 0)
                        {
                            self.ShowPage.SetActive(false);
                        }
                    }
                    break;

                case 2:

                    if (self.Next_Material == 0 && subtypeid == 0)
                    {
                        self.ShowPage.SetActive(true);
                        self.Btn_Refresh.SetActive(true);
                    }
                    else
                    {
                        //self.Btn_Refresh.SetActive(false);
                        if (subtypeid != 0)
                        {
                            self.ShowPage.SetActive(false);
                        }
                    }
                    break;

                case 3:

                    if (self.Next_Equipment == 0 && subtypeid == 0)
                    {
                        self.ShowPage.SetActive(true);
                        self.Btn_Refresh.SetActive(true);
                    }
                    else
                    {
                        //self.Btn_Refresh.SetActive(false);
                        if (subtypeid != 0)
                        {
                            self.ShowPage.SetActive(false);
                        }
                    }
                    break;

                case 4:

                    if (self.Next_Gemstone == 0 && subtypeid == 0)
                    {
                        self.ShowPage.SetActive(true);
                        self.Btn_Refresh.SetActive(true);
                    }
                    else
                    {
                        //self.Btn_Refresh.SetActive(false);
                        if (subtypeid != 0)
                        {
                            self.ShowPage.SetActive(false);
                        }
                    }
                    break;
            }

            self.NowTypeid = typeid;
            //显示当前页数
            self.Text_PageShow.GetComponent<Text>().text = self.PageIndex.ToString();
        }

        public static void OnUpdateUI(this UIPaiMaiBuyComponent self)
        {
            //Debug.Log("OnUpdateUI...");
            //self.PageIndex = 1;
            //self.RequestAllPaiMaiList().Coroutine();
        }

        //上一页
        public static async ETTask OnClickBtn_UpPage(this UIPaiMaiBuyComponent self) 
        {
            await ETTask.CompletedTask;
            if (self.PageIndex <= 1)
            {
                return;
            }

            switch (self.NowTypeid)
            {
                case 1:
                    self.ShowNum_Consume = self.ShowNum_Consume - 1;
                    /*
                    if (self.ShowNum_Consume < 1)
                    {
                        self.ShowNum_Consume = 1;
                    }
                    */
                    self.PageIndex = self.ShowNum_Consume;

                    if (self.PaiMaiItemInfosAll_Consume.ContainsKey(self.PageIndex)) 
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Consume[self.PageIndex];
                    }
                    break;

                case 2:
                    self.ShowNum_Material = self.ShowNum_Material - 1;
                    self.PageIndex = self.ShowNum_Material;
                    if (self.PaiMaiItemInfosAll_Material.ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Material[self.PageIndex];
                    }
                    break;

                case 3:
                    self.ShowNum_Equipment = self.ShowNum_Equipment - 1;
                    self.PageIndex = self.ShowNum_Equipment;
                    if (self.PaiMaiItemInfosAll_Equipment.ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Equipment[self.PageIndex];
                    }
                    break;

                case 4:
                    self.ShowNum_Material = self.ShowNum_Material - 1;
                    self.PageIndex = self.ShowNum_Material;
                    if (self.PaiMaiItemInfosAll_Material.ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Material[self.PageIndex];
                    }
                    break;
            }

            if (self.PageIndex < 1) {
                self.PageIndex = 1;
            }

            //显示页数
            self.Text_PageShow.GetComponent<Text>().text = self.PageIndex.ToString();

            //显示列表
            self.OnClickTypeItem(self.NowTypeid, 0).Coroutine();

        }

        //清理
        public static void OnClearnNowList(this UIPaiMaiBuyComponent self) {

            //浅拷贝清理  直接clear 会有吧dic里的值清理
            List<PaiMaiItemInfo> aaa = new List<PaiMaiItemInfo>();
            //self.CopyList(self.PaiMaiIteminfos_Now, aaa);
            self.PaiMaiIteminfos_Now = aaa;
            self.PaiMaiIteminfos_Now.Clear();

        }

        //下一页
        public static async ETTask OnClickBtn_Next(this UIPaiMaiBuyComponent self)
        {
            if (self.PageIndex < 1)
            {
                return;
            }

            //页数到底不进行任何操作
            switch (self.NowTypeid) {
                case 1:
                    if (self.PageIndex>=self.PaiMaiItemInfosAll_Consume.Count && self.Next_Consume == 1) 
                    {
                        FloatTipManager.Instance.ShowFloatTipDi("已达最后一页");
                        return;
                    }
                    break;

                case 2:
                    if (self.PageIndex >= self.PaiMaiItemInfosAll_Material.Count && self.Next_Material == 1)
                    {
                        FloatTipManager.Instance.ShowFloatTipDi("已达最后一页");
                        return;
                    }
                    break;

                case 3:
                    if (self.PageIndex >= self.PaiMaiItemInfosAll_Equipment.Count && self.Next_Equipment == 1)
                    {
                        FloatTipManager.Instance.ShowFloatTipDi("已达最后一页");
                        return;
                    }
                    break;

                case 4:
                    if (self.PageIndex >= self.PaiMaiItemInfosAll_Gemstone.Count && self.Next_Gemstone == 1)
                    {
                        FloatTipManager.Instance.ShowFloatTipDi("已达最后一页");
                        return;
                    }
                    break;
            }

            //浅拷贝清理  直接clear 会有吧dic里的值清理
            self.OnClearnNowList();

            switch (self.NowTypeid) {
                
                case 1:
                    self.ShowNum_Consume = self.ShowNum_Consume + 1;
                    self.PageIndex = self.ShowNum_Consume;
 
                    if (self.PaiMaiItemInfosAll_Consume.ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Consume[self.PageIndex];
                    }
                    break;

                case 2:
                    self.ShowNum_Material = self.ShowNum_Material + 1;
                    self.PageIndex = self.ShowNum_Material;
                    if (self.PaiMaiItemInfosAll_Material.ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Material[self.PageIndex];
                    }
                    break;

                case 3:
                    self.ShowNum_Equipment = self.ShowNum_Equipment + 1;
                    self.PageIndex = self.ShowNum_Equipment;
                    if (self.PaiMaiItemInfosAll_Equipment.ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Equipment[self.PageIndex];
                    }
                    break;

                case 4:
                    self.ShowNum_Material = self.ShowNum_Material + 1;
                    self.PageIndex = self.ShowNum_Material;
                    if (self.PaiMaiItemInfosAll_Material.ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiIteminfos_Now = self.PaiMaiItemInfosAll_Material[self.PageIndex];
                    }
                    break;
            }

            if (self.PageIndex < 1)
            {
                self.PageIndex = 1;
            }

            //获取下一页数据
            if (self.PaiMaiIteminfos_Now.Count==0)
            {
                await self.PaiMaiBuyInit(self.NowTypeid);
            }

            //显示列表
            self.OnClickTypeItem(self.NowTypeid, 0).Coroutine();

            //显示页数
            self.Text_PageShow.GetComponent<Text>().text = self.PageIndex.ToString();

        }




        //查询按钮
        public static void OnClickBtn_Search(this UIPaiMaiBuyComponent self)
        {
            string text = self.InputField.GetComponent<InputField>().text;

            /*   直接在现有的预制件上控制隐藏和显示的处理方法,此方法快,但是显示数据不全
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
            */

            //浅拷贝清理  直接clear 会有吧dic里的值清理
            self.OnClearnNowList();

            //每次点击进行清理
            if (self.ItemListNode != null)
            {
                FunctionUI.GetInstance().DestoryTargetObj(self.ItemListNode);
            }


            //获取ID
            int findItemID = 0;
            int findType = 0;
            if (self.allitemCof == null) {
                self.allitemCof = ItemConfigCategory.Instance.GetAll();
            }
            foreach (int id in self.allitemCof.Keys) {
                if (self.allitemCof[id].ItemName == text) {
                    findItemID = self.allitemCof[id].Id;
                    findType = self.allitemCof[id].ItemType;
                    if (findType == 5) {
                        findType = 2;
                    }
                    break;
                }
            }

            if (findItemID == 0) {
                return;
            }


            switch (findType) {
                case 1:
                    foreach (PaiMaiItemInfo info in self.PaiMaiItemInfos_Consume)
                    {
                        if (info.BagInfo.ItemID == findItemID)
                        {
                            self.PaiMaiIteminfos_Now.Add(info);
                        }
                    }
                    break;

                case 2:
                    foreach (PaiMaiItemInfo info in self.PaiMaiItemInfos_Material)
                    {
                        if (info.BagInfo.ItemID == findItemID)
                        {
                            self.PaiMaiIteminfos_Now.Add(info);
                        }
                    }
                    break;

                case 3:
                    foreach (PaiMaiItemInfo info in self.PaiMaiItemInfos_Equipment)
                    {
                        if (info.BagInfo.ItemID == findItemID)
                        {
                            self.PaiMaiIteminfos_Now.Add(info);
                        }
                    }
                    break;

                case 4:
                    foreach (PaiMaiItemInfo info in self.PaiMaiItemInfos_Gemstone)
                    {
                        if (info.BagInfo.ItemID == findItemID)
                        {
                            self.PaiMaiIteminfos_Now.Add(info);
                        }
                    }
                    break;
            }

            if (self.PaiMaiIteminfos_Now.Count > 0)
            {
                //展示列表数据
                self.ShowPaiMaiList().Coroutine();
            }
            else {
                FloatTipManager.Instance.ShowFloatTipDi("未找到对应拍卖行道具");
            }
        }

        public static async ETTask InitShow(this UIPaiMaiBuyComponent self) {

            //初始化数据显示
            await self.PaiMaiBuyInit(1);
            //展示列表数据
            self.OnClickTypeItem(1,0).Coroutine();

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

            switch (showType) {

                case 1:
                    if (m2C_PaiMaiBuyResponse.Message == "1")
                    {
                        self.Next_Consume = 1;
                    }

                    if (self.PaiMaiItemInfosAll_Consume.ContainsKey(m2C_PaiMaiBuyResponse.NextPage) == false)
                    {
                        self.PaiMaiItemInfosAll_Consume.Add(m2C_PaiMaiBuyResponse.NextPage, m2C_PaiMaiBuyResponse.PaiMaiItemInfos);
                        self.PaiMaiItemInfos_Consume.AddRange(m2C_PaiMaiBuyResponse.PaiMaiItemInfos);
                        self.ShowNum_Consume = m2C_PaiMaiBuyResponse.NextPage;
                    }
                    break;

                case 2:
                    if (m2C_PaiMaiBuyResponse.Message == "1")
                    {
                        self.Next_Material = 1;
                    }

                    if (self.PaiMaiItemInfosAll_Material.ContainsKey(m2C_PaiMaiBuyResponse.NextPage) == false)
                    {
                        self.PaiMaiItemInfosAll_Material.Add(m2C_PaiMaiBuyResponse.NextPage, m2C_PaiMaiBuyResponse.PaiMaiItemInfos);
                        self.PaiMaiItemInfos_Material.AddRange(m2C_PaiMaiBuyResponse.PaiMaiItemInfos);
                        self.ShowNum_Material = m2C_PaiMaiBuyResponse.NextPage;
                    }
                    break;

                case 3:
                    if (m2C_PaiMaiBuyResponse.Message == "1")
                    {
                        self.Next_Equipment = 1;
                    }

                    if (self.PaiMaiItemInfosAll_Equipment.ContainsKey(m2C_PaiMaiBuyResponse.NextPage) == false)
                    {
                        self.PaiMaiItemInfosAll_Equipment.Add(m2C_PaiMaiBuyResponse.NextPage, m2C_PaiMaiBuyResponse.PaiMaiItemInfos);
                        self.PaiMaiItemInfos_Equipment.AddRange(m2C_PaiMaiBuyResponse.PaiMaiItemInfos);
                        self.ShowNum_Equipment = m2C_PaiMaiBuyResponse.NextPage;
                    }
                    break;

                case 4:
                    if (m2C_PaiMaiBuyResponse.Message == "1")
                    {
                        self.Next_Gemstone = 1;
                    }

                    if (self.PaiMaiItemInfosAll_Gemstone.ContainsKey(m2C_PaiMaiBuyResponse.NextPage) == false)
                    {
                        self.PaiMaiItemInfosAll_Gemstone.Add(m2C_PaiMaiBuyResponse.NextPage, m2C_PaiMaiBuyResponse.PaiMaiItemInfos);
                        self.PaiMaiItemInfos_Gemstone.AddRange(m2C_PaiMaiBuyResponse.PaiMaiItemInfos);
                        self.ShowNum_Gemstone = m2C_PaiMaiBuyResponse.NextPage;
                    }
                    break;

            }

            //self.NowServerNum = m2C_PaiMaiBuyResponse.NextPage;

            if (m2C_PaiMaiBuyResponse.Error == ErrorCode.ERR_Success) {
                //self.PaiMaiItemInfos_Consume = m2C_PaiMaiBuyResponse.PaiMaiItemInfos;
                //赋值当前显示
                //self.PaiMaiIteminfos_Now = self.PaiMaiItemInfos_Consume;
                self.PaiMaiIteminfos_Now = m2C_PaiMaiBuyResponse.PaiMaiItemInfos;
                //self.CopyList(m2C_PaiMaiBuyResponse.PaiMaiItemInfos, self.PaiMaiIteminfos_Now);
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

        public static void Copy(this UIPaiMaiBuyComponent self, Dictionary<int, List<PaiMaiItemInfo>> alldiclist , List<PaiMaiItemInfo> list,int addKey) {

            List<PaiMaiItemInfo> addlist = new List<PaiMaiItemInfo>();
            foreach (PaiMaiItemInfo paimaiinfo in list) {



                //addlist.Add(ComHelp.DeepCopy<PaiMaiItemInfo>(paimaiinfo));
                //addlist.Add(UIPaiMaiBuyComponentSystem.Clone<PaiMaiItemInfo>(paimaiinfo));
                addlist.Add(ComHelp.DeepCopy<PaiMaiItemInfo>(paimaiinfo));
            }
            ;
            //增加addkey
            if (alldiclist.ContainsKey(addKey)==false) {
                alldiclist.Add(addKey,addlist);
            }
            
        }

        /*
        public static T Clone<T>(T RealObject)
        {
            using (Stream objectStream = new MemoryStream())
            {
                //利用 System.Runtime.Serialization序列化与反序列化完成引用对象的复制 
                IFormatter formatter = new BinaryFormatter(); formatter.Serialize(objectStream, RealObject);
                objectStream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(objectStream);
            }
        }
        */
        public static void CopyList(this UIPaiMaiBuyComponent self, List<PaiMaiItemInfo> list, List<PaiMaiItemInfo> Copylist)
        {
            //Copylist = new List<PaiMaiItemInfo>();
            //List<PaiMaiItemInfo> addlist = new List<PaiMaiItemInfo>();
            foreach (PaiMaiItemInfo paimaiinfo in list)
            {
                Debug.Log("id:" + paimaiinfo.Id);
                Copylist.Add(ComHelp.DeepCopy<PaiMaiItemInfo>(paimaiinfo));
            }

        }



        public static object Clone(this UIPaiMaiBuyComponent self, List<PaiMaiItemInfo> obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(memoryStream, obj);
            memoryStream.Position = 0;
            return formatter.Deserialize(memoryStream);
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


        //下一页  废弃
        public static void OnClickBtn_Refresh(this UIPaiMaiBuyComponent self)
        {
            //Debug.Log("OnClickBtn_Refresh...");
            self.PageIndex++;
            self.RequestAllPaiMaiList().Coroutine();
        }
    }
}
