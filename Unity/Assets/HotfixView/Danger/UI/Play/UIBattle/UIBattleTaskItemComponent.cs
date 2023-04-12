using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIBattleTaskItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ItemListNode;
        public GameObject ButtonComplete;
        public GameObject ButtonReceive;
        public GameObject TextHuoyueValue;
        public GameObject TextTaskProgress;
        public GameObject TextTaskDesc;
        public GameObject TextTaskName;
        public GameObject ImageIcon;
        public GameObject ItemNumber;

        public GameObject GameObject;
        public TaskPro TaskPro;
    }


    public class UIBattleTaskItemComponentAwake : AwakeSystem<UIBattleTaskItemComponent, GameObject>
    {

        public override void Awake(UIBattleTaskItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.ButtonComplete = rc.Get<GameObject>("ButtonComplete");
            self.ButtonReceive = rc.Get<GameObject>("ButtonReceive");
            //self.ButtonReceive.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Receive(); });
            ButtonHelp.AddListenerEx(self.ButtonReceive, () => { self.OnBtn_Receive(); });

            self.TextHuoyueValue = rc.Get<GameObject>("TextHuoyueValue");
            self.TextTaskProgress = rc.Get<GameObject>("TextTaskProgress");
            self.TextTaskDesc = rc.Get<GameObject>("TextTaskDesc");
            self.TextTaskName = rc.Get<GameObject>("TextTaskName");
            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
            self.ItemNumber = rc.Get<GameObject>("ItemNumber");
        }
    }

    public static class UIBattleTaskItemComponentSystem
    {
        public static void OnUpdateData(this UIBattleTaskItemComponent self, TaskPro taskPro)
        {
            self.TaskPro = taskPro;
            TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(taskPro.taskID);
            if (!ComHelp.IfNull(taskConfig.RewardItem))
            {
                UICommonHelper.DestoryChild(self.ItemListNode);
                UICommonHelper.ShowItemList(taskConfig.RewardItem, self.ItemListNode, self, 0.8f, true);
            }
            self.TextTaskName.GetComponent<Text>().text = taskConfig.TaskName;
            self.TextTaskDesc.GetComponent<Text>().text = taskConfig.TaskDes;

            taskPro.taskTargetNum_1 = taskPro.taskTargetNum_1 > taskConfig.TargetValue ? taskConfig.TargetValue : taskPro.taskTargetNum_1;
            self.TextTaskProgress.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度值") + ": " + string.Format("{0}/{1}", taskPro.taskTargetNum_1, taskConfig.TargetValue);

            //更新图标
            self.ImageIcon.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.TaskIcon, taskConfig.TaskIcon.ToString());
            //self.ImageIcon.GetComponent<Image>()

            //更新金币
            self.ItemNumber.GetComponent<Text>().text = " +" + taskConfig.RewardGold;

            //活跃度
            self.TextHuoyueValue.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("活跃度") + " +" + taskConfig.EveryTaskRewardNum;

            self.ButtonComplete.SetActive(taskPro.taskStatus == (int)TaskStatuEnum.Commited);
            self.ButtonReceive.SetActive(taskPro.taskStatus != (int)TaskStatuEnum.Commited);

        }

        public static void OnBtn_Receive(this UIBattleTaskItemComponent self)
        {
            if (self.TaskPro.taskStatus < (int)TaskStatuEnum.Completed)
            {
                FloatTipManager.Instance.ShowFloatTip("任务还没有完成！");
                return;
            }
            if (self.TaskPro.taskStatus == (int)TaskStatuEnum.Commited)
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过奖励！");
                return;
            }

            //发送奖励
            self.ZoneScene().GetComponent<TaskComponent>().SendCommitTaskCountry(self.TaskPro.taskID).Coroutine();

            //显示领取
            self.ButtonComplete.SetActive(true);
            self.ButtonReceive.SetActive(false);
        }
    }
}
