using System;
using UnityEngine;

namespace ET
{

    [ObjectSystem]
    public class GameObjectAwakeSystem : AwakeSystem<GameObjectComponent>
    {
        public override void Awake(GameObjectComponent self)
        {
            self.GameObject = null;
            self.Material = null;
            self.UnitAssetsPath = "";

            self.LoadGameObject();
        }
    }

    [ObjectSystem]
    public class GameObjectDestroySystem : DestroySystem<GameObjectComponent>
    {
        public override void Destroy(GameObjectComponent self)
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
            self.RecoverHorse();
            GameObjectPoolComponent.Instance.RecoverGameObject(ABPathHelper.GetUnitPath("Player/BaiTan"), self.BaiTan);
            self.BaiTan = null;
        }
    }


    public static class GameObjectComponentSystem
    {

        public static void LoadGameObject(this GameObjectComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
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
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    break;
                case UnitType.Monster:
                    int monsterId = unit.ConfigId;
                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(monsterId);
                    int userMaterModel = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UseMasterModel);
                    long masterId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
                    Unit master = unit.GetParent<UnitComponent>().Get(masterId);

                    if (userMaterModel == 1 && master != null
                        && master.GetComponent<GameObjectComponent>()!= null
                        && master.GetComponent<GameObjectComponent>().GameObject != null)
                    {
                        GameObject gameObject = GameObject.Instantiate(master.GetComponent<GameObjectComponent>().GameObject);
                        self.OnLoadGameObject(gameObject, self.InstanceId);
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
            }
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
            self.ObjectHorse = go;
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int horseId = numericComponent.GetAsInt(NumericType.Now_Horse);
            if (horseId == 0)
            {
                self.RecoverHorse();
                unit.GetComponent<AnimatorComponent>().UpdateAnimator(self.GameObject);
                unit.GetComponent<FsmComponent>().SetIdleState();
                self.ShowRoleDi(true);
            }
            else
            {
                UICommonHelper.SetParent(go, GlobalComponent.Instance.Unit.gameObject);
                go.SetActive(true);
                go.transform.localPosition = unit.Position;
                go.transform.rotation = unit.Rotation;
                UICommonHelper.SetParent(self.GameObject, HoreseHelper.GetHorseNode(self.ObjectHorse));
                self.GameObject.transform.localScale = HoreseHelper.GetRoleScale(go, horseId) * Vector3.one;
                unit.GetComponent<FsmComponent>().SetHorseState();
                unit.GetComponent<AnimatorComponent>().UpdateAnimator(go);
                self.ShowRoleDi(false);
            }
            self.GetParent<Unit>().GetComponent<HeroHeadBarComponent>().OnUpdateHorse(horseId);
        }

        public static void ShowRoleDi(this GameObjectComponent self, bool show)
        {
            GameObject di = self.GameObject.transform.Find("fake shadow (5)").gameObject;
            di.SetActive(show);
        }

        public static void OnUpdateHorse(this GameObjectComponent self)
        {
            self.RecoverHorse();
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int horseId = numericComponent.GetAsInt(NumericType.Now_Horse);
            if (horseId != 0)
            {
                ZuoQiShowConfig zuoQiShowConfig = ZuoQiShowConfigCategory.Instance.Get(horseId);
                self.HorseAssetsPath = ABPathHelper.GetUnitPath($"ZuoQi/{zuoQiShowConfig.ModelID}");
                GameObjectPoolComponent.Instance.AddLoadQueue(self.HorseAssetsPath, self.InstanceId, self.OnLoadHorse);
                self.ShowRoleDi(false);
            }
            else
            {
                UICommonHelper.SetParent(self.GameObject, GlobalComponent.Instance.Unit.gameObject);
                self.UpdatePositon(self.GetParent<Unit>().Position);
                unit.GetComponent<AnimatorComponent>().UpdateAnimator(self.GameObject);
                self.ShowRoleDi(true);

                MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
                bool run = moveComponent!=null && !moveComponent.IsArrived();
                if (run)
                {
                    unit.GetComponent<FsmComponent>().OnEnterFsmRunState();
                }
            }
            self.GetParent<Unit>().GetComponent<HeroHeadBarComponent>().OnUpdateHorse(horseId);
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
            UICommonHelper.SetParent(go, GlobalComponent.Instance.Unit.gameObject);
            go.SetActive(true);
            go.transform.localPosition = unit.Position;
            go.transform.rotation = unit.Rotation;
            self.GameObject = go;

            int unitType = unit.Type;
            switch (unitType)
            {
                case UnitType.Player:
                    MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
                    LayerHelp.ChangeLayer(go.transform, LayerEnum.Player);
                    self.OnAddCollider(go);
                    go.transform.name = unit.Id.ToString();
                    unit.UpdateUIType = HeadBarType.HeroHeadBar;
                    unit.AddComponent<HeroTransformComponent>();              //获取角色绑点组件
                    unit.AddComponent<ChangeEquipComponent>().InitWeapon(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Weapon));
                    unit.AddComponent<AnimatorComponent>();
                    unit.AddComponent<FsmComponent>();                         //当前状态组建
                    unit.AddComponent<HeroHeadBarComponent>();
                    unit.AddComponent<EffectViewComponent>();               //添加特效组建
                    unit.AddComponent<SkillYujingComponent>(true);
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
                        unit.GetComponent<BuffManagerComponent>().InitBuff();
                        unit.GetComponent<SkillManagerComponent>().InitSkill();
                    }
                    if (unit.MainHero)
                    {
                        Transform topTf = unit.GetComponent<HeroTransformComponent>().GetTranform(PosType.Head).transform;
                        NpcLocalHelper.OnMainHero(topTf, go.transform, mapComponent.SceneTypeEnum);
                    }
                    break;
                case UnitType.Monster:
                    go.transform.name = unit.Id.ToString();
                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(unit.ConfigId);
                    if (monsterCof.AI != 0)
                    {
                        LayerHelp.ChangeLayer(go.transform, LayerEnum.Player);
                        self.OnAddCollider(go);
                        unit.AddComponent<EffectViewComponent>(true);            //添加特效组建
                        unit.AddComponent<AnimatorComponent>(true);
                        unit.AddComponent<FsmComponent>(true);                 //当前状态组建
                        unit.AddComponent<SkillYujingComponent>(true);
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
                    if (monsterCof.MonsterSonType == 51)
                    {
                        unit.UpdateUIType = -1;
                    }
                    if (monsterCof.MonsterSonType == 52)
                    {
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<UISceneItemComponent>().InitTableData(unit.GetComponent<UnitInfoComponent>().EnergySkillId).Coroutine();
                    }
                    else if (monsterCof.MonsterSonType == 54)
                    {
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<UISceneItemComponent>().InitSceneData().Coroutine();         //血条UI组件
                    }
                    else if (unit.IsChest())
                    {
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<UISceneItemComponent>().InitSceneData().Coroutine();         //血条UI组件
                        LayerHelp.ChangeLayer(go.transform, LayerEnum.Box);
                    }
                    else if (monsterCof.MonsterType != (int)MonsterTypeEnum.SceneItem )
                    {
                        unit.UpdateUIType = HeadBarType.HeroHeadBar;
                        unit.AddComponent<HeroTransformComponent>();       //获取角色绑点组件
                        unit.AddComponent<HeroHeadBarComponent>();         //血条UI组件
                    }

                    if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
                    {
                        EventType.UnitDead.Instance.Unit = unit;
                        Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
                    }
                    break;
                case UnitType.Pet:
                    unit.UpdateUIType = HeadBarType.HeroHeadBar;
                    go.transform.name = unit.Id.ToString();
                    unit.AddComponent<EffectViewComponent>();            //添加特效组建
                    unit.AddComponent<AnimatorComponent>();
                    unit.AddComponent<HeroTransformComponent>();       //获取角色绑点组件
                    unit.AddComponent<FsmComponent>();                 //当前状态组建
                    unit.AddComponent<HeroHeadBarComponent>();         //血条UI组件
                    break;
                case UnitType.Npc:
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
                    go.name = unit.Id.ToString();
                    unit.UpdateUIType = HeadBarType.DropUI;
                    DropComponent dropComponent = unit.GetComponent<DropComponent>();
                    unit.AddComponent<EffectViewComponent>();
                    unit.AddComponent<DropUIComponent>().InitData(dropComponent.DropInfo);
                    break;
                case UnitType.Chuansong:
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
            }
        }

        public static void OnHui(this GameObjectComponent self)
        {
            //self.Material = self.GameObject.GetComponentInChildren<SkinnedMeshRenderer>().materials[0];
            //self.Material.shader = Shader.Find("Custom/UI_Hui");
            Transform transform = self.GameObject.transform;
            for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.GetChild(i).name == "RoleBoneSet")
                {
                    continue;
                }
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        public static void OnRevive(this GameObjectComponent self)
        {
            //if (self.Material != null)
            //{
            //    self.Material.shader = Shader.Find("Toon/BasicOutline");
            //}
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
            UICommonHelper.SetParent(gameObject, GlobalComponent.Instance.Unit.gameObject);
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