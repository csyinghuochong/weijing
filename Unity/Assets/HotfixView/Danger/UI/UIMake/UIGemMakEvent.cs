using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIGemMake)]
    public class UIGemMakEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIGemMake);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIGemMake, gameObject);

            ui.AddComponent<UIGemMakeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIGemMake);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
