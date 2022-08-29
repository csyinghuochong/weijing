using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIItemExpBoxComponent : Entity, IAwake
    {
        public GameObject Label_ItemNum;
        public GameObject ImageButton;
        public GameObject Text_ZuanShi;
        public GameObject Btn_ZuanShiOpen;
        public GameObject Btn_MianFeiOpen;

        public UIItemComponent UICommonItem;
        public BagInfo BagInfo;
    }

    [ObjectSystem]
    public class UIItemExpBoxComponentAwakeSystem : AwakeSystem<UIItemExpBoxComponent>
    {
        public override void Awake(UIItemExpBoxComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Text_ZuanShi = rc.Get<GameObject>("Text_ZuanShi");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.ImageButton(); });

            GameObject UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(UICommonItem);

            self.Btn_ZuanShiOpen = rc.Get<GameObject>("Btn_ZuanShiOpen");
            ButtonHelp.AddListenerEx(self.Btn_ZuanShiOpen, () => { self.OnButtonOpen(1).Coroutine(); } );
            self.Btn_MianFeiOpen = rc.Get<GameObject>("Btn_MianFeiOpen");
            ButtonHelp.AddListenerEx(self.Btn_MianFeiOpen, () => { self.OnButtonOpen(2).Coroutine(); });
        }
    }

    public static class UIItemExpBoxComponentSystem
    {


        public static void OnInitUI(this UIItemExpBoxComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            ItemConfig itemConfig =ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            string[] expInfos = itemConfig.ItemUsePar.Split('@');
            self.Text_ZuanShi.GetComponent<Text>().text = expInfos[0];
            self.UICommonItem.UpdateItem(bagInfo, ItemOperateEnum.None);
            self.UpdateNumber();
        }

        public static long UpdateNumber(this UIItemExpBoxComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            self.BagInfo = bagComponent.GetBagInfo( self.BagInfo.BagInfoID );
            if (self.BagInfo == null)
            {
                return 0;
            }
            self.Label_ItemNum.GetComponent<Text>().text = self.BagInfo.ItemNum.ToString();
            return self.BagInfo.ItemNum;
        }

        /// <summary>
        /// 1 钻石开启 2免费开启
        /// </summary>
        /// <par;f"></param>
        /// <param name="openType"></param>
        /// <returns></returns>
        public static async ETTask  OnButtonOpen(this UIItemExpBoxComponent self, int openType)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
            string[] expInfos = itemConfig.ItemUsePar.Split('@');
            if (openType == 1 && self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Diamond < int.Parse(expInfos[0]))
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_DiamondNotEnoughError);
                return;
            }
            await self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.BagInfo, openType.ToString());
            if (self.UpdateNumber() <= 0)
            {
                self.ImageButton();
            }
        }

        public static void ImageButton(this UIItemExpBoxComponent self)
        {
            UIHelper.Remove( self.ZoneScene(), UIType.UIItemExpBox ).Coroutine();
        }
    }
}