using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UICommonProperty)]
    public class UICommonPropertyEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICommonProperty);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UICommonProperty, gameObject);
            ui.AddComponent<UICommonPropertyComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICommonProperty);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}