using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    [UIEvent(UIType.UILeavlReward)]
    public class UILeavlRewardEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UILeavlReward);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UILeavlReward, gameObject);
            ui.AddComponent<UILeavlRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UILeavlReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}