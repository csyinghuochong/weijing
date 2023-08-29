using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIDemonMainComponent : Entity, IAwake, IDestroy
    {

        public UISkillGridComponent UISkillGrid;
    }


    public class UIDemonMainComponentAwake : AwakeSystem<UIDemonMainComponent>
    {
        public override void Awake(UIDemonMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject UI_MainRoseSkill_item = rc.Get<GameObject>("UI_MainRoseSkill_item");
            self.UISkillGrid = self.AddChild<UISkillGridComponent, GameObject>(UI_MainRoseSkill_item);
            self.UISkillGrid.SkillCancelHandler = self.ShowCancelButton;
            self.UISkillGrid.GameObject.SetActive(false);
        }
    }

    public static class UIDemonMainComponentSystem
    {

        public static void OnTransform(this UIDemonMainComponent self, int monsterId)
        {
            self.UISkillGrid.GameObject.SetActive(true);
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterId);
            self.UISkillGrid.UpdateSkillInfo(new SkillPro() { SkillID = monsterConfig.ActSkillID, SkillSetType = (int)SkillSetEnum.Skill });
        }

        public static void ShowCancelButton(this UIDemonMainComponent self, bool show)
        { 
            
        }
    }
}