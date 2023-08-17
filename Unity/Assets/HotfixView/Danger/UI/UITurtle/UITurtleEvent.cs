using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UITurtle)]
    public class UITurtleEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITurtle);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITurtle, gameObject);

            ui.AddComponent<UITurtleComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITurtle);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}