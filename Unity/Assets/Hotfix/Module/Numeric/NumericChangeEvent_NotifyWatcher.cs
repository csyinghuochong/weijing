namespace ET
{
	// 分发数值监听NumericComponent
	public class NumericChangeEvent_NotifyWatcher: AEventClass<EventType.NumericChangeEvent>
	{
		protected override  void Run(object number)
		{
			EventType.NumericChangeEvent args = number as EventType.NumericChangeEvent;
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
