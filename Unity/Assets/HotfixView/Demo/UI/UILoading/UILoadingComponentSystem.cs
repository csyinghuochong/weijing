using libx;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UILoadingComponentAwakeDestroy : DestroySystem<UILoadingComponent>
    {
        public override void Destroy(UILoadingComponent self)
        {
            if (!string.IsNullOrEmpty(self.AssetPath))
            { 
                ResourcesComponent.Instance.UnLoadAsset(self.AssetPath);    
            }
            self.AssetPath = null;
        }
    }

    public class UILoadingComponentAwake : AwakeSystem<UILoadingComponent>
    {
        public override void Awake(UILoadingComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>(); 
            self.Image = rc.Get<GameObject>("Image");
            self.lodingImg = rc.Get<GameObject>("Img_LodingValue").GetComponent<Image>();
            self.text = rc.Get<GameObject>("Lab_Text").GetComponent<Text>();
            self.BackSet = rc.Get<GameObject>("BackSet");
            self.Back_1 = rc.Get<GameObject>("Back_1");
            self.PreLoadAssets.Clear();
            self.ReleaseAssets.Clear();
            self.StartLoadAssets = false;
            self.PassTime = 0f;
            self.ShowMainUI = false;
        }
    }

    public static class UILoadingComponentSystem
    {
        public static void  OnInitUI(this UILoadingComponent self,int lastScene, int sceneTypeEnum, int chapterId)
        {
            UnitFactory.LoadingScene = true;
            string loadResName = "MainCity";
            List<string> backpngs = new List<string>() { "Back_6" ,"Back_7",  "Back_11", "Back_13", "Back_14", "Back_15"};
            int index = RandomHelper.RandomNumber(0, backpngs.Count);
            self.StartLoadAssets = false;
            switch (sceneTypeEnum)
            {
                case (int)SceneTypeEnum.MainCityScene:
                    if (!ResourcesComponent.Instance.LoadCommonAsset)
                    {
                        ResourcesComponent.Instance.LoadCommonAsset = true;
                        self.PreLoadAssets.AddRange(self.GetCommonAssets());
                    }
                    SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(chapterId);
                    loadResName = !ComHelp.IfNull(sceneConfig.LoadingRes) ? sceneConfig.LoadingRes : "MainCity";
                    break;
                case (int)SceneTypeEnum.CellDungeon:
                    loadResName = backpngs[index];
                    self.PreLoadAssets.AddRange(self.GetRoleSkillEffect());
                    self.PreLoadAssets.AddRange(self.GetCommonAssets());
                    break;
                case (int)SceneTypeEnum.TeamDungeon:
                case (int)SceneTypeEnum.BaoZang:
                case (int)SceneTypeEnum.MiJing:
                case (int)SceneTypeEnum.Tower:
                case (int)SceneTypeEnum.RandomTower:
                case (int)SceneTypeEnum.TrialDungeon:
                case (int)SceneTypeEnum.PetDungeon:
                case (int)SceneTypeEnum.PetTianTi:
                case (int)SceneTypeEnum.PetMing:
                case (int)SceneTypeEnum.Battle:
                case (int)SceneTypeEnum.Arena:
                    loadResName = backpngs[index];
                    sceneConfig = SceneConfigCategory.Instance.Get(chapterId);
                    loadResName = !ComHelp.IfNull(sceneConfig.LoadingRes) ? sceneConfig.LoadingRes : "MainCity";
                    self.PreLoadAssets.AddRange( self.GetRoleSkillEffect() );
                    self.PreLoadAssets.AddRange(self.GetSceneDungeonMonsters());
                    break;
                case (int)SceneTypeEnum.LocalDungeon:
                    loadResName = backpngs[index];
                    self.PreLoadAssets.AddRange(self.GetRoleSkillEffect());
                    self.PreLoadAssets.AddRange(self.GetLocalDungeonMonsters());
                    self.ReleaseAssets.AddRange(self.GetLocalDungeonMonsters());
                    break;
                default:
                    loadResName = backpngs[index];
                    break;
            }

            if (!loadResName.Equals("MainCity"))
            {
                var path = ABPathHelper.GetJpgPath(loadResName);
                Sprite atlas = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                self.Back_1.GetComponent<Image>().sprite = atlas;
                self.Back_1.SetActive(true);
                self.AssetPath = path;  
            }

            self.PassTime = 0f;
            self.ChapterId = sceneTypeEnum == (int)SceneTypeEnum.CellDungeon ? chapterId : 0;
        }

        public static List<string> GetMonstersModelAndEffect(this UILoadingComponent self,  List<int> monsterIds)
        {
            List<string> assets = new List<string>();

            for (int i = 0; i < monsterIds.Count; i++)
            {
                int monsterId = monsterIds[i];

                MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(monsterId);
                var path = ABPathHelper.GetUnitPath("Monster/" + monsterCof.MonsterModelID);
                if (!assets.Contains(path))
                {
                    assets.Add(path);
                }

                if (monsterCof.MonsterType != MonsterTypeEnum.Boss)
                {
                    continue;
                }
                int[] aiSkillIDList = monsterCof.SkillID;
                if (aiSkillIDList == null)
                {
                    continue;
                }
                for (int s = 0; s < aiSkillIDList.Length; s++)
                {
                    if (aiSkillIDList[s] == 0)
                    {
                        continue;
                    }
                    if (!SkillConfigCategory.Instance.Contain(aiSkillIDList[s]))
                    {
                        continue;
                    }

                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(aiSkillIDList[s]);
                    int effectId = skillConfig.SkillEffectID[0];
                    if (effectId == 0)
                    {
                        continue;
                    }

                    string effectName = $"SkillEffect/{EffectConfigCategory.Instance.Get(effectId).EffectName}";
                    effectName = ABPathHelper.GetEffetPath(effectName);
                    if (!assets.Contains(effectName))
                    {
                        assets.Add(effectName);
                    }
                }
            }
            return assets;
        }

        public static List<string> GetLocalDungeonMonsters(this UILoadingComponent self)
        {
            int mapid = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            List<int> monsterIds = SceneConfigHelper.GetLocalDungeonMonsters(mapid);
            return self.GetMonstersModelAndEffect(monsterIds);
        }

        public static List<string> GetSceneDungeonMonsters(this UILoadingComponent self)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (!SceneConfigHelper.UseSceneConfig(mapComponent.SceneTypeEnum)
              || mapComponent.SceneTypeEnum!= SceneTypeEnum.TeamDungeon)
            {
                return new List<string>();
            }
            int mapid = mapComponent.SceneId;
            List<int> monsterIds = SceneConfigHelper.GetSceneMonsterList(mapid);
            return self.GetMonstersModelAndEffect(monsterIds);
        }

        public static List<string> GetRoleSkillEffect(this UILoadingComponent self)
        {
            List<string> effects = new List<string>();
            int fangunSkill = int.Parse(GlobalValueConfigCategory.Instance.Get(2).Value);
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            List<SkillPro> allskills = new List<SkillPro>();
            allskills.AddRange(skillSetComponent.SkillList);
            allskills.Add(new SkillPro() { SkillID = fangunSkill, SkillPosition = 100, SkillSetType = (int)SkillSetEnum.Skill });

            for (int i = 0; i < allskills.Count; i++)
            {
                SkillPro skillPro = allskills[i];
                if (skillPro.SkillPosition == 0)
                {
                    continue;
                }
                if (skillPro.SkillSetType != (int)SkillSetEnum.Skill)
                {
                    continue;
                }
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillPro.SkillID);
                if (skillConfig.SkillEffectID.Length > 0 && skillConfig.SkillEffectID[0] != 0)
                {
                    EffectConfig effectConfig = EffectConfigCategory.Instance.Get(skillConfig.SkillEffectID[0]);
                    effects.Add(ABPathHelper.GetEffetPath("SkillEffect/" + effectConfig.EffectName));
                }
                if (skillConfig.SkillHitEffectID != 0)
                {
                    EffectConfig effectConfig = EffectConfigCategory.Instance.Get(skillConfig.SkillHitEffectID);
                    effects.Add(ABPathHelper.GetEffetPath("SkillHitEffect/" + effectConfig.EffectName));
                }
            }
            
           
            return effects;
        }

        public static List<string> GetCommonAssets(this UILoadingComponent self)
        {
            List<string> effects = new List<string>()
            {  
                ABPathHelper.GetUGUIPath(UIType.UIRole),
                ABPathHelper.GetUGUIPath(UIType.UIPet),
                ABPathHelper.GetUGUIPath("Blood/UIDropItem"),
                ABPathHelper.GetUGUIPath("Blood/UIBattleFly"),
                ABPathHelper.GetUGUIPath("Blood/UIMonsterHp"),
                ABPathHelper.GetUGUIPath("Main/Role/UIRoleBag"),
                ABPathHelper.GetUGUIPath("Common/UIModelShow1"),
                ABPathHelper.GetUGUIPath("Main/Common/UICommonItem"),
                ABPathHelper.GetUGUIPath("Main/Pet/UIPetList"),
                ABPathHelper.GetUGUIPath("Main/Pet/UIPetListItem"),
            };
            return effects;
        }

        public static async ETTask StartPreLoadAssets(this UILoadingComponent self)
        {
            for (int i = self.PreLoadAssets.Count - 1; i >= 0; i--)
            {
                await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(self.PreLoadAssets[i]);
                self.PreLoadAssets.RemoveAt(i);
            }

            List<string> commonassets = self.GetCommonAssets();
            for (int i = 0; i < self.ReleaseAssets.Count; i++)
            {
                if (commonassets.Contains(self.ReleaseAssets[i]))
                {
                    continue;
                }
                ResourcesComponent.Instance.UnLoadAsset(self.ReleaseAssets[i]);
            }
        }

        public static void ShowProgress(this UILoadingComponent self, float progress)
        {
            progress = Mathf.Min(1f, Mathf.Max(progress, 0f));
            self.lodingImg.fillAmount = progress;
            self.text.text = $"{(int)(progress * 100)}%";
        }

        public static void  UpdateMainUI(this UILoadingComponent self, int sceneTypeEnum)
        {
            Scene zoneScene = self.ZoneScene();
            UI uimain = UIHelper.GetUI(zoneScene, UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().AfterEnterScene(sceneTypeEnum);
            switch (sceneTypeEnum)
            {
                case SceneTypeEnum.LocalDungeon:
                    int mapid = zoneScene.GetComponent<MapComponent>().SceneId;
                    int subType = DungeonConfigCategory.Instance.Get(mapid).MapType;
                    switch (subType)
                    {
                        case SceneSubTypeEnum.LocalDungeon_1:
                            UIHelper.Create(self.ZoneScene(), UIType.UIDungeonHappyMain).Coroutine();
                            uimain.GameObject.transform.localScale = Vector3.one;
                            break;
                        default:
                            UIHelper.Create(zoneScene, UIType.UIEnterMapHint).Coroutine();
                            break;
                    }
                    break;
                case SceneTypeEnum.CellDungeon:
                    uimain.GetComponent<UIMainComponent>().OnCellDungeonEnterShow(self.ChapterId);
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.PetDungeon:
                case SceneTypeEnum.PetTianTi:
                case SceneTypeEnum.PetMing:
                    UIHelper.Create(zoneScene, UIType.UIPetMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.zero;
                    break;
                case SceneTypeEnum.Tower:
                    UIHelper.Create(zoneScene, UIType.UITowerOpen).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.RandomTower:
                    UIHelper.Create(self.ZoneScene(), UIType.UIRandomOpen).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.Happy:
                    UIHelper.Create(self.ZoneScene(), UIType.UIHappyMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.Battle:
                    UIHelper.Create(zoneScene, UIType.UIBattleMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.Arena:
                    UIHelper.Create(zoneScene, UIType.UIArenaMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.TeamDungeon:
                    UIHelper.Create(zoneScene, UIType.UIEnterMapHint).Coroutine();
                    UIHelper.Create(zoneScene, UIType.UITeamMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.TrialDungeon:
                    UIHelper.Create(zoneScene, UIType.UITrialMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.TowerOfSeal:
                    UIHelper.Create(zoneScene, UIType.UITowerOfSealMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.JiaYuan:
                    UIHelper.Create(zoneScene, UIType.UIJiaYuanMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.RunRace:
                    UIHelper.Create(zoneScene, UIType.UIRunRaceMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.Demon:
                    UIHelper.Create(zoneScene, UIType.UIDemonMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                case SceneTypeEnum.MiJing:
                    UIHelper.Create(zoneScene, UIType.UIMiJingMain).Coroutine();
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
                default:
                    uimain.GameObject.transform.localScale = Vector3.one;
                    break;
            }
        }
    }

    /// <summary>
    /// 客户端登录流程：
    /// LoginHelper.Login           C2A_LoginAccount
    /// LoginHelper.GetRealmKey     C2A_GetRealmKey
    /// LoginHelper.EnterGame       C2R_LoginRealm  C2G_LoginGameGate  C2G_EnterGame        二次登录成功到此为止
    /// 服务器完成角色组装 登录流程
    /// S TransferHelper.Transfer
    /// S MessageHelper.SendToClient(unit, M2C_StartSceneChange);                   a
    ///     C SceneChangeHelper.SceneChangeTo                                       通知客户端切场景
    ///     C Game.EventSystem.PublishClass(EventType.SceneChangeStart.Instance);   加载场景
    ///     C await ResourcesComponent.Instance.LoadSceneAsync(path);
    ///     C 加载场景完成并且UIMain加载ok卸载uiloading
    /// S M2M_UnitTransferRequest request = new M2M_UnitTransferRequest();          a   服务器完成切场景，并通知客户端生成Unit. 
    ///     S MessageHelper.SendToClient(unit, M2C_CreateMyUnit);
    ///     C WaitType.Wait_CreateMyUnit waitCreateMyUnit = await zoneScene.GetComponent<ObjectWait>().Wait<WaitType.Wait_CreateMyUnit>();
    ///     C await zoneScene.GetComponent<ObjectWait>().Wait<WaitType.Wait_SceneChangeFinish>();
    ///     C //请求角色数据
    ///     C Game.EventSystem.PublishClass(EventType.EnterMapFinish.Instance);
    ///     C UIHelper.Create(args.ZoneScene, UIType.UIMain).Coroutine();
    /// </summary>

    public class UILoadingComponentUpdateSystem : UpdateSystem<UILoadingComponent>
    {
        public override  void Update(UILoadingComponent self)
        {
            try
            {
                SceneManagerComponent sceneManagerComponent = Game.Scene.GetComponent<SceneManagerComponent>();
                SceneAssetRequest sceneAssetRequest = sceneManagerComponent.SceneAssetRequest;
                if (sceneAssetRequest == null)
                {
                    return;
                }

                if (sceneAssetRequest.progress < 1)
                {
                    self.ShowProgress(sceneAssetRequest.progress - 0.3f);
                    return;
                }
                if (!self.StartLoadAssets)
                {
                    self.StartLoadAssets = true;
                    self.StartPreLoadAssets().Coroutine();
                }
                if (self.PreLoadAssets.Count > 0)
                {
                    self.ShowProgress(0.8f);
                    return;
                }
                else
                {
                    self.lodingImg.fillAmount = 1f;
                    self.text.text = "100%";
                }
                self.PassTime += Time.deltaTime;
                self.ShowProgress(0.9f + self.PassTime * 0.1f);
                if (self.PassTime > 0.5f && UnitFactory.LoadingScene)
                {
                    UnitFactory.LoadingScene = false;
                    UnitFactory.ShowAllUnit(self.DomainScene()).Coroutine();
                }
                if (self.PassTime < 1.5f )
                {
                    return;
                }
                Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                if (main == null)
                {
                    return;
                }
                UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
                if (uimain == null)
                {
                    //if (!self.ShowMainUI)
                    //{
                    //    self.ShowMainUI = true;
                    //    UIHelper.Create(self.ZoneScene(), UIType.UIMain).Coroutine();
                    //}
                    return;
                }
                Scene zoneScene = self.ZoneScene();
                int sceneType =  self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum;
                self.UpdateMainUI(sceneType);

                //Game.Scene.GetComponent<SoundComponent>().PlayBgmSound(self.ZoneScene(), sceneType);

                Camera camera = UIComponent.Instance.MainCamera;
                camera.GetComponent<Camera>().fieldOfView = 50;
                sceneManagerComponent.SceneAssetRequest = null;
                UIHelper.Remove(self.DomainScene(), UIType.UILoading);
                //播放传送特效
                if (sceneType != SceneTypeEnum.MainCityScene)
                {
                    FunctionEffect.GetInstance().PlaySelfEffect(UnitHelper.GetMyUnitFromZoneScene(zoneScene), 30000002);
                }
            }
            catch (Exception ex)
            {
                Log.Error("UILoading1: " + ex.ToString());
            }
        }
    }

}