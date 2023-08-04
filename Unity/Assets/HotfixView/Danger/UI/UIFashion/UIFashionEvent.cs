using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIFashion)]
    public class UIFashionEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIFashion);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIFashion, gameObject);
            ui.AddComponent<UIFashionComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIFashion);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }


    }
}