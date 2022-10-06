using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UI_CommonHint_2)]
    public class UI_CommonHint_2 : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UI_CommonHint_2);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UI_CommonHint_2, gameObject);
            ui.AddComponent<UIPopupComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UI_CommonHint_2);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }
    }
}
