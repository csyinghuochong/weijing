using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{
	public class UILoadingComponent : Entity, IAwake, IUpdate
	{
		public Text text;
		public GameObject Image;
		public GameObject lodingImg;
		public GameObject Img_BackIcon;
		public GameObject BackSet;
		public int ChapterId;
		public float PassTime;

		public bool StartLoadAssets = false;
		public List<string> PreLoadAssets = new List<string>();
	}
}
