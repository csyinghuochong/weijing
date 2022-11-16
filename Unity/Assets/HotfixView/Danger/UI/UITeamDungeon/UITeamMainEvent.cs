using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UITeamMain)]
    public class UITeamMainEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamMain);
            var bundleGameObject =await  ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITeamMain, gameObject);
            ui.AddComponent<UITeamMainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITeamMain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
