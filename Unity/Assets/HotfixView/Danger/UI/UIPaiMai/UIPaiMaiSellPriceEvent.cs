using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPaiMaiSellPrice)]
    public class UIPaiMaiSellPriceEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMaiSellPrice);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIPaiMaiSellPrice, gameObject);
            ui.AddComponent<UIPaiMaiSellPriceComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMaiSellPrice);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }


    }
}
