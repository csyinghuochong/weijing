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
            if (self.SelectEffect != null)
            { 
                GameObject.Destroy(self.SelectEffect.gameObject);
                self.SelectEffect = null;
            }

            TimerComponent.Instance?.Remove(ref self.Timer);
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

            JiaYuanComponent jianYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            for (int i = 0; i < jianYuanComponent.JianYuanPlants.Count; i++)
            {
                JiaYuanPlant jianYuanPlant = jianYuanComponent.JianYuanPlants[i];
                self.JianYuanPlanUIs[jianYuanPlant.CellIndex].OnInitUI(jianYuanPlant);
            }

            string path = ABPathHelper.GetEffetPath("ScenceEffect/Eff_JiaYuan_Select");
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            self.SelectEffect = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            self.SelectEffect.SetActive(false);

            self.Timer = TimerComponent.Instance.NewRepeatedTimer( 1000, TimerType.JiaYuanViewTimer, self);
        }

        public static void OnTimer(this JiaYuanViewComponent self)
        {
            self.OnUpdateUI();
        }

        public static void OnUprootPlan(this JiaYuanViewComponent self, int cellindex)
        {
            self.JianYuanPlanUIs[cellindex].OnUprootPlan();
        }

        public static void OnSelectCell(this JiaYuanViewComponent self, int cell)
        {
            UICommonHelper.SetParent( self.SelectEffect, self.JianYuanPlanUIs[cell].GameObject );
            self.SelectEffect.SetActive(true);
            self.SelectEffect.transform.localPosition = new Vector3(-0.5f, 0.2f, -0.5f);
        }

        public static void OnSelectCancel(this JiaYuanViewComponent self)
        {
            self.SelectEffect?.SetActive(false);
        }
        
        public static void OnUpdateUI(this JiaYuanViewComponent self)
        {
            JiaYuanComponent jianYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            for (int i = 0; i < jianYuanComponent.JianYuanPlants.Count; i++)
            {
                JiaYuanPlant jianYuanPlant = jianYuanComponent.JianYuanPlants[i];
                self.JianYuanPlanUIs[jianYuanPlant.CellIndex].OnUpdateUI(jianYuanPlant);
            }
        }
    }
}
