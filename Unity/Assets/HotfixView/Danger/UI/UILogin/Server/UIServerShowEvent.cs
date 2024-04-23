using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIServerShow)]
    public class UIServerShowEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIServerShow);
            await ETTask.CompletedTask;
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIServerShow, gameObject);
            ui.AddComponent<UIServerShowComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIServerShow);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}