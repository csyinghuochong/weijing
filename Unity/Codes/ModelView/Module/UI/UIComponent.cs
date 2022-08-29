using System.Collections.Generic;
using UnityEngine;
namespace ET
{
	/// <summary>
	/// 管理Scene上的UI
	/// </summary>
	public class UIComponent : Entity, IAwake, IDestroy
	{
		public Camera UICamera;
		public Camera MainCamera;
		public static UIComponent Instance;

		public int ResolutionWidth;
		public int ResolutionHeight;
		public Dictionary<string, UI> UIs = new Dictionary<string, UI>();
	}
}