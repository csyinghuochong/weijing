using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetHeChengExplain)]
    public class UIPetHeChengExplainEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeChengExplain);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetHeChengExplain, gameObject);
            ui.AddComponent<UIPetHeChengExplainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeChengExplain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}