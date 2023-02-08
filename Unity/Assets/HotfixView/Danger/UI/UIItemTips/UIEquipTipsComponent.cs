using ProtoBuf.Meta;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIEquipTipsComponent : Entity, IAwake, IDestroy
    {
        public GameObject ImageQualityLine;
        public GameObject ImageQualityBg;
        public GameObject Img_back_btn;

        public string ItemID;
        public string ItemHideID;
        public string ItemGemID;
        public string ItemGemHole;
        public string ItemHide_PaiHangBangShowHideStr; 
        public GameObject Img_back;
        public GameObject Obj_EquipIcon;
        public GameObject Obj_EquipQuality;
        public GameObject Obj_EquipName;

        public GameObject Obj_EquipTypeSon;
        public GameObject Obj_EquipProperty;
        public GameObject Obj_EquipWearNeed;
        public GameObject Obj_EquipDes;
        public GameObject Obj_EquipWearNeedProperty;

        public GameObject Obj_EquipHintSkill;
        public GameObject Obj_EquipHintSkillSetList;
        public GameObject Obj_HideProperty;

        public GameObject Obj_EquipZhuanJingSetList;
        public GameObject EquipBaseSetList;

        public GameObject Obj_EquiZhuanJing;
        public GameObject Obj_EquipBottom;
        public GameObject Obj_BtnSet;
        public GameObject Obj_EquipPropertyText;
        public GameObject Obj_EquipSuitItemNamePropertyText;
        public GameObject Obj_BagOpenSet;
        public GameObject Obj_RoseEquipOpenSet;
        public GameObject Obj_SaveStoreHouse;
        public GameObject Obj_Diu;
        public GameObject Obj_Btn_StoreHouseSet;
        public GameObject Obj_Btn_HuiShou;
        public GameObject Obj_Btn_HuiShouCancle;

        public string UIBagSpaceNum;
        public GameObject Obj_UIBagSpace;
        public GameObject Obj_UIRoseEquipShow;
        public GameObject Obj_UIOrnamentChoice;

        public GameObject Obj_UIEquipGemHoleSet;
        public GameObject[] Obj_UIEquipGemHoleList;
        public GameObject[] Obj_UIEquipGemHoleTextList;
        public GameObject[] Obj_UIEquipGemHoleIconList;

        public GameObject Obj_UIEquipSuit;             
        public GameObject Obj_UIEquipSuitName;         
        public GameObject Obj_EquipSuitPropertyText;
        public GameObject Obj_EquipSuitSetList;
        public GameObject Obj_EquipSuitShowListSet;
        public GameObject Obj_Lab_EquipSuitShowListSetSuitName;

        public GameObject Obj_UISuitEquipName;
        public GameObject EquipSuitShowSet_Right;
        public GameObject EquipSuitShowSet_Lelt;
        public GameObject Obj_Btn_ShowEquipSuit;
        public GameObject Obj_EquipSuitShowNameListSet;
        public GameObject Obj_Lab_EquipQiangHua;
        public GameObject Obj_ZhuanJingStatusDes;
        public GameObject Obj_ZhuanJingStatusImg;

        public ItemOperateEnum EquipTipsType;                    
        public int EquipQiangHuaID;                 
        public GameObject itemTips_1;
        public GameObject showEquipObj;
        public GameObject Obj_ImgYiChuanDai;
        public GameObject Obj_Lab_EquipBangDing;
        public GameObject Obj_Img_EquipBangDing;
        public GameObject Lab_EquipType;

        public GameObject Obj_Lab_EquipMake;       
        public bool clickBtnStatus;

        public BagInfo BagInfo;

        public float TitleBigHeight_160;      //底图头部的宽度
        public float TextItemHeight_40;       //底图属性的宽度
        public float TitleMiniHeight_50;

        //按钮相关
        public GameObject Btn_Use;          //穿戴
        public GameObject Btn_Takeoff;      //取回
        public GameObject Btn_Sell;         //出售

        public BagComponent BagComponent;

        public Vector2 Img_backVector2;
        public float Lab_ItemNameWidth;
    }

    [ObjectSystem]
    public class UIEquipTipsComponentAwakeSystem : AwakeSystem<UIEquipTipsComponent>
    {
        public override void Awake(UIEquipTipsComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageQualityLine = rc.Get<GameObject>("ImageQualityLine");
            self.ImageQualityBg = rc.Get<GameObject>("ImageQualityBg");
            self.Img_back_btn = rc.Get<GameObject>("Img_back_btn");
            self.Img_back = rc.Get<GameObject>("Img_back");
            self.Img_backVector2 = self.Img_back.GetComponent<RectTransform>().sizeDelta;

            self.Obj_EquipIcon = rc.Get<GameObject>("Img_EquipIcon");
            self.Obj_EquipQuality = rc.Get<GameObject>("Img_EquipQuality");
            self.Obj_EquipName = rc.Get<GameObject>("Img_EquipName");
            self.Lab_ItemNameWidth = self.Obj_EquipName.GetComponent<RectTransform>().sizeDelta.x;

            self.Obj_EquipTypeSon = rc.Get<GameObject>("Img_EquipTypeSon");
            self.Obj_EquipProperty = rc.Get<GameObject>("Lab_EquipProperty");
            self.Obj_EquipWearNeed = rc.Get<GameObject>("Lab_WearNeed");
            self.Obj_EquipDes = rc.Get<GameObject>("Lab_EquipDes");
            self.Obj_EquipWearNeedProperty = rc.Get<GameObject>("Lab_WearNeedProperty");
            self.Obj_EquipHintSkill = rc.Get<GameObject>("EquipHintSkill");
            self.Obj_EquipHintSkill.SetActive(false);

            self.Obj_EquipHintSkillSetList = rc.Get<GameObject>("EquipHintSkillSetList");
            self.Obj_EquipBottom = rc.Get<GameObject>("EquipBottom");
            self.Obj_BtnSet = rc.Get<GameObject>("EquipBtnSet");
            self.Obj_BagOpenSet = rc.Get<GameObject>("BagOpenSet");
            self.Obj_RoseEquipOpenSet = rc.Get<GameObject>("RoseEquipOpenSet");
            self.Obj_SaveStoreHouse = rc.Get<GameObject>("Btn_SaveStoreHouse");
            self.Obj_Diu = rc.Get<GameObject>("Btn_Diu");
            self.Obj_Btn_StoreHouseSet = rc.Get<GameObject>("Btn_StoreHouseSet");
            self.Obj_Btn_HuiShou = rc.Get<GameObject>("Btn_HuiShouFangZhi");
            self.Obj_Btn_HuiShouCancle = rc.Get<GameObject>("Btn_Take");
            self.Obj_HideProperty = rc.Get<GameObject>("Lab_WearNeed");
            self.Btn_Use = rc.Get<GameObject>("Btn_Use");
            self.Btn_Takeoff = rc.Get<GameObject>("Btn_Takeoff");
            self.Obj_EquipPropertyText = rc.Get<GameObject>("Obj_EquipPropertyText");
            self.Obj_EquipPropertyText.SetActive(false);
            self.Obj_EquiZhuanJing = rc.Get<GameObject>("ObjEquipZhuanJingSet");
            self.Obj_EquiZhuanJing.SetActive(false);

            self.Obj_UIEquipSuit = rc.Get<GameObject>("Obj_UIEquipSuit");
            self.Obj_UIEquipSuitName = rc.Get<GameObject>("Lab_SuitName");
            self.Btn_Sell = rc.Get<GameObject>("Btn_Sell");
            self.Obj_EquipZhuanJingSetList = rc.Get<GameObject>("EquipZhuanJingSetList");
            self.EquipBaseSetList = rc.Get<GameObject>("EquipBaseSetList");
            self.Obj_EquipSuitSetList = rc.Get<GameObject>("EquipSuitSetList");
            self.Obj_Btn_ShowEquipSuit = rc.Get<GameObject>("Btn_ShowEquipSuit");
            self.Obj_EquipSuitShowListSet = rc.Get<GameObject>("EquipSuitShowListSet");
            self.Obj_EquipSuitShowNameListSet = rc.Get<GameObject>("EquipSuitShowNameListSet");
            self.Obj_Lab_EquipSuitShowListSetSuitName = rc.Get<GameObject>("Lab_EquipSuitShowListSetSuitName");
            self.Obj_Lab_EquipQiangHua = rc.Get<GameObject>("Lab_EquipQiangHua");
            self.Obj_ZhuanJingStatusDes = rc.Get<GameObject>("ZhuanJingStatusDes");
            self.Obj_ZhuanJingStatusImg = rc.Get<GameObject>("ZhuanJingStatusImg");
            self.Obj_Lab_EquipBangDing = rc.Get<GameObject>("Lab_EquipBangDing");
            self.Obj_Img_EquipBangDing = rc.Get<GameObject>("Img_EquipBangDing");
            self.Obj_Lab_EquipMake = rc.Get<GameObject>("Lab_EquipMake");
            self.Lab_EquipType = rc.Get<GameObject>("Lab_EquipType");
            self.Obj_EquipSuitItemNamePropertyText = rc.Get<GameObject>("EquipSuitItemNamePropertyText");

            self.Obj_UIEquipGemHoleSet = rc.Get<GameObject>("Obj_UIEquipGemHoleSet");
            self.Obj_UIEquipGemHoleList = new GameObject[4];
            self.Obj_UIEquipGemHoleList[0] = rc.Get<GameObject>("Obj_UIEquipGemHole_1");
            self.Obj_UIEquipGemHoleList[1] = rc.Get<GameObject>("Obj_UIEquipGemHole_2");
            self.Obj_UIEquipGemHoleList[2] = rc.Get<GameObject>("Obj_UIEquipGemHole_3");
            self.Obj_UIEquipGemHoleList[3] = rc.Get<GameObject>("Obj_UIEquipGemHole_4");

            self.Obj_UIEquipGemHoleTextList = new GameObject[4];
            self.Obj_UIEquipGemHoleTextList[0] = rc.Get<GameObject>("Obj_UIEquipGemHoleText_1");
            self.Obj_UIEquipGemHoleTextList[1] = rc.Get<GameObject>("Obj_UIEquipGemHoleText_2");
            self.Obj_UIEquipGemHoleTextList[2] = rc.Get<GameObject>("Obj_UIEquipGemHoleText_3");
            self.Obj_UIEquipGemHoleTextList[3] = rc.Get<GameObject>("Obj_UIEquipGemHoleText_4");

            self.Obj_UIEquipGemHoleIconList= new GameObject[4];
            self.Obj_UIEquipGemHoleIconList[0] = rc.Get<GameObject>("Obj_UIEquipGemHoleIcon_1");
            self.Obj_UIEquipGemHoleIconList[1] = rc.Get<GameObject>("Obj_UIEquipGemHoleIcon_2");
            self.Obj_UIEquipGemHoleIconList[2] = rc.Get<GameObject>("Obj_UIEquipGemHoleIcon_3");
            self.Obj_UIEquipGemHoleIconList[3] = rc.Get<GameObject>("Obj_UIEquipGemHoleIcon_4");

            ButtonHelp.AddListenerEx(self.Img_back_btn, self.OnCloseTips);
            ButtonHelp.AddListenerEx(self.Btn_Use, self.OnClickWearEquip);
            ButtonHelp.AddListenerEx(self.Btn_Takeoff, self.OnClickTakeEquip);
            ButtonHelp.AddListenerEx(self.Btn_Sell, self.OnClickSellEquip);
            ButtonHelp.AddListenerEx(self.Obj_Btn_ShowEquipSuit, self.OnClickShowSuitEquip);
            ButtonHelp.AddListenerEx(self.Obj_Btn_HuiShou, self.On_Btn_HuiShou);
            ButtonHelp.AddListenerEx(self.Obj_Btn_HuiShouCancle, self.OnBtn_HuiShouCancle);
            ButtonHelp.AddListenerEx(self.Obj_SaveStoreHouse, self.OnBtn_PutStoreHouse);
            ButtonHelp.AddListenerEx(self.Obj_Btn_StoreHouseSet, self.OnBtn_PutBag);

            self.TitleBigHeight_160 = 160f;              //标题底框高度
            self.TitleMiniHeight_50 = 50;                //条目标题高度
            self.TextItemHeight_40 = 40;                  //条目文本高度
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
        }
    }

    [ObjectSystem]
    public class UIEquipTipsComponentDestroySystem : DestroySystem<UIEquipTipsComponent>
    {
        public override void Destroy(UIEquipTipsComponent self)
        {
            self.OnDestroyTips();
        }
    }

    public static class UIEquipTipsComponentSystem
    {

        public static void On_Btn_HuiShou(this UIEquipTipsComponent self)
        {
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"1_{self.BagInfo.BagInfoID}");
            self.OnCloseTips();
        }

        public static void OnBtn_HuiShouCancle(this UIEquipTipsComponent self)
        {
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"0_{self.BagInfo.BagInfoID}");
            self.OnCloseTips();
        }

        //放入仓库
        public static void OnBtn_PutStoreHouse(this UIEquipTipsComponent self)
        {
            self.BagComponent.SendPutStoreHouse(self.BagInfo).Coroutine();

            self.OnCloseTips();
        }

        //放入仓库
        public static void OnBtn_StoreHouse(this UIEquipTipsComponent self)
        {
            self.BagComponent.SendPutStoreHouse(self.BagInfo).Coroutine();

            self.OnCloseTips();
        }

        //放入背包
        public static void OnBtn_PutBag(this UIEquipTipsComponent self)
        {
            self.BagComponent.SendPutBag(self.BagInfo).Coroutine();

            self.OnCloseTips();
        }

        public static void OnCloseTips(this UIEquipTipsComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips);
        }

        public static void OnDestroyTips(this UIEquipTipsComponent self)
        {
        }

        //穿戴装备
        public static void OnClickWearEquip(this UIEquipTipsComponent self)
        {
            ItemConfig itemconf = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int occTwo = userInfo.OccTwo;


            if (itemconf.ItemSubType == (int)ItemSubTypeEnum.Wuqi)
            {
                if (!UIItemHelp.OccWeaponList[userInfo.Occ].Contains(itemconf.EquipType))
                {
                    switch (userInfo.Occ)
                    {
                        //战士
                        case 1:
                            FloatTipManager.Instance.ShowFloatTip("请选择武器类型为：刀 剑！");
                            break;
                        //法师
                        case 2:
                            FloatTipManager.Instance.ShowFloatTip("请选择武器类型为：法杖 魔法书！！");
                            break;
                    }
                    return;
                }
            }
            if ( (itemconf.ItemSubType != (int)ItemSubTypeEnum.Wuqi  && itemconf.ItemSubType <= (int)ItemSubTypeEnum.Xianglian)  && occTwo != 0)
            {
                OccupationTwoConfig occupationTwo = OccupationTwoConfigCategory.Instance.Get(occTwo);
                if (itemconf.EquipType != 0 && itemconf.EquipType != occupationTwo.ArmorMastery&& itemconf.EquipType!=99)
                {
                    //FloatTipManager.Instance.ShowFloatTip("请选择合适的装备！");
                    switch (occupationTwo.ArmorMastery)
                    {
                        //布甲
                        case 11:
                            FloatTipManager.Instance.ShowFloatTip("转职后请选择布甲进行装备！");
                            break;
                        //轻甲
                        case 12:
                            FloatTipManager.Instance.ShowFloatTip("转职后请选择轻甲进行装备！");
                            break;
                        //重甲
                        case 13:
                            FloatTipManager.Instance.ShowFloatTip("转职后请选择重甲进行装备！");
                            break;
                    }
                    return;
                }
            }

            self.BagComponent.SendWearEquip(self.BagInfo).Coroutine();
            self.OnCloseTips();
        }

        //卸下装备
        public static void OnClickTakeEquip(this UIEquipTipsComponent self)
        {
            self.BagComponent.SendTakeEquip(self.BagInfo).Coroutine();

            self.OnCloseTips();
        }

        //出售装备
        public static void OnClickSellEquip(this UIEquipTipsComponent self)
        {
            string[] gemids = self.BagInfo.GemIDNew.Split('_');
            bool haveGem = false;
            for (int i = 0; i < gemids.Length; i++)
            {
                if (gemids[i] != "0")
                {
                    haveGem = true;
                    break;
                }
            }
            if (haveGem)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "出售道具", "该装备镶嵌有宝石，是否出售道具？", () =>
                {
                    self.BagComponent.SendSellItem(self.BagInfo).Coroutine();
                    FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("装备出售完成!"));
                    self.OnCloseTips();
                }).Coroutine();

                return;
            }

            if (ItemConfigCategory.Instance.Get(self.BagInfo.ItemID).ItemQuality >= 4)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "出售道具", "是否出售道具:" + itemConfig.ItemName, () =>
                {
                    self.BagComponent.SendSellItem(self.BagInfo).Coroutine();
                    FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("装备出售完成!"));
                    self.OnCloseTips();
                }).Coroutine();

                return;
            }

            self.BagComponent.SendSellItem(self.BagInfo).Coroutine();
            FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("装备出售完成!"));
            self.OnCloseTips();
        }

        //展示装备套装Tips
        public static void OnClickShowSuitEquip(this UIEquipTipsComponent self)
        {
            if (self.Obj_EquipSuitShowListSet.activeSelf == false)
            {
                self.Obj_EquipSuitShowListSet.SetActive(true);
            }
            else {
                self.Obj_EquipSuitShowListSet.SetActive(false);
            }
        }

        //展示隐藏技能
        public static string ShowHintSkill(this UIEquipTipsComponent self, string AddPropreListStr)
        {
            string proprety = AddPropreListStr.Split(',')[0];
            string propretyValue = AddPropreListStr.Split(',')[1];
            string textShow = "";
            switch (proprety)
            {
                case "10001":
                    //获取技能名称
                    string skillName = SkillConfigCategory.Instance.Get(int.Parse(propretyValue)).SkillName;
                    string langStr = GameSettingLanguge.LoadLocalization("隐藏属性");
                    textShow = langStr + "：" + skillName;
                    break;
            }
            return textShow;
        }

        //显示宝石
        public static void TipsShowEquipGem(this UIEquipTipsComponent self, GameObject gemIconObj, GameObject gemTextObj, int gemItemID, int gemHoleID)
        {

            //Debug.Log("gemItemID = " + gemItemID + "gemHoleID = " + gemHoleID);

            //获取道具图标和名称
            if (gemItemID != 0)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(gemItemID);
                //显示宝石
                string gemItemIcon = itemConfig.Icon;
                string gemItemName = itemConfig.ItemName;
                int gemItemQuality = itemConfig.ItemQuality;

                object obj = Resources.Load("ItemIcon/" + gemItemIcon, typeof(Sprite));
                Sprite itemIcon = obj as Sprite;
                gemIconObj.GetComponent<Image>().sprite = itemIcon;
                gemTextObj.GetComponent<Text>().text = gemItemName;
                gemTextObj.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(gemItemQuality);

            }
            else
            {
                //表示空的宝石槽位
                switch (gemHoleID)
                {
                    //紫色宝石
                    case 101:
                        //显示名称
                        string langStr = GameSettingLanguge.LoadLocalization("红色插槽");
                        gemTextObj.GetComponent<Text>().text = langStr;
                        //显示空图标
                        object obj = Resources.Load("GemHoleDi/" + gemHoleID, typeof(Sprite));
                        Sprite itemIcon = obj as Sprite;
                        gemIconObj.GetComponent<Image>().sprite = itemIcon;
                        break;
                    //红色宝石
                    case 102:
                        langStr = GameSettingLanguge.LoadLocalization("紫色插槽");
                        gemTextObj.GetComponent<Text>().text = langStr;
                        //显示空图标
                        obj = Resources.Load("GemHoleDi/" + gemHoleID, typeof(Sprite));
                        itemIcon = obj as Sprite;
                        gemIconObj.GetComponent<Image>().sprite = itemIcon;
                        break;
                    //蓝色宝石
                    case 103:
                        langStr = GameSettingLanguge.LoadLocalization("蓝色插槽");
                        gemTextObj.GetComponent<Text>().text = langStr;
                        //显示空图标
                        obj = Resources.Load("GemHoleDi/" + gemHoleID, typeof(Sprite));
                        itemIcon = obj as Sprite;
                        gemIconObj.GetComponent<Image>().sprite = itemIcon;
                        break;
                    //绿色孔位
                    case 104:
                        langStr = GameSettingLanguge.LoadLocalization("绿色插槽");
                        gemTextObj.GetComponent<Text>().text = langStr;
                        //显示空图标
                        obj = Resources.Load("GemHoleDi/" + gemHoleID, typeof(Sprite));
                        itemIcon = obj as Sprite;
                        gemIconObj.GetComponent<Image>().sprite = itemIcon;
                        break;
                    //白色孔位
                    case 105:
                        langStr = GameSettingLanguge.LoadLocalization("白色插槽");
                        gemTextObj.GetComponent<Text>().text = langStr;
                        //显示空图标
                        obj = Resources.Load("GemHoleDi/" + gemHoleID, typeof(Sprite));
                        itemIcon = obj as Sprite;
                        gemIconObj.GetComponent<Image>().sprite = itemIcon;
                        break;
                    //多彩插槽
                    case 110:
                        langStr = GameSettingLanguge.LoadLocalization("多彩插槽");
                        gemTextObj.GetComponent<Text>().text = langStr;
                        //显示空图标
                        obj = Resources.Load("GemHoleDi/" + gemHoleID, typeof(Sprite));
                        itemIcon = obj as Sprite;
                        gemIconObj.GetComponent<Image>().sprite = itemIcon;
                        break;
                }
            }
        }


        //专精状态
        public static void ZhuanJingStatus(this UIEquipTipsComponent self, int occTwoValue, ItemConfig itemconf, BagInfo baginfo)
        {
            if (occTwoValue != 0)
            {
                if (itemconf.EquipType == 11 || itemconf.EquipType == 12 || itemconf.EquipType == 13 && baginfo.Loc == (int)ItemLocType.ItemLocEquip)
                {
                    self.Obj_ZhuanJingStatusDes.SetActive(true);
                    int selfMastery = OccupationTwoConfigCategory.Instance.Get(occTwoValue).ArmorMastery;
                    if (selfMastery == itemconf.EquipType)
                    {
                        //occShowStr = "         (护甲专精+20%)";
                        self.Obj_ZhuanJingStatusDes.GetComponent<Text>().text = "已激活护甲专精";
                        self.Obj_ZhuanJingStatusDes.GetComponent<Text>().color = new Color(0.52f, 0.75f, 0);
                        self.Obj_ZhuanJingStatusImg.SetActive(true);
                    }
                    else
                    {
                        self.Obj_ZhuanJingStatusDes.GetComponent<Text>().text = "未激活护甲专精";
                        self.Obj_ZhuanJingStatusDes.GetComponent<Text>().color = new Color(0.58f, 0.58f, 0.58f);
                        self.Obj_ZhuanJingStatusImg.SetActive(false);
                    }
                }
            }
            else
            {
                //self.Obj_ZhuanJingStatusDes.SetActive(false);
                //self.Obj_ZhuanJingStatusImg.SetActive(false);
                self.Obj_ZhuanJingStatusDes.GetComponent<Text>().text = "转职后激活护甲专精";
                self.Obj_ZhuanJingStatusDes.GetComponent<Text>().color = new Color(0.58f, 0.58f, 0.58f);
                self.Obj_ZhuanJingStatusImg.SetActive(false);
            }
        }

        //宝石
        public static int ShowGemList(this UIEquipTipsComponent self)
        {
            int gemNumber = 0;
            if (!string.IsNullOrEmpty(self.BagInfo.GemHole))
            {
                string[] gemHoles = self.BagInfo.GemHole.Split('_');
                string[] gemIds = self.BagInfo.GemIDNew.Split('_');
                for (int g = 0; g < self.Obj_UIEquipGemHoleList.Length; g++)
                {
                    self.Obj_UIEquipGemHoleList[g].SetActive(false);
                }
                for (int i = 0; i < gemIds.Length; i++)
                {
                    if (gemHoles.Length <= i || string.IsNullOrEmpty(gemHoles[i]))
                    {
                        continue;
                    }
                    self.Obj_UIEquipGemHoleList[gemNumber].SetActive(gemHoles[i] != "0");
                    UIItemHelp.TipsShowEquipGem(self.ZoneScene(), self.Obj_UIEquipGemHoleIconList[gemNumber], self.Obj_UIEquipGemHoleTextList[gemNumber],
                        int.Parse(gemHoles[gemNumber]), int.Parse(gemIds[gemNumber]));
                    gemNumber += (gemHoles[i] != "0" ? 1 : 0);
                }
            }
            else
            {
                self.Obj_UIEquipGemHoleList[0].SetActive(false);
                self.Obj_UIEquipGemHoleList[1].SetActive(false);
                self.Obj_UIEquipGemHoleList[2].SetActive(false);
                self.Obj_UIEquipGemHoleList[3].SetActive(false);
            }
            return gemNumber;
        }

        //显示专精属性
        public static int ShowZhuanJingAttribute(this UIEquipTipsComponent self, ItemConfig itemconf, float startPostionY)
        {
            int properShowNum = 0;
            if (self.BagInfo.HideProLists != null && self.BagInfo.HideProLists.Count >= 1)
            {
                //统计长度需要在显示属性之前,要不显示属性会将self.properShowNum值累加
                Vector2 hint_vec2 = new Vector2(0, startPostionY);

                foreach (HideProList hide in self.BagInfo.HideProLists)
                {
                    //获取属性名称
                    string proName = UICommonHelper.GetProName(hide.HideID);
                    string proText = proName + "提高" + hide.HideValue + "点";
                    GameObject nowObj = UIItemHelp.ShowPropertyText(proText, "1", self.Obj_EquipPropertyText, self.Obj_EquipZhuanJingSetList);
                    properShowNum += 1;
       
                    //显示职业护甲加成
                    if (itemconf.EquipType == 11 || itemconf.EquipType == 12 || itemconf.EquipType == 13)
                    {
                        int occTwo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.OccTwo;
                        if (occTwo != 0)
                        {
                            int selfMastery = OccupationTwoConfigCategory.Instance.Get(occTwo).ArmorMastery;
                            if (selfMastery != itemconf.EquipType)
                            {
                                //未激活专精的为灰色
                                nowObj.GetComponent<Text>().color = new Color(0.58f, 0.58f, 0.58f);
                            }
                        }
                        else
                        {
                            //未激活专精的为灰色
                            nowObj.GetComponent<Text>().color = new Color(0.58f, 0.58f, 0.58f);
                        }
                    }
                }

                self.Obj_EquiZhuanJing.transform.GetComponent<RectTransform>().anchoredPosition = hint_vec2;
                self.Obj_EquiZhuanJing.SetActive(true);
            }
            return properShowNum;
        }

        public static int ShowHideSkill(this UIEquipTipsComponent self, ItemConfig itemconf, float startPostionY)
        {
            int properShowNum = 0;
            string skillIDStr = itemconf.SkillID;
            if (skillIDStr != "" && skillIDStr != "0" && itemconf.SkillIDIfShow == 0)
            {
                string[] skillID = skillIDStr.Split(',');

                Vector2 hint_vec2 = new Vector2(0f, startPostionY);
                self.Obj_EquipHintSkill.transform.GetComponent<RectTransform>().anchoredPosition = hint_vec2;

                for (int i = 0; i <= skillID.Length - 1; i++)
                {
                    if (skillID[i] == "")
                        continue;

                    SkillConfig skillconf = SkillConfigCategory.Instance.Get(int.Parse(skillID[i]));
                    string skillName = skillconf.SkillName;
                    string showHintTxt = GameSettingLanguge.LoadLocalization("技能") + "：" + skillName;
                    UIItemHelp.ShowPropertyText(showHintTxt, "4", self.Obj_EquipPropertyText, self.Obj_EquipHintSkillSetList);
                    properShowNum += 1;
                }

                self.Obj_EquipHintSkill.SetActive(true);
            }
            else
            {
                self.Obj_EquipHintSkill.SetActive(false);
            }
            return properShowNum;
        }

        //套装信息
        public static int ShowSuitEquipInfo(this UIEquipTipsComponent self, ItemConfig  itemConfig, int equipSuitID, float startPostionY, List<BagInfo> itemList)
        {
            int properShowNum = 0;
            if (equipSuitID != 0)
            {
                Vector2 equipSuit_vec2 = new Vector2(0, startPostionY);
                Log.Info("equipSuit_vec2 = " + equipSuit_vec2);
                self.Obj_UIEquipSuit.transform.GetComponent<RectTransform>().anchoredPosition = equipSuit_vec2;
                self.Obj_UIEquipSuit.SetActive(true);

                EquipSuitConfig equipSuit = EquipSuitConfigCategory.Instance.Get(equipSuitID);

                string equipSuitName = equipSuit.Name;

                string[] needEquipIDSet = equipSuit.NeedEquipID.Split(';');
                //string[] needEquipNumSet = equipSuit.NeedEquipNum.Split(';');
                string[] suitPropertyIDSet = equipSuit.SuitPropertyID.Split(';');

                List<int> itemIDList = new List<int>();
                for (int i = 0; i < itemList.Count; i++)
                {
                    itemIDList.Add(itemList[i].ItemID);
                }

                //获取自身拥有的装备
                int equipSuitNum = 0;
                for (int i = 0; i < needEquipIDSet.Length; i++)
                {
                    if (!ItemConfigCategory.Instance.Contain(int.Parse(needEquipIDSet[i])))
                    {
                        continue;
                    }
                    ItemConfig itemCof = ItemConfigCategory.Instance.Get(int.Parse(needEquipIDSet[i]));
                    string showType = "0";
                    if (itemIDList.Contains(int.Parse(needEquipIDSet[i])))
                    {
                        equipSuitNum = equipSuitNum + 1;
                        showType = "5";
                    }
                    else
                    {
                        showType = "11";
                    }

                    //显示套装名称
                    self.Obj_EquipSuitItemNamePropertyText.GetComponent<Text>().horizontalOverflow = HorizontalWrapMode.Overflow;
                    UIItemHelp.ShowPropertyText(itemCof.ItemName, showType, self.Obj_EquipSuitItemNamePropertyText, self.Obj_EquipSuitShowNameListSet);
                    properShowNum += 0;
                    self.Obj_Lab_EquipSuitShowListSetSuitName.GetComponent<Text>().text = equipSuitName + "(" + equipSuitNum + "/" + needEquipIDSet.Length + ")";
                }

                self.Obj_UIEquipSuitName.GetComponent<Text>().text = equipSuitName + "(" + equipSuitNum + "/" + needEquipIDSet.Length + ")";

                //循环显示数值条
                for (int i = 0; i <= suitPropertyIDSet.Length - 1; i++)
                {
                    string triggerSuitNum = suitPropertyIDSet[i].Split(',')[0];
                    string triggerSuitPropertyID = suitPropertyIDSet[i].Split(',')[1];

                    EquipSuitPropertyConfig equipSuitProperty = EquipSuitPropertyConfigCategory.Instance.Get(int.Parse(triggerSuitPropertyID));
                    if (equipSuitProperty == null)
                    {
                        continue;
                    }
                    string equipSuitDes = equipSuitProperty.EquipSuitDes;
                    string ifShowSuitNum = equipSuitProperty.ifShowSuitNum.ToString();

                    //显示类型
                    string showType = "11";
                    //满足显示为绿色
                    if (equipSuitNum >= int.Parse(triggerSuitNum))
                    {
                        showType = "1";
                    }

                    if (ifShowSuitNum == "0")
                    {
                        string langStr = GameSettingLanguge.LoadLocalization("件套");
                        UIItemHelp.ShowPropertyText(triggerSuitNum + langStr + "：" + equipSuitDes, showType, self.Obj_EquipPropertyText, self.Obj_EquipSuitSetList);
                        properShowNum += 1;
                    }
                }

                self.Obj_UIEquipSuit.SetActive(true);
            }
            else
            {
                self.Obj_UIEquipSuit.SetActive(false);
            }
            return properShowNum;
        }

        //基础信息
        public static void ShowBaseAttribute(this UIEquipTipsComponent self)
        {
            ItemConfig itemconf = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
            EquipConfig equipconf = EquipConfigCategory.Instance.Get(itemconf.ItemEquipID);
            string ItemIcon = itemconf.Icon;
            int ItemQuality = itemconf.ItemQuality;
            string equip_ID = itemconf.ItemEquipID.ToString();
            string equipName = itemconf.ItemName;
            string equipLv = itemconf.UseLv.ToString();
            string ItemBlackDes = itemconf.ItemDes;
            string textEquipType = "";
            string textEquipTypeSon = "";
            textEquipType = UIItemHelp.GetItemSubType3Name(itemconf.ItemSubType);
            textEquipTypeSon = self.GetEquipType(itemconf.EquipType);
            textEquipType = GameSettingLanguge.LoadLocalization(textEquipType);

            //生肖处理
            if (itemconf.EquipType == 101) {
                textEquipType = self.GetEquipShengXiaoType(itemconf.ItemSubType%100);
                textEquipTypeSon = GameSettingLanguge.LoadLocalization("生肖");
            }

            string langStr = GameSettingLanguge.LoadLocalization("强化");
            int qianghuaLevel = self.BagComponent.GetQiangHuaLevel(itemconf.ItemSubType);
            if (qianghuaLevel != 0)
            {
                //EquipQiangHuaConfig equipQiangHua = EquipQiangHuaConfigCategory.Instance.Get(self.EquipQiangHuaID);
                //float equipPropreAdd = float.Parse(equipQiangHua.EquipPropreAdd);
                //string qiangHuaLv = equipQiangHua.QiangHuaLv.ToString();
                self.Obj_Lab_EquipQiangHua.GetComponent<Text>().text = "+" + qianghuaLevel + langStr;
            }
            else
            {
                self.Obj_Lab_EquipQiangHua.GetComponent<Text>().text = "+" + 0 + langStr;
            }

            //生效不显示
            if (itemconf.ItemType == 3 && itemconf.EquipType == 101) {
                self.Obj_Lab_EquipQiangHua.SetActive(false);
            }


            //显示是否绑定
            if (self.BagInfo.isBinging)
            {
                self.Obj_Lab_EquipBangDing.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("已绑定");
                self.Obj_Lab_EquipBangDing.GetComponent<Text>().color = new Color(175f / 255f, 1, 6f / 255f);
                self.Obj_Img_EquipBangDing.SetActive(true);
            }
            else
            {
                self.Obj_Lab_EquipBangDing.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("未绑定");
                self.Obj_Lab_EquipBangDing.GetComponent<Text>().color = new Color(255 / 255, 240f / 255f, 200f / 255f);
                self.Obj_Img_EquipBangDing.SetActive(false);
            }

            self.Obj_EquipIcon.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, ItemIcon);
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(ItemQuality);
            Log.Info("qualityiconStr = " + qualityiconStr);
            self.Obj_EquipQuality.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconStr);

            //显示基础信息
            self.Obj_EquipName.GetComponent<Text>().text = equipName;
            self.Obj_EquipName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(ItemQuality);
            //self.Lab_EquipType.GetComponent<Text>().text = "类型" + " : " + textEquipType;
            float exceedWidth = self.Obj_EquipName.GetComponent<Text>().preferredWidth - self.Lab_ItemNameWidth;
            if (exceedWidth > 0)
            {
                self.Img_back.GetComponent<RectTransform>().sizeDelta = new Vector2(self.Img_backVector2.x + exceedWidth, self.Img_backVector2.y);
            }

            langStr = GameSettingLanguge.LoadLocalization("部位");
            self.Lab_EquipType.GetComponent<Text>().text = langStr + ":" + textEquipType;
            langStr = GameSettingLanguge.LoadLocalization("类型");
            self.Obj_EquipTypeSon.GetComponent<Text>().text = langStr + ":" + textEquipTypeSon;

            int occTwo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.OccTwo;
            if (occTwo != 0)
            {
                OccupationTwoConfig occupationTwo = OccupationTwoConfigCategory.Instance.Get(occTwo);
                if (itemconf.EquipType != 0 && itemconf.EquipType != occupationTwo.ArmorMastery)
                {
                    self.Obj_EquipTypeSon.GetComponent<Text>().color = new Color(248f / 255f, 148f / 255f, 148f / 255f);
                    //self.Obj_EquipTypeSon.GetComponent<Text>().text = self.Obj_EquipTypeSon.GetComponent<Text>().text + "(类型不符)";
                }
            }
            langStr = GameSettingLanguge.LoadLocalization("等级");
            self.Obj_EquipWearNeed.GetComponent<Text>().text = langStr + " : " + equipLv;

            if (int.Parse(equipLv) > self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv)
            {
                self.Obj_EquipWearNeed.GetComponent<Text>().text = langStr + " : " + equipLv + " (等级不足)";
                self.Obj_EquipWearNeed.GetComponent<Text>().color = new Color(255f / 255f, 200f / 255f, 200f / 255f);
            }

            string propertyLimit = ""; /// itemconf.PropertyLimit;
            string[] needProperty = propertyLimit.Split(',');
            if (needProperty[0] != "" && needProperty[0] != "0")
            {
                string propertyName = FunctionUI.GetInstance().ReturnEquipNeedPropertyName(needProperty[0]);
                string langStr_1 = GameSettingLanguge.LoadLocalization("需要");
                string langStr_2 = GameSettingLanguge.LoadLocalization("达到");
                string langStr_4 = GameSettingLanguge.LoadLocalization(propertyName);
                self.Obj_EquipWearNeedProperty.GetComponent<Text>().text = langStr_1 + langStr_4 + langStr_2 + " ： " + needProperty[1];

                switch (needProperty[0])
                {
                    case "1":
                        int value = 0;
                        if (value < int.Parse(needProperty[1]))
                        {
                            //Obj_EquipWearNeedProperty.GetComponent<Text>().color = Color.red;
                            string langStr_3 = GameSettingLanguge.LoadLocalization("攻击力不足");
                            self.Obj_EquipWearNeedProperty.GetComponent<Text>().text = langStr_1 + langStr_4 + langStr_2 + " ：" + needProperty[1] + "<color=#ff0000ff>  (" + langStr_3 + ")</color>";
                        }
                        break;
                }

                self.Obj_EquipWearNeedProperty.SetActive(true);
            }
            else
            {
                self.Obj_EquipWearNeedProperty.SetActive(false);
            }

            int ItemBlackNum = 0;
            //Debug.Log("ItemBlackDes = " + ItemBlackDes);
            if (ItemBlackDes != "0" && ItemBlackDes != "")
            {
                ItemBlackNum = (int)((ItemBlackDes.Length - 16) / 16) + 1;
            }
            else
            {
                self.Obj_EquipBottom.SetActive(false);
            }
            if (ItemBlackDes.Length > 32)
            {
                ItemBlackNum = (int)((ItemBlackDes.Length - 32) / 16) + 1;
                self.Obj_EquipDes.GetComponent<RectTransform>().sizeDelta = new Vector2(240.0f, 40.0f + 16.0f * ItemBlackNum);
                self.Obj_EquipDes.GetComponent<Text>().text = ItemBlackDes;
            }

            //显示制造方
            if (self.BagInfo.MakePlayer != "" && self.BagInfo.MakePlayer != null)
            {
                self.Obj_Lab_EquipMake.GetComponent<Text>().text = $"由<color=#805100>{self.BagInfo.MakePlayer}</color>打造";
            }
            else {
                self.Obj_Lab_EquipMake.GetComponent<Text>().text = "";
            }
        }

        public static void ShowButton(this UIEquipTipsComponent self)
        {
            self.Obj_BagOpenSet.SetActive(false);
            self.Obj_RoseEquipOpenSet.SetActive(false);
            self.Obj_Btn_StoreHouseSet.SetActive(false);
            self.Obj_SaveStoreHouse.SetActive(false);
            self.Obj_Btn_HuiShou.SetActive(false);
            self.Obj_Btn_HuiShouCancle.SetActive(false);
            switch (self.EquipTipsType)
            {
                case ItemOperateEnum.None:
                case ItemOperateEnum.PaiMaiSell:
                case ItemOperateEnum.PetHeXinBag:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_StoreHouseSet.SetActive(false);
                    self.Obj_SaveStoreHouse.SetActive(false);
                    break;
                case ItemOperateEnum.Bag:
                    self.Obj_BagOpenSet.SetActive(true);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_StoreHouseSet.SetActive(false);
                    bool StoreHouseStatus = false;
                    if (StoreHouseStatus)
                    {
                        self.Obj_SaveStoreHouse.SetActive(true);
                        self.Obj_Diu.SetActive(false);
                    }
                    else
                    {
                        self.Obj_SaveStoreHouse.SetActive(false);
                        self.Obj_Diu.SetActive(true);
                    }
                    break;
                case ItemOperateEnum.XiangQianBag:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_StoreHouseSet.SetActive(false);
                    break;
                case ItemOperateEnum.Juese:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(true);
                    self.Obj_Btn_StoreHouseSet.SetActive(false);
                    break;
                case ItemOperateEnum.Shop:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_StoreHouseSet.SetActive(false);
                    break;
                case ItemOperateEnum.Cangku:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_StoreHouseSet.SetActive(true);
                    break;
                case ItemOperateEnum.CangkuBag:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_HuiShouCancle.SetActive(false);
                    self.Obj_SaveStoreHouse.SetActive(true);
                    self.Obj_Btn_StoreHouseSet.SetActive(false);
                    break;
                case ItemOperateEnum.MailReward:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_HuiShouCancle.SetActive(false);
                    self.Obj_SaveStoreHouse.SetActive(false);
                    break;
                case ItemOperateEnum.Watch:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_StoreHouseSet.SetActive(false);
                    self.Obj_SaveStoreHouse.SetActive(false);
                    break;
                case ItemOperateEnum.HuishouBag:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_StoreHouseSet.SetActive(false);
                    self.Obj_SaveStoreHouse.SetActive(false);
                    self.Obj_Diu.SetActive(false);
                    self.Obj_Btn_HuiShou.SetActive(true);
                    break;
                case ItemOperateEnum.HuishouShow:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_StoreHouseSet.SetActive(false);
                    self.Obj_SaveStoreHouse.SetActive(false);
                    self.Obj_Btn_HuiShouCancle.SetActive(true);
                    break;
                case ItemOperateEnum.MakeItem:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_RoseEquipOpenSet.SetActive(false);
                    self.Obj_Btn_StoreHouseSet.SetActive(false);
                    self.Obj_Btn_HuiShouCancle.SetActive(false);
                    break;
            }

        }


        public static void InitData(this UIEquipTipsComponent self, BagInfo baginfo, ItemOperateEnum equipTipsType, int occTwoValue, List<BagInfo> equipItemList)
        {
            //初始化值
            self.BagInfo = baginfo;
            self.EquipTipsType = equipTipsType;
            ItemConfig itemconf = ItemConfigCategory.Instance.Get(baginfo.ItemID);
            EquipConfig equipconf = EquipConfigCategory.Instance.Get(itemconf.ItemEquipID);
            string qualityiconLine = FunctionUI.GetInstance().ItemQualityLine(itemconf.ItemQuality);
            self.ImageQualityLine.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconLine);
            string qualityiconBack = FunctionUI.GetInstance().ItemQualityBack(itemconf.ItemQuality);
            self.ImageQualityBg.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconBack);
            self.ShowBaseAttribute();
            self.ZhuanJingStatus(occTwoValue, itemconf, baginfo);
            self.ShowButton();

            //基础属性  专精属性  隐藏技能  套装属性
            //基础属性
            int properShowNum = UIItemHelp.ShowBaseAttribute(baginfo, self.Obj_EquipPropertyText, self.EquipBaseSetList) ;

            //显示宝石
            float startPostionY = 0 - self.TitleBigHeight_160 - self.TitleMiniHeight_50 - self.TextItemHeight_40 * properShowNum;
            Vector2 equipNeedvec2 = new Vector2(155.5f, startPostionY);
            self.Obj_UIEquipGemHoleSet.transform.GetComponent<RectTransform>().anchoredPosition = equipNeedvec2;
            float gemHoleShowHeight = self.ShowGemList() * 35f;

            //显示专精属性
            startPostionY -= gemHoleShowHeight;
            startPostionY -= 5;
            int zhunjingNumber = self.ShowZhuanJingAttribute(itemconf, startPostionY);

            //显示隐藏技能
            //float HintTextNum = 50;
            startPostionY -= (zhunjingNumber > 0 ? self.TitleMiniHeight_50 : 0);
            startPostionY = startPostionY  - zhunjingNumber * self.TextItemHeight_40;
            startPostionY -= 5;
            int hideSkillNumber = self.ShowHideSkill(itemconf, startPostionY);

            //显示装备套装信息
            //float equipSuitTextNum = 0;
            startPostionY -= (hideSkillNumber > 0 ? self.TitleMiniHeight_50 : 0);
            startPostionY -= hideSkillNumber * self.TextItemHeight_40;

            int suitEquipNumber = self.ShowSuitEquipInfo(itemconf, equipconf.EquipSuitID, startPostionY, equipItemList);
            suitEquipNumber = suitEquipNumber + (suitEquipNumber > 0 ? 2 : 0);
            startPostionY = startPostionY - self.TitleMiniHeight_50 - suitEquipNumber * self.TextItemHeight_40 ;
            startPostionY -= 5;

            float DiHight = startPostionY * -1 + 70;
            if (DiHight > self.Img_backVector2.y)
            {
                self.Img_back.GetComponent<RectTransform>().sizeDelta = new Vector2(self.Img_backVector2.x, DiHight);
            }
            if (DiHight > 1150)
            {
                float height = (DiHight - 1098f) * 0.5f;
                self.Obj_BtnSet.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, height);
            }
            else
            {
                self.Obj_BtnSet.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            }

            //显示装备制造者的名字[名字直接放入baginfo]
        }

        //获取装备子类型名称
        public static string GetEquipType(this UIEquipTipsComponent self, int type) {

            switch (type)
            {
                case 0:
                    return "首饰";

                case 1:
                    return "剑";

                case 2:
                    return "刀";

                case 3:
                    return "法杖";

                case 4:
                    return "魔法书";

                case 11:
                    return "布甲";

                case 12:
                    return "轻甲";

                case 13:
                    return "重甲";

                case 99:
                    return "无限制";
            }

            return "";
        }

        //获取装备子类型名称
        public static string GetEquipShengXiaoType(this UIEquipTipsComponent self, int type)
        {

            switch (type)
            {

                case 1:
                    return "鼠";

                case 2:
                    return "牛";

                case 3:
                    return "虎";

                case 4:
                    return "兔";

                case 5:
                    return "龙";

                case 6:
                    return "蛇";

                case 7:
                    return "马";

                case 8:
                    return "羊";

                case 9:
                    return "猴";

                case 10:
                    return "鸡";

                case 11:
                    return "狗";

                case 12:
                    return "猪";
            }

            return "";
        }

    }

}
