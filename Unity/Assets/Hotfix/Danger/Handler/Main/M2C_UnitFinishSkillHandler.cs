namespace ET
{
    [MessageHandler]
    public class M2C_UnitFinishSkillHandler : AMHandler<M2C_UnitFinishSkill>
    {
        protected override void Run(Session session, M2C_UnitFinishSkill message)
        {
            Scene curScene = session.ZoneScene().CurrentScene();
            if (curScene == null)
            {
                return;
            }
            Unit unit = curScene.GetComponent<UnitComponent>().Get(message.UnitId);
            if (unit != null)
            {
                unit.GetComponent<SkillManagerComponent>().OnFinish();
            }
        }
    }
}
