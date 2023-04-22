using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWatchPetComponent : Entity, IAwake, IDestroy
    {
        public GameObject ImageJinHua;
        public GameObject Text_ShouHu;
        public GameObject ImageShouHu;
        public GameObject Lab_JinHua;

        public GameObject ButtonCloseAddPoint;
        public GameObject AttributeNode;
        public GameObject ButtonCloseHexin;

        public GameObject[] PetHeXinItemList;

        public GameObject ButtonAddPoint;

        public GameObject PetProSetNode_2;
        public GameObject PetProSetNode_1;
        public GameObject PetProSetItem_2;
        public GameObject PetProSetItem_1;
        public GameObject PetProSetNode;
        public GameObject SkinWeiJiHuo;
        public GameObject SkinJiHuo;

        public GameObject ScrollViewSkin;
        public GameObject ButtonUseSkin;
        public GameObject PetSkinRawImage;

        public GameObject ButtonNode;
        public GameObject PetPiFuSet;
        public GameObject PetProSet;
        public GameObject PetZiZhiSet;

        public GameObject ButtonRName;
        public GameObject[] Text_Attribute = new GameObject[4];

        public GameObject Text_PetExp;
        public GameObject Text_PetLevel;
        public GameObject Text_PetNumber;

        public GameObject PetRawImage;
        public GameObject ImageExpValue;
        public GameObject ImagePetStar;

        public GameObject[] PetZiZhiItemList = new GameObject[6];

        public GameObject Btn_XiuXi;
        public GameObject Btn_FangSheng;
        public GameObject Btn_ChuZhan;

        public GameObject InputFieldName;

        public GameObject GameObject2;
        public GameObject GameObject1;

        public GameObject PetListNode;
        public GameObject PetSkillNode;

        public GameObject PropertyShowText;
        public GameObject Text_PetPingFen;

        public UI PetModelShowComponent;
        public UI SkinModelShowComponent;
        public RolePetInfo LastSelectItem;
        public UIPetAddPointComponent PetAddPointComponent;
        public UIPetHeXinSetComponent PetHeXinSetComponent;
        public List<UIPetListItemComponent> PetUIList = new List<UIPetListItemComponent>();
        public List<UICommonSkillItemComponent> PetSkillUIList = new List<UICommonSkillItemComponent>();
        public List<UIPetSkinIconComponent> PetSkinList = new List<UIPetSkinIconComponent>();
        public UIPageButtonComponent uIPageButton;

        public List<RolePetInfo> RolePetInfoList = new List<RolePetInfo>();

        public int PetSkinId;
    }


    public class UIWatchPetComponentDestroy: DestroySystem<UIWatchPetComponent>
    {
        public override void Destroy(UIWatchPetComponent self)
        {
            self.PetUIList.Clear();
            self.PetSkillUIList.Clear();
            self.PetSkinList.Clear();
            self.RolePetInfoList.Clear();
            self.LastSelectItem = null;
            self.PetAddPointComponent = null;
            self.PetHeXinSetComponent = null;
        }
    }


    public class UIWatchPetComponentAwake : AwakeSystem<UIWatchPetComponent>
    {
        public override void Awake(UIWatchPetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.PetProSetNode_2 = rc.Get<GameObject>("PetProSetNode_2");
            self.PetProSetNode_1 = rc.Get<GameObject>("PetProSetNode_1");
            self.PetProSetNode = rc.Get<GameObject>("PetProSetNode");
            self.PetProSetItem_2 = rc.Get<GameObject>("PetProSetItem_2");
            self.PetProSetItem_1 = rc.Get<GameObject>("PetProSetItem_1");

            self.Text_ShouHu = rc.Get<GameObject>("Text_ShouHu");
            self.ImageShouHu = rc.Get<GameObject>("ImageShouHu");
            self.Lab_JinHua = rc.Get<GameObject>("Lab_JinHua");
            self.ImageJinHua = rc.Get<GameObject>("ImageJinHua");
            self.Text_ShouHu.SetActive(false);
            self.ImageShouHu.SetActive(false);
            self.Lab_JinHua.SetActive(false);
            self.ImageJinHua.SetActive(false);

            self.PetProSetItem_2.SetActive(false);
            self.PetProSetItem_1.SetActive(false);
            self.PetProSetNode.SetActive(true);
            self.SkinWeiJiHuo = rc.Get<GameObject>("SkinWeiJiHuo");
            self.SkinJiHuo = rc.Get<GameObject>("SkinJiHuo");
            self.PetPiFuSet = rc.Get<GameObject>("PetPiFuSet");
            self.PetProSet = rc.Get<GameObject>("PetProSet");
            self.PetZiZhiSet = rc.Get<GameObject>("PetZiZhiSet");
            self.Btn_FangSheng = rc.Get<GameObject>("Btn_FangSheng");
            self.Btn_ChuZhan = rc.Get<GameObject>("Btn_ChuZhan");
            self.Btn_XiuXi = rc.Get<GameObject>("Btn_XiuXi");
            self.ButtonNode = rc.Get<GameObject>("ButtonNode");
            self.ScrollViewSkin = rc.Get<GameObject>("ScrollViewSkin");
            self.ButtonUseSkin = rc.Get<GameObject>("ButtonUseSkin");
            self.PetSkinRawImage = rc.Get<GameObject>("PetSkinRawImage");
            self.PropertyShowText = rc.Get<GameObject>("PropertyShowText");

            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI PageButton = self.AddChild<UI, string, GameObject>("FunctionSetBtn", BtnItemTypeSet);
            UIPageButtonComponent uIPageButtonComponent = PageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageButtonComponent.OnSelectIndex(0);
            self.uIPageButton = uIPageButtonComponent;

            self.ButtonRName = rc.Get<GameObject>("ButtonRName");
            ButtonHelp.AddListenerEx(self.ButtonRName, () => { });
            self.ButtonAddPoint = rc.Get<GameObject>("ButtonAddPoint");
            self.ButtonAddPoint.SetActive(false);

            self.ButtonCloseAddPoint = rc.Get<GameObject>("ButtonCloseAddPoint");
            ButtonHelp.AddListenerEx(self.ButtonCloseAddPoint, () => { self.OnButtonCloseAddPoint(); });

            self.AttributeNode = rc.Get<GameObject>("AttributeNode");

            GameObject gameObject = rc.Get<GameObject>("PetAddPoint");
            self.PetAddPointComponent = self.AddChild<UIPetAddPointComponent, GameObject>(gameObject);
            self.PetAddPointComponent.GameObject.SetActive(false);

            GameObject PetHeXinSet = rc.Get<GameObject>("PetHeXinSet");
            self.PetHeXinSetComponent = self.AddChild<UIPetHeXinSetComponent, GameObject>(PetHeXinSet);
            self.PetHeXinSetComponent.ButtonHeXinHeCheng.SetActive(false);
            self.PetHeXinSetComponent.GameObject.SetActive(false);
            self.ButtonCloseHexin = rc.Get<GameObject>("ButtonCloseHexin");
            self.ButtonCloseHexin.GetComponent<Button>().onClick.AddListener(() => {
                self.OnChangeNode(1);
            });

            GameObject petHeXinItem0 = rc.Get<GameObject>("PetHeXinItem0");
            ButtonHelp.AddListenerEx(petHeXinItem0.transform.Find("Node_1/ButtonAdd").gameObject, () => {
                self.OnChangeNode(2);
                self.OnButtonPetHeXinItem(0);
            });
            GameObject petHeXinItem1 = rc.Get<GameObject>("PetHeXinItem1");
            ButtonHelp.AddListenerEx(petHeXinItem1.transform.Find("Node_1/ButtonAdd").gameObject, () => {
                self.OnChangeNode(2);
                self.OnButtonPetHeXinItem(1);
            });
            GameObject petHeXinItem2 = rc.Get<GameObject>("PetHeXinItem2");
            ButtonHelp.AddListenerEx(petHeXinItem2.transform.Find("Node_1/ButtonAdd").gameObject, () => {
                self.OnChangeNode(2);
                self.OnButtonPetHeXinItem(2);
            });
            petHeXinItem0.transform.Find("ImageSelect").gameObject.SetActive(false);
            petHeXinItem1.transform.Find("ImageSelect").gameObject.SetActive(false);
            petHeXinItem2.transform.Find("ImageSelect").gameObject.SetActive(false);
            self.PetHeXinItemList = new GameObject[3];
            self.PetHeXinItemList[0] = petHeXinItem0;
            self.PetHeXinItemList[1] = petHeXinItem1;
            self.PetHeXinItemList[2] = petHeXinItem2;

            self.Text_PetExp = rc.Get<GameObject>("Text_PetExp");
            self.Text_PetLevel = rc.Get<GameObject>("Text_PetLevel");
            self.Text_PetNumber = rc.Get<GameObject>("Text_PetNumber");
            self.PetRawImage = rc.Get<GameObject>("PetRawImage");
            self.ImageExpValue = rc.Get<GameObject>("ImageExpValue");
            self.ImagePetStar = rc.Get<GameObject>("ImagePetStar");

            for (int i = 0; i < self.PetZiZhiItemList.Length; i++)
            {
                self.PetZiZhiItemList[i] = rc.Get<GameObject>("PetZiZhiItem" + (i + 1));
            }

            self.Btn_FangSheng.SetActive(false);
            self.ButtonUseSkin.SetActive(false);

            self.InputFieldName = rc.Get<GameObject>("InputFieldName");
            self.InputFieldName.SetActive(false);

            self.GameObject2 = rc.Get<GameObject>("GameObject2");
            self.GameObject1 = rc.Get<GameObject>("GameObject1");
            self.PetListNode = rc.Get<GameObject>("PetListNode");
            self.PetSkillNode = rc.Get<GameObject>("PetSkillNode");
            self.Text_PetPingFen = rc.Get<GameObject>("Text_PetPingFen");

            self.Btn_XiuXi.SetActive(false);
            self.Btn_ChuZhan.SetActive(false);

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.PetSkinId = 0;
            self.LastSelectItem = null;
            self.PetModelShowComponent = null;
            self.SkinModelShowComponent = null;
            self.InitModelShowView_1().Coroutine();
            self.InitModelShowView_2().Coroutine();
        }
    }

    public static class UIWatchPetComponentSystem
    {

        /// <summary>
        ///  //1 属性 2 宠物之核 3 加点
        /// </summary>
        /// <param name="self"></param>
        /// <param name="nodetype"></param>
        public static void OnChangeNode(this UIWatchPetComponent self, int nodetype)
        {
            self.ButtonNode.SetActive(nodetype == 1);
            self.AttributeNode.SetActive(nodetype == 1);
            self.PetHeXinSetComponent.GameObject.SetActive(nodetype == 2);
            self.PetAddPointComponent.GameObject.SetActive(nodetype == 3);
        }

        public static void OnButtonCloseAddPoint(this UIWatchPetComponent self)
        {
            self.OnChangeNode(1);
        }

        public static F2C_WatchPlayerResponse GetWatchPlayerInfo(this UIWatchPetComponent self)
        {
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIWatch);
            return uI.GetComponent<UIWatchComponent>().F2C_WatchPlayerResponse;
        }

        public static void OnButtonPetHeXinItem(this UIWatchPetComponent self, int position)
        {
            for (int i = 0; i < self.PetHeXinItemList.Length; i++)
            {
                self.PetHeXinItemList[i].transform.Find("ImageSelect").gameObject.SetActive(i == position);
            }
            self.PetHeXinSetComponent.OnUpdateUI(self.LastSelectItem, position);
            self.PetHeXinSetComponent.UpdatePetHexinItem(self.GetWatchPlayerInfo().PetHeXinList);
        }

        public static void OnClickPageButton(this UIWatchPetComponent self, int page)
        {
            self.PetPiFuSet.SetActive(page == 2);
            self.PetProSet.SetActive(page == 1);
            self.PetZiZhiSet.SetActive(page == 0);
            self.ButtonNode.SetActive(page != 2);
        }

        public static async ETTask InitModelShowView_1(this UIWatchPetComponent self)
        {
            //模型展示界面
            long instanceId = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }

            GameObject gameObject_1 = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject_1, self.PetRawImage);
            gameObject_1.transform.localPosition = new Vector3(0 * 1000, 0, 0);
            self.PetModelShowComponent = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject_1);
            self.PetModelShowComponent.AddComponent<UIModelShowComponent, GameObject>(self.PetRawImage);
            //配置摄像机位置[0,115,257]
            gameObject_1.transform.Find("Camera").localPosition = new Vector3(0f, 115, 257f);
            if (self.LastSelectItem != null)
            {
                PetConfig petConfig = PetConfigCategory.Instance.Get(self.LastSelectItem.ConfigId);
                self.PetModelShowComponent.GetComponent<UIModelShowComponent>().ShowOtherModel("Pet/" + petConfig.PetModel.ToString(), true).Coroutine();
            }
        }

        public static async ETTask InitModelShowView_2(this UIWatchPetComponent self)
        {
            //模型展示界面
            long instanceId = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Common/UIModelShow2");
            await TimerComponent.Instance.WaitAsync(1000);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            GameObject gameObject_2 = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject_2, self.PetSkinRawImage);
            gameObject_2.transform.localPosition = new Vector3(1 * 1000, 0, 0);
            self.SkinModelShowComponent = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject_2);
            self.SkinModelShowComponent.AddComponent<UIModelShowComponent, GameObject>(self.PetSkinRawImage);
            //配置摄像机位置[0,115,257]
            gameObject_2.transform.Find("Camera").localPosition = new Vector3(0f, 115, 257f);
            if (self.PetSkinId != 0)
            {
                self.OnSelectSkinHandler(self.PetSkinId);
            }
        }

        public static void OnUpdateUI(this UIWatchPetComponent self)
        {
            self.PetSkinId = 0;
            self.LastSelectItem = null;

            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIWatch);
            self.OnInitUI(uI.GetComponent<UIWatchComponent>().F2C_WatchPlayerResponse.RolePetInfos);
        }

        public static  void OnInitUI(this UIWatchPetComponent self, List<RolePetInfo> rolePetInfos)
        {
            if (rolePetInfos == null)
            {
                return;
            }
            self.RolePetInfoList = rolePetInfos;
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetListItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                UIPetListItemComponent ui_pet = null;
                if (i < self.PetUIList.Count)
                {
                    ui_pet = self.PetUIList[i];
                    ui_pet.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.PetListNode);
                    ui_pet = self.AddChild<UIPetListItemComponent, GameObject>(go);
                    ui_pet.SetClickHandler((long petId) => { self.OnClickPetHandler(petId); });
                    self.PetUIList.Add(ui_pet);
                }

                ui_pet.OnInitData(rolePetInfos[i], 0);
            }

            for (int i = rolePetInfos.Count; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].GameObject.SetActive(false);
            }

            if (self.PetUIList.Count > 0)
            {
                self.GameObject1.SetActive(true);
                self.GameObject2.SetActive(false);
                self.PetUIList[0].OnClickPetItem();
            }
            else
            {
                self.GameObject1.SetActive(false);
                self.GameObject2.SetActive(true);
            }

            self.Text_PetNumber.GetComponent<Text>().text = string.Format("{0}", rolePetInfos.Count);
        }

        public static RolePetInfo GetPetInfoByID(this UIWatchPetComponent self, long petId)
        {
            for (int i = 0; i < self.RolePetInfoList.Count; i++)
            {
                if (self.RolePetInfoList[i].Id == petId)
                {
                    return self.RolePetInfoList[i];
                }
            }
            return null;
        }

        public static void OnClickPetHandler(this UIWatchPetComponent self, long petId)
        {
            self.PetSkinId = 0;
            self.LastSelectItem = self.GetPetInfoByID(petId);
            self.uIPageButton.OnSelectIndex(0);
            self.OnChangeNode(1);
            self.OnUpdatePetInfo(self.LastSelectItem);
            self.UpdatePetModel(self.LastSelectItem);
            self.UpdatePetSelected(self.LastSelectItem);
            self.UpdatePetHeXin(self.LastSelectItem);
        }

        public static BagInfo GetBagInfo(this UIWatchPetComponent self, long bagId)
        {
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIWatch);
            List<BagInfo> bagInfos = uI.GetComponent<UIWatchComponent>().F2C_WatchPlayerResponse.PetHeXinList;
            for (int i = 0; i < bagInfos.Count; i++)
            {
                if (bagInfos[i].BagInfoID == bagId)
                { 
                    return bagInfos[i];
                }
            }
            return null;
        }

        public static void UpdatePetHeXin(this UIWatchPetComponent self, RolePetInfo rolePetItem)
        {
            for (int i = 0; i < self.PetHeXinItemList.Length; i++)
            {
                self.PetHeXinItemList[i].transform.Find("Node_2").gameObject.SetActive(false);
            }

            for (int i = 0; i < rolePetItem.PetHeXinList.Count; i++)
            {
                if (rolePetItem.PetHeXinList[i] == 0)
                {
                    continue;
                }
                BagInfo bagInfo = self.GetBagInfo(rolePetItem.PetHeXinList[i]);
                if (bagInfo == null)
                {
                    Log.ILog.Debug("PetHeXin == null");
                    continue;
                }
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                Transform itemTransform = self.PetHeXinItemList[i].transform;
                //int position = int.Parse(itemConfig.ItemUsePar);
                itemTransform.Find("Node_2").gameObject.SetActive(true);
                itemTransform.Find("Node_2/TextName").gameObject.GetComponent<Text>().text = itemConfig.ItemName;
                itemTransform.Find("Node_2/TextIcon").gameObject.GetComponent<Text>().text = $"等级 {itemConfig.UseLv}";
                Image ImageIcon = itemTransform.Find("Node_2/ImageIcon").gameObject.GetComponent<Image>();
                Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
                ImageIcon.sprite = sp;
            }
        }

        public static void UpdatePetSelected(this UIWatchPetComponent self, RolePetInfo rolePetItem)
        {
            for (int i = 0; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].OnSelectUI(rolePetItem);
            }

            self.OnUpdatePetPoint(rolePetItem);
        }

        public static void UpdatePetModel(this UIWatchPetComponent self, RolePetInfo rolePetItem)
        {
            int skinId = rolePetItem.SkinId;
            if (skinId == 0)
            {
                skinId = PetConfigCategory.Instance.Get(rolePetItem.ConfigId).Skin[0];
            }
            PetSkinConfig petConfig = PetSkinConfigCategory.Instance.Get(skinId);
            if (self.PetModelShowComponent != null)
            {
                self.PetModelShowComponent.GetComponent<UIModelShowComponent>().ShowOtherModel("Pet/" + petConfig.SkinID.ToString(), true).Coroutine();
            }
        }

        public static async ETTask UpdateSkillList(this UIWatchPetComponent self, RolePetInfo rolePetInfo)
        {
            long instanceId = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            List<int> zhuanzhuids = new List<int>();
            string[] zhuanzhuskills = petConfig.ZhuanZhuSkillID.Split(';');
            for (int i = 0; i < zhuanzhuskills.Length; i++)
            {
                if (zhuanzhuskills[i].Length > 1)
                {
                    zhuanzhuids.Add(int.Parse(zhuanzhuskills[i]));
                }
            }
            List<int> skills = new List<int>();
            for (int i = 0; i < rolePetInfo.PetSkill.Count; i++)
            {
                if (zhuanzhuids.Contains(rolePetInfo.PetSkill[i]))
                {
                    skills.Insert(0, rolePetInfo.PetSkill[i]);
                }
                else
                {
                    skills.Add(rolePetInfo.PetSkill[i]);
                }
            }


            for (int i = 0; i < skills.Count; i++)
            {
                UICommonSkillItemComponent ui_item = null;
                if (i < self.PetSkillUIList.Count)
                {
                    ui_item = self.PetSkillUIList[i];
                    ui_item.GameObject.SetActive(true);
                }
                else
                {
                    GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(bagSpace, self.PetSkillNode);
                    ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>(bagSpace);
                    self.PetSkillUIList.Add(ui_item);
                }
                ui_item.OnUpdateUI(skills[i], ABAtlasTypes.PetSkillIcon);
            }

            for (int i = skills.Count; i < self.PetSkillUIList.Count; i++)
            {
                self.PetSkillUIList[i].GameObject.SetActive(false);
            }
        }

        public static void UpdateExpAndLv(this UIWatchPetComponent self, RolePetInfo rolePetInfo)
        {
            self.Text_PetLevel.GetComponent<Text>().text = rolePetInfo.PetLv.ToString() + GameSettingLanguge.LoadLocalization("级");
            ExpConfig expConfig = ExpConfigCategory.Instance.Get(rolePetInfo.PetLv);
            self.Text_PetExp.GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.PetExp, expConfig.PetUpExp);
            self.ImageExpValue.transform.localScale = new Vector3(Mathf.Clamp(rolePetInfo.PetExp * 1f / expConfig.PetUpExp, 0f, 1f), 1f, 1f);
        }

        public static long GetAsLong(this UIWatchPetComponent self, int numericType)
        {
            return 0;
        }

        public static float GetAsFloat(this UIWatchPetComponent self, int numericType)
        {
            return 0f;
        }

        public static void UpdateAttribute(this UIWatchPetComponent self, RolePetInfo rolePetInfo)
        {
            long petAllAct = self.GetAsLong(NumericType.Now_PetAllAct);
            long petAllMageact = self.GetAsLong(NumericType.Now_PetAllMageAct);
            long petAllAdf = self.GetAsLong(NumericType.Now_PetAllAdf);
            long petAllDef = self.GetAsLong(NumericType.Now_PetAllDef);
            long petAllHp = self.GetAsLong(NumericType.Now_PetAllHp);

            float petAllCri = self.GetAsFloat(NumericType.Now_PetAllCri);
            float petAllHit = self.GetAsFloat(NumericType.Now_PetAllHit);
            float petAllDodge = self.GetAsFloat(NumericType.Now_PetAllDodge);

            //基础属性
            self.UpdateAttributeItem(0, self.PetProSetItem_1, self.PetProSetNode_1, ItemViewHelp.GetAttributeIcon(NumericType.Now_MaxAct),
                self.GetAttributeShow(rolePetInfo, NumericType.Now_MaxAct, petAllAct));

            self.UpdateAttributeItem(1, self.PetProSetItem_1, self.PetProSetNode_1, ItemViewHelp.GetAttributeIcon(NumericType.Now_Mage),
                self.GetAttributeShow(rolePetInfo, NumericType.Now_Mage, petAllMageact));

            self.UpdateAttributeItem(2, self.PetProSetItem_1, self.PetProSetNode_1, ItemViewHelp.GetAttributeIcon(NumericType.Now_MaxDef),
                 self.GetAttributeShow(rolePetInfo, NumericType.Now_MaxDef, petAllDef));

            self.UpdateAttributeItem(3, self.PetProSetItem_1, self.PetProSetNode_1, ItemViewHelp.GetAttributeIcon(NumericType.Now_MaxAdf),
                  self.GetAttributeShow(rolePetInfo, NumericType.Now_MaxAdf, petAllAdf));

            self.UpdateAttributeItem(4, self.PetProSetItem_1, self.PetProSetNode_1, ItemViewHelp.GetAttributeIcon(NumericType.Now_MaxHp),
                 self.GetAttributeShow(rolePetInfo, NumericType.Now_MaxHp, petAllHp));


            //特殊属性
            self.UpdateAttributeItem(0, self.PetProSetItem_2, self.PetProSetNode_2, "", self.GetAttributeShow(rolePetInfo, NumericType.Now_Cri, petAllCri));
            self.UpdateAttributeItem(1, self.PetProSetItem_2, self.PetProSetNode_2, "", self.GetAttributeShow(rolePetInfo, NumericType.Now_Res, 0));
            self.UpdateAttributeItem(2, self.PetProSetItem_2, self.PetProSetNode_2, "", self.GetAttributeShow(rolePetInfo, NumericType.Now_Hit, petAllHit));
            self.UpdateAttributeItem(3, self.PetProSetItem_2, self.PetProSetNode_2, "", self.GetAttributeShow(rolePetInfo, NumericType.Now_Dodge, petAllDodge));
        }

        public static string GetAttributeShow(this UIWatchPetComponent self, RolePetInfo rolePetInfo, int numericType, float addValue)
        {
            NumericAttribute numericAttribute = ItemViewHelp.AttributeToName[numericType];
            if (NumericHelp.GetNumericValueType(numericType) == 2)
            {
                float fvalue = (NumericHelp.GetAttributeValue(rolePetInfo, numericType)) * 0.01f + addValue * 100;
                //string svalue = string.Format("{0:F}", fvalue);
                string svalue = fvalue.ToString("0.#####");
                return $"{ItemViewHelp.GetAttributeName(numericType)} {svalue}%";
            }
            else
            {
                return $"{ItemViewHelp.GetAttributeName(numericType)} {(long)(NumericHelp.GetAttributeValue(rolePetInfo, numericType) + addValue)}";
            }
        }

        public static void UpdateAttributeItem(this UIWatchPetComponent self, int index, GameObject itemObj, GameObject parentObj, string iconid, string value)
        {
            GameObject gameObject = null;
            if (parentObj.transform.childCount > index)
            {
                gameObject = parentObj.transform.GetChild(index).gameObject;
            }
            else
            {
                gameObject = GameObject.Instantiate(itemObj);
                UICommonHelper.SetParent(gameObject, parentObj);
                gameObject.SetActive(true);
            }
            gameObject.transform.Find("Text_Attribute1").GetComponent<Text>().text = value;
            if (iconid.Length > 0)
            {
                gameObject.transform.Find("ImageIcon").GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PropertyIcon, iconid);
            }
        }

        public static void UpdatePetZizhi(this UIWatchPetComponent self, RolePetInfo rolePetInfo)
        {
            for (int i = 0; i < self.ImagePetStar.transform.childCount; i++)
            {
                self.ImagePetStar.transform.GetChild(i).gameObject.SetActive(rolePetInfo.Star > i);
            }

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
           
            self.PetZiZhiItemList[0].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Hp, petConfig.ZiZhi_Hp_Max);
            self.PetZiZhiItemList[1].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Act, petConfig.ZiZhi_Act_Max);
            self.PetZiZhiItemList[2].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Def, petConfig.ZiZhi_Def_Max);
            self.PetZiZhiItemList[3].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Adf, petConfig.ZiZhi_Adf_Max);
            self.PetZiZhiItemList[4].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", UICommonHelper.ShowFloatValue(rolePetInfo.ZiZhi_ChengZhang), UICommonHelper.ShowFloatValue((float)petConfig.ZiZhi_ChengZhang_Max));
            self.PetZiZhiItemList[5].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_MageAct, petConfig.ZiZhi_MageAct_Max);

            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_Hp / (float)petConfig.ZiZhi_Hp_Max, 0f, 1f);
            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_Act / (float)petConfig.ZiZhi_Act_Max, 0f, 1f);
            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_Def / (float)petConfig.ZiZhi_Def_Max, 0f, 1f);
            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_Adf / (float)petConfig.ZiZhi_Adf_Max, 0f, 1f);
            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_ChengZhang / (float)petConfig.ZiZhi_ChengZhang_Max, 0f, 1f);
            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_MageAct / (float)petConfig.ZiZhi_MageAct_Max, 0f, 1f);
        }

        public static async ETTask UpdatePetSkin(this UIWatchPetComponent self, RolePetInfo rolePetInfo)
        {
            if (self.LastSelectItem == null)
            {
                return;
            }
            self.PetSkinList.Clear();
            UICommonHelper.DestoryChild(self.ScrollViewSkin);
            PetConfig petConfig = PetConfigCategory.Instance.Get(self.LastSelectItem.ConfigId);

            int selectIndex = 0;
            long instanceId = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetSkinIcon");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            for (int i = 0; i < petConfig.Skin.Length; i++)
            {
                if (petConfig.Skin[i] == 0)
                {
                    continue;
                }
                if (petConfig.Skin[i] == rolePetInfo.SkinId)
                {
                    selectIndex = i;
                }
                GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(bagSpace, self.ScrollViewSkin);
                UIPetSkinIconComponent uIPetSkinIcon = self.AddChild<UIPetSkinIconComponent, GameObject>(bagSpace);
                uIPetSkinIcon.OnUpdateUI(petConfig.Skin[i], self.HavePetSkin(petConfig.Id, petConfig.Skin[i]));
                uIPetSkinIcon.SetClickHandler(self.OnSelectSkinHandler);
                self.PetSkinList.Add(uIPetSkinIcon);
            }

            self.PetSkinList[selectIndex].OnImage_ItemButton();
        }

        public static bool HavePetSkin(this UIWatchPetComponent self, int petid, int skinid)
        {
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIWatch);
            List<KeyValuePair> skinList = uI.GetComponent<UIWatchComponent>().F2C_WatchPlayerResponse.PetSkinList;
            for (int p = 0; p < skinList.Count; p++)
            {
                if (skinList[p].KeyId != petid)
                {
                    continue;
                }
                return skinList[p].Value.Contains(skinid.ToString());
            }
            return false;
        }

        public static void OnSelectSkinHandler(this UIWatchPetComponent self, int skinId)
        {
            self.PetSkinId = skinId;
            for (int i = 0; i < self.PetSkinList.Count; i++)
            {
                self.PetSkinList[i].OnSelected(skinId);
            }

            PetSkinConfig petConfig = PetSkinConfigCategory.Instance.Get(skinId);
            if (self.SkinModelShowComponent != null)
            {
                self.SkinModelShowComponent.GetComponent<UIModelShowComponent>().ShowOtherModel("Pet/" + petConfig.SkinID.ToString(), true).Coroutine();
            }
           
            self.SkinJiHuo.SetActive(self.HavePetSkin(self.LastSelectItem.ConfigId, self.PetSkinId));
            self.SkinWeiJiHuo.SetActive(!self.SkinJiHuo.activeSelf);

            //显示激活属性
            if (petConfig.PripertyShow != "" && petConfig.PripertyShow != "0")
            {
                self.PropertyShowText.SetActive(true);
                self.PropertyShowText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("激活属性") + ":" + petConfig.PripertyShow;
            }
            else
            {
                self.PropertyShowText.SetActive(false);
            }

        }

        public static void OnUpdatePetPoint(this UIWatchPetComponent self, RolePetInfo rolePetItem)
        {
            self.LastSelectItem = rolePetItem;
            self.ButtonAddPoint.transform.Find("Reddot").gameObject.SetActive(rolePetItem != null && rolePetItem.AddPropretyNum > 0);
            for (int i = 0; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].OnUpdatePetPoint(rolePetItem);
            }
            self.UpdateAttribute(self.LastSelectItem);
        }

        public static void OnUpdatePetInfo(this UIWatchPetComponent self, RolePetInfo rolePetInfo)
        {
            self.InputFieldName.GetComponent<InputField>().text = rolePetInfo.PetName;
            self.Btn_XiuXi.SetActive(false);
            self.Btn_ChuZhan.SetActive(false);

            self.UpdateAttribute(rolePetInfo);
            self.UpdateExpAndLv(rolePetInfo);
            self.UpdatePetZizhi(rolePetInfo);
            self.UpdatePetSkin(rolePetInfo).Coroutine();
            self.UpdateSkillList(rolePetInfo).Coroutine();

            self.Text_PetPingFen.GetComponent<Text>().text = ComHelp.PetPingJia(rolePetInfo).ToString();
        }
    }
}
