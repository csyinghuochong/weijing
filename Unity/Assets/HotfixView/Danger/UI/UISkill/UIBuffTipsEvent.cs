using System;
using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIBuffTips)]
    public class UIBuffTipsEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIBuffTips);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIBuffTips, gameObject);
            ui.AddComponent<UIBuffTipsComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIBuffTips);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
