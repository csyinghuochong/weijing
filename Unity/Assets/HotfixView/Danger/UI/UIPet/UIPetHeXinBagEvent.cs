using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPetHeXinBag)]
    public class UIPetHeXinBagEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeXinBag);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetHeXinBag, gameObject);
            ui.AddComponent<UIPetHeXinBagComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeXinBag);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
