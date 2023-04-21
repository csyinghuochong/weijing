using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIItemFumoSelect)]
    public class UIItemFumoSelectEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIItemFumoSelect);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIItemFumoSelect, gameObject);
            ui.AddComponent<UIItemFumoSelectComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIItemFumoSelect);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
