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
        public string SpellCast;
        public string showTimeStr;
        public string BuffIcon;
        public ABAtlasTypes aBAtlasTypes;
    }



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
            if (self.IsDisposed)
            {
                return;
            }
            if (self.BuffID == 0)
            {
                Log.Error($"UIMainBuffItemComponent {self.BuffID == 0}");
                return;
            }

            Vector2 localPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);
            skillTips.GetComponent<UIBuffTipsComponent>().OnUpdateData(self.BuffID, new Vector3(localPoint.x, localPoint.y, 0f), self.showTimeStr, self.SpellCast, self.aBAtlasTypes, self.BuffIcon);
        }

        public static void BeforeRemove(this UIMainBuffItemComponent self)
        { 
            UI uI = UIHelper.GetUI(self.DomainScene(), UIType.UIBuffTips);
            if (uI != null && self.BuffID == uI.GetComponent<UIBuffTipsComponent>().BuffId)
            {
                UIHelper.Remove(self.DomainScene(), UIType.UIBuffTips);
            }
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

        public static void OnAddBuff(this UIMainBuffItemComponent self, ABuffHandler buffHandler)
        {
            long endTime = buffHandler.BuffData.BuffEndTime;
            SkillBuffConfig skillBuffConfig = buffHandler.mSkillBuffConf;
            self.BuffTime = skillBuffConfig.BuffTime;
            self.TextBuffName.GetComponent<Text>().text = skillBuffConfig.BuffName;
            self.SpellCast = buffHandler.BuffData.Spellcaster;
            self.EndTime = endTime;
            self.BuffID = skillBuffConfig.Id;

            string bufficon = skillBuffConfig.BuffIcon;
            //Buff表BuffIcon为0时,显示图标显示为对应的技能图标,如果没找到对应资源,
            //释放者是怪物,那么就显示怪物的头像Icon,最后还是没找到显示默认图标b001
            ABAtlasTypes aBAtlasTypes = ABAtlasTypes.RoleSkillIcon;

            if (!ComHelp.IfNull(bufficon) && skillBuffConfig.BuffIconType.Equals("ItemIcon"))
            {
                aBAtlasTypes = ABAtlasTypes.ItemIcon;
            }
            if (ComHelp.IfNull(bufficon) && buffHandler.BuffData.SkillId != 0)
            {
                bufficon = SkillConfigCategory.Instance.Get(buffHandler.BuffData.SkillId).SkillIcon;
            }
            if (ComHelp.IfNull(bufficon) && buffHandler.BuffData.UnitType == UnitType.Monster)
            {
                aBAtlasTypes = ABAtlasTypes.MonsterIcon;
                bufficon = MonsterConfigCategory.Instance.Get(buffHandler.BuffData.UnitConfigId).MonsterHeadIcon;
            }
            if (ComHelp.IfNull(bufficon))
            {
                bufficon = "b001";
            }
            self.aBAtlasTypes = aBAtlasTypes;
            self.BuffIcon = bufficon;
            Sprite sp = ABAtlasHelp.GetIconSprite(aBAtlasTypes, bufficon);
            self.ImgBufflIcon.GetComponent<Image>().sprite = sp;
        }

    }

}
