using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UITreasureOpen)]
    public class UITreasureOpenEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITreasureOpen);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITreasureOpen, gameObject);

            ui.AddComponent<UITreasureOpenComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITreasureOpen);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}

