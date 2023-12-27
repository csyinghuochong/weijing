using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetHeChengPreview)]
    public class UIPetHeChengPreviewEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeChengPreview);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetHeChengPreview, gameObject);
            ui.AddComponent<UIPetHeChengPreviewComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeChengPreview);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}