using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITaskComponent : Entity, IAwake, IDestroy
	{
		public GameObject Text_expValue;
		public GameObject Button_Giveup;
		public GameObject Button_Going;
		public GameObject Text_jinbiValue;
		public GameObject Text_taskTarget;
		public GameObject Text_jiangliText;
		public GameObject Button_CancelZhuizong ;
		public GameObject Button_Zhuizong;
		public GameObject RewardListNode;
		public GameObject TypeListNode;
		public GameObject ImageButton;

		public int TaskId;
		public TaskPro TaskPro;
		public TaskConfig TaskConfig;

		public List<UI> TaskTypeUIList;
		public List<UI> RewardUIList;
		public TaskComponent TaskComponent;
	}

	[ObjectSystem]
	public class UIRoleTaskComponentAwakeSystem : AwakeSystem<UITaskComponent>
	{
		public override void Awake(UITaskComponent self)
		{
			self.RewardUIList = new List<UI>();
			self.TaskTypeUIList = new List<UI>();
			ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

			self.Text_expValue = rc.Get<GameObject>("Text_expValue");

			self.Button_Giveup = rc.Get<GameObject>("Button_Giveup");
			self.Button_Giveup.GetComponent<Button>().onClick.AddListener(() => { self.OnGiveUpTask(); });

			self.Button_Going = rc.Get<GameObject>("Button_Going");
			self.Button_Going.GetComponent<Button>().onClick.AddListener(() => { self.OnExcuteTask(); });

			self.Text_jinbiValue = rc.Get<GameObject>("Text_jinbiValue");
			self.Text_taskTarget = rc.Get<GameObject>("Text_taskTarget");
			self.Text_jiangliText = rc.Get<GameObject>("Text_jiangliText");


			self.Button_CancelZhuizong = rc.Get<GameObject>("Button_CancelZhuizong");
			self.Button_CancelZhuizong.GetComponent<Button>().onClick.AddListener(() => { self.OnTrackTask(false); });
			self.Button_Zhuizong = rc.Get<GameObject>("Button_Zhuizong");
			self.Button_Zhuizong.GetComponent<Button>().onClick.AddListener(() => { self.OnTrackTask(true); });

			self.RewardListNode = rc.Get<GameObject>("RewardListNode");
			self.TypeListNode = rc.Get<GameObject>("TypeListNode");

			self.ImageButton = rc.Get<GameObject>("ImageButton");
			self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseTask(); });

			self.TaskComponent = self.ZoneScene().GetComponent<TaskComponent>();

			DataUpdateComponent.Instance.AddListener(DataType.TaskUpdate, self);
			DataUpdateComponent.Instance.AddListener(DataType.TaskGiveUp, self);

			self.InitTaskTypeList();
		}
	}

	[ObjectSystem]
	public class UIRoleTaskComponentDestroySystem : DestroySystem<UITaskComponent>
	{
		public override void Destroy(UITaskComponent self)
		{
			DataUpdateComponent.Instance.RemoveListener(DataType.TaskUpdate, self);
			DataUpdateComponent.Instance.RemoveListener(DataType.TaskGiveUp, self);
		}
	}

	public static class UIRoleTaskComponentSystem
	{

		public static void OnTaskGiveUp(this UITaskComponent self)
		{
			self.TaskTypeUIList[1].GetComponent<UITaskTypeComponent>().OnTaskGiveUp();
		}

		public static  void InitTaskTypeList(this UITaskComponent self)
		{
			string path = ABPathHelper.GetUGUIPath("Main/Task/UITaskType");
			GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

			List<int> ids = new List<int>() { (int)TaskTypeEnum.Main, (int)TaskTypeEnum.Branch, (int)TaskTypeEnum.EveryDay };
			for (int i = 0; i < ids.Count; i++)
			{
				GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
				UICommonHelper.SetParent(taskTypeItem, self.TypeListNode);

				UI ui_1 = self.AddChild<UI, string, GameObject>( "taskTypeItem_" + i.ToString(), taskTypeItem);
				UITaskTypeComponent uIItemComponent = ui_1.AddComponent<UITaskTypeComponent>();
				uIItemComponent.OnUpdateData(ids[i]);
				uIItemComponent.SetClickTypeHandler((int typeid) => { self.OnClickTaskType(typeid); });
				uIItemComponent.SetClickTypeItemHandler((int typeid, int chapterId) => { self.OnClickTaskTypeItem(typeid, chapterId); });
				self.TaskTypeUIList.Add(ui_1);
			}

			TaskPro taskPro = self.TaskComponent.GetTaskById(self.TaskId);
			if (taskPro == null)
			{
				self.OnClickTaskType(ids[0]);
			}
			else
			{
				TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
				self.OnClickTaskType(taskConfig.TaskType, taskPro.taskID);
			}
		}

		public static void OnClickTaskType(this UITaskComponent self, int type, int taskId = 0)
		{
			for (int i = 0; i < self.TaskTypeUIList.Count; i++)
			{
				self.TaskTypeUIList[i].GetComponent<UITaskTypeComponent>().SetSelected(type, taskId);
			}
		}

		public static void OnClickTaskTypeItem(this UITaskComponent self, int type, int taskId)
		{
			self.TaskPro = self.ZoneScene().GetComponent<TaskComponent>().GetTaskById(taskId);
			self.TaskId = taskId;

			self.UpdateTaskInfo(self.TaskPro).Coroutine();
		}

		public static void OnCloseTask(this UITaskComponent self)
		{
			UIHelper.Remove(self.DomainScene(), UIType.UITask);
		}

		public static async ETTask UpdateTaskInfo(this UITaskComponent self, TaskPro taskPro)
		{
			self.TaskPro = taskPro;
			self.GetParent<UI>().GameObject.transform.Find("Right").gameObject.SetActive(taskPro != null);
			if (taskPro == null)
			{
				return;
			}

			self.TaskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);

			self.Text_expValue.GetComponent<Text>().text = self.TaskConfig.TaskExp.ToString();
			self.Text_jinbiValue.GetComponent<Text>().text = self.TaskConfig.TaskCoin.ToString();

			self.Text_taskTarget.GetComponent<Text>().text = TaskViewHelp.Instance.GetTaskProgessDesc(taskPro);
			self.Text_jiangliText.GetComponent<Text>().text = self.TaskConfig.TaskDes;

			self.Button_Zhuizong.SetActive(taskPro.TrackStatus == 0);
			self.Button_CancelZhuizong.SetActive(taskPro.TrackStatus == 1);

			string path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
			await ETTask.CompletedTask;
			GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

			string rewardStr = self.TaskConfig.ItemID;
			string rewardNum = self.TaskConfig.ItemNum;
			if (ComHelp.IfNull(rewardStr))
			{
				rewardStr = "1;2";
				rewardNum = self.TaskConfig.TaskCoin + ";" + self.TaskConfig.TaskExp;
			}
			else 
			{
				rewardStr = "1;2;" + rewardStr;
				rewardNum = self.TaskConfig.TaskCoin + ";" + self.TaskConfig.TaskExp + ";" + rewardNum;
			}

			string[] rewarditems = rewardStr.Split(';');
			string[] rewardItemNums = rewardNum.Split(';');

			int number = 0;
			for (int i = 0; i < rewarditems.Length; i++)
			{
				UI ui_1;
				if (rewarditems[i] == "0" || rewardItemNums[i] == "0")
				{
					continue;
				}

				if (number < self.RewardUIList.Count)
				{
					ui_1 = self.RewardUIList[number];
					ui_1.GameObject.SetActive(true);
				}
				else
				{
					GameObject skillItem = GameObject.Instantiate(bundleObj);
					UICommonHelper.SetParent(skillItem, self.RewardListNode);
					ui_1 = self.AddChild<UI, string, GameObject>( "skillItem_" + i.ToString(), skillItem);
					ui_1.AddComponent<UIItemComponent>();
					self.RewardUIList.Add(ui_1);
				}

				UIItemComponent uIItemComponent = ui_1.GetComponent<UIItemComponent>();
				uIItemComponent.ItemNum = rewardItemNums[i];
				uIItemComponent.UpdateItem(new BagInfo() { ItemID = int.Parse(rewarditems[i]), ItemNum = int.Parse(rewardItemNums[i]) }, ItemOperateEnum.TaskItem);
				number++;
			}
			for (int i = number; i < self.RewardUIList.Count; i++)
			{
				self.RewardUIList[i].GameObject.SetActive(false);
			}
		}

		public static void OnRecvTaskUpdate(this UITaskComponent self)
		{
			self.UpdateTaskInfo(self.TaskComponent.GetTaskById(self.TaskPro.taskID)).Coroutine();
		}

		public static void OnTrackTask(this UITaskComponent self, bool track)
		{
			if (self.TaskPro == null)
				return;

			TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.TaskPro.taskID);
			if (taskConfig.TaskType == (int)TaskTypeEnum.Main)
				return;
			if (self.ZoneScene().GetComponent<TaskComponent>().GetAllTrackList().Count >= 3 && track)
				return;

			self.ZoneScene().GetComponent<TaskComponent>().SendTaskTrack(self.TaskPro.taskID, self.TaskPro.TrackStatus == 0 ? 1 : 0).Coroutine();

			self.Button_Zhuizong.SetActive(!self.Button_Zhuizong.activeSelf);
			self.Button_CancelZhuizong .SetActive(!self.Button_CancelZhuizong .activeSelf);

			//提示
			if (self.Button_Zhuizong.activeSelf == false)
			{
				FloatTipManager.Instance.ShowFloatTip("任务开启追踪!");
			}
			else {
				FloatTipManager.Instance.ShowFloatTip("任务取消追踪!");
			}

		}

		public static void OnGiveUpTask(this UITaskComponent self)
		{
			if (self.TaskPro == null)
				return;

			TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.TaskPro.taskID);
			if (taskConfig.TaskType == (int)TaskTypeEnum.Main)
			{
				FloatTipManager.Instance.ShowFloatTip("主线任务不能放弃");
				return;
			}
			self.ZoneScene().GetComponent<TaskComponent>().SendGiveUpTask(self.TaskPro.taskID).Coroutine();
		}

		public static void MoveToTask(this UITaskComponent self, int positionId)
		{
			TaskPositionConfig taskPositionConfig = TaskPositionConfigCategory.Instance.Get(positionId);
			MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
			if (mapComponent.SceneTypeEnum != (int)SceneTypeEnum.LocalDungeon)
			{
				return;
			}
			if (mapComponent.SceneId == taskPositionConfig.MapID)
			{
				self.MoveToTaskPosition	(positionId);
				return;
			}
			string[] otherMapMoves = taskPositionConfig.OtherMapMove.Split(';');
			if (otherMapMoves == null)
			{
				return;
			}
			for (int i = 0; i < otherMapMoves.Length; i++)
			{
				if (otherMapMoves[i] == "0")
				{
					continue;	
				}
				string[] positionIds = otherMapMoves[i].Split(',');
				if (int.Parse(positionIds[0]) == mapComponent.SceneId)
				{
					self.MoveToTaskPosition(int.Parse(positionIds[1]));
					break;
				}
			}
		}

		public static void MoveToTaskPosition(this UITaskComponent self, int taskPositionId)
		{
			TaskPositionConfig taskPositionConfig = TaskPositionConfigCategory.Instance.Get(taskPositionId);
			GameObject gameObject = GameObject.Find($"ScenceRosePositionSet/{taskPositionConfig.PositionName}");
			if (gameObject == null)
			{
				return;
			}
			UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
			uI.GetComponent<UIMainComponent>().OnMoveStart();
			Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
			unit.MoveToAsync2( gameObject.transform.position ).Coroutine();
		}

		public static void  OnExcuteTask(this UITaskComponent self)
		{
			int target = self.TaskConfig.TargetType;

			if (self.TaskPro.taskStatus == (int)TaskStatuEnum.Completed)
			{
				TaskHelper.MoveToNpc(self.ZoneScene(), self.TaskPro).Coroutine();
				self.OnCloseTask();
				return;
			}
			if (self.TaskConfig.TargetPosition != 0)
			{
				self.MoveToTask(self.TaskConfig.TargetPosition);
				self.OnCloseTask();
				return;
			}
			TaskViewHelp.Instance.TaskTypeLogic[(TaskTargetType)target].taskExcute(self.DomainScene(), self.TaskPro, self.TaskConfig);
			self.OnCloseTask();
		}
	}

}
