using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIUnionXiuLian)]
    public class UIUnionXiuLianEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionXiuLian);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIUnionXiuLian, gameObject);
            ui.AddComponent<UIUnionXiuLianComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionXiuLian);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
