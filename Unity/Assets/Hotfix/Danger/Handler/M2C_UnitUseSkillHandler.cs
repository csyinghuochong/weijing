using UnityEngine;

namespace ET
{

    [MessageHandler]
    public class M2C_UnitUseSkillHandler : AMHandler<M2C_UnitUseSkill>
    {
        protected override  void Run(Session session, M2C_UnitUseSkill message)
        {
            Scene curScene = session.ZoneScene().CurrentScene();
            if (curScene == null)
            {
                return;
            }
            Unit unit = curScene.GetComponent<UnitComponent>().Get(message.UnitId);
            if (unit != null)
            {
                unit.GetComponent<SkillManagerComponent>().OnUseSkill(message);
            }
            else
            {
                Log.Debug("unit == null  " + message.UnitId);
            }
        }

    }
}
