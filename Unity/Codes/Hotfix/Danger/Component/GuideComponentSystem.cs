using System.Collections.Generic;
using System.Linq;

namespace ET
{
	[ObjectSystem]
	public class GuideComponentAwakeSystem : AwakeSystem<GuideComponent>
	{
		public override void Awake(GuideComponent self)
		{
			self.GuideInfoDict.Clear();
			//self.Awake();
		}
	}

	public static class GuideComponentSystem
    {

		public static void Awake(this GuideComponent self)
		{
			List<int> guideOpenList = new List<int>() {  };
			List<GuideConfig> guideConfigs = GuideConfigCategory.Instance.GetAll().Values.ToList();
			for (int i = 0; i < guideConfigs.Count; i++)
			{
				if (guideConfigs[i].Triger.Length > 1)
				{
					guideOpenList.Add(guideConfigs[i].Id);
				}
			}

			for (int i = 0; i < guideOpenList.Count; i++)
			{
				GuideInfo guideInfo = self.AddChild<GuideInfo, int>(guideOpenList[i]);
				self.GuideInfoDict.Add(guideOpenList[i], guideInfo);
				int nextId = guideOpenList[i];
				while (nextId > 0)
				{
					GuideConfig guideConfig = GuideConfigCategory.Instance.Get(nextId);

					guideInfo.Ids.Add(nextId);
					nextId = guideConfig.NextID;
				}
			}
		}

		/// <summary>
		/// 进入游戏
		/// </summary>
		/// <param name="self"></param>
		public static void FirstEnter(this GuideComponent self)
		{
			//UserInfoComponent userInfo = self.ZoneScene().GetComponent<UserInfoComponent>();
			//self.OnTrigger(GuideTriggerType.GuideTriggerLevel, userInfo.UserInfo.Lv);
		}

		public static void OnNext(this GuideComponent self, int guideId)
		{
			self.GuideInfoDict[guideId].OnNext();
		}

		public static async ETTask SendUpdateGuide(this GuideComponent self, int guideId)
		{
			C2M_GuideUpdateRequest c2M_ItemHuiShouRequest = new C2M_GuideUpdateRequest() { GuideId = guideId };
			M2C_GuideUpdateResponse r2c_roleEquip = (M2C_GuideUpdateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
			UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
			userInfoComponent.UserInfo.CompleteGuideIds.Add(guideId);
		}

		public static void OnTrigger(this GuideComponent self, int trigger, int level)
		{
			List<GuideInfo> guideInfos = self.GuideInfoDict.Values.ToList();
			for (int i = 0; i < guideInfos.Count; i++)
			{
				if (guideInfos[i].IsDone())
				{
					continue;
				}
				GuideConfig guideConfig = guideInfos[i].GuideConfig;
				if (guideConfig.Triger.Length < 3 || guideConfig.Triger[0] != trigger)
				{
					continue;
				}
				if (GuideTriggerType.GuideTriggerLevel == trigger && level >= guideConfig.Triger[1])
				{
					guideInfos[i].OnUpdate();
				}
			}
		}
	}
}
