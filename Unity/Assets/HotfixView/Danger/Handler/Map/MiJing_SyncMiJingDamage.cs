
namespace ET
{
    [Event]
    public class MiJing_SyncMiJingDamage : AEventClass<EventType.SyncMiJingDamage>
    {
        protected override void Run(object cls)
        {
            EventType.SyncMiJingDamage args = cls as EventType.SyncMiJingDamage;
            MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.MiJing)
            {
                UI uiBattleMain = UIHelper.GetUI(args.ZoneScene, UIType.UIMiJingMain);
                if (uiBattleMain == null)
                {
                    return;
                }
                uiBattleMain.GetComponent<UIMiJingMainComponent>().OnUpdateDamage(args.M2C_SyncMiJingDamage);
            }
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                UI uiMain = UIHelper.GetUI(args.ZoneScene, UIType.UIMain);
                if (uiMain == null)
                {
                    return;
                }
                uiMain.GetComponent<UIMainComponent>().UIMainTeam.OnUpdateDamage(args.M2C_SyncMiJingDamage);
            }
        }
    }
}
