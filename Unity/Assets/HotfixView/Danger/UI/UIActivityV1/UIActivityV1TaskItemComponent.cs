using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1TaskItemComponent: Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject ButtonComplete;
        public GameObject ButtonReceive;
        public GameObject TextHuoyueValue;
        public GameObject TextTaskProgress;
        public GameObject TextTaskDesc;
        public GameObject RewardListNode;
        public GameObject TextTaskName;
        public GameObject ImageIcon;
        public GameObject ItemNumber;

        public GameObject GameObject;
        public TaskPro TaskPro;

        public List<string> AssetPath = new List<string>();
    }

    public class UIActivityV1TaskItemComponentAwakeSystem: AwakeSystem<UIActivityV1TaskItemComponent, GameObject>
    {
        public override void Awake(UIActivityV1TaskItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ButtonComplete = rc.Get<GameObject>("ButtonComplete");
            self.ButtonReceive = rc.Get<GameObject>("ButtonReceive");
            //self.ButtonReceive.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Receive(); });
            ButtonHelp.AddListenerEx(self.ButtonReceive, () => { self.OnBtn_Receive().Coroutine(); });

            self.TextHuoyueValue = rc.Get<GameObject>("TextHuoyueValue");
            self.TextTaskProgress = rc.Get<GameObject>("TextTaskProgress");
            self.TextTaskDesc = rc.Get<GameObject>("TextTaskDesc");
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.TextTaskName = rc.Get<GameObject>("TextTaskName");
            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
            self.ItemNumber = rc.Get<GameObject>("ItemNumber");
        }
    }

    public class UIActivityV1TaskItemComponentDestroy: DestroySystem<UIActivityV1TaskItemComponent>
    {
        public override void Destroy(UIActivityV1TaskItemComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }

    public static class UIActivityV1TaskItemComponentSystem
    {
        public static void OnUpdateData(this UIActivityV1TaskItemComponent self, TaskPro taskPro)
        {
            self.TaskPro = taskPro;
            TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(taskPro.taskID);

            self.TextTaskName.GetComponent<Text>().text = taskConfig.GetTaskName();
            self.TextTaskDesc.GetComponent<Text>().text = taskConfig.GetTaskDes();

            if (taskConfig.TargetType == (int)TaskTargetType.GiveItem_10
                || taskConfig.TargetType == (int)TaskTargetType.GivePet_25)
            {
                self.TextTaskProgress.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度值") + ": " +
                    string.Format("{0}/{1}", 0, 1);
            }
            else if (taskConfig.TargetType == (int)TaskTargetType.JianDingAttrNumber_43 ||
                     taskConfig.TargetType == (int)TaskTargetType.TeamDungeonHurt_136 ||
                     taskConfig.TargetType == (int)TaskTargetType.MakeQulityNumber_29)
            {
                int curnumber = self.TaskPro.taskStatus == (int)TaskStatuEnum.Completed ? 1 : 0;    
                self.TextTaskProgress.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度") + ": " +
                   string.Format("{0}/{1}", curnumber, 1);
            }
            else
            {
                taskPro.taskTargetNum_1 = taskPro.taskTargetNum_1 > taskConfig.TargetValue[0] ? taskConfig.TargetValue[0] : taskPro.taskTargetNum_1;
                self.TextTaskProgress.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度值") + ": " +
                        string.Format("{0}/{1}", taskPro.taskTargetNum_1, taskConfig.TargetValue[0]);
            }

            //更新图标
            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.TaskIcon, taskConfig.TaskIcon.ToString());
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }

            self.ImageIcon.GetComponent<Image>().sprite = sp;
            //self.ImageIcon.GetComponent<Image>()

            UICommonHelper.DestoryChild(self.RewardListNode);
            UICommonHelper.ShowItemList(taskConfig.RewardItem, self.RewardListNode, self, 1f);
            
            //更新金币
            self.ItemNumber.GetComponent<Text>().text = " +" + taskConfig.RewardGold;

            //活跃度
            self.TextHuoyueValue.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("活跃度") + " +" + taskConfig.EveryTaskRewardNum;

            self.ButtonComplete.SetActive(taskPro.taskStatus == (int)TaskStatuEnum.Commited);
            self.ButtonReceive.SetActive(taskPro.taskStatus != (int)TaskStatuEnum.Commited);
        }

        public static async ETTask OnGiveBtn(this UIActivityV1TaskItemComponent self)
        {
            TaskCountryConfig taskCountryConfig = TaskCountryConfigCategory.Instance.Get(self.TaskPro.taskID);
            if (taskCountryConfig.TargetType == (int)TaskTargetType.GiveItem_10)
            {
                UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UIGiveTask);
                ui.GetComponent<UIGiveTaskComponent>().InitTask(self.TaskPro.taskID, 2);
                ui.GetComponent<UIGiveTaskComponent>().OnGiveAction = self.UpdateSeasonDayTask;
            }
            else if (taskCountryConfig.TargetType == (int)TaskTargetType.GivePet_25)
            {
                UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UIGivePet);
                ui.GetComponent<UIGivePetComponent>().InitTask(self.TaskPro.taskID, 2);
                ui.GetComponent<UIGivePetComponent>().OnUpdateUI();
                ui.GetComponent<UIGivePetComponent>().OnGiveAction = self.UpdateSeasonDayTask;
            }
        }

        public static void UpdateSeasonDayTask(this UIActivityV1TaskItemComponent self)
        {
            TaskPro taskPro = self.TaskPro;
            self.OnUpdateData(taskPro);
        }

        public static async ETTask OnBtn_Receive(this UIActivityV1TaskItemComponent self)
        {
            TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(self.TaskPro.taskID);

            if (self.TaskPro.taskStatus < (int)TaskStatuEnum.Completed)
            {
                if (taskConfig.TargetType == (int)TaskTargetType.GiveItem_10 || taskConfig.TargetType == (int)TaskTargetType.GivePet_25)
                {
                    self.OnGiveBtn().Coroutine();
                    return;
                }

                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("任务还没有完成！"));
                return;
            }

            if (self.TaskPro.taskStatus == (int)TaskStatuEnum.Commited)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("已经领取过奖励！"));
                return;
            }

            //发送奖励
            long instanceid = self.InstanceId;
            int errorCode = await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTaskCountry(self.TaskPro.taskID);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            if (errorCode == ErrorCode.ERR_Success)
            {
                self.GetParent<UIActivityV1TaskComponent>().UpdateTaskCountrys();
            }
        }
    }
}