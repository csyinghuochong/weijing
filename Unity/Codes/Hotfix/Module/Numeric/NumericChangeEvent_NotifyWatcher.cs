namespace ET
{
	// 分发数值监听
	public class NumericChangeEvent_NotifyWatcher: AEventClass<EventType.NumbericChange>
	{
		protected override  void Run(object number)
		{
			EventType.NumbericChange args = number as EventType.NumbericChange;
#if SERVER
			if (NumericHelp.BroadcastType.Contains(args.NumericType))
			{
				SendNumbericChange.Broadcast(args);
			}
			else
			{
				SendNumbericChange.SendToClient(args);
			}
#endif
			NumericWatcherComponent.Instance.Run(args);
		}
	}
}
