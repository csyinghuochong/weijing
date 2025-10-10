using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UISelectWeapon)]
    public class UISelectWeaponEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISelectWeapon);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISelectWeapon, gameObject);

            ui.AddComponent<UISelectWeaponComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISelectWeapon);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
