using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UILingDi)]
    public class UILingDiEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UILingDi);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UILingDi, gameObject);

            ui.AddComponent<UILingDiComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UILingDi);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
