using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICountryHuoDongComponent : Entity, IAwake
    {
        public GameObject Btn_HuoDong_Lingzhu;
        public GameObject Btn_HuoDong_Baozang;
    }

    [ObjectSystem]
    public class UICountryHuoDongComponentAwakeSystem : AwakeSystem<UICountryHuoDongComponent>
    {

        public override void Awake(UICountryHuoDongComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Btn_HuoDong_Lingzhu = rc.Get<GameObject>("Btn_HuoDong_Lingzhu");
            self.Btn_HuoDong_Lingzhu.GetComponent<Button>().onClick.AddListener(() => { self.Btn_HuoDong_Lingzhu(); });

            self.Btn_HuoDong_Baozang = rc.Get<GameObject>("Btn_HuoDong_Baozang");
            self.Btn_HuoDong_Baozang.GetComponent<Button>().onClick.AddListener(() => { self.Btn_HuoDong_Baozang(); });
        }
    }

    public static class UICountryHuoDongComponentSystem
    {
        public static void Btn_HuoDong_Lingzhu(this UICountryHuoDongComponent self) 
        {
            UITaskViewHelp.Instance.OnGoToNpc(self.ZoneScene(), 20000028);
            self.OnBtn_Close();
        }

        public static void Btn_HuoDong_Baozang(this UICountryHuoDongComponent self)
        {
            UITaskViewHelp.Instance.OnGoToNpc(self.ZoneScene(), 20000027);
            self.OnBtn_Close();
        }

        public static void OnBtn_Close(this UICountryHuoDongComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UICountry);
        }

    }
}
