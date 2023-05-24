using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIWearWeapon)]
    public class UIWearWeaponEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWearWeapon);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIWearWeapon, gameObject);

            ui.AddComponent<UIWearWeaponComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWearWeapon);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
