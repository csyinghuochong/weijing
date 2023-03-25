using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    [UIEvent(UIType.UIJiaYuanPasture)]
    public class UIJiaYuanPastureEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanPasture);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanPasture, gameObject);
            ui.AddComponent<UIJiaYuanPastureComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanPasture);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
