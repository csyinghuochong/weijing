using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITaskGetComponent : Entity, IAwake, IDestroy
    {
        public int NpcID;
        public int TaskId;

        //NpcID
        public GameObject TaskFubenList;
        public GameObject UITaskFubenItem;
        public GameObject Btn_EnergyDuihuan;
        public GameObject EnergySkill;
        public GameObject BtnCommitTask1;
        public GameObject RewardListNode;
        public GameObject ButtonGet;
        public GameObject TaskListNode;
        public GameObject ScrollView1;
        public GameObject Lab_NpcSpeak;
        public GameObject Lab_NpcName;
        public GameObject Img_button;
        public GameObject Obj_Lab_MoNnengHint;
        public List<UI> TaskUIList;
    }

    [ObjectSystem]
    public class UINpcTaskComponentAwakeSystem : AwakeSystem<UITaskGetComponent>
    {
        public override void Awake(UITaskGetComponent self)
        {
            self.TaskId = 0;
            self.TaskUIList = new List<UI>();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_EnergyDuihuan = rc.Get<GameObject>("Btn_EnergyDuihuan");
            self.Btn_EnergyDuihuan.GetComponent<Button>().onClick.AddListener(() => { self.RequestEnergySkill().Coroutine(); });

            self.EnergySkill = rc.Get<GameObject>("EnergySkill");
            self.Obj_Lab_MoNnengHint = rc.Get<GameObject>("Lab_MoNnengHint");

            self.BtnCommitTask1 = rc.Get<GameObject>("BtnCommitTask1");
            self.BtnCommitTask1.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_CommitTask().Coroutine(); });
            self.BtnCommitTask1.SetActive(false);
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
          
            self.ButtonGet = rc.Get<GameObject>("ButtonGet");
            self.ButtonGet.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonGetTask(); });
            self.ButtonGet.SetActive(false);

            self.TaskListNode = rc.Get<GameObject>("TaskListNode");
            self.ScrollView1 = rc.Get<GameObject>("ScrollView1");

            self.Lab_NpcSpeak = rc.Get<GameObject>("Lab_NpcSpeak");
            self.Lab_NpcName = rc.Get<GameObject>("Lab_NpcName");

            self.TaskFubenList = rc.Get<GameObject>("TaskFubenList");
            self.UITaskFubenItem = rc.Get<GameObject>("UITaskFubenItem");
            self.UITaskFubenItem.SetActive(false);

            self.Img_button = rc.Get<GameObject>("Img_button");
            self.Img_button.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseNpcTask(); });

            DataUpdateComponent.Instance.AddListener(DataType.TaskGet, self);
        }
    }


    [ObjectSystem]
    public class UINpcTaskComponentDestroySystem : DestroySystem<UITaskGetComponent>
    {
        public override void Destroy(UITaskGetComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.TaskGet, self);
        }
    }

    public static class UINpcTaskComponentSystem
    {
        public static async ETTask OnTaskGet(this UITaskGetComponent self)
        {
            bool update = self.UpdataTask();
            if (update)
            {
                return;
            }

            long instanceid = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(1);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            self.OnCloseNpcTask();
        }

        public static void OnCloseNpcTask(this UITaskGetComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UITaskGet).Coroutine();
        }

        public static void InitData(this UITaskGetComponent self, int npcID)
        {
            self.NpcID = npcID;
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcID);

            //显示Npc对话   
            self.Lab_NpcSpeak.GetComponent<Text>().text = "   " + npcConfig.SpeakText;
            self.Lab_NpcName.GetComponent<Text>().text = npcConfig.Name;
            self.TaskFubenList.SetActive(false);
            self.ScrollView1.SetActive(false);
            self.EnergySkill.SetActive(false);
            if (npcID == 1000014)       //魔能老人
            {
                //显示消耗
                int costItemID = 12000006;
                long itemNum = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(costItemID);
                self.EnergySkill.SetActive(true);
                //获取
                self.Obj_Lab_MoNnengHint.GetComponent<Text>().text = ItemConfigCategory.Instance.Get(costItemID).ItemName + "  " + itemNum + "/" + 5;
            }
            else if (npcConfig.NpcType == 2)  //挑戰之地
            {
                self.TaskFubenList.SetActive(true);
                List<int> fubenList = new List<int>(npcConfig.NpcPar);
                for (int i = 0; i < fubenList.Count; i++)
                {
                    GameObject go = GameObject.Instantiate(self.UITaskFubenItem);
                    go.SetActive(true);
                    UICommonHelper.SetParent( go, self.TaskFubenList);
                    UITaskFubenItemComponent uITaskFubenItemComponent = self.AddChild<UITaskFubenItemComponent, GameObject>(go);
                    uITaskFubenItemComponent.OnInitData((int fubenId) => { self.OnClickFubenItem(fubenId); }, fubenList[i]);
                }
            }
            else
            {
                self.ScrollView1.SetActive(true);
                self.UpdataTask();
            }
        }

        public static void OnClickFubenItem(this UITaskGetComponent self, int sceneId)
        {
            if (sceneId == 0)
            {
                return;
            }
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);

            string desStr = "是否进入" + sceneConfig.Name + "?";

            if (sceneConfig.DayEnterNum >= 1) {
                desStr += "\n提示:每天只能进入" + sceneConfig.DayEnterNum + "次";
            }

            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "进入地图", desStr,
                () =>
                {
                    self.RequestEnterFuben(sceneId).Coroutine();
                }).Coroutine();
        }

        public static async ETTask RequestEnterFuben(this UITaskGetComponent self, int sceneId)
        {
            int sceneType = SceneConfigCategory.Instance.Get(sceneId).MapType;
            int errorCode = ErrorCore.ERR_Success;
            if (sceneType == (int)SceneTypeEnum.YeWaiScene)
            {
                errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), (int)SceneTypeEnum.YeWaiScene, sceneId);
            }
            if(sceneType == (int)SceneTypeEnum.Tower)
            {
                UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
                if (sceneConfig.DayEnterNum <= userInfoComponent.GetSceneFubenTimes(sceneId))
                {
                    FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("今日进入次数已用完"));
                    return;
                }
                errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), sceneType, sceneId);
                if (errorCode == ErrorCore.ERR_Success)
                {
                    userInfoComponent.AddSceneFubenTimes(sceneId);
                }
            }
            if (errorCode == ErrorCore.ERR_Success)
            { 
                UIHelper.Remove(self.ZoneScene(), UIType.UITaskGet).Coroutine();
            }
        }

        public static async ETTask RequestEnergySkill(this UITaskGetComponent self)
        {
            Actor_FubenEnergySkillRequest c2M_PaiMaiBuyRequest = new Actor_FubenEnergySkillRequest() {   };
            Actor_FubenEnergySkillResponse m2C_PaiMaiBuyResponse = (Actor_FubenEnergySkillResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

            if (m2C_PaiMaiBuyResponse.Error == 0)
            {
                UIHelper.Remove(self.DomainScene(), UIType.UITaskGet).Coroutine();
            }
            else {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_ItemNotEnoughError);
            }
        }

        //如果当前有任务接取了还没完成，则什么都不显示
        public static bool UpdataTask(this UITaskGetComponent self)
        {
            for (int i = 0; i < self.TaskUIList.Count; i++)
            {
                self.TaskUIList[i].Dispose();
            }
            self.TaskUIList.Clear();
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
        
            //获取npc任务
            List<int> taskids = taskComponent.GetOpenTaskIds(self.NpcID);
            List<TaskPro> taskProCompleted = taskComponent.GetCompltedTaskByNpc(self.NpcID);
            for (int i = 0; i < taskProCompleted.Count; i++)
            {
                taskids.Add(taskProCompleted[i].taskID);
            }
            //当前没有接取任务
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Task/UITaskGetItem");
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return true;
            }
            for (int i = 0; i < taskids.Count; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.TaskListNode);

                UI uiitem = self.AddChild<UI, string, GameObject>("UITaskItem_" + i, go);
                UITaskGetItemComponent taskItemComponent = uiitem.AddComponent<UITaskGetItemComponent>();
                taskItemComponent.InitData(taskids[i]);
                taskItemComponent.SetClickHandler((int taskid) => { self.OnSelectTaskHandler(taskid); });

                self.TaskUIList.Add(uiitem);
            }

            if (taskids.Count > 0)
            {
                self.TaskUIList[0].GetComponent<UITaskGetItemComponent>().OnClickSelectTask();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void OnSelectTaskHandler(this UITaskGetComponent self, int taskid)
        {
            self.TaskId = taskid;

            for (int i = 0; i < self.TaskUIList.Count; i++)
            {
                self.TaskUIList[i].GetComponent<UITaskGetItemComponent>().SetSelected(taskid);
            }

            TaskPro taskPro = self.ZoneScene().GetComponent<TaskComponent>().GetTaskById(taskid);
            bool isCompleted = taskPro != null && taskPro.taskStatus == (int)TaskStatuEnum.Completed;
            self.BtnCommitTask1.SetActive(isCompleted);
            self.ButtonGet.SetActive(!isCompleted);
        }

        public static void OnButtonGetTask(this UITaskGetComponent self)
        {
            if (self.TaskId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择一个任务");
                return;
            }

            NetHelper.SendGetTask(self.ZoneScene(), self.TaskId).Coroutine();
        }

        public static async ETTask OnBtn_CommitTask(this UITaskGetComponent self)
        {
            int errorCode =  await self.ZoneScene().GetComponent<TaskComponent>().SendCommitTask(self.TaskId);
            if (errorCode == ErrorCore.ERR_Success)
            {
                FunctionEffect.GetInstance().PlaySelfEffect(UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()), 91000201) ;
            }
            self.OnCloseNpcTask();
        }

    }

}
