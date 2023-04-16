using System;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPaiMaiAuction)]
    public class UIPaiMaiAuctionEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMaiAuction);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPaiMaiAuction, gameObject);
            ui.AddComponent<UIPaiMaiAuctionComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMaiAuction);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
