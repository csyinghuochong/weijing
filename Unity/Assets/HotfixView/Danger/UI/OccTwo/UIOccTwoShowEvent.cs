using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIOccTwoShow)]
    public class UIOccTwoShowEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIOccTwoShow);
            var bundleGameObject =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIOccTwoShow, gameObject);

            ui.AddComponent<UIOccTwoShowComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIOccTwoShow);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
