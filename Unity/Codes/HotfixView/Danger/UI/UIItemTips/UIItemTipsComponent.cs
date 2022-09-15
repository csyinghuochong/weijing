using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIItemTipsComponent : Entity, IAwake
    {

        public GameObject ImageQualityLine;
        public GameObject ImageQualityBg;
        public GameObject TextBtn_Use;
        public GameObject Obj_ItemQuality;
        public GameObject Obj_ItemIcon;
        public GameObject Lab_ItemName;
        public GameObject ItemDes;
        public GameObject ItemItemLv;
        public GameObject ItemType;
        public GameObject Img_back;
        public GameObject Obj_BagOpenSet;
        public GameObject Obj_Diu;
        public GameObject Obj_Btn_GemHoleText;
        public GameObject Obj_Btn_HuiShou;
        public GameObject Obj_Btn_HuiShouCancle;
        public GameObject Obj_Btn_XieXiaGemSet;
        public GameObject selPastureItemUICommonHint;
        public GameObject Obj_Lab_EquipBangDing;
        public GameObject Obj_Img_EquipBangDing;

        public GameObject Imagebg;

        public ItemOperateEnum EquipTipsType;               //操作类型
        public BagInfo BagInfo;

        //按钮相关
        public GameObject Btn_Sell;
        public GameObject Btn_Use;

        public GameObject Btn_StoreHouse;    //放入仓库
        public GameObject Btn_PutBag;           //放入背包
        public BagComponent BagComponent;

        public Vector2 Img_backVector2;
        public float Lab_ItemNameWidth;
    }

    [ObjectSystem]
    public class UIItemTipsComponentAwakeSystem : AwakeSystem<UIItemTipsComponent>
    {
        public override void Awake(UIItemTipsComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageQualityLine = rc.Get<GameObject>("ImageQualityLine");
            self.ImageQualityBg = rc.Get<GameObject>("ImageQulityBg");
            self.TextBtn_Use = rc.Get<GameObject>("TextBtn_Use");
            self.Obj_Btn_XieXiaGemSet = rc.Get<GameObject>("Btn_XieXiaGem");
            self.Obj_Btn_HuiShouCancle = rc.Get<GameObject>("Btn_HuiShouCancle");
            self.Obj_Btn_HuiShou = rc.Get<GameObject>("Btn_HuiShou");
            self.Obj_Diu = rc.Get<GameObject>("Btn_Diu");
            self.ItemType = rc.Get<GameObject>("Lab_ItemType");
            self.ItemItemLv = rc.Get<GameObject>("Lab_ItemLv");
            self.ItemDes = rc.Get<GameObject>("Lab_ItemDes");
            self.Lab_ItemName = rc.Get<GameObject>("Lab_ItemName");
            self.Lab_ItemNameWidth = self.Lab_ItemName.GetComponent<RectTransform>().sizeDelta.x;
            self.Obj_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");
            self.Obj_ItemQuality = rc.Get<GameObject>("Image_ItemQuality");
            self.Imagebg = rc.Get<GameObject>("Imagebg");
            self.Obj_BagOpenSet = rc.Get<GameObject>("BagOpenSet");
            self.Img_back = rc.Get<GameObject>("Img_back");
            self.Img_backVector2 = self.Img_back.GetComponent<RectTransform>().sizeDelta;

            self.Btn_Use = rc.Get<GameObject>("Btn_Use");
            self.Btn_Sell = rc.Get<GameObject>("Btn_Sell");
            self.Obj_Lab_EquipBangDing = rc.Get<GameObject>("Lab_BangDing");
            self.Obj_Img_EquipBangDing = rc.Get<GameObject>("Img_BangDing");

            self.Imagebg.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseTips(); });
            self.Btn_Sell.GetComponent<Button>().onClick.AddListener(() => { self.OnClickSell(); });
            self.Btn_Use.GetComponent<Button>().onClick.AddListener(() => { self.OnClickUse().Coroutine(); });

            self.Btn_StoreHouse = rc.Get<GameObject>("Btn_StoreHouse");
            self.Btn_StoreHouse.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_StoreHouse(); });
            self.Btn_StoreHouse.SetActive(false);

            self.Btn_PutBag = rc.Get<GameObject>("Btn_PutBag");
            self.Btn_PutBag.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_PutBag(); });
            self.Btn_PutBag.SetActive(false);

            self.Obj_Btn_HuiShouCancle.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_HuiShouCancle(); });
            self.Obj_Btn_HuiShou.GetComponent<Button>().onClick.AddListener(() => { self.On_Btn_HuiShou(); });
            self.Obj_Btn_XieXiaGemSet.GetComponent<Button>().onClick.AddListener(() => { self.On_Btn_XieXiaGemSet(); });
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
        }
    }

    public static class UIItemTipsComponentSystem
    {
        public static void On_Btn_HuiShou(this UIItemTipsComponent self)
        {
            self.BagComponent.HuiShouSelect = self.BagInfo;
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, "1");
            self.OnCloseTips();
        }

        public static void OnBtn_HuiShouCancle(this UIItemTipsComponent self)
        {
            self.BagComponent.HuiShouSelect = self.BagInfo;
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, "0");
            self.OnCloseTips();
        }

        //卸下宝石
        public static void On_Btn_XieXiaGemSet(this UIItemTipsComponent self)
        {
            UI uiRole = UIHelper.GetUI(self.ZoneScene(), UIType.UIRole);
            if (uiRole == null)
            {
                return;
            }
            UIRoleComponent uIRoleComponent = uiRole.GetComponent<UIRoleComponent>();
            UIRoleGemComponent uIRoleGemComponent = uIRoleComponent.UIPageView.UISubViewList[(int)RolePageEnum.RoleGem].GetComponent<UIRoleGemComponent>();
            if (uIRoleGemComponent.XiangQianItem == null)
            {
                return;
            }
            string usrPar = $"{uIRoleGemComponent.XiangQianItem.BagInfoID}_{uIRoleGemComponent.XiangQianIndex}";
            self.BagComponent.SendXieXiaGem(self.BagInfo, usrPar).Coroutine();

            self.OnCloseTips();
        }

        //放入仓库
        public static void OnBtn_StoreHouse(this UIItemTipsComponent self)
        {
            self.BagComponent.SendPutStoreHouse(self.BagInfo).Coroutine();

            self.OnCloseTips();
        }

        //放入仓库
        public static void OnBtn_PutStoreHouse(this UIItemTipsComponent self)
        {
            self.BagComponent.SendPutStoreHouse(self.BagInfo).Coroutine();

            self.OnCloseTips();
        }

        //放入背包
        public static void OnBtn_PutBag(this UIItemTipsComponent self)
        {
            self.BagComponent.SendPutBag(self.BagInfo).Coroutine();

            self.OnCloseTips();
        }


        public static void Awake(this UIItemTipsComponent self)
        {

        }

        //点击Tips
        public static void OnCloseTips(this UIItemTipsComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIItemTips).Coroutine();
        }

        //出售道具
        public static void OnClickSell(this UIItemTipsComponent self)
        {
            //发送消息
            if (ItemConfigCategory.Instance.Get(self.BagInfo.ItemID).ItemQuality >= 4)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "出售道具", "是否出售道具:" + itemConfig.ItemName, () =>
                {
                    self.ZoneScene().GetComponent<BagComponent>().SendSellItem(self.BagInfo).Coroutine();
                    FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("道具出售完成!"));
                    self.OnCloseTips();
                }).Coroutine();
            }
            else
            {
                self.ZoneScene().GetComponent<BagComponent>().SendSellItem(self.BagInfo).Coroutine();
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("道具出售完成!"));
                self.OnCloseTips();
            }
        }

        //使用道具
        public static async ETTask OnClickUse(this UIItemTipsComponent self)
        {
            //发送消息
            Log.ILog.Info("我点击了道具使用..");
            //判断当前技能是否再CD状态
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
            int errorCode = ErrorCore.ERR_Success;
            string usrPar = "";

            //镶嵌宝石
            if (itemConfig.ItemType == (int)ItemTypeEnum.Gemstone)
            {
                UI uiRole = UIHelper.GetUI(self.ZoneScene(), UIType.UIRole);
                if (uiRole == null)
                {
                    return;
                }
                UIRoleComponent uIRoleComponent = uiRole.GetComponent<UIRoleComponent>();
                if (uIRoleComponent.UIPageButton.CurrentIndex != (int)RolePageEnum.RoleGem)
                {
                    uIRoleComponent.UIPageButton.OnSelectIndex((int)RolePageEnum.RoleGem);
                    return;
                }
                UIRoleGemComponent uIRoleGemComponent = uIRoleComponent.UIPageView.UISubViewList[(int)RolePageEnum.RoleGem].GetComponent<UIRoleGemComponent>();
                if (uIRoleGemComponent.XiangQianItem == null)
                {
                    FloatTipManager.Instance.ShowFloatTip("请选择装备！");
                    return;
                }
                string gemHole = uIRoleGemComponent.XiangQianItem.GemHole;
                if (uIRoleGemComponent.XiangQianIndex == -1)
                {
                    FloatTipManager.Instance.ShowFloatTip("请选择孔位！");
                    return;
                }
                string itemgem = gemHole.Split('_')[uIRoleGemComponent.XiangQianIndex];
                if (itemgem != itemConfig.ItemSubType.ToString())
                {
                    FloatTipManager.Instance.ShowFloatTip("宝石与孔位不符！");
                    return;
                }
                usrPar = $"{uIRoleGemComponent.XiangQianItem.BagInfoID}_{uIRoleGemComponent.XiangQianIndex}";
                errorCode = await self.ZoneScene().GetComponent<BagComponent>().SendXiangQianGem(self.BagInfo, usrPar);
                //注销Tips
                self.OnCloseTips();
                return;
            }
            if (itemConfig.ItemType == (int)ItemTypeEnum.PetHeXin)
            {
                UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
                errorCode = await uI.GetComponent<UIPetComponent>().RequestPetHeXinSelect();
                //注销Tips
                if (errorCode == ErrorCore.ERR_Success)
                {
                    self.OnCloseTips();
                }
                return;
            }

            if (itemConfig.ItemSubType == 4 || itemConfig.ItemSubType == 14)
            {
                if (self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum != (int)SceneTypeEnum.LocalDungeon)
                {
                    FloatTipManager.Instance.ShowFloatTip("副本中才能使用!");
                    return;
                }
            }
            if (itemConfig.ItemSubType == 5)
            {
                UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UITuZhiMake);
                uI.GetComponent<UITuZhiMakeComponent>().OnInitUI(self.BagInfo).Coroutine();
                self.OnCloseTips();
                return;
            }
            if (itemConfig.ItemSubType == 101 && itemConfig.ItemUsePar != "0" && itemConfig.ItemUsePar != "")
            {
                if (UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<SkillManagerComponent>().CanUseSkill(int.Parse(itemConfig.ItemUsePar)) != 0)
                {
                    FloatTipManager.Instance.ShowFloatTip("技能冷却中!");
                    return;
                }
            }
            if (itemConfig.ItemSubType == 102 || itemConfig.ItemSubType == 103)
            {
                FloatTipManager.Instance.ShowFloatTip("请前往主成的宠物蛋孵化处!");
                return;
            }
            if (itemConfig.ItemSubType == 112)
            {
                UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIItemExpBox);
                uI.GetComponent<UIItemExpBoxComponent>().OnInitUI(self.BagInfo);
                self.OnCloseTips();
                return;
            }
            if (itemConfig.ItemSubType == 113)
            {
                int curSceneId = 0;
                int needSceneId = int.Parse(self.BagInfo.ItemPar.Split('@')[0]);
                MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                {
                    curSceneId = mapComponent.SceneId;
                }
                if (curSceneId != needSceneId)
                {
                    string fubenName = DungeonConfigCategory.Instance.Get(needSceneId).ChapterName;
                    FloatTipManager.Instance.ShowFloatTip($"请前往{fubenName}");
                    return;
                }
                else
                {
                    Scene zoneScene = self.ZoneScene();
                    string path = $"ScenceRosePositionSet/{self.BagInfo.ItemPar.Split('@')[1]}";
                    GameObject gameObject = GameObject.Find(path);
                    EventType.DigForTreasure.Instance.BagInfo = self.BagInfo;
                    EventType.DigForTreasure.Instance.ZoneScene = self.ZoneScene();
                    Game.EventSystem.PublishClass(EventType.DigForTreasure.Instance);
                    UIHelper.Remove(zoneScene, UIType.UIRole).Coroutine();
                    self.OnCloseTips();
                    return;
                    //if (gameObject == null)
                    //{
                    //    return;
                    //}
                    //Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
                    //int ret = await unit.MoveToAsync2(gameObject.transform.position);
                    //if (ret == 0 && Vector3.Distance(gameObject.transform.position, unit.Position) < 0.2f)
                    //{
                    //    EventType.DigForTreasure.Instance.BagInfo = self.BagInfo;
                    //    EventType.DigForTreasure.Instance.ZoneScene = self.ZoneScene();
                    //    Game.EventSystem.PublishClass(EventType.DigForTreasure.Instance);
                    //}
                    //return;
                }
            }
            if (itemConfig.ItemSubType == 108
                || itemConfig.ItemSubType == 109
                || itemConfig.ItemSubType == 117
                || itemConfig.ItemSubType == 118
                || itemConfig.ItemSubType == 119)
            {
                PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
                RolePetInfo petInfo = petComponent.GetFightPetInfo();
                if ((itemConfig.ItemSubType == 108
                || itemConfig.ItemSubType == 109) && petInfo != null)
                {
                    petComponent.RequestXiLian(self.BagInfo.BagInfoID, petInfo.Id).Coroutine();
                    self.OnCloseTips();
                    return;
                }
                FloatTipManager.Instance.ShowFloatTip("请前往宠物重塑界面使用！");
                return;
            }

            errorCode = await self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.BagInfo, usrPar);
            if (errorCode == ErrorCore.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTipDi(GameSettingLanguge.LoadLocalization("道具使用成功!"));
            }
            if (errorCode == ErrorCore.ERR_ItemOnlyUseOcc)
            {
                OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(itemConfig.UseOcc);
                string tip = string.Format(ErrorHelp.Instance.GetHint(ErrorCore.ERR_ItemOnlyUseOcc), occupationConfig.OccupationName);
                FloatTipManager.Instance.ShowFloatTipDi(GameSettingLanguge.LoadLocalization(tip));
            }
            //注销Tips
            self.OnCloseTips();
        }

        public static void InitData(this UIItemTipsComponent self, BagInfo baginfo, ItemOperateEnum equipTipsType, Action handler = null)
        {
            self.BagInfo = baginfo;
            ItemConfig itemconf = ItemConfigCategory.Instance.Get(baginfo.ItemID);

            int itemType = itemconf.ItemType;
            int itemSubType = itemconf.ItemSubType;

            string qualityiconLine = FunctionUI.GetInstance().ItemQualityLine(itemconf.ItemQuality);
            self.ImageQualityLine.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconLine);
            string qualityiconBack = FunctionUI.GetInstance().ItemQualityBack(itemconf.ItemQuality);
            self.ImageQualityBg.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconBack);

            //类型描述
            string itemTypename = "消耗品";
            ItemViewHelp.ItemTypeName.TryGetValue((ItemTypeEnum)itemType, out itemTypename);
            self.ItemType.GetComponent<Text>().text = "类型:" + itemTypename;

            string Text_ItemDes = itemconf.ItemDes;
            //获取道具描述的分隔符
            string[] itemDesArray = Text_ItemDes.Split(';');
            string itemMiaoShu = "";
            for (int i = 0; i <= itemDesArray.Length - 1; i++)
            {
                if (itemMiaoShu == "")
                {
                    itemMiaoShu = itemDesArray[i];
                }
                else
                {
                    itemMiaoShu = itemMiaoShu + "\n" + itemDesArray[i];
                }
            }

            //显示是否绑定
            if (baginfo.isBinging)
            {
                self.Obj_Lab_EquipBangDing.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("已绑定");
                self.Obj_Lab_EquipBangDing.GetComponent<Text>().color = new Color(175f / 255f, 1, 6f / 255f);
                self.Obj_Img_EquipBangDing.SetActive(true);
            }
            else
            {
                self.Obj_Lab_EquipBangDing.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("未绑定");
                self.Obj_Lab_EquipBangDing.GetComponent<Text>().color = new Color(255f / 255f, 240f / 255f, 200f / 255f);
                self.Obj_Img_EquipBangDing.SetActive(false);
            }

            //数组大于2表示有换行符,否则显示原来的描述
            if (itemDesArray.Length >= 2)
            {
                Text_ItemDes = itemMiaoShu;
            }

            //根据Tips描述长度缩放底的大小
            int i1 = 0;
            Text_ItemDes = ItemViewHelp.GetItemDesc(baginfo, ref i1);
            //赞助宝箱设置描述为绿色
            if (itemSubType == 9)
            {
                self.ItemDes.GetComponent<Text>().color = Color.green;
            }

            //显示图标
            //显示道具Icon
            string ItemIcon = itemconf.Icon;
            self.Obj_ItemIcon.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, ItemIcon);

            string ItemQuality = FunctionUI.GetInstance().ItemQualiytoPath(itemconf.ItemQuality);
            self.Obj_ItemQuality.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, ItemQuality);

            string Text_ItemStory = itemconf.ItemDes;
            //显示道具描述
            int i2 = (int)((Text_ItemStory.Length) / 20) + 1;
            //float ItemBottomTextNum = 30.0f;
            self.TextBtn_Use.GetComponent<Text>().text = itemconf.ItemSubType == 114 ? "镶嵌" : "使用";
            self.Obj_BagOpenSet.SetActive(false);
            self.Obj_Btn_HuiShou.SetActive(false);
            self.Obj_Btn_HuiShouCancle.SetActive(false);
            self.Obj_Btn_XieXiaGemSet.SetActive(false);

            //显示按钮
            switch ((ItemOperateEnum)equipTipsType)
            {
                //不显示任何按钮
                case ItemOperateEnum.None:
                case ItemOperateEnum.PaiMaiSell:
                    //ItemBottomTextNum = 0;
                    break;
                //背包打开显示对应功能按钮
                case ItemOperateEnum.Bag:
                    self.Obj_BagOpenSet.SetActive(true);
                    //判定当前是否打开仓库
                    self.Obj_Diu.SetActive(true);
                    break;
                //角色栏打开显示对应功能按钮
                case ItemOperateEnum.Juese:
                    self.Obj_BagOpenSet.SetActive(true);
                    break;
                //商店查看属性
                case ItemOperateEnum.Shop:
                    self.Obj_BagOpenSet.SetActive(false);
                    //ItemBottomTextNum = 0;
                    break;
                //仓库查看属性
                case ItemOperateEnum.Cangku:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Btn_PutBag.SetActive(true);
                    //ItemBottomTextNum = 0;
                    break;
                case ItemOperateEnum.CangkuBag:
                    self.Btn_StoreHouse.SetActive(true);
                    break;
                //回收背包打开
                case ItemOperateEnum.HuishouBag:
                    self.Obj_BagOpenSet.SetActive(true);
                    self.Obj_Btn_HuiShou.SetActive(true);
                    break;
                //回收功能显示
                case ItemOperateEnum.HuishouShow:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_Btn_HuiShouCancle.SetActive(true);
                    break;
                //牧场  不显示任何按钮
                case ItemOperateEnum.Muchang:
                    //ItemBottomTextNum = 0;
                    break;
                //牧场仓库  显示出售按钮
                case ItemOperateEnum.MuchangCangku:
                    self.Obj_BagOpenSet.SetActive(true);
                    self.Obj_Diu.SetActive(true);
                    break;
                //镶嵌背包切页
                case ItemOperateEnum.XiangQianBag:
                    self.Obj_BagOpenSet.SetActive(true);
                    break;
                //镶嵌在装备上的宝石
                case ItemOperateEnum.XiangQianGem:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Obj_Btn_XieXiaGemSet.SetActive(true);
                    break;
                case ItemOperateEnum.PetHeXinBag:
                    self.Obj_BagOpenSet.SetActive(true);
                    self.Btn_Use.transform.Find("TextBtn_Use").GetComponent<Text>().text = "装备";
                    break;
                default:
                    //ItemBottomTextNum = 0;
                    break;
            }

            //判定道具为宝石时显示使用变为镶嵌字样
            if (itemType == 4)
            {
                string langStr_A = GameSettingLanguge.LoadLocalization("镶 嵌");
                //self.Obj_Btn_GemHoleText.GetComponent<Text>().text = langStr_A;
            }

            //设置底的长度
            //self.ItemDi.GetComponent<RectTransform>().sizeDelta = new Vector2(301.0f, 180.0f + i1 * 20.0f + i2 * 16.0f + ItemBottomTextNum);
            //显示道具信息
            self.Lab_ItemName.GetComponent<Text>().text = itemconf.ItemName + "_" + itemconf.ItemName;
            self.Lab_ItemName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemconf.ItemQuality);
            self.ItemDes.GetComponent<Text>().text = Text_ItemDes;
            float exceedWidth = self.Lab_ItemName.GetComponent<Text>().preferredWidth - self.Lab_ItemNameWidth;
            Log.ILog.Debug($"exceedWidth  {exceedWidth}");
            if (exceedWidth > 0)
            {
                self.Img_back.GetComponent<RectTransform>().sizeDelta = new Vector2(self.Img_backVector2.x + exceedWidth, self.Img_backVector2.y);
            }

            if (itemconf.ItemSubType == 121)
            {
                self.ItemDes.GetComponent<Text>().text = Text_ItemDes + "\n" + "\n" + $"鉴定符品质:{baginfo.ItemPar}" + "\n" + "品质越高,鉴定出极品的概率越高。";
            }

            string langStr = GameSettingLanguge.LoadLocalization("使用等级");
            if (itemconf.UseLv > 0)
            {
                self.ItemItemLv.GetComponent<Text>().text = langStr + ":" + itemconf.UseLv;
            }
            else
            {
                self.ItemItemLv.GetComponent<Text>().text = langStr + ":1";
            }

            //监测UI是否超过底部显示
            /*
            float DiHight = self.ItemDi.GetComponent<RectTransform>().sizeDelta.y;
            Debug.Log("DiHight = " + DiHight);
            float screen_higeValue = 768 * FunctionUI.GetInstance().ReturnScreenScalePro();
            float UIHeadValue = screen_higeValue - self.GetParent<UI>().GameObject.transform.localPosition.y - DiHight / 2;            //UI�Ͷ����ľ���
            float UIHightValue = UIHeadValue + DiHight + 50.0f;

            if (UIHightValue >= screen_higeValue)
            {
                ////////////this.transform.localPosition = new Vector3(this.transform.localPosition.x, 50 + DiHight / 2, 0);
            }
            //���UI�Ƿ񳬹��˶�����ʾ
            if (UIHeadValue <= 30)
            {
                ////////////this.transform.localPosition = new Vector3(this.transform.localPosition.x, screen_higeValue - DiHight / 2 - 50, 0);
            }
            */
        }
    }
}