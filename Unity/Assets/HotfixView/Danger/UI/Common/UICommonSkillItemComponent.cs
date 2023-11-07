using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UICommonSkillItemComponent : Entity, IAwake<GameObject>,IDestroy
    {

        public GameObject ImageIcon;
        public GameObject ImageKuang;
        public GameObject GameObject;
        //public GameObject Text_XiLianName;
        public GameObject TextSkillName;
        public GameObject NewSkillHint;
        public string SkillAtlas;
        public int SkillId;
        public string addTip;
        
        public List<string> AssetPath = new List<string>();
    }


    public class UICommonSkillItemComponentAwakeSystem : AwakeSystem<UICommonSkillItemComponent, GameObject>
    {
        public override void Awake(UICommonSkillItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ImageIcon = rc.Get<GameObject>("ImageIcon");
            self.ImageKuang = rc.Get<GameObject>("ImageKuang");
            //self.Text_XiLianName = rc.Get<GameObject>("Text_XiLianName");
            self.TextSkillName = rc.Get<GameObject>("TextSkillName");
            self.NewSkillHint = rc.Get<GameObject>("NewSkillHint");

            ButtonHelp.AddEventTriggers(self.ImageIcon, (PointerEventData pdata) => { self.BeginDrag(pdata).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.ImageIcon, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.PointerUp);
        }
    }
    public class UICommonSkillItemComponentDestroy : DestroySystem<UICommonSkillItemComponent>
    {
        public override void Destroy(UICommonSkillItemComponent self)
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
    public static class UICommonSkillItemComponentSystem
    {

        public static void OnUpdateUI(this UICommonSkillItemComponent self, int skillId, string SkillAtlas = ABAtlasTypes.RoleSkillIcon, string addtip = "")
        {
            self.SkillId = skillId;
            if (!SkillConfigCategory.Instance.Contain(skillId))
            {
                return;
            }

            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillId);
            if (string.IsNullOrEmpty(skillConfig.SkillIcon))
            {
                return;
            }
            
            string path =ABPathHelper.GetAtlasPath_2(SkillAtlas, skillConfig.SkillIcon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ImageIcon.GetComponent<Image>().sprite = sp;
            self.SkillAtlas = SkillAtlas;
            self.addTip = addtip;

            self.TextSkillName.GetComponent<Text>().text = skillConfig.SkillName;
        }

        public static async ETTask BeginDrag(this UICommonSkillItemComponent self, PointerEventData pdata)
        {
            UI skillTips = await UIHelper.Create(self.DomainScene(), UIType.UISkillTips);

            Vector2 localPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);
            skillTips.GetComponent<UISkillTipsComponent>().OnUpdateData(self.SkillId, new Vector3(localPoint.x, localPoint.y, 0f), self.SkillAtlas, self.addTip);
        }

        public static void EndDrag(this UICommonSkillItemComponent self, PointerEventData pdata)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UISkillTips);
        }
    }

}
