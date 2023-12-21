using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIActivityV1)]
    public class UIActivityV1Event: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIActivityV1);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIActivityV1, gameObject);
            ui.AddComponent<UIActivityV1Component>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIActivityV1);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}