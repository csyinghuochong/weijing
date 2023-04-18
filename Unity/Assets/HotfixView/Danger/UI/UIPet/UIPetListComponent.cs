using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetListComponent : Entity, IAwake, IDestroy
    {

        public GameObject Text_ShouHu;
        public GameObject ImageShouHu;

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

        public GameObject ImageJinHua;
        public GameObject JinHuaReddot;
        public GameObject Lab_JinHua;

        public UI PetModelShowComponent;
        public UI SkinModelShowComponent;
        public PetComponent PetComponent;
        public RolePetInfo LastSelectItem;
        public UIPetAddPointComponent PetAddPointComponent;
        public UIPetHeXinSetComponent PetHeXinSetComponent;
        public List<UIPetListItemComponent> PetUIList = new List<UIPetListItemComponent>();
        public List<UICommonSkillItemComponent> PetSkillUIList = new List<UICommonSkillItemComponent>();
        public List<UIPetSkinIconComponent> PetSkinList = new List<UIPetSkinIconComponent>();
        public UIPageButtonComponent UIPageButton;

        public int PetSkinId;
    }


    public class UIPetListComponentDestroySystem : DestroySystem<UIPetListComponent>
    {
        public override void Destroy(UIPetListComponent self)
        {
            self.PetUIList.Clear();
            self.PetSkillUIList.Clear();
            self.PetSkinList.Clear();
            self.LastSelectItem = null;
            self.PetAddPointComponent = null;
            self.PetHeXinSetComponent = null;
        }
    }


    public class UIPetListComponentAwakeSystem : AwakeSystem<UIPetListComponent>
    {
        public override void Awake(UIPetListComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.PetProSetNode_2 = rc.Get<GameObject>("PetProSetNode_2");
            self.PetProSetNode_1 = rc.Get<GameObject>("PetProSetNode_1");
            self.PetProSetNode = rc.Get<GameObject>("PetProSetNode");
            self.PetProSetItem_2 = rc.Get<GameObject>("PetProSetItem_2");
            self.PetProSetItem_1 = rc.Get<GameObject>("PetProSetItem_1");
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
            self.Text_ShouHu = rc.Get<GameObject>("Text_ShouHu");
            self.ImageShouHu = rc.Get<GameObject>("ImageShouHu");
         
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI PageButton = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageButtonComponent = PageButton.AddComponent<UIPageButtonComponent>();
            uIPageButtonComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageButtonComponent.OnSelectIndex(0);
            self.UIPageButton = uIPageButtonComponent;

            self.ButtonRName = rc.Get<GameObject>("ButtonRName");
            ButtonHelp.AddListenerEx( self.ButtonRName, ()=> { self.OnButtonRName().Coroutine(); } );
            self.ButtonAddPoint = rc.Get<GameObject>("ButtonAddPoint");
            ButtonHelp.AddListenerEx(self.ButtonAddPoint, () => { self.OnButtonAddPoint(); });

            self.ButtonCloseAddPoint = rc.Get<GameObject>("ButtonCloseAddPoint");
            ButtonHelp.AddListenerEx(self.ButtonCloseAddPoint, () => { self.OnButtonCloseAddPoint(); });

            self.AttributeNode = rc.Get<GameObject>("AttributeNode");

            GameObject gameObject = rc.Get<GameObject>("PetAddPoint");
            self.PetAddPointComponent = self.AddChild<UIPetAddPointComponent, GameObject>(gameObject);
            self.PetAddPointComponent.GameObject.SetActive(false);

            GameObject PetHeXinSet = rc.Get<GameObject>("PetHeXinSet");
            self.PetHeXinSetComponent = self.AddChild<UIPetHeXinSetComponent, GameObject>(PetHeXinSet);
            self.PetHeXinSetComponent.GameObject.SetActive(false);
            self.ButtonCloseHexin = rc.Get<GameObject>("ButtonCloseHexin");
            self.ButtonCloseHexin.GetComponent<Button>().onClick.AddListener(() =>{
                self.OnChangeNode(1);
            } );

            GameObject petHeXinItem0 = rc.Get<GameObject>("PetHeXinItem0");
            ButtonHelp.AddListenerEx(petHeXinItem0.transform.Find("Node_1/ButtonAdd").gameObject, () => {
                self.OnChangeNode(2);
                self.OnButtonPetHeXinItem(0); });
            GameObject petHeXinItem1 = rc.Get<GameObject>("PetHeXinItem1");
            ButtonHelp.AddListenerEx(petHeXinItem1.transform.Find("Node_1/ButtonAdd").gameObject, () => {
                self.OnChangeNode(2);
                self.OnButtonPetHeXinItem(1); });
            GameObject petHeXinItem2 = rc.Get<GameObject>("PetHeXinItem2");
            ButtonHelp.AddListenerEx(petHeXinItem2.transform.Find("Node_1/ButtonAdd").gameObject, () => {
                self.OnChangeNode(2);
                self.OnButtonPetHeXinItem(2); });
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

            ButtonHelp.AddListenerEx(self.Btn_FangSheng, () => { self.OnBtn_FangSheng(); });
            ButtonHelp.AddListenerEx(self.ButtonUseSkin, () => { self.OnButtonUseSkin().Coroutine(); });

            self.InputFieldName = rc.Get<GameObject>("InputFieldName");
            self.InputFieldName.GetComponent<InputField>().onValueChanged.AddListener((string text) => { self.CheckSensitiveWords(); });

            self.GameObject2 = rc.Get<GameObject>("GameObject2");
            self.GameObject1 = rc.Get<GameObject>("GameObject1");
            self.PetListNode = rc.Get<GameObject>("PetListNode");
            self.PetSkillNode = rc.Get<GameObject>("PetSkillNode");
            self.Text_PetPingFen = rc.Get<GameObject>("Text_PetPingFen");
            self.ImageJinHua = rc.Get<GameObject>("ImageJinHua");
            self.JinHuaReddot = rc.Get<GameObject>("JinHuaReddot");
            self.Lab_JinHua = rc.Get<GameObject>("Lab_JinHua");

            self.Btn_XiuXi.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChuZhan(); });
            //self.Btn_FangSheng.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChuZhan(); });
            self.Btn_ChuZhan.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChuZhan(); });
            self.ImageJinHua.GetComponent<Button>().onClick.AddListener(() => { self.OnClickJinHua(); });

            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            self.ImageJinHua.SetActive(true);

            self.PetComponent = self.ZoneScene().GetComponent<PetComponent>();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.PetSkinId = 0;
            self.LastSelectItem = null;
            self.PetModelShowComponent = null;
            self.SkinModelShowComponent = null;
            self.InitModelShowView_1().Coroutine();
            self.InitModelShowView_2().Coroutine();
        }
    }

    public static class UIPetListComponentSystem
    {

        /// <summary>
        ///  //1 属性 2 宠物之核 3 加点
        /// </summary>
        /// <param name="self"></param>
        /// <param name="nodetype"></param>
        public static void OnChangeNode(this UIPetListComponent self, int nodetype)
        {
            self.ButtonNode.SetActive(nodetype == 1);
            self.AttributeNode.SetActive(nodetype == 1);
            self.PetHeXinSetComponent.GameObject.SetActive(nodetype == 2);
            self.PetAddPointComponent.GameObject.SetActive(nodetype == 3);
        }

        public static void OnButtonAddPoint(this UIPetListComponent self)
        {
            self.OnChangeNode(3);
            self.PetAddPointComponent.OnInitUI(self.LastSelectItem);
        }

        public static void OnButtonCloseAddPoint(this UIPetListComponent self)
        {
            self.OnChangeNode(1);
        }

        public static void OnButtonPetHeXinItem(this UIPetListComponent self, int position)
        {
            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByLoc(ItemLocType.ItemPetHeXinBag);
            List<BagInfo> eqipInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByLoc(ItemLocType.ItemPetHeXinEquip);
            for (int i = 0; i < self.PetHeXinItemList.Length; i++)
            {
                self.PetHeXinItemList[i].transform.Find("ImageSelect").gameObject.SetActive(i == position);
            }
            self.PetHeXinSetComponent.OnUpdateUI(self.LastSelectItem, position);
            self.PetHeXinSetComponent.UpdatePetHexinItem(eqipInfos);
            self.PetHeXinSetComponent.OnUpdateItemList(bagInfos);
        }

        public static void OnClickPageButton(this UIPetListComponent self, int page)
        {
            self.PetPiFuSet.SetActive(page == 2);
            self.PetProSet.SetActive(page == 1);
            self.PetZiZhiSet.SetActive(page == 0);
            self.ButtonNode.SetActive(page != 2);
        }

        public static async ETTask OnButtonRName(this UIPetListComponent self)
        {
            string text_old = self.InputFieldName.GetComponent<InputField>().text;
            if (string.IsNullOrEmpty(text_old) || text_old.Length == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请输入名字！");
                return;
            }
            bool mask = MaskWordHelper.Instance.IsContainSensitiveWords(text_old);
            if (mask)
            {
                FloatTipManager.Instance.ShowFloatTip("请重新输入！");
                return;
            }
            if (text_old.Length > 10)
            {
                FloatTipManager.Instance.ShowFloatTip("名字过长！");
                return;
            }

            C2M_RolePetRName c2M_RolePetRName = new C2M_RolePetRName() { PetInfoId = self.LastSelectItem.Id, PetName = text_old };
            M2C_RolePetRName m2C_RolePetRName = (M2C_RolePetRName)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetRName);
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(self.LastSelectItem.Id);
            rolePetInfo.PetName = text_old;
            self.LastSelectItem = rolePetInfo;
            self.OnUpdatePetInfo(rolePetInfo);
            for (int i = 0; i < self.PetUIList.Count; i++)
            {
                if (self.PetUIList[i].PetId == self.LastSelectItem.Id)
                {
                    self.PetUIList[i].OnRName(rolePetInfo);
                }
            }
        }

        public static void CheckSensitiveWords(this UIPetListComponent self)
        {
            string text_new = "";
            string text_old = self.InputFieldName.GetComponent<InputField>().text;
            MaskWordHelper.Instance.IsContainSensitiveWords(ref text_old, out text_new);
            self.InputFieldName.GetComponent<InputField>().text = text_old;
        }

        public static void OnPetFenJieUpdate(this UIPetListComponent self)
        {
            self.LastSelectItem = null;
            self.OnInitUI().Coroutine();
        }

        public static void OnPetFightingSet(this UIPetListComponent self)
        {
            RolePetInfo rolePetInfo = self.PetComponent.GetFightPet();
            for (int i = 0; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].OnPetFightingSet(rolePetInfo);
            }
            self.OnUpdatePetInfo(self.LastSelectItem);
        }

        public static async ETTask OnButtonUseSkin(this UIPetListComponent self)
        {
            if (self.LastSelectItem == null || self.PetSkinId == 0)
            {
                return;
            }

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            if (!petComponent.HavePetSkin(self.LastSelectItem.ConfigId, self.PetSkinId))
            {
                FloatTipManager.Instance.ShowFloatTip("该皮肤尚未激活！");
                return;
            }

            C2M_RolePetSkinSet c2M_RolePetSkinSet = new C2M_RolePetSkinSet();
            c2M_RolePetSkinSet.PetInfoId = self.LastSelectItem.Id;
            c2M_RolePetSkinSet.SkinId = self.PetSkinId;
            M2C_RolePetSkinSet m2C_RolePetSkinSet = (M2C_RolePetSkinSet)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetSkinSet);
            if (m2C_RolePetSkinSet.Error != 0)
            {
                return;
            }
            self.LastSelectItem.SkinId = self.PetSkinId;
            self.UpdatePetModel(self.LastSelectItem);
            FloatTipManager.Instance.ShowFloatTip("宠物皮肤更换成功！");
        }

        public static void OnBtn_FangSheng(this UIPetListComponent self)
        {
            if (self.LastSelectItem == null)
            {
                return;
            }
            if (self.LastSelectItem.PetStatus == 1)
            {
                FloatTipManager.Instance.ShowFloatTip("出战宠物不能分解！");
                return;
            }
            if (self.LastSelectItem.PetStatus == 2)
            {
                FloatTipManager.Instance.ShowFloatTip("请先停止家园散步！");
                return;
            }
            if (self.PetComponent.TeamPetList.Contains(self.LastSelectItem.Id))
            {
                FloatTipManager.Instance.ShowFloatTip("当前宠物存在于宠物天梯上阵中,不能分解！");
                return;
            }
            if (self.PetComponent.PetFormations.Contains(self.LastSelectItem.Id))
            {
                FloatTipManager.Instance.ShowFloatTip("当前宠物存在于宠物副本上阵中,不能分解！");
                return;
            }
            PopupTipHelp.OpenPopupTip(self.DomainScene(), "", GameSettingLanguge.LoadLocalization("确定放生?"),
            () =>
            {
                self.PetComponent.RequestFenJie(self.LastSelectItem.Id).Coroutine();
            },
            null).Coroutine();
        }

        public static void OnClickChuZhan(this UIPetListComponent self)
        {
            RolePetInfo rolePetInfo = self.LastSelectItem;
            if (rolePetInfo == null)
            {
                return;
            }
            if (rolePetInfo.PetStatus == 2)
            {
                FloatTipManager.Instance.ShowFloatTip("先停止散步！");
                return;
            }
            NetHelper.RequestPetFight(self.DomainScene(), rolePetInfo.Id, rolePetInfo.PetStatus == 0 ? 1 : 0).Coroutine();
        }

        //进化按钮
        public static void OnClickJinHua(this UIPetListComponent self)
        {
            RolePetInfo rolePetInfo = self.LastSelectItem;
            if (rolePetInfo.UpStageStatus == 0) {
                FloatTipManager.Instance.ShowFloatTip("宠物在1-60级有概率进行进化,进化消耗1个基础宠物全面提升属性并有概率获得新的技能。");
            }
            if (rolePetInfo.UpStageStatus == 1)
            {
                self.OpenJinHuaUI().Coroutine();
                /*
                PopupTipHelp.OpenPopupTip(self.ZoneScene(),"宠物进化","是否献祭1个宠物后全面进化一次宠物资质",
                    () =>
                    {
                        self.OpenJinHuaUI().Coroutine();
                    }
                    ).Coroutine();
                */
            }
            if (rolePetInfo.UpStageStatus == 2)
            {
                FloatTipManager.Instance.ShowFloatTip("您的宠物已进化完成。");
            }
        }

        public static async ETTask OpenJinHuaUI(this UIPetListComponent self)
        {
            UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIPetXianji);
            uI.GetComponent<UIPetXianjiComponent>().OnInitUI(self.LastSelectItem.Id);
        }

        public static async ETTask OnJinHua(this UIPetListComponent self,long petInfoID)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(self.LastSelectItem.ConfigId);
            if (petConfig.PetType == 2)
            {
                FloatTipManager.Instance.ShowFloatTip("神兽已达最终阶段,无需进化！");
            }

            RolePetInfo oldpetInfo = self.PetComponent.GetPetInfoByID(petInfoID);

            C2M_RolePetUpStage c2M_RolePetUpStage = new C2M_RolePetUpStage() { PetInfoId = petInfoID };
            M2C_RolePetUpStage m2C_RolePetUpStageg = (M2C_RolePetUpStage)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetUpStage);

            if (m2C_RolePetUpStageg.Error == ErrorCore.ERR_Success)
            {
                UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIPetChouKaGet);
                PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
                List<KeyValuePair> oldPetSkin = petComponent.GetPetSkinCopy();
                uI.GetComponent<UIPetChouKaGetComponent>().OnInitUI(m2C_RolePetUpStageg.NewPetInfo, oldPetSkin, false, oldpetInfo);
            }
        }

        public static async ETTask InitModelShowView_1(this UIPetListComponent self)
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

        public static async ETTask InitModelShowView_2(this UIPetListComponent self)
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
            //if (self.LastSelectItem != null)
            //{
            //    PetConfig petConfig = PetConfigCategory.Instance.Get(self.LastSelectItem.ConfigId);
            //    self.SkinModelShowComponent.GetComponent<UIModelShowComponent>().ShowOtherModel("Pet/" + petConfig.PetModel.ToString(), true).Coroutine();
            //}
            if (self.PetSkinId != 0)
            {
                self.OnSelectSkinHandler(self.PetSkinId);
            }
        }

        public static void OnUpdateUI(this UIPetListComponent self)
        {
            self.PetSkinId = 0;
            self.LastSelectItem = null;

            self.OnInitUI().Coroutine();
        }

        public static int NextPetNumber(this UIPetListComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int level = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            int curNumber = self.ZoneScene().GetComponent<PetComponent>().RolePetInfos.Count;
            if (curNumber < ComHelp.GetPetMaxNumber(unit, level))
            {
                return 0;
            }
            
            string[] petInfos = GlobalValueConfigCategory.Instance.Get(34).Value.Split('@');
            for (int i = 0; i < petInfos.Length; i++)
            {
                string[] petNumber = petInfos[i].Split(';');
                if (level < int.Parse(petNumber[0]))
                {
                    return int.Parse(petNumber[0]);
                }
            }
            return 0;
        }

        public static async ETTask OnInitUI(this UIPetListComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetListItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            List<RolePetInfo> rolePetInfos = self.PetComponent.RolePetInfos;
            
            List<RolePetInfo> showList = new List<RolePetInfo>();
            showList.AddRange(rolePetInfos);
            int nextLv = self.NextPetNumber();
            if (nextLv > 0)
            {
                showList.Add(null);
            }
            for (int i = 0; i < showList.Count; i++)
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
                    ui_pet = self.AddChild<UIPetListItemComponent, GameObject>( go);
                    ui_pet.SetClickHandler((long petId) => { self.OnClickPetHandler(petId); });
                    self.PetUIList.Add(ui_pet);
                }
                ui_pet.OnInitData(showList[i], nextLv);
            }

            for (int i = showList.Count; i < self.PetUIList.Count; i++)
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

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int maxNum = ComHelp.GetPetMaxNumber(unit, userInfo.Lv);
            self.Text_PetNumber.GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfos.Count, maxNum);
        }

        public static void OnClickPetHandler(this UIPetListComponent self, long petId)
        {
            if (self.PetComponent.GetPetInfoByID(petId) == null)
            {
                return;
            }

            self.PetSkinId = 0;
            self.LastSelectItem = self.PetComponent.GetPetInfoByID(petId);
            self.UIPageButton.OnSelectIndex(0);
            self.OnChangeNode(1);
            self.OnUpdatePetInfo(self.LastSelectItem);
            self.UpdatePetModel(self.LastSelectItem);
            self.UpdatePetSelected(self.LastSelectItem);
            self.UpdatePetHeXin(self.LastSelectItem);
        }

        public static void UpdatePetHeXin(this UIPetListComponent self, RolePetInfo rolePetItem)
        {
            for (int i = 0; i < self.PetHeXinItemList.Length; i++)
            {
                self.PetHeXinItemList[i].transform.Find("Node_2").gameObject.SetActive(false);
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            for (int i = 0; i < rolePetItem.PetHeXinList.Count; i++)
            {
                if (rolePetItem.PetHeXinList[i] == 0)
                {
                    continue;
                }
                BagInfo bagInfo = bagComponent.GetBagInfo(rolePetItem.PetHeXinList[i]);
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

        public static void UpdatePetSelected(this UIPetListComponent self, RolePetInfo rolePetItem)
        {
            for (int i = 0; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].OnSelectUI(rolePetItem);
            }

            self.OnUpdatePetPoint(rolePetItem);
        }

        public static void UpdatePetModel(this UIPetListComponent self, RolePetInfo rolePetItem)
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

        public static void  UpdateSkillList(this UIPetListComponent self, RolePetInfo rolePetInfo)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);

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
                    ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>( bagSpace);
                    self.PetSkillUIList.Add(ui_item);
                }
                ui_item.OnUpdateUI(skills[i], ABAtlasTypes.PetSkillIcon);
            }

            for (int i = skills.Count; i < self.PetSkillUIList.Count; i++)
            {
                self.PetSkillUIList[i].GameObject.SetActive(false);
            }
        }

        public static void UpdateExpAndLv(this UIPetListComponent self, RolePetInfo rolePetInfo)
        {
            self.Text_PetLevel.GetComponent<Text>().text = rolePetInfo.PetLv.ToString() + GameSettingLanguge.LoadLocalization("级");
            ExpConfig expConfig = ExpConfigCategory.Instance.Get(rolePetInfo.PetLv);
            self.Text_PetExp.GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.PetExp, expConfig.PetUpExp);
            self.ImageExpValue.transform.localScale = new Vector3(Mathf.Clamp(rolePetInfo.PetExp * 1f / expConfig.PetUpExp, 0f, 1f), 1f, 1f);
        }

        public static void UpdateAttribute(this UIPetListComponent self, RolePetInfo rolePetInfo)
        {

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long petAllAct = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_PetAllAct);
            long petAllMageact = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_PetAllMageAct);
            long petAllAdf = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_PetAllAdf);
            long petAllDef = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_PetAllDef);
            long petAllHp = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_PetAllHp);

            float petAllCri = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_PetAllCri);
            float petAllHit = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_PetAllHit);
            float petAllDodge = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_PetAllDodge);

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
            self.UpdateAttributeItem(1, self.PetProSetItem_2, self.PetProSetNode_2, "", self.GetAttributeShow(rolePetInfo, NumericType.Now_Res,0));
            self.UpdateAttributeItem(2, self.PetProSetItem_2, self.PetProSetNode_2, "", self.GetAttributeShow(rolePetInfo, NumericType.Now_Hit, petAllHit));
            self.UpdateAttributeItem(3, self.PetProSetItem_2, self.PetProSetNode_2, "", self.GetAttributeShow(rolePetInfo, NumericType.Now_Dodge, petAllDodge));
        }

        public static string GetAttributeShow(this UIPetListComponent self, RolePetInfo rolePetInfo, int numericType,float addValue)
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

        public static void UpdateAttributeItem(this UIPetListComponent self, int index, GameObject itemObj, GameObject parentObj, string iconid, string value)
        {
            GameObject gameObject = null;
            if (parentObj.transform.childCount > index)
            {
                gameObject = parentObj.transform.GetChild(index).gameObject;
            }
            else
            {
                gameObject = GameObject.Instantiate(itemObj);
                UICommonHelper.SetParent( gameObject, parentObj);
                gameObject.SetActive(true);
            }
            gameObject.transform.Find("Text_Attribute1").GetComponent<Text>().text = value;
            if (iconid.Length > 0)
            {
                gameObject.transform.Find("ImageIcon").GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PropertyIcon, iconid);
            }
        }

        public static void UpdatePetZizhi(this UIPetListComponent self, RolePetInfo rolePetInfo)
        {
            for (int i = 0; i < self.ImagePetStar.transform.childCount; i++)
            {
                self.ImagePetStar.transform.GetChild(i).gameObject.SetActive(rolePetInfo.Star > i );
            }

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            //self.Text_Attribute[0].GetComponent<Text>().text = string.Format("血量 {0}", self.PetComponent.GetAttributeValue(rolePetInfo, NumericType.Now_MaxHp));
            //self.Text_Attribute[1].GetComponent<Text>().text = string.Format("攻击 {0}", self.PetComponent.GetAttributeValue(rolePetInfo, NumericType.Now_MaxAct));
            //self.Text_Attribute[2].GetComponent<Text>().text = string.Format("物防 {0}", self.PetComponent.GetAttributeValue(rolePetInfo, NumericType.Now_MaxDef));
            //self.Text_Attribute[3].GetComponent<Text>().text = string.Format("魔防 {0}", self.PetComponent.GetAttributeValue(rolePetInfo, NumericType.Now_MaxAdf));

            self.PetZiZhiItemList[0].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Hp, petConfig.ZiZhi_Hp_Max);
            self.PetZiZhiItemList[1].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Act, petConfig.ZiZhi_Act_Max);
            self.PetZiZhiItemList[2].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Def, petConfig.ZiZhi_Def_Max);
            self.PetZiZhiItemList[3].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_Adf, petConfig.ZiZhi_Adf_Max);
            self.PetZiZhiItemList[4].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", UICommonHelper.ShowFloatValue(rolePetInfo.ZiZhi_ChengZhang), UICommonHelper.ShowFloatValue((float)petConfig.ZiZhi_ChengZhang_Max));
            self.PetZiZhiItemList[5].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", rolePetInfo.ZiZhi_MageAct, petConfig.ZiZhi_MageAct_Max);
            /*
            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Hp * 1f / petConfig.ZiZhi_Hp_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Act * 1f / petConfig.ZiZhi_Act_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Def * 1f / petConfig.ZiZhi_Def_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_Adf * 1f / petConfig.ZiZhi_Adf_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_ChengZhang * 1f / (float)petConfig.ZiZhi_ChengZhang_Max, 0f, 1f), 1f, 1f);
            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").localScale = new Vector3(Mathf.Clamp(rolePetInfo.ZiZhi_MageAct * 1f / petConfig.ZiZhi_MageAct_Max, 0f, 1f), 1f, 1f);
            */
            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_Hp / (float)petConfig.ZiZhi_Hp_Max, 0f,1f);
            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_Act / (float)petConfig.ZiZhi_Act_Max, 0f, 1f);
            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_Def / (float)petConfig.ZiZhi_Def_Max, 0f, 1f);
            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_Adf / (float)petConfig.ZiZhi_Adf_Max, 0f, 1f);
            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_ChengZhang / (float)petConfig.ZiZhi_ChengZhang_Max, 0f, 1f);
            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)rolePetInfo.ZiZhi_MageAct / (float)petConfig.ZiZhi_MageAct_Max, 0f, 1f);
        }

        public static  void UpdatePetSkin(this UIPetListComponent self, RolePetInfo rolePetInfo)
        {
            if (self.LastSelectItem == null)
            {
                return;
            }
            self.PetSkinList.Clear();
            UICommonHelper.DestoryChild(self.ScrollViewSkin);
            PetConfig petConfig = PetConfigCategory.Instance.Get(self.LastSelectItem.ConfigId);

            int selectIndex = 0;
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetSkinIcon");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
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
                uIPetSkinIcon.OnUpdateUI(petConfig.Skin[i], petComponent.HavePetSkin(petConfig.Id, petConfig.Skin[i]) );
                uIPetSkinIcon.SetClickHandler(self.OnSelectSkinHandler);
                self.PetSkinList.Add(uIPetSkinIcon);
            }

            self.PetSkinList[selectIndex].OnImage_ItemButton();
        }

        public static void OnSelectSkinHandler(this UIPetListComponent self, int skinId)
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
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            self.SkinJiHuo.SetActive(petComponent.HavePetSkin( self.LastSelectItem.ConfigId, self.PetSkinId ));
            self.SkinWeiJiHuo.SetActive(!self.SkinJiHuo.activeSelf);

            //显示激活属性
            if (petConfig.PripertyShow != "" && petConfig.PripertyShow != "0")
            {
                self.PropertyShowText.SetActive(true);
                self.PropertyShowText.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("激活属性") + ":" + petConfig.PripertyShow;
            }
            else {
                self.PropertyShowText.SetActive(false);
            }
            
        }

        public static void OnBagItemUpdate(this UIPetListComponent self)
        {
            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByLoc(ItemLocType.ItemPetHeXinBag);
            self.PetHeXinSetComponent.OnUpdateItemList(bagInfos);
        }

        public static void OnUpdatePetPoint(this UIPetListComponent self, RolePetInfo rolePetItem)
        {
            self.LastSelectItem = rolePetItem;
            self.ButtonAddPoint.transform.Find("Reddot").gameObject.SetActive(rolePetItem != null && rolePetItem.AddPropretyNum > 0);
            for (int i = 0; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].OnUpdatePetPoint(rolePetItem);
            }
            self.UpdateAttribute(self.LastSelectItem);
        }

        public static void OnEquipPetHeXin(this UIPetListComponent self)
        {
            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByLoc(ItemLocType.ItemPetHeXinBag);
            List<BagInfo> eqipInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByLoc(ItemLocType.ItemPetHeXinEquip);
            self.LastSelectItem = self.PetComponent.GetPetInfoByID(self.LastSelectItem.Id);
            self.UpdatePetHeXin(self.LastSelectItem);
            self.UpdateAttribute(self.LastSelectItem);
            self.PetHeXinSetComponent.SelectItemHandlder(null);
            self.PetHeXinSetComponent.UpdatePetHexinItem(eqipInfos);
            self.PetHeXinSetComponent.OnUpdateItemList(bagInfos);
        }

        public static void OnUpdatePetInfo(this UIPetListComponent self, RolePetInfo rolePetInfo)
        {
            self.InputFieldName.GetComponent<InputField>().text = rolePetInfo.PetName;
            self.Btn_XiuXi.SetActive(rolePetInfo.PetStatus == 1);
            self.Btn_ChuZhan.SetActive(rolePetInfo.PetStatus == 0);

            self.UpdateAttribute(rolePetInfo);
            self.UpdateExpAndLv(rolePetInfo);
            self.UpdatePetZizhi(rolePetInfo);
            self.UpdatePetSkin(rolePetInfo);
            self.UpdateSkillList(rolePetInfo);

            self.Text_PetPingFen.GetComponent<Text>().text = ComHelp.PetPingJia(rolePetInfo).ToString();

            self.Text_ShouHu.GetComponent<Text>().text = ConfigHelper.PetShouHuAttri[rolePetInfo.ShouHuPos - 1].Value;
            self.ImageShouHu.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, $"ShouHu_{rolePetInfo.ShouHuPos - 1}");

            //更新宠物是否进化
            if (rolePetInfo.UpStageStatus == 0 || rolePetInfo.UpStageStatus == 1)
            {
                UICommonHelper.SetImageGray(self.ImageJinHua, true);
                if (rolePetInfo.UpStageStatus == 1) {
                    self.JinHuaReddot.SetActive(true);
                    self.Lab_JinHua.GetComponent<Text>().text = "点击进化";
                }
                else {
                    self.JinHuaReddot.SetActive(false);
                    self.Lab_JinHua.GetComponent<Text>().text = "未进化";
                }
            }
            else {
                UICommonHelper.SetImageGray(self.ImageJinHua, false);
                self.JinHuaReddot.SetActive(false);
                self.Lab_JinHua.GetComponent<Text>().text = "已进化";
            }

            PetConfig petConfig = PetConfigCategory.Instance.Get(self.LastSelectItem.ConfigId);
            if (petConfig.PetType == 2) {
                UICommonHelper.SetImageGray(self.ImageJinHua, false);
                self.JinHuaReddot.SetActive(false);
                self.Lab_JinHua.GetComponent<Text>().text = "已进化";
            }
        }
    }
}