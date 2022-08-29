using System;
using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIPetSelect)]
    public class UIPetSelectEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetSelect);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIPetSelect, gameObject);
            ui.AddComponent<UIPetSelectComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetSelect);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }
    }
}
