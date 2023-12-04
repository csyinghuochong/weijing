using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetHeXinSuit)]
    public class UIPetHeXinSuitEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeXinSuit);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetHeXinSuit, gameObject);
            ui.AddComponent<UIPetHeXinSuitComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeXinSuit);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}