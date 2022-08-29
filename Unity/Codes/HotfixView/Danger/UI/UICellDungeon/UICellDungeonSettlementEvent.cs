using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UICellDungeonSettlement)]
    public class UICellDungeonSettlementEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICellDungeonSettlement);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UICellDungeonSettlement, gameObject);
            ui.AddComponent<UICellDungeonSettlementComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICellDungeonSettlement);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
