using UnityEngine;
using System;

namespace ET
{
    public class AfterUnitCreate_CreateUnitView : AEventClass<EventType.AfterUnitCreate>
    {
        protected override  void Run(object cls)
        {
            RunAsync(cls as EventType.AfterUnitCreate).Coroutine();
        }

        private  async ETTask RunAsync(EventType.AfterUnitCreate args)
        {
            Unit unit = args.Unit;
            MapComponent mapComponent = unit.ZoneScene().GetComponent<MapComponent>();
            if (unit.MainHero && mapComponent.SceneTypeEnum == (int)SceneTypeEnum.PetDungeon)
            {
                return;
            }

            long instanceid = unit.InstanceId;
            int configId = unit.GetComponent<UnitInfoComponent>().UnitCondigID;
            var path = ABPathHelper.GetUnitPath($"Player/{OccupationConfigCategory.Instance.Get(configId).ModelAsset}");
            GameObject go = await GameObjectPool.Instance.GetExternal(path);
            //await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != unit.InstanceId)
            {
                go.SetActive(false);
                GameObjectPool.Instance.InternalPut(path, go);
                return;
            }
            //GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            go.SetActive(true);
            UICommonHelper.SetParent(go, GlobalComponent.Instance.Unit.gameObject);
            LayerHelp.ChangeLayer(go.transform, LayerEnum.Player);
            if (go.GetComponent<Collider>() == null)
            {
                BoxCollider box = go.AddComponent<BoxCollider>();
                box.size = new Vector3(1f, 2f, 1f);
                box.center = new Vector3(0f, 1f, 0f);
            }
            go.transform.localPosition = unit.Position;
            go.transform.name = unit.Id.ToString();
            unit.AddComponent<EffectViewComponent>();               //添加特效组建
            unit.AddComponent<GameObjectComponent>().GameObject = go;
            unit.GetComponent<GameObjectComponent>().AssetsPath = path;
            unit.AddComponent<HeroTransformComponent>();              //获取角色绑点组件
            unit.AddComponent<ChangeEquipComponent>().InitWeapon(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Weapon));
            unit.AddComponent<AnimatorComponent>();
            unit.AddComponent<FsmComponent>();                         //当前状态组建
            unit.UpdateUIType = HeadBarType.HeroHeadBar;
            unit.AddComponent<HeroHeadBarComponent>();                 //血条UI组件                 //刷新显示

            if (unit.GetComponent<UnitInfoComponent>().Type == UnitType.Player)
            {
                int stall = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Stall);
                unit.GetComponent<GameObjectComponent>().OnUnitStallUpdate(stall).Coroutine();
            }
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
            {
                EventType.UnitDead.Instance.Unit = unit;
                Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
            }

            if (unit.MainHero)
            {
                OnMainHero(unit, go.transform, mapComponent.SceneTypeEnum);
            }
        }

        private void OnMainHero(Unit unit, Transform mainTf, int sceneTypeEnum)
        {
            Transform targetTf = unit.GetComponent<HeroTransformComponent>().GetTranform(PosType.Head).transform;
            Camera camera = UIComponent.Instance.MainCamera;
            camera.GetComponent<MyCamera_1>().enabled = sceneTypeEnum == SceneTypeEnum.MainCityScene;
            camera.GetComponent<MyCamera_1>().Target = targetTf;

            GameObject shiBingSet = GameObject.Find("ShiBingSet");
            if (shiBingSet != null)
            {
                string path_2 = ABPathHelper.GetUGUIPath($"Battle/UINpcLocal");
                GameObject npc_go =  ResourcesComponent.Instance.LoadAsset<GameObject>(path_2);
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
    }
}