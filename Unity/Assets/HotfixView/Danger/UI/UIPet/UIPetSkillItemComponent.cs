
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetSkillItemComponent : Entity, IAwake,IDestroy
    {
        public GameObject ImageKuang;
        public GameObject ImageIcon;
        
        public List<string> AssetPath = new List<string>();
    }


    public class UIPetSkillItemComponentAwakeSystem : AwakeSystem<UIPetSkillItemComponent>
    {
        public override void Awake(UIPetSkillItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageIcon = rc.Get<GameObject>("Image_ItemIcon");
        }
    }
    public class UIPetSkillItemComponentDestroy : DestroySystem<UIPetSkillItemComponent>
    {
        public override void Destroy(UIPetSkillItemComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }

    public static class UIPetSkillItemComponentSystem
    {

        public static void OnUpdateUI(this UIPetSkillItemComponent self, int skillId)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ImageIcon.GetComponent<Image>().sprite = sp;
        }
        
    }
}
