using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIItemTips)]
    public class UIItemTipsEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIItemTips);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIItemTips, gameObject);
            ui.AddComponent<UIItemTipsComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIItemTips);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}
