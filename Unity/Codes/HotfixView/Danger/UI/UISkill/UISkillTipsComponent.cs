using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UISkillTipsComponent : Entity, IAwake
    {
        public GameObject PositionNode;
        public GameObject ImageButton;
        public GameObject Lab_SkillDes;
        public GameObject Lab_SkillName;
        public GameObject Image_SkillIcon;

    }

    [ObjectSystem]
    public class UISkillTipsComponentAwakeSystem : AwakeSystem<UISkillTipsComponent>
    {
        public override void Awake(UISkillTipsComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.PositionNode = rc.Get<GameObject>("PositionNode");

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnImageButton(); });

            self.Lab_SkillDes = rc.Get<GameObject>("Lab_SkillDes");
            self.Lab_SkillName = rc.Get<GameObject>("Lab_SkillName");
            self.Image_SkillIcon = rc.Get<GameObject>("Image_SkillIcon");
        }

    }

    public static class UISkillTipsComponentSystem
    {
        public static void OnImageButton(this UISkillTipsComponent self)
        {
            UIHelper.Remove( self.DomainScene(), UIType.UISkillTips ).Coroutine();
        }

        public static void OnUpdateData(this UISkillTipsComponent self, int skillId, Vector3 vector3, ABAtlasTypes aBAtlasTypes = ABAtlasTypes.RoleSkillIcon)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            Sprite sp = ABAtlasHelp.GetIconSprite(aBAtlasTypes, skillConfig.SkillIcon);
            self.Image_SkillIcon.GetComponent<Image>().sprite = sp;

            self.Lab_SkillName.GetComponent<Text>().text = skillConfig.SkillName;
            self.Lab_SkillDes.GetComponent<Text>().text = skillConfig.SkillDescribe;

            if (vector3.x > UnityEngine.Screen.width * -0.5 + 500)
                self.PositionNode.transform.localPosition = vector3 + new Vector3(-50f,50f,0f);
            else
                self.PositionNode.transform.localPosition = vector3 + new Vector3(450f, 50f, 0f);
        }

    }

}

