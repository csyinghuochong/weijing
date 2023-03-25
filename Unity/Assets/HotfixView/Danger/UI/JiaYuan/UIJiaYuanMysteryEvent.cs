using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIUIJiaYuanMystery)]
    internal class UIJiaYuanMysteryEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUIJiaYuanMystery);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIUIJiaYuanMystery, gameObject);
            ui.AddComponent<UIUIJiaYuanMysteryComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUIJiaYuanMystery);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
