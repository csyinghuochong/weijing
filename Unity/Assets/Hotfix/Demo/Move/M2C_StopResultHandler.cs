using UnityEngine;

namespace ET
{
    [MessageHandler]
    public class M2C_StopResultHandler : AMHandler<M2C_StopResult>
    {
        protected override async void Run(Session session, M2C_StopResult message)
        {
            Unit unit = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(message.Id);
            if (unit == null)
            {
                return;
            }

            if (!unit.MainHero)
            {
                Vector3 target = new Vector3 (message.X, message.Y, message.Z);
                if (Vector3.Distance(unit.Position, target) < 0.3f)
                {
                    MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
                    moveComponent.Stop();
                    unit.Position = target;

                    EventType.MoveStop.Instance.Unit = unit;
                    Game.EventSystem.PublishClass(EventType.MoveStop.Instance);
                }
                else
                {
                    float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
                    using var list = ListComponent<Vector3>.Create();
                    list.Add(unit.Position + (target - unit.Position) * 0.5f);
                    list.Add(target);
                    unit.GetComponent<MoveComponent>().MoveToAsync(list, speed * 1.5f).Coroutine();
                }
            }
            await ETTask.CompletedTask;
        }
    }
}
