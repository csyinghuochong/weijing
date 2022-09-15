using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	public class UIRoleXiLianShowComponent : Entity, IAwake
	{

		public GameObject Obj_EquipPropertyText;
		public GameObject EquipBaseSetList;
		public GameObject UIXiLianItemNode;
		public GameObject XiLianButton;
		public GameObject Text_CostValue;
		public GameObject Text_CostName;
		public GameObject CostItem;
		public GameObject EquipListNode;
		public GameObject FunctionBtnSet;
		public GameObject ImageButton;
		public GameObject Lab_Num;

		public BagComponent BagComponent;

		public UI CostItemUI;
		public UI XiLianItemUI;
		public UI UIPageComponent;
		public List<UI> EquipUIList;

		public BagInfo XilianBagInfo;
	}

	[ObjectSystem]
	public class UIRoleXiLianShowComponentAwakeSystem : AwakeSystem<UIRoleXiLianShowComponent>
	{
		public override void Awake(UIRoleXiLianShowComponent self)
		{
			self.EquipUIList = new List<UI>();
			self.XilianBagInfo = null;
			ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
			self.XiLianButton = rc.Get<GameObject>("XiLianButton");
			self.XiLianButton.GetComponent<Button>().onClick.AddListener(() => { self.OnXiLianButton().Coroutine(); });

			self.Text_CostValue = rc.Get<GameObject>("Text_CostValue");
			self.Text_CostName = rc.Get<GameObject>("Text_CostName");
			self.CostItem = rc.Get<GameObject>("CostItem");
			self.EquipListNode = rc.Get<GameObject>("EquipListNode");
			self.UIXiLianItemNode = rc.Get<GameObject>("UIXiLianItemNode");
			self.Lab_Num = rc.Get<GameObject>("Lab_Num");
			self.Obj_EquipPropertyText = rc.Get<GameObject>("Obj_EquipPropertyText");
			self.EquipBaseSetList = rc.Get<GameObject>("EquipBaseSetList");

			self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

			self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

			self.XiLianItemUI = null;
			self.CostItem.SetActive(false);
			self.InitSubItemUI().Coroutine();
		}
	}


	public static class UIRoleXiLianShowComponentSystem
	{

		//显示的时候刷新
		public static void OnUpdateUI(this UIRoleXiLianShowComponent self)
		{
			self.XilianBagInfo = null;
			self.OnEquiListUpdate().Coroutine();
		}

		public static void UpdateAttribute(this UIRoleXiLianShowComponent self, BagInfo bagInfo)
		{
			UICommonHelper.DestoryChild(self.EquipBaseSetList);
			if (bagInfo == null)
			{
				return;
			}
			ItemViewHelp.ShowBaseAttribute( bagInfo, self.Obj_EquipPropertyText, self.EquipBaseSetList);
		}

		public static void OnUpdateXinLian(this UIRoleXiLianShowComponent self)
		{
			BagInfo bagInfo = self.XilianBagInfo;
			self.CostItem.SetActive(bagInfo != null);
			self.UpdateAttribute(bagInfo);
			if (bagInfo == null)
			{
				return;
			}
			ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
			if (self.XiLianItemUI != null)
			{
				self.XiLianItemUI.GetComponent<UIItemComponent>().UpdateItem(bagInfo, ItemOperateEnum.None);
			}

			//洗炼消耗
			int[] itemCost = itemConfig.XiLianStone;
			if (itemCost == null || itemCost.Length == 0)
			{
				self.CostItem.SetActive(false);
				return;
			}

			BagInfo bagInfoNeed = new BagInfo() { ItemID = itemCost[0], ItemNum = itemCost[1] };
			self.CostItemUI.GetComponent<UIItemComponent>().UpdateItem(bagInfoNeed, ItemOperateEnum.None);
			self.CostItemUI.GetComponent<UIItemComponent>().Label_ItemNum.SetActive(false);

			self.Text_CostValue.GetComponent<Text>().text = string.Format("{0}/{1}", self.BagComponent.GetItemNumber(itemCost[0]), itemCost[1]);
			self.Text_CostValue.GetComponent<Text>().color = self.BagComponent.GetItemNumber(itemCost[0]) >= itemCost[1] ? Color.green : Color.red;

			self.Text_CostName.GetComponent<Text>().text = ItemConfigCategory.Instance.Get(bagInfoNeed.ItemID).ItemName;
			self.Text_CostName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColorDi((int)ItemConfigCategory.Instance.Get(bagInfoNeed.ItemID).ItemQuality);
			if (self.BagComponent.GetItemNumber(itemCost[0]) >= itemCost[1])
			{
				self.Text_CostValue.GetComponent<Text>().color = Color.green;
			}
		}

		public static void OnXiLianReturn(this UIRoleXiLianShowComponent self)
		{
			self.XilianBagInfo = self.BagComponent.GetBagInfo(self.XilianBagInfo.BagInfoID);
			self.OnUpdateXinLian();
			self.OnEquiListUpdate().Coroutine();
		}

		public static async ETTask OnEquiListUpdate(this UIRoleXiLianShowComponent self)
		{
			int number = 0;
			var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
			var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
			List<BagInfo> equipInfos = self.BagComponent.GetItemsByType(ItemTypeEnum.Equipment);

			for (int i = 0; i < equipInfos.Count; i++)
			{
				if (equipInfos[i].IfJianDing)
				{
					continue;
				}

				UI uI = null;
				if (number < self.EquipUIList.Count)
				{
					uI = self.EquipUIList[number];
					uI.GameObject.SetActive(true);
				}
				else
				{
					GameObject go = GameObject.Instantiate(bundleGameObject);
					UICommonHelper.SetParent(go, self.EquipListNode);
					uI = self.AddChild<UI, string, GameObject>("XiLianItem", go);
					UIItemComponent uIItemComponent = uI.AddComponent<UIItemComponent>();
					uIItemComponent.SetClickHandler((BagInfo bagInfo) => { self.OnSelectItem(bagInfo); });
					self.EquipUIList.Add(uI);
				}
				number++;
				uI.GetComponent<UIItemComponent>().UpdateItem(equipInfos[i], ItemOperateEnum.ItemXiLian);
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
				self.EquipUIList[0].GetComponent<UIItemComponent>().OnClickUIItem();
			}
		}

		public static void OnSelectItem(this UIRoleXiLianShowComponent self, BagInfo bagInfo)
		{
			self.XilianBagInfo = bagInfo;
			for (int i = 0; i < self.EquipUIList.Count; i++)
			{
				self.EquipUIList[i].GetComponent<UIItemComponent>().SetSelected(bagInfo);
			}
			self.OnUpdateXinLian();
		}

		public static async ETTask InitSubItemUI(this UIRoleXiLianShowComponent self)
		{
			var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
			var bundleGameObject =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

			GameObject go = GameObject.Instantiate(bundleGameObject);
			UICommonHelper.SetParent(go, self.UIXiLianItemNode);
			self.XiLianItemUI = self.AddChild<UI, string, GameObject>("XiLianItem", go);
			self.XiLianItemUI.AddComponent<UIItemComponent>();
			self.XiLianItemUI.GetComponent<UIItemComponent>().Label_ItemName.SetActive(true);

			go = GameObject.Instantiate(bundleGameObject);
			UICommonHelper.SetParent(go, self.CostItem);
			self.CostItemUI = self.AddChild<UI, string, GameObject>("CostItemUI", go);
			UIItemComponent uIItemComponent = self.CostItemUI.AddComponent<UIItemComponent>();
			uIItemComponent.Label_ItemNum.SetActive(false);
			uIItemComponent.Label_ItemName.SetActive(false);

			BagInfo bagInfo = self.XilianBagInfo;
			self.CostItem.SetActive(bagInfo != null);
			if (bagInfo != null)
			{
				ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
				self.XiLianItemUI.GetComponent<UIItemComponent>().UpdateItem(bagInfo, ItemOperateEnum.None);
			}
		}

		public static async ETTask OnXiLianButton(this UIRoleXiLianShowComponent self)
		{
			if (self.XilianBagInfo == null)
			{
				return;
			}

			BagInfo bagInfo = self.XilianBagInfo;
			ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
			List<RewardItem> costItems = new List<RewardItem>();
			int[] itemCost = itemConfig.XiLianStone;
			if (itemCost != null && itemCost.Length > 0)
			{
				costItems.Add(new RewardItem() { ItemID = itemCost[0], ItemNum = itemCost[1] });
			}

			if (!self.BagComponent.CheckNeedItem(costItems))
			{
				FloatTipManager.Instance.ShowFloatTip("材料不足！");
				return;
			}

			await self.BagComponent.SendXiLian(self.XilianBagInfo);
			self.OnXiLianReturn();
		}
	}
}
