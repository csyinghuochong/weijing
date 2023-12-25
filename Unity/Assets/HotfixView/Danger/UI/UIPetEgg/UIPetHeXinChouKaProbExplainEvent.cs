using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetHeXinChouKaProbExplain)]
    public class UIPetHeXinChouKaProbExplainEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeXinChouKaProbExplain);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetHeXinChouKaProbExplain, gameObject);
            ui.AddComponent<UIPetHeXinChouKaProbExplainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeXinChouKaProbExplain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}