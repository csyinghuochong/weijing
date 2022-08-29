using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIRankReward)]
    public class UIRankRewardEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRankReward);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRankReward, gameObject);
            ui.AddComponent<UIRankRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRankReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
