using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIDeleteAccount)]
    public class UIDeleteAccountEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIDeleteAccount);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIDeleteAccount, gameObject);

            ui.AddComponent<UIDeleteAccountComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIDeleteAccount);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}
