using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIStorySpeak)]
    public class UIRoleStoryEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIStorySpeak);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIStorySpeak, gameObject);
            ui.AddComponent<UIRoleStoryComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIStorySpeak);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
