using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIJiaYuanPet)]
    public class UIJiaYuanPetEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            await ETTask.CompletedTask;
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanPet);
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanPet, gameObject);
            ui.AddComponent<UIJiaYuanPetComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanPet);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
