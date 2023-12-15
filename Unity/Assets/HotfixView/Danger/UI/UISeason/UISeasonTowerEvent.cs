using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UISeasonTower)]
    public class UISeasonTowerEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISeasonTower);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISeasonTower, gameObject);
            ui.AddComponent<UISeasonTowerComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISeasonTower);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}