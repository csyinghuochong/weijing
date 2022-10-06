using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIShouJi)]
    public class UIShouJiEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIShouJi);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIShouJi, gameObject);
            ui.AddComponent<UIShouJiComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIShouJi);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
