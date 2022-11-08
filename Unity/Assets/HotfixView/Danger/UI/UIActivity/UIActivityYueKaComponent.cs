using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityYueKaComponent : Entity, IAwake
    {
        public GameObject TextYueKaCost;
        public GameObject Text_Remainingtimes;
        public GameObject ItemListNode;
        public GameObject Btn_GetReward;
        public GameObject Btn_OpenYueKa;
        public GameObject Img_JiHuo;
        public GameObject BtnOpenYueKaSet;
        public GameObject Btn_GoPay;
    }

    [ObjectSystem]
    public class UIActivityYueKaComponentAwakeSystem : AwakeSystem<UIActivityYueKaComponent>
    {
        public override void Awake(UIActivityYueKaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.TextYueKaCost = rc.Get<GameObject>("TextYueKaCost");
            self.Btn_OpenYueKa = rc.Get<GameObject>("Btn_OpenYueKa");
            self.Btn_OpenYueKa.GetComponent<Button>().onClick.AddListener(() => { self.OpenYueKa(); });
            self.Img_JiHuo = rc.Get<GameObject>("Img_JiHuo");
            self.BtnOpenYueKaSet = rc.Get<GameObject>("BtnOpenYueKaSet");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.Btn_GetReward = rc.Get<GameObject>("Btn_GetReward");
            self.Btn_GoPay = rc.Get<GameObject>("Btn_GoPay");
            self.Text_Remainingtimes = rc.Get<GameObject>("Text_Remainingtimes");

            ButtonHelp.AddListenerEx(self.Btn_GetReward, () => { self.ReceiveReward().Coroutine(); });
     
            self.OnUpdateUI();
            self.InitReward();
        }
    }

    public static class UIActivityYueKaComponentSystem
    {
        public static void OnUpdateUI(this UIActivityYueKaComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.IsYueKaStates())
            {
                self.Img_JiHuo.SetActive(true);
                self.BtnOpenYueKaSet.SetActive(false);
                self.Btn_GetReward.SetActive(true);
                self.Btn_GoPay.SetActive(true);
                self.Btn_OpenYueKa.SetActive(false);

                int leftDay = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.YueKaRemainTimes);
                self.Text_Remainingtimes.GetComponent<Text>().text = $"{leftDay}/7";
            }
            else 
            {
                self.Img_JiHuo.SetActive(false);
                self.BtnOpenYueKaSet.SetActive(true);
                self.Btn_GetReward.SetActive(false);
                self.Btn_GoPay.SetActive(false);
                self.Btn_OpenYueKa.SetActive(true);
                self.Text_Remainingtimes.GetComponent<Text>().text = $"0/7";
            }
        }

        public static void InitReward(this UIActivityYueKaComponent self)
        {
            string reward = GlobalValueConfigCategory.Instance.Get(28).Value;
            UICommonHelper.ShowItemList(reward, self.ItemListNode, self, 1f).Coroutine();

            self.TextYueKaCost.GetComponent<Text>().text = GlobalValueConfigCategory.Instance.Get(37).Value;
        }

        public static async ETTask ReceiveReward(this UIActivityYueKaComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (!unit.IsYueKaStates())
            {
                FloatTipManager.Instance.ShowFloatTip("请先开启月卡！");
                return;
            }

            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.YueKaAward) == 1)
            {
                //当天已领取
                FloatTipManager.Instance.ShowFloatTip("当天奖励已领取！");
                return;
            }
            C2M_YueKaRewardRequest c2M_RoleYueKaRequest = new C2M_YueKaRewardRequest() { };
            M2C_YueKaRewardResponse m2C_RoleYueKaResponse = (M2C_YueKaRewardResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RoleYueKaRequest);
            self.OnUpdateUI();
        }

        public static async ETTask ReqestOpenYueKa(this UIActivityYueKaComponent self)
        {
            C2M_YueKaOpenRequest c2M_RoleYueKaRequest = new C2M_YueKaOpenRequest() { };
            M2C_YueKaOpenResponse m2C_RoleYueKaResponse = (M2C_YueKaOpenResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RoleYueKaRequest);
            if (m2C_RoleYueKaResponse.Error == 0)
            {
                //月卡开启成功
                FloatTipManager.Instance.ShowFloatTipDi(GameSettingLanguge.LoadLocalization("月卡开启成功"));
                self.Img_JiHuo.SetActive(true);
                self.BtnOpenYueKaSet.SetActive(false);
                self.Btn_GetReward.SetActive(true);
                self.Btn_OpenYueKa.SetActive(true);
                self.Btn_GoPay.SetActive(true);
                self.OnUpdateUI();
            }
        }

        //开启月卡
        public static  void OpenYueKa(this UIActivityYueKaComponent self)
        {

            //判断自身是否有钻石
            string cost = GlobalValueConfigCategory.Instance.Get(37).Value;
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "开启月卡", $"是否花费{cost}钻石开启月卡?", () =>
           {
               self.ReqestOpenYueKa().Coroutine();
           }, null).Coroutine() ;

            
        }
    }
}
