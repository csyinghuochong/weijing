using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPetMiningRecord)]
    public class UIPetMiningRecordEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMiningRecord);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetMiningRecord, gameObject);

            ui.AddComponent<UIPetMiningRecordComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetMiningRecord);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}