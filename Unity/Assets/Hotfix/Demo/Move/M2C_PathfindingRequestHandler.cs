using UnityEngine;

namespace ET
{
	[MessageHandler]
	public class M2C_PathfindingRequestHandler : AMHandler<M2C_PathfindingRequest>
	{
		protected override void Run(Session session, M2C_PathfindingRequest message)
		{
			Unit unit = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(message.Id);
			if (unit == null)
			{
				return;
			}

			//MapHelper.LogMoveInfo($"移动寻路返回 {TimeHelper.ServerNow()}");
           
            float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
            using (ListComponent<Vector3> pointsList = ListComponent<Vector3>.Create())
			{
				for (int i = 0; i < message.Xs.Count; ++i)
				{
					Vector3 v1 = new Vector3(message.Xs[i], message.Ys[i], message.Zs[i]);
                    pointsList.Add(v1);

					if (i >= message.Xs.Count - 1)
					{
						continue;
					}

                    Vector3 v2 = new Vector3(message.Xs[i + 1], message.Ys[i + 1], message.Zs[i + 1]);
					Vector3 dir = (v2 - v1).normalized;
					float distance = Vector3.Distance(v1, v2);
                    if (distance <= 1.2f || Mathf.Abs(v1.y- v2.y) > 0.2f)
                    {
						//pointsList.Add( (v1 + v2) * 0.5f );
						continue;
                    }

					float index = 0f;
					while (distance > index)
					{
                        index += 1f;
                        if (distance - index < 0.5f)
                        {
                            break;
                        }
                        Vector3 temp = v1 + dir * index;
                        pointsList.Add(temp);
                    }
                }
				unit.SpeedRate = message.SpeedRate;
                unit.GetComponent<MoveComponent>().MoveToAsync(pointsList, speed).Coroutine();
			}
		}
	}
}
