using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetEggChouKaProbExplainComponent: Entity, IAwake
    {
        public GameObject Btn_Close;
    }

    public class UIPetEggChouKaProbExplainComponentAwakeSystem: AwakeSystem<UIPetEggChouKaProbExplainComponent>
    {
        public override void Awake(UIPetEggChouKaProbExplainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
        }
    }

    public static class UIPetEggChouKaProbExplainComponentSystem
    {
        public static void OnBtn_Close(this UIPetEggChouKaProbExplainComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIPetEggChouKaProbExplain);
        }
    }
}