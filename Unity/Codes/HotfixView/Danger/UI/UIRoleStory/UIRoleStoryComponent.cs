using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIRoleStoryComponent : Entity, IAwake
	{

        public GameObject closeButton;
		public int TaskId;
    }

	[ObjectSystem]
	public class UIRoleStoryComponentwakeSystem : AwakeSystem<UIRoleStoryComponent>
	{
		public override void Awake(UIRoleStoryComponent self)
		{
			ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
			
			self.closeButton = rc.Get<GameObject>("Btn_ShowNextSpeak");
			self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseStory(); });
		}
	}

	public static class UIRoleStoryComponentSystem
	{
		public static void OnCloseStory(this UIRoleStoryComponent self)
		{
			NetHelper.SendTaskNotice(self.DomainScene(), self.TaskId).Coroutine();
			UIHelper.Remove(self.ZoneScene(), UIType.UIStorySpeak).Coroutine();
		}

		public static void OnUpdateInfo(this UIRoleStoryComponent self, int taskid)
		{
			self.TaskId = taskid;
		}
	}
}
