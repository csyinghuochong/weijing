using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIStallSellPrice)]
    public class UIStallSellPriceEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIStallSellPrice);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIStallSellPrice, gameObject);
            ui.AddComponent<UIStallSellPriceComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIStallSellPrice);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}