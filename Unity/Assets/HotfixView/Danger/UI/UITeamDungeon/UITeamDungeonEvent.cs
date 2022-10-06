using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UITeamDungeon)]
    public class UITeamDungeonEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamDungeon);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UITeamDungeon, gameObject);
            ui.AddComponent<UITeamDungeonComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamDungeon);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
