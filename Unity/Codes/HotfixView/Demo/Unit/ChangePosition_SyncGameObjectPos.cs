using System;
using UnityEngine;

namespace ET
{
    public class ChangePosition_SyncGameObjectPos: AEventClass<EventType.ChangePosition>
    {
        protected override void Run(object changePosition)
        {
            try
            {
                EventType.ChangePosition args = changePosition as EventType.ChangePosition;
                Unit unit = args.Unit;
                GameObjectComponent gameObjectComponent = unit.GetComponent<GameObjectComponent>();
                if (gameObjectComponent == null)
                {
                    return;
                }
                gameObjectComponent.GameObject.transform.position = unit.Position;
                unit.GetComponent<EffectViewComponent>().UpdatePositon();

                ////主角
                if (unit.MainHero)
                {
                    UICommonHelper.UpdateAllNpcBar(unit);
                    UI uI = UIHelper.GetUI(unit.ZoneScene(), UIType.UIMapBig);
                    uI?.GetComponent<UIMapBigComponent>().OnChangePosition(unit.Position);
                    unit.ZoneScene().CurrentScene()?.GetComponent<LockTargetComponent>()?.OnUpdate();

                    MapComponent mapComponent = unit.ZoneScene().GetComponent<MapComponent>();
                    if (mapComponent.SceneTypeEnum == SceneTypeEnum.MainCityScene)
                    {
                        Camera camera = UIComponent.Instance.MainCamera;
                        camera.GetComponent<MyCamera_1>().OnUpdate();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
        }
    }
}