using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UITeamDungeonSettlement)]
    public class UITeamDungeonSettlementEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamDungeonSettlement);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UITeamDungeonSettlement, gameObject);
            ui.AddComponent<UITeamDungeonSettlementComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamDungeonSettlement);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
