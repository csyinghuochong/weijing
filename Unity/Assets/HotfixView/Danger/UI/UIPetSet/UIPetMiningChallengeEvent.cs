using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPetMiningChallenge)]
    public class UIPetMiningChallengeEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMiningChallenge);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetMiningChallenge, gameObject);

            ui.AddComponent<UIPetMiningChallengeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMiningChallenge);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}