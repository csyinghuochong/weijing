using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    [UIEvent(UIType.UISelectReward)]
    public class UILeavlRewardEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISelectReward);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISelectReward, gameObject);
            ui.AddComponent<UISelectRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISelectReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}