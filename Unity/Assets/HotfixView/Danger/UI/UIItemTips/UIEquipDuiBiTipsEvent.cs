using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIEquipDuiBiTips)]
    public class UIEquipDuiBiTipsEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIEquipDuiBiTips);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIEquipDuiBiTips, gameObject);
            ui.AddComponent<UIEquipDuiBiTipsComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIEquipDuiBiTips);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }
    }
}
