using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIUnionDonation)]
    public class UIUnionDonationEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionDonation);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIUnionDonation, gameObject);
            ui.AddComponent<UIUnionDonationComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionDonation);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
