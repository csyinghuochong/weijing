using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIRunRace)]
    public class UIRunRaceEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRunRace);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRunRace, gameObject);
            ui.AddComponent<UIRunRaceComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRunRace);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}