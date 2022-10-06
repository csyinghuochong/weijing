using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UICreateRole)]
    public class UICreateRoleEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICreateRole);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UICreateRole, gameObject);

            ui.AddComponent<UICreateRoleComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICreateRole);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}
