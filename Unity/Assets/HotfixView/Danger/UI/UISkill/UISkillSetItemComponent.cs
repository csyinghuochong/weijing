using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{

    public class UISkillSetItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Img_SkillIconDi;
        public GameObject Lab_SkillLv;
        public GameObject Lab_SkillName;
        public GameObject Img_SkillIcon;
        public GameObject Img_SkillIconDi_Copy;

        public Vector2 localPoint;
        public SkillPro SkillPro;
        public GameObject GameObject;
        public bool canDrag = true;
    }


    public class UISkillSetItemComponentAwakeSystem : AwakeSystem<UISkillSetItemComponent, GameObject>
    {
        public override void Awake(UISkillSetItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Img_SkillIconDi = rc.Get<GameObject>("Img_SkillIconDi");
            self.Lab_SkillLv = rc.Get<GameObject>("Lab_SkillLv");
            self.Lab_SkillName = rc.Get<GameObject>("Lab_SkillName");
            self.Img_SkillIcon = rc.Get<GameObject>("Img_SkillIcon");

            ButtonHelp.AddEventTriggers(self.Img_SkillIcon, (PointerEventData pdata) => { self.BeginDrag(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.Img_SkillIcon, (PointerEventData pdata) => { self.Draging(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.Img_SkillIcon, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.EndDrag);
        }
    }

    public static class UISkillSetItemComponentSystem
    {

        public static void BeginDrag(this UISkillSetItemComponent self, PointerEventData pdata)
        {
            self.Img_SkillIconDi_Copy = GameObject.Instantiate(self.Img_SkillIconDi);
            self.Img_SkillIconDi_Copy.transform.SetParent(UIEventComponent.Instance.UILayers[(int)UILayer.Low]);
            self.Img_SkillIconDi_Copy.transform.localScale = Vector3.one;
        }

        public static void Draging(this UISkillSetItemComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.Img_SkillIconDi_Copy.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out self.localPoint);

            self.Img_SkillIconDi_Copy.transform.localPosition = new Vector3(self.localPoint.x, self.localPoint.y, 0f);
        }

        public static void EndDrag(this UISkillSetItemComponent self, PointerEventData pdata)
        {
            RectTransform canvas = self.Img_SkillIconDi_Copy.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;
                if (!name.Contains("Danger_Skill_Icon_"))
                {
                    continue;
                }
                int index = int.Parse(name.Substring(18, name.Length - 18));
                if (index >= 9)
                {
                    continue;
                }
                skillSetComponent.SetSkillIdByPosition(self.SkillPro.SkillID, (int)SkillSetEnum.Skill, index).Coroutine();
                break;
            }
            if (self.Img_SkillIconDi_Copy != null)
            {
                GameObject.Destroy(self.Img_SkillIconDi_Copy);
                self.Img_SkillIconDi_Copy = null;
            }
        }

        public static void OnUpdateUI(this UISkillSetItemComponent self, SkillPro skillPro)
        {
            self.SkillPro = skillPro;

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            SkillConfig skillWeaponConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkill(skillPro.SkillID, bagComponent.GetEquipType()));
            self.Lab_SkillName.GetComponent<Text>().text = skillWeaponConfig.SkillName;
            self.Lab_SkillLv.GetComponent<Text>().text = skillWeaponConfig.SkillLv.ToString();
            Sprite sp = ABAtlasHelp.GetIconSprite( ABAtlasTypes.RoleSkillIcon, skillWeaponConfig.SkillIcon);
            self.Img_SkillIcon.GetComponent<Image>().sprite = sp;

            self.canDrag = skillWeaponConfig.SkillType == (int)SkillTypeEnum.ActiveSkill;
        }

    }

}
