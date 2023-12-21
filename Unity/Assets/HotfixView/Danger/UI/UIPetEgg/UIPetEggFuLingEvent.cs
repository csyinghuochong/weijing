using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetEggFuLing)]
    public class UIPetEggFuLingEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetEggFuLing);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetEggFuLing, gameObject);
            ui.AddComponent<UIPetEggFuLingComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetEggFuLing);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}