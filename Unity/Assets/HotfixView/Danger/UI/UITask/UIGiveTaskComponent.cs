using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIGiveTaskComponent: Entity, IAwake
    {
        public GameObject BagListNode;
        public GameObject UICommonItem;
        public GameObject TaskDesText;
        public GameObject GiveBtn;
        public GameObject CloseBtn;

        public int TaskId;
        public BagInfo BagInfo;
        public BagComponent BagComponent;
        public UIItemComponent CheckedItem;
        public List<UIItemComponent> BagList = new List<UIItemComponent>();
    }

    public class UIGiveTaskComponentAwakeSystem: AwakeSystem<UIGiveTaskComponent>
    {
        public override void Awake(UIGiveTaskComponent self)
        {
            self.Awake();
        }
    }

    public static class UIGiveTaskComponentSystem
    {
        public static void Awake(this UIGiveTaskComponent self)
        {
            self.BagList.Clear();
            self.BagInfo = null;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BagListNode = rc.Get<GameObject>("BagListNode");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.TaskDesText = rc.Get<GameObject>("TaskDesText");
            self.GiveBtn = rc.Get<GameObject>("GiveBtn");
            self.CloseBtn = rc.Get<GameObject>("CloseBtn");

            self.CloseBtn.GetComponent<Button>().onClick.AddListener(() => UIHelper.Remove(self.ZoneScene(), UIType.UIGiveTask));
            self.GiveBtn.GetComponent<Button>().onClick.AddListener(() => self.OnGiveBtn().Coroutine());

            self.CheckedItem = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem);
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            self.OnBagListUpdate().Coroutine();
        }

        public static async ETTask InitTask(this UIGiveTaskComponent self, int TaskId)
        {
            self.TaskId = TaskId;
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(TaskId);
            self.TaskDesText.GetComponent<Text>().text = taskConfig.TaskDes;
        }

        public static async ETTask OnBagListUpdate(this UIGiveTaskComponent self)
        {
            int number = 0;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            List<BagInfo> bagInfos = self.BagComponent.GetBagList();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                UIItemComponent uI = null;
                if (number < self.BagList.Count)
                {
                    uI = self.BagList[number];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BagListNode);
                    uI = self.AddChild<UIItemComponent, GameObject>(go);
                    uI.SetClickHandler((BagInfo bagInfo) => { self.OnSelect(bagInfo); });
                    self.BagList.Add(uI);
                }

                number++;
                uI.UpdateItem(bagInfos[i], ItemOperateEnum.SkillSet);
            }

            for (int i = number; i < self.BagList.Count; i++)
            {
                self.BagList[i].GameObject.SetActive(false);
            }
        }

        public static void OnSelect(this UIGiveTaskComponent self, BagInfo baginfo)
        {
            self.BagInfo = baginfo;
            self.CheckedItem.UpdateItem(baginfo, ItemOperateEnum.None);
        }

        public static async ETTask OnGiveBtn(this UIGiveTaskComponent self)
        {
            if (TaskHelper.IsTaskGiveItem(self.TaskId, self.BagInfo))
            {
                int errorCode = await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTask(self.TaskId, self.BagInfo.BagInfoID);
                if (errorCode == ErrorCode.ERR_Success)
                {
                    FloatTipManager.Instance.ShowFloatTip("完成任务");
                    UIHelper.Remove(self.ZoneScene(), UIType.UIGiveTask);
                }
            }
            else
            {
                FloatTipManager.Instance.ShowFloatTip("道具类型不符合任务要求");
                return;
            }

            await ETTask.CompletedTask;
        }
    }
}