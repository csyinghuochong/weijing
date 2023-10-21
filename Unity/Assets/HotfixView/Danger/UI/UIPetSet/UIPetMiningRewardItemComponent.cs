using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningRewardItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImageReceived;
        public GameObject GameObject;
        public GameObject ItemListNode;
        public GameObject ButtonReward;
        public GameObject Text_tip;
        public GameObject Text_progress;

        public TaskPro TaskPro;

        public int Number;
    }

    public class UIPetMiningRewardItemComponentAwake : AwakeSystem<UIPetMiningRewardItemComponent, GameObject>
    {
        public override void Awake(UIPetMiningRewardItemComponent self, GameObject a)
        {
            self.GameObject = a;

            self.ItemListNode = a.transform.Find("ItemListNode").gameObject;
            self.ButtonReward = a.transform.Find("ButtonReward").gameObject;
            self.Text_tip = a.transform.Find("Text_tip").gameObject;
            self.ImageReceived = a.transform.Find("ImageReceived").gameObject;
            self.Text_progress = a.transform.Find("Text_progress").gameObject;

            ButtonHelp.AddListenerEx( self.ButtonReward, () => { self.OnButtonReward().Coroutine();  }  );
        }
    }

    public static class UIPetMiningRewardItemComponentSystem
    {

        public static async ETTask OnButtonReward(this UIPetMiningRewardItemComponent self)
        {
            if (self.TaskPro.taskStatus != (int)TaskStatuEnum.Completed)
            {
                FloatTipManager.Instance.ShowFloatTip("任务未完成！");
                return;
            }
            int errorCode = await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTaskCountry(self.TaskPro.taskID);
            if (errorCode == ErrorCode.ERR_Success)
            {
                self.ImageReceived.SetActive(true);
                self.ButtonReward.SetActive(false);
            }
        }

        public static void OnInitUI(this UIPetMiningRewardItemComponent self, TaskPro taskPro)
        {
            self.TaskPro = taskPro;
            TaskCountryConfig taskCountryConfig = TaskCountryConfigCategory.Instance.Get( taskPro.taskID );

            self.Text_tip.GetComponent<Text>().text = taskCountryConfig.TaskDes;
            self.Text_progress.GetComponent<Text>().text = $"{taskPro.taskTargetNum_1}/{taskCountryConfig.TargetValue}";

            self.ImageReceived.SetActive(taskPro.taskStatus == (int)TaskStatuEnum.Commited);
            self.ButtonReward.SetActive(taskPro.taskStatus != (int)TaskStatuEnum.Commited);
        }
    }

}