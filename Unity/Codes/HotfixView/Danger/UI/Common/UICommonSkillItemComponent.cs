using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UICommonSkillItemComponent : Entity, IAwake<GameObject>
    {

        public GameObject ImageIcon;
        public GameObject ImageKuang;
        public GameObject GameObject;
        public ABAtlasTypes SkillAtlas;
        public int SkillId;
    }

    [ObjectSystem]
    public class UICommonSkillItemComponentAwakeSystem : AwakeSystem<UICommonSkillItemComponent, GameObject>
    {
        public override void Awake(UICommonSkillItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
            self.ImageKuang = rc.Get<GameObject>("ImageKuang");

            ButtonHelp.AddEventTriggers(self.ImageIcon, (PointerEventData pdata) => { self.BeginDrag(pdata).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.ImageIcon, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.PointerUp);
        }
    }

    public static class UICommonSkillItemComponentSystem
    {

        public static void OnUpdateUI(this UICommonSkillItemComponent self, int skillId, ABAtlasTypes SkillAtlas = ABAtlasTypes.RoleSkillIcon)
        {
            self.SkillId = skillId;
            if (!SkillConfigCategory.Instance.Contain(skillId))
            {
                return;
            }
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            Sprite sp = ABAtlasHelp.GetIconSprite(SkillAtlas, skillConfig.SkillIcon);
            self.ImageIcon.GetComponent<Image>().sprite = sp;
            self.SkillAtlas = SkillAtlas;
        }

        public static async ETTask BeginDrag(this UICommonSkillItemComponent self, PointerEventData pdata)
        {
            UI skillTips = await UIHelper.Create(self.DomainScene(), UIType.UISkillTips);

            Vector2 localPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);
            skillTips.GetComponent<UISkillTipsComponent>().OnUpdateData(self.SkillId, new Vector3(localPoint.x, localPoint.y, 0f), self.SkillAtlas);
        }

        public static void EndDrag(this UICommonSkillItemComponent self, PointerEventData pdata)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UISkillTips).Coroutine();
        }
    }

}
