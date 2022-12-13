
namespace ET
{
    [Event]
    public class MiJing_SyncMiJingDamage : AEventClass<EventType.SyncMiJingDamage>
    {
        protected override void Run(object cls)
        {
            EventType.SyncMiJingDamage args = cls as EventType.SyncMiJingDamage;
            UI uiBattleMain = UIHelper.GetUI(args.ZoneScene, UIType.UIMiJingMain);
            if (uiBattleMain == null)
            {
                return;
            }
            uiBattleMain.GetComponent<UIMiJingMainComponent>().OnUpdateDamage(args.M2C_SyncMiJingDamage);
        }
    }
}
