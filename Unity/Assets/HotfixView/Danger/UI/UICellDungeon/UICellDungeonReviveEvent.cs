using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UICellDungeonRevive)]
    public class UICellDungeonReviveEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICellDungeonRevive);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UICellDungeonRevive, gameObject);
            ui.AddComponent<UICellDungeonReviveComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICellDungeonRevive);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
