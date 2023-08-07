using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIJueXing)]
    public class UIJueXingEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJueXing);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJueXing, gameObject);
            ui.AddComponent<UIJueXingComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJueXing);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }


    }
}