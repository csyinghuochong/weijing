using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFirstWinComponent : Entity, IAwake, IDestroy
    {

		public GameObject Text_JiSha_3;
		public GameObject Text_JiSha_2;
		public GameObject Text_JiSha_1;
		public GameObject Text_SkillJieShao;
		public GameObject Text_UpdateStatus;
		public GameObject Text_BossName;
		public GameObject Button_FirstWin;
		public GameObject RewardListNode;
		public GameObject ImageBossIcon;
		public GameObject RawImage;

		public GameObject TypeListNode;
		public UITypeViewComponent UITypeViewComponent;
		public UIFirstWinRewardComponent UIFirstWinReward;
		public List<FirstWinInfo> FirstWinInfos = new List<FirstWinInfo>();
		public List<UIItemComponent> UIItemComponents = new List<UIItemComponent>();	

		public int FirstWinId;
		public long LastUpdateTime;

		public UIModelShowComponent UIModelShowComponent;
	}

    [ObjectSystem]
    public class UIFirstWinComponentAwakeSystem : AwakeSystem<UIFirstWinComponent>
    {
        public override void Awake(UIFirstWinComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

			self.FirstWinId = 0;
			self.LastUpdateTime = 0;
			self.UIItemComponents.Clear();
			self.Text_JiSha_3 = rc.Get<GameObject>("Text_JiSha_3");
			self.Text_JiSha_2 = rc.Get<GameObject>("Text_JiSha_2");
			self.Text_JiSha_1 = rc.Get<GameObject>("Text_JiSha_1");
			self.Text_SkillJieShao = rc.Get<GameObject>("Text_SkillJieShao");
			self.Text_UpdateStatus = rc.Get<GameObject>("Text_UpdateStatus");
			self.Text_BossName = rc.Get<GameObject>("Text_BossName");

			self.RawImage = rc.Get<GameObject>("RawImage");
			//模型展示界面
			var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
			GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
			GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
			UICommonHelper.SetParent(gameObject, self.RawImage);
			UI ui = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject);
			self.UIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);
			//配置摄像机位置[0,115,257]
			gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 115, 394f);

			self.Button_FirstWin = rc.Get<GameObject>("Button_FirstWin");
			self.Button_FirstWin.GetComponent<Button>().onClick.AddListener( self.OnButton_FirstWin);

			self.RewardListNode = rc.Get<GameObject>("RewardListNode");
			self.ImageBossIcon = rc.Get<GameObject>("ImageBossIcon");

			self.TypeListNode = rc.Get<GameObject>("TypeListNode");

			GameObject UIFirstWinReward = rc.Get<GameObject>("UIFirstWinReward");
			self.UIFirstWinReward = self.AddChild<UIFirstWinRewardComponent, GameObject>(UIFirstWinReward);
			UIFirstWinReward.SetActive(false);

			self.UITypeViewComponent = self.AddChild<UITypeViewComponent, GameObject>(self.TypeListNode);
			self.UITypeViewComponent.TypeButtonItemAsset = ABPathHelper.GetUGUIPath("Main/ZhanQu/UIFirstWinTypeItem"); 
			self.UITypeViewComponent.TypeButtonAsset = ABPathHelper.GetUGUIPath("Main/ZhanQu/UIFirstWinType");
			self.UITypeViewComponent.ClickTypeItemHandler = (int typeid, int subtypeid) => { self.OnClickTypeItem(typeid, subtypeid); };

			self.UITypeViewComponent.TypeButtonInfos = self.InitTypeButtonInfos();
			self.UITypeViewComponent.OnInitUI().Coroutine();
		
			self.ReqestFirstWinInfo().Coroutine();
		}
    }

    public static class UIFirstWinComponentSystem
    {

		public static void OnButton_FirstWin(this UIFirstWinComponent self)
		{
			self.UIFirstWinReward.OnUpdateUI( self.FirstWinId );
		}

		public static async ETTask ReqestFirstWinInfo(this UIFirstWinComponent self)
		{
			try
			{
				long instance = self.InstanceId;
				C2A_FirstWinInfoRequest request = new C2A_FirstWinInfoRequest();
				A2C_FirstWinInfoResponse response = (A2C_FirstWinInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
				if (instance != self.InstanceId)
				{
					return;
				}
				self.FirstWinInfos = response.FirstWinInfos;
				self.UpdateBossInfo(self.FirstWinId);
			}
			catch (Exception ex)
			{
				Log.Error(ex.ToString());
			}
		}

		public static List<TypeButtonInfo> InitTypeButtonInfos(this UIFirstWinComponent self)
		{
			Dictionary<int, List<int>> keyValuePairs = self.GetFirstWinList();

			List<TypeButtonInfo> typeButtonInfos = new List<TypeButtonInfo>();

			foreach (var item in keyValuePairs)
			{
				List<TypeButtonItem> typeButtonItems = new List<TypeButtonItem>();
				for (int b = 0; b < item.Value.Count; b++)
				{
					int bossId = FirstWinConfigCategory.Instance.Get(item.Value[b]).BossID;
					typeButtonItems.Add( new TypeButtonItem() 
					{
						SubTypeId = item.Value[b], 
						ItemName = MonsterConfigCategory.Instance.Get(bossId).MonsterName
					} );
				}

				typeButtonInfos.Add(new TypeButtonInfo()
				{
					TypeId = item.Key,
					TypeName = $"第{item.Key}章",
					typeButtonItems = typeButtonItems
				});
			}

			return typeButtonInfos;
		}

		public static Dictionary<int, List<int>> GetFirstWinList(this UIFirstWinComponent self)
		{
			Dictionary<int , List<int>> keyValuePairs = new Dictionary<int , List<int>>();	
			List<FirstWinConfig>  firstWinConfigs = FirstWinConfigCategory.Instance.GetAll().Values.ToList();
			for (int i = 0; i < firstWinConfigs.Count; i++)
			{
				FirstWinConfig firstWinConfig = firstWinConfigs[i];
				if (!keyValuePairs.ContainsKey(firstWinConfig.ChatperId))
				{
					keyValuePairs.Add(firstWinConfig.ChatperId, new List<int>());
				}
				keyValuePairs[firstWinConfig.ChatperId].Add(firstWinConfig.Id);
			}
			return keyValuePairs;
		}

		public static void OnClickTypeItem(this UIFirstWinComponent self, int typeid, int firstwinId)
		{
			if (self.FirstWinId == firstwinId)
			{
				return;	
			}
			if (TimeHelper.ServerNow() - self.LastUpdateTime < 500)
			{
				return;
			}
			self.LastUpdateTime = TimeHelper.ServerNow();
			self.FirstWinId = firstwinId;
			self.UpdateBossInfo(firstwinId);
		}

		public static FirstWinInfo GetFirstWinInfo(this UIFirstWinComponent self, int firstWinId, int difficulty)
		{
			for (int i = 0; i < self.FirstWinInfos.Count; i++)
			{
				if (self.FirstWinInfos[i].FirstWinId == firstWinId
				&&	self.FirstWinInfos[i].Difficulty == difficulty)
				{ 
					return self.FirstWinInfos[i];
				}
			}
			return null;
		}

		public static bool IsUpdateStatus(this UIFirstWinComponent self, int bossId)
		{
			UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;

			for (int i = 0; i < userInfo.MonsterRevives.Count; i++)
			{
				if (userInfo.MonsterRevives[i].KeyId == bossId)
				{
					long relime = long.Parse(userInfo.MonsterRevives[i].Value);
					return relime <= TimeHelper.ServerNow();
				}
			}
			return true;
		}

		public static void UpdateRewardList(this UIFirstWinComponent self, List<RewardItem> itemList)
		{
			var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
			var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);

			int number = 0;
			for (int i = 0; i < itemList.Count; i++)
			{
				RewardItem rewardItem = itemList[i];
				UIItemComponent uIItemComponent = null;
				if (number < self.UIItemComponents.Count)
				{
					uIItemComponent = self.UIItemComponents[i];
					uIItemComponent.GameObject.SetActive(true);
				}
				else
				{
					GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
					UICommonHelper.SetParent(itemSpace, self.RewardListNode);
					uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
					uIItemComponent.Label_ItemName.SetActive(false);
					uIItemComponent.Label_ItemNum.SetActive(false);
					itemSpace.transform.localScale = Vector3.one * 1f;
					self.UIItemComponents.Add(uIItemComponent);
				}
				uIItemComponent.UpdateItem(new BagInfo() { ItemID = rewardItem.ItemID, ItemNum = rewardItem.ItemNum }, ItemOperateEnum.None);
				number++;
			}
			for (int i = number; i < self.UIItemComponents.Count; i++)
			{
				self.UIItemComponents[i].GameObject.SetActive(false);
			}
		}

		public static void UpdateBossInfo(this UIFirstWinComponent self, int firstwinId)
		{
			if (firstwinId == 0)
			{
				return;
			}
			int bossId = FirstWinConfigCategory.Instance.Get(firstwinId).BossID;
			MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(bossId);
			self.Text_BossName.GetComponent<Text>().text = monsterConfig.MonsterName;
			//Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.MonsterIcon, monsterConfig.MonsterHeadIcon.ToString());
			//self.ImageBossIcon.GetComponent<Image>().sprite = sp;

			MonsterConfigCategory.Instance.Get(bossId);
			self.UIModelShowComponent.ShowOtherModel("Monster/" + monsterConfig.MonsterModelID.ToString()).Coroutine();

			string skilldesc = "";
			int[] skilllist = monsterConfig.SkillID;
			for (int i = 0; i < skilllist.Length; i++)
			{
				if (skilllist[i] == 0)
				{
					continue;
				}
				SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skilllist[i]);
				skilldesc = skilldesc + skillConfig.SkillName +  " " + skillConfig.SkillDescribe + "\n";
			}
			self.Text_SkillJieShao.GetComponent<Text>().text = skilldesc;
			bool updatestatus = self.IsUpdateStatus(bossId);
			self.Text_UpdateStatus.GetComponent<Text>().text = updatestatus ? "(已刷新)" : "(未刷新)";
			self.Text_UpdateStatus.GetComponent<Text>().color = updatestatus ? new Color(25f/255,180f/255f,25f/255f) : new Color(50f / 255, 50f / 255f, 50f / 255f);
			List<RewardItem> droplist = DropHelper.AI_MonsterDrop(monsterConfig.Id, 1f, true);
			List<int> itemIdList = new List<int>();
			for (int i = droplist.Count - 1; i >=0;  i--)
			{
				if (itemIdList.Contains(droplist[i].ItemID))
				{
					droplist.RemoveAt(i);
					continue;
				}
				ItemConfig itemConfig = ItemConfigCategory.Instance.Get( droplist[i].ItemID );
				if (itemConfig.ItemQuality < 4)
				{
					droplist.RemoveAt(i);
					continue;
				}
				itemIdList.Add(droplist[i].ItemID);
			}
			
			self.UpdateRewardList(droplist);

			FirstWinInfo firstWinInfo_1 = self.GetFirstWinInfo(firstwinId, 1);
			FirstWinInfo firstWinInfo_2 = self.GetFirstWinInfo(firstwinId, 2);
			FirstWinInfo firstWinInfo_3 = self.GetFirstWinInfo(firstwinId, 3);
			self.ShowJiShaTime(firstWinInfo_1, self.Text_JiSha_1);
			self.ShowJiShaTime(firstWinInfo_2, self.Text_JiSha_2);
			self.ShowJiShaTime(firstWinInfo_3, self.Text_JiSha_3);
		}


		public static void ShowJiShaTime(this UIFirstWinComponent self, FirstWinInfo firstWinInfo, GameObject Text_JiSha_1)
		{
			if (firstWinInfo != null)
			{
				Text_JiSha_1.GetComponent<Text>().text = $"{firstWinInfo.PlayerName} (时间： {TimeInfo.Instance.ToDateTime(firstWinInfo.KillTime).ToString()})";
			}
			else
			{
				Text_JiSha_1.GetComponent<Text>().text = "暂无上榜!";
			}
		}
	}
}