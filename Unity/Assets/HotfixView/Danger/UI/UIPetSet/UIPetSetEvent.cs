using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPetSet)]
    public class UIPetSetEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetSet);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetSet, gameObject);

            ui.AddComponent<UIPetSetComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetSet);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
