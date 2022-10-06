using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIChouKaReward)]
    public class UIChouKaRewardEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChouKaReward);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIChouKaReward, gameObject);
            ui.AddComponent<UIChouKaRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChouKaReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
