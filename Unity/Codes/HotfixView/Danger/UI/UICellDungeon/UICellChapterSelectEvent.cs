using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UICellChapterSelect)]
    public class UICellChapterSelectEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICellChapterSelect);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UICellChapterSelect, gameObject);

            ui.AddComponent<UICellChapterSelectComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICellChapterSelect);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
