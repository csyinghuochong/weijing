using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{
	public class UILoadingComponent : Entity, IAwake, IUpdate
	{
		public Text text;
		public GameObject Back_1;
        public GameObject Image;
		public Image lodingImg;
		public GameObject BackSet;
		public int ChapterId;
		public float PassTime;
		public bool ShowMainUI;

		public bool StartLoadAssets = false;
		public List<string> PreLoadAssets = new List<string>();
		public List<string> ReleaseAssets = new List<string>();
	}
}
