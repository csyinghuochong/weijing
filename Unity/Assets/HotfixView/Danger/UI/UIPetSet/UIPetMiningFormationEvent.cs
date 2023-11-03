using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetMiningFormation)]
    internal class UIPetMiningFormationEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMiningFormation);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetMiningFormation, gameObject);

            ui.AddComponent<UIPetMiningFormationComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMiningFormation);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
