using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetHeXinChouKaReward)]
    public class UIPetHeXinChouKaRewardEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeXinChouKaReward);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetHeXinChouKaReward, gameObject);
            ui.AddComponent<UIPetHeXinChouKaRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeXinChouKaReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}