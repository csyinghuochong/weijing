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
                " 1.活动开启后,所有12级以上玩家均可进入。\n 2.活动开启10分钟后将禁止所有玩家进入此地图。\n 3.在角斗场内,玩家将互相发起挑战,坚持到最后1名的玩家将会\n 获得丰厚奖励。\n 4.在同一个角斗场内,人数最多达到20人。\n 5.20:00活动结束,如果场内剩余多人,则按照当前最低排名发放奖励。");
        }

        public static  void On_Btn_HuoDong_Arena(this UICountryHuoDongComponent self)
        {
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "角斗场", "是否立即前往角斗场？", () =>
            {
                self.RequestEnterArena().Coroutine();
            }, null).Coroutine();
        }

        public static async ETTask RequestEnterArena(this UICountryHuoDongComponent self)
        {
            int errorCode = await ActivityTipHelper.RequestEnterArena(self.ZoneScene());
            if (errorCode == ErrorCore.ERR_Success)
            {
                self.OnBtn_Close();
            }
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
