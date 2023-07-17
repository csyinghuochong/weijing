using UnityEngine;
namespace ET
{
    [UIEvent(UIType.UIWatchPaiMai)]
    public class UIWatchPaiMaiEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWatchPaiMai);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIWatchPaiMai, gameObject);
            ui.AddComponent<UIWatchPaiMaiComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWatchPaiMai);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}