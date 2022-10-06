using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIXiuLian)]
    public class UIXiuLianEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIXiuLian);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIXiuLian, gameObject);
            ui.AddComponent<UIXiuLianComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIXiuLian);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
