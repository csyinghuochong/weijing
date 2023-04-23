using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

	/// <summary>
	/// 技能事件类型
	/// </summary>
	public enum ESkillEventType : byte
	{
		/// <summary>
		/// 范围伤害
		/// </summary>
		RangeDamage = 1,
		/// <summary>
		/// 子弹
		/// </summary>
		Bullet = 2,
		/// <summary>
		/// 添加buff
		/// </summary>
		AddBuff = 3,
		/// <summary>
		/// 移除buff
		/// </summary>
		RemoveBuff = 4,
	}

	public class SkillEvent : Entity, IAwake<SkillConfig>, IDestroy
    {

        public Unit Unit => this.GetParent<SkillTimelineComponent>().Unit;

		public ESkillEventType SkillEventType;

		public long EventTriggerTime;
	}
}
