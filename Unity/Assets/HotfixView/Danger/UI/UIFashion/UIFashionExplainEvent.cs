using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIFashionExplain)]
    public class UIFashionExplainEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIFashionExplain);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIFashionExplain, gameObject);
            ui.AddComponent<UIFashionExplainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIFashionExplain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}