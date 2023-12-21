using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetEggLucklyExplain)]
    public class UIPetEggLucklyExplainEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetEggLucklyExplain);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetEggLucklyExplain, gameObject);
            ui.AddComponent<UIPetEggLucklyExplainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetEggLucklyExplain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}