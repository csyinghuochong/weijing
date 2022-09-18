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

		public GameObject TypeListNode;
		public UITypeViewComponent UITypeViewComponent;
		public UIFirstWinRewardComponent UIFirstWinReward;
		public List<FirstWinInfo> firstWinInfos = new List<FirstWinInfo>();

		public int FirstWinId;
	}

    [ObjectSystem]
    public class UIFirstWinComponentAwakeSystem : AwakeSystem<UIFirstWinComponent>
    {
        public override void Awake(UIFirstWinComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

			self.Text_JiSha_3 = rc.Get<GameObject>("Text_JiSha_3");
			self.Text_JiSha_2 = rc.Get<GameObject>("Text_JiSha_2");
			self.Text_JiSha_1 = rc.Get<GameObject>("Text_JiSha_1");
			self.Text_SkillJieShao = rc.Get<GameObject>("Text_SkillJieShao");
			self.Text_UpdateStatus = rc.Get<GameObject>("Text_UpdateStatus");
			self.Text_BossName = rc.Get<GameObject>("Text_BossName");

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
			C2A_FirstWinInfoRequest	 request = new C2A_FirstWinInfoRequest();
			A2C_FirstWinInfoResponse response = (A2C_FirstWinInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
			self.firstWinInfos = response.FirstWinInfos;
			self.UpdateBossInfo(self.FirstWinId);
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
			self.FirstWinId = firstwinId;
			self.UpdateBossInfo(firstwinId);
		}

		public static FirstWinInfo GetFirstWinInfo(this UIFirstWinComponent self, int firstWinId, int difficulty)
		{
			for (int i = 0; i < self.firstWinInfos.Count; i++)
			{
				if (self.firstWinInfos[i].FirstWinId == firstWinId
				&&	self.firstWinInfos[i].Difficulty == difficulty)
				{ 
					return self.firstWinInfos[i];
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
			UICommonHelper.DestoryChild(self.RewardListNode);
			List<RewardItem> droplist = DropHelper.AI_MonsterDrop(monsterConfig.Id, 1f, true);
			string showList = "";
			for (int i = 0; i < droplist.Count; i++)
			{
				if (showList.Contains(droplist[i].ItemID.ToString()))
				{
					continue;
				}
				ItemConfig itemConfig = ItemConfigCategory.Instance.Get( droplist[i].ItemID );
				if (itemConfig.ItemQuality < 4)
				{
					continue;
				}
				showList = showList + $"{droplist[i].ItemID};1@";
			}
			if (showList.Length > 0)
			{
				showList = showList.Substring(0, showList.Length - 1);
			}
			UICommonHelper.ShowItemList(showList, self.RewardListNode, self, 1f, false).Coroutine();

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