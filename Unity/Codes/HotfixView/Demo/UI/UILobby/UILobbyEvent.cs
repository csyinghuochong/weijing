using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UILobby)]
    public class UILobbyEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            await ETTask.CompletedTask;
            var path = ABPathHelper.GetUGUIPath(UIType.UILobby);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);

            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UILobby, gameObject);
            ui.AddComponent<UILobbyComponent>();

            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UILobby);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}