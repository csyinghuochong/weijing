using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public enum RolePageEnum : int
	{
		RoleBag = 0,
		RoleProperty = 1,
		RoleGem = 2,
		RoleHuiShou = 3,
		RoleQiangHua = 4,

		Number,
	}

	public class UIRoleComponent : Entity, IAwake, IDestroy
	{
		public GameObject EquipSet;
		public GameObject ObjLabRoleLv;
		public GameObject ObjLabRoleName;
		public GameObject ObjLab_RoseComBat;
		public GameObject ObjLab_RoseOccShow;
		public GameObject ButtonZodiac;

		public GameObject RawImage;
		public UIPageButtonComponent UIPageButton;

		public UIEquipSetComponent UIEquipSetComponent;
		public UIPageViewComponent UIPageView;
	}

	public class ShowPropertyList {

		public int numericType;
		public string name;
		public string iconID;
		public int Type;			//1表示整数  2表示小数
	}

	[ObjectSystem]
	public class UIRoleComponentAwakeSystem : AwakeSystem<UIRoleComponent>
	{
		public override void Awake(UIRoleComponent self)
		{
			ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
			self.EquipSet = rc.Get<GameObject>("EquipSet");
			self.RawImage = rc.Get<GameObject>("RawImage");
			GameObject pageView = rc.Get<GameObject>("SubViewNode");
			UI uiPageView = self.AddChild<UI, string, GameObject>( "FunctionBtnSet", pageView);
			UIPageViewComponent pageViewComponent = uiPageView.AddComponent<UIPageViewComponent>();
			pageViewComponent.UISubViewList = new UI[(int)RolePageEnum.Number];
			pageViewComponent.UISubViewPath = new string[(int)RolePageEnum.Number];
			pageViewComponent.UISubViewType = new Type[(int)RolePageEnum.Number];

			pageViewComponent.UISubViewPath[(int)RolePageEnum.RoleBag] = ABPathHelper.GetUGUIPath("Main/Role/UIRoleBag");
			pageViewComponent.UISubViewPath[(int)RolePageEnum.RoleProperty] = ABPathHelper.GetUGUIPath("Main/Role/UIRoleProperty");
			pageViewComponent.UISubViewPath[(int)RolePageEnum.RoleGem] = ABPathHelper.GetUGUIPath("Main/Role/UIRoleGem");
			pageViewComponent.UISubViewPath[(int)RolePageEnum.RoleHuiShou] = ABPathHelper.GetUGUIPath("Main/Role/UIRoleHuiShou");
			pageViewComponent.UISubViewPath[(int)RolePageEnum.RoleQiangHua] = ABPathHelper.GetUGUIPath("Main/Role/UIRoleQiangHua");

			pageViewComponent.UISubViewType[(int)RolePageEnum.RoleBag] = typeof(UIRoleBagComponent);
			pageViewComponent.UISubViewType[(int)RolePageEnum.RoleProperty] = typeof(UIRolePropertyComponent);
			pageViewComponent.UISubViewType[(int)RolePageEnum.RoleGem] = typeof(UIRoleGemComponent);
			pageViewComponent.UISubViewType[(int)RolePageEnum.RoleHuiShou] = typeof(UIRoleHuiShouComponent);
			pageViewComponent.UISubViewType[(int)RolePageEnum.RoleQiangHua] = typeof(UIRoleQiangHuaComponent);
			self.UIPageView = pageViewComponent;

			self.ObjLabRoleLv = rc.Get<GameObject>("Lab_RoseLv");
			self.ObjLabRoleName = rc.Get<GameObject>("Lab_RoseName");
			self.ObjLab_RoseComBat = rc.Get<GameObject>("Lab_RoseComBat");
			self.ObjLab_RoseOccShow = rc.Get<GameObject>("Lab_RoseOccShow");

			AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
			self.ButtonZodiac = rc.Get<GameObject>("ButtonZodiac");
			self.ButtonZodiac.SetActive(GMHelp.GmAccount.Contains(accountInfoComponent.Account));
			ButtonHelp.AddListenerEx(self.ButtonZodiac, () => { self.OnButtonZodiac().Coroutine(); });


			//初始化显示背包
			self.InitSubView();

			//单选组件
			GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
			UI uiPage = self.AddChild<UI, string, GameObject>( "FunctionSetBtn", BtnItemTypeSet);
			UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
				uIPageViewComponent.SetClickHandler((int page) => { self.OnClickPageButton(page);
			});
			self.UIPageButton = uIPageViewComponent;
			uIPageViewComponent.OnSelectIndex(0);

			//IOS适配
			IPHoneHelper.SetPosition(BtnItemTypeSet, new Vector2(300f, 316f));
			DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);
			DataUpdateComponent.Instance.AddListener(DataType.EquipWear, self);
			DataUpdateComponent.Instance.AddListener(DataType.HuiShouSelect, self);
			DataUpdateComponent.Instance.AddListener(DataType.EquipHuiShow, self);

			ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
			redPointComponent.RegisterReddot(ReddotType.RolePoint, self.Reddot_RolePoint);

			self.InitBagUI();
		}
	}


	[ObjectSystem]
	public class UIRoleComponentDestroySystem : DestroySystem<UIRoleComponent>
	{
		public override void Destroy(UIRoleComponent self)
		{
			DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
			DataUpdateComponent.Instance.RemoveListener(DataType.EquipWear, self);
			DataUpdateComponent.Instance.RemoveListener(DataType.HuiShouSelect, self);
			DataUpdateComponent.Instance.RemoveListener(DataType.EquipHuiShow, self);

			ReddotViewComponent redPointComponent = self.DomainScene().GetComponent<ReddotViewComponent>();
			redPointComponent.UnRegisterReddot(ReddotType.RolePoint, self.Reddot_RolePoint);
		}
	}

	public static class UIRoleComponentSystem
	{

		public static async ETTask OnButtonZodiac(this UIRoleComponent self)
		{
			UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIRoleZodiac);
			UIEquipSetComponent EquipSetComponent = self.UIEquipSetComponent;
			uI.GetComponent<UIRoleZodiacComponent>().OnInitUI(EquipSetComponent.EquipInfoList, EquipSetComponent.Occ, EquipSetComponent.ItemOperateEnum);

			self.ButtonZodiac.SetActive(false);
			self.UIEquipSetComponent.GameObject.SetActive(false);
		}

		public static void OnCloseRoleZodiac(this UIRoleComponent self)
		{
			self.ButtonZodiac.SetActive(true);
			self.UIEquipSetComponent.GameObject.SetActive(true);
		}

		public static void Reddot_RolePoint(this UIRoleComponent self, int num)
		{
			self.UIPageButton.SetButtonReddot((int)RolePageEnum.RoleProperty, num > 0);
		}

		//点击回调
		public static void OnClickPageButton(this UIRoleComponent self, int page)
		{
			bool showEquip = page == 0 || page == 1 || page == 2;
			self.UIPageView.OnSelectIndex(page).Coroutine();
			self.EquipSet.SetActive(showEquip);
			self.UpdateEquipSet();
			if (showEquip)
			{
				self.UIEquipSetComponent.PlayShowIdelAnimate(null);
			}
			if (page == 0)
			{
				self.OnCloseRoleZodiac();
			}
			UIHelper.Remove(self.ZoneScene(), UIType.UIRoleZodiac);
			self.UIEquipSetComponent.EquipSetHide(page!= 2);
		}

		public static void UpdateEquipSet(this UIRoleComponent self)
		{
			BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
			UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
			self.UIEquipSetComponent.UpdateBagUI(bagComponent.GetEquipList(), userInfoComponent.UserInfo.Occ, ItemOperateEnum.Juese);
		}

		//初始化背包界面
		public static void InitSubView(this UIRoleComponent self)
		{
			UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;

			//显示基本信息
			self.ObjLabRoleLv.GetComponent<Text>().text = userInfo.Lv.ToString();
			self.ObjLabRoleName.GetComponent<Text>().text = userInfo.Name;

			self.UIEquipSetComponent = self.AddChild<UIEquipSetComponent, GameObject, int>(self.EquipSet, 0);

			BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
			BagInfo bagInfo = bagComponent.GetEquipBySubType((int)ItemSubTypeEnum.Wuqi);

			self.UIEquipSetComponent.ShowPlayerModel(bagInfo, userInfo.Occ);
			int occTwo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.OccTwo;
			if (occTwo != 0) 
			{
				//转职
				self.ObjLab_RoseOccShow.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("职业") + ": " + OccupationTwoConfigCategory.Instance.Get(occTwo).OccupationName;
			}
			else 
			{
				//未转职
				int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
				self.ObjLab_RoseOccShow.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("职业") + ": " + OccupationConfigCategory.Instance.Get(occ).OccupationName;
			}

			self.UpdateShowComBat();
		}

		public static void UpdateShowComBat(this UIRoleComponent self) 
		{
			//显示战力
			long combat = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Combat;
			self.ObjLab_RoseComBat.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("战力") + ": " + combat;
		}

		public static void OnCloseEquip(this UIRoleComponent self)
		{
			UIHelper.Remove(self.ZoneScene(), UIType.UIRole);
		}

		public static void OnEquipWear(this UIRoleComponent self, string DataParams)
		{
			BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
			UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
			BagInfo bagInfo = bagComponent.GetEquipBySubType((int)ItemSubTypeEnum.Wuqi);
			self.UIEquipSetComponent.ChangeWeapon(bagInfo, userInfoComponent.UserInfo.Occ);
		}

		public static void InitBagUI(this UIRoleComponent self)
		{
			ReddotComponent reddotComponent = self.ZoneScene().GetComponent<ReddotComponent>();
			reddotComponent.UpdateReddont(ReddotType.RolePoint);

			UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
			self.UIEquipSetComponent.PlayerLv(userInfoComponent.UserInfo.Lv);
			self.UIEquipSetComponent.PlayerName(userInfoComponent.UserInfo.Name);
			self.UpdateEquipSet();
		}

		public static void UpdateBagUI(this UIRoleComponent self)
		{
			UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
			self.UIEquipSetComponent.PlayerLv(userInfoComponent.UserInfo.Lv);
			self.UIEquipSetComponent.PlayerName(userInfoComponent.UserInfo.Name);
			UI[] uilist = self.UIPageView.UISubViewList;
			uilist[(int)RolePageEnum.RoleBag]?.GetComponent<UIRoleBagComponent>().UpdateBagUI(-1);
			uilist[(int)RolePageEnum.RoleGem]?.GetComponent<UIRoleGemComponent>().UpdateBagUI();

			self.UpdateEquipSet();
		}

		public static void OnHuiShouSelect(this UIRoleComponent self, string param_1)
		{
			UI uI = self.UIPageView.UISubViewList[(int)RolePageEnum.RoleHuiShou];
			uI?.GetComponent<UIRoleHuiShouComponent>().OnHuiShouSelect(param_1);
		}


		public static void OnEquipHuiShow(this UIRoleComponent self)
		{
			self.UIPageView.UISubViewList[(int)RolePageEnum.RoleHuiShou].GetComponent<UIRoleHuiShouComponent>().OnEquipHuiShow();
		}

		public static void OnClickXiangQianItem(this UIRoleComponent self, BagInfo bagInfo)
		{
			UI[] uilist = self.UIPageView.UISubViewList;
			uilist[(int)RolePageEnum.RoleGem]?.GetComponent<UIRoleGemComponent>().OnClickXiangQianItem(bagInfo);
		}
	}
}
