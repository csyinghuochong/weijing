using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UILingDiReward)]
    public class UILingDiRewardEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UILingDiReward);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UILingDiReward, gameObject);

            ui.AddComponent<UILingDiRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UILingDiReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
