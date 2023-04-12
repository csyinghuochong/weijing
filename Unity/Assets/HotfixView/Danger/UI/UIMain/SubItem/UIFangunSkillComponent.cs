using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFangunSkillComponent : Entity, IAwake<GameObject>
    {
        public Image Img_SkillCD;
        public Text Text_Time;
        public float LastSkillTime;
        public int SkillId;

    }


    public class SubFungunSkillComponentAwakeSystem : AwakeSystem<UIFangunSkillComponent, GameObject>
    {
        public override void Awake(UIFangunSkillComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            GameObject button_1 = gameObject;

            self.Img_SkillCD = rc.Get<GameObject>("Img_SkillCD").GetComponent<Image>();
            self.Text_Time = rc.Get<GameObject>("Text_Time").GetComponent<Text>();

            button_1.GetComponent<Button>().onClick.AddListener(() => { self.OnUseFangunSkill(); });

            self.SkillId = int.Parse(GlobalValueConfigCategory.Instance.Get(2).Value);
        }
    }

    public static class SubFungunSkillComponentSysmtem
    {

        public static void OnUpdate(this UIFangunSkillComponent self, long leftTime)
        {
            if (leftTime > 0)
            {
                int showCostTime = (int)(leftTime / 1000f) + 1;
                float proValue = (float)leftTime / 10000f;
                self.Text_Time.text = showCostTime.ToString();
                self.Img_SkillCD.fillAmount = proValue;
            }
            else
            {
                self.Text_Time.text = string.Empty;
                self.Img_SkillCD.fillAmount = 0f;
            }
        }

        public static void OnUseFangunSkill(this UIFangunSkillComponent self)
        {
            if (Time.time - self.LastSkillTime < 0.4f)
                return;

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int skillID = unit.GetComponent<SkillManagerComponent>().FangunSkillId;
            EventType.BeforeSkill.Instance.ZoneScene = self.ZoneScene();    
            EventSystem.Instance.PublishClass(EventType.BeforeSkill.Instance);
            unit.GetComponent<SkillManagerComponent>().SendUseSkill(skillID, 0, Mathf.FloorToInt(unit.Rotation.eulerAngles.y), 0, 0).Coroutine();

            self.LastSkillTime = Time.time;
        }
    }
}
