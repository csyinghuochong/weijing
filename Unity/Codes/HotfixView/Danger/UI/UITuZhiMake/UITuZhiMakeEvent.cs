using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UITuZhiMake)]
    public class UITuZhiMakeEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITuZhiMake);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITuZhiMake, gameObject);
            ui.AddComponent<UITuZhiMakeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITuZhiMake);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }


    }
}
