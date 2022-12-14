using UnityEngine;

namespace ET
{
	[MessageHandler]
	public class M2C_StopHandler : AMHandler<M2C_Stop>
	{
		protected override void Run(Session session, M2C_Stop message)
		{
			Unit unit = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(message.Id);
			if (unit == null)
			{
				return;
			}
			//if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
			//{
			//	return;
			//}
			Vector3 pos = new Vector3(message.X, message.Y, message.Z);
			//立即停止
			if (message.Error == -1)
			{
				MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
				moveComponent.Stop();
				return;
			}

			if (Vector3.Distance(unit.Position, pos) < 0.2f)
			{
				Quaternion rotation = new Quaternion(message.A, message.B, message.C, message.W);
				MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
				moveComponent.Stop();
				unit.Position = pos;
				unit.Rotation = rotation;
				EventType.MoveStop.Instance.Unit = unit;
				Game.EventSystem.PublishClass(EventType.MoveStop.Instance);
			}
			else
			{
				//Log.Debug($"FsmStateEnum.M2C_Stop > 0.2f");
				float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
				var list = ListComponent<Vector3>.Create();
				list.Add(unit.Position + (pos - unit.Position) * 0.5f);
				list.Add(pos);
				unit.GetComponent<MoveComponent>().MoveToAsync(list, speed * 1.5f).Coroutine();
			}

			unit.GetComponent<ObjectWait>()?.Notify(new WaitType.Wait_UnitStop() { Error = message.Error });
		}
	}
}
