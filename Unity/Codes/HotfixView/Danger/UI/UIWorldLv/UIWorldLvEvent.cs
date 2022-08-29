using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIWorldLv)]
    public class UIWorldLvEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWorldLv);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIWorldLv, gameObject);
            ui.AddComponent<UIWorldLvComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWorldLv);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
