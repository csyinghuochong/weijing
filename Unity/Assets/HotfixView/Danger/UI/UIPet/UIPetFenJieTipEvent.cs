using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetFenJieTip)]
    public class UIPetFenJieTipEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetFenJieTip);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetFenJieTip, gameObject);
            ui.AddComponent<UIPetFenJieTipComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetFenJieTip);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
