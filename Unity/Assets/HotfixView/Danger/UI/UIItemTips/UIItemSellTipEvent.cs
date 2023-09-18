using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIItemSellTip)]
    public class UIItemSellTipEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIItemSellTip);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIItemSellTip, gameObject);
            ui.AddComponent<UIItemSellTipComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIItemSellTip);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}
