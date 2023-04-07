using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIJiaYuanDaShi)]
    public class UIJiaYuanDaShiEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanDaShi);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanDaShi, gameObject);
            ui.AddComponent<UIJiaYuanDaShiComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanDaShi);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
