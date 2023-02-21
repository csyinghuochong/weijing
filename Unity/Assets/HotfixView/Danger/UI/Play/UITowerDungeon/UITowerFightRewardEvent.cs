using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UITowerFightReward)]
    public class UITowerFightRewardEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerFightReward);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITowerFightReward, gameObject);
            ui.AddComponent<UITowerFightRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerFightReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
