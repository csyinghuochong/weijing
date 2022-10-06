using System;
using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIPaiMaiStall)]
    public class UIPaiMaiStallEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMaiStall);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIPaiMaiStall, gameObject);
            ui.AddComponent<UIPaiMaiStallComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMaiStall);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
