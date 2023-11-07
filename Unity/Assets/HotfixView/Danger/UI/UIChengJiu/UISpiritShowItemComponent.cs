using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISpiritShowItemComponent : Entity, IAwake,IDestroy
    {

        public GameObject Lab_SpiritNum;
        public GameObject Lab_ProValue;
        public GameObject Lab_TaskName;
        public GameObject Ima_CompleteTask;
        public GameObject Ima_Icon;
        public GameObject Lab_TaskDes;
        public List<string> AssetPath = new List<string>();
    }


    public class UISpiritShowItemComponentAwakeSystem : AwakeSystem<UISpiritShowItemComponent>
    {

        public override void Awake(UISpiritShowItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Lab_SpiritNum = rc.Get<GameObject>("Lab_SpiritNum");
            self.Lab_ProValue = rc.Get<GameObject>("Lab_ProValue");
            self.Lab_TaskName = rc.Get<GameObject>("Lab_TaskName");
            self.Ima_CompleteTask = rc.Get<GameObject>("Ima_CompleteTask");
            self.Ima_Icon = rc.Get<GameObject>("Ima_Icon");
            self.Lab_TaskDes = rc.Get<GameObject>("Lab_TaskDes");
        }
    }

    public class UISpiritShowItemComponentDestroy: DestroySystem<UISpiritShowItemComponent>
    {
        public override void Destroy(UISpiritShowItemComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }
    
    public static class UISpiritShowItemComponentSystem
    {

        public static void OnUpdateData(this UISpiritShowItemComponent self, int id)
        {
            SpiritConfig SpiritConfig = SpiritConfigCategory.Instance.Get(id);
            ChengJiuComponent ChengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();

            bool complete = ChengJiuComponent.ChengJiuCompleteList.Contains(id);
            ChengJiuInfo SpiritInfo = null;
            ChengJiuComponent.ChengJiuProgessList.TryGetValue(id, out SpiritInfo);

            self.Lab_TaskName.GetComponent<Text>().text = SpiritConfig.Name;
            if (complete)
            {
                self.Lab_ProValue.GetComponent<Text>().text ="进度:0/1";
            }
            else
            {
                self.Lab_ProValue.GetComponent<Text>().text = "进度:1/1";
            }
            self.Ima_CompleteTask.SetActive(complete);

            self.Lab_TaskDes.GetComponent<Text>().text = SpiritConfig.Des;

            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.MonsterIcon, SpiritConfig.Icon.ToString());
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.Ima_Icon.GetComponent<Image>().sprite = sp;
            
            //self.Lab_SpiritNum.GetComponent<Text>().text = string.Format("成就点数:{0}", SpiritConfig.RewardNum);
        }
    }

}
