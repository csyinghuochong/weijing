using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    [UIEvent(UIType.UIJiaYuanBag)]
    public class UIJiaYuanBagEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanBag);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanBag, gameObject);
            ui.AddComponent<UIJiaYuanBagComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanBag);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
