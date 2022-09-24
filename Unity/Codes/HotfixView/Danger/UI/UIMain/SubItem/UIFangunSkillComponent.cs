using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFangunSkillComponent : Entity, IAwake<GameObject>
    {
        public GameObject Img_SkillCD;
        public GameObject Text_Time;
        public float LastSkillTime;
        public int SkillId;

    }

    [ObjectSystem]
    public class SubFungunSkillComponentAwakeSystem : AwakeSystem<UIFangunSkillComponent, GameObject>
    {
        public override void Awake(UIFangunSkillComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject button_1 = self.GetParent<UI>().GameObject;

            self.Img_SkillCD = rc.Get<GameObject>("Img_SkillCD");
            self.Text_Time = rc.Get<GameObject>("Text_Time");

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
                //显示冷却CD
                int showCostTime = (int)(leftTime / 1000) + 1;
                self.Text_Time.GetComponent<Text>().text = showCostTime.ToString();
                float proValue = (float)leftTime / 10000f;
                self.Img_SkillCD.GetComponent<Image>().fillAmount = proValue;
                self.Img_SkillCD.SetActive(true);
                self.Text_Time.SetActive(true);
            }
            else
            {
                self.Text_Time.SetActive(false);
                self.Img_SkillCD.SetActive(false);
            }
        }

        public static void OnUseFangunSkill(this UIFangunSkillComponent self)
        {
            if (Time.time - self.LastSkillTime < 0.4f)
                return;

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int skillID = unit.GetComponent<SkillManagerComponent>().FangunSkillId;
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().OnSpellStart();
            MapHelper.SendUseSkill(self.DomainScene(), skillID, Mathf.FloorToInt(unit.Rotation.eulerAngles.y), 0, 0).Coroutine();

            self.LastSkillTime = Time.time;
        }
    }
}
