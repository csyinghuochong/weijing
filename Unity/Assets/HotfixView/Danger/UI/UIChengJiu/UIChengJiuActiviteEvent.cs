using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIChengJiuActivite)]
    public class UIChengJiuActiviteEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChengJiuActivite);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIChengJiuActivite, gameObject);
            ui.AddComponent<UIChengJiuActiviteComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChengJiuActivite);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
