using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIRolePetBag)]
    public class UIRolePetBagEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRolePetBag);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRolePetBag, gameObject);
            ui.AddComponent<UIRolePetBagComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRolePetBag);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}