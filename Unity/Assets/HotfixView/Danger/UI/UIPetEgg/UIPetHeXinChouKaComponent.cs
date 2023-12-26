using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetHeXinChouKaComponent: Entity, IAwake, IDestroy
    {
        public GameObject ItemImageIcon10;
        public GameObject RewardItemListNode;
        public GameObject Btn_PetEggLucklyExplain;
        public GameObject Btn_RolePetHeXin;
        public GameObject Btn_ChouKaNumReward;
        public GameObject Text_TotalNumber;
        public GameObject Text_DiamondNumber;
        public GameObject Text_CostNumber;
        public GameObject ItemImageIcon;
        public GameObject Btn_ChouKaTen;
        public GameObject Btn_ChouKa;

        public List<string> AssetPath = new List<string>();
    }

    public class UIPetHeXinChouKaComponentAwakeSystem: AwakeSystem<UIPetHeXinChouKaComponent>
    {
        public override void Awake(UIPetHeXinChouKaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemImageIcon10 = rc.Get<GameObject>("ItemImageIcon10");
            self.RewardItemListNode = rc.Get<GameObject>("RewardItemListNode");
            self.Btn_PetEggLucklyExplain = rc.Get<GameObject>("Btn_PetEggLucklyExplain");
            self.Btn_ChouKaNumReward = rc.Get<GameObject>("Btn_ChouKaNumReward");
            self.Text_TotalNumber = rc.Get<GameObject>("Text_TotalNumber");
            self.Text_DiamondNumber = rc.Get<GameObject>("Text_DiamondNumber");
            self.Text_CostNumber = rc.Get<GameObject>("Text_CostNumber");
            self.ItemImageIcon = rc.Get<GameObject>("ItemImageIcon");

            self.Btn_PetEggLucklyExplain.GetComponent<Button>().onClick.AddListener(() =>
            {
                UIHelper.Create(self.ZoneScene(), UIType.UIPetHeXinChouKaProbExplain).Coroutine();
            });
            self.Btn_ChouKaNumReward.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ChouKaNumReward(); });
            self.Btn_ChouKaTen = rc.Get<GameObject>("Btn_ChouKaTen");
            ButtonHelp.AddListenerEx(self.Btn_ChouKaTen, () => { self.OnBtn_ChouKa(10).Coroutine(); });
            self.Btn_ChouKa = rc.Get<GameObject>("Btn_ChouKa");
            ButtonHelp.AddListenerEx(self.Btn_ChouKa, () => { self.OnBtn_ChouKa(1).Coroutine(); });

            self.Btn_RolePetHeXin = rc.Get<GameObject>("Btn_RolePetHeXin");
            self.Btn_RolePetHeXin.GetComponent<Button>().onClick.AddListener(self.OnBtn_RolePetHeXin);

            self.UpdateMoney();
            self.OnUpdateInfo();
            self.UpdateReward();
        }
    }

    public class UIPetHeXinChouKaComponentDestroy: DestroySystem<UIPetHeXinChouKaComponent>
    {
        public override void Destroy(UIPetHeXinChouKaComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }

    public static class UIPetHeXinChouKaComponentSystem
    {
        public static void UpdateReward(this UIPetHeXinChouKaComponent self)
        {
            UICommonHelper.ShowItemList(ConfigHelper.PetHeXinChouKaRewardItemShow, self.RewardItemListNode, self, 0.8f);
        }

        public static void OnBtn_ChouKaNumReward(this UIPetHeXinChouKaComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIPetHeXinChouKaReward).Coroutine();
        }

        public static void OnUpdateInfo(this UIPetHeXinChouKaComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int totalTimes = numericComponent.GetAsInt(NumericType.PetHeXinExploreNumber);
            self.Text_TotalNumber.GetComponent<Text>().text = $"今日累计次数：{totalTimes}";
        }

        public static void UpdateMoney(this UIPetHeXinChouKaComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;

            string[] itemInfo10 = GlobalValueConfigCategory.Instance.Get(111).Value.Split('@')[0].Split(';');
            string path1 = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, ItemConfigCategory.Instance.Get(int.Parse(itemInfo10[0])).Icon);
            Sprite sp1 = ResourcesComponent.Instance.LoadAsset<Sprite>(path1);
            if (!self.AssetPath.Contains(path1))
            {
                self.AssetPath.Add(path1);
            }

            self.ItemImageIcon10.GetComponent<Image>().sprite = sp1;
            int exlporeNumber = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>()
                    .GetAsInt(NumericType.PetHeXinExploreNumber);
            string[] set = GlobalValueConfigCategory.Instance.Get(112).Value.Split(';');
            float discount;
            if (exlporeNumber < int.Parse(set[0]))
            {
                discount = 1;
            }
            else
            {
                discount = float.Parse(set[1]);
            }

            long haveNumber10 = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(int.Parse(itemInfo10[0]));
            self.Text_DiamondNumber.GetComponent<Text>().text = $"{haveNumber10}/{(int)(int.Parse(itemInfo10[1]) * discount)}";
            self.Text_DiamondNumber.GetComponent<Text>().color = haveNumber10 >= (int)(int.Parse(itemInfo10[1]) * discount)? Color.white : Color.red;

            string[] itemInfo1 = GlobalValueConfigCategory.Instance.Get(110).Value.Split('@')[0].Split(';');
            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, ItemConfigCategory.Instance.Get(int.Parse(itemInfo1[0])).Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }

            self.ItemImageIcon.GetComponent<Image>().sprite = sp;
            long haveNumber1 = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(int.Parse(itemInfo1[0]));
            self.Text_CostNumber.GetComponent<Text>().text = haveNumber1 + "/" + itemInfo1[1];
            self.Text_CostNumber.GetComponent<Text>().color = (haveNumber1 >= int.Parse(itemInfo1[1]))? Color.white : Color.red;
        }

        public static void OnBtn_RolePetHeXin(this UIPetHeXinChouKaComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIPetHeXinHeCheng).Coroutine();
        }

        public static async ETTask OnBtn_ChouKa(this UIPetHeXinChouKaComponent self, int choukaType)
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

            string needItems = GlobalValueConfigCategory.Instance.Get(110).Value.Split('@')[0];
            if (choukaType == 1 && !self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem(needItems))
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_ItemNotEnoughError);
                return;
            }

            string[] itemInfo10 = GlobalValueConfigCategory.Instance.Get(111).Value.Split('@')[0].Split(';');
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int exlporeNumber = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>()
                    .GetAsInt(NumericType.PetExploreNumber);
            string[] set = GlobalValueConfigCategory.Instance.Get(112).Value.Split(';');
            float discount;
            if (exlporeNumber < int.Parse(set[0]))
            {
                discount = 1;
            }
            else
            {
                discount = float.Parse(set[1]);
            }
            long haveNumber10 = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(int.Parse(itemInfo10[0]));
            if (choukaType == 10 && haveNumber10 < (int)(int.Parse(itemInfo10[1]) * discount))
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_ItemNotEnoughError);
                return;
            }

            long instanceid = self.InstanceId;
            C2M_PetHeXinChouKaRequest m_ItemOperateWear = new C2M_PetHeXinChouKaRequest() { ChouKaType = choukaType };
            M2C_PetHeXinChouKaResponse r2c_roleEquip =
                    (M2C_PetHeXinChouKaResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
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