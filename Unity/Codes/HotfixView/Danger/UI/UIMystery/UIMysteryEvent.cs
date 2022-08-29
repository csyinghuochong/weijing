using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIMystery)]
    public class UIMysteryEvent : AUIEvent
    {


        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIMystery);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIMystery, gameObject);
            ui.AddComponent<UIMysteryComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIMystery);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
