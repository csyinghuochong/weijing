using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UICommonHuoBiSet)]
    public class UICommonHuoBiSetEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICommonHuoBiSet);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UICommonHuoBiSet, gameObject);

            ui.AddComponent<UICommonHuoBiSetComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICommonHuoBiSet);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
