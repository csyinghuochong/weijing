using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIJiaYuanMystery)]
    internal class UIJiaYuanMysteryEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanMystery);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanMystery, gameObject);
            ui.AddComponent<UIJiaYuanMysteryComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanMystery);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
