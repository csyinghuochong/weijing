using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UISettingPool)]
    public class UISettingPoolEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            await ETTask.CompletedTask;
            var path = ABPathHelper.GetUGUIPath(UIType.UISettingPool);
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISettingPool, gameObject);
            ui.AddComponent<UISettingPoolComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISettingPool);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}