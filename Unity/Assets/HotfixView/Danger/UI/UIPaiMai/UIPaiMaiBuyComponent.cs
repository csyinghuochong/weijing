using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{
    public class UIPaiMaiBuyComponent : Entity, IAwake
    {
        public GameObject TypeListNode;
        public GameObject Btn_Search;
        public GameObject InputField;
        public GameObject ItemListNode;

        public List<UI> PaiMaiList = new List<UI>();
        public UITypeViewComponent UITypeViewComponent;
    }

    [ObjectSystem]
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

            self.InputField = rc.Get<GameObject>("InputField");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.PaiMaiList.Clear();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
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
            foreach (int key in UIItemHelp.ItemSubType1Name.Keys) 
            {
                //typeButtonInfo.typeButtonItems.Add(new TypeButtonItem() { SubTypeId = 1, ItemName = name });
                typeButtonInfo.typeButtonItems.Add(new TypeButtonItem() { SubTypeId = key, ItemName = UIItemHelp.ItemSubType1Name[key] });
            }


            typeButtonInfo.TypeId = 1;
            //typeButtonInfo.typeButtonItems = new List<TypeButtonItem>();
            typeButtonInfo.TypeName = UIItemHelp.ItemTypeName[ItemTypeEnum.Consume];

            typeButtonInfos.Add(typeButtonInfo);

            typeButtonInfo = new TypeButtonInfo();
            foreach (int key in UIItemHelp.ItemSubType2Name.Keys)
            {
                //typeButtonInfo.typeButtonItems.Add(new TypeButtonItem() { SubTypeId = 2, ItemName = name });
                typeButtonInfo.typeButtonItems.Add(new TypeButtonItem() { SubTypeId = key, ItemName = UIItemHelp.ItemSubType2Name[key] });
            }


            typeButtonInfo.TypeId = 2;
            //typeButtonInfo.typeButtonItems = new List<TypeButtonItem>();
            typeButtonInfo.TypeName = UIItemHelp.ItemTypeName[ItemTypeEnum.Material];

            typeButtonInfos.Add(typeButtonInfo);

            typeButtonInfo = new TypeButtonInfo();
            foreach (int key in UIItemHelp.ItemSubType3Name.Keys)
            {
                typeButtonInfo.typeButtonItems.Add(new TypeButtonItem() { SubTypeId = key, ItemName = UIItemHelp.ItemSubType3Name[key] });
            }


            typeButtonInfo.TypeId = 3;
            //typeButtonInfo.typeButtonItems = new List<TypeButtonItem>();
            typeButtonInfo.TypeName = UIItemHelp.ItemTypeName[ItemTypeEnum.Equipment];

            typeButtonInfos.Add(typeButtonInfo);


            typeButtonInfo = new TypeButtonInfo();
            foreach (int key in UIItemHelp.ItemSubType4Name.Keys)
            {
                typeButtonInfo.typeButtonItems.Add(new TypeButtonItem() { SubTypeId = key, ItemName = UIItemHelp.ItemSubType4Name[key] });
            }

            typeButtonInfo.TypeId = 4;
            //typeButtonInfo.typeButtonItems = new List<TypeButtonItem>();
            typeButtonInfo.TypeName = UIItemHelp.ItemTypeName[ItemTypeEnum.Gemstone];

            typeButtonInfos.Add(typeButtonInfo);

            return typeButtonInfos;
        }

        public static void OnClickTypeItem(this UIPaiMaiBuyComponent self, int typeid, int subtypeid)
        {
            for (int i = 0; i < self.PaiMaiList.Count; i++)
            {
                UIPaiMaiBuyItemComponent uI = self.PaiMaiList[i].GetComponent<UIPaiMaiBuyItemComponent>();
                if (uI.PaiMaiItemInfo == null)
                {
                    self.PaiMaiList[i].GameObject.SetActive(false);
                }
                if (uI.PaiMaiItemInfo != null) 
                { 
                    ItemConfig itemConfig = ItemConfigCategory.Instance.Get(uI.PaiMaiItemInfo.BagInfo.ItemID);
                    //显示   0表示通用
                    if (itemConfig.ItemType == typeid && subtypeid == 0)
                    {
                        self.PaiMaiList[i].GameObject.SetActive(true);
                    }
                    else
                    {
                        //子类符合对应关系
                        self.PaiMaiList[i].GameObject.SetActive(itemConfig.ItemType == typeid && itemConfig.ItemSubType == subtypeid);
                    }
                }
            }
        }

        public static void OnUpdateUI(this UIPaiMaiBuyComponent self)
        {
            self.RequestAllPaiMaiList().Coroutine();
        }

        public static void OnClickBtn_Search(this UIPaiMaiBuyComponent self)
        {
            string text = self.InputField.GetComponent<InputField>().text;

            for (int i = 0; i < self.PaiMaiList.Count; i++)
            {
                UIPaiMaiBuyItemComponent uI = self.PaiMaiList[i].GetComponent<UIPaiMaiBuyItemComponent>();
                if (uI.PaiMaiItemInfo == null)
                {
                    self.PaiMaiList[i].GameObject.SetActive(false);
                }
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(uI.PaiMaiItemInfo.BagInfo.ItemID);
                self.PaiMaiList[i].GameObject.SetActive(itemConfig.ItemName.Contains(text));
            }
        }

        public static async ETTask RequestAllPaiMaiList(this UIPaiMaiBuyComponent self)
        {
            C2P_PaiMaiListRequest c2M_PaiMaiBuyRequest = new C2P_PaiMaiListRequest()
            {
                PaiMaiType = 2,
                UserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId
            };
            P2C_PaiMaiListResponse m2C_PaiMaiBuyResponse = (P2C_PaiMaiListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

            var path = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiBuyItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

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

                UI uI = null;
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
                    uI = self.AddChild<UI, string, GameObject>( "BagItemUILIist_" + i, go);
                    uI.AddComponent<UIPaiMaiBuyItemComponent>();
                    self.PaiMaiList.Add(uI);
                }

                uI.GetComponent<UIPaiMaiBuyItemComponent>().OnUpdateItem(paiMaiItemInfo);
                number++;
            }
            //刷新列表
            for (int i = number; i < self.PaiMaiList.Count; i++)
            {
                self.PaiMaiList[i].GetComponent<UIPaiMaiBuyItemComponent>().OnUpdateItem(null);
                self.PaiMaiList[i].GameObject.SetActive(false);
            }
            //选择刷新列表
            self.UITypeViewComponent.TypeButtonComponents[0].OnClickTypeButton();
        }
    }
}
