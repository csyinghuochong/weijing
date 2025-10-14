using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class UISupportDevsComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonOpen;
        public GameObject ButtonSupport;
        public GameObject ButtonClose;
        public GameObject ItemListNode;
        public GameObject ImageButton;

        public BagInfo UseBagInfo;
    }

    public class UISupportDevsComponentAwake : AwakeSystem<UISupportDevsComponent>
    {
        public override void Awake(UISupportDevsComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonOpen = rc.Get<GameObject>("ButtonOpen");
            ButtonHelp.AddListenerEx(self.ButtonOpen, () => { self.OnButtonOpen().Coroutine(); });

            self.ButtonSupport = rc.Get<GameObject>("ButtonSupport");
            ButtonHelp.AddListenerEx(self.ButtonSupport, self.OnButtonSupport);

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            ButtonHelp.AddListenerEx(self.ButtonClose, self.OnButtonClose);

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            ButtonHelp.AddListenerEx(self.ImageButton, self.OnButtonClose);
        }
    }

    public class UISupportDevsComponentDestroy : DestroySystem<UISupportDevsComponent>
    {
        public override void Destroy(UISupportDevsComponent self)
        {
            
        }
    }

    public static class UISupportDevsComponentSystem
    {

        public static void InitData(this UISupportDevsComponent self, BagInfo bagInfo)
        {
            self.UseBagInfo = bagInfo;

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            string[] rewardInfos = itemConfig.ItemUsePar.Split(';');
            int dropid = int.Parse(rewardInfos[1]);
            List<RewardItem> rewardItems =  DropHelper.DropIDToShowItem(dropid);

            Log.ILog.Debug($"rewardItems:  {rewardItems.Count}");

            UICommonHelper.ShowItemList(rewardItems, self.ItemListNode, self);
        }

        public static async ETTask OnButtonOpen(this UISupportDevsComponent self)
        {
            long instanceid = self.InstanceId;

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get( self.UseBagInfo.ItemID );
            string[] itemPar = itemConfig.ItemUsePar.Split(';');
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RechargeNumber) < long.Parse(itemPar[0]))
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_NoPayValueError);
                return;
            }

            List<RewardItem> droplist = new List<RewardItem>();
            string[] rewardInfos = itemConfig.ItemUsePar.Split(';');
            DropHelper.DropIDToDropItem(int.Parse(rewardInfos[1]), droplist);
            if (self.ZoneScene().GetComponent<BagComponent>().GetBagLeftCell() < ItemHelper.GetNeedCell(droplist))
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_BagIsFull);
                return;
            }

            int errorCode = await self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.UseBagInfo, string.Empty);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            if (errorCode == ErrorCode.ERR_Success)
            {
                self.OnButtonClose();
            }
        }

        public static void OnButtonSupport(this UISupportDevsComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIRecharge).Coroutine();
        }

        public static void OnButtonClose(this UISupportDevsComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UISupportDevs);
        }

    }
}
