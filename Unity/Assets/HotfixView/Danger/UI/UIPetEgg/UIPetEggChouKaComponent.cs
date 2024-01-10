using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetEggChouKaComponent : Entity, IAwake,IDestroy
    {
        public GameObject RewardItemListNode;
        public GameObject Btn_PetEggLucklyExplain;
        public GameObject Btn_RolePetHeXin;
        public GameObject PetLucky;
        public GameObject Btn_RolePetBag;
        public GameObject PetEggLucklyExplainBtn;
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

            self.RewardItemListNode = rc.Get<GameObject>("RewardItemListNode");
            self.Btn_PetEggLucklyExplain = rc.Get<GameObject>("Btn_PetEggLucklyExplain");
            self.Btn_RolePetBag = rc.Get<GameObject>("Btn_RolePetBag");
            self.PetEggLucklyExplainBtn = rc.Get<GameObject>("PetEggLucklyExplainBtn");
            self.Text_PetExploreLuckly = rc.Get<GameObject>("Text_PetExploreLuckly");
            self.Btn_ChouKaNumReward = rc.Get<GameObject>("Btn_ChouKaNumReward");
            self.Text_TotalNumber = rc.Get<GameObject>("Text_TotalNumber");
            self.Text_DiamondNumber = rc.Get<GameObject>("Text_DiamondNumber");
            self.Text_CostNumber = rc.Get<GameObject>("Text_CostNumber");
            self.ItemImageIcon = rc.Get<GameObject>("ItemImageIcon");

            self.Btn_PetEggLucklyExplain.GetComponent<Button>().onClick.AddListener(()=>{UIHelper.Create(self.ZoneScene(),UIType.UIPetEggChouKaProbExplain).Coroutine();});
            self.Btn_RolePetBag.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_RolePetBag(); });
            self.PetEggLucklyExplainBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnPetEggLucklyExplainBtn(); });
            self.Btn_ChouKaNumReward.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ChouKaNumReward(); });
            self.Btn_ChouKaTen = rc.Get<GameObject>("Btn_ChouKaTen");
            ButtonHelp.AddListenerEx(self.Btn_ChouKaTen, () => { self.OnBtn_ChouKa(10).Coroutine(); });
            self.Btn_ChouKa = rc.Get<GameObject>("Btn_ChouKa");
            ButtonHelp.AddListenerEx(self.Btn_ChouKa, () => { self.OnBtn_ChouKa(1).Coroutine(); });

            self.Btn_RolePetHeXin = rc.Get<GameObject>("Btn_RolePetHeXin");
            self.Btn_RolePetHeXin.GetComponent<Button>().onClick.AddListener(self.OnBtn_RolePetHeXin);

            self.PetLucky = rc.Get<GameObject>("PetLucky");
            self.PetLucky.SetActive( true) ;

            self.UpdateMoney();
            self.OnUpdateInfo();
            self.UpdateReward();
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
        public static void UpdateReward(this UIPetEggChouKaComponent self)
        {
            UICommonHelper.ShowItemList(ConfigHelper.PetChouKaRewardItemShow, self.RewardItemListNode, self, 0.8f);
        }
        
        public static void OnBtn_RolePetBag(this UIPetEggChouKaComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIRolePetBag).Coroutine();
        }
        public static void OnPetEggLucklyExplainBtn(this UIPetEggChouKaComponent self)
        {
            UIHelper.Create(self.ZoneScene(),UIType.UIPetEggLucklyExplain).Coroutine();
        }
        
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
            int exlporeNumber = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.PetExploreNumber);
            string[] set = GlobalValueConfigCategory.Instance.Get(107).Value.Split(';');
            float discount;
            if (exlporeNumber < int.Parse(set[0]))
            {
                discount = 1;
            }
            else
            {
                discount = float.Parse(set[1]);
            }
            self.Text_DiamondNumber.GetComponent<Text>().text = ((int)(needDimanond * discount)).ToString();

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

        public static  void OnBtn_RolePetHeXin(this UIPetEggChouKaComponent self)
        {
            UIHelper.Create( self.ZoneScene(), UIType.UIPetHeXinHeCheng ).Coroutine();
        }

        public static async ETTask OnBtn_ChouKa(this UIPetEggChouKaComponent self, int choukaType)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftSpace() < choukaType)
            {
                FloatTipManager.Instance.ShowFloatTip("请预留足够的背包空间！");
                return;
            }
            if (bagComponent.GetPetHeXinLeftSpace() < choukaType)
            {
                FloatTipManager.Instance.ShowFloatTip("请清理一下宠物之核背包！");
                return;
            }
            if (self.ZoneScene().GetComponent<PetComponent>().RolePetBag.Count >= GlobalValueConfigCategory.Instance.Get(119).Value2)
            {
                FloatTipManager.Instance.ShowFloatTip("请及时清理探索宠物仓库！");
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
            int exlporeNumber = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.PetExploreNumber);
            string[] set = GlobalValueConfigCategory.Instance.Get(107).Value.Split(';');
            float discount;
            if (exlporeNumber < int.Parse(set[0])) // 超过300次打8折
            {
                discount = 1;
            }
            else
            {
                discount = float.Parse(set[1]);
            }
            if (choukaType == 10 && userInfo.Diamond < (int)(needDimanond * discount))
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