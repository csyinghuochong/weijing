using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetEquipMake)]
    public class UIPetEquipMakeEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetEquipMake);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetEquipMake, gameObject);

            ui.AddComponent<UIPetEquipMakeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetEquipMake);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}