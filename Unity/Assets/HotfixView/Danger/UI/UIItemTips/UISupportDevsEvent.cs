using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UISupportDevs)]
    public class UISupportDevsEventEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISupportDevs);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISupportDevs, gameObject);
            ui.AddComponent<UISupportDevsComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISupportDevs);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}
