using libx;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [ObjectSystem]
    public class UiLoadingComponentAwakeSystem : AwakeSystem<UILoadingComponent>
    {
        public override void Awake(UILoadingComponent self)
        {
            self.Img_BackIcon = self.GetParent<UI>().GameObject.Get<GameObject>("Img_BackIcon");
            self.Image = self.GetParent<UI>().GameObject.Get<GameObject>("Image");
            self.lodingImg = self.GetParent<UI>().GameObject.Get<GameObject>("Img_LodingValue");
            self.text = self.GetParent<UI>().GameObject.Get<GameObject>("Lab_Text").GetComponent<Text>();
            self.BackSet = self.GetParent<UI>().GameObject.Get<GameObject>("BackSet");
            self.PreLoadAssets.Clear();
            self.StartLoadAssets = false;
            self.PassTime = 0f;
        }
    }

    public static class UILoadingComponentSystem
    {
        public static async ETTask OnInitUI(this UILoadingComponent self, int sceneTypeEnum, int chapterId)
        {
            await ETTask.CompletedTask;
            UnitHelper.LoadingScene = true;
            string loadResName = "Back_1";
            List<string> backpngs = new List<string>() { "Back_1", "Back_2", "Back_3", "Back_4", "Back_5" };
            int index = RandomHelper.RandomNumber(0, backpngs.Count);
            self.StartLoadAssets = false;
            switch (sceneTypeEnum)
            {
                case (int)SceneTypeEnum.MainCityScene:
                    self.PreLoadAssets.Add(ABPathHelper.GetUGUIPath(UIType.UIRole));
                    self.PreLoadAssets.Add(ABPathHelper.GetUGUIPath("Main/Role/UIRoleBag"));
                    self.PreLoadAssets.Add(ABPathHelper.GetUGUIPath("Common/UIModelShow1"));
                    self.PreLoadAssets.Add(ABPathHelper.GetUGUIPath("Main/Role/UIItem"));
                    self.PreLoadAssets.Add(ABPathHelper.GetUGUIPath(UIType.UIPet));
                    self.PreLoadAssets.Add(ABPathHelper.GetUGUIPath("Main/Pet/UIPetList"));
                    self.PreLoadAssets.Add(ABPathHelper.GetUGUIPath("Main/Pet/UIPetListItem"));
                    loadResName = "MainCity";
                    break;
                case (int)SceneTypeEnum.CellDungeon:
                case (int)SceneTypeEnum.TeamDungeon:
                case (int)SceneTypeEnum.YeWaiScene:
                case (int)SceneTypeEnum.Tower:
                case (int)SceneTypeEnum.RandomTower:
                case (int)SceneTypeEnum.PetDungeon:
                    loadResName = backpngs[index];
                    //self.PreLoadAssets.AddRange( self.GetRoleSkillEffect() );
                    //self.PreLoadAssets.AddRange( self.GetCommonAssets( ) );
                    break;
                case (int)SceneTypeEnum.LocalDungeon:
                    loadResName = backpngs[index];
                    self.PreLoadAssets.AddRange(self.GetLocalDungeonMonsters());
                    break;
            }

            long instanceid = self.InstanceId;
            self.BackSet.transform.Find(loadResName).gameObject.SetActive(true);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            self.PassTime = 0f;
            self.ChapterId = sceneTypeEnum == (int)SceneTypeEnum.CellDungeon ? chapterId : 0;

            UI uimain = UIHelper.GetUI(self.DomainScene(), UIType.UIMain);
            if (uimain != null)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UIMapBig).Coroutine();
                uimain.GetComponent<UIMainComponent>().BeginChangeScene();
            }
        }

        public static List<string> GetLocalDungeonMonsters(this UILoadingComponent self)
        {
            List<string> assets = new List<string>();

            int mapid = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            DungeonConfig chapterSonConfig = DungeonConfigCategory.Instance.Get(mapid);
            string createMonster = chapterSonConfig.CreateMonster;
            if (chapterSonConfig.MonsterGroup != 0)
            {
                MonsterGroupConfig monsterGroupConfig = MonsterGroupConfigCategory.Instance.Get(chapterSonConfig.MonsterGroup);
                createMonster = createMonster + "@"  + monsterGroupConfig.CreateMonster;
            }

            string[] monsters = createMonster.Split('@');
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i] == "0")
                {
                    continue;
                }

                string[] mondels = monsters[i].Split(';');
                string[] monsterid = mondels[2].Split(',');
                int monsterId = int.Parse(monsterid[0]);
                MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(monsterId);
                var path = ABPathHelper.GetUnitPath("Monster/" + monsterCof.MonsterModelID);
                if (!assets.Contains(path))
                {
                    assets.Add(path);
                }
            }
            return assets;
        }

        public static List<string> GetRoleSkillEffect(this UILoadingComponent self)
        {
            List<string> effects = new List<string>();
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for(int i = 0; i < skillSetComponent.SkillList.Count; i++)
            {
                SkillPro skillPro = skillSetComponent.SkillList[i];
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
            List<string> effects = new List<string>();
            effects.Add(ABPathHelper.GetUGUIPath("Battle/UIDropItem"));
            effects.Add(ABPathHelper.GetUGUIPath("Battle/UIBattleFly"));
            effects.Add(ABPathHelper.GetUGUIPath("Battle/UIMonsterHp"));
            return effects;
        }

        public static async ETTask StartPreLoadAssets(this UILoadingComponent self)
        {
            for (int i = self.PreLoadAssets.Count - 1; i >= 0; i--)
            {
                await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(self.PreLoadAssets[i]);
                self.PreLoadAssets.RemoveAt(i);
            }
        }

        public static void ShowProgress(this UILoadingComponent self, float progress)
        {
            progress = Mathf.Min(1f, Mathf.Max(progress, 0f));
            self.lodingImg.transform.localScale = new Vector3(progress, 1f, 1f);
            self.text.text = $"{(int)(progress * 100)}%";
        }
    }

    [ObjectSystem]
    public class UiLoadingComponentUpdateSystem : UpdateSystem<UILoadingComponent>
    {
        public override void Update(UILoadingComponent self)
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
                self.lodingImg.transform.localScale = new Vector3(1, 1f, 1f);
                self.text.text = "100%";
            }
            self.PassTime += Time.deltaTime;
            self.ShowProgress(0.9f + self.PassTime * 0.1f);
            if (self.PassTime > 0.5f && UnitHelper.LoadingScene)
            {
                UnitHelper.LoadingScene = false;
                UnitHelper.ShowAllUnit(self.DomainScene());
            }
            if (self.PassTime < 1f)
            {
                return;
            }
            UI uimain = UIHelper.GetUI(self.DomainScene(), UIType.UIMain);
            if (uimain == null)
            {
                return;
            }
            Unit mainUnit = UnitHelper.GetMyUnitFromZoneScene(self.DomainScene());
            if (mainUnit == null)
            {
                return;
            }
            int sceneTypeEnum = self.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum;
            //uimain.GameObject.SetActive(sceneTypeEnum != (int)SceneTypeEnum.PetFuben);
            uimain.GameObject.transform.localScale = sceneTypeEnum !=SceneTypeEnum.PetDungeon ? Vector3.one : Vector3.zero;
            Camera camera = UIComponent.Instance.MainCamera;
            camera.GetComponent<Camera>().fieldOfView = 50;
            sceneManagerComponent.SceneAssetRequest = null;
            uimain.GetComponent<UIMainComponent>().OnEnterScene(sceneTypeEnum);
            switch (sceneTypeEnum)
            {
                case (int)SceneTypeEnum.CellDungeon:
                    uimain.GetComponent<UIMainComponent>().OnCellDungeonEnterShow(self.ChapterId);
                    break;
                case (int)SceneTypeEnum.PetDungeon:
                    UIHelper.Create(self.ZoneScene(), UIType.UIPetMain).Coroutine();
                    break;
                case (int)SceneTypeEnum.RandomTower:
                    UIHelper.Create(self.ZoneScene(), UIType.UIRandomOpen).Coroutine();
                    break;
            }
            Game.Scene.GetComponent<SceneManagerComponent>().PlayBgmSound(self.ZoneScene(), sceneTypeEnum);
            UIHelper.Remove(self.DomainScene(), UIType.UILoading).Coroutine();
        }
    }

}