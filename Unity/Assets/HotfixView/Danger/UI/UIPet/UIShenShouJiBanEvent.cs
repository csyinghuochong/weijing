using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIShenShouJiBan)]
    public class UIShenShouJiBanEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIShenShouJiBan);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIShenShouJiBan, gameObject);
            ui.AddComponent<UIShenShouJiBanComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIShenShouJiBan);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}