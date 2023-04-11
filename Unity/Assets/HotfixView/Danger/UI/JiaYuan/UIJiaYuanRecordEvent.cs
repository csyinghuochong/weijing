using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIJiaYuanRecord)]
    public class UIJiaYuanRecordEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanRecord);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanRecord, gameObject);
            ui.AddComponent<UIJiaYuanRecordComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanRecord);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
