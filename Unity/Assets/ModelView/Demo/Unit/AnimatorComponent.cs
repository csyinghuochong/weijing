using System.Collections.Generic;
using UnityEngine;

namespace ET
{
	public static class MotionType
	{
		public const string None = "None";
		public const string Idle = "Idle";
		public const string Run = "Run";
		public const string Act_1 = "Act_1";
		public const string Act_2 = "Act_2";
		public const string Act_3 = "Act_3";
		public const string Tiao = "Tiao";
		public const string CriAct = "CriAct";
		public const string Death = "Death";
		public const string Hui = "Hui";
		public const string SelectNpc = "SelectNpc";
	}

	public class AnimatorComponent : Entity, IAwake,  IDestroy
	{
		public Dictionary<string, AnimationClip> animationClips = new Dictionary<string, AnimationClip>();
		public HashSet<string> Parameter = new HashSet<string>();

		public string MotionType;
		public float MontionSpeed;
		public bool isStop;
		public float stopSpeed;

		public Animator Animator;

	}
}