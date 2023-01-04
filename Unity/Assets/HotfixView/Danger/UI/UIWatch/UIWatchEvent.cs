using UnityEngine;


namespace ET
{
    [UIEvent(UIType.UIWatch)]
    public class UIWatchEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWatch);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIWatch, gameObject);
            ui.AddComponent<UIWatchComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWatch);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
