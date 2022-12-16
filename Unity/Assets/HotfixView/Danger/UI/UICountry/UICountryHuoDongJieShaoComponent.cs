using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICountryHuoDongJieShaoComponent : Entity, IAwake
    {
        public GameObject BtnClose;
    }

    [ObjectSystem]
    public class UICountryHuoDongJieShaoComponentAwakeSystem : AwakeSystem<UICountryHuoDongJieShaoComponent>
    {

        public override void Awake(UICountryHuoDongJieShaoComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.BtnClose = rc.Get<GameObject>("BtnClose");
            self.BtnClose.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
        }
    }

    public static class UICountryHuoDongJieShaoComponentSystem
    {
        public static void OnBtn_Close(this UICountryHuoDongJieShaoComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UICountryHuoDongJieShao);
        }
    }
}
