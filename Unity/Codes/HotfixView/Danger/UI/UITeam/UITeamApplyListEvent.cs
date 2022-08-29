using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UITeamApplyList)]
    public class UITeamApplyListEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamApplyList);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITeamApplyList, gameObject);
            ui.AddComponent<UITeamApplyListComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamApplyList);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
