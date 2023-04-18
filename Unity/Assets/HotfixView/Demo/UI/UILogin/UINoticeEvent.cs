using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UINotice)]
    public class UINoticeEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UINotice);
            await ETTask.CompletedTask;
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UINotice, gameObject);
            ui.AddComponent<UINoticeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UINotice);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
