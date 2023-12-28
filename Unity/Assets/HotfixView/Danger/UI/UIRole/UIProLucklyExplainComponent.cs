using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIProLucklyExplainComponent: Entity, IAwake
    {
        public GameObject Btn_Close;
    }

    public class UIProLucklyExplainComponentAwakeSystem: AwakeSystem<UIProLucklyExplainComponent>
    {
        public override void Awake(UIProLucklyExplainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
        }
    }

    public static class UIProLucklyExplainComponentSystem
    {
        public static void OnBtn_Close(this UIProLucklyExplainComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIProLucklyExplain);
        }
    }
}