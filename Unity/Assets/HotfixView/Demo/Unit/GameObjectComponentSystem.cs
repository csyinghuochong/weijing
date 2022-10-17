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
            self.AssetsPath = "";

            self.LoadGameObject();
        }
    }

    [ObjectSystem]
    public class GameObjectDestroySystem : DestroySystem<GameObjectComponent>
    {
        public override void Destroy(GameObjectComponent self)
        {
            if (string.IsNullOrEmpty(self.AssetsPath) && self.GameObject != null)
            {
                UnityEngine.Object.Destroy(self.GameObject);
                self.GameObject = null;
            }
            if (!string.IsNullOrEmpty(self.AssetsPath))
            {
                GameObjectPoolComponent.Instance.RecoverGameObject(self.AssetsPath, self.GameObject);
                self.GameObject = null;
            }
            GameObjectPoolComponent.Instance.RecoverGameObject(ABPathHelper.GetUnitPath("Player/BaiTan"), self.BaiTan);
            self.BaiTan = null;
        }
    }


    public static class GameObjectComponentSystem
    {

        public static void RecoverGameObject(this GameObjectComponent self)
        { 
            
        }

        public static void LoadGameObject(this GameObjectComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            int unitType = unitInfoComponent.Type;
            switch (unitType)
            {
                case UnitType.Player:
                    MapComponent mapComponent = unit.ZoneScene().GetComponent<MapComponent>();
                    //宠物副本不显示玩家
                    if (unit.MainHero &&( mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetDungeon
                        || mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetTianTi))
                    {
                        return;
                    }
                    int occId = unit.GetComponent<UnitInfoComponent>().UnitCondigID;
                    var path = ABPathHelper.GetUnitPath($"Player/{OccupationConfigCategory.Instance.Get(occId).ModelAsset}");
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    break;
                case UnitType.Monster:
                    int monsterId = unit.GetComponent<UnitInfoComponent>().UnitCondigID;
                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(monsterId);
                    int userMaterModel = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UseMasterModel);
                    if (userMaterModel == 1)
                    {
                        long masterId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Master_ID);
                        Unit master = unit.GetParent<UnitComponent>().Get(masterId);
                        GameObject gameObject = GameObject.Instantiate(master.GetComponent<GameObjectComponent>().GameObject);
                        self.OnLoadGameObject(gameObject, self.InstanceId);
                    }
                    else
                    {
                        path = ABPathHelper.GetUnitPath("Monster/" + monsterCof.MonsterModelID);
                        GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                        self.AssetsPath = path;
                    }
                    break;
                case UnitType.Pet:
                    int skinId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.PetSkin);
                    int configId = unit.GetComponent<UnitInfoComponent>().UnitCondigID;
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
                    int npcId = unitInfoComponent.UnitCondigID;
                    NpcConfig config = NpcConfigCategory.Instance.Get(npcId);
                    path = ABPathHelper.GetUnitPath("Npc/" + config.Asset);
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    break;
                case UnitType.DropItem:
                    DropComponent dropComponent = unit.GetComponent<DropComponent>();
                    string assetPath = dropComponent.DropInfo.ItemID == 1 ? "DropICoin" : "DropItem";
                    path = ABPathHelper.GetUnitPath($"Player/{assetPath}");
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    self.AssetsPath = path;
                    break;
                case UnitType.Chuansong:
                    path = ABPathHelper.GetUnitPath("Monster/DorrWay_1");
                    GameObjectPoolComponent.Instance.AddLoadQueue(path, self.InstanceId, self.OnLoadGameObject);
                    break;
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

            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            int unitType = unitInfoComponent.Type;
            switch (unitType)
            {
                case UnitType.Player:
                    MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
                    LayerHelp.ChangeLayer(go.transform, LayerEnum.Player);
                    if (go.GetComponent<Collider>() == null)
                    {
                        BoxCollider box = go.AddComponent<BoxCollider>();
                        box.size = new Vector3(1f, 2f, 1f);
                        box.center = new Vector3(0f, 1f, 0f);
                    }
                    go.transform.name = unit.Id.ToString();
                    unit.UpdateUIType = HeadBarType.HeroHeadBar;
                    unit.AddComponent<HeroTransformComponent>();              //获取角色绑点组件
                    unit.AddComponent<ChangeEquipComponent>().InitWeapon(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Weapon));
                    unit.AddComponent<AnimatorComponent>();
                    unit.AddComponent<FsmComponent>();                         //当前状态组建
                    unit.AddComponent<HeroHeadBarComponent>();
                    unit.AddComponent<EffectViewComponent>();               //添加特效组建
                    //血条UI组件
                    NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                    self.OnUnitStallUpdate(numericComponent.GetAsInt(NumericType.Now_Stall));
                    if (numericComponent.GetAsInt(NumericType.Now_Dead) == 1)
                    {
                        EventType.UnitDead.Instance.Unit = unit;
                        Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
                    }
                    if (unit.MainHero)
                    {
                        Transform topTf = unit.GetComponent<HeroTransformComponent>().GetTranform(PosType.Head).transform;
                        self.OnMainHero(topTf, go.transform, mapComponent.SceneTypeEnum);
                    }
                    break;
                case UnitType.Monster:
                    go.transform.name = unit.Id.ToString();
                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(unitInfoComponent.UnitCondigID);
                    if (monsterCof.AI != 0)
                    {
                        unit.AddComponent<EffectViewComponent>(true);            //添加特效组建
                        unit.AddComponent<AnimatorComponent>(true);
                        unit.AddComponent<FsmComponent>(true);                 //当前状态组建
                        unit.AddComponent<SkillYujingComponent>(true);
                    }
                    //51 场景怪 有AI 不显示名称
                    //52 能量台子 无AI
                    //54 场景怪 有AI 显示名称
                    //55 宝箱类 无AI
                    if (monsterCof.MonsterType != (int)MonsterTypeEnum.SceneItem)
                    {
                        unit.UpdateUIType = HeadBarType.HeroHeadBar;
                        unit.AddComponent<HeroTransformComponent>();       //获取角色绑点组件
                        unit.AddComponent<HeroHeadBarComponent>();         //血条UI组件
                    }
                    if (monsterCof.MonsterType == (int)MonsterTypeEnum.Boss)
                    {
                        unit.AddComponent<MonsterActRangeComponent, int>(monsterCof.Id);         //血条UI组件
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
                    else if (monsterCof.MonsterSonType == 55)
                    {
                        unit.UpdateUIType = HeadBarType.SceneItemUI;
                        unit.AddComponent<UISceneItemComponent>().InitSceneData().Coroutine();         //血条UI组件
                        LayerHelp.ChangeLayer(go.transform, LayerEnum.Box);
                    }
                    if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
                    {
                        Log.ILog.Debug($"monsterConfig.Id1 :   {monsterCof.Id}");
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
                    if (go.GetComponent<Collider>() == null)
                    {
                        BoxCollider box = go.AddComponent<BoxCollider>();
                        box.size = new Vector3(1f, 2f, 1f);
                        box.center = new Vector3(0f, 1f, 0f);
                    }
                    unit.UpdateUIType = HeadBarType.NpcHeadBarUI;
                    go.name = unitInfoComponent.UnitCondigID.ToString();
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
                    unit.AddComponent<TransferUIComponent>().OnInitUI(unitInfoComponent.UnitCondigID).Coroutine();
                    unit.GetComponent<ChuansongComponent>().ChuanSongOpen = true;
                    break;
            }
        }


        public static void OnMainHero(this GameObjectComponent self, Transform topTf, Transform mainTf, int sceneTypeEnum)
        {
            Camera camera = UIComponent.Instance.MainCamera;
            camera.GetComponent<MyCamera_1>().enabled = sceneTypeEnum == SceneTypeEnum.MainCityScene;
            camera.GetComponent<MyCamera_1>().Target = topTf;

            GameObject shiBingSet = GameObject.Find("ShiBingSet");
            if (shiBingSet != null)
            {
                string path_2 = ABPathHelper.GetUGUIPath($"Battle/UINpcLocal");
                GameObject npc_go = ResourcesComponent.Instance.LoadAsset<GameObject>(path_2);
                for (int i = 0; i < shiBingSet.transform.childCount; i++)
                {
                    GameObject shiBingItem = shiBingSet.transform.GetChild(i).gameObject;
                    NpcLocal npcLocal = shiBingItem.GetComponent<NpcLocal>();
                    if (npcLocal == null)
                    {
                        continue;
                    }
                    NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcLocal.NpcId);
                    npcLocal.Target = mainTf;
                    npcLocal.NpcName = npcConfig.Name;
                    npcLocal.NpcSpeak = npcConfig.SpeakText;
                    npcLocal.AssetBundle = npc_go;
                }
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