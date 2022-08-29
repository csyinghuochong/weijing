using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPopupview)]
    public class UIPopupEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPopupview);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIPopupview, gameObject);
            ui.AddComponent<UIPopupComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPopupview);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }
    }
}
