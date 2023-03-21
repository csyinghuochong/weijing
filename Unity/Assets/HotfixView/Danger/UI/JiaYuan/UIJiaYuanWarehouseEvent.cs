using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    [UIEvent(UIType.UIJiaYuanWarehouse)]
    public class UIJiaYuanWarehouseEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanWarehouse);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanWarehouse, gameObject);
            ui.AddComponent<UIJiaYuanWarehouseComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanWarehouse);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
