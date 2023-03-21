using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace ET
{
	namespace EventType
	{
		//NumericChangeEvent_NotifyWatcher
		public class NumericChangeEvent : DisposeObject
		{
			public static readonly NumericChangeEvent Instance = new NumericChangeEvent();

			public Unit Parent;
			public Unit Attack;
			public int NumericType;
			public long OldValue;
			public long NewValue;
			public int SkillId;
			public int DamgeType;           //1 暴击   2闪避
		}
	}
	
	[ObjectSystem]
	public class NumericComponentAwakeSystem : AwakeSystem<NumericComponent>
	{
		public override void Awake(NumericComponent self)
		{
			self.Awake();
		}
	}

	public class NumericComponent: Entity, IAwake, ITransfer, IUnitCache
	{
		[BsonDictionaryOptions(DictionaryRepresentation.ArrayOfArrays)]
		public Dictionary<int, long> NumericDic = new Dictionary<int, long>();

		//重置所有属性
		public void ResetProperty()
		{
			long max = (int)NumericType.Max;
			foreach (int key in this.NumericDic.Keys)
			{

				//这个范围内的属性为特殊属性不进行重置
				if (key >= NumericType.Now_Hp && key < max)
				{
					continue;
				}

				//buff属性不进行重置
				int yushu = key % 100;
				if (yushu == 11 || yushu == 12)
				{
					continue;
				}

				this.NumericDic[key] = 0;
			}
		}

		public void Awake()
		{
			// 这里初始化base值
			this.NumericDic[NumericType.Now_Dead] = 0;
			this.NumericDic[NumericType.Ling_DiLv] = 1;
		}

		public float GetAsFloat(int numericType)
		{
			return (float)GetByKey(numericType) / 10000;
		}

		public int GetAsInt(int numericType)
		{
			return (int)GetByKey(numericType);
		}
		
		public long GetAsLong(int numericType)
		{
			return GetByKey(numericType);
		}

		public void Set(int nt, double value, bool notice = true)
		{
			this[nt, notice] = (int)(value * 10000);
		}

		public void Set(int nt, float value, bool notice = true)
		{
			this[nt, notice] = (int) (value * 10000);
		}

		public void Set(int nt, int value, bool notice = true)
		{
			this[nt, notice] = value;
		}
		
		public void Set(int nt, long value, bool notice = true)
		{
			this[nt, notice] = value;
		}

		public long this[int numericType, bool notice = true]
		{
			get
			{
				return this.GetByKey(numericType);
			}
			set
			{

				long v = this.GetByKey(numericType);
				if (v == value)
				{
					return;
				}

				NumericDic[numericType] = value;

				Update(numericType, notice);
			}
		}

		private long GetByKey(int key)
		{
			long value = 0;
			this.NumericDic.TryGetValue(key, out value);
			return value;
		}

		public void Update(int numericType, bool notice = true)
		{
			if (numericType < (int)NumericType.Max)
			{
				return;
			}

			int nowValue = (int)numericType / 100;

			int add = nowValue * 100 + 1;
			int mul = nowValue * 100 + 2;
			int finalAdd = nowValue * 100 + 3;
			int buffAdd = nowValue * 100 + 11;
			int buffMul = nowValue * 100 + 12;
			long old = this.GetByKey(nowValue);
			long nowPropertyValue = (long)
				(
				(GetByKey(add) * (1 + GetAsFloat(mul)) + GetByKey(finalAdd)) * (1 + GetAsFloat(buffMul)) 
				
				+ GetByKey(buffAdd)
				);
			this.NumericDic[nowValue] = nowPropertyValue;

			if (notice && old != nowPropertyValue)
			{
				//发送改变属性的相关消息
				EventType.NumericChangeEvent args = EventType.NumericChangeEvent.Instance;
				args.Parent = this.Parent as Unit;
				args.NumericType = nowValue;
				args.OldValue = old;
				args.NewValue = nowPropertyValue;
				Game.EventSystem.PublishClass(args);
			}
		}


		public long ReturnGetFightNumLong(int numericType, bool notice = true)
		{
			if (numericType < (int)NumericType.Max)
			{
				numericType = numericType * 100 ;
			}

			int nowValue = (int)numericType / 100;
			int add = nowValue * 100 + 1;
			int mul = nowValue * 100 + 2;
			int finalAdd = nowValue * 100 + 3;

			long nowPropertyValue = (long)((GetByKey(add) * (1 + GetAsFloat(mul)) + GetByKey(finalAdd)));

			return nowPropertyValue;
		}

		public float ReturnGetFightNumfloat(int numericType, bool notice = true)
		{
			if (numericType < (int)NumericType.Max)
			{
				numericType = numericType * 100;
			}

			int nowValue = (int)numericType / 100;
			int add = nowValue * 100 + 1;
			int mul = nowValue * 100 + 2;
			int finalAdd = nowValue * 100 + 3;

			long nowPropertyValue = (long)((GetByKey(add) * (1 + GetAsFloat(mul)) + GetByKey(finalAdd)));
			//return GetAsFloat((int)nowPropertyValue);
			return (float)nowPropertyValue / 10000f;
		}


		public void ApplyValue(int numericType, long value, bool notice = true, bool check = false)
		{
			long old = this.GetByKey(numericType);
			NumericDic[numericType] = value;

			if (check && old == value)
			{
				return;
			}
			if (notice)
			{
				//发送改变属性的相关消息
				EventType.NumericChangeEvent args = EventType.NumericChangeEvent.Instance;
				args.Parent = this.Parent as Unit;
				args.NumericType = numericType;
				args.OldValue = old;
				args.NewValue = this[numericType];
				args.SkillId = 0;
				args.DamgeType = 0;
				Game.EventSystem.PublishClass(args);
			}
		}

		//传入改变值,设置当前的属性值, 不走公式，一定会广播给客户端
		public void ApplyChange(Unit attack, int numericType, long changedValue, int skillID, bool notice = true, int DamgeType = 0)
		{
			//是否超过指定上限值
			if (numericType == (int)NumericType.Now_Hp)
			{
				long nowCostHp = GetAsLong((int)NumericType.Now_MaxHp) - GetAsLong((int)NumericType.Now_Hp);
				if (changedValue >= nowCostHp)
				{
					changedValue = nowCostHp;
				}
			}
			long old = this.GetByKey((int)numericType);
			long newvalue = GetAsLong(numericType) + changedValue;
			NumericDic[(int)numericType] = newvalue;

			if (notice)
			{
				//发送改变属性的相关消息
				EventType.NumericChangeEvent args = EventType.NumericChangeEvent.Instance;
				args.Parent = this.Parent as Unit;
				args.Attack = attack;
				args.NumericType = numericType;
				args.OldValue = old;
				args.NewValue = this[numericType];
				args.SkillId = skillID;
				args.DamgeType = DamgeType;
				Game.EventSystem.PublishClass(args);
			}
		}
	}
}