using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIRoleBagSplit)]
    public class UIRoleBagSplitEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleBagSplit);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRoleBagSplit, gameObject);

            ui.AddComponent<UIRoleBagSplitComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleBagSplit);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
