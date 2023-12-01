using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICountryTaskItemComponent : Entity, IAwake<GameObject>,IDestroy
    {
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
        
        public List<string> AssetPath = new List<string>();
    }


    public class UICountryTaskItemComponentAwakeSystem : AwakeSystem<UICountryTaskItemComponent, GameObject>
    {

        public override void Awake(UICountryTaskItemComponent self, GameObject gameObject)
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
            self.TextTaskName = rc.Get<GameObject>("TextTaskName");
            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
            self.ItemNumber = rc.Get<GameObject>("ItemNumber");
        }
    }
    public class UICountryTaskItemComponentDestroy : DestroySystem<UICountryTaskItemComponent>
    {
        public override void Destroy(UICountryTaskItemComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }
    public static class UICountryTaskItemComponentSystem
    {

        public static void OnUpdateData(this UICountryTaskItemComponent self, TaskPro taskPro)
        {

            self.TaskPro = taskPro;
            TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(taskPro.taskID);

            self.TextTaskName.GetComponent<Text>().text = taskConfig.TaskName;
            self.TextTaskDesc.GetComponent<Text>().text = taskConfig.TaskDes;

            taskPro.taskTargetNum_1 = taskPro.taskTargetNum_1 > taskConfig.TargetValue[0] ? taskConfig.TargetValue[0] : taskPro.taskTargetNum_1;
            self.TextTaskProgress.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("进度值") + ": " + string.Format("{0}/{1}", taskPro.taskTargetNum_1, taskConfig.TargetValue);

            //更新图标
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.TaskIcon, taskConfig.TaskIcon.ToString());
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ImageIcon.GetComponent<Image>().sprite = sp;
            //self.ImageIcon.GetComponent<Image>()

            //更新金币
            self.ItemNumber.GetComponent<Text>().text = " +" + taskConfig.RewardGold;

            //活跃度
            self.TextHuoyueValue.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("活跃度") + " +" + taskConfig.EveryTaskRewardNum;

            self.ButtonComplete.SetActive(taskPro.taskStatus == (int)TaskStatuEnum.Commited);
            self.ButtonReceive.SetActive(taskPro.taskStatus != (int)TaskStatuEnum.Commited);

        }

        public static async ETTask OnBtn_Receive(this UICountryTaskItemComponent self)
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
            long instanceid = self.InstanceId;
            int errorCode =  await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTaskCountry(self.TaskPro.taskID);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            if (errorCode == ErrorCode.ERR_Success)
            {
                UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UICountry);
                uI.GetComponent<UICountryComponent>().OnUpdateRoleData();

                //显示领取
                self.ButtonComplete.SetActive(true);
                self.ButtonReceive.SetActive(false);
            }
        }
    }
}
