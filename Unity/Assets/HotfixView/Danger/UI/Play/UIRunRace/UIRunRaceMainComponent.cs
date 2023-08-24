using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIRunRaceMainComponent : Entity, IAwake, IDestroy
    {

        public Text EndTimeText;

        public UISkillGridComponent UISkillGrid;
    }

    public class UIRunRaceMainComponentAwake : AwakeSystem<UIRunRaceMainComponent>
    {
        public override void Awake(UIRunRaceMainComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.EndTimeText = rc.Get<GameObject>("EndTimeText").GetComponent<Text>();

            GameObject UI_MainRoseSkill_item = rc.Get<GameObject>("UI_MainRoseSkill_item");
            self.UISkillGrid = self.AddChild<UISkillGridComponent, GameObject>(UI_MainRoseSkill_item);
            self.UISkillGrid.SkillCancelHandler = self.ShowCancelButton;

            self.OnInitUI();
        }
    }

    public static class UIRunRaceMainComponentSystem
    {

        public static void OnInitUI(this UIRunRaceMainComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene() );
            int monsterId = unit.GetComponent<NumericComponent>().GetAsInt( NumericType.RunRaceMonster );
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get( monsterId );

            self.UISkillGrid.UpdateSkillInfo(new SkillPro()
            {
                SkillID = monsterConfig.ActSkillID,
                SkillSetType = (int)SkillSetEnum.Skill
            });
        }

        public static void ShowCancelButton(this UIRunRaceMainComponent self, bool show)
        { 
            
        }
    }
}