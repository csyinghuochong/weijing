using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UISeasonTowerReward)]
    public class UISeasonTowerRewardEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISeasonTowerReward);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISeasonTowerReward, gameObject);
            ui.AddComponent<UISeasonTowerRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISeasonTowerReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}