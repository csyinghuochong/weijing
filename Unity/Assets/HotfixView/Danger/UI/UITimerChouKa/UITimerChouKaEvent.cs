using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UITimerChouKa)]
    public class UITimerChouKaEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITimerChouKa);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITimerChouKa, gameObject);

            ui.AddComponent<UITimerChouKaComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITimerChouKa);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}