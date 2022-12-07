using UnityEngine.UI;

namespace ET
{

    public class Fuben_OnFubenSettlement : AEventClass<EventType.FubenSettlement>
    {
        protected override void Run(object cls)
        {
            RunAsync(cls as EventType.FubenSettlement).Coroutine();
        }

        private async ETTask RunAsync(EventType.FubenSettlement args)
        {
            UI uimain = UIHelper.GetUI(args.Scene, UIType.UIMain);
            Button buttonReturn = uimain.GetComponent<UIMainComponent>().buttonReturn.GetComponent<Button>();
            buttonReturn.enabled = false;

            await TimerComponent.Instance.WaitAsync(1000);
            MapComponent mapComponent = args.Scene.GetComponent<MapComponent>();
            int sceneTypeEnum = mapComponent.SceneTypeEnum;
            if (sceneTypeEnum == (int)SceneTypeEnum.MainCityScene)
            {
                return;
            }
            switch (sceneTypeEnum)
            {
                case SceneTypeEnum.PetDungeon:
                    int star = 0;
                    for (int i = 0; i < args.m2C_FubenSettlement.StarInfos.Count; i++)
                    {
                        star += args.m2C_FubenSettlement.StarInfos[i];
                    }
                    if (args.m2C_FubenSettlement.BattleResult == 1)
                    {
                        args.Scene.GetComponent<PetComponent>().OnPassPetFuben(mapComponent.SonSceneId, star);
                    }
                    UIHelper.GetUI(args.Scene, UIType.UIPetMain).GetComponent<UIPetMainComponent>().OnFubenResult(args.m2C_FubenSettlement);
                    UI ui = await UIHelper.Create(args.Scene, UIType.UIPetFubenResult);
                    ui.GetComponent<UIPetFubenResultComponent>().OnUpdateUI(args.m2C_FubenSettlement);
                    break;
                case SceneTypeEnum.Tower:
                    ui = UIHelper.GetUI(args.Scene, UIType.UITowerOpen);
                    ui.GetComponent<UITowerOpenComponent>().OnFubenResult(args.m2C_FubenSettlement).Coroutine();
                    break;
                case SceneTypeEnum.PetTianTi:
                    UIHelper.GetUI(args.Scene, UIType.UIPetMain).GetComponent<UIPetMainComponent>().OnFubenResult ( args.m2C_FubenSettlement);
                    ui = await UIHelper.Create(args.Scene, UIType.UIPetFubenResult);
                    ui.GetComponent<UIPetFubenResultComponent>().OnUpdateUI(args.m2C_FubenSettlement);
                    break;
                case SceneTypeEnum.RandomTower:
                    ui = await UIHelper.Create(args.Scene, UIType.UIRandomTowerResult);
                    ui.GetComponent<UIRandomTowerResultComponent>().OnUpdateUI(args.m2C_FubenSettlement);
                    break;
                case SceneTypeEnum.TrialDungeon:
                    UI uitrial = UIHelper.GetUI(args.Scene, UIType.UITrialMain);
                    uitrial.GetComponent<UITrialMainComponent>().StopTimer();
                    PopupTipHelp.OpenPopupTip_2(args.Scene, args.m2C_FubenSettlement.BattleResult == CombatResultEnum.Win ? "胜利" : "失败", "恭喜你赢得了本场试炼的胜利！",
                     () => { EnterFubenHelp.RequestQuitFuben(args.Scene); }
                     ).Coroutine();
                    break;
                default:
                    ui = await UIHelper.Create(args.Scene, UIType.UICellDungeonSettlement);
                    ui.GetComponent<UICellDungeonSettlementComponent>().OnUpdateUI(args.m2C_FubenSettlement).Coroutine();
                    break;
            }
            buttonReturn.enabled = true;
        }
    }
}
