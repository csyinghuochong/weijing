using System;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.UISingingTimer)]
    public class UISingingTimer : ATimer<UISingingComponent>
    {
        public override void Run(UISingingComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UISingingComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject Img_Progress;
        public GameObject Img_Di2;
        public float PassTime;
        public float TotalTime;
        public long Timer;
        public int Type;
    }

    [ObjectSystem]
    public class UISingingComponentAwakeSystem : AwakeSystem<UISingingComponent, GameObject>
    {
        public override void Awake(UISingingComponent self, GameObject go)
        {
            self.GameObject = go;
            self.Img_Progress = go.Get<GameObject>("Img_Progress");
            self.Img_Di2 = go.Get<GameObject>("Img_Di2");
            self.GameObject.SetActive(false);
        }
    }

    public static class UISingingComponentSystem
    {
        public static void OnTimer(this UISingingComponent self)
        {
            self.PassTime += Time.deltaTime;
            if (self.Type == 1)
            {
                self.Img_Progress.transform.localScale = new Vector3((1f * self.PassTime / self.TotalTime), 1f, 1f);
            }
            else
            {
                self.Img_Progress.transform.localScale = new Vector3((1f - 1f * self.PassTime / self.TotalTime), 1f, 1f);
            }
            
            if (self.PassTime >= self.TotalTime)
            {
                self.PassTime = 0;
                self.GameObject.SetActive(false);
                TimerComponent.Instance.Remove(ref self.Timer);
            }
        }

        public static void OnFrontSinging(this UISingingComponent self, int skillId)
        {
            self.Type = 1;
            self.PassTime = 0;
            self.GameObject.SetActive(true);
            self.TotalTime = (float)SkillConfigCategory.Instance.Get(skillId).SkillFrontSingTime;
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewFrameTimer( TimerType.UISingingTimer, self );
        }

        public static void OnSkillSinging(this UISingingComponent self, int skillId)
        {
            self.Type = 2;
            self.PassTime = 0;
            self.GameObject.SetActive(true);
            self.TotalTime = (float)SkillConfigCategory.Instance.Get(skillId).SkillSingTime;
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.UISingingTimer, self);
        }

        public static void OnSingingFinish(this UISingingComponent self)
        {
            self.PassTime = 0;
            self.GameObject.SetActive(false);
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }
}
