using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.JiaYuanViewTimer)]
    public class JiaYuanViewTimer : ATimer<JiaYuanViewComponent>
    {
        public override void Run(JiaYuanViewComponent self)
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

    [ObjectSystem]
    public class JiaYuanViewComponentAwake : AwakeSystem<JiaYuanViewComponent>
    {
        public override void Awake(JiaYuanViewComponent self)
        {
            self.JianYuanPlanUIs.Clear();
        }
    }

    [ObjectSystem]
    public class JiaYuanViewComponentDestroy : DestroySystem<JiaYuanViewComponent>
    {
        public override void Destroy(JiaYuanViewComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);

            foreach(var item in self.JianYuanPlanUIs)
            { 
                
            }
        }
    }

    public static class JiaYuanViewComponentSystem
    {

        public static void OnInitUI(this JiaYuanViewComponent self)
        {
            int level = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            int openCell = 0;
            if (level > 10)
            {
                openCell = 10;
            }
            if (level > 60)
            {
                openCell = 20;
            }
            if (level > 70)
            {
                openCell = 40;
            }

            GameObject NongChangSet = GameObject.Find("NongChangSet");
            for (int i = 0; i < NongChangSet.transform.childCount; i++)
            {
                GameObject item = NongChangSet.transform.GetChild(i).gameObject;
                JiaYuanPlanUIComponent jiaYuanPlanUIComponent = self.AddChild<JiaYuanPlanUIComponent>();
                jiaYuanPlanUIComponent.GameObject = item;
                self.JianYuanPlanUIs.Add(i, jiaYuanPlanUIComponent);
                item.SetActive(i < openCell);
            }

            JianYuanComponent jianYuanComponent = self.ZoneScene().GetComponent<JianYuanComponent>();
            for (int i = 0; i < jianYuanComponent.JianYuanPlants.Count; i++)
            {
                JiaYuanPlant jianYuanPlant = jianYuanComponent.JianYuanPlants[i];
                self.JianYuanPlanUIs[jianYuanPlant.CellIndex].OnInitUI(jianYuanPlant);
            }

            self.Timer = TimerComponent.Instance.NewRepeatedTimer( 6000, TimerType.JiaYuanViewTimer, self);
        }

        public static void OnTimer(this JiaYuanViewComponent self)
        {
            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this JiaYuanViewComponent self)
        {
            JianYuanComponent jianYuanComponent = self.ZoneScene().GetComponent<JianYuanComponent>();
            for (int i = 0; i < jianYuanComponent.JianYuanPlants.Count; i++)
            {
                JiaYuanPlant jianYuanPlant = jianYuanComponent.JianYuanPlants[i];
                self.JianYuanPlanUIs[jianYuanPlant.CellIndex].OnUpdateUI(jianYuanPlant);
            }
        }
    }
}
