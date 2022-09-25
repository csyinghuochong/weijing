using System;
using UnityEngine;

namespace ET

{
    [UIEvent(UIType.UIPetFormation)]
    internal class UIPetFormationEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetFormation);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetFormation, gameObject);

            ui.AddComponent<UIPetFormationComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetFormation);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
