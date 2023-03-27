using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace ET
{
    public class UICountryTaskComponent : Entity, IAwake
    {
        public GameObject[] Button_Open;
        public GameObject[] Button_Reward;
        public GameObject[] Text_Huoyue;
        public GameObject Text_DayHuoYue;

        public GameObject Image_progressvalue;
        public GameObject TaskListNode;

        public List<UICountryTaskItemComponent> TaskList = new List<UICountryTaskItemComponent>();
        public UserInfoComponent UserInfoComponent;
    }

    [ObjectSystem]
    public class UICountryTaskComponentAwakeSystem : AwakeSystem<UICountryTaskComponent>
    {

        public override void Awake(UICountryTaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Button_Open = new GameObject[4];
            self.Button_Open[0] = rc.Get<GameObject>("Button_Open_1");
            self.Button_Open[1] = rc.Get<GameObject>("Button_Open_2");
            self.Button_Open[2] = rc.Get<GameObject>("Button_Open_3");
            self.Button_Open[3] = rc.Get<GameObject>("Button_Open_4");

            self.Text_Huoyue = new GameObject[4];
            self.Text_Huoyue[0] = rc.Get<GameObject>("Text_Huoyue1");
            self.Text_Huoyue[1] = rc.Get<GameObject>("Text_Huoyue2");
            self.Text_Huoyue[2] = rc.Get<GameObject>("Text_Huoyue3");
            self.Text_Huoyue[3] = rc.Get<GameObject>("Text_Huoyue4");

            self.Text_DayHuoYue = rc.Get<GameObject>("Text_DayHuoYue");

            self.Button_Reward = new GameObject[4];
            self.Button_Reward[3] = rc.Get<GameObject>("Button_4");
            //self.Button_Reward[3].GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Reward_Type(4); });
            self.Button_Reward[2] = rc.Get<GameObject>("Button_3");
            //self.Button_Reward[2].GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Reward_Type(3); });
            self.Button_Reward[1] = rc.Get<GameObject>("Button_2");
            //self.Button_Reward[1].GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Reward_Type(2); });
            self.Button_Reward[0] = rc.Get<GameObject>("Button_1");
            //self.Button_Reward[0].GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Reward_Type(1); });

            ButtonHelp.AddEventTriggers(self.Button_Reward[3], (PointerEventData pdata) => { self.BeginDrag(pdata, 4).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Button_Reward[3], (PointerEventData pdata) => { self.EndDrag(pdata, 4); }, EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.Button_Reward[2], (PointerEventData pdata) => { self.BeginDrag(pdata, 3).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Button_Reward[2], (PointerEventData pdata) => { self.EndDrag(pdata, 3); }, EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.Button_Reward[1], (PointerEventData pdata) => { self.BeginDrag(pdata, 2).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Button_Reward[1], (PointerEventData pdata) => { self.EndDrag(pdata, 2); }, EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.Button_Reward[0], (PointerEventData pdata) => { self.BeginDrag(pdata, 1).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Button_Reward[0], (PointerEventData pdata) => { self.EndDrag(pdata, 1); }, EventTriggerType.PointerUp);

            self.Image_progressvalue = rc.Get<GameObject>("Image_progressvalue");
            self.TaskListNode = rc.Get<GameObject>("TaskListNode");

            self.TaskList.Clear();
            self.UserInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
        }
    }


    public static class UICountryTaskComponentSystem
    {

        public static async ETTask BeginDrag(this UICountryTaskComponent self, PointerEventData pdata, int index)
        {
            UI skillTips = await UIHelper.Create(self.DomainScene(), UIType.UICountryTips);

            Vector2 localPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);
            HuoYueRewardConfig huoYueRewardConfig = HuoYueRewardConfigCategory.Instance.Get(index);
            skillTips.GetComponent<UICountryTipsComponent>().OnUpdateUI(huoYueRewardConfig.RewardItems, new Vector3(localPoint.x, localPoint.y, 0f));
        }

        public static void EndDrag(this UICountryTaskComponent self, PointerEventData pdata, int index)
        {
            self.OnBtn_Reward_Type(index);
            UIHelper.Remove(self.DomainScene(), UIType.UICountryTips);
        }

        public static void OnBtn_Reward_Type(this UICountryTaskComponent self, int index)
        {
            long haveHuoyue = self.ZoneScene().GetComponent<TaskComponent>().GetHuoYueDu();
            HuoYueRewardConfig huoYueRewardConfig = HuoYueRewardConfigCategory.Instance.Get(index);
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
            if (haveHuoyue < huoYueRewardConfig.NeedPoint)
            {
                FloatTipManager.Instance.ShowFloatTip("活跃度不足！");
                return;
            }
            if (taskComponent.ReceiveHuoYueIds.Contains(index))
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过该奖励！");
                return;
            }
            if (!self.ZoneScene().GetComponent<BagComponent>().CheckAddItemData(huoYueRewardConfig.RewardItems))
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足！");
                return;
            }

            taskComponent.RuqestHuoYueReward(index).Coroutine();
            taskComponent.ReceiveHuoYueIds.Add(index);
            self.UpdateHuoYueReward();
        }

        public static void OnTaskCountryUpdate(this UICountryTaskComponent self)
        {
            self.UpdateTaskCountrys().Coroutine();
        }

        public static async ETTask UpdateTaskCountrys(this UICountryTaskComponent self)
        {
            List<TaskPro> taskPros = self.ZoneScene().GetComponent<TaskComponent>().TaskCountryList;
            string path = ABPathHelper.GetUGUIPath("Main/Country/UICountryTaskItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            taskPros.Sort(delegate (TaskPro a, TaskPro b)
            {
                int commita = a.taskStatus == (int)TaskStatuEnum.Commited ? 1 : 0;
                int commitb = b.taskStatus == (int)TaskStatuEnum.Commited ? 1 : 0;
                int completea = a.taskStatus == (int)TaskStatuEnum.Completed ? 1 : 0;
                int completeb = b.taskStatus == (int)TaskStatuEnum.Completed ? 1 : 0;

                if (commita == commitb)
                    return completeb - completea;       //可以领取的在前
                else
                    return commitb - commita;           //已经完成的在前
            });

            int number = 0;
            for (int i = 0; i < taskPros.Count; i++)
            {
                TaskCountryConfig taskConfig = TaskCountryConfigCategory.Instance.Get(taskPros[i].taskID);
                if (taskConfig.TaskType != TaskCountryType.Country)
                {
                    continue;
                }

                UICountryTaskItemComponent ui_1 = null;
                if (number < self.TaskList.Count)
                {
                    ui_1 = self.TaskList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.TaskListNode);
                    ui_1 = self.AddChild<UICountryTaskItemComponent, GameObject>(taskTypeItem);
                    self.TaskList.Add(ui_1);
                }

                ui_1.OnUpdateData(taskPros[i]);
                number++;
            }

            for (int k = number; k < self.TaskList.Count; k++)
            {
                self.TaskList[k].GameObject.SetActive(false);
            }

            long haveHuoyue = self.ZoneScene().GetComponent<TaskComponent>().GetHuoYueDu();
            int totalHuoyue = HuoYueRewardConfigCategory.Instance.Get(4).NeedPoint;
            self.Text_DayHuoYue.GetComponent<Text>().text = haveHuoyue.ToString();
            self.Image_progressvalue.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(Mathf.Clamp01(haveHuoyue * 1f / totalHuoyue)* 800f, 58);
        }

        public static void UpdateHuoYueReward(this UICountryTaskComponent self)
        {
            List<int> getids = self.ZoneScene().GetComponent<TaskComponent>().ReceiveHuoYueIds;

            for (int i = 0; i < self.Button_Open.Length; i++)
            {
                self.Button_Reward[i].SetActive(!getids.Contains(i + 1));
                self.Button_Open[i].SetActive(getids.Contains(i+1));
                self.Text_Huoyue[i].GetComponent<Text>().text = string.Format("{0}活跃度", HuoYueRewardConfigCategory.Instance.Get(i+1).NeedPoint);
            }
        }

        public static void OnUpdateUI(this UICountryTaskComponent self)
        {
            self.UpdateTaskCountrys().Coroutine();
            self.UpdateHuoYueReward();
        }

    }
}
