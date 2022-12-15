
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

	[ObjectSystem]
	public class FloatTipComponentAwakeSystem : AwakeSystem<FloatTipComponent>
	{
		public override void Awake(FloatTipComponent self)
		{
			self.passTime = 0f;
			self.AssetEffect = string.Empty;
		}
	}

	[ObjectSystem]
	public class FloatTipComponentDestroy : DestroySystem<FloatTipComponent>
	{
        public override void Destroy(FloatTipComponent self)
        {
			if (self.GameObject != null)
			{
				self.GameObject.Get<GameObject>("Text").GetComponent<Text>().CrossFadeAlpha(1f, 0.1f, false);
				if (self.FloatTipType.type != 0)
				{
					self.GameObject.Get<GameObject>("Image").GetComponent<Image>().CrossFadeAlpha(1f, 0.1f, false);
				}
				GameObjectPoolComponent.Instance.RecoverGameObject(self.AssetEffect, self.GameObject, true);
				self.GameObject.transform.localPosition = new Vector2(0f, 2000f);
			}
			self.GameObject = null;
        }
    }

	public static class FloatTipComponentSystem
    {

		public static void OnInitData(this FloatTipComponent self, FloatTipType tip)
		{
			string tipPath = tip.type == 0 ? "Common/UITips" : "Common/UITipsDi";
			self.FloatTipType = tip;
			self.AssetEffect = ABPathHelper.GetUGUIPath(tipPath);
			GameObjectPoolComponent.Instance.AddLoadQueue(self.AssetEffect, self.InstanceId, self.OnLoadGameObject);
		}

		public static void OnLoadGameObject(this FloatTipComponent self, GameObject gameObject, long formId)
		{
			if (self.InstanceId != formId)
			{
				GameObject.DestroyImmediate(gameObject);
				return;
			}
			self.GameObject = gameObject;
			gameObject.transform.SetParent(UIEventComponent.Instance.UILayers[(int)UILayer.High]);
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

			self.tipNode = rc.Get<GameObject>("Tips");
			self.tipText = rc.Get<GameObject>("Text");
			self.tipText.GetComponent<Text>().text = self.FloatTipType.tip;
			self.CrossFadeAlpha(self.FloatTipType.type);
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
			if (self.tipNode != null)
			{
				self.tipNode.transform.localPosition = new Vector3(0f, self.passTime * 120, 0f);
			}
			self.passTime += Time.deltaTime;
			return self.passTime >= 2;
		}
	}
}
