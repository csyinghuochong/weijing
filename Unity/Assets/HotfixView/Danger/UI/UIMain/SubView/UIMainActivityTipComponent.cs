using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.MainActivityTipTimer)]
    public class MainActivityTipTimer : ATimer<UIMainActivityTipComponent>
    {
        public override void Run(UIMainActivityTipComponent self)
        {
            try
            {
                self.OnCheck();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIMainActivityTipComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;
        public GameObject ImageButton;
        public GameObject TextName;
        public List<ActivityTipConfig> ActivityShowList = new List<ActivityTipConfig>();

        public ActivityTipConfig ActivtyCur;   
        public int Index = 0;  //0 开始时间  1结束时间

        public long Timer;
    }


    public class UIMainActivityTipComponentAwake: AwakeSystem<UIMainActivityTipComponent, GameObject>
    {

        public override void Awake(UIMainActivityTipComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.TextName = rc.Get<GameObject>("TextName");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            ButtonHelp.AddListenerEx(self.ImageButton, self.OnButtonActivity);

            self.GameObject.SetActive(false);

            self.OnUpdateUI();
        }
    }

    public class UIMainActivityTipComponentDestroy : DestroySystem<UIMainActivityTipComponent>
    {
        public override void Destroy(UIMainActivityTipComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIMainActivityTipComponentSystem
    {

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="self"></param>
        public static void OnUpdateUI(this UIMainActivityTipComponent self)
        {
            self.Index = 0;
            TimerComponent.Instance.Remove(ref self.Timer);

            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeHelper.DateTimeNow();
            int hour = dateTime.Hour;
            int minute = dateTime.Minute;
            int second = dateTime.Second;
            int time1 = hour * 3600 + minute * 60 + second;  //当前时间

            for (int i = 0; i < ConfigHelper.ActivityShowList.Count; i++)
            {
                ActivityTipConfig worldSayConfig = ConfigHelper.ActivityShowList[i];

                if(!worldSayConfig.OpenDay.Contains((int)dateTime.DayOfWeek) && worldSayConfig.OpenDay[0]!= -1)
                {
                    continue;
                }

                int hour2 = (int)worldSayConfig.OpenTime / 100;
                int minute2 = (int)worldSayConfig.OpenTime % 100;
                int time2 = hour2 * 3600 + minute2 * 60;   //开始时间

                int hour3 = (int)worldSayConfig.CloseTime / 100;
                int minute3 = (int)worldSayConfig.CloseTime % 100;
                int time3 = hour3 * 3600 + minute3 * 60;   //结束时间

                if (time1 > time3)
                {
                    continue;
                }

                worldSayConfig.OpenTime = serverTime + (time2 - time1) * 1000 ;
                worldSayConfig.CloseTime = serverTime + (time3 - time1) * 1000;
                self.ActivityShowList.Add(worldSayConfig);

            }

            self.ActivityShowList.Sort(delegate (ActivityTipConfig a, ActivityTipConfig b)
            {
                return (a.OpenTime > b.OpenTime ? 1:0);
            });

            self.StartTimer();
        }


        public static void StartTimer(this UIMainActivityTipComponent self)
        {
            if (self.ActivityShowList.Count <= 0)
            {
                self.GameObject.SetActive(false);
                return;
            }


            TimerComponent.Instance.Remove(ref self.Timer);
            long nextTime = self.Index == 0 ? self.ActivityShowList[0].OpenTime : self.ActivityShowList[0].CloseTime;
            nextTime = Math.Max(nextTime, TimeHelper.ServerNow() + 1);

            self.ActivtyCur = self.ActivityShowList[0];
            self.Timer = TimerComponent.Instance.NewOnceTimer(nextTime, TimerType.MainActivityTipTimer, self);
        }

        public static void OnCheck(this UIMainActivityTipComponent self)
        {
           
            self.GameObject.SetActive(true);
            if (self.Index == 0 && self.ActivityShowList.Count > 0)
            {
                self.TextName.GetComponent<Text>().text = self.ActivityShowList[0].Conent;
            }
            if (self.Index == 1 && self.ActivityShowList.Count > 0)
            {
                self.ActivityShowList.RemoveAt(0);
            }

            self.Index = self.Index == 0 ? 1 : 0;
            self.StartTimer();
        }

        public static async void OnButtonActivity(this UIMainActivityTipComponent self)
        {
            if (!string.IsNullOrEmpty(self.ActivtyCur.UIType))
            {
                UI uicountry = await UIHelper.Create(self.ZoneScene(), self.ActivtyCur.UIType);
            }
            else
            {
                UI uicountry = await UIHelper.Create(self.ZoneScene(), UIType.UICountry);
                uicountry.GetComponent<UICountryComponent>().UIPageButton.OnSelectIndex(2);
            }

        }
    }
}