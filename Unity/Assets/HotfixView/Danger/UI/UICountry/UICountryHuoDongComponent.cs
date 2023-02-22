using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICountryHuoDongComponent : Entity, IAwake
    {
        public GameObject Btn_HuoDong_ArenaJieShao;
        public GameObject Btn_HuoDong_Lingzhu;
        public GameObject Btn_HuoDong_Baozang;
        public GameObject Btn_HuoDong_LingzhuJieShao;
        public GameObject Btn_HuoDong_Arena;
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

            self.Btn_HuoDong_LingzhuJieShao = rc.Get<GameObject>("Btn_HuoDong_LingzhuJieShao");
            self.Btn_HuoDong_LingzhuJieShao.GetComponent<Button>().onClick.AddListener(() => { self.Btn_HuoDong_LingzhuJieShao(); });

            self.Btn_HuoDong_Arena = rc.Get<GameObject>("Btn_HuoDong_Arena");
            self.Btn_HuoDong_Arena.GetComponent<Button>().onClick.AddListener(() => { self.On_Btn_HuoDong_Arena(); });

            self.Btn_HuoDong_ArenaJieShao = rc.Get<GameObject>("Btn_HuoDong_ArenaJieShao");
            self.Btn_HuoDong_ArenaJieShao.GetComponent<Button>().onClick.AddListener(() => { self.On_Btn_HuoDong_ArenaJieShao().Coroutine(); });

        }
    }

    public static class UICountryHuoDongComponentSystem
    {
        public static void Btn_HuoDong_Lingzhu(this UICountryHuoDongComponent self) 
        {
            UITaskViewHelp.Instance.OnGoToNpc(self.ZoneScene(), 20000028);
            self.OnBtn_Close();
        }

        public static void Btn_HuoDong_LingzhuJieShao(this UICountryHuoDongComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UICountryHuoDongJieShao).Coroutine();
        }

        public static async ETTask On_Btn_HuoDong_ArenaJieShao(this UICountryHuoDongComponent self)
        {
             UI uI = await UIHelper.Create(self.DomainScene(), UIType.UICountryHuoDongJieShao);
             uI.GetComponent<UICountryHuoDongJieShaoComponent>().OnUpdateJieShao("角斗场规则",
                "活动暂时没开启\n  活动暂时没开启");
        }

        public static void On_Btn_HuoDong_Arena(this UICountryHuoDongComponent self)
        {
            UITaskViewHelp.Instance.OnGoToNpc(self.ZoneScene(), 20000027);
            self.OnBtn_Close();
        }

        public static void Btn_HuoDong_Baozang(this UICountryHuoDongComponent self)
        {
            UITaskViewHelp.Instance.OnGoToNpc(self.ZoneScene(), 20000035);
            self.OnBtn_Close();
        }

        public static void OnBtn_Close(this UICountryHuoDongComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UICountry);
        }

    }
}
