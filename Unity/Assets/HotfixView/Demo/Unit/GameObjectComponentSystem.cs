using System;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.HighLightTimer)]
    public class HighLightTimer : ATimer<GameObjectComponent>
    {
        public override void Run(GameObjectComponent self)
        {
            try
            {
                self.OnResetShader();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class GameObjectAwakeSystem : AwakeSystem<GameObjectComponent>
    {
        public override void Awake(GameObjectComponent self)
        {
            self.GameObject = null;
            self.Material = null;
            self.UnitAssetsPath = string.Empty;

            self.LoadGameObject();
        }
    }

    public class GameObjectDestroySystem : DestroySystem<GameObjectComponent>
    {
        public override void Destroy(GameObjectComponent self)
        {
            self.OnResetShader();
            self.RecoverHorse();
            self.RecoverGameObject();
            TimerComponent.Instance?.Remove(ref self.HighLightTimer);
            GameObjectPoolComponent.Instance.RecoverGameObject(ABPathHelper.GetUnitPath("Player/BaiTan"), self.BaiTan);
            self.BaiTan = null;
        }
    }


    public static class GameObjectComponentSystem
    {

        public static void RecoverGameObject(this GameObjectComponent self)
        {
            if (string.IsNullOrEmpty(self.UnitAssetsPath) && self.GameObject != null)
            {
                UnityEngine.Object.Destroy(self.GameObject);
                self.GameObject = null;
            }
            if (!string.IsNullOrEmpty(self.UnitAssetsPath))
            {
                self.OnRevive();
                GameObjectPoolComponent.Instance.RecoverGameObject(self.UnitAssetsPath, self.GameObject);
                self.GameObject = null;
            }
        }

        public static void LoadGameObject(this GameObjectComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            int unitType = unit.Type;
            switch (unitType)
            {
                case UnitType.Player:
                    MapComponent mapComponent = unit.ZoneScene().GetComponent<MapComponent>();
                    //宠物副本不显示玩家
                    if (unit.MainHero && (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetDungeon
                        || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetTianTi))
                    {
                        return;
                    }
                    int occId = unit.ConfigId;
                    var path = ABPathHelper.GetUnitPath($"Player/{OccupationConfigCategory.Instance.Get(occId).ModelAsset}");
                    GameObjectPoolComponent.Instance.AddPlayerLoad(occId, path, self.InstanceId, self.OnLoadGameObject);
                    self.UnitAssetsPath = path;
                    break;
                case UnitType.Monster:
                    int monsterId = unit.ConfigId;
                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(monsterId);
                    int userMaterModel = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UseMasterModel);
                    long masterId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
                    Unit master = unit.GetParent<UnitComponent>().Get(masterId);

                    if (userMaterModel == 1 && master != null
                        && master.GetComponent<GameObjectComponent>() != null
                        && master.GetComponent<GameObjectComponent>().GameObject != null)
                    {
                        GameObject gameObject = GameObject.Instantiate(master.GetComponent<GameObjectComponent>().GameObject);
                        self.OnLoadGameObject(gameObject, self.InstanceId);
                    }
                    else if (monsterCof.MonsterSonType == 58)
                    {
                        path = ABPathHelper.GetUnitPath("Pet/" + monsterCof.MonsterModelID);
                        GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                        self.UnitAssetsPath = path;
                    }
                    else if (monsterCof.MonsterSonType == 59)
                    {
                        path = ABPathHelper.GetUnitPath("JingLing/" + monsterCof.MonsterModelID);
                        GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                        self.UnitAssetsPath = path;
                    }
                    else
                    {
                        path = ABPathHelper.GetUnitPath("Monster/" + monsterCof.MonsterModelID);
                        GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                        self.UnitAssetsPath = path;
                    }
                    break;
                case UnitType.Pet:
                    int skinId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.PetSkin);
                    int configId = unit.ConfigId;
                    PetConfig petConfig = PetConfigCategory.Instance.Get(configId);
                    if (skinId == 0)
                    {
                        skinId = petConfig.Skin[0];
                    }
                    PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(skinId);
                    path = ABPathHelper.GetUnitPath("Pet/" + petSkinConfig.SkinID.ToString());
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    break;
                case UnitType.Bullet:   //从特效里面加载
                    int skillid = unit.ConfigId;
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillid);
                    EffectConfig effectConfig = EffectConfigCategory.Instance.Get(skillConfig.SkillEffectID[0]);
                    path = ABPathHelper.GetEffetPath("SkillEffect/" + effectConfig.EffectName);
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    break;
                case UnitType.Npc:
                    int npcId = unit.ConfigId;
                    NpcConfig config = NpcConfigCategory.Instance.Get(npcId);
                    path = ABPathHelper.GetUnitPath("Npc/" + config.Asset);
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    break;
                case UnitType.DropItem:
                    DropComponent dropComponent = unit.GetComponent<DropComponent>();
                    string assetPath = dropComponent.DropInfo.ItemID == 1 ? "DropICoin" : "DropItem";
                    path = ABPathHelper.GetUnitPath($"Player/{assetPath}");
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    self.UnitAssetsPath = path;
                    break;
                case UnitType.Chuansong:
                    path = ABPathHelper.GetUnitPath("Monster/DorrWay_1");
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    break;
                case UnitType.JingLing:
                    JingLingConfig jingLing = JingLingConfigCategory.Instance.Get(unit.ConfigId);
                    path = ABPathHelper.GetUnitPath("JingLing/" + jingLing.Assets);
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    break;
                case UnitType.Plant:
                    self.OnUpdatePlan();
                    break;
                case UnitType.Pasture:
                    JiaYuanPastureConfig jiaYuanPastureConfig = JiaYuanPastureConfigCategory.Instance.Get(unit.ConfigId);
                    path = ABPathHelper.GetUnitPath("Pasture/" + jiaYuanPastureConfig.Assets);
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    break;
                default:
                    break;
            }
        }

        public static void OnUpdatePlan(this GameObjectComponent self)
        {
            self.RecoverGameObject();
            Unit unit = self.GetParent<Unit>(); 
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(unit.ConfigId);
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long startTime = numericComponent.GetAsLong(NumericType.StartTime);
            int gatherNumber = numericComponent.GetAsInt(NumericType.GatherNumber);
            int planStage = JiaYuanHelper.GetPlanStage(unit.ConfigId, startTime, gatherNumber);
            string path = ABPathHelper.GetUnitPath($"JiaYuan/{jiaYuanFarmConfig.ModelID + planStage}");
            unit.RemoveComponent<JiaYuanPlanUIComponent>();
            unit.RemoveComponent<JiaYuanPlanEffectComponent>();
            GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
        }

        public static void RecoverHorse(this GameObjectComponent self)
        {
            if (self.ObjectHorse != null)
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(self.HorseAssetsPath, self.ObjectHorse);
                self.ObjectHorse = null;
            }
        }

        public static void UpdateRotation(this GameObjectComponent self, Quaternion quaternion)
        {
            if (self.ObjectHorse != null)
            {
                self.ObjectHorse.transform.rotation = quaternion;
                return;
            }
            if (self.GameObject != null)
            {
                self.GameObject.transform.rotation = quaternion;
            }
        }

        public static void UpdatePositon(this GameObjectComponent self, Vector3 vector)
        {
            if (self.ObjectHorse != null)
            {
                self.ObjectHorse.transform.position = vector;
                return;
            }
            if (self.GameObject!=null)
            {
                self.GameObject.transform.position = vector;
            }
        }

        public static void OnLoadHorse(this GameObjectComponent self, GameObject go, long formId)
        {
            if (self.IsDisposed || self.InstanceId!= formId)
            {
                GameObject.Destroy(go);
                return;
            }
            self.ObjectHorse = go;
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int horseRide = numericComponent.GetAsInt(NumericType.HorseRide);
            if (horseRide != 0)
            {
                self.OnShangMa(go, horseRide);
            }
            else
            {
                self.OnXiaMa();
            }
        }

        public static void ShowRoleDi(this GameObjectComponent self, bool show)
        {
            GameObject di = self.GameObject.transform.Find("fake shadow (5)").gameObject;
            di.SetActive(show);

            Unit unit = self.GetParent<Unit>();
            MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
            bool run = moveComponent != null && !moveComponent.IsArrived();
            if (run)
            {
                unit.GetComponent<FsmComponent>().OnEnterFsmRunState();
            }
        }

        public static void OnShangMa(this GameObjectComponent self, GameObject go, int horseId)
        {
            if (self.GameObject == null)
            {
                return;
            }
            Unit unit = self.GetParent<Unit>();
            UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitPlayer.gameObject);
            go.SetActive(true);
            go.transform.localPosition = unit.Position;
            go.transform.rotation = unit.Rotation;

            UICommonHelper.SetParent(self.GameObject, HoreseHelper.GetHorseNode(self.ObjectHorse));
            self.GameObject.transform.localScale = HoreseHelper.GetRoleScale(go, horseId) * Vector3.one;
            //特殊处理
            if (horseId == 10008)
            {
                self.GameObject.transform.localRotation = Quaternion.Euler(0, 90, 0);
            }
            unit.GetComponent<FsmComponent>().SetHorseState();
            unit.GetComponent<AnimatorComponent>().UpdateAnimator(go);
            self.ShowRoleDi(false);
        }

        public static void OnXiaMa(this GameObjectComponent self)
        {
            if (self.GameObject == null)
            {
                return;
            }
            self.RecoverHorse();
            Unit unit = self.GetParent<Unit>();
            UICommonHelper.SetParent(self.GameObject, GlobalComponent.Instance.UnitPlayer.gameObject);
            self.UpdatePositon(self.GetParent<Unit>().Position);
            unit.GetComponent<AnimatorComponent>()?.UpdateAnimator(self.GameObject);
            self.ShowRoleDi(true);
        }

        public static void OnUpdateHorse(this GameObjectComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int horseRide = numericComponent.GetAsInt(NumericType.HorseRide);
            if (horseRide != 0)
            {
                MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
                if (SceneConfigHelper.UseSceneConfig(mapComponent.SceneTypeEnum))
                {
                    int sceneid = mapComponent.SceneId;
                    SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneid);
                    if (sceneConfig.IfMount == 1)
                    {
                        return;
                    }
                }

                ZuoQiShowConfig zuoQiShowConfig = ZuoQiShowConfigCategory.Instance.Get(horseRide);
                self.HorseAssetsPath = ABPathHelper.GetUnitPath($"ZuoQi/{zuoQiShowConfig.ModelID}");
                GameObjectPoolComponent.Instance.AddLoadQueue(self.HorseAssetsPath, self.InstanceId, self.OnLoadHorse);
            }
            else
            {
                self.OnXiaMa();
            }
        }

        public static void OnAddCollider(this GameObjectComponent self, GameObject go)
        {
            if (go.GetComponent<Collider>() == null)
            {
                BoxCollider box = go.AddComponent<BoxCollider>();
                box.size = new Vector3(1f, 2f, 1f);
                box.center = new Vector3(0f, 1f, 0f);
            }
        }

        public static void OnLoadGameObject(this GameObjectComponent self, GameObject go, long formId)
        {
            if (self.IsDisposed)
            {
                GameObject.Destroy(go);
                return;
            }
            Unit unit = self.GetParent<Unit>();
            int unitType = unit.Type;
            self.GameObject = go;
            go.SetActive(true);
            switch (unitType)
            {
                case UnitType.Player:
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitPlayer.gameObject);
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
                    LayerHelp.ChangeLayer(go.transform, LayerEnum.Player);
                    self.OnAddCollider(go);
                    int weaponid = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Weapon);
                    go.transform.name = unit.Id.ToString();
                    unit.UpdateUIType = HeadBarType.HeroHeadBar;
                    unit.AddComponent<HeroTransformComponent>();              //获取角色绑点组件
                    unit.AddComponent<ChangeEquipComponent>().InitWeapon(unit.ConfigId, weaponid);
                    unit.AddComponent<AnimatorComponent>();
                    unit.AddComponent<FsmComponent>();                         //当前状态组建
                    unit.AddComponent<EffectViewComponent>();               //添加特效组建
                    unit.AddComponent<SkillYujingComponent>();
                    unit.AddComponent<UIUnitHpComponent>();
                    self.OnUpdateHorse();
                    //血条UI组件
                    NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                    self.OnUnitStallUpdate(numericComponent.GetAsInt(NumericType.Now_Stall));
                    if (numericComponent.GetAsInt(NumericType.Now_Dead) == 1)
                    {
                        EventType.UnitDead.Instance.Unit = unit;
                        Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
                    }
                    else
                    {
                        unit.GetComponent<BuffManagerComponent>()?.InitBuff();
                        unit.GetComponent<SkillManagerComponent>()?.InitSkill();
                    }
                    if (unit.MainHero)
                    {
                        Transform topTf = unit.GetComponent<HeroTransformComponent>().GetTranform(PosType.Head).transform;
                        NpcLocalHelper.OnMainHero(topTf, go.transform, mapComponent.SceneTypeEnum);
                    }
                    break;
                case UnitType.Monster:
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitMonster.gameObject);
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    go.transform.name = unit.Id.ToString();
                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(unit.ConfigId);
                    if (monsterCof.AI != 0)
                    {
                        LayerHelp.ChangeLayer(go.transform, LayerEnum.Monster);
                        self.OnAddCollider(go);
                        unit.AddComponent<EffectViewComponent>();            //添加特效组建
                        unit.AddComponent<AnimatorComponent>();
                        unit.AddComponent<FsmComponent>();                 //当前状态组建
                        unit.AddComponent<SkillYujingComponent>();
                    }
                    if (monsterCof.MonsterType == (int)MonsterTypeEnum.Boss)
                    {
                        unit.AddComponent<MonsterActRangeComponent, int>(monsterCof.Id);         //血条UI组件

                        mapComponent = self.ZoneScene().GetComponent<MapComponent>();
                        bool shenYuan = mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon && mapComponent.FubenDifficulty == TeamFubenType.ShenYuan;
                        go.transform.localScale = shenYuan ? Vector3.one * 1.3f : Vector3.one;
                    }

                    //51 场景怪 有AI 不显示名称
                    //52 能量台子 无AI
                    //54 场景怪 有AI 显示名称
                    //55 宝箱类 无AI
                    //56 宝箱类 刷新地图后即可刷新
                    //57 宠物蛋 直接掉落进背包
                    //58 宠物实体
                    //59 精灵实体
                    //60 家园物品
                    if (monsterCof.MonsterSonType == 51)
                    {
                        unit.UpdateUIType = -1;
                    }
                    else if (monsterCof.MonsterSonType == 52 || monsterCof.MonsterSonType == 54)
                    {
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<SceneItemUIComponent>(); //血条UI组件
                    }
                    else if (monsterCof.MonsterSonType == 58 || monsterCof.MonsterSonType == 59)
                    {
                        self.OnAddCollider(go);
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<SceneItemUIComponent>();         //血条UI组件
                        LayerHelp.ChangeLayer(go.transform, LayerEnum.Monster);
                    }
                    else if (unit.IsChest() || monsterCof.MonsterSonType == 60)
                    {
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<SceneItemUIComponent>();         //血条UI组件
                        LayerHelp.ChangeLayer(go.transform, LayerEnum.Box);
                    }
                    else if (monsterCof.MonsterType != (int)MonsterTypeEnum.SceneItem)
                    {
                        unit.UpdateUIType = HeadBarType.HeroHeadBar;
                        unit.AddComponent<HeroTransformComponent>();       //获取角色绑点组件
                        unit.AddComponent<UIUnitHpComponent>();         //血条UI组件
                    }

                    if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
                    {
                        EventType.UnitDead.Instance.Unit = unit;
                        Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
                    }
                    else
                    {
                        unit.GetComponent<BuffManagerComponent>()?.InitBuff();
                        unit.GetComponent<SkillManagerComponent>()?.InitSkill();
                    }
                    break;
                case UnitType.Pet:
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitMonster.gameObject);
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    unit.UpdateUIType = HeadBarType.HeroHeadBar;
                    go.transform.name = unit.Id.ToString();
                    unit.AddComponent<EffectViewComponent>();            //添加特效组建
                    unit.AddComponent<AnimatorComponent>();
                    unit.AddComponent<HeroTransformComponent>();       //获取角色绑点组件
                    unit.AddComponent<FsmComponent>();                 //当前状态组建
                    unit.AddComponent<UIUnitHpComponent>();         //血条UI组件
                    self.OnAddCollider(go);
                    LayerHelp.ChangeLayer(go.transform, LayerEnum.Monster);
                    break;
                case UnitType.Npc:
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitMonster.gameObject);
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    LayerHelp.ChangeLayer(go.transform, LayerEnum.NPC);
                    self.OnAddCollider(go);
                    unit.UpdateUIType = HeadBarType.NpcHeadBarUI;
                    go.name = unit.ConfigId.ToString();
                    unit.AddComponent<AnimatorComponent>();
                    unit.AddComponent<HeroTransformComponent>();
                    unit.AddComponent<NpcHeadBarComponent>();
                    unit.AddComponent<FsmComponent>();
                    break;
                case UnitType.DropItem:
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitMonster.gameObject);
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    go.name = unit.Id.ToString();
                    unit.UpdateUIType = HeadBarType.DropUI;
                    DropComponent dropComponent = unit.GetComponent<DropComponent>();
                    unit.AddComponent<EffectViewComponent>();
                    unit.AddComponent<DropUIComponent>().InitData(dropComponent.DropInfo);
                    break;
                case UnitType.Chuansong:
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitMonster.gameObject);
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    go.name = unit.Id.ToString();
                    switch (unit.GetComponent<ChuansongComponent>().DirectionType)
                    {
                        case 1: //上
                            go.transform.localRotation = Quaternion.Euler(-90, 0, 180);         //设置旋转
                            break;
                        case 2: //左
                            go.transform.localRotation = Quaternion.Euler(-90, 0, 90);         //设置旋转
                            break;
                        case 3: //下
                            go.transform.localRotation = Quaternion.Euler(-90, 0, 0);         //设置旋转
                            break;
                        case 4: //右
                            go.transform.localRotation = Quaternion.Euler(-90, 0, -90);         //设置旋转
                            break;
                        default:
                            break;
                    }
                    unit.UpdateUIType = HeadBarType.TransferUI;
                    unit.AddComponent<TransferUIComponent>().OnInitUI(unit.ConfigId).Coroutine();
                    unit.GetComponent<ChuansongComponent>().ChuanSongOpen = true;
                    break;
                case UnitType.JingLing:
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitMonster.gameObject);
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    unit.UpdateUIType = HeadBarType.HeroHeadBar;
                    go.transform.name = unit.Id.ToString();
                    unit.AddComponent<EffectViewComponent>();            //添加特效组建
                    unit.AddComponent<AnimatorComponent>();
                    unit.AddComponent<HeroTransformComponent>();       //获取角色绑点组件
                    unit.AddComponent<FsmComponent>();                 //当前状态组建
                    unit.AddComponent<UIUnitHpComponent>();         //血条UI组件
                    break;
                case UnitType.Pasture:
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitMonster.gameObject);
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    LayerHelp.ChangeLayer(go.transform, LayerEnum.Monster);
                    self.OnAddCollider(go);
                    unit.UpdateUIType = HeadBarType.HeroHeadBar;
                    go.transform.name = unit.Id.ToString();
                    unit.AddComponent<EffectViewComponent>();            //添加特效组建
                    unit.AddComponent<AnimatorComponent>();
                    unit.AddComponent<HeroTransformComponent>();       //获取角色绑点组件
                    unit.AddComponent<FsmComponent>();                 //当前状态组建
                    unit.AddComponent<JiaYuanPastureUIComponent>();         //血条UI组件
                    break;
                case UnitType.Plant:
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitMonster.gameObject);
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    unit.UpdateUIType = HeadBarType.HeroHeadBar;
                    go.transform.name = unit.Id.ToString();
                    go.transform.localScale = Vector3.one * 10f;
                    unit.AddComponent<JiaYuanPlanUIComponent>();
                    unit.AddComponent<JiaYuanPlanEffectComponent>();
                    break;
                case UnitType.Bullet:
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitEffect.gameObject);
                    go.name = unit.Id.ToString();
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get( unit.ConfigId );
                    if (skillConfig.GameObjectName.Equals(StringBuilderHelper.Skill_ComTargetMove_RangDamge_2))
                    {
                        unit.AddComponent<RoleBullet2Componnet>().BaseOnBulletInit(unit.ConfigId);
                    }
                    break;
                default:
                    break;
            }
        }

        public static void OnHighLight(this GameObjectComponent self)
        {
            if (GlobalHelp.GetBigVersion() < 15)
            {
                return;
            }
            if (self.Material == null)
            {
                Material[] materials = self.GameObject.GetComponentInChildren<SkinnedMeshRenderer>().materials;
                for (int i = 0; i < materials.Length; i++)
                {
                    if (materials[i].shader == null)
                    {
                        continue;
                    }
                    if (materials[i].shader.name.Contains(StringBuilderHelper.ToonBasic))
                    {
                        self.Material = materials[i];
                        break;
                    }
                }
            }

            if (self.Material != null)
            {
                self.Material.shader = GlobalHelp.Find(StringBuilderHelper.Ill_HighLight);
                //self.Material.shader = GlobalHelp.Find(StringBuilderHelper.Ill_RimLight);     //第二种效果  高亮
                TimerComponent.Instance.Remove(ref  self.HighLightTimer);
                self.HighLightTimer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + 120, TimerType.HighLightTimer, self);
            }
        }

        public static void OnResetShader(this GameObjectComponent self)
        {
            if (GlobalHelp.GetBigVersion() < 15)
            {
                return;
            }
            if (self.Material != null)
            {
                self.Material.shader = GlobalHelp.Find(StringBuilderHelper.ToonBasic);
            }
        }

        public static void OnHui(this GameObjectComponent self)
        {
            Transform transform = self.GameObject.transform;
            for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.GetChild(i).name.Equals(StringBuilderHelper.RoleBoneSet))
                {
                    continue;
                }
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        public static void OnRevive(this GameObjectComponent self)
        {
            if (self.GameObject == null)
            {
                return;
            }
            Transform transform = self.GameObject.transform;
            for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.GetChild(i).name == "RoleBoneSet")
                {
                    continue;
                }
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        public static void OnLoadBaiTan(this GameObjectComponent self, GameObject gameObject, long formId)
        {
            if (self.IsDisposed)
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(ABPathHelper.GetUnitPath("Player/BaiTan"), gameObject);
                return;
            }
            UICommonHelper.SetParent(gameObject, GlobalComponent.Instance.UnitPlayer.gameObject);
            self.BaiTan = gameObject;
            self.BaiTan.SetActive(true);
            self.BaiTan.transform.position = self.GameObject.transform.position;
            self.GameObject.transform.Find("BaseModel").gameObject.SetActive(false);
        }

        public static void  OnUnitStallUpdate(this GameObjectComponent self,int stallType)
        {
            if (stallType == 0)
            {
                if (self.BaiTan != null)
                {
                    GameObjectPoolComponent.Instance.RecoverGameObject(ABPathHelper.GetUnitPath("Player/BaiTan"), self.BaiTan);
                    self.BaiTan.SetActive(false);
                    self.BaiTan = null;
                }
                self.GameObject.transform.Find("BaseModel").gameObject.SetActive(true);
                return;
            }

            if (stallType == 1 && self.BaiTan == null)
            {
                if (self.BaiTan == null)
                {
                    GameObjectPoolComponent.Instance.AddLoadQueue(ABPathHelper.GetUnitPath("Player/BaiTan"), self.InstanceId, self.OnLoadBaiTan);
                }
                else
                {
                    self.OnLoadBaiTan(self.BaiTan, self.InstanceId);
                }
            }
        }
    }
}