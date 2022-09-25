using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPetChallenge)]
    public class UIPetChallengeEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetChallenge);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetChallenge, gameObject);

            ui.AddComponent<UIPetChallengeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetChallenge);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
