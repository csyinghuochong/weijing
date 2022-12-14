using System;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.FloatTipTimer)]
	public class FloatTipTimer : ATimer<FloatTipManager>
	{
		public override void Run(FloatTipManager self)
		{
			try
			{
				self.OnUpdate();
			}
			catch (Exception e)
			{
				Log.Error($"move timer error: {self.Id}\n{e}");
			}
		}
	}

	[ObjectSystem]
	public class FloatTipManagerAwakeSystem : AwakeSystem<FloatTipManager>
	{
		public override void Awake(FloatTipManager self)
		{
			FloatTipManager.Instance = self;
			self.Awake(); 
		}
	}

	[ObjectSystem]
	public class FloatTipManagerDestroySystem : DestroySystem<FloatTipManager>
	{
		public override void Destroy(FloatTipManager self)
		{
			FloatTipManager.Instance = null;
			TimerComponent.Instance?.Remove(ref self.Timer);
		}
	}

	public static class FloatTipManagerSystem
	{
		public static void Awake(this FloatTipManager self)
		{
			self.FloatTipList.Clear();
			self.WaitFloatTip.Clear();
		}

		public static void OnUpdate(this FloatTipManager self)
		{
			if (self.WaitFloatTip.Count > 0)
			{
				self.PassTime += Time.deltaTime;
				if (self.PassTime >= self.IntervalTime)
				{
					FloatTipType floatTipType = self.WaitFloatTip[0];
					self.CreateFloatTip(floatTipType);
					self.WaitFloatTip.RemoveAt(0);
					self.PassTime = 0;
				}
			}

			for (int i = self.FloatTipList.Count - 1; i >= 0; i--)
			{
				bool value = self.FloatTipList[i].OnUpdate();
				if (value)
				{
					self.FloatTipList[i].Dispose();
					self.FloatTipList.RemoveAt(i);
				}
			}
			if (self.FloatTipList.Count == 0 &&  self.WaitFloatTip.Count == 0)
			{
				TimerComponent.Instance?.Remove(ref self.Timer);
			}
		}

		public static  void CreateFloatTip(this FloatTipManager self, FloatTipType tip)
		{
			FloatTipComponent uiitem = self.AddChild<FloatTipComponent>(true);
			uiitem.OnInitData(tip);
			self.FloatTipList.Add(uiitem);
		}
		
		//不带底图的Tips
		public static void ShowFloatTip(this FloatTipManager self, string tip)
		{
			self.WaitFloatTip.Add(new FloatTipType() {  type = 0, tip = tip });
			if (self.Timer == 0)
			{
				self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.FloatTipTimer, self);
			}
		}

		//带底图的Tips
		public static void ShowFloatTipDi(this FloatTipManager self, string tip)
		{
			self.WaitFloatTip.Add(new FloatTipType() { type = 1, tip = tip });
			if (self.Timer == 0)
			{
				self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.FloatTipTimer, self);
			}
		}

	}
}
