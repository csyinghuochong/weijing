using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIChengJiu)]
    public class UIChengJiuEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChengJiu);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIChengJiu, gameObject);
            ui.AddComponent<UIChengJiuComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChengJiu);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
