using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UITeamDungeonCreate)]
    public class UITeamDungeonCreateEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamDungeonCreate);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UITeamDungeonCreate, gameObject);
            ui.AddComponent<UITeamDungeonCreateComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamDungeonCreate);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
