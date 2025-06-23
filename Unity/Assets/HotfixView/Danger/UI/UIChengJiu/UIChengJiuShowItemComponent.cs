using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChengJiuShowItemComponent : Entity, IAwake,IDestroy
    {
        public GameObject GameObject;
        public GameObject Lab_ChengJiuNum;
        public GameObject Lab_ProValue;
        public GameObject Lab_TaskName;
        public GameObject Ima_CompleteTask;
        public GameObject Ima_Icon;
        public GameObject Lab_TaskDes;
        
        public List<string> AssetPath = new List<string>();
    }


    public class UIChengJiuShowItemComponentAwakeSystem : AwakeSystem<UIChengJiuShowItemComponent>
    {

        public override void Awake(UIChengJiuShowItemComponent self)
        {
            self.GameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Lab_ChengJiuNum = rc.Get<GameObject>("Lab_ChengJiuNum");
            self.Lab_ProValue = rc.Get<GameObject>("Lab_ProValue");
            self.Lab_TaskName = rc.Get<GameObject>("Lab_TaskName");
            self.Ima_CompleteTask = rc.Get<GameObject>("Ima_CompleteTask");
            self.Ima_Icon = rc.Get<GameObject>("Ima_Icon");
            self.Lab_TaskDes = rc.Get<GameObject>("Lab_TaskDes");
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    public class UIChengJiuShowItemComponentDestroy : DestroySystem<UIChengJiuShowItemComponent>
    {
        public override void Destroy(UIChengJiuShowItemComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
            
            self.AssetPath = null;
        }
    }

    public static class UIChengJiuShowItemComponentSystem
    {
        public static void OnLanguageUpdate(this UIChengJiuShowItemComponent self)
        {
            if (self.GameObject == null)
            {
                return;
            }

            self.Lab_TaskName.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 30;
            self.Lab_TaskDes.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 32 : 26;
            self.Lab_ProValue.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 32 : 26;
            self.Lab_ChengJiuNum.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 38 : 28;
        }
        
        public static void OnUpdateData(this UIChengJiuShowItemComponent self, int id)
        {
            ChengJiuConfig chengJiuConfig = ChengJiuConfigCategory.Instance.Get(id);
            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();

            bool complete = chengJiuComponent.ChengJiuCompleteList.Contains(id);
            ChengJiuInfo chengJiuInfo = null;
            chengJiuComponent.ChengJiuProgessList.TryGetValue(id, out chengJiuInfo);

            self.Lab_TaskName.GetComponent<Text>().text = chengJiuConfig.GetName();
            if (complete)
            {
                self.Lab_ProValue.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("进度:{0}/{1}"), chengJiuConfig.TargetValue, chengJiuConfig.TargetValue);
            }
            else
            {
                self.Lab_ProValue.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("进度:{0}/{1}"), chengJiuInfo != null ? chengJiuInfo.ChengJiuProgess : 0, chengJiuConfig.TargetValue);
            }
            self.Ima_CompleteTask.SetActive(complete);

            self.Lab_TaskDes.GetComponent<Text>().text = chengJiuConfig.GetDes();

            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ChengJiuIcon, chengJiuConfig.Icon.ToString());
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.Ima_Icon.GetComponent<Image>().sprite = sp;
            
            self.Lab_ChengJiuNum.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("成就点数:{0}"), chengJiuConfig.RewardNum);
        }
    }

}
