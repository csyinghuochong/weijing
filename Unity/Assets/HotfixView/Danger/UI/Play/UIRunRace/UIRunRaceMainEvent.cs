using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIRunRaceMain)]
    public class UIRunRaceMainEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRunRaceMain);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRunRaceMain, gameObject);
            ui.AddComponent<UIRunRaceMainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRunRaceMain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}