using System;
using UnityEngine;

namespace ET
{
	[UIEvent(UIType.UILoading)]
    public class UILoadingEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
	        try
	        {
                var path = ABPathHelper.GetUGUIPath(UIType.UILoading);
                await ETTask.CompletedTask;
                var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
                UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UILoading, gameObject);

                ui.AddComponent<UILoadingComponent>();
                return ui;
            }
	        catch (Exception e)
	        {
				Log.Error(e);
		        return null;
	        }
		}

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UILoading);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}