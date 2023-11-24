using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UISeasonJingHeZhuru)]
    public class UISeasonJingHeZhuruEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISeasonJingHeZhuru);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISeasonJingHeZhuru, gameObject);
            ui.AddComponent<UISeasonJingHeZhuruComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISeasonJingHeZhuru);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}