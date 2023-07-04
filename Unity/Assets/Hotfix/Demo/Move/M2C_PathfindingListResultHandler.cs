using UnityEngine;

namespace ET
{
    [MessageHandler]
    public class M2C_PathfindingListResultHandler : AMHandler<M2C_PathfindingListResult>
    {
        protected override void Run(Session session, M2C_PathfindingListResult messagelist)
        {
            UnitComponent unitComponent = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>();

            for(int p = 0; p < messagelist.PathList.Count; p++)
            {
                M2C_PathfindingResult message = messagelist.PathList[p];
                Unit unit = unitComponent.Get(message.Id);
                if (unit == null)
                {
                    return;
                }

                float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
                using (ListComponent<Vector3> list = ListComponent<Vector3>.Create())
                {
                    list.Add( unit.Position );
                    for (int i = 0; i < message.Xs.Count; ++i)
                    {
                        list.Add(new Vector3(message.Xs[i], message.Ys[i], message.Zs[i]));
                    }

                    unit.GetComponent<MoveComponent>().MoveToAsync(list, speed).Coroutine();
                }
            }

        }
    }
}