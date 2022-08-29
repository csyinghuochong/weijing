using UnityEngine;

namespace ET
{

    [Event]
    public class AfterDropCreate_CreateDrop : AEventClass<EventType.AfterDropCreate>
    {
        protected override  void Run(object cls)
        {
            RunAsync(cls as EventType.AfterDropCreate).Coroutine();
        }

        private  async ETTask RunAsync(EventType.AfterDropCreate args)
        {
            Unit unit = args.Unit;
            var path = ABPathHelper.GetUnitPath("Player/DropItem");
            GameObject prefab = await  ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
            go.name = unit.Id.ToString();

            DropComponent dropComponent = unit.GetComponent<DropComponent>();
            unit.AddComponent<EffectViewComponent>();
            unit.AddComponent<GameObjectComponent>().GameObject = go;
            unit.UpdateUIType = HeadBarType.DropUI;
            unit.AddComponent<DropUIComponent>().InitData(dropComponent.DropInfo).Coroutine();
        }
    }
}
