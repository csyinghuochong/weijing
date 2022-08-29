using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UISetting)]
    public class UISettingEvent: AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISetting);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UISetting, gameObject);
            ui.AddComponent<UISettingComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISetting);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
