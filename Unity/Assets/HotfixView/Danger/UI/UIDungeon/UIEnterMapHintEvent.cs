using System;
using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIEnterMapHint)]
    public class UIEnterMapHintEvent  : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIEnterMapHint);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIEnterMapHint, gameObject);
            ui.AddComponent<UIEnterMapHintComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIEnterMapHint);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}