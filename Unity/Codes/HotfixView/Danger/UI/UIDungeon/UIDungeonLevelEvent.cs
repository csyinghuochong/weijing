using System;
using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIDungeonLevel)]
    public class UIDungeonLevelEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIDungeonLevel);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIDungeonLevel, gameObject);
            ui.AddComponent<UIDungeonLevelComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIDungeonLevel);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
