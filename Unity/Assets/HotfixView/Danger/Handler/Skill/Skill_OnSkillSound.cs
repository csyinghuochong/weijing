
namespace ET
{
    public class Skill_OnSkillSound : AEventClass<EventType.SkillSound>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillSound args = numerice as EventType.SkillSound;
            Game.Scene.GetComponent<SoundComponent>().PlayClip(args.Asset).Coroutine();
        }
    }
}
