using System;
using UnityEngine;


namespace ET
{
    [UIEvent(UIType.UIPaiMaiStallBuy)]
    public class UIPaiMaiStallBuyEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMaiStallBuy);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIPaiMaiStallBuy, gameObject);
            ui.AddComponent<UIPaiMaiStallBuyComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMaiStallBuy);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
