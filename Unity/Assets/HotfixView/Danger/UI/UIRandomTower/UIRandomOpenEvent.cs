using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIRandomOpen)]
    public class UIRandomOpenEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRandomOpen);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRandomOpen, gameObject);
            ui.AddComponent<UIRandomOpenComponent> ();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRandomOpen);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
