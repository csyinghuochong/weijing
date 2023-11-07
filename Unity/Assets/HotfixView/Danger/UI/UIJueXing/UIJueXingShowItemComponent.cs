using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{

    public class UIJueXingShowItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject ImageIcon;
        public GameObject ImageKuang;
        public GameObject TextSkillName;

        public Action<int> ClickHandler;
        public int SkillId;
        
        public List<string> AssetPath = new List<string>();
    }

    public class UIJueXingShowItemComponentAwake : AwakeSystem<UIJueXingShowItemComponent, GameObject>
    {
        public override void Awake(UIJueXingShowItemComponent self, GameObject gameObject)
        {
            //ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ImageIcon = gameObject.transform.Find("ImageMask/ImageIcon").gameObject;
            self.ImageKuang = gameObject.transform.Find("ImageKuang").gameObject;
            self.TextSkillName = gameObject.transform.Find("TextSkillName").gameObject;

            self.ImageIcon.GetComponent<Button>().onClick.AddListener( self.OnClickImageIcon);
        }
    }
    public class UIJueXingShowItemComponentDestroy : DestroySystem<UIJueXingShowItemComponent>
    {
        public override void Destroy(UIJueXingShowItemComponent self)
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
    public static class UIJueXingShowItemComponentSystem
    {

        public static void SetSelected(this UIJueXingShowItemComponent self, int skillid)
        {
            self.ImageKuang.SetActive( self.SkillId == skillid );
        }

        public static void OnClickImageIcon(this UIJueXingShowItemComponent self)
        {
            self.ClickHandler.Invoke( self.SkillId );
        }

        public static void OnUpdateUI(this UIJueXingShowItemComponent self)
        {
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            UICommonHelper.SetImageGray(self.ImageIcon, null == skillSetComponent.GetBySkillID(self.SkillId));
        }

        public static void OnInitUI(this UIJueXingShowItemComponent self, Action<int> action,  int skillId)
        { 
            self.SkillId = skillId;
            self.ClickHandler = action;     
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ImageIcon.GetComponent<Image>().sprite = sp;

            self.TextSkillName.GetComponent<Text>().text = skillConfig.SkillName;

            self.OnUpdateUI();
        }

    }
}