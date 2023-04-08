
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIJiaYuanPetFeed)]
    public class UIJiaYuanPetFeedEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanPetFeed);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanPetFeed, gameObject);
            ui.AddComponent<UIJiaYuanPetFeedComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanPetFeed);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
