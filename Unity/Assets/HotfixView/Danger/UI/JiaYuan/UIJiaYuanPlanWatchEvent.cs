using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    [UIEvent(UIType.UIJiaYuanPlanWatch)]
    public class UIJiaYuanPlanWatchEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanPlanWatch);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanPlanWatch, gameObject);
            ui.AddComponent<UIJiaYuanPlanWatchComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanPlanWatch);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
