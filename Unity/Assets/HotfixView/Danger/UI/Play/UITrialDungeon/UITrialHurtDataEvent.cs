using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UITrialHurtData)]
    public class UITrialHurtDataEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITrialHurtData);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITrialHurtData, gameObject);
            ui.AddComponent<UITrialHurtDataComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITrialHurtData);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
