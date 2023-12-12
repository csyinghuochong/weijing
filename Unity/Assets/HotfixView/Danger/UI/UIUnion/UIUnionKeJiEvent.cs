using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIUnionKeJi)]
    public class UIUnionKeJiEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionKeJi);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIUnionKeJi, gameObject);
            ui.AddComponent<UIUnionKeJiComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionKeJi);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}