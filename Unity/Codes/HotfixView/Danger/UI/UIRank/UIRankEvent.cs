using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIRank)]
    public class UIRankEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRank);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIRank, gameObject);
            ui.AddComponent<UIRankComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRank);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
