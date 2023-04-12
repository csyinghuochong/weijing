using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UICellDungeonSettlementComponent : Entity, IAwake, IUpdate
    {

        public GameObject closeButton;
        public GameObject Text_LeftTime;
        public GameObject SelectEffectSet;
        public GameObject Star_3_OK;
        public GameObject Star_2_OK;
        public GameObject Star_1_OK;

        public GameObject Star_3_liang;
        public GameObject Star_2_liang;
        public GameObject Star_1_liang;

        public GameObject Button_continue;
        public GameObject Button_exit;

        public GameObject Text_gold;
        public GameObject Text_exp;

        public GameObject Obj_SelectEffect;

        public List<UISettlementRewardComponent> RewardUIList = new List<UISettlementRewardComponent>();

        public int LeftTime;
        public float Timer;

        public int GetPassTime = 0;

        public bool topSelect = false;
        public bool bottomSelect = false;
    }


    public class UILevelSettlementComponentAwakeSystem : AwakeSystem<UICellDungeonSettlementComponent>
    {
        public override void Awake(UICellDungeonSettlementComponent self)
        {
            self.GetPassTime = 0;
            self.topSelect = false;
            self.bottomSelect = false;

            self.RewardUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.closeButton = rc.Get<GameObject>("closeButton");
            self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseButton(); });

            self.Text_LeftTime = rc.Get<GameObject>("Text_LeftTime");
            self.SelectEffectSet = rc.Get<GameObject>("SelectEffectSet");

            self.Star_3_OK = rc.Get<GameObject>("Star_3_OK");
            self.Star_2_OK = rc.Get<GameObject>("Star_2_OK");
            self.Star_1_OK = rc.Get<GameObject>("Star_1_OK");

            self.Star_3_liang = rc.Get<GameObject>("Star_3_liang");
            self.Star_2_liang = rc.Get<GameObject>("Star_2_liang");
            self.Star_1_liang = rc.Get<GameObject>("Star_1_liang");
            self.Star_1_liang.SetActive(false);
            self.Star_2_liang.SetActive(false);
            self.Star_3_liang.SetActive(false);

            self.Button_continue = rc.Get<GameObject>("Button_continue");
            self.Button_exit = rc.Get<GameObject>("Button_exit");

            self.Text_gold = rc.Get<GameObject>("Text_gold");
            self.Text_exp = rc.Get<GameObject>("Text_exp");

            self.Obj_SelectEffect  = rc.Get<GameObject>("SelectEffectSet");
            self.Obj_SelectEffect.SetActive(false);

            for (int i = 0; i < 6; i++)
            {
                GameObject cellitem = rc.Get<GameObject>("UISettlementReward" + (i+1).ToString());
                UISettlementRewardComponent uISettlementRewardComponent = self.AddChild<UISettlementRewardComponent, GameObject>(cellitem);
                uISettlementRewardComponent.SetClickHandler((int index) => { self.OnClickRewardItem(index).Coroutine(); }, i);
                self.RewardUIList.Add(uISettlementRewardComponent);
            }

            self.Button_continue.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonContinue(); });
            self.Button_exit.GetComponent<Button>().onClick.AddListener(() => { self.OnExitButton(); });
            self.Timer = 0;
            self.LeftTime = 10;
        }
    }



    public class UILevelSettlementComponentUpdateSystem : UpdateSystem<UICellDungeonSettlementComponent>
    {
        public override void Update(UICellDungeonSettlementComponent self)
        {
            self.Timer += Time.deltaTime;
            if (self.Timer < 1f)
                return;
            self.Timer = 0;
            self.Check();
        }
    }

    public static class UILevelSettlementComponentSystem
    {

        public static void Check(this UICellDungeonSettlementComponent self)
        {
            self.LeftTime--;
            if (self.LeftTime < 0)
                self.OnCheckGetReward();
            else
                self.Text_LeftTime.GetComponent<Text>().text = string.Format("选择剩余时间:{0}秒", self.LeftTime);

            if (self.topSelect && self.bottomSelect)
            {
                self.GetPassTime++;
            }
        }

        public static void OnCloseButton(this UICellDungeonSettlementComponent self)
        {
            if (self.GetPassTime <= 3)
            {
                return;
            }

            UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonSettlement);
        }

        public static void OnExitButton(this UICellDungeonSettlementComponent self)
        {
            EnterFubenHelp.RequestQuitFuben(self.DomainScene());
            UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonSettlement);
        }


        public static void OnCheckGetReward(this UICellDungeonSettlementComponent self)
        {
            if (self.topSelect && self.bottomSelect)
            {
                return;
            }

            //默认选中第一个
            if (!self.topSelect)
            {
                self.RewardUIList[0].OnClickItem();
            }
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (!self.bottomSelect && unit.IsYueKaStates())
            {
                self.RewardUIList[3].OnClickItem();
            }
        }

        public static async ETTask OnClickRewardItem(this UICellDungeonSettlementComponent self, int index)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (index >= 3 && !unit.IsYueKaStates())
            {
                FloatTipManager.Instance.ShowFloatTip("周卡用户才能开启！");
                return;
            }

            UISettlementRewardComponent select = self.RewardUIList[index];
            UICommonHelper.SetParent(self.SelectEffectSet, select.GameObject);
            self.SelectEffectSet.SetActive(true);
            RewardItem rewardItem = select.RewardItem;
            Actor_GetFubenRewardRequest actor_GetFubenRewardRequest = new Actor_GetFubenRewardRequest() { RewardItem = rewardItem };
            Actor_GetFubenRewardReponse r2c_Reward = (Actor_GetFubenRewardReponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(actor_GetFubenRewardRequest);

            if (!self.topSelect) self.topSelect = index < 3;
            if (!self.bottomSelect) self.bottomSelect = index >= 3;

            //屏蔽点击
            int startIndex = select.Index < 3 ? 0 : 3;
            for (int i = startIndex; i < startIndex+3; i++)
            {
                self.RewardUIList[i].DisableClick();
            }
        }

        public static void OnButtonContinue(this UICellDungeonSettlementComponent self)
        {
            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.PiLao <= 0)
            {
                FloatTipManager.Instance.ShowFloatTip("体力不足!");
                return;
            }
            int chapterId = self.ZoneScene().GetComponent<CellDungeonComponent>().ChapterId;
            int difficulty = self.ZoneScene().GetComponent<CellDungeonComponent>().FubenDifficulty;
            EnterFubenHelp.EnterFubenRequest(self.DomainScene(), difficulty, chapterId, 1).Coroutine();
            UIHelper.Remove(self.DomainScene(), UIType.UICellDungeonSettlement);
        }

        public static async ETTask OnUpdateUI(this UICellDungeonSettlementComponent self, M2C_FubenSettlement m2C_FubenSettlement)
        {
            self.Text_exp.GetComponent<Text>().text = m2C_FubenSettlement.RewardExp.ToString();
            self.Text_gold.GetComponent<Text>().text = m2C_FubenSettlement.RewardGold.ToString();

            self.Star_3_OK.SetActive(m2C_FubenSettlement.StarInfos[2] == 1);
            self.Star_2_OK.SetActive(m2C_FubenSettlement.StarInfos[1] == 1);
            self.Star_1_OK.SetActive(m2C_FubenSettlement.StarInfos[0] == 1);

            //奖励列表
            for (int i = 0; i < m2C_FubenSettlement.ReardList.Count; i++)
            {
                self.RewardUIList[i].OnUpdateData(m2C_FubenSettlement.ReardList[i]);
            }
            for (int i = 0; i < m2C_FubenSettlement.ReardListExcess.Count; i++)
            {
                self.RewardUIList[i+3].OnUpdateData(m2C_FubenSettlement.ReardListExcess[i]);
            }

            long instanceid = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(1000);
            if (instanceid != self.InstanceId)
                return;
            self.Star_1_liang.SetActive(m2C_FubenSettlement.StarInfos[0] == 1);
            await TimerComponent.Instance.WaitAsync(1000);
            if (instanceid != self.InstanceId)
                return;
            self.Star_2_liang.SetActive(m2C_FubenSettlement.StarInfos[1] == 1);
            await TimerComponent.Instance.WaitAsync(1000);
            if (instanceid != self.InstanceId)
                return;
            self.Star_3_liang.SetActive(m2C_FubenSettlement.StarInfos[2] == 1);
        }
    }
}
