using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICountryHuoDongComponent : Entity, IAwake
    {
        public GameObject Btn_HuoDong_1;
        public GameObject Btn_HuoDong_2;
    }

    [ObjectSystem]
    public class UICountryHuoDongComponentAwakeSystem : AwakeSystem<UICountryHuoDongComponent>
    {

        public override void Awake(UICountryHuoDongComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Btn_HuoDong_1 = rc.Get<GameObject>("Btn_HuoDong_1");
            self.Btn_HuoDong_2 = rc.Get<GameObject>("Btn_HuoDong_2");
            self.Btn_HuoDong_1.GetComponent<Button>().onClick.AddListener(() => { self.Go_HuoDong_1(); });
            self.Btn_HuoDong_2.GetComponent<Button>().onClick.AddListener(() => { self.Go_HuoDong_2(); });
        }
    }

    public static class UICountryHuoDongComponentSystem
    {
        public static void Go_HuoDong_1(this UICountryHuoDongComponent self) 
        {
            TaskViewHelp.Instance.OnGoToNpc(self.ZoneScene(), 1000024);
            self.OnBtn_Close();
        }

        public static void Go_HuoDong_2(this UICountryHuoDongComponent self)
        {
            TaskViewHelp.Instance.OnGoToNpc(self.ZoneScene(), 1000023);
            self.OnBtn_Close();
        }

        public static void OnBtn_Close(this UICountryHuoDongComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UICountry);
        }

    }
}
