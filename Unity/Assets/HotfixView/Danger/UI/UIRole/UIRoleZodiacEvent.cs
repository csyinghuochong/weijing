using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIRoleZodiac)]
    public class UIRoleZodiacEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleZodiac);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRoleZodiac, gameObject);

            ui.AddComponent<UIRoleZodiacComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleZodiac);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
