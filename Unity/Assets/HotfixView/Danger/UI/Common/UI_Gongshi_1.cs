using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UI_Gongshi_1)]
    public class UI_Gongshi_1 : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UI_Gongshi_1);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UI_Gongshi_1, gameObject);
            ui.AddComponent<UIGongshi1Component>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UI_Gongshi_1);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }
    }

}
