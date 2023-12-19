using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [Timer(TimerType.TurtleSpeak)]
    public class TurtleSpeakTimer : ATimer<NpcHeadBarComponent>
    {
        public override void Run(NpcHeadBarComponent self)
        {
            try
            {
                self.OnTurtleSpeakFinish();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }


    public class NpcHeadBarComponent : Entity, IAwake, IDestroy
    {
        public Unit Unit;
        public GameObject UINpcName;
        public Vector3 OldPosition;
        public Vector3 NewPosition;
        public bool MainUnitEnter;
        public bool MainUnitExit;
        public float EnterPassTime;

        public int NpcId;
        public HeadBarUI HeadBarUI;
        public GameObject[] EffectComTask = new GameObject[2];

        public long TurtleTimer;
    }

    public class NpcHeadBarComponentAwakeSystem : AwakeSystem<NpcHeadBarComponent>
    {
        public override void Awake(NpcHeadBarComponent self)
        {
            self.HeadBarUI = null;
            self.MainUnitEnter = false;
            self.MainUnitExit = false;
            self.EnterPassTime = 0;
            self.EffectComTask[0] = null;
            self.EffectComTask[1] = null;
            self.Unit = null;
            self.Awake(self.GetParent<Unit>());
        }
    }


    public class NpcHeadBarComponentDestroySystem : DestroySystem<NpcHeadBarComponent>
    {
        public override void Destroy(NpcHeadBarComponent self)
        {
            self.Destroy();
            TimerComponent.Instance?.Remove(ref self.TurtleTimer);
        }
    }

    public static class NpcHeadBarComponentSystem
    {
        public static void Awake(this NpcHeadBarComponent self, Unit myUnit)
        {
            self.Unit = myUnit;
            self.NpcId = myUnit.ConfigId;

            long instanceid = self.InstanceId;
            GameObject bundleObject = ResourcesComponent.Instance.LoadAsset<GameObject>(ABPathHelper.GetUGUIPath("Blood/UINpcName"));
            if (instanceid != self.InstanceId)
            {
                return;
            }
            self.UINpcName = GameObject.Instantiate(bundleObject);
            self.UINpcName.transform.SetParent(UIEventComponent.Instance.BloodMonster.transform);
            self.UINpcName.transform.localScale = Vector3.one;

            if (self.UINpcName.GetComponent<HeadBarUI>() == null)
            {
                self.UINpcName.AddComponent<HeadBarUI>();
            }
            self.HeadBarUI = self.UINpcName.GetComponent<HeadBarUI>();
            self.HeadBarUI.HeadPos = self.Unit.GetComponent<HeroTransformComponent>().GetTranform(PosType.Head);
            self.HeadBarUI.HeadBar = self.UINpcName;

            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(self.NpcId);
            self.UINpcName.transform.Find("Lab_NpcName").GetComponent<Text>().text = npcConfig.Name;

            // 乌龟说话
            if (ConfigHelper.TurtleList.Contains(self.NpcId) )
            {
                self.WuGuiSay().Coroutine();
            }
            //self.LateUpdate();
        }

        public static void UpdateRewardName(this NpcHeadBarComponent self, List<string> names)
        {
            if (names.Count == 0 || self.UINpcName == null)
            {
                return;
            }
            string name = string.Empty;
            for (int i = 0; i < names.Count; i++)
            {
                name += $"{names[i]}、";
            }

            self.UINpcName.transform.Find("NpcHeadSpeakSet").gameObject.SetActive(true);
            self.UINpcName.transform.Find("NpcHeadSpeakSet/Lab_HeadSpeak").GetComponent<Text>().text =$"东西给你!{name} 不要追着我啦！";

            TimerComponent.Instance.Remove(ref self.TurtleTimer);
            self.TurtleTimer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + TimeHelper.Second * 5, TimerType.TurtleSpeak, self);
        }

        /// <summary>
        /// 每次讲话5秒后消失。 
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateTurtleAI(this NpcHeadBarComponent self)
        {
            if (self.Unit == null || self.Unit.IsDisposed)
            {
                return;
            }
            int Now_TurtleAI = self.Unit.GetComponent<NumericComponent>().GetAsInt( NumericType.Now_TurtleAI );
            //(Now_TurtleAI == 1) //移动 2移动 3终点
            if (Now_TurtleAI == 3)
            {
                FunctionEffect.GetInstance().PlaySelfEffect(self.Unit, 30000003);    //小龟到达终点播放特效
                return;
            }

            List<string> speaklist = null;
            ConfigHelper.TurtleSpeakList.TryGetValue(Now_TurtleAI, out speaklist);
            if (speaklist == null || speaklist.Count == 0)
            {
                return;
            }

            string speakcontent = speaklist[RandomHelper.RandomNumber(0, speaklist.Count)];
            self.UINpcName.transform.Find("NpcHeadSpeakSet").gameObject.SetActive(true);
            self.UINpcName.transform.Find("NpcHeadSpeakSet/Lab_HeadSpeak").GetComponent<Text>().text = speakcontent;

            TimerComponent.Instance.Remove(ref self.TurtleTimer);
            self.TurtleTimer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + TimeHelper.Second * 5, TimerType.TurtleSpeak, self);
        }

        public static void OnTurtleSpeakFinish(this NpcHeadBarComponent self)
        {
            self.UINpcName.transform.Find("NpcHeadSpeakSet").gameObject.SetActive(false);
        }

        public static async ETTask WuGuiSay(this NpcHeadBarComponent self)
        {
            while (!self.IsDisposed)
            {
                self.UpdateTurtleAI();
                await TimerComponent.Instance.WaitAsync(30 * TimeHelper.Second);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }
        public static void OnUpdateNpcTalk(this NpcHeadBarComponent self, Unit mainUnit)
        {
            float distance = PositionHelper.Distance2D(mainUnit, self.Unit);
            if (distance < 10f && !self.MainUnitEnter)
            {
                self.MainUnitEnter = true;
                self.MainUnitExit = false;
                self.OnRecvTaskUpdate();
                NpcConfig npcConfig = NpcConfigCategory.Instance.Get(self.NpcId);
                self.UINpcName.transform.Find("NpcHeadSpeakSet").gameObject.SetActive(true);
                self.UINpcName.transform.Find("NpcHeadSpeakSet/Lab_HeadSpeak").GetComponent<Text>().text = npcConfig.SpeakText;
            }
            if (distance > 10f && !self.MainUnitExit)
            {
                self.MainUnitEnter = false;
                self.MainUnitExit = true;
                self.EnterPassTime = 0f;
                self.UINpcName.transform.Find("NpcHeadSpeakSet").gameObject.SetActive(false);
            }

            if (self.MainUnitEnter)
            {
                self.EnterPassTime += Time.deltaTime;
            }
            if (self.MainUnitEnter && self.EnterPassTime >= 10f)
            {
                self.UINpcName.transform.Find("NpcHeadSpeakSet").gameObject.SetActive(false);
            }
        }

        public static void OnRecvTaskUpdate(this NpcHeadBarComponent self)
        {
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
            List<TaskPro> taskProCompleted = taskComponent.GetCompltedTaskByNpc(self.NpcId);
            List<int> canGets = taskComponent.GetOpenTaskIds(self.NpcId);
            canGets.AddRange(self.GetAddtionTaskId(self.NpcId));

             self.ShowNpcEffect( 0, ABPathHelper.GetEffetPath("UIEffect/Effect_GetTask"), canGets.Count > 0 && taskProCompleted.Count == 0);
             self.ShowNpcEffect( 1, ABPathHelper.GetEffetPath("UIEffect/Effect_ComTask"), taskProCompleted.Count > 0);
        }

        public static List<int> GetAddtionTaskId(this NpcHeadBarComponent self, int npcId)
        {
            List<int> addTaskids = new List<int>();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
            if (npcId == 20000102)   //家族任务
            {
                int unionTaskId = numericComponent.GetAsInt(NumericType.UnionTaskId);
                if (unionTaskId > 0 && taskComponent.GetTaskById(unionTaskId) == null )
                {
                    addTaskids.Add(unionTaskId);
                }
            }
            return addTaskids;
        }
        
        public static void ShowNpcEffect(this NpcHeadBarComponent self, int type,  string path, bool show)
        {
            GameObject go = self.EffectComTask[type];
            if (show)
            {
                if (go == null)
                {
                    GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                    go = GameObject.Instantiate(prefab);
                    UICommonHelper.SetParent(go, self.GetParent<Unit>().GetComponent<HeroTransformComponent>().GetTranform( PosType.Head).gameObject);
                    go.transform.localPosition = new Vector3(0f, 1f, 0f);
                    self.EffectComTask[type] = go;
                }
                go.SetActive(true);
            }
            else
            {
                if (go != null)
                {
                    go.SetActive(false);
                }
            }
        }

        public static void Destroy(this NpcHeadBarComponent self)
        {
            if (self.UINpcName != null)
            {
                GameObject.Destroy(self.UINpcName);
                self.UINpcName = null;
            }

            if (self.EffectComTask[0] != null)
            {
                GameObject.Destroy(self.EffectComTask[0]);
            }
            if (self.EffectComTask[1] != null)
            {
                GameObject.Destroy(self.EffectComTask[1]);
            }
            self.EffectComTask[0] = null;
            self.EffectComTask[1] = null;
        }
    }
}
