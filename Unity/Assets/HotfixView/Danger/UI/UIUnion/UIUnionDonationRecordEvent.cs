using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIUnionDonationRecord)]
    public class UIUnionDonationRecordEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionDonationRecord);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIUnionDonationRecord, gameObject);
            ui.AddComponent<UIUnionDonationRecordComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionDonationRecord);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
