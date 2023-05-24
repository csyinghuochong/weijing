using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UISettingFrame)]
    public class UISettingFrameEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISettingFrame);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISettingFrame, gameObject);
            ui.AddComponent<UISettingFrameComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISettingFrame);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
