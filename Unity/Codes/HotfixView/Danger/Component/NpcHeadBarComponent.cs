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


    [ObjectSystem]
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
            self.Awake(self.GetParent<Unit>()).Coroutine();
        }
    }

    [ObjectSystem]
    public class NpcHeadBarComponentDestroySystem : DestroySystem<NpcHeadBarComponent>
    {
        public override void Destroy(NpcHeadBarComponent self)
        {
            self.Destroy();
        }
    }

    public static class NpcHeadBarComponentSystem
    {
        public static async ETTask Awake(this NpcHeadBarComponent self, Unit myUnit)
        {
            self.npcUnit = myUnit;
            self.NpcId = myUnit.GetComponent<UnitInfoComponent>().UnitCondigID;

            long instanceid = self.InstanceId;
            await ETTask.CompletedTask;
            GameObject bundleObject = ResourcesComponent.Instance.LoadAsset<GameObject>(ABPathHelper.GetUGUIPath("Battle/UINpcName"));
            if (instanceid != self.InstanceId)
            {
                return;
            }
            self.UINpcName = GameObject.Instantiate(bundleObject);
            self.UINpcName.transform.SetParent(UIEventComponent.Instance.UILayers[(int)UILayer.Blood]);
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
            //self.LateUpdate();
        }

        public static void OnUpdateNpcTalk(this NpcHeadBarComponent self, Unit mainUnit)
        {
            float distance = PositionHelper.Distance2D(mainUnit, self.npcUnit);
            if (distance < 3f && !self.MainUnitEnter)
            {
                self.MainUnitEnter = true;
                self.MainUnitExit = false;
                self.OnRecvTaskUpdate();
                NpcConfig npcConfig = NpcConfigCategory.Instance.Get(self.NpcId);
                self.UINpcName.transform.Find("NpcHeadSpeakSet").gameObject.SetActive(true);
                self.UINpcName.transform.Find("NpcHeadSpeakSet/Lab_HeadSpeak").GetComponent<Text>().text = npcConfig.SpeakText;
            }
            if (distance > 3f && !self.MainUnitExit)
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
            if (self.MainUnitEnter && self.EnterPassTime >= 3f)
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
