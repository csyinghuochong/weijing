using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    [UIEvent(UIType.UIMapBig)]
    public class UIMapBigEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIMapBig);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIMapBig, gameObject);
            ui.AddComponent<UIMapBigComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIMapBig);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
