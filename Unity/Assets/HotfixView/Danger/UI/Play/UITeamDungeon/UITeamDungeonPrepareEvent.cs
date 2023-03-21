using UnityEngine;


namespace ET
{
    [UIEvent(UIType.UITeamDungeonPrepare)]
    public class UITeamDungeonPrepareEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamDungeonPrepare);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITeamDungeonPrepare, gameObject);
            ui.AddComponent<UITeamDungeonPrepareComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamDungeonPrepare);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
