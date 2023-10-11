using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPetMiningReward)]
    public class UIPetMiningRewardEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMiningReward);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetMiningReward, gameObject);

            ui.AddComponent<UIPetMiningRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMiningReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}