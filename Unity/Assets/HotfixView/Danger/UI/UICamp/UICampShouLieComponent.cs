using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{
    public class UICampShouLieComponent : Entity, IAwake
    {
        public GameObject Text_Tip_2;
        public GameObject ItemNodeList;
    }


    public class UICampShouLieComponentAwakeSystem : AwakeSystem<UICampShouLieComponent>
    {
        public override void Awake(UICampShouLieComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Tip_2 = rc.Get<GameObject>("Text_Tip_2");
            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");

            self.OnInitUI().Coroutine();
        }
    }

    public static class UICampShouLieComponentSystem
    { 
        
        public static async ETTask OnInitUI(this UICampShouLieComponent self)
        {
            string path = ABPathHelper.GetUGUIPath("Main/Camp/UICampShouLieItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            //List<CampRewardConfig> configs = CampRewardConfigCategory.Instance.GetAll().Values.ToList();
            List<TaskPro> tasks = new List<TaskPro>();
            for (int i = 0; i < tasks.Count; i++)
            {
                GameObject gameObject = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(gameObject, self.ItemNodeList);
                UICampShouLieItemComponent itemComponent = self.AddChild<UICampShouLieItemComponent, GameObject>(gameObject);
                itemComponent.OnInitUI(null);
            }
        }
    }
}
