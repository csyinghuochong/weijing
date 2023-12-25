using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetHeXinChouKaProbExplainComponent: Entity, IAwake
    {
        public GameObject Btn_Close;
    }

    public class UIPetHeXinChouKaProbExplainComponentAwakeSystem: AwakeSystem<UIPetHeXinChouKaProbExplainComponent>
    {
        public override void Awake(UIPetHeXinChouKaProbExplainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
        }
    }

    public static class UIPetHeXinChouKaProbExplainComponentSystem
    {
        public static void OnBtn_Close(this UIPetHeXinChouKaProbExplainComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIPetHeXinChouKaProbExplain);
        }
    }
}