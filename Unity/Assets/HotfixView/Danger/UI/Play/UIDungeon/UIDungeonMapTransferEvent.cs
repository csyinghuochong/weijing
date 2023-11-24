using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIDungeonMapTransfer)]
    public class UIDungeonMapTransferEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIDungeonMapTransfer);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIDungeonMapTransfer, gameObject);

            ui.AddComponent<UIDungeonMapTransferComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIDungeonMapTransfer);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}