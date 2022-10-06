using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIZhanQu)]
    public class UIZhanQuEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIZhanQu);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIZhanQu, gameObject);

            ui.AddComponent<UIZhanQuComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIZhanQu);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
