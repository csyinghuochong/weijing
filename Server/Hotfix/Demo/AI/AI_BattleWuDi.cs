using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_BattleWuDi : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            return true;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            await ETTask.CompletedTask;
            Unit unit = aiComponent.GetParent<Unit>();
            C2M_SkillCmd cmd = new C2M_SkillCmd();
            cmd.SkillID = aiComponent.AISkillIDList[0];
            cmd.TargetID = 0;
            cmd.TargetDistance = 0;
            cmd.TargetAngle = (int)Quaternion.QuaternionToEuler(unit.Rotation).y; ;
            //触发技能
            unit.GetComponent<SkillManagerComponent>().OnUseSkill(cmd, true);
            return;
        }
    }
}
