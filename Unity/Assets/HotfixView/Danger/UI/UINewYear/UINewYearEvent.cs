using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UINewYear)]
    public class UINewYearEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UINewYear);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UINewYear, gameObject);
            ui.AddComponent<UINewYearComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UINewYear);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
