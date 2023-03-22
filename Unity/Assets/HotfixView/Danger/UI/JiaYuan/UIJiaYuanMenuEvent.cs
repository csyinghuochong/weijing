using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    [UIEvent(UIType.UIJiaYuanMenu)]
    public class UIJiaYuanMenuEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanMenu);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanMenu, gameObject);
            ui.AddComponent<UIJiaYuanMenuComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanMenu);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
