using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UISeasonLordDetail)]
    public class UISeasonLordDetailEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISeasonLordDetail);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISeasonLordDetail, gameObject);
            ui.AddComponent<UISeasonLordDetailComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISeasonLordDetail);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}