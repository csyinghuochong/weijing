using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

    [Timer(TimerType.DelayShowTimer)]
    public class DelayShowTimer : ATimer<GameObjectComponent>
    {
        public override void Run(GameObjectComponent self)
        {
            try
            {
                if (self.IsDisposed)
                {
                    return;
                }
                self.GameObject.SetActive(true);
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
            self.OldShader = null;  
            self.UnitAssetsPath = string.Empty;
            self.DelayShow = 0;

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
            TimerComponent.Instance?.Remove(ref self.DelayShowTimer);
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
                    var path = string.Empty;

                    NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                    int runmonsterId = numericComponent.GetAsInt(NumericType.TransformId);
                    self.OnRunRaceMonster(runmonsterId, false);
                    //if (runmonsterId > 0)
                    //{
                    //    self.OnRunRaceMonster( runmonsterId, false );  
                    //}
                    //else
                    //{
                    //    path = ABPathHelper.GetUnitPath($"Player/{OccupationConfigCategory.Instance.Get(unit.ConfigId).ModelAsset}");
                    //    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    //    self.UnitAssetsPath = string.Empty;
                    //}
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
                    self.UnitAssetsPath = path;
                    break;
                case UnitType.Bullet:   //从特效里面加载
                    int skillid = unit.ConfigId;
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillid);
                    EffectConfig effectConfig = EffectConfigCategory.Instance.Get(skillConfig.SkillEffectID[0]);
                    self.DelayShow =  (long)(1000 * effectConfig.SkillEffectDelayTime);
                    path = ABPathHelper.GetEffetPath("SkillEffect/" + effectConfig.EffectName);
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    self.UnitAssetsPath = path;
                    break;
                case UnitType.Npc:
                    int npcId = unit.ConfigId;
                    NpcConfig config = NpcConfigCategory.Instance.Get(npcId);
                    path = ABPathHelper.GetUnitPath("Npc/" + config.Asset);
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    self.UnitAssetsPath = path;
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
                    self.UnitAssetsPath = path;
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
            if (numericComponent.GetAsInt(NumericType.TransformId) > 0)
            {
                return;
            }

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
            if (numericComponent.GetAsInt(NumericType.TransformId) > 0)
            {
                return;
            }

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
            if ( self.GameObject !=null)
            {
                Log.Error(" self.GameObject !=null");
                return;
            }
            self.GameObject = go;
            self.InitMaterial();
            if (self.DelayShow > 0)
            {
                go.SetActive(false);
                TimerComponent.Instance.Remove(ref self.DelayShowTimer);
                self.DelayShowTimer = TimerComponent.Instance.NewOnceTimer (TimeHelper.ServerNow() + self.DelayShow, TimerType.DelayShowTimer, self);
            }
            else
            {
                go.SetActive(true);
            }
            Unit unit = self.GetParent<Unit>();
            switch (unit.Type)
            {
                case UnitType.Player:
                
                    UICommonHelper.SetParent(go, GlobalComponent.Instance.UnitPlayer.gameObject);
                    go.transform.localPosition = unit.Position;
                    go.transform.rotation = unit.Rotation;
                    MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
                    LayerHelp.ChangeLayer(go.transform, LayerEnum.Player);
                    self.OnAddCollider(go);

                    NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                    int weaponid = numericComponent.GetAsInt(NumericType.Now_Weapon);
                    List<int> fashionids = unit.GetComponent<UnitInfoComponent>().FashionEquipList;
                    go.transform.name = unit.Id.ToString();
                    unit.UpdateUIType = HeadBarType.HeroHeadBar;
                    unit.AddComponent<HeroTransformComponent>();              //获取角色绑点组件
                    if (numericComponent.GetAsInt(NumericType.TransformId) == 0)
                    {
                        unit.AddComponent<ChangeEquipComponent>().InitWeapon(fashionids, unit.ConfigId, weaponid);
                        self.OnUnitStallUpdate(numericComponent.GetAsInt(NumericType.Now_Stall));
                    }
                    unit.AddComponent<AnimatorComponent>();
                    unit.AddComponent<FsmComponent>();                         //当前状态组建
                    unit.AddComponent<EffectViewComponent>();               //添加特效组建
                    unit.AddComponent<SkillYujingComponent>();
                    unit.AddComponent<UIUnitHpComponent>();

                    self.OnUpdateHorse();
                    unit.GetComponent<BuffManagerComponent>()?.InitBuff();
                    unit.GetComponent<SkillManagerComponent>()?.InitSkill();

                    if (unit.GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.Stealth))
                    { 
                        self.EnterStealth(); 
                    }
                    if (numericComponent.GetAsInt(NumericType.Now_Dead) == 1)
                    {
                        EventType.UnitDead.Instance.Unit = unit;
                        Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
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
                        self.OnAddCollider(go);
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<SceneItemUIComponent>(); //血条UI组件
                    }
                    else if (monsterCof.MonsterSonType == 58 || monsterCof.MonsterSonType == 59)
                    {
                        self.OnAddCollider(go);
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<SceneItemUIComponent>();         //血条UI组件
                        LayerHelp.ChangeLayer(go.transform, LayerEnum.Monster);

                        if (monsterCof.MonsterSonType == 58)
                        {
                            //实例化特效
                            FunctionEffect.GetInstance().PlaySelfEffect(unit, 91000106);
                        }

                        if (monsterCof.MonsterSonType == 59)
                        {
                            //实例化特效
                            FunctionEffect.GetInstance().PlaySelfEffect(unit, 91000107);
                        }
                    }
                    else if (unit.IsChest() || monsterCof.MonsterSonType == 60)
                    {
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<SceneItemUIComponent>();         //血条UI组件
                        LayerHelp.ChangeLayer(go.transform, LayerEnum.Box);
                    }
                    else if (monsterCof.MonsterSonType == 61)
                    {
                        self.OnAddCollider(go);
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<SceneItemUIComponent>();         //血条UI组件
                        LayerHelp.ChangeLayer(go.transform, LayerEnum.Monster);
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
                    unit.AddComponent<EffectViewComponent>();
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
                    break;
                default:
                    break;
            }

            if (unit.Type == UnitType.Bullet)
            {
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(unit.ConfigId);
                if (skillConfig.GameObjectName.Equals(StringBuilderHelper.Skill_ComTargetMove_RangDamge_2))
                {
                    unit.AddComponent<RoleBullet2Componnet>().BaseOnBulletInit(unit.ConfigId);
                }
            }
        }

        public static void InitMaterial(this GameObjectComponent self)
        {
            if (self.Material == null)
            {
                SkinnedMeshRenderer skinnedMeshRenderer = self.GameObject.GetComponentInChildren<SkinnedMeshRenderer>();
                if (skinnedMeshRenderer == null)
                {
                    return;
                }
                Material[] materials = skinnedMeshRenderer.materials;
                for (int i = 0; i < materials.Length; i++)
                {
                    if (materials[i].shader == null)
                    {
                        continue;
                    }
                    if (materials[i].shader.name.Equals(StringBuilderHelper.ToonBasic))
                    {
                        self.Material = materials[i];
                        self.OldShader = StringBuilderHelper.ToonBasic;
                        break;
                    }
                    if (materials[i].shader.name.Equals(StringBuilderHelper.ToonBasicOutline))
                    {
                        self.Material = materials[i];
                        self.OldShader = StringBuilderHelper.ToonBasicOutline;
                        break;
                    }
                }
            }
        }

        public static void OnHighLight(this GameObjectComponent self)
        {
            if (GlobalHelp.GetBigVersion() < 15)
            {
                return;
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
                self.Material.shader = GlobalHelp.Find(self.OldShader);
            }
        }

        /// <summary>
        /// 退出隐身
        /// </summary>
        /// <param name="self"></param>
        public static void ExitStealth(this GameObjectComponent self)
        {
            Unit unit = self.GetParent<Unit>();

            Log.ILog.Debug($"ExitStealth: {unit.Id}");

            //退出隐身
            float alpha = 1f;
            self.Material.shader = GlobalHelp.Find(self.OldShader);

            GameObject Wuqi001 = null;
            if (self.GameObject.GetComponent<ReferenceCollector>() !=null)
            {
                Wuqi001 = self.GameObject.Get<GameObject>("Wuqi001");
            }
            if (Wuqi001 != null)
            {
                // 武器恢复
                MeshRenderer[] meshRenderers = Wuqi001.GetComponentsInChildren<MeshRenderer>();
                foreach (MeshRenderer meshRenderer in meshRenderers)
                {
                    meshRenderer.material.shader = GlobalHelp.Find(StringBuilderHelper.ToonBasicOutline);
                }
            }

            // 脚底阴影恢复
            GameObject di = null;
            if (self.GameObject.transform.Find("fake shadow (5)")!=null)
            {
                di = self.GameObject.transform.Find("fake shadow (5)").gameObject;
                Color oldColorDi = di.GetComponent<MeshRenderer>().material.color;
                di.GetComponent<MeshRenderer>().material.color = new Color(oldColorDi.r, oldColorDi.g, oldColorDi.b, 0.5f);
            }

            // 脚底Buff恢复
            foreach (AEffectHandler aEffectHandler in unit.GetComponent<EffectViewComponent>().Effects)
            {
                if (aEffectHandler.EffectConfig.Id >= 80000001 && aEffectHandler.EffectConfig.Id <= 80000006)
                {
                    ParticleSystem particleSystem = aEffectHandler.EffectObj.GetComponentInChildren<ParticleSystem>();
                    if (particleSystem != null)
                    {
                        Material material = particleSystem.GetComponent<Renderer>().material;
                        if (material.HasProperty("_TintColor"))
                        {
                            Color oldColor = material.GetColor("_TintColor");
                            oldColor.a = 0.5f;
                            material.SetColor("_TintColor", oldColor);
                        }
                    }
                }
            }
            // 血条恢复
            Image[] hpImages = unit.GetComponent<UIUnitHpComponent>().GameObject.GetComponentsInChildren<Image>();
            foreach (Image image in hpImages)
            {
                Color oldColor = image.color;
                image.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
            }

            //TextMeshProUGUI[] hpTextMeshPros = unit.GetComponent<UIUnitHpComponent>().GameObject.GetComponentsInChildren<TextMeshProUGUI>();
            //foreach (TextMeshProUGUI textMeshPro in hpTextMeshPros)
            //{
            //    Color oldColor = textMeshPro.color;
            //    textMeshPro.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
            //}

            // 名称恢复
            Image[] nameImages = unit.GetComponent<UIUnitHpComponent>().UIPlayerHpText.GetComponentsInChildren<Image>();
            foreach (Image image in nameImages)
            {
                Color oldColor = image.color;
                image.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
            }

            //TextMeshProUGUI[] nameTextMeshPros =
            //        unit.GetComponent<UIUnitHpComponent>().UIPlayerHpText.GetComponentsInChildren<TextMeshProUGUI>();
            //foreach (TextMeshProUGUI textMeshPro in nameTextMeshPros)
            //{
            //    Color oldColor = textMeshPro.color;
            //    textMeshPro.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
            //}
        }

        /// <summary>
        /// 进入隐身
        /// </summary>
        /// <param name="self"></param>
        public static void EnterStealth(this GameObjectComponent self)
        {
            Unit unit = self.GetParent<Unit>();

            Log.ILog.Debug($"EnterStealth: {unit.Id}");

            float alpha = 1f;
            // 对自己半透明
            if (unit.Id == UnitHelper.GetMyUnitId(unit.ZoneScene()))
            {
                alpha = 0.3f;
            }
            // 对别人透明
            else
            {
                alpha = 0f;
            }

             // 身体隐形
            self.Material.shader = GlobalHelp.Find(StringBuilderHelper.SimpleAlpha);
            self.Material.SetFloat("_Alpha", alpha);

            GameObject Wuqi001 = null;
            if (self.GameObject.GetComponent<ReferenceCollector>() != null)
            {
                Wuqi001 = self.GameObject.Get<GameObject>("Wuqi001");
            }
            if (Wuqi001 != null)
            {
                // 武器隐形
                MeshRenderer[] meshRenderers = Wuqi001.GetComponentsInChildren<MeshRenderer>();

                foreach (MeshRenderer meshRenderer in meshRenderers)
                {
                    meshRenderer.material.shader = GlobalHelp.Find(StringBuilderHelper.SimpleAlpha);
                    meshRenderer.material.SetFloat("_Alpha", alpha);
                }
            }
            
            // 脚底阴影隐形
            if (self.GameObject.transform.Find("fake shadow (5)") != null)
            {
                GameObject di = self.GameObject.transform.Find("fake shadow (5)").gameObject;
                Color oldColorDi = di.GetComponent<MeshRenderer>().material.color;
                di.GetComponent<MeshRenderer>().material.color = new Color(oldColorDi.r, oldColorDi.g, oldColorDi.b, alpha);
            }
           
            // 脚底Buff隐形
            foreach (AEffectHandler aEffectHandler in unit.GetComponent<EffectViewComponent>().Effects)
            {
                if (aEffectHandler.EffectConfig.Id >= 80000001 && aEffectHandler.EffectConfig.Id <= 80000006)
                {
                    ParticleSystem particleSystem = aEffectHandler.EffectObj.GetComponentInChildren<ParticleSystem>();
                    if (particleSystem != null)
                    {
                        Material material = particleSystem.GetComponent<Renderer>().material;
                        if (material.HasProperty("_TintColor"))
                        {
                            Color oldColor = material.GetColor("_TintColor");
                            oldColor.a = alpha;
                            material.SetColor("_TintColor", oldColor);
                        }
                       
                    }
                }
            }

            // 血条隐形
            Image[] hpImages = unit.GetComponent<UIUnitHpComponent>().GameObject.GetComponentsInChildren<Image>();
            foreach (Image image in hpImages)
            {
                Color oldColor = image.color;
                image.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
            }

            //TextMeshProUGUI[] hpTextMeshPros = unit.GetComponent<UIUnitHpComponent>().GameObject.GetComponentsInChildren<TextMeshProUGUI>();
            //foreach (TextMeshProUGUI textMeshPro in hpTextMeshPros)
            //{
            //    Color oldColor = textMeshPro.color;
            //    textMeshPro.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
            //}

            // 名称隐形
            Image[] nameImages = unit.GetComponent<UIUnitHpComponent>().UIPlayerHpText.GetComponentsInChildren<Image>();
            foreach (Image image in nameImages)
            {
                Color oldColor = image.color;
                image.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
            }

            //TextMeshProUGUI[] nameTextMeshPros =
            //        unit.GetComponent<UIUnitHpComponent>().UIPlayerHpText.GetComponentsInChildren<TextMeshProUGUI>();
            //foreach (TextMeshProUGUI textMeshPro in nameTextMeshPros)
            //{
            //    Color oldColor = textMeshPro.color;
            //    textMeshPro.color = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
            //}

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

        public static void OnRunRaceMonster(this GameObjectComponent self, int monsterId, bool remove)
        {
            self.RecoverGameObject();
            self.Material = null;
            Unit unit = self.GetParent<Unit>();
            if (remove)
            {
                unit.RemoveComponent<ChangeEquipComponent>();
                unit.RemoveComponent<HeroTransformComponent>();              //获取角色绑点组件
                unit.RemoveComponent<AnimatorComponent>();
                unit.RemoveComponent<FsmComponent>();                         //当前状态组建
                unit.RemoveComponent<EffectViewComponent>();               //添加特效组建
                unit.RemoveComponent<SkillYujingComponent>();
                unit.RemoveComponent<UIUnitHpComponent>();
            }

            if (monsterId > 0)
            {
                MonsterConfig runmonsterCof = MonsterConfigCategory.Instance.Get(monsterId);
                string path = ABPathHelper.GetUnitPath("Monster/" + runmonsterCof.MonsterModelID);
                GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                self.UnitAssetsPath = path;
            }
            else
            {
                string path = ABPathHelper.GetUnitPath($"Player/{OccupationConfigCategory.Instance.Get(self.GetParent<Unit>().ConfigId).ModelAsset}");
                GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                self.UnitAssetsPath = string.Empty;
            }

            if (unit.MainHero && monsterId > 0)
            {
                UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
                uI?.GetComponent<UIMainComponent>()?.UIMainSkillComponent.OnTransform(monsterId);
            }
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