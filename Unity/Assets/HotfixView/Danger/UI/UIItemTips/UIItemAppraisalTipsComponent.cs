using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIItemAppraisalTipsComponent : Entity, IAwake
    {
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
        public GameObject Obj_Btn_XieXiaGemSet;
        public GameObject Obj_Lab_ItemCostDes;
        public GameObject selPastureItemUICommonHint;
        public GameObject Obj_Lab_EquipBangDing;
        public GameObject Obj_Img_EquipBangDing;
        public GameObject Lab_ItemSubType;
        public GameObject Imagebg;
        public GameObject Lab_ItemMake;

        public ItemOperateEnum EquipTipsType;               //操作类型
        public BagInfo BagInfo;
        public BagComponent BagComponent;

        //按钮相关
        public GameObject Btn_Sell;
        public GameObject Btn_Use;

        public Vector2 Img_backVector2;
        public float Lab_ItemNameWidth;
    }


    public class UIItemAppraisalTipsComponentAwakeSystem : AwakeSystem<UIItemAppraisalTipsComponent>
    {
        public override void Awake(UIItemAppraisalTipsComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
      
            self.ImageQualityLine = rc.Get<GameObject>("ImageQualityLine");
            self.ImageQualityBg = rc.Get<GameObject>("ImageQualityBg");
            self.Obj_Btn_XieXiaGemSet = rc.Get<GameObject>("Btn_XieXiaGem");
            self.Obj_Btn_HuiShouCancle = rc.Get<GameObject>("Btn_HuiShouCancle");
            self.Obj_Btn_HuiShou = rc.Get<GameObject>("Btn_HuiShou");
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
            ButtonHelp.AddListenerEx(self.Obj_SaveStoreHouse, self.OnBtn_PutStoreHouse);
            ButtonHelp.AddListenerEx(self.Btn_TakeStoreHouse, self.OnBtn_PutBag);

            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
        }
    }

    public static class UIItemAppraisalTipsComponentSystem
    { 
        //放入背包
        public static void OnBtn_PutBag(this UIItemAppraisalTipsComponent self)
        {
            self.BagComponent.SendPutBag(self.BagInfo).Coroutine();

            self.OnCloseTips();
        }

        //放入仓库
        public static void OnBtn_PutStoreHouse(this UIItemAppraisalTipsComponent self)
        {
            self.BagComponent.SendPutStoreHouse(self.BagInfo).Coroutine();

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

        //鉴定道具
        public static async ETTask OnClickUse(this UIItemAppraisalTipsComponent self)
        {
            //发送消息
            UI uI = await UIHelper.Create( self.ZoneScene(), UIType.UIAppraisalSelect );
            uI.GetComponent<UIAppraisalSelectComponent>().OnInitUI(self.BagInfo);
            self.OnCloseTips();

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
            ItemConfig itemconf = ItemConfigCategory.Instance.Get(baginfo.ItemID);

            string qualityiconLine = FunctionUI.GetInstance().ItemQualityLine(itemconf.ItemQuality);
            self.ImageQualityLine.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconLine);
            string qualityiconBack = FunctionUI.GetInstance().ItemQualityBack(itemconf.ItemQuality);
            self.ImageQualityBg.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconBack);

            int itemType = itemconf.ItemType;
            int itemSubType = itemconf.ItemSubType;
            //类型描述
            string itemTypename = "消耗品";
            ItemViewHelp.ItemTypeName.TryGetValue(itemType, out itemTypename);
            self.ItemType.GetComponent<Text>().text =  "类型:" + itemTypename;
            if (itemconf.ItemEquipID != 0)
            {
                int appraisalItem = EquipConfigCategory.Instance.Get(itemconf.ItemEquipID).AppraisalItem;
                if (appraisalItem != 0)
                {
                    string jiandingName = ItemConfigCategory.Instance.Get(appraisalItem).ItemName;
                    self.Obj_Lab_ItemCostDes.GetComponent<Text>().text = $"消耗<color=#EA8EF9>{jiandingName}</color>进行鉴定";
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
            self.Obj_ItemIcon.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, ItemIcon);

            string ItemQuality = FunctionUI.GetInstance().ItemQualiytoPath(itemconf.ItemQuality);
            self.Obj_ItemQuality.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, ItemQuality);

            string Text_ItemStory = itemconf.ItemDes;
            //显示道具描述
            int i2 = (int)((Text_ItemStory.Length) / 20) + 1;
            //float ItemBottomTextNum = 30.0f;

            self.Obj_BagOpenSet.SetActive(false);
            self.Obj_SaveStoreHouse.SetActive(false);
            self.Btn_TakeStoreHouse.SetActive(false);
            self.Obj_Btn_HuiShou.SetActive(false);
            self.Obj_Btn_HuiShouCancle.SetActive(false);
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
                    self.Obj_BagOpenSet.SetActive(false);
                    self.Btn_TakeStoreHouse.SetActive(true);
                    //self.Obj_Btn_StoreHouseSet.SetActive(true);
                    //ItemBottomTextNum = 0;
                    break;
                case ItemOperateEnum.CangkuBag:
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
