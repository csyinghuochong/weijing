using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIAuctionRecode)]
    public class UIAuctionRecordEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIAuctionRecode);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIAuctionRecode, gameObject);
            ui.AddComponent<UIAuctionRecodeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIAuctionRecode);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
