using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UICellDungeonSelect)]
    public class UICellDungeonSelectEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICellDungeonSelect);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UICellDungeonSelect, gameObject);

            ui.AddComponent<UICellDungeonSelectComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICellDungeonSelect);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}
