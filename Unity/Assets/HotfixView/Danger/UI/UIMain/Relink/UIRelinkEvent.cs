using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIRelink)]
    public class UIRelinkEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRelink);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRelink, gameObject);

            ui.AddComponent<UIRelinkComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRelink);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
