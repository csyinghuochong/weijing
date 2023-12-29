using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleXiLianExplainComponent: Entity, IAwake
    {
        public GameObject Btn_Close;
    }

    public class UIXiLianExplainComponentAwakeSystem: AwakeSystem<UIRoleXiLianExplainComponent>
    {
        public override void Awake(UIRoleXiLianExplainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
        }
    }

    public static class UIXiLianExplainComponentSystem
    {
        public static void OnBtn_Close(this UIRoleXiLianExplainComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIRoleXiLianExplain);
        }
    }
}