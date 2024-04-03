using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIWeiJingShop)]
    public class UIWeiJingShopEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWeiJingShop);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIWeiJingShop, gameObject);
            ui.AddComponent<UIWeiJingShopComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWeiJingShop);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }


    }
}
