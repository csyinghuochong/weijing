
namespace ET
{

    [MessageHandler]
    public class M2C_SkillSetHandler : AMHandler<M2C_SkillSetMessage>
    {
        protected override void Run(Session session, M2C_SkillSetMessage message)
        {
            session.ZoneScene().GetComponent<SkillSetComponent>().UpdateSkillSet(message.SkillSetInfo);
        }
    }
}
