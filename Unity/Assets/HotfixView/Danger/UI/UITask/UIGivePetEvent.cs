using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIGivePet)]
    public class UIGivePetEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIGivePet);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIGivePet, gameObject);
            ui.AddComponent<UIGivePetComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIGivePet);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}