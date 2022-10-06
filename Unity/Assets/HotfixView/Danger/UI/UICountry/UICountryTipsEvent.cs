using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UICountryTips)]
    public class UICountryTipsEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICountryTips);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UICountryTips, gameObject);
            ui.AddComponent<UICountryTipsComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICountryTips);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
