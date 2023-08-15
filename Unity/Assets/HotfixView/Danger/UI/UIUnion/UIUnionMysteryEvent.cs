using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIUnionMystery)]
    public class UIUnionMysteryEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionMystery);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIUnionMystery, gameObject);
            ui.AddComponent<UIUnionMysteryComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionMystery);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}