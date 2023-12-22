using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChouKaProbExplainComponent: Entity, IAwake
    {
        public GameObject Btn_Close;
    }

    public class UIChouKaProbExplainComponentAwakeSystem: AwakeSystem<UIChouKaProbExplainComponent>
    {
        public override void Awake(UIChouKaProbExplainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
        }
    }

    public static class UIChouKaProbExplainComponentSystem
    {
        public static void OnBtn_Close(this UIChouKaProbExplainComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIChouKaProbExplain);
        }
    }
}