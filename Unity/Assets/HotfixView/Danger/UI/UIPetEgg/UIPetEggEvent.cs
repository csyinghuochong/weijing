using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetEgg)]
    public class UIPetEggEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetEgg);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetEgg, gameObject);

            ui.AddComponent<UIPetEggComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetEgg);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
