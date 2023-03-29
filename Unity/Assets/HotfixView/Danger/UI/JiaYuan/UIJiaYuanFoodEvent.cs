using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIJiaYuanFood)]
    public class UIJiaYuanFoodEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanFood);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanFood, gameObject);
            ui.AddComponent<UIJiaYuanFoodComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanFood);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
