using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIItemExpBox)]
    public class UIItemExpBoxEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIItemExpBox);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIItemExpBox, gameObject);
            ui.AddComponent<UIItemExpBoxComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIItemExpBox);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }

    }
}
