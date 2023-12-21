using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetEggLucklyExplainComponent: Entity, IAwake
    {
        public GameObject Btn_Close;
    }

    public class UIPetEggLucklyExplainComponentAwakeSystem: AwakeSystem<UIPetEggLucklyExplainComponent>
    {
        public override void Awake(UIPetEggLucklyExplainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
        }
    }

    public static class UIPetEggLucklyExplainComponentSystem
    {
        public static void OnBtn_Close(this UIPetEggLucklyExplainComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIPetEggLucklyExplain);
        }
    }
}