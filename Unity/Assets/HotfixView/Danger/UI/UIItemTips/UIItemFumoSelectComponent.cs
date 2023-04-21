using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIItemFumoSelectComponent : Entity, IAwake
    {

        public BagInfo FumoItemInfo;
        public List<Text> TextFomoPro = new List<Text>();
        public List<UIItemComponent> ItemList = new List<UIItemComponent>();
        public List<BagInfo> BagInfos = new List<BagInfo>();
        public GameObject BtnClose;
    }

    public class UIItemFumoSelectComponentAwake : AwakeSystem<UIItemFumoSelectComponent>
    {
        public override void Awake(UIItemFumoSelectComponent self)
        {

            self.ItemList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BtnClose = rc.Get<GameObject>("BtnClose");
            ButtonHelp.AddListenerEx(self.BtnClose, () => { self.OnCloseTips(); }); 

            UIItemComponent UICommonItem_0 = self.AddChild<UIItemComponent, GameObject>(rc.Get<GameObject>("UICommonItem_0"));
            UIItemComponent UICommonItem_1 = self.AddChild<UIItemComponent, GameObject>(rc.Get<GameObject>("UICommonItem_1"));
            UIItemComponent UICommonItem_2 = self.AddChild<UIItemComponent, GameObject>(rc.Get<GameObject>("UICommonItem_2"));

            self.ItemList.Add(UICommonItem_0);
            self.ItemList.Add(UICommonItem_1);
            self.ItemList.Add(UICommonItem_2);
            for (int i = 0; i < self.ItemList.Count; i++)
            {
                self.ItemList[i].GameObject.SetActive(false);
                self.ItemList[i].SetClickHandler((BagInfo bagInfo) => { self.OnSetClickHandler(bagInfo).Coroutine(); });

                Text text = rc.Get<GameObject>($"Label_ItemFumo_{i}").GetComponent<Text>();
                text.text = String.Empty;
                self.TextFomoPro.Add(text);
            }
        }
    }

    public static class UIItemFumoSelectComponentSystem
    {
        public static void OnInitUI(this UIItemFumoSelectComponent self, BagInfo fumoitem)
        {
            self.FumoItemInfo = fumoitem;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(fumoitem.ItemID);
            string[] itemparams = itemConfig.ItemUsePar.Split('@');
            int weizhi = int.Parse(itemparams[0]);
            List<BagInfo> equipinfos = self.ZoneScene().GetComponent<BagComponent>().GetEquipListByWeizhi(weizhi);

            for (int i = 0; i < equipinfos.Count; i++)
            {
                self.ItemList[i].GameObject.SetActive(true);
                self.ItemList[i].UpdateItem(equipinfos[i], ItemOperateEnum.None);
                self.ItemList[i].ShowTip = false;

                self.TextFomoPro[i].text = ItemViewHelp.GetFumpProDesc(equipinfos[i].FumoProLists);
            }

            self.BagInfos = equipinfos;
        }

        public static void OnCloseTips(this UIItemFumoSelectComponent self)
        {
            if (self.IsDisposed)
            {
                return;
            }

            UIHelper.Remove(self.DomainScene(), UIType.UIItemFumoSelect);
        }

        public static async ETTask OnSetClickHandler(this UIItemFumoSelectComponent self, BagInfo bagInfo)
        { 
            int index = self.BagInfos.IndexOf(bagInfo);
            if (index == -1)
            {
                index = 0;
            }

            BagInfo equipinfo = self.BagInfos[index];
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.FumoItemInfo.ItemID);
            List<HideProList> hideProLists = ItemHelper.GetItemFumoPro(itemConfig.Id);
            string itemfumo = ItemViewHelp.GetFumpProDesc(hideProLists);
            if (equipinfo.FumoProLists.Count > 0)
            {
                string equipfumo = ItemViewHelp.GetFumpProDesc(equipinfo.FumoProLists);
                string fumopro = $"当前附魔属性<color=#BEFF34>{equipfumo}</color> \n是否覆盖已有属性\n{itemfumo}\n此附魔道具已消耗";
                self.ZoneScene().GetComponent<BagComponent>().SendFumoUse(self.FumoItemInfo, hideProLists).Coroutine();
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "装备附魔", fumopro, async () =>
                {
                    await  self.ZoneScene().GetComponent<BagComponent>().SendFumoPro(index);
                    FloatTipManager.Instance.ShowFloatTip($"附魔属性 {itemfumo}");

                    UIHelper.Remove(self.ZoneScene(), UIType.UIItemFumoSelect);
                }, () =>
                {
                    UIHelper.Remove(self.ZoneScene(), UIType.UIItemFumoSelect);
                }).Coroutine();
            }
            else
            {
                //await self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.FumoItemInfo, index.ToString());
                await self.ZoneScene().GetComponent<BagComponent>().SendFumoUse(self.FumoItemInfo, hideProLists);
                await self.ZoneScene().GetComponent<BagComponent>().SendFumoPro(index);
                FloatTipManager.Instance.ShowFloatTip($"附魔属性 {itemfumo}");

                UIHelper.Remove(self.ZoneScene(), UIType.UIItemFumoSelect);
            }
        }
    }
}
