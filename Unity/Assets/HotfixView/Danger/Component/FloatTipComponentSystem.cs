
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

	[ObjectSystem]
	public class FloatTipComponentAwakeSystem : AwakeSystem<FloatTipComponent, GameObject, string>
	{
		public override void Awake(FloatTipComponent self, GameObject gameObject, string tip)
		{
			self.passTime = 0f;
			self.GameObject = gameObject;	
			self.Awake(tip);
		}
	}

	public static class FloatTipComponentSystem
    {
		public static void Awake(this FloatTipComponent self, string tip)
		{
			ReferenceCollector rc = self.GameObject.GetComponent<ReferenceCollector>();
			
			self.tipNode = rc.Get<GameObject>("Tips");
			self.tipText = rc.Get<GameObject>("Text");
			self.tipText.GetComponent<Text>().text = tip;
		}

		public static void CrossFadeAlpha(this FloatTipComponent self, int tipType)
		{
			self.GameObject.Get<GameObject>("Text").GetComponent<Text>().CrossFadeAlpha(0f, 2f, false);
			if (tipType != 0)
			{
				self.GameObject.Get<GameObject>("Image").GetComponent<Image>().CrossFadeAlpha(0f, 2f, false);
			}
		}

		public static bool OnUpdate(this FloatTipComponent self)
		{
			self.passTime += Time.deltaTime;
			self.tipNode.transform.localPosition = new Vector3(0f, self.passTime* FloatTipComponent.moveSpeed,0f);

			return self.passTime >= 2;
		}
	}
}
