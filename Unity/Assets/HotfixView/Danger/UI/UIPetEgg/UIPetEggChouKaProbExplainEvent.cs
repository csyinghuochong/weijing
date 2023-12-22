using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetEggChouKaProbExplain)]
    public class UIPetEggChouKaProbExplainEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetEggChouKaProbExplain);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetEggChouKaProbExplain, gameObject);
            ui.AddComponent<UIPetEggChouKaProbExplainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetEggChouKaProbExplain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}