using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIWelfare)]
    public class UIWelfareEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWelfare);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIWelfare, gameObject);

            //ui.AddComponent<UIWelfareComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWelfare);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
