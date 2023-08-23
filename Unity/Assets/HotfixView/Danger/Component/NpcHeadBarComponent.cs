using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class NpcHeadBarComponent : Entity, IAwake, IDestroy
    {
        public Unit npcUnit;
        public GameObject UINpcName;
        public Vector3 OldPosition;
        public Vector3 NewPosition;
        public bool MainUnitEnter;
        public bool MainUnitExit;
        public float EnterPassTime;

        public int NpcId;
        public HeadBarUI HeadBarUI;
        public GameObject[] EffectComTask = new GameObject[2];
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
            self.npcUnit = null;
            self.Awake(self.GetParent<Unit>());
        }
    }


    public class NpcHeadBarComponentDestroySystem : DestroySystem<NpcHeadBarComponent>
    {
        public override void Destroy(NpcHeadBarComponent self)
        {
            self.Destroy();
        }
    }

    public static class NpcHeadBarComponentSystem
    {
        public static void Awake(this NpcHeadBarComponent self, Unit myUnit)
        {
            self.npcUnit = myUnit;
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
            self.HeadBarUI.HeadPos = self.npcUnit.GetComponent<HeroTransformComponent>().GetTranform(PosType.Head);
            self.HeadBarUI.HeadBar = self.UINpcName;

            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(self.NpcId);
            self.UINpcName.transform.Find("Lab_NpcName").GetComponent<Text>().text = npcConfig.Name;

            // 乌龟说话
            if (self.NpcId >= 20099011 && self.NpcId <= 20099013)
            {
                self.WuGuiSay().Coroutine();
            }
            //self.LateUpdate();
        }

        public static void UpdateTurtleAI(this NpcHeadBarComponent self)
        {
            int Now_TurtleAI = self.Parent.GetComponent<NumericComponent>().GetAsInt( NumericType.Now_TurtleAI );
            if (Now_TurtleAI == 1) //移动
            {
            }
            else  //停止
            { 
                
            }
        }

        public static async ETTask WuGuiSay(this NpcHeadBarComponent self)
        {
            long interval;
            bool flag = true;
            while (!self.IsDisposed)
            {
                if (flag)
                {
                    self.UINpcName.transform.Find("NpcHeadSpeakSet").gameObject.SetActive(true);
                    self.UINpcName.transform.Find("NpcHeadSpeakSet/Lab_HeadSpeak").GetComponent<Text>().text = "加油!加油!";
                    interval = 10000;
                }
                else
                {
                    self.UINpcName.transform.Find("NpcHeadSpeakSet").gameObject.SetActive(false);
                    interval = 20000;
                }

                flag = !flag;

                await TimerComponent.Instance.WaitAsync(interval);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }
        public static void OnUpdateNpcTalk(this NpcHeadBarComponent self, Unit mainUnit)
        {
            float distance = PositionHelper.Distance2D(mainUnit, self.npcUnit);
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

             self.ShowNpcEffect( 0, ABPathHelper.GetEffetPath("UIEffect/Effect_GetTask"), canGets.Count > 0 && taskProCompleted.Count == 0);
             self.ShowNpcEffect( 1, ABPathHelper.GetEffetPath("UIEffect/Effect_ComTask"), taskProCompleted.Count > 0);
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
