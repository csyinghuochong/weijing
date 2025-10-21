using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    [UIEvent(UIType.UISelectRewardWeapon)]
    public class UISelectRewardWeaponEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISelectRewardWeapon);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISelectRewardWeapon, gameObject);
            ui.AddComponent<UISelectRewardWeaponComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISelectRewardWeapon);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}