using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [Timer(TimerType.UIChouKaTimer)]
    public class UIChouKaTimer : ATimer<UIChouKaComponent>
    {
        public override void Run(UIChouKaComponent self)
        {
            try
            {
                self.OnUpdateMianFeiTime();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIChouKaComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_TotalNumber;
        public GameObject Text_MianFeiTime_2;
        public GameObject Text_MianFeiTime_1;
        public GameObject Text_Chapter;
        public GameObject TextTenCost;
        public GameObject TextOneCost;
        public GameObject ButtonClose;
        public GameObject Btn_ZhangJieXuanZe;
        public GameObject Btn_ChouKaNumReward;
        public GameObject chouKaShowItemNode;
        public GameObject Btn_ChouKaTen;
        public GameObject Btn_ChouKaOne;
        public GameObject Btn_AddZuanShi;
        public GameObject Lab_Gold;
        public GameObject Lab_ZuanShi;

        public int TakeCardId;
        public List<UI> DropShowList;
        public UI UIChouKaChapterSelect;

        public long Timer;
    }

    [ObjectSystem]
    public class UIChouKaComponentAwakeSystem : AwakeSystem<UIChouKaComponent>
    {
        public override void Awake(UIChouKaComponent self)
        {
            self.DropShowList = new List<UI>();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_TotalNumber = rc.Get<GameObject>("Text_TotalNumber");
            self.Text_MianFeiTime_2 = rc.Get<GameObject>("Text_MianFeiTime_2");
            self.Text_MianFeiTime_1 = rc.Get<GameObject>("Text_MianFeiTime_1");

            self.Text_Chapter = rc.Get<GameObject>("Text_Chapter");
            self.TextTenCost = rc.Get<GameObject>("TextTenCost");
            self.TextOneCost = rc.Get<GameObject>("TextOneCost");

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonClose(); });

            self.Btn_ZhangJieXuanZe = rc.Get<GameObject>("Btn_ZhangJieXuanZe");
            self.Btn_ZhangJieXuanZe.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhangJieXuanZe(); });

            self.Btn_ChouKaNumReward = rc.Get<GameObject>("Btn_ChouKaNumReward");
            self.Btn_ChouKaNumReward.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ChouKaNumReward(); });

            self.chouKaShowItemNode = rc.Get<GameObject>("chouKaShowItemNode");

            self.Btn_ChouKaTen = rc.Get<GameObject>("Btn_ChouKaTen");
            self.Btn_ChouKaTen.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ChouKaOne(10).Coroutine(); });
            self.Btn_ChouKaOne = rc.Get<GameObject>("Btn_ChouKaOne");
            self.Btn_ChouKaOne.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ChouKaOne(1).Coroutine(); });
            self.Btn_AddZuanShi = rc.Get<GameObject>("Btn_AddZuanShi");
            self.Btn_AddZuanShi.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_AddZuanShi(); });

            GameObject uiChouKaChapterSelect = rc.Get<GameObject>("UIChouKaChapterSelect");
            self.UIChouKaChapterSelect = self.AddChild<UI, string, GameObject>( "UIChouKaChapterSelect", uiChouKaChapterSelect);
            self.UIChouKaChapterSelect.AddComponent<UIChouKaChapterSelectComponent>();
            self.UIChouKaChapterSelect.GameObject.SetActive(false);
            self.UIChouKaChapterSelect.GetComponent<UIChouKaChapterSelectComponent>().SetClickHandler((int cid) => { self.OnSelectChapterID(cid); });

            self.Lab_Gold = rc.Get<GameObject>("Lab_Gold");
            self.Lab_ZuanShi = rc.Get<GameObject>("Lab_ZuanShi");

            self.OnSelectChapterID(1001);
            self.OnUpdateUI();

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000,TimerType.UIChouKaTimer, self);
            DataUpdateComponent.Instance.AddListener(DataType.UpdateRoleData, self);
        }
    }


    [ObjectSystem]
    public class UIChouKaComponentDestroySystem : DestroySystem<UIChouKaComponent>
    {
        public override void Destroy(UIChouKaComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            DataUpdateComponent.Instance.RemoveListener(DataType.UpdateRoleData, self);
        }
    }

    public static class UIChouKaComponentSystem
    {

        public static void OnButtonClose(this UIChouKaComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIChouKa);
        }

        public static void OnSelectChapterID(this UIChouKaComponent self, int chapterid)
        {
            self.TakeCardId = chapterid;

            self.OnUpdateCost();
            self.UpdateReardShowList();
        }

        public static void  UpdateReardShowList(this UIChouKaComponent self)
        {
            int cindex = self.TakeCardId % 1000;
            self.Text_Chapter.GetComponent<Text>().text = string.Format("第{0}章探宝", cindex);
            UICommonHelper.DestoryChild(self.chouKaShowItemNode);

            TakeCardConfig takeCardConfig = TakeCardConfigCategory.Instance.Get(self.TakeCardId);
            string dropShow = takeCardConfig.DropShow;
            List<RewardItem> droplist = new List<RewardItem>();
            droplist = DropHelper.DropIDToShowItem(takeCardConfig.DropID, 5);
            string itemList = "";
            for (int i = 0; i < droplist.Count; i++)
            {
                itemList = itemList + $"{droplist[i].ItemID};{1}@";
            }
            //itemList = itemList.Substring(0, itemList.Length - 1);
            itemList = itemList + dropShow;
            UICommonHelper.ShowItemList(itemList, self.chouKaShowItemNode, self, 0.8f).Coroutine();
        }

        public static void OnBtn_ZhangJieXuanZe(this UIChouKaComponent self)
        {
            self.UIChouKaChapterSelect.GameObject.SetActive(true);
        }

        public static void OnBtn_ChouKaNumReward(this UIChouKaComponent self)
        {
            UIHelper.Create( self.ZoneScene(), UIType.UIChouKaReward ).Coroutine();
        }

        public static async ETTask ShowRewardView(this UIChouKaComponent self, List<RewardItem> rewardItems)
        {
            UI ui = await UIHelper.Create(self.DomainScene(), UIType.UICommonReward);
            ui.GetComponent<UICommonRewardComponent>().OnUpdateUI(rewardItems);
        }

        public static async ETTask OnBtn_ChouKaOne(this UIChouKaComponent self, int times)
        {
            C2M_ChouKaRequest m_ItemOperateWear = new C2M_ChouKaRequest() { ChapterId = self.TakeCardId, ChouKaType = times };
            M2C_ChouKaResponse r2c_roleEquip = (M2C_ChouKaResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
            if (r2c_roleEquip.Error != 0)
            {
                return;
            }

            self.OnUpdateUI();
            self.ShowRewardView(r2c_roleEquip.RewardList).Coroutine();
        }

        public static void OnUpdateRoleData(this UIChouKaComponent self, string updateType)
        {
            UserDataType userDataType = (UserDataType)int.Parse(updateType.Split('_')[0]);
            if (userDataType == UserDataType.Diamond)
            {
                self.OnUpdateDiamond();
            }
        }

        public static void OnUpdateDiamond(this UIChouKaComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            self.Lab_Gold.GetComponent<Text>().text = userInfoComponent.UserInfo.Gold.ToString();
            self.Lab_ZuanShi.GetComponent<Text>().text = userInfoComponent.UserInfo.Diamond.ToString();
        }

        public static void OnUpdateCost(this UIChouKaComponent self)
        {
            TakeCardConfig takeCardConfig = TakeCardConfigCategory.Instance.Get(self.TakeCardId);
            self.TextOneCost.GetComponent<Text>().text = takeCardConfig.ZuanShiNum.ToString();
            self.TextTenCost.GetComponent<Text>().text = takeCardConfig.ZuanShiNum_Ten.ToString();
        }

        public static void OnUpdateTotalTime(this UIChouKaComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int totalTimes = numericComponent.GetAsInt(NumericType.ChouKa);
            self.Text_TotalNumber.GetComponent<Text>().text = $"今日累计次数：{totalTimes}";
        }

        public static void OnUpdateMianFeiTime(this UIChouKaComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long curTime = TimeHelper.ServerNow();
            long passTime_1 = curTime - numericComponent.GetAsLong(NumericType.ChouKaOneTime);
            long passTime_2 = curTime - numericComponent.GetAsLong(NumericType.ChouKaTenTime);
            long cdTime_1 = long.Parse(GlobalValueConfigCategory.Instance.Get(35).Value) * 1000;
            long cdTime_2 = long.Parse(GlobalValueConfigCategory.Instance.Get(36).Value) * 1000;
            self.Text_MianFeiTime_1.GetComponent<Text>().text = passTime_1 > cdTime_1 ? "免费抽卡" : TimeHelper.ShowLeftTime(cdTime_1 - passTime_1);
            self.Text_MianFeiTime_2.GetComponent<Text>().text = passTime_2 > cdTime_2 ? "免费抽卡" : TimeHelper.ShowLeftTime(cdTime_2 - passTime_2);
        }

        public static void OnUpdateUI(this UIChouKaComponent self)
        {
            self.OnUpdateDiamond();
            self.OnUpdateTotalTime();
            self.OnUpdateMianFeiTime();
        }

        public static void OnBtn_AddZuanShi(this UIChouKaComponent self)
        {

        }
    }
}
