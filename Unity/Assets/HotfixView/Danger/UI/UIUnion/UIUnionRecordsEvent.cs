using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIUnionRecords)]
    public class UIUnionRecordsEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionRecords);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIUnionRecords, gameObject);
            ui.AddComponent<UIUnionRecordsComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionRecords);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}