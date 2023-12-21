using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetXiLianLockSkill)]
    public class UIPetXiLianLockSkillEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetXiLianLockSkill);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetXiLianLockSkill, gameObject);
            ui.AddComponent<UIPetXiLianLockSkillComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetXiLianLockSkill);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}