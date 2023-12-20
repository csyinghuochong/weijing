using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetEggChouKaComponent : Entity, IAwake,IDestroy
    {
        public GameObject Text_PetExploreLuckly;
        public GameObject Btn_ChouKaNumReward;
        public GameObject Text_TotalNumber;
        public GameObject Text_DiamondNumber;
        public GameObject Text_CostNumber;
        public GameObject ItemImageIcon;
        public GameObject Btn_ChouKaTen;
        public GameObject Btn_ChouKa;
        
        public List<string> AssetPath = new List<string>();
    }


    public class UIPetEggChouKaComponentAwakeSystem : AwakeSystem<UIPetEggChouKaComponent>
    {
        public override void Awake(UIPetEggChouKaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_PetExploreLuckly = rc.Get<GameObject>("Text_PetExploreLuckly");
            self.Btn_ChouKaNumReward = rc.Get<GameObject>("Btn_ChouKaNumReward");
            self.Text_TotalNumber = rc.Get<GameObject>("Text_TotalNumber");
            self.Text_DiamondNumber = rc.Get<GameObject>("Text_DiamondNumber");
            self.Text_CostNumber = rc.Get<GameObject>("Text_CostNumber");
            self.ItemImageIcon = rc.Get<GameObject>("ItemImageIcon");

            self.Btn_ChouKaNumReward.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ChouKaNumReward(); });
            self.Btn_ChouKaTen = rc.Get<GameObject>("Btn_ChouKaTen");
            ButtonHelp.AddListenerEx(self.Btn_ChouKaTen, () => { self.OnBtn_ChouKa(10).Coroutine(); });
            self.Btn_ChouKa = rc.Get<GameObject>("Btn_ChouKa");
            ButtonHelp.AddListenerEx(self.Btn_ChouKa, () => { self.OnBtn_ChouKa(1).Coroutine(); });
            self.UpdateMoney();
            self.OnUpdateInfo();
            //self.UpdateChouKaTime();
        }

    }
    public class UIPetEggChouKaComponentDestroy : DestroySystem<UIPetEggChouKaComponent>
    {
        public override void Destroy(UIPetEggChouKaComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }
    public static class UIPetEggChouKaComponentSystem
    {
        public static void OnBtn_ChouKaNumReward(this UIPetEggChouKaComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIPetEggChouKaReward).Coroutine();
        }

        public static void OnUpdateInfo(this UIPetEggChouKaComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int totalTimes = numericComponent.GetAsInt(NumericType.PetExploreNumber);
            self.Text_TotalNumber.GetComponent<Text>().text = $"今日累计次数：{totalTimes}";

            self.Text_PetExploreLuckly.GetComponent<Text>().text = $"{numericComponent.GetAsInt(NumericType.PetExploreLuckly)}";
        }

        public static void UpdateMoney(this UIPetEggChouKaComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;

            int needDimanond = int.Parse(GlobalValueConfigCategory.Instance.Get(40).Value.Split('@')[0]);
            self.Text_DiamondNumber.GetComponent<Text>().text = needDimanond.ToString();

            string[] itemInfo = GlobalValueConfigCategory.Instance.Get(39).Value.Split('@')[0].Split(';');
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, ItemConfigCategory.Instance.Get(int.Parse(itemInfo[0])).Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ItemImageIcon.GetComponent<Image>().sprite = sp;
            long haveNumber = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(int.Parse(itemInfo[0]));
            self.Text_CostNumber.GetComponent<Text>().text = haveNumber + "/" + itemInfo[1];
            self.Text_CostNumber.GetComponent<Text>().color = (haveNumber >= int.Parse(itemInfo[1])) ? Color.white : Color.red;
        }

        public static async ETTask OnBtn_ChouKa(this UIPetEggChouKaComponent self, int choukaType)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetLeftSpace() < choukaType)
            {
                FloatTipManager.Instance.ShowFloatTip("请预留足够的背包空间！");
                return;
            }
            if (bagComponent.GetPetHeXinLeftSpace() < choukaType)
            {
                FloatTipManager.Instance.ShowFloatTip("请清理一下宠物之核背包！");
                return;
            }

            string needItems = GlobalValueConfigCategory.Instance.Get(39).Value.Split('@')[0];
            if (choukaType == 1 && !self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem(needItems))
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_ItemNotEnoughError);
                return;
            }

            int needDimanond = int.Parse(GlobalValueConfigCategory.Instance.Get(40).Value.Split('@')[0]);
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (choukaType == 10 && userInfo.Diamond < needDimanond)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_DiamondNotEnoughError);
                return;
            }

            //Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            //int leftTime = 20 - unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Pet_ChouKa);
            //if (choukaType == 2 && leftTime <= 0)
            //{
            //    FloatTipManager.Instance.ShowFloatTip("已达到钻石抽卡最大次数");
            //    return;
            //}
            long instanceid = self.InstanceId;
            C2M_PetEggChouKaRequest m_ItemOperateWear = new C2M_PetEggChouKaRequest() { ChouKaType = choukaType };
            M2C_PetEggChouKaResponse r2c_roleEquip = (M2C_PetEggChouKaResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
            if (r2c_roleEquip.Error != 0 || instanceid != self.InstanceId)
            {
                return;
            }
            self.UpdateMoney();
            self.OnUpdateInfo();

            UI ui = await UIHelper.Create(self.DomainScene(), UIType.UICommonReward);
            ui.GetComponent<UICommonRewardComponent>().OnUpdateUI(r2c_roleEquip.ReardList);
        }

    }
}