using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPetMiningTeam)]
    public class UIPetMiningTeamEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMiningTeam);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetMiningTeam, gameObject);

            ui.AddComponent<UIPetMiningTeamComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMiningTeam);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}