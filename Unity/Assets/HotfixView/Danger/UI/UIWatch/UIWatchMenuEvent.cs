using UnityEngine;


namespace ET
{


    [UIEvent(UIType.UIWatchMenu)]
    public class UIWatchMenuEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWatchMenu);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIWatchMenu, gameObject);
            ui.AddComponent<UIWatchMenuComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWatchMenu);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }

}
