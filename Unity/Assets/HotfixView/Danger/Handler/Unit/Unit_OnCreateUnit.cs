using UnityEngine;

namespace ET
{
    [Event]
    public class Unit_OnCreateUnit : AEventClass<EventType.AfterUnitCreate>
    {
        protected override void Run(object cls)
        {
            EventType.AfterUnitCreate args = cls as EventType.AfterUnitCreate;
            if (args.Unit.IsDisposed)
            {
                Log.ILog.Debug("args.Unit.IsDisposed: " + args.Unit.Id);
                return;
            }
            
            args.Unit.AddComponent<GameObjectComponent>();
            //如果死亡的是怪物,判断当前是否在挂机
            MapComponent mapComponent = args.Unit.ZoneScene().GetComponent<MapComponent>(); 
            if (args.Unit.Type == UnitType.Monster && mapComponent.SceneTypeEnum == SceneTypeEnum.LocalDungeon)
            {
                args.Unit.ZoneScene().GetComponent<UnitGuaJiComponen>()?.OnCreateUnit(args.Unit);
            }
        }
    }
}
