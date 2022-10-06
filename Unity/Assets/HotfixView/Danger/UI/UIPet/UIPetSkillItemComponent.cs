
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetSkillItemComponent : Entity, IAwake
    {
        public GameObject ImageKuang;
        public GameObject ImageIcon;
    }

    [ObjectSystem]
    public class UIPetSkillItemComponentAwakeSystem : AwakeSystem<UIPetSkillItemComponent>
    {
        public override void Awake(UIPetSkillItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageIcon = rc.Get<GameObject>("Image_ItemIcon");
        }
    }


    public static class UIPetSkillItemComponentSystem
    {

        public static void OnUpdateUI(this UIPetSkillItemComponent self, int skillId)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
            self.ImageIcon.GetComponent<Image>().sprite = sp;
        }
        
    }
}
