using System.Collections.Generic;
using System.Linq;

namespace ET
{
	[ObjectSystem]
	public class GuideComponentAwakeSystem : AwakeSystem<GuideComponent>
	{
		public override void Awake(GuideComponent self)
		{
			self.Awake();
		}
	}

	public static class GuideComponentSystem
    {
		public static void Awake(this GuideComponent self)
		{
			//self.GuideInfoDict.Clear();
			//List<int> guideOpenList = new List<int>() {  };
			//List<GuideConfig> guideConfigs = GuideConfigCategory.Instance.GetAll().Values.ToList();
			//for (int i = 0; i < guideConfigs.Count; i++)
			//{
			//	if (guideConfigs[i].NextID == 0)
			//	{
			//		guideOpenList.Add(guideConfigs[i].Id);
			//	}
			//}

			//for (int i = 0; i < guideOpenList.Count; i++)
			//{
			//	GuideInfo guideInfo = self.AddChild<GuideInfo, int>(guideOpenList[i]);
			//	self.GuideInfoDict.Add(guideOpenList[i], guideInfo);
			//	int nextId = guideOpenList[i];
			//	while (nextId > 0)
			//	{
			//		GuideConfig guideConfig = GuideConfigCategory.Instance.Get(nextId);

			//		guideInfo.Ids.Add(nextId);
			//		nextId = guideConfig.NextID;
			//	}
			//}
		}


		public static void SetGuideId(this GuideComponent self, int guideid)
		{
			if (self.GuideInfo != null)
			{
				self.GuideInfo.Dispose();
				self.GuideInfo = null;
			}
			if (GuideConfigCategory.Instance.Contain(guideid))
			{
				self.GuideInfo = self.AddChild<GuideInfo, int>(guideid);
			}
		}

		public static void OnOpenUI(this GuideComponent self, string uiType)
		{
			self.OnTrigger(GuideTriggerType.OpenUI, uiType);
		}

		public static void OnNext(this GuideComponent self)
		{
			if (self.GuideInfo == null)
			{
				return;
			}
			self.GuideInfo.OnNext();
			self.SetGuideId(self.GuideInfo.GuideId + 1);
		}

		public static  void SendUpdateGuide(this GuideComponent self, int guideId)
		{
			//C2M_GuideUpdateRequest c2M_ItemHuiShouRequest = new C2M_GuideUpdateRequest() { GuideId = guideId };
			//M2C_GuideUpdateResponse r2c_roleEquip = (M2C_GuideUpdateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
			//UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
			//userInfoComponent.UserInfo.CompleteGuideIds.Add(guideId);
		}

		public static void OnTrigger(this GuideComponent self, int triggerType, string triggeParasm)
		{
			if (self.GuideInfo == null)
			{
				return;
			}
			
			GuideConfig guideConfig = GuideConfigCategory.Instance.Get(self.GuideInfo.GuideId);

			Log.Debug($"GuideComponent_OnTrigger : {self.GuideInfo.GuideId}  {triggeParasm}");
			if (triggeParasm != guideConfig.TrigerParams)
			{
				return;
			}

			self.GuideInfo.OnUpdate();
		}
	}
}
