using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIZuoQi)]
    public class UIZuoQiEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIZuoQi);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIZuoQi, gameObject);

            ui.AddComponent<UIZuoQiComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIZuoQi);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
