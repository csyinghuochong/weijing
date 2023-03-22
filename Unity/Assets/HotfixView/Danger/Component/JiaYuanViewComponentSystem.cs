using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{

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
            foreach(var item in self.JianYuanPlanUIs)
            { 
                
            }
        }
    }

    public static class JiaYuanViewComponentSystem
    {

        public static void OnInitUI(this JiaYuanViewComponent self)
        {
            GameObject NongChangSet = GameObject.Find("NongChangSet");
            for (int i = 0; i < NongChangSet.transform.childCount; i++)
            {
                GameObject item = NongChangSet.transform.GetChild(i).gameObject;
                JiaYuanPlanUIComponent jiaYuanPlanUIComponent = self.AddChild<JiaYuanPlanUIComponent>();
                jiaYuanPlanUIComponent.GameObject = item;
                self.JianYuanPlanUIs.Add(i, jiaYuanPlanUIComponent);
            }
        }

        public static void OnUpdateUI(this JiaYuanViewComponent self)
        {
            if (self.JianYuanPlanUIs.Count == 0)
            {
                self.OnInitUI();
            }

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
            foreach (var item in self.JianYuanPlanUIs)
            {
                item.Value.GameObject.SetActive(item.Key < openCell);
            }

            JianYuanComponent jianYuanComponent = self.ZoneScene().GetComponent<JianYuanComponent>();
            for (int i = 0; i < jianYuanComponent.JianYuanPlants.Count; i++)
            { 

            }
        }
    }
}
