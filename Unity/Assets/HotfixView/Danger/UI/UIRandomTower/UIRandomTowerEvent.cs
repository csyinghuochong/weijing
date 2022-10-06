using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIRandomTower)]
    public class UIRandomTowerEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRandomTower);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRandomTower, gameObject);
            ui.AddComponent<UIRandomTowerComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRandomTower);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
