using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ET
{
    public class UIProtectEquipComponent : Entity, IAwake
    {

		public GameObject ButtonUnLock;
        public GameObject Obj_EquipPropertyText;
        public GameObject EquipBaseSetList;
        public GameObject UIXiLianItemNode;
        public GameObject XiLianButton;
        public GameObject EquipListNode;
        public GameObject ImageButton;
		public GameObject Lab_Num;

		public BagInfo XilianBagInfo;
		public BagComponent BagComponent;
		public UIItemComponent XiLianItemUI;
		public List<UIItemComponent> EquipUIList = new List<UIItemComponent>();
    }

    public class UIProtectEquipComponentAwake : AwakeSystem<UIProtectEquipComponent>
    {
        public override void Awake(UIProtectEquipComponent self)
        {
            self.EquipUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.XiLianButton = rc.Get<GameObject>("XiLianButton");
            ButtonHelp.AddListenerEx(self.XiLianButton, () => { self.OnXiLianButton(true).Coroutine(); });
			self.XiLianButton.SetActive(false);

			self.ButtonUnLock = rc.Get<GameObject>("ButtonUnLock");
			ButtonHelp.AddListenerEx(self.ButtonUnLock, () => { self.OnXiLianButton(false).Coroutine(); });
			self.ButtonUnLock.SetActive(false);

			self.EquipListNode = rc.Get<GameObject>("EquipListNode");
            self.UIXiLianItemNode = rc.Get<GameObject>("UIXiLianItemNode");

            self.Obj_EquipPropertyText = rc.Get<GameObject>("Obj_EquipPropertyText");
            self.EquipBaseSetList = rc.Get<GameObject>("EquipBaseSetList");
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
            self.InitSubItemUI().Coroutine();
        }
    }

    public static class UIProtectEquipComponentSystem
    {
		public static void OnUpdateUI(this UIProtectEquipComponent self)
		{
			self.XilianBagInfo = null;
			self.OnEquiListUpdate().Coroutine();
		}

		public static void UpdateAttribute(this UIProtectEquipComponent self, BagInfo bagInfo)
		{
			UICommonHelper.DestoryChild(self.EquipBaseSetList);
			ItemViewHelp.ShowBaseAttribute(bagInfo, self.Obj_EquipPropertyText, self.EquipBaseSetList);
		}

		public static void OnUpdateXinLian(this UIProtectEquipComponent self)
		{
			BagInfo bagInfo = self.XilianBagInfo;
			self.UpdateAttribute(bagInfo);
			self.XiLianItemUI.UpdateItem(bagInfo, ItemOperateEnum.None);
			self.ButtonUnLock.SetActive(bagInfo.IsProtect);
			self.XiLianButton.SetActive(!bagInfo.IsProtect);
		}

		public static void OnXiLianReturn(this UIProtectEquipComponent self)
		{
			self.OnUpdateXinLian();
			self.OnEquiListUpdate().Coroutine();
		}

		public static async ETTask OnEquiListUpdate(this UIProtectEquipComponent self)
		{
			int number = 0;
			var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
			var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
			List<BagInfo> equipInfos = self.BagComponent.GetItemsByType(ItemTypeEnum.Equipment);

			for (int i = 0; i < equipInfos.Count; i++)
			{
				ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equipInfos[i].ItemID);
				if (itemConfig.EquipType == 101)
				{
					continue;
				}

				UIItemComponent uI = null;
				if (number < self.EquipUIList.Count)
				{
					uI = self.EquipUIList[number];
					uI.GameObject.SetActive(true);
				}
				else
				{
					GameObject go = GameObject.Instantiate(bundleGameObject);
					UICommonHelper.SetParent(go, self.EquipListNode);
					uI = self.AddChild<UIItemComponent, GameObject>(go);
					uI.SetClickHandler((BagInfo bagInfo) => { self.OnSelectItem(bagInfo); });
					self.EquipUIList.Add(uI);
				}
				number++;
				uI.UpdateItem(equipInfos[i], ItemOperateEnum.ItemXiLian);
			}

			for (int i = number; i < self.EquipUIList.Count; i++)
			{
				self.EquipUIList[i].GameObject.SetActive(false);
			}

			if (self.XilianBagInfo != null)
			{
				self.OnSelectItem(self.XilianBagInfo);
			}
			else if (number > 0)
			{
				self.EquipUIList[0].OnClickUIItem();
			}
		}

		public static void OnSelectItem(this UIProtectEquipComponent self, BagInfo bagInfo)
		{
			self.XilianBagInfo = bagInfo;
			for (int i = 0; i < self.EquipUIList.Count; i++)
			{
				self.EquipUIList[i].SetSelected(bagInfo);
			}
			self.OnUpdateXinLian();
		}

		public static async ETTask InitSubItemUI(this UIProtectEquipComponent self)
		{
			var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
			var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

			GameObject go_1 = GameObject.Instantiate(bundleGameObject);
			UICommonHelper.SetParent(go_1, self.UIXiLianItemNode);
			self.XiLianItemUI = self.AddChild<UIItemComponent, GameObject>(go_1);
			self.XiLianItemUI.Label_ItemName.SetActive(true);

			BagInfo bagInfo = self.XilianBagInfo;
			self.XiLianItemUI.UpdateItem(bagInfo, ItemOperateEnum.None);
		}

		public static async ETTask OnXiLianButton(this UIProtectEquipComponent self, bool isprotectd)
		{
			BagInfo bagInfo = self.XilianBagInfo;
			if (bagInfo == null)
			{
				return;
			}
			C2M_ItemProtectRequest	request = new C2M_ItemProtectRequest() { OperateBagID = bagInfo.BagInfoID, IsProtect = isprotectd };
			M2C_ItemProtectResponse	response= (M2C_ItemProtectResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
			if (self.IsDisposed)
			{
				return;
			}
			string tip = isprotectd ? "锁定" : "解锁";
			FloatTipManager.Instance.ShowFloatTip($"装备{tip}成功");
			self.XilianBagInfo = self.BagComponent.GetBagInfo(self.XilianBagInfo.BagInfoID);
			self.OnXiLianReturn();
		}
	}
}
