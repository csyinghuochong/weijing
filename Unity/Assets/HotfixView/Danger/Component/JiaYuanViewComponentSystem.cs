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
            if (self.SelectEffect != null)
            { 
                GameObject.Destroy(self.SelectEffect.gameObject);
                self.SelectEffect = null;
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
                item.SetActive(i < openCell);
                self.JianYuanPlanUIs.Add(i, item);
            }

            string path = ABPathHelper.GetEffetPath("ScenceEffect/Eff_JiaYuan_Select");
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            self.SelectEffect = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            self.SelectEffect.SetActive(false);
        }

        public static void OnOpenPlan(this JiaYuanViewComponent self)
        { 
            
        }

        public static void OnUprootPlan(this JiaYuanViewComponent self)
        { 
            
        }

        public static void OnSelectCell(this JiaYuanViewComponent self, int cell)
        {
            UICommonHelper.SetParent( self.SelectEffect, self.JianYuanPlanUIs[cell]);
            self.CellIndex = cell;
            self.SelectEffect.SetActive(true);
            self.SelectEffect.transform.localPosition = new Vector3(-0.5f, 0.2f, -0.5f);
        }

        public static void OnSelectCancel(this JiaYuanViewComponent self)
        {
            self.SelectEffect?.SetActive(false);
        }
    }
}
