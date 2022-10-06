using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPetChouKaGet)]
    public class UIPetChouKaGetEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetChouKaGet);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIPetChouKaGet, gameObject);
            ui.AddComponent<UIPetChouKaGetComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetChouKaGet);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
