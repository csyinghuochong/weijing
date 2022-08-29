using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetMain)]
    public class UIPetMainEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMain);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetMain, gameObject);

            ui.AddComponent<UIPetMainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
