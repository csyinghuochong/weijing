using System;
using UnityEngine;

namespace ET
{
    public class UIPetEggDuiHuanComponent : Entity, IAwake
    {
        public GameObject Btn_ChouKaCoin2;
        public GameObject Btn_ChouKaCoin1;
        public GameObject Btn_ChouKaCoin0;

        public UICommonCostItemComponent UICommonCostItem0;
        public UICommonCostItemComponent UICommonCostItem1;
        public UICommonCostItemComponent UICommonCostItem2;
    }


    public class UIPetEggDuiHuanComponentAwakeSystem : AwakeSystem<UIPetEggDuiHuanComponent>
    {
        public override void Awake(UIPetEggDuiHuanComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject commonCostItem2 = rc.Get<GameObject>("UICommonCostItem2");
            self.UICommonCostItem2 =  self.AddChild<UICommonCostItemComponent, GameObject>(commonCostItem2);
            self.Btn_ChouKaCoin2 = rc.Get<GameObject>("Btn_ChouKaCoin2");
            ButtonHelp.AddListenerEx( self.Btn_ChouKaCoin2, () => { self.OnBtn_ChouKaCoin(3).Coroutine();  } );

            GameObject commonCostItem1 = rc.Get<GameObject>("UICommonCostItem1");
            self.UICommonCostItem1 = self.AddChild<UICommonCostItemComponent, GameObject>(commonCostItem1);
            self.Btn_ChouKaCoin1 = rc.Get<GameObject>("Btn_ChouKaCoin1");
            ButtonHelp.AddListenerEx(self.Btn_ChouKaCoin1, () => { self.OnBtn_ChouKaCoin(2).Coroutine(); });

            GameObject commonCostItem0 = rc.Get<GameObject>("UICommonCostItem0");
            self.UICommonCostItem0 = self.AddChild<UICommonCostItemComponent, GameObject>(commonCostItem0);
            self.Btn_ChouKaCoin0 = rc.Get<GameObject>("Btn_ChouKaCoin0");
            ButtonHelp.AddListenerEx(self.Btn_ChouKaCoin0, () => { self.OnBtn_ChouKaCoin(1).Coroutine(); });

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UIPetEggDuiHuanComponentSystem
    {
        public static void OnUpdateUI(this UIPetEggDuiHuanComponent self)
        {
            PetEggDuiHuanConfig cofig0 = PetEggDuiHuanConfigCategory.Instance.Get(1);
            string[] itemcost0 = cofig0.CostItems.Split(';');
            self.UICommonCostItem0.UpdateItem(int.Parse(itemcost0[0]), int.Parse(itemcost0[1]));

            PetEggDuiHuanConfig cofig1 = PetEggDuiHuanConfigCategory.Instance.Get(2);
            string[] itemcost1 = cofig1.CostItems.Split(';');
            self.UICommonCostItem1.UpdateItem(int.Parse(itemcost1[0]), int.Parse(itemcost1[1]));

            PetEggDuiHuanConfig cofig2 = PetEggDuiHuanConfigCategory.Instance.Get(3);
            string[] itemcost2 = cofig2.CostItems.Split(';');
            self.UICommonCostItem2.UpdateItem(int.Parse(itemcost2[0]), int.Parse(itemcost2[1]));
        }

        public static async ETTask OnBtn_ChouKaCoin(this UIPetEggDuiHuanComponent self, int index)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            PetEggDuiHuanConfig cofig0 = PetEggDuiHuanConfigCategory.Instance.Get(index);
            if (!bagComponent.CheckNeedItem(cofig0.CostItems))
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足！");
                return;
            }
            if (bagComponent.GetLeftSpace() <= 1)
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足！");
                return;
            }

            C2M_PetEggDuiHuanRequest request = new C2M_PetEggDuiHuanRequest() { ChouKaId = index };
            M2C_PetEggDuiHuanResponse response = (M2C_PetEggDuiHuanResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error!= ErrorCore.ERR_Success)
            {
                return;
            }
            UI ui = await UIHelper.Create(self.DomainScene(), UIType.UICommonReward);
            ui.GetComponent<UICommonRewardComponent>().OnUpdateUI(response.ReardList);
            self.OnUpdateUI();
        }
    }
}