using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIShouJiSelect)]
    public class UIShouJiSelectEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIShouJiSelect);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIShouJiSelect, gameObject);
            ui.AddComponent<UIShouJiSelectComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIShouJiSelect);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
