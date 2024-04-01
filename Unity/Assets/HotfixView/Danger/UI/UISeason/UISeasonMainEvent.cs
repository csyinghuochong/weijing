using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UISeasonMain)]
    public class UISeasonMainEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISeasonMain);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISeasonMain, gameObject);
            ui.AddComponent<UISeasonMainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISeasonMain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}