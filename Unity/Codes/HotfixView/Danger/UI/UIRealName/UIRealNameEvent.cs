using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIRealName)]
    public class UIRealNameEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRealName);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIRealName, gameObject);
            ui.AddComponent<UIRealNameComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRealName);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }

}
