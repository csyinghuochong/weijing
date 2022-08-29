using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPaiMai)]
    public class UIPaiMaiEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMai);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIPaiMai, gameObject);
            ui.AddComponent<UIPaiMaiComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPaiMai);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
