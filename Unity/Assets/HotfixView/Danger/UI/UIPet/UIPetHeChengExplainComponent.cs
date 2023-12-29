using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetHeChengExplainComponent: Entity, IAwake
    {
        public GameObject Btn_Close;
    }

    public class UIPetHeChengExplainComponentAwakeSystem: AwakeSystem<UIPetHeChengExplainComponent>
    {
        public override void Awake(UIPetHeChengExplainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
        }
    }

    public static class UIPetHeChengExplainComponentSystem
    {
        public static void OnBtn_Close(this UIPetHeChengExplainComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIPetHeChengExplain);
        }
    }
}