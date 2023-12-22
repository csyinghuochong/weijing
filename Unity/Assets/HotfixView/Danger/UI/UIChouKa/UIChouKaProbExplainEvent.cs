using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIChouKaProbExplain)]
    public class UIChouKaProbExplainEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChouKaProbExplain);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIChouKaProbExplain, gameObject);
            ui.AddComponent<UIChouKaProbExplainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChouKaProbExplain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}