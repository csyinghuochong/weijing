using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIGiveTask)]
    public class UIGiveTaskEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIGiveTask);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIGiveTask, gameObject);
            ui.AddComponent<UIGiveTaskComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIGiveTask);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}