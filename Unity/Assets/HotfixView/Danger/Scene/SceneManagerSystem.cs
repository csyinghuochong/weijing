using UnityEngine;

namespace ET
{

    public static class SceneManagerSystem
    {

        public static void PlayBgmSound(this SceneManagerComponent self, Scene scene, int sceneTypeEnum)
        {
            string music = "";
            switch (sceneTypeEnum)
            {
                case (int)SceneTypeEnum.LoginScene:
                    music = "Login";
                    break;
                case (int)SceneTypeEnum.MainCityScene:
                    music = "MainCity";
                    break;
               case (int)SceneTypeEnum.TeamDungeon:
               case (int)SceneTypeEnum.JiaYuan:
                    int mapid = scene.GetComponent<MapComponent>().SceneId;
                    music = SceneConfigCategory.Instance.Get(mapid).Music;
                    break;
                case (int)SceneTypeEnum.CellDungeon:
                    music = ChapterConfigCategory.Instance.Get(scene.GetComponent<MapComponent>().SceneId).Music;
                    ChapterSonConfig chapterSonConfig = ChapterSonConfigCategory.Instance.Get(scene.GetComponent<MapComponent>().SonSceneId);
                    string[] monsters = chapterSonConfig.CreateMonster.Split('@');

                    for (int i = 0; i < monsters.Length; i++)
                    {
                        if (monsters[i] == "0")
                        {
                            continue;
                        }
                        string[] mondels = monsters[i].Split(';');
                        string[] monsterid = mondels[2].Split(',');
                        MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(int.Parse(monsterid[0]));
                        if (monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss)
                        {
                            music = "Boss";
                            break;
                        }
                    }
                    break;
                default:
                    music = "Fight_1";
                    break;
            }

            if (music != "")
            {
                Game.Scene.GetComponent<SoundComponent>().PlayMusic(music).Coroutine();
            }

            if (sceneTypeEnum != (int)SceneTypeEnum.LoginScene)
            {
                bool showMainUnit = sceneTypeEnum != (int)SceneTypeEnum.PetTianTi
                && sceneTypeEnum != (int)SceneTypeEnum.PetDungeon;
                Unit mainUnit = UnitHelper.GetMyUnitFromZoneScene(scene);
                //宠物副本 禁止玩家移动
                long rigidityEndTime = showMainUnit ? 0 :TimeHelper.ServerNow() + TimeHelper.OneDay;
                mainUnit.GetComponent<StateComponent>().SetNetWaitEndTime(rigidityEndTime);
            }
        }

        public static async ETTask ChangeSonScene(this SceneManagerComponent self, Scene scene, int sceneTypeEnum, string paramss)
        {
            scene.GetComponent<SkillIndicatorComponent>().BeginEnterScene();
            scene.GetComponent<LockTargetComponent>().BeginEnterScene();

            var path = ABPathHelper.GetScenePath(paramss);
            await ResourcesComponent.Instance.LoadSceneAdditive(path);

            self.UpdateChuanSong(scene, (int)sceneTypeEnum);
            //刷新主界面
            UI ui = UIHelper.GetUI(scene, UIType.UIMain);
            UIMainComponent uimain = ui.GetComponent<UIMainComponent>();
            uimain.AfterEnterScene(sceneTypeEnum);
        }

        public static void  UpdateChuanSong(this SceneManagerComponent self, Scene scene, int sceneTypeEnum)
        {
            AdditiveHide[] additiveHides = (AdditiveHide[])GameObject.FindObjectsOfType(typeof(AdditiveHide));
            for (int i = 0; i < additiveHides.Length; i++)
            {
                additiveHides[i].ToggleShow();
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
            {
                //显示传送
                GameObject ChuanSongPosiSet = GameObject.Find("AdditiveHide/ChuanSongPosiSet");
                if (ChuanSongPosiSet == null)
                    return;
                ChuanSongPosiSet.SetActive(true);
                CellDungeonComponent fubenComponent = scene.GetComponent<CellDungeonComponent>();
                bool isEnd = fubenComponent.IsEndCell();
                if (isEnd)
                {
                    ChuanSongPosiSet.SetActive(false);
                    return;
                }
                for (int i = 0; i < fubenComponent.SonFubenInfo.PassableFlag.Count; i++)
                {
                    string path = $"NoChuanSong_{i + 1}";
                    GameObject obj = ChuanSongPosiSet.transform.Find(path).gameObject;
                    if (obj != null)
                    {
                        obj.SetActive(fubenComponent.SonFubenInfo.PassableFlag[i] == 0);
                    }
                }
            }
        }

        public static async ETTask ChangeScene(this SceneManagerComponent self, Scene scene, int sceneTypeEnum,int lastScene, int chapterId)
        {
            string paramss = "";
            switch (sceneTypeEnum)
            {
                case (int)SceneTypeEnum.InitScene:
                    paramss = "Init";
                    break;
                case (int)SceneTypeEnum.LoginScene:
                    paramss = "Login";
                    break;
                case (int)SceneTypeEnum.MainCityScene:
                    AccountInfoComponent accountInfoComponent = scene.GetComponent<AccountInfoComponent>();
                    string scenepath = accountInfoComponent.Account == "tcg011" ? "101_test" : chapterId.ToString();
                    paramss = scenepath;
                    break;
                case (int)SceneTypeEnum.CellDungeon:
                    paramss = ChapterSonConfigCategory.Instance.Get(scene.GetComponent<MapComponent>().SonSceneId).MapID.ToString();
                    break;
                case (int)SceneTypeEnum.LocalDungeon:
                    paramss = DungeonConfigCategory.Instance.Get(chapterId).MapID.ToString();
                    break;
                default:
                    paramss = SceneConfigCategory.Instance.Get(chapterId).MapID.ToString();
                    break;
            }
            var path = ABPathHelper.GetScenePath(paramss);
            await ResourcesComponent.Instance.LoadSceneAsync(path);
            self.UpdateChuanSong(scene, sceneTypeEnum);
        }

    }
}
