using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    [UIEvent(UIType.UIMain)]
    public class UIMainEvent : AUIEvent
    {
        public const int SkillButtonNumber = 10;

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIMain);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIMain, gameObject);
            ui.AddComponent<UIMainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIMain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}
