using UnityEngine;
using System;

namespace ET
{
    [Event]
    public class UnitDead_OnUnitDead : AEventClass<EventType.UnitDead>
    {
        protected override void Run(object cls)
        {
            EventType.UnitDead args = cls as EventType.UnitDead;
            OnRobotDead(args).Coroutine();
        }

		public async ETTask OnRobotDead(EventType.UnitDead args)
		{
			Unit unit = args.Unit;
			long InstanceId = unit.InstanceId;
			if (unit.MainHero && unit.IsRobot())
			{
				Scene zoneScene = unit.ZoneScene();
				MapComponent mapComponent = zoneScene.GetComponent<MapComponent>();
				zoneScene.GetComponent<BehaviourComponent>().Stop();
				switch (mapComponent.SceneTypeEnum)
				{
					case SceneTypeEnum.Battle:
						await TimerComponent.Instance.WaitAsync(10000);
						if (InstanceId != unit.InstanceId)
						{
							Log.Debug("InstanceId != unit.InstanceId");
							return;
						}
						C2M_TeamDungeonRBornRequest request = new C2M_TeamDungeonRBornRequest() { };
						zoneScene.GetComponent<SessionComponent>().Session.Send(request);
						zoneScene.GetComponent<BehaviourComponent>().Start();
						zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_Target);
						break;
					case SceneTypeEnum.TeamDungeon:
					case SceneTypeEnum.BaoZang:
					case SceneTypeEnum.MiJing:
						await TimerComponent.Instance.WaitAsync(20000);
						if (InstanceId != unit.InstanceId)
						{
							Log.Debug("InstanceId != unit.InstanceId");
							return;
						}
						request = new C2M_TeamDungeonRBornRequest() { };
						zoneScene.GetComponent<SessionComponent>().Session.Send(request);
						zoneScene.GetComponent<BehaviourComponent>().Start();
						zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_Target);
						break;
					case SceneTypeEnum.Arena:
						await TimerComponent.Instance.WaitAsync(20000);
						zoneScene.GetComponent<SessionComponent>().Session.Dispose();
						RobotManagerComponent robotManager = zoneScene.GetParent<RobotManagerComponent>();
						robotManager.RemoveRobot(zoneScene, "角斗场死亡").Coroutine();
						break;
					default:
						EnterFubenHelp.RequestQuitFuben(unit.ZoneScene());
						await TimerComponent.Instance.WaitAsync(1000);
						zoneScene.GetComponent<BehaviourComponent>().Start();
						zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_Stroll);
						break;
				}
			}
		}
	}
}
