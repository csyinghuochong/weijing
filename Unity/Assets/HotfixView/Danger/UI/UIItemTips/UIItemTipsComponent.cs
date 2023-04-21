using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIItemTipsComponent : Entity, IAwake
    {
        public GameObject Btn_Split;
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
            self.Btn_Split = rc.Get<GameObject>("Btn_Split");
            self.Obj_Lab_EquipBangDing = rc.Get<GameObject>("Lab_BangDing");
            self.Obj_Img_EquipBangDing = rc.Get<GameObject>("Img_BangDing");

            ButtonHelp.AddListenerEx(self.Imagebg, () => { self.OnCloseTips(); });
            ButtonHelp.AddListenerEx(self.Btn_Sell, () => { self.OnClickSell(); });
            ButtonHelp.AddListenerEx(self.Btn_Use, () => { self.OnClickUse().Coroutine(); });     
            ButtonHelp.AddListenerEx(self.Btn_Split, () => { self.OnBtn_Split().Coroutine(); });
           
            self.Btn_StoreHouse = rc.Get<GameObject>("Btn_StoreHouse");
            ButtonHelp.AddListenerEx(self.Btn_StoreHouse, () => { self.OnBtn_StoreHouse(); });
            self.Btn_StoreHouse.SetActive(false);

            self.Btn_PutBag = rc.Get<GameObject>("Btn_PutBag");
            self.Btn_PutBag.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_PutBag(); });
            self.Btn_PutBag.SetActive(false);

            ButtonHelp.AddListenerEx(self.Obj_Btn_HuiShouCancle, () => { self.OnBtn_HuiShouCancle(); });
            ButtonHelp.AddListenerEx(self.Obj_Btn_HuiShou, () => { self.On_Btn_HuiShou(); });
            ButtonHelp.AddListenerEx(self.Obj_Btn_XieXiaGemSet, () => { self.On_Btn_XieXiaGemSet(); });
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
        }
    }

    public static class UIItemTipsComponentSystem
    {
        public static void On_Btn_HuiShou(this UIItemTipsComponent self)
        {
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"1_{self.BagInfo.BagInfoID}");
            self.OnCloseTips();
        }

        public static void OnBtn_HuiShouCancle(this UIItemTipsComponent self)
        {
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"0_{self.BagInfo.BagInfoID}");
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

            self.BagComponent.SendXieXiaGem(uIRoleGemComponent.XiangQianItem, uIRoleGemComponent.XiangQianIndex.ToString()).Coroutine();

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
            if (self.IsDisposed)
            {
                return;
            }

            UIHelper.Remove(self.DomainScene(), UIType.UIItemTips);
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
                    self.OnCloseTips();
                }).Coroutine();
            }
            else
            {
                self.ZoneScene().GetComponent<BagComponent>().SendSellItem(self.BagInfo).Coroutine();
                self.OnCloseTips();
            }
        }

        public static void RequestXiangQianGem(this UIItemTipsComponent self, string usrPar)
        {
            self.ZoneScene().GetComponent<BagComponent>().SendXiangQianGem(self.BagInfo, usrPar).Coroutine();
            //注销Tips
            self.OnCloseTips();
        }

        public static async ETTask OnBtn_Split(this UIItemTipsComponent self)
        {
            UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIRoleBagSplit);
            uI.GetComponent<UIRoleBagSplitComponent>().OnInitUI(self.BagInfo);

            self.OnCloseTips();
        }

        public static async ETTask OnItemFumoUse(this UIItemTipsComponent self, ItemConfig itemConfig)
        {
            await ETTask.CompletedTask;
            string[] itemparams = itemConfig.ItemUsePar.Split('@');
            int weizhi = int.Parse(itemparams[0]);
            BagInfo equipinfo = self.ZoneScene().GetComponent<BagComponent>().GetEquipBySubType(weizhi);
            if (equipinfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip("对应的位置没有装备！");
                return;
            }
            if (weizhi == (int)ItemSubTypeEnum.Shiping)
            {
                UI uI = await UIHelper.Create( self.ZoneScene(), UIType.UIItemFumoSelect );
                uI.GetComponent<UIItemFumoSelectComponent>().OnInitUI( self.BagInfo );
                return;
            }

           
            List<HideProList> hideProLists = ItemHelper.GetItemFumoPro(itemConfig.Id);
            string itemfumo = ItemViewHelp.GetFumpProDesc(hideProLists);

            if (equipinfo.FumoProLists.Count > 0)
            {
                string equipfumo = ItemViewHelp.GetFumpProDesc(equipinfo.FumoProLists);
                string fumopro = $"当前附魔属性{itemfumo} 是否覆盖{equipfumo}";

                self.ZoneScene().GetComponent<BagComponent>().SendFumoUse(self.BagInfo, hideProLists).Coroutine();
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "装备附魔", fumopro, () =>
                {
                    self.ZoneScene().GetComponent<BagComponent>().SendFumoPro(0).Coroutine();
                    FloatTipManager.Instance.ShowFloatTip($"附魔属性 {itemfumo}");
                    self.OnCloseTips();
                }, () =>
                {
                    self.OnCloseTips();
                }).Coroutine();
            }
            else
            {
                
                self.OnCloseTips();
            }
            return;
        }

        //使用道具
        public static async ETTask OnClickUse(this UIItemTipsComponent self)
        {
            //发送消息
            //判断当前技能是否再CD状态
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
            int errorCode = ErrorCore.ERR_Success;
            string usrPar = "";

            if (itemConfig.DayUseNum > 0 && userInfoComponent.GetDayItemUse(itemConfig.Id) >= itemConfig.DayUseNum)
            {
                FloatTipManager.Instance.ShowFloatTip(ErrorHelp.Instance.ErrorHintList[ErrorCore.ERR_ItemNoUseTime]);
                return;
            }

            //材料
            if (itemConfig.ItemType == (int)ItemTypeEnum.Material)
            {
                return;
            }
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
                string[] gemHolelist = gemHole.Split('_');
                if (gemHolelist.Length <= uIRoleGemComponent.XiangQianIndex)
                {
                    FloatTipManager.Instance.ShowFloatTip("请选择孔位！");
                    return;
                }
                string itemgem = gemHolelist[uIRoleGemComponent.XiangQianIndex];
                if (itemgem != itemConfig.ItemSubType.ToString() && itemConfig.ItemSubType != 110 && itemConfig.ItemSubType != 111)
                {
                    FloatTipManager.Instance.ShowFloatTip("宝石与孔位不符！");
                    return;
                }
                string[] getIdNew = uIRoleGemComponent.XiangQianItem.GemIDNew.Split('_');
                usrPar = $"{uIRoleGemComponent.XiangQianItem.BagInfoID}_{uIRoleGemComponent.XiangQianIndex}";
                if (getIdNew[uIRoleGemComponent.XiangQianIndex] != "0")
                {
                    PopupTipHelp.OpenPopupTip(self.ZoneScene(), "镶嵌宝石", "是否需要覆盖宝石?", () =>
                    {
                        self.RequestXiangQianGem(usrPar);
                    }).Coroutine();
                }
                else
                {
                    self.RequestXiangQianGem(usrPar);
                }
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
            if (itemConfig.ItemSubType == 15)   //附魔
            {
                self.OnItemFumoUse( itemConfig ).Coroutine();
                return;
            }
            if (itemConfig.ItemSubType == 16)   //锻造精灵
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                int makeType = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.MakeType);
                int makeNew = int.Parse(itemConfig.ItemUsePar);
                EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeNew);
                if (makeType != equipMakeConfig.ProficiencyType)
                {
                    ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_MakeTypeError);
                    return;
                }
                if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.MakeList.Contains(makeNew))
                {
                    FloatTipManager.Instance.ShowFloatTip("已经学习过该技能！");
                    return;
                }
            }
            if (itemConfig.ItemSubType == 101)
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                unit.GetComponent<SkillManagerComponent>().SendUseSkill(int.Parse(itemConfig.ItemUsePar), itemConfig.Id,
                    Mathf.FloorToInt(unit.Rotation.eulerAngles.y), 0, 0).Coroutine();
                self.OnCloseTips();
                return;
            }
            if (itemConfig.ItemSubType == 102)
            {
                FloatTipManager.Instance.ShowFloatTip("请前往主城的宠物蛋孵化处!");
                return;
            }
            if (itemConfig.ItemSubType == 112)
            {
                AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
                if (ServerHelper.GetOpenServerDay(!GlobalHelp.IsOutNetMode, accountInfoComponent.ServerId) <= 1)
                {
                    FloatTipManager.Instance.ShowFloatTip("开服第一天不能使用该道具!");
                    return;
                }
                UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIItemExpBox);
                uI.GetComponent<UIItemExpBoxComponent>().OnInitUI(self.BagInfo);
                self.OnCloseTips();
                return;
            }
            if (itemConfig.ItemSubType == 113 || itemConfig.ItemSubType == 127)
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
                    // $"{dungeonid}@{"TaskMove_6"}@{dropId}";
                    Scene zoneScene = self.ZoneScene();
                    EventType.DigForTreasure.Instance.BagInfo = self.BagInfo;
                    EventType.DigForTreasure.Instance.ZoneScene = self.ZoneScene();
                    Game.EventSystem.PublishClass(EventType.DigForTreasure.Instance);
                    UIHelper.Remove(zoneScene, UIType.UIRole);
                    self.OnCloseTips();
                    FloatTipManager.Instance.ShowFloatTip($"消耗道具:{itemConfig.ItemName}");
                    return;
                }
            }
            if (itemConfig.ItemSubType == 108
                || itemConfig.ItemSubType == 109
                || itemConfig.ItemSubType == 117
                || itemConfig.ItemSubType == 118
                || itemConfig.ItemSubType == 119
                || itemConfig.ItemSubType == 122)
            {
                PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
                RolePetInfo petInfo = petComponent.GetFightPet();
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
            if (itemConfig.ItemSubType == 110)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UIRole);
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
            ItemViewHelp.ItemTypeName.TryGetValue(itemType, out itemTypename);

            //烹饪道具显示
            if (itemType == 1 && itemSubType == 131) {
                itemTypename = "家园烹饪";
            }

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
            self.Btn_Use.SetActive(itemType != (int)ItemTypeEnum.Material);
            self.Btn_Split.SetActive(itemType == (int)ItemTypeEnum.Material);
           
            //显示按钮
            switch ((ItemOperateEnum)equipTipsType)
            {
                //不显示任何按钮
                case ItemOperateEnum.None:
                case ItemOperateEnum.PaiMaiSell:
                    //ItemBottomTextNum = 0;
                    break;
                case ItemOperateEnum.JianYuanBag:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Btn_Split.SetActive(false);
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
            self.Lab_ItemName.GetComponent<Text>().text = itemconf.ItemName;
            self.Lab_ItemName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemconf.ItemQuality);
            self.ItemDes.GetComponent<Text>().text = Text_ItemDes;
            //赞助宝箱设置描述为绿色
            //if (itemSubType == 9)
            //{
            //    self.ItemDes.GetComponent<Text>().color = Color.green;
            //}
            float exceedWidth = self.Lab_ItemName.GetComponent<Text>().preferredWidth - self.Lab_ItemNameWidth;
            if (exceedWidth > -20)
            {
                self.Img_back.GetComponent<RectTransform>().sizeDelta = new Vector2(self.Img_backVector2.x + exceedWidth + 30, self.Img_backVector2.y);
            }

            //鉴定品质符
            if (itemconf.ItemSubType == 121)
            {
                self.ItemDes.GetComponent<Text>().text = Text_ItemDes + "\n" + "\n" + $"鉴定符品质:{baginfo.ItemPar}" + "\n" + "品质越高,鉴定出极品的概率越高。" + "\n" + "鉴定符品质与制造者熟练度相关。";
            }

            //鉴定品质符
            if (itemconf.ItemType == 1 && itemconf.ItemSubType == 131)
            {
                string[] addList = itemconf.ItemUsePar.Split(';')[0].Split(',');
                self.ItemDes.GetComponent<Text>().text = Text_ItemDes + "\n" + "\n" + "烹饪品质:" + baginfo.ItemPar;
            }

            //宠物技能
            if (itemconf.ItemType == 2 && itemconf.ItemSubType == 122)
            {
                SkillConfig skillCof = SkillConfigCategory.Instance.Get(int.Parse(itemconf.ItemUsePar));
                self.ItemDes.GetComponent<Text>().text = Text_ItemDes + "\n" + "\n" + $"技能描述:{skillCof.SkillDescribe}";
            }

            //藏宝图
            if (itemconf.ItemSubType == 127 && !string.IsNullOrEmpty(self.BagInfo.ItemPar)) 
            {
                int sceneID = int.Parse(self.BagInfo.ItemPar.Split('@')[0]);
                self.ItemDes.GetComponent<Text>().text =  $"前往地图:{DungeonConfigCategory.Instance.Get(sceneID).ChapterName}开启藏宝图!";
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