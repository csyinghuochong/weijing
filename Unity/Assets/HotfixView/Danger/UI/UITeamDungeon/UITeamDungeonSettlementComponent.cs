using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
  
    public class UITeamDungeonSettlementComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_LeftTime;

        public GameObject SettlementRward2;
        public GameObject SettlementRward1;
        public GameObject SettlementItem;

        public GameObject SelectEffectSet;
        public GameObject Text_PassTime;
        public GameObject Button_exit;
        public GameObject Img_back2;

        public List<UITeamDungeonSettlementPlayerComponent> PlayerUIList = new List<UITeamDungeonSettlementPlayerComponent>();
        public List<UISettlementRewardComponent> RewardUIList = new List<UISettlementRewardComponent>();

        public int LeftTime;
        public bool IfLingQuStatus;
        public long SendGetTime;
    }

    [ObjectSystem]
    public class UITeamDungeonSettlementComponentDestroySystem : DestroySystem<UITeamDungeonSettlementComponent>
    {
        public override void Destroy(UITeamDungeonSettlementComponent self)
        {
        }
    }

    [ObjectSystem]
    public class UITeamDungeonSettlementComponentAwakeSystem : AwakeSystem<UITeamDungeonSettlementComponent>
    {

        public override void Awake(UITeamDungeonSettlementComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            
            self.Text_LeftTime = rc.Get<GameObject>("Text_LeftTime");

            self.SelectEffectSet = rc.Get<GameObject>("SelectEffectSet");
            self.SelectEffectSet.SetActive(false);

            self.SendGetTime = 0;
            self.RewardUIList.Clear();
            self.SettlementRward1 = rc.Get<GameObject>("SettlementRward1");
            self.SettlementRward1.SetActive(false);
            for (int i = 0; i < 3; i++)
            {
                GameObject cellitem = GameObject.Instantiate(self.SettlementRward1);
                cellitem.SetActive(true);
                UICommonHelper.SetParent(cellitem, self.SettlementRward1.transform.parent.gameObject);

                UISettlementRewardComponent uISettlementRewardComponent = self.AddChild<UISettlementRewardComponent, GameObject>(cellitem);
                uISettlementRewardComponent.SetClickHandler((int index) => { self.OnClickRewardItem(index).Coroutine(); }, i);
                self.RewardUIList.Add(uISettlementRewardComponent);
            }
            self.SettlementRward2 = rc.Get<GameObject>("SettlementRward2");
            self.SettlementRward2.SetActive(false);
            for (int i = 3; i < 6; i++)
            {
                GameObject cellitem = GameObject.Instantiate(self.SettlementRward2);
                cellitem.SetActive(true);
                UICommonHelper.SetParent(cellitem, self.SettlementRward2.transform.parent.gameObject);

                UISettlementRewardComponent uISettlementRewardComponent = self.AddChild<UISettlementRewardComponent, GameObject>(cellitem);
                uISettlementRewardComponent.SetClickHandler((int index) => { self.OnClickRewardItem(index).Coroutine(); }, i);
                self.RewardUIList.Add(uISettlementRewardComponent);
            }

            self.PlayerUIList.Clear();
            self.SettlementItem = rc.Get<GameObject>("SettlementItem");
            self.SettlementItem.gameObject.SetActive(false);
            for (int i = 0; i < 3; i++)
            {
                GameObject cellitem = GameObject.Instantiate(self.SettlementItem);
                cellitem.SetActive(true);
                UICommonHelper.SetParent(cellitem, self.SettlementItem.transform.parent.gameObject);
                UITeamDungeonSettlementPlayerComponent uISettlementRewardComponent = self.AddChild<UITeamDungeonSettlementPlayerComponent, GameObject>(cellitem);
                self.PlayerUIList.Add(uISettlementRewardComponent);
            }

            self.Button_exit = rc.Get<GameObject>("Button_exit");
            ButtonHelp.AddListenerEx(self.Button_exit, ()=> { self.OnButton_exit();  });

            self.Img_back2 = rc.Get<GameObject>("Img_back2");
            ButtonHelp.AddListenerEx(self.Img_back2, () => { self.OnButton_exit(); });

            self.IfLingQuStatus = false;
            self.BeingTimer().Coroutine();
        }
    }

    public static class UITeamDungeonSettlementComponentSystem
    {
        public static async ETTask BeingTimer(this UITeamDungeonSettlementComponent self)
        {
            long instanceIds = self.InstanceId;
            for (int i = 10;  i >= 0; i-- )
            {
                self.OnUpdate(i);
                await TimerComponent.Instance.WaitAsync(1000);
                if (instanceIds != self.InstanceId)
                {
                    break;
                }
            }
        }

        public static void OnUpdate(this UITeamDungeonSettlementComponent self, int leftTime)
        {
            self.LeftTime = leftTime;
            if (leftTime <= 0)
            {
                self.CheckSelfSelected();
                self.Text_LeftTime.SetActive(false);
                return;
            }
            self.Text_LeftTime.GetComponent<Text>().text = $"选择剩余时间:{leftTime}秒";
        }

        public static void CheckSelfSelected(this UITeamDungeonSettlementComponent self)
        {
            if (self.IfLingQuStatus)
            {
                return;
            }
            int index = -1;
            for (int i = 0; i < 3; i++)
            {
                if( self.RewardUIList[i].IsCanClicked())
                {
                    index = i;
                    break;
                }
            }
            self.IfLingQuStatus = true;
            if (index == -1)
            {
                return;
            }
            self.OnClickRewardItem(index).Coroutine();
        }

        public static void OnTeamDungeonBoxReward(this UITeamDungeonSettlementComponent self, M2C_TeamDungeonBoxRewardResult message)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum!= SceneTypeEnum.TeamDungeon)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITeamDungeonSettlement);
                return;
            }

            if (message.BoxIndex < 0 || message.BoxIndex >= self.RewardUIList.Count)
            {
                Log.Error($"message.BoxIndex : {message.BoxIndex}");
                return;
            }

            self.RewardUIList[message.BoxIndex].ShowRewardItem();
            long userId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            if (userId == message.UserId)
            {
                if (message.BoxIndex <= 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        self.RewardUIList[i].DisableClick();
                    }
                    self.IfLingQuStatus = true;
                    self.Text_LeftTime.SetActive(false);
                }
                else
                {
                    for (int i = 3; i < 6; i++)
                    {
                        self.RewardUIList[i].DisableClick();
                    }
                }
            }
        }

        public static async ETTask OnClickRewardItem(this UITeamDungeonSettlementComponent self, int index)
        {
            if (TimeHelper.ServerNow() - self.SendGetTime < 1000)
            {
                return;
            }
            self.SendGetTime = TimeHelper.ServerNow();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (index >= 3 && !unit.IsYueKaStates())
            {
                FloatTipManager.Instance.ShowFloatTip("月卡用户才能开启！");
                return;
            }

            UISettlementRewardComponent select = self.RewardUIList[index];
            self.SelectEffectSet.SetActive(true);
            UICommonHelper.SetParent(self.SelectEffectSet, select.GameObject);
            RewardItem rewardItem = select.RewardItem;

            C2M_TeamDungeonBoxRewardRequest actor_GetFubenRewardRequest = new C2M_TeamDungeonBoxRewardRequest() { BoxIndex = index, RewardItem = rewardItem };
            M2C_TeamDungeonBoxRewardResponse r2c_Reward = (M2C_TeamDungeonBoxRewardResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(actor_GetFubenRewardRequest);
        }

        public static void OnUpdateUI(this UITeamDungeonSettlementComponent self, M2C_TeamDungeonSettlement m2C_FubenSettlement)
        {
            //奖励列表
            for (int i = 0; i < m2C_FubenSettlement.ReardList.Count; i++)
            {
                self.RewardUIList[i].OnUpdateData(m2C_FubenSettlement.ReardList[i]);
            }
            for (int i = 0; i < m2C_FubenSettlement.ReardListExcess.Count; i++)
            {
                self.RewardUIList[i + 3].OnUpdateData(m2C_FubenSettlement.ReardListExcess[i]);
            }

            long idExtra = 0;
            int damageMax = 0;
            for (int i = 0; i < m2C_FubenSettlement.PlayerList.Count; i++)
            {
                if (m2C_FubenSettlement.PlayerList[i].Damage >= damageMax)
                {
                    damageMax = m2C_FubenSettlement.PlayerList[i].Damage;
                    idExtra = m2C_FubenSettlement.PlayerList[i].UserID;
                }
            }

            //伤害数据
            for (int i = 0; i < self.PlayerUIList.Count; i++)
            {
                if (i >= m2C_FubenSettlement.PlayerList.Count)
                {
                    self.PlayerUIList[i].GameObject.SetActive(false);
                    continue;
                }
                TeamPlayerInfo teamPlayerInfo = m2C_FubenSettlement.PlayerList[i];
                self.PlayerUIList[i].OnUpdateUI(teamPlayerInfo, idExtra == teamPlayerInfo.UserID ? m2C_FubenSettlement.RewardExtraItem : null);
            }
        }

        public static void OnButton_exit(this UITeamDungeonSettlementComponent self)
        {
            if (self.LeftTime > 5)
            {
                return;
            }

            //判断宝箱自己是否领取
            if (self.IfLingQuStatus == false) 
            {
                FloatTipManager.Instance.ShowFloatTip("请在右侧领取自己的战利品哦!");
                return;
            }

            //离开副本
            //EnterFubenHelp.QuitTeamDungeonRequest(self.DomainScene(), 1).Coroutine();
            UIHelper.Remove( self.DomainScene(), UIType.UITeamDungeonSettlement );
        }

    }
}
