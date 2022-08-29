using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetFubenResult)]
    public class UIPetFubenResultEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetFubenResult);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetFubenResult, gameObject);

            ui.AddComponent<UIPetFubenResultComponent>();
            return ui;
        }


        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetFubenResult);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
