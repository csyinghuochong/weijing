using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIChouKaWarehouse)]
    public class UIChouKaWarehouseEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChouKaWarehouse);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIChouKaWarehouse, gameObject);

            ui.AddComponent<UIChouKaWarehouseComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChouKaWarehouse);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}