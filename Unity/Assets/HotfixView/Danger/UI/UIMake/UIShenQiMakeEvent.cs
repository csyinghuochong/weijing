using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIShenQiMake)]
    public class UIShenQiMakeEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIShenQiMake);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIShenQiMake, gameObject);

            ui.AddComponent<UIShenQiMakeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIShenQiMake);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
