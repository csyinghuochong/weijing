using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UITrialMain)]
    public class UITrialMainEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITrialMain);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITrialMain, gameObject);
            ui.AddComponent<UITrialMainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITrialMain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
