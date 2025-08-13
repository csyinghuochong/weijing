using UnityEngine;

namespace ET
{
    [MessageHandler]
    public class M2C_PathfindingResultHandler : AMHandler<M2C_PathfindingResult>
    {
        protected override void Run(Session session, M2C_PathfindingResult message)
        {
            Unit unit = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(message.Id);
            if (unit == null)
            {
                return;
            }

            //MapHelper.LogMoveInfo($"移动寻路返回 {TimeHelper.ServerNow()}");
            if ( !message.YaoGan)
			{
                return;
            }
            if (unit.MainHero)
            {
                MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
                moveComponent.C2SDistance = Vector3.Distance(new Vector3(message.X, message.Y, message.Z), unit.Position);
                moveComponent.LastRecvTime = TimeHelper.ClientNow();
            }
            else
            {
                float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
                using (ListComponent<Vector3> list = ListComponent<Vector3>.Create())
                {
                    for (int i = 0; i < message.Xs.Count; ++i)
                    {
                        list.Add(new Vector3(message.Xs[i], message.Ys[i], message.Zs[i]));
                    }
                    //PathPosition pathPosition =   unit.GetPositionRelativeToPath( list);
                    //Log.ILog.Debug($"pathPosition:  {pathPosition}   unit.Position:  {unit.Position}");
                    unit.GetComponent<MoveComponent>().MoveToAsync(list, speed).Coroutine();
                }
            }
        }
    }
}
