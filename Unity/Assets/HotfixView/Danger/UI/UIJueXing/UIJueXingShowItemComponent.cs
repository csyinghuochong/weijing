using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{

    public class UIJueXingShowItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImageIcon;
        public GameObject ImageKuang;
        public GameObject TextSkillName;

        public Action<int> ClickHandler;
        public int SkillId;
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

        public static void OnInitUI(this UIJueXingShowItemComponent self, Action<int> action,  int skillId)
        { 
            self.SkillId = skillId;
            self.ClickHandler = action;     
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
            self.ImageIcon.GetComponent<Image>().sprite = sp;

            self.TextSkillName.GetComponent<Text>().text = skillConfig.SkillName;

            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();

            UICommonHelper.SetImageGray(self.ImageIcon, null ==skillSetComponent.GetBySkillID(skillId));


        }

    }
}