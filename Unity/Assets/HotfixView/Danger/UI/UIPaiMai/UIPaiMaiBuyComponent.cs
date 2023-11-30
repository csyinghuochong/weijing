using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiBuyComponent: Entity, IAwake
    {
        public GameObject NextPageBtn;
        public GameObject TypeListNode;
        public GameObject Btn_Search;
        public GameObject InputField;
        public GameObject ItemListNode;
        public GameObject UIPaiMaiBuyItem;
        public GameObject PrePageBtn;
        public GameObject Text_PageShow;
        public GameObject ShowPage;

        public List<UIPaiMaiBuyItemComponent> PaiMaiList = new List<UIPaiMaiBuyItemComponent>();
        public UITypeViewComponent UITypeViewComponent;
        public int PageIndex = 1;
        public int ItemType;
        public int ItemSubType;

        //当前用到的显示用的
        public List<PaiMaiItemInfo> PaiMaiIteminfos_Now = new List<PaiMaiItemInfo>();

        //-----------拍卖行缓存---------- <ItemSubType,<Page , [PaiMaiItemInfo,PaiMaiItemInfo,···]>>  ItemSubType==0表示该大类
        public Dictionary<int, Dictionary<int, List<PaiMaiItemInfo>>> PaiMaiItemInfos_Consume =
                new Dictionary<int, Dictionary<int, List<PaiMaiItemInfo>>>();

        public Dictionary<int, Dictionary<int, List<PaiMaiItemInfo>>> PaiMaiItemInfos_Material =
                new Dictionary<int, Dictionary<int, List<PaiMaiItemInfo>>>();

        public Dictionary<int, Dictionary<int, List<PaiMaiItemInfo>>> PaiMaiItemInfos_Equipment =
                new Dictionary<int, Dictionary<int, List<PaiMaiItemInfo>>>();

        public Dictionary<int, Dictionary<int, List<PaiMaiItemInfo>>> PaiMaiItemInfos_Gemstone =
                new Dictionary<int, Dictionary<int, List<PaiMaiItemInfo>>>();

        //记录下一页index
        public Dictionary<int, int> MaxPage_Consume = new Dictionary<int, int>();
        public Dictionary<int, int> MaxPage_Material = new Dictionary<int, int>();
        public Dictionary<int, int> MaxPage_Equipment = new Dictionary<int, int>();
        public Dictionary<int, int> MaxPage_Gemstone = new Dictionary<int, int>();
    }

    public class UIPaiMaiBuyComponentAwakeSystem: AwakeSystem<UIPaiMaiBuyComponent>
    {
        public override void Awake(UIPaiMaiBuyComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.InputField = rc.Get<GameObject>("InputField");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.UIPaiMaiBuyItem = rc.Get<GameObject>("UIPaiMaiBuyItem");
            self.UIPaiMaiBuyItem.SetActive(false);
            self.Text_PageShow = rc.Get<GameObject>("Text_PageShow");
            self.ShowPage = rc.Get<GameObject>("ShowPage");

            self.TypeListNode = rc.Get<GameObject>("TypeListNode");
            self.UITypeViewComponent = self.AddChild<UITypeViewComponent, GameObject>(self.TypeListNode);
            self.UITypeViewComponent.TypeButtonItemAsset = ABPathHelper.GetUGUIPath("Main/Common/UITypeItem");
            self.UITypeViewComponent.TypeButtonAsset = ABPathHelper.GetUGUIPath("Main/Common/UITypeButton");
            self.UITypeViewComponent.ClickTypeItemHandler = (itemType, itemSubType) => { self.OnClickTypeItem(itemType, itemSubType).Coroutine(); };

            self.UITypeViewComponent.TypeButtonInfos = self.InitTypeButtonInfos();
            self.UITypeViewComponent.OnInitUI().Coroutine();

            self.Btn_Search = rc.Get<GameObject>("Btn_Search");
            self.Btn_Search.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn_Search(); });

            self.NextPageBtn = rc.Get<GameObject>("NextPageBtn");
            self.NextPageBtn.GetComponent<Button>().onClick.AddListener(self.OnNextPageBtn);

            self.PrePageBtn = rc.Get<GameObject>("PrePageBtn");
            self.PrePageBtn.GetComponent<Button>().onClick.AddListener(self.OnPrePageBtn);
        }
    }

    public static class UIPaiMaiBuyComponentSystem
    {
        /// <summary>
        /// 定位对应的切页和某个道具所在的位置
        /// </summary>
        /// <param name="self"></param>
        /// <param name="itemType"></param>
        /// <param name="paimaiItemId"></param>
        public static async ETTask OnClickGoToPaiMai(this UIPaiMaiBuyComponent self, int itemType, long paimaiItemId)
        {
            if (itemType != 1)
            {
                foreach (var value in self.UITypeViewComponent.TypeButtonComponents)
                {
                    if (value.TypeId == itemType)
                    {
                        value.OnClickTypeButton();
                        break;
                    }
                }
            }

            long instanceid = self.InstanceId;

            C2P_PaiMaiFindRequest reuqest = new C2P_PaiMaiFindRequest() { PaiMaiItemInfoId = paimaiItemId };
            P2C_PaiMaiFindResponse response = (P2C_PaiMaiFindResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(reuqest);
            if (response.Page == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("道具已经被买走了!");
                return;
            }

            if (self.InstanceId != instanceid)
            {
                return;
            }

            await self.OnClickTypeItem(itemType, 0, response.Page);

            await TimerComponent.Instance.WaitAsync(500);

            // 移动到指定位置
            for (int i = 0; i < self.PaiMaiIteminfos_Now.Count; i++)
            {
                if (self.PaiMaiIteminfos_Now[i].Id == paimaiItemId)
                {
                    self.ItemListNode.GetComponent<RectTransform>().localPosition = new Vector3(0, i * 124f, 0);
                    break;
                }
            }
        }

        /// <summary>
        /// 初始化切页
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 移除拍卖物品数据(本地)
        /// </summary>
        /// <param name="self"></param>
        /// <param name="type"></param>
        /// <param name="paiMaiItemInfo"></param>
        public static void RemoveItem(this UIPaiMaiBuyComponent self, int type, PaiMaiItemInfo paiMaiItemInfo)
        {
            long infoId = paiMaiItemInfo.Id;
            switch (type)
            {
                case 1:
                    foreach (Dictionary<int, List<PaiMaiItemInfo>> dictionary in self.PaiMaiItemInfos_Consume.Values)
                    {
                        foreach (List<PaiMaiItemInfo> paiMaiItemInfos in dictionary.Values)
                        {
                            foreach (PaiMaiItemInfo info in paiMaiItemInfos)
                            {
                                if (info.Id == infoId)
                                {
                                    paiMaiItemInfos.Remove(info);
                                    break;
                                }
                            }
                        }
                    }

                    break;
                case 2:
                    foreach (Dictionary<int, List<PaiMaiItemInfo>> dictionary in self.PaiMaiItemInfos_Material.Values)
                    {
                        foreach (List<PaiMaiItemInfo> paiMaiItemInfos in dictionary.Values)
                        {
                            foreach (PaiMaiItemInfo info in paiMaiItemInfos)
                            {
                                if (info.Id == infoId)
                                {
                                    paiMaiItemInfos.Remove(info);
                                    break;
                                }
                            }
                        }
                    }

                    break;
                case 3:
                    foreach (Dictionary<int, List<PaiMaiItemInfo>> dictionary in self.PaiMaiItemInfos_Equipment.Values)
                    {
                        foreach (List<PaiMaiItemInfo> paiMaiItemInfos in dictionary.Values)
                        {
                            foreach (PaiMaiItemInfo info in paiMaiItemInfos)
                            {
                                if (info.Id == infoId)
                                {
                                    paiMaiItemInfos.Remove(info);
                                    break;
                                }
                            }
                        }
                    }

                    break;
                case 4:
                    foreach (Dictionary<int, List<PaiMaiItemInfo>> dictionary in self.PaiMaiItemInfos_Equipment.Values)
                    {
                        foreach (List<PaiMaiItemInfo> paiMaiItemInfos in dictionary.Values)
                        {
                            foreach (PaiMaiItemInfo info in paiMaiItemInfos)
                            {
                                if (info.Id == infoId)
                                {
                                    paiMaiItemInfos.Remove(info);
                                    break;
                                }
                            }
                        }
                    }

                    break;
            }
        }

        /// <summary>
        /// 点击切页
        /// </summary>
        /// <param name="self"></param>
        /// <param name="itemType"></param>
        /// <param name="itemSubType"></param>
        /// <param name="page"></param>
        public static async ETTask OnClickTypeItem(this UIPaiMaiBuyComponent self, int itemType, int itemSubType, int page = 1)
        {
            Log.Debug($"-------点击切页 ItemType:{itemType} ItemSubType:{itemSubType} Page:{page}--------");
            self.PaiMaiIteminfos_Now.Clear();

            self.ItemType = itemType;
            self.ItemSubType = itemSubType;
            self.PageIndex = page;

            // 先尝试从缓存获取
            self.PaiMaiIteminfos_Now.AddRange(self.GetInfoLocal(self.ItemType, self.ItemSubType));

            if (self.PaiMaiIteminfos_Now == null || self.PaiMaiIteminfos_Now.Count <= 0)
            {
                // 从服务端获取
                await self.UpdatePaiMaiData(itemType, itemSubType);
                self.PaiMaiIteminfos_Now.AddRange(self.GetInfoLocal(self.ItemType, self.ItemSubType));
            }

            // 展示拍卖物品
            self.ShowPaiMaiList();

            self.Text_PageShow.GetComponent<Text>().text = self.PageIndex.ToString();
        }

        /// <summary>
        /// 从本地缓存获取数据
        /// </summary>
        /// <param name="self"></param>
        /// <param name="itemType"></param>
        /// <param name="itemSubType"></param>
        /// <returns></returns>
        public static List<PaiMaiItemInfo> GetInfoLocal(this UIPaiMaiBuyComponent self, int itemType, int itemSubType)
        {
            switch (itemType)
            {
                case 1:
                    if (!self.PaiMaiItemInfos_Consume.ContainsKey(itemSubType))
                    {
                        self.PaiMaiItemInfos_Consume.Add(itemSubType, new Dictionary<int, List<PaiMaiItemInfo>>());
                    }

                    if (!self.PaiMaiItemInfos_Consume[itemSubType].ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiItemInfos_Consume[itemSubType].Add(self.PageIndex, new List<PaiMaiItemInfo>());
                    }

                    return self.PaiMaiItemInfos_Consume[itemSubType][self.PageIndex];



                case 2:
                    if (!self.PaiMaiItemInfos_Material.ContainsKey(itemSubType))
                    {
                        self.PaiMaiItemInfos_Material.Add(itemSubType, new Dictionary<int, List<PaiMaiItemInfo>>());
                    }

                    if (!self.PaiMaiItemInfos_Material[itemSubType].ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiItemInfos_Material[itemSubType].Add(self.PageIndex, new List<PaiMaiItemInfo>());
                    }

                    return self.PaiMaiItemInfos_Material[itemSubType][self.PageIndex];


                case 3:

                    if (!self.PaiMaiItemInfos_Equipment.ContainsKey(itemSubType))
                    {
                        self.PaiMaiItemInfos_Equipment.Add(itemSubType, new Dictionary<int, List<PaiMaiItemInfo>>());
                    }

                    if (!self.PaiMaiItemInfos_Equipment[itemSubType].ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiItemInfos_Equipment[itemSubType].Add(self.PageIndex, new List<PaiMaiItemInfo>());
                    }

                    return self.PaiMaiItemInfos_Equipment[itemSubType][self.PageIndex];



                case 4:

                    if (!self.PaiMaiItemInfos_Gemstone.ContainsKey(itemSubType))
                    {
                        self.PaiMaiItemInfos_Gemstone.Add(itemSubType, new Dictionary<int, List<PaiMaiItemInfo>>());
                    }

                    if (!self.PaiMaiItemInfos_Gemstone[itemSubType].ContainsKey(self.PageIndex))
                    {
                        self.PaiMaiItemInfos_Gemstone[itemSubType].Add(self.PageIndex, new List<PaiMaiItemInfo>());
                    }

                    return self.PaiMaiItemInfos_Gemstone[itemSubType][self.PageIndex];
            }

            return null;
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="self"></param>
        public static void OnPrePageBtn(this UIPaiMaiBuyComponent self)
        {
            if (self.PageIndex <= 1)
            {
                return;
            }

            self.PageIndex -= 1;
            self.OnClickTypeItem(self.ItemType, self.ItemSubType, self.PageIndex).Coroutine();
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="self"></param>
        public static void OnNextPageBtn(this UIPaiMaiBuyComponent self)
        {
            switch (self.ItemType)
            {
                case 1:
                    if (self.PageIndex >= self.MaxPage_Consume[self.ItemSubType])
                    {
                        FloatTipManager.Instance.ShowFloatTipDi("已达最后一页");
                        return;
                    }

                    break;

                case 2:
                    if (self.PageIndex >= self.MaxPage_Material[self.ItemSubType])
                    {
                        FloatTipManager.Instance.ShowFloatTipDi("已达最后一页");
                        return;
                    }

                    break;

                case 3:
                    if (self.PageIndex >= self.MaxPage_Equipment[self.ItemSubType])
                    {
                        FloatTipManager.Instance.ShowFloatTipDi("已达最后一页");
                        return;
                    }

                    break;

                case 4:
                    if (self.PageIndex >= self.MaxPage_Gemstone[self.ItemSubType])
                    {
                        FloatTipManager.Instance.ShowFloatTipDi("已达最后一页");
                        return;
                    }

                    break;
            }

            self.PageIndex += 1;
            self.OnClickTypeItem(self.ItemType, self.ItemSubType, self.PageIndex).Coroutine();
        }

        /// <summary>
        /// 查询按钮(目前只是从本地缓存中查找 findPaiMaiType 0模糊查找 1精准查找)
        /// </summary>
        /// <param name="self"></param>
        /// <param name="findPaiMaiType"></param>
        public static void OnClickBtn_Search(this UIPaiMaiBuyComponent self, int findPaiMaiType = 0)
        {
            string text = self.InputField.GetComponent<InputField>().text;

            //获取ID
            int findItemID = 0;
            int findType = 0;

            List<int> findItemIDLiSt = new List<int>();
            List<int> findTypeList = new List<int>();

            //模糊查找
            if (findPaiMaiType == 0)
            {
                foreach (ItemConfig itemConfig in ItemConfigCategory.Instance.GetAll().Values)
                {
                    if (itemConfig.ItemName.Contains(text))
                    {
                        if (!findItemIDLiSt.Contains(itemConfig.Id))
                        {
                            findItemIDLiSt.Add(itemConfig.Id);
                        }

                        if (!findTypeList.Contains(itemConfig.ItemType))
                        {
                            findTypeList.Add(itemConfig.ItemType);
                        }
                    }
                }
            }
            else if (findPaiMaiType == 1) //精准查找
            {
                foreach (ItemConfig itemConfig in ItemConfigCategory.Instance.GetAll().Values)
                {
                    if (itemConfig.ItemName == text)
                    {
                        findItemID = itemConfig.Id;
                        findType = itemConfig.ItemType;
                        if (findType == 5)
                        {
                            findType = 2;
                        }

                        break;
                    }
                }
            }

            //精准查找为空直接返回
            if (findItemID == 0 && findPaiMaiType == 1)
            {
                return;
            }

            self.PaiMaiIteminfos_Now.Clear();
            if (findPaiMaiType == 0)
            {
                for (int i = 0; i < findTypeList.Count; i++)
                {
                    switch (findTypeList[i])
                    {
                        case 1:
                            foreach (List<PaiMaiItemInfo> paiMaiItemInfos in self.PaiMaiItemInfos_Consume[0].Values)
                            {
                                foreach (PaiMaiItemInfo paiMaiItemInfo in paiMaiItemInfos)
                                {
                                    if (findItemIDLiSt.Contains(paiMaiItemInfo.BagInfo.ItemID))
                                    {
                                        self.PaiMaiIteminfos_Now.Add(paiMaiItemInfo);
                                    }
                                }
                            }

                            break;

                        case 2:
                            foreach (List<PaiMaiItemInfo> paiMaiItemInfos in self.PaiMaiItemInfos_Material[0].Values)
                            {
                                foreach (PaiMaiItemInfo paiMaiItemInfo in paiMaiItemInfos)
                                {
                                    if (findItemIDLiSt.Contains(paiMaiItemInfo.BagInfo.ItemID))
                                    {
                                        self.PaiMaiIteminfos_Now.Add(paiMaiItemInfo);
                                    }
                                }
                            }

                            break;

                        case 3:
                            foreach (List<PaiMaiItemInfo> paiMaiItemInfos in self.PaiMaiItemInfos_Equipment[0].Values)
                            {
                                foreach (PaiMaiItemInfo paiMaiItemInfo in paiMaiItemInfos)
                                {
                                    if (findItemIDLiSt.Contains(paiMaiItemInfo.BagInfo.ItemID))
                                    {
                                        self.PaiMaiIteminfos_Now.Add(paiMaiItemInfo);
                                    }
                                }
                            }

                            break;

                        case 4:
                            foreach (List<PaiMaiItemInfo> paiMaiItemInfos in self.PaiMaiItemInfos_Gemstone[0].Values)
                            {
                                foreach (PaiMaiItemInfo paiMaiItemInfo in paiMaiItemInfos)
                                {
                                    if (findItemIDLiSt.Contains(paiMaiItemInfo.BagInfo.ItemID))
                                    {
                                        self.PaiMaiIteminfos_Now.Add(paiMaiItemInfo);
                                    }
                                }
                            }

                            break;
                    }
                }
            }
            else if (findPaiMaiType == 1) //精准查找
            {
                switch (findType)
                {
                    case 1:
                        foreach (List<PaiMaiItemInfo> paiMaiItemInfos in self.PaiMaiItemInfos_Consume[0].Values)
                        {
                            foreach (PaiMaiItemInfo paiMaiItemInfo in paiMaiItemInfos)
                            {
                                if (paiMaiItemInfo.BagInfo.ItemID == findItemID)
                                {
                                    self.PaiMaiIteminfos_Now.Add(paiMaiItemInfo);
                                }
                            }
                        }

                        break;

                    case 2:
                        foreach (List<PaiMaiItemInfo> paiMaiItemInfos in self.PaiMaiItemInfos_Material[0].Values)
                        {
                            foreach (PaiMaiItemInfo paiMaiItemInfo in paiMaiItemInfos)
                            {
                                if (paiMaiItemInfo.BagInfo.ItemID == findItemID)
                                {
                                    self.PaiMaiIteminfos_Now.Add(paiMaiItemInfo);
                                }
                            }
                        }

                        break;

                    case 3:
                        foreach (List<PaiMaiItemInfo> paiMaiItemInfos in self.PaiMaiItemInfos_Equipment[0].Values)
                        {
                            foreach (PaiMaiItemInfo paiMaiItemInfo in paiMaiItemInfos)
                            {
                                if (paiMaiItemInfo.BagInfo.ItemID == findItemID)
                                {
                                    self.PaiMaiIteminfos_Now.Add(paiMaiItemInfo);
                                }
                            }
                        }

                        break;

                    case 4:
                        foreach (List<PaiMaiItemInfo> paiMaiItemInfos in self.PaiMaiItemInfos_Gemstone[0].Values)
                        {
                            foreach (PaiMaiItemInfo paiMaiItemInfo in paiMaiItemInfos)
                            {
                                if (paiMaiItemInfo.BagInfo.ItemID == findItemID)
                                {
                                    self.PaiMaiIteminfos_Now.Add(paiMaiItemInfo);
                                }
                            }
                        }

                        break;
                }
            }

            self.ShowPaiMaiList();
            if (self.PaiMaiIteminfos_Now.Count <= 0)
            {
                FloatTipManager.Instance.ShowFloatTipDi("未找到对应拍卖行道具");
            }
        }

        /// <summary>
        /// 更新拍卖数据,同时更新self.PaiMaiIteminfos_Now(此作法会错过一些道具)
        /// </summary>
        /// <param name="self"></param>
        /// <param name="itemType"></param>
        /// <param name="itemSubType"></param>
        public static async ETTask UpdatePaiMaiData(this UIPaiMaiBuyComponent self, int itemType, int itemSubType)
        {
            long instanceId = self.InstanceId;

            C2P_PaiMaiListRequest c2M_PaiMaiBuyRequest = new C2P_PaiMaiListRequest()
            {
                Page = self.PageIndex, PaiMaiType = itemType, PaiMaiShowType = itemSubType, UserId = UnitHelper.GetMyUnitId(self.ZoneScene()),
            };
            P2C_PaiMaiListResponse m2C_PaiMaiBuyResponse =
                    (P2C_PaiMaiListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

            //因为是异步不加这里,消息来了玩家关闭界面会报错
            if (instanceId != self.InstanceId)
            {
                return;
            }

            switch (itemType)
            {
                case 1:
                    self.PaiMaiItemInfos_Consume[itemSubType][self.PageIndex].Clear();
                    self.PaiMaiItemInfos_Consume[itemSubType][self.PageIndex].AddRange(m2C_PaiMaiBuyResponse.PaiMaiItemInfos);

                    if (!self.MaxPage_Consume.ContainsKey(itemSubType))
                    {
                        self.MaxPage_Consume.Add(itemSubType, 1);
                    }

                    self.MaxPage_Consume[itemSubType] = m2C_PaiMaiBuyResponse.NextPage;

                    break;

                case 2:
                    self.PaiMaiItemInfos_Material[itemSubType][self.PageIndex].Clear();
                    self.PaiMaiItemInfos_Material[itemSubType][self.PageIndex].AddRange(m2C_PaiMaiBuyResponse.PaiMaiItemInfos);

                    if (!self.MaxPage_Material.ContainsKey(itemSubType))
                    {
                        self.MaxPage_Material.Add(itemSubType, 1);
                    }

                    self.MaxPage_Material[itemSubType] = m2C_PaiMaiBuyResponse.NextPage;

                    break;

                case 3:
                    self.PaiMaiItemInfos_Equipment[itemSubType][self.PageIndex].Clear();
                    self.PaiMaiItemInfos_Equipment[itemSubType][self.PageIndex].AddRange(m2C_PaiMaiBuyResponse.PaiMaiItemInfos);

                    if (!self.MaxPage_Equipment.ContainsKey(itemSubType))
                    {
                        self.MaxPage_Equipment.Add(itemSubType, 1);
                    }

                    self.MaxPage_Equipment[itemSubType] = m2C_PaiMaiBuyResponse.NextPage;

                    break;

                case 4:
                    self.PaiMaiItemInfos_Gemstone[itemSubType][self.PageIndex].Clear();
                    self.PaiMaiItemInfos_Gemstone[itemSubType][self.PageIndex].AddRange(m2C_PaiMaiBuyResponse.PaiMaiItemInfos);

                    if (!self.MaxPage_Gemstone.ContainsKey(itemSubType))
                    {
                        self.MaxPage_Gemstone.Add(itemSubType, 1);
                    }

                    self.MaxPage_Gemstone[itemSubType] = m2C_PaiMaiBuyResponse.NextPage;

                    break;
            }
        }

        /// <summary>
        /// 展示拍卖物品
        /// </summary>
        /// <param name="self"></param>
        public static void ShowPaiMaiList(this UIPaiMaiBuyComponent self)
        {
            int number = 0;
            for (int i = 0; i < self.PaiMaiIteminfos_Now.Count; i++)
            {
                PaiMaiItemInfo paiMaiItemInfo = self.PaiMaiIteminfos_Now[i];
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
                    GameObject go = GameObject.Instantiate(self.UIPaiMaiBuyItem);
                    go.SetActive(true);
                    UICommonHelper.SetParent(go, self.ItemListNode);
                    go.transform.localScale = Vector3.one * 1f;
                    uI = self.AddChild<UIPaiMaiBuyItemComponent, GameObject>(go);
                    self.PaiMaiList.Add(uI);
                }

                uI.OnUpdateItem(paiMaiItemInfo);
                number++;
            }

            for (int i = number; i < self.PaiMaiList.Count; i++)
            {
                self.PaiMaiList[i].GameObject.SetActive(false);
            }
        }
    }
}