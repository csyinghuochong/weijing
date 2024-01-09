using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPaiMaiBuyTip)]
    public class UIPaiMaiBuyTipEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMaiBuyTip);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPaiMaiBuyTip, gameObject);
            ui.AddComponent<UIPaiMaiBuyTipComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMaiBuyTip);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}