using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPropertyHint)]
    public class UIPropertyHintEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPropertyHint);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPropertyHint, gameObject);

            ui.AddComponent<UIPropertyHintComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPropertyHint);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}