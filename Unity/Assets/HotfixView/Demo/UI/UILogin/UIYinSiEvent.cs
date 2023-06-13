using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIYinSi)]
    public class UIYinSiEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIYinSi);
            await ETTask.CompletedTask;
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIYinSi, gameObject);
            ui.AddComponent<UIYinSiComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIYinSi);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}