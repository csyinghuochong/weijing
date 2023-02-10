using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPhoneCode)]
    public class UIPhoneCodeEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPhoneCode);
            await ETTask.CompletedTask;
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPhoneCode, gameObject);
            ui.AddComponent<UIPhoneCodeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPhoneCode);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
