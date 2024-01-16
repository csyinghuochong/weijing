using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIItemAppraisalTipsComponent : Entity, IAwake,IDestroy
    {
        public GameObject Lab_ItemJingHeQuality;
        public GameObject Lab_ItemJingHeProperty;
        public GameObject Img_FengYin;
        public GameObject ImageQualityLine;
        public GameObject ImageQualityBg;
        public GameObject Obj_ItemQuality;
        public GameObject Obj_ItemIcon;
        public GameObject Lab_ItemName;
        public GameObject ItemDes;
        public GameObject ItemItemLv;
        public GameObject ItemType;
        public GameObject Img_back;
        public GameObject Obj_BagOpenSet;
        public GameObject Obj_SaveStoreHouse;
        public GameObject Btn_TakeStoreHouse;
        public GameObject Obj_Diu;
        //public GameObject Obj_Btn_StoreHouseSet;
        public GameObject Obj_Btn_GemHoleText;
        public GameObject Obj_Btn_HuiShou;
        public GameObject Obj_Btn_HuiShouCancle;
        public GameObject Btn_JingHeAddQuality;
        public GameObject Btn_JingHeActivate;
        public GameObject Obj_Btn_XieXiaGemSet;
        public GameObject Obj_Lab_ItemCostDes;
        public GameObject selPastureItemUICommonHint;
        public GameObject Obj_Lab_EquipBangDing;
        public GameObject Obj_Img_EquipBangDing;
        public GameObject Lab_ItemSubType;
        public GameObject Imagebg;
        public GameObject Lab_ItemMake;

        public ItemOperateEnum ItemOpetateType;               //操作类型
        public BagInfo BagInfo;
        public BagComponent BagComponent;

        //按钮相关
        public GameObject Btn_Sell;
        public GameObject Btn_Use;

        public Vector2 Img_backVector2;
        public float Lab_ItemNameWidth;
        public List<string> AssetPath = new List<string>();
    }


    public class UIItemAppraisalTipsComponentAwakeSystem : AwakeSystem<UIItemAppraisalTipsComponent>
    {
        public override void Awake(UIItemAppraisalTipsComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
      
            self.Img_FengYin = rc.Get<GameObject>("Img_FengYin");
            self.ImageQualityLine = rc.Get<GameObject>("ImageQualityLine");
            self.ImageQualityBg = rc.Get<GameObject>("ImageQualityBg");
            self.Obj_Btn_XieXiaGemSet = rc.Get<GameObject>("Btn_XieXiaGem");
            self.Obj_Btn_HuiShouCancle = rc.Get<GameObject>("Btn_HuiShouCancle");
            self.Obj_Btn_HuiShou = rc.Get<GameObject>("Btn_HuiShou");
            self.Btn_JingHeAddQuality = rc.Get<GameObject>("Btn_JingHeAddQuality");
            self.Btn_JingHeActivate = rc.Get<GameObject>("Btn_JingHeActivate");
            self.Lab_ItemJingHeQuality = rc.Get<GameObject>("Lab_ItemJingHeQuality");
            self.Lab_ItemJingHeProperty = rc.Get<GameObject>("Lab_ItemJingHeProperty");
            self.Btn_TakeStoreHouse = rc.Get<GameObject>("Btn_TakeStoreHouse");
            self.Obj_SaveStoreHouse = rc.Get<GameObject>("Btn_SaveStoreHouse");
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
            self.Obj_Lab_ItemCostDes = rc.Get<GameObject>("Lab_ItemCostDes");
            self.Obj_Lab_EquipBangDing = rc.Get<GameObject>("Lab_BangDing");
            self.Obj_Img_EquipBangDing = rc.Get<GameObject>("Img_BangDing");
            self.Lab_ItemSubType = rc.Get<GameObject>("Lab_ItemSubType");
            self.Lab_ItemMake = rc.Get<GameObject>("Lab_ItemMake");

            self.Imagebg.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseTips(); });
            ButtonHelp.AddListenerEx(self.Btn_Sell, self.OnClickSell);
            ButtonHelp.AddListenerEx(self.Btn_Use, () => { self.OnClickUse().Coroutine(); });
            ButtonHelp.AddListenerEx(self.Obj_Btn_HuiShou, self.On_Btn_HuiShou);
            ButtonHelp.AddListenerEx(self.Obj_Btn_HuiShouCancle, self.OnBtn_HuiShouCancle);
            ButtonHelp.AddListenerEx(self.Btn_JingHeAddQuality, () => { self.OnBtn_JingHeZhuYu().Coroutine(); });
            ButtonHelp.AddListenerEx(self.Btn_JingHeActivate, () => { self.OnBtn_JingHeActivate().Coroutine(); });
            ButtonHelp.AddListenerEx(self.Obj_SaveStoreHouse, self.OnBtn_PutStoreHouse);
            ButtonHelp.AddListenerEx(self.Btn_TakeStoreHouse, self.OnBtn_PutBag);

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
        }
    }
    public class UIItemAppraisalTipsComponentDestroy: DestroySystem<UIItemAppraisalTipsComponent>
    {
        public override void Destroy(UIItemAppraisalTipsComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }
    public static class UIItemAppraisalTipsComponentSystem
    {

        //晶核注入。增加品质
        public static async ETTask OnBtn_JingHeZhuYu(this UIItemAppraisalTipsComponent self)
        {
            UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UISeasonJingHeZhuru);
            ui.GetComponent<UISeasonJingHeZhuruComponent>().InitInfo(self.BagInfo);
            self.OnCloseTips();
        }

        //晶核激活
        public static async ETTask OnBtn_JingHeActivate(this UIItemAppraisalTipsComponent self)
        {
            C2M_JingHeActivateRequest request = new C2M_JingHeActivateRequest() { BagInfoId = self.BagInfo.BagInfoID };
            M2C_JingHeActivateResponse response = (M2C_JingHeActivateResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.OnCloseTips();
        }

        //放入背包
        public static void OnBtn_PutBag(this UIItemAppraisalTipsComponent self)
        {
            if (self.ItemOpetateType == ItemOperateEnum.AccountCangku)
            {
                NetHelper.RequestAccountWarehousOperate(self.ZoneScene(), 2, self.BagInfo.BagInfoID).Coroutine();
            }
            else
            {
                self.BagComponent.SendPutBag(self.BagInfo).Coroutine();
            }

            self.OnCloseTips();
        }

        //放入仓库
        public static void OnBtn_PutStoreHouse(this UIItemAppraisalTipsComponent self)
        {
            if (self.ItemOpetateType == ItemOperateEnum.AccountBag)
            {
                ItemViewHelp.AccountCangkuPutIn(self.ZoneScene(), self.BagInfo);
            }
            else
            {
                self.BagComponent.SendPutStoreHouse(self.BagInfo).Coroutine();
            }

            self.OnCloseTips();
        }

        public static void Awake(this UIItemAppraisalTipsComponent self)
        {

        }
        //点击Tips
        public static void OnCloseTips(this UIItemAppraisalTipsComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips);
        }

        public static void On_Btn_HuiShou(this UIItemAppraisalTipsComponent self)
        {
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"1_{self.BagInfo.BagInfoID}");
            self.OnCloseTips();
        }

        public static void OnBtn_HuiShouCancle(this UIItemAppraisalTipsComponent self)
        {
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"0_{self.BagInfo.BagInfoID}");
            self.OnCloseTips();
        }

        //出售道具
        public static void OnClickSell(this UIItemAppraisalTipsComponent self)
        {
            //发送消息
            if (ItemConfigCategory.Instance.Get(self.BagInfo.ItemID).ItemQuality >= 4)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "出售道具", "是否出售道具:" + itemConfig.ItemName, () =>
                {
                    self.ZoneScene().GetComponent<BagComponent>().SendSellItem(self.BagInfo, self.BagInfo.ItemNum.ToString()).Coroutine();
                    self.OnCloseTips();
                }).Coroutine();
            }
            else
            {
                self.ZoneScene().GetComponent<BagComponent>().SendSellItem(self.BagInfo, self.BagInfo.ItemNum.ToString()).Coroutine();
                self.OnCloseTips();
            }
        }



        //鉴定道具
        public static async ETTask OnClickUse(this UIItemAppraisalTipsComponent self)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);

            if (itemConfig.EquipType == 101)
            {
                int appraisalItem = EquipConfigCategory.Instance.Get(itemConfig.ItemEquipID).AppraisalItem;

                BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
                BagInfo costbaginfo = bagComponent.GetBagInfo(appraisalItem);
                if (costbaginfo == null)
                {
                    FloatTipManager.Instance.ShowFloatTip("道具不足！");
                    return;
                }

                string costitem = ItemConfigCategory.Instance.Get(appraisalItem).ItemName;
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "开启封印", $"是否消耗{costitem}开启封印?", () =>
                {
                    bagComponent.SendAppraisalItem(self.BagInfo, costbaginfo.BagInfoID).Coroutine();
                    self.OnCloseTips();
                }).Coroutine();
            }
            else
            {
                //发送消息
                UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIAppraisalSelect);
                uI.GetComponent<UIAppraisalSelectComponent>().OnInitUI(self.BagInfo);
                self.OnCloseTips();
            }
            //int errorCode = await self.ZoneScene().GetComponent<BagComponent>().SendAppraisalItem(self.BagInfo);
            //if (errorCode == ErrorCore.ERR_Success)
            //{
            //    FloatTipManager.Instance.ShowFloatTipDi(GameSettingLanguge.LoadLocalization("道具鉴定成功!"));
            //    self.OnCloseTips();
            //}
        }

        public static void InitData(this UIItemAppraisalTipsComponent self, BagInfo baginfo, ItemOperateEnum equipTipsType, Action handler=null)
        {
            self.BagInfo = baginfo;
            self.ItemOpetateType = equipTipsType;
            ItemConfig itemconf = ItemConfigCategory.Instance.Get(baginfo.ItemID);

            string qualityiconLine = FunctionUI.GetInstance().ItemQualityLine(itemconf.ItemQuality);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, qualityiconLine);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ImageQualityLine.GetComponent<Image>().sprite = sp;
            string qualityiconBack = FunctionUI.GetInstance().ItemQualityBack(itemconf.ItemQuality);
            string path1 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, qualityiconBack);
            Sprite sp1 = ResourcesComponent.Instance.LoadAsset<Sprite>(path1);
            if (!self.AssetPath.Contains(path1))
            {
                self.AssetPath.Add(path1);
            }
            self.ImageQualityBg.GetComponent<Image>().sprite = sp1;

            int itemType = itemconf.ItemType;
            int itemSubType = itemconf.ItemSubType;
            //类型描述
            string itemTypename = "消耗品";
            ItemViewHelp.ItemTypeName.TryGetValue(itemType, out itemTypename);
            self.ItemType.GetComponent<Text>().text =  "类型:" + itemTypename;
            if (itemconf.ItemEquipID != 0 && itemconf.EquipType != 201)
            {
                int appraisalItem = EquipConfigCategory.Instance.Get(itemconf.ItemEquipID).AppraisalItem;
                if (appraisalItem != 0)
                {
                    string tip_1 = itemconf.EquipType == 101 ? "封印生肖" : "进行鉴定";
                    string jiandingName = ItemConfigCategory.Instance.Get(appraisalItem).ItemName;
                    self.Obj_Lab_ItemCostDes.GetComponent<Text>().text = $"消耗<color=#EA8EF9>{jiandingName}</color>{tip_1}";
                }
            }

            if (baginfo.MakePlayer != "" && baginfo.MakePlayer != null)
            {
                self.Lab_ItemMake.SetActive(true);
                self.Lab_ItemMake.GetComponent<Text>().text = $"此装备由<color=#805100>{self.BagInfo.MakePlayer}</color>打造";
            }
            else {
                self.Lab_ItemMake.GetComponent<Text>().text = "";
                self.Lab_ItemMake.SetActive(false);
            }

            string equipType = "";
            if (itemType == 3)
            {
                //获取类型显示
                string textEquipType = ItemViewHelp.GetEquipSonType(itemconf.ItemSubType.ToString());
                string textEquipSonType = ItemViewHelp.GetEquipTypeShow(itemconf.EquipType);

                //121211 <color=#AFFF06>颜色</color>
                equipType =  $"<color=#AFFF06>    类型:{textEquipSonType}</color>";
                self.ItemType.GetComponent<Text>().text = "部位:" + textEquipType;
            }

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

            //数组大于2表示有换行符,否则显示原来的描述
            if (itemDesArray.Length >= 2)
            {
                Text_ItemDes = itemMiaoShu;
            }

            //根据Tips描述长度缩放底的大小
            int i1 = 0;
            Text_ItemDes = ItemViewHelp.GetItemDesc(baginfo,ref i1);
            //赞助宝箱设置描述为绿色
            if (itemSubType == 9)
            {
                //self.ItemDes.GetComponent<Text>().color = Color.green;
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

            //显示图标
            //显示道具Icon
            string ItemIcon = itemconf.Icon;
            string path2 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, ItemIcon);
            Sprite sp2 = ResourcesComponent.Instance.LoadAsset<Sprite>(path2);
            if (!self.AssetPath.Contains(path2))
            {
                self.AssetPath.Add(path2);
            }
            self.Obj_ItemIcon.GetComponent<Image>().sprite = sp2;

            self.Img_FengYin.SetActive( itemconf.EquipType == 101 );
            UICommonHelper.SetImageGray(self.Obj_ItemIcon, true);

            self.ItemDes.GetComponent<Text>().text = itemconf.EquipType == 101 ? "封印生肖" : "未鉴定装备";
            // 赛季晶核
            if (itemType == 3 && itemconf.EquipType == 201)
            {
                self.ItemDes.SetActive(false);
                self.Lab_ItemJingHeQuality.SetActive(true);
                int qua = 1;
                int nowQua = int.Parse(baginfo.ItemPar);
                qua = (int)(nowQua / 20) + 1;
                if (qua >= 5) {
                    qua = 5;
                }
                string colorValue = ItemViewHelp.QualityReturnColorUI(qua);
                self.Lab_ItemJingHeQuality.GetComponent<Text>().text = $"当前品质:{baginfo.ItemPar}";
                //self.Lab_ItemJingHeQuality.AddComponent<Outline>();
                // 属性显示itemConfig.ItemUsePar
                string attribute = "";
                string[] parmainfos = itemconf.ItemUsePar.Split('@');
                string[] attriinfos = parmainfos[1].Split(';');
                int addType = int.Parse(attriinfos[0]);
                if (addType == 1)
                {
                    string[] hidevalueinfo = attriinfos[1].Split(',');
                    int hideid = int.Parse(hidevalueinfo[0]);
                    string proName = ItemViewHelp.GetAttributeName(hideid);
                    int showType = NumericHelp.GetNumericValueType(hideid);
                    if (showType == 2)
                    {
                        float hidevaluemin = float.Parse(hidevalueinfo[1]);
                        float hidevaluemax = float.Parse(hidevalueinfo[2]);

                        (hidevaluemin, hidevaluemax) = ItemHelper.GetJingHeHideProRange(hidevaluemin, hidevaluemax, nowQua);
                        attribute = $"{proName}:" + (hidevaluemin * 100).ToString("0.##") + "~" + (hidevaluemax * 100).ToString("0.##") +
                                "%\n";
                    }
                    else
                    {
                        int hidevaluemin = int.Parse(hidevalueinfo[1]);
                        int hidevaluemax = int.Parse(hidevalueinfo[2]);
                        (hidevaluemin, hidevaluemax) = ItemHelper.GetJingHeHideProRange(hidevaluemin, hidevaluemax, nowQua);
                        attribute = $"{proName}:" + hidevaluemin + "~" + hidevaluemax;
                    }
                }
                // else if (addType == 2)
                // {
                //     string[] hidevalueinfo = attriinfos[1].Split(',');
                //     int hideid = int.Parse(hidevalueinfo[0]);
                //     SkillConfig skillConfig = SkillConfigCategory.Instance.Get(hideid);
                //     string skillName = skillConfig.SkillName;
                //     attribute = $"当前附加 {skillName}:"+"\n";
                // }

                self.Lab_ItemJingHeProperty.GetComponent<Text>().text = attribute;
            }

            self.Btn_Use.transform.Find("Text").GetComponent<Text>().text = itemconf.EquipType == 101 ? "开启封印" : "鉴定";

            string ItemQuality = FunctionUI.GetInstance().ItemQualiytoPath(itemconf.ItemQuality);
            string path3 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, ItemQuality);
            Sprite sp3 = ResourcesComponent.Instance.LoadAsset<Sprite>(path3);
            if (!self.AssetPath.Contains(path3))
            {
                self.AssetPath.Add(path3);
            }
            self.Obj_ItemQuality.GetComponent<Image>().sprite = sp3;

            string Text_ItemStory = itemconf.ItemDes;
            //显示道具描述
            int i2 = (int)((Text_ItemStory.Length) / 20) + 1;
            //float ItemBottomTextNum = 30.0f;

            self.Obj_BagOpenSet.SetActive(false);
            self.Obj_SaveStoreHouse.SetActive(false);
            self.Btn_TakeStoreHouse.SetActive(false);
            self.Obj_Btn_HuiShou.SetActive(false);
            self.Obj_Btn_HuiShouCancle.SetActive(false);
            self.Btn_JingHeAddQuality.SetActive(false);
            self.Btn_JingHeActivate.SetActive(false);
            self.Obj_Btn_XieXiaGemSet.SetActive(false);

            //显示按钮
            switch ((ItemOperateEnum)equipTipsType)
            {
                //不显示任何按钮
                case ItemOperateEnum.None:
                case ItemOperateEnum.PaiMaiSell:
                case ItemOperateEnum.PaiMaiBuy:
                    //ItemBottomTextNum = 0;
                    break;
                //背包打开显示对应功能按钮
                case ItemOperateEnum.Bag:
                    self.Obj_BagOpenSet.SetActive(true);
                    self.Btn_TakeStoreHouse.SetActive(false);
                    //判定当前是否打开仓库
                    bool openHouse = false;
                    if (openHouse)
                    {
                        self.Obj_SaveStoreHouse.SetActive(true);
                        self.Obj_Diu.SetActive(false);
                    }
                    else
                    {
                        self.Obj_SaveStoreHouse.SetActive(false);
                        self.Obj_Diu.SetActive(true);
                    }
                    
                    // 赛季晶核
                    if (itemType == 3 && itemconf.EquipType == 201)
                    {
                        self.Btn_Use.SetActive(false);
                        self.Btn_Sell.SetActive(false);
                        self.Btn_JingHeAddQuality.SetActive(true);
                        self.Btn_JingHeActivate.SetActive(true);
                    }

                    break;
                //角色栏打开显示对应功能按钮
                case ItemOperateEnum.Juese:
                    self.Obj_BagOpenSet.SetActive(true);
                    self.Btn_TakeStoreHouse.SetActive(false);
                    break;
                //商店查看属性
                case ItemOperateEnum.Shop:
                    self.Obj_BagOpenSet.SetActive(false);
                    //self.Obj_Btn_StoreHouseSet.SetActive(false);
                    //ItemBottomTextNum = 0;
                    break;
                //仓库查看属性
                case ItemOperateEnum.Cangku:
                case ItemOperateEnum.AccountCangku:
                case ItemOperateEnum.GemCangku:
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Btn_TakeStoreHouse.SetActive(true);
                    //self.Obj_Btn_StoreHouseSet.SetActive(true);
                    //ItemBottomTextNum = 0;
                    break;
                case ItemOperateEnum.CangkuBag:
                case ItemOperateEnum.AccountBag:
                    self.Obj_BagOpenSet.SetActive(true);
                    self.Obj_SaveStoreHouse.SetActive(true);
                    self.Btn_Sell.SetActive(false);
                    self.Btn_Use.SetActive(false);
                    break;
                //回收背包打开
                case ItemOperateEnum.HuishouBag:
                    self.Obj_BagOpenSet.SetActive(true);
                    //self.Obj_Btn_StoreHouseSet.SetActive(false);
                    self.Obj_SaveStoreHouse.SetActive(false);
                    self.Obj_Btn_HuiShou.SetActive(true);
                    self.Btn_Sell.SetActive(false);
                    self.Btn_Use.SetActive(false);
                    break;
                //回收功能显示
                case ItemOperateEnum.HuishouShow:
                    self.Obj_BagOpenSet.SetActive(false);
                    //self.Obj_Btn_StoreHouseSet.SetActive(false);
                    self.Obj_Btn_HuiShouCancle.SetActive(true);
                    self.Obj_SaveStoreHouse.SetActive(false);
                    break;
                //牧场  不显示任何按钮
                case ItemOperateEnum.Muchang:
                    //ItemBottomTextNum = 0;
                    break;
                //牧场仓库  显示出售按钮
                case ItemOperateEnum.MuchangCangku:
                    self.Obj_BagOpenSet.SetActive(true);
                    //self.Obj_Btn_StoreHouseSet.SetActive(false);
                    self.Obj_SaveStoreHouse.SetActive(false);
                    self.Obj_Diu.SetActive(true);
                    break;
                default:
                    //ItemBottomTextNum = 0;
                    break;
            }

            //判定道具为宝石时显示使用变为镶嵌字样
            /*
            if (itemType == 4)
            {
                string langStr_A = GameSettingLanguge.LoadLocalization("镶 嵌");
                self.Obj_Btn_GemHoleText.GetComponent<Text>().text = langStr_A;
            }
            */
            //设置底的长度
            //self.ItemDi.GetComponent<RectTransform>().sizeDelta = new Vector2(301.0f, 180.0f + i1 * 20.0f + i2 * 16.0f + ItemBottomTextNum);

            //显示道具信息
            self.Lab_ItemName.GetComponent<Text>().text =  itemconf.ItemName;
            self.Lab_ItemSubType.GetComponent<Text>().text = equipType;
            self.Lab_ItemName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemconf.ItemQuality);
            float exceedWidth = self.Lab_ItemName.GetComponent<Text>().preferredWidth - self.Lab_ItemNameWidth;
            if (exceedWidth > -20)
            {
                self.Img_back.GetComponent<RectTransform>().sizeDelta = new Vector2(self.Img_backVector2.x + exceedWidth + 30, self.Img_backVector2.y);
            }

            string langStr = GameSettingLanguge.LoadLocalization("等级");
            if (itemconf.UseLv > 0)
            {
                self.ItemItemLv.GetComponent<Text>().text = langStr + ":" + itemconf.UseLv;

                if (itemconf.UseLv > self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv)
                {
                    self.ItemItemLv.GetComponent<Text>().text = langStr + " : " + itemconf.UseLv;
                    //self.ItemItemLv.GetComponent<Text>().text = langStr + " : " + itemconf.UseLv + " (等级不足)";
                    self.ItemItemLv.GetComponent<Text>().color = new Color(255f / 255f, 200f / 255f, 200f / 255f);
                }
            }
            else
            {
                self.ItemItemLv.GetComponent<Text>().text = langStr + ":1";
            }
        }
     }
}
