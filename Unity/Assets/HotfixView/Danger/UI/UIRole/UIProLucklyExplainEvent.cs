using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIProLucklyExplain)]
    public class UIProLucklyExplainEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIProLucklyExplain);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIProLucklyExplain, gameObject);
            ui.AddComponent<UIProLucklyExplainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIProLucklyExplain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}