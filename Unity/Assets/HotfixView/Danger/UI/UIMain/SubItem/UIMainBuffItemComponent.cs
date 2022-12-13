using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace ET
{
    public class UIMainBuffItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextNumber;
        public GameObject TextLeftTime;
        public GameObject TextBuffName;
        public GameObject Img_BuffCD;
        public GameObject ImgBufflIcon;
        public GameObject GameObject;

        public int BuffID;
        public long BuffTime;
        public long EndTime;
        public string showTimeStr;
    }


    [ObjectSystem]
    public class UIMainBuffItemComponentAwakeSystem : AwakeSystem<UIMainBuffItemComponent, GameObject>
    {

        public override void Awake(UIMainBuffItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.TextBuffName = rc.Get<GameObject>("TextBuffName");
            self.Img_BuffCD = rc.Get<GameObject>("Img_BuffCD");
            self.ImgBufflIcon = rc.Get<GameObject>("ImgBufflIcon");
            self.TextLeftTime = rc.Get<GameObject>("TextLeftTime");

            ButtonHelp.AddEventTriggers(self.ImgBufflIcon, (PointerEventData pdata) => { self.BeginDrag(pdata).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.ImgBufflIcon, (PointerEventData pdata) => { self.EndDrag(pdata); }, EventTriggerType.PointerUp);
        }
    }

    public static class UIMainBuffItemComponentSystem
    {
        public static async ETTask BeginDrag(this UIMainBuffItemComponent self, PointerEventData pdata)
        {
            UI skillTips = await UIHelper.Create(self.DomainScene(), UIType.UIBuffTips);

            Vector2 localPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);
            skillTips.GetComponent<UIBuffTipsComponent>().OnUpdateData(self.BuffID, new Vector3(localPoint.x, localPoint.y, 0f), self.showTimeStr);
        }

        public static void EndDrag(this UIMainBuffItemComponent self, PointerEventData pdata)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIBuffTips);
        }

        public static bool OnUpdate(this UIMainBuffItemComponent self)
        {
            long leftTime  = self.EndTime - TimeHelper.ClientNow();

            self.Img_BuffCD.GetComponent<Image>().fillAmount = (self.BuffTime - leftTime) * 1f /  self.BuffTime;
            leftTime = leftTime / 1000;
            self.TextLeftTime.GetComponent<Text>().text = self.showTimeStr;
            return leftTime > 0;
        }

        public static void OnResetBuff(this UIMainBuffItemComponent self)
        {
            self.EndTime = TimeHelper.ClientNow() + self.BuffTime;
        }

        public static void OnAddBuff(this UIMainBuffItemComponent self, int buffId, long endTime)
        {
            SkillBuffConfig skillBuffConfig = SkillBuffConfigCategory.Instance.Get(buffId);
            self.BuffTime = skillBuffConfig.BuffTime;
            self.TextBuffName.GetComponent<Text>().text = skillBuffConfig.BuffName;
            self.EndTime = endTime;
            self.BuffID = buffId;

            string bufficon = skillBuffConfig.BuffIcon;
            if (ComHelp.IfNull(bufficon))
            {
                bufficon = "96001001";
            }
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, bufficon);
            self.ImgBufflIcon.GetComponent<Image>().sprite = sp;
        }

    }

}
