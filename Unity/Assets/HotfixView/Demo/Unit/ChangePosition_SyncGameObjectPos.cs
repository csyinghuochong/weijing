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
                unit.GetComponent<GameObjectComponent>()?.UpdatePositon(unit.Position);
                unit.GetComponent<EffectViewComponent>()?.UpdatePositon();

                //主角
                if (unit.MainHero)
                {
                    EventType.DataUpdate.Instance.DataType = DataType.MainHeroMove;
                    EventSystem.Instance.PublishClass(EventType.DataUpdate.Instance);

                    UICommonHelper.UpdateTalkBar(unit);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
        }
    }
}