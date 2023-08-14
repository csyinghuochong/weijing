using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIHappyMain)]
    public class UIHappyMainEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIHappyMain);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIHappyMain, gameObject);
            ui.AddComponent<UIHappyMainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIHappyMain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
