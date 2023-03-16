using UnityEngine;

namespace ET
{

    //进入副本
    [Event]
    public class Fuben_OnAfterEnterFuben : AEventClass<EventType.AfterEnterFuben>
    {

        protected override  void Run(object cls)
        {
            RunAsync(cls as EventType.AfterEnterFuben).Coroutine();
        }

        private async ETTask RunAsync(EventType.AfterEnterFuben args)
        {
            CellDungeonComponent fubenComponent = args.ZoneScene.GetComponent<CellDungeonComponent>();
            int SonSceneId = fubenComponent.SonFubenInfo.SonSceneId;
            ChapterSonConfig chapterSonConfig = ChapterSonConfigCategory.Instance.Get(SonSceneId);

            if (args.EnterSonScene)
            {
                await Game.Scene.GetComponent<SceneManagerComponent>().ChangeSonScene(args.ZoneScene, SceneTypeEnum.CellDungeon, chapterSonConfig.MapID.ToString());
                ResourcesComponent.Instance.RemoveUnUseScene();
                //GlobalComponent.Instance.Unit.transform.localPosition = Vector3.zero;
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(args.ZoneScene);
                //unit.GetComponent<GameObjectComponent>().GameObject.transform.SetParent(GlobalComponent.Instance.Unit.transform);
                ChapterSonConfig chapterSon = ChapterSonConfigCategory.Instance.Get(SonSceneId);
                //更新unit出生点坐标
                int[] borpos;
                if (args.DirectionType == 1)
                    borpos = chapterSon.BornPosDwon;
                else if (args.DirectionType == 2)
                    borpos = chapterSon.BornPosRight;
                else if (args.DirectionType == 3)
                    borpos = chapterSon.BornPosUp;
                else
                    borpos = chapterSon.BornPosLeft;
                unit.Position = new Vector3(borpos[0] * 0.01f, borpos[1] * 0.01f, borpos[2] * 0.01f);
                //UICommonHelper.UpdaterAllHeadBar(unit);
                UnitFactory.LoadingScene = false;
                UnitFactory.ShowAllUnit(args.ZoneScene);
                await TimerComponent.Instance.WaitAsync(200);
                fubenComponent.CheckChuansongOpen();
            }
        }
    }
}