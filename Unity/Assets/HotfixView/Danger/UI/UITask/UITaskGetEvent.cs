using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UITaskGet)]
    public class UITaskGetEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITaskGet);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UITaskGet, gameObject);
            ui.AddComponent<UITaskGetComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITaskGet);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
