using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
	[ObjectSystem]
	public class UIEventComponentAwakeSystem : AwakeSystem<UIEventComponent>
	{
		public override void Awake(UIEventComponent self)
		{
			UIEventComponent.Instance = self;

			GameObject uiRoot = GameObject.Find("/Global/UI");
			ReferenceCollector referenceCollector = uiRoot.GetComponent<ReferenceCollector>();

			self.UILayers.Add((int)UILayer.Hidden, referenceCollector.Get<GameObject>(UILayer.Hidden.ToString()).transform);
			self.UILayers.Add((int)UILayer.Low, referenceCollector.Get<GameObject>(UILayer.Low.ToString()).transform);
			self.UILayers.Add((int)UILayer.Mid, referenceCollector.Get<GameObject>(UILayer.Mid.ToString()).transform);
			self.UILayers.Add((int)UILayer.High, referenceCollector.Get<GameObject>(UILayer.High.ToString()).transform);
			self.UILayers.Add((int)UILayer.Blood, referenceCollector.Get<GameObject>(UILayer.Blood.ToString()).transform);

			var uiEvents = Game.EventSystem.GetTypes(typeof(UIEventAttribute));
			foreach (Type type in uiEvents)
			{
				object[] attrs = type.GetCustomAttributes(typeof(UIEventAttribute), false);
				if (attrs.Length == 0)
				{
					continue;
				}

				UIEventAttribute uiEventAttribute = attrs[0] as UIEventAttribute;
				AUIEvent aUIEvent = Activator.CreateInstance(type) as AUIEvent;
				self.UIEvents.Add(uiEventAttribute.UIType, aUIEvent);
			}
		}
	}

	[ObjectSystem]
	public class UIEventComponentDestroySystem : DestroySystem<UIEventComponent>
	{
		public override void Destroy(UIEventComponent self)
		{
			self.UILayers = new Dictionary<int, Transform>();
			self.UIEvents = new Dictionary<string, AUIEvent>();
		}
	}

	/// <summary>
	/// 管理所有UI GameObject 以及UI事件
	/// </summary>
	public static class UIEventComponentSystem
	{
		public static async ETTask<UI> OnCreate(this UIEventComponent self, UIComponent uiComponent, string uiType)
		{
			try
			{
				long instanceId = self.InstanceId;
				if (!self.UIEvents.ContainsKey(uiType))
				{
					return null;
				}
				UI ui = await self.UIEvents[uiType].OnCreate(uiComponent);
				if ( instanceId != self.InstanceId)
                {
					return null;
                }
				UILayer uiLayer = ui.GameObject.GetComponent<UILayerScript>().UILayer;
				ui.GameObject.transform.SetParent(self.UILayers[(int)uiLayer]);
				ui.GameObject.transform.localPosition = Vector3.zero;
				ui.GameObject.transform.localScale = Vector3.one;

				//多语言
				GameSettingLanguge.TransformText(ui.GameObject.transform);
				GameSettingLanguge.TransformImage(ui.GameObject.transform);

				if (ui.GameObject.GetComponent<UILayerScript>().UIType == ET.UIEnum.FullScreen)
				{
					ui.GameObject.transform.GetComponent<RectTransform>().offsetMax = Vector2.zero;
					ui.GameObject.transform.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				}
				return ui;
			}
			catch (Exception e)
			{
				throw new Exception($"on create ui error: {uiType}", e);
			}
		}

		public static void OnRemove(this UIEventComponent self, UIComponent uiComponent, string uiType)
		{
			try
			{
				self.UIEvents[uiType].OnRemove(uiComponent);
			}
			catch (Exception e)
			{
				throw new Exception($"on remove ui error: {uiType}", e);
			}

		}
	}
}