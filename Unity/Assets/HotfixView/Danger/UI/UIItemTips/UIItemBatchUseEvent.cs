using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIItemBatchUse)]
    public class UIItemBatchUseEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIItemBatchUse);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIItemBatchUse, gameObject);
            ui.AddComponent<UIItemBatchUseComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIItemBatchUse);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}