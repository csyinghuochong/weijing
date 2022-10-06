using ET;
using System;
using UnityEngine;

namespace ET
{

    [FsmHandler]
    public class FsmComboState : AFsmHandler
    {

        public override void OnInit()
        {
        }

        public string GetSkillAnimation(string animation )
        {
            if (this.EquipType == (int)ItemEquipType.Knife)
                return animation;

            if (animation == "Act_1")
                return "Act_11";
            if (animation == "Act_2")
                return "Act_12";
            if (animation == "Act_3")
                return "Act_13";

            return animation;
        }

        public string GetSkillAction(string animation)
        {
            if (this.EquipType == (int)ItemEquipType.Knife)
            {
                return animation;
            }

            if (animation == "Act_11")
                return "Act_1";
            if (animation == "Act_12")
                return "Act_2";
            if (animation == "Act_13")
                return "Act_3";

            return animation;
        }

        public override void OnEnter(string paramss = "")
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(int.Parse(paramss));
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();

            int itemId = (int)this.FsmComponent.GetParent<Unit>().GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Weapon);
            if (itemId == 0)
            {
                this.EquipType = (int)ItemEquipType.Common;
            }
            else
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
                this.EquipType = itemConfig.EquipType;
            }

            this.ClearnAnimator();
            acomponent.PlayAnimation(GetSkillAnimation(skillConfig.SkillAnimation));
        }

        public override void OnReEnter(string paramss = "")
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(int.Parse(paramss));
            AnimatorComponent acomponent = FsmComponent.Parent.GetComponent<AnimatorComponent>();
            acomponent.PlayAnimation(GetSkillAnimation(skillConfig.SkillAnimation));
        }

        public override void OnExit()
        {

        }

    }
}