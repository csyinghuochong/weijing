using UnityEngine;


namespace ET
{

    public class AfterSpilingCreate_CreateUnitView : AEventClass<EventType.AfterSpilingCreate>
    {
        protected override void  Run(object numerice)
        {
            RunAsync(numerice as EventType.AfterSpilingCreate).Coroutine();
        }

        private async ETTask RunAsync(EventType.AfterSpilingCreate args)
        {
            Unit unit= args.Unit;
            long instanceid = unit.InstanceId;
            int monsterId = unit.GetComponent<UnitInfoComponent>().UnitCondigID;
            MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(monsterId);
            var path = ABPathHelper.GetUnitPath("Monster/" + monsterCof.MonsterModelID);
            GameObject prefab =await  ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != unit.InstanceId)
            {
                return;
            }
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            go.transform.localPosition = unit.Position;
            go.transform.name = unit.Id.ToString();
            
            if (monsterCof.AI != 0)
            {
                unit.AddComponent<EffectViewComponent>(true);            //添加特效组建
                unit.AddComponent<GameObjectComponent>(true).GameObject = go;
                unit.AddComponent<AnimatorComponent>(true);
                unit.AddComponent<FsmComponent>(true);                 //当前状态组建
                unit.AddComponent<SkillYujingComponent>(true);
            }
            else
            {
                unit.AddComponent<GameObjectComponent>().GameObject = go;
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
                EventType.UnitDead.Instance.Unit = unit;
                Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
            }
        }
    }
}