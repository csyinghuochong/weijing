using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIRoleQiangHuaTip)]
    public class UIRoleQiangHuaTipEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleQiangHuaTip);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRoleQiangHuaTip, gameObject);

            ui.AddComponent<UIRoleQiangHuaTipComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleQiangHuaTip);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}