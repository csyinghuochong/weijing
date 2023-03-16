using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIJingLingGet)]
    public class UIJingLingGetEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJingLingGet);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJingLingGet, gameObject);
            ui.AddComponent<UIJingLingGetComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJingLingGet);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
