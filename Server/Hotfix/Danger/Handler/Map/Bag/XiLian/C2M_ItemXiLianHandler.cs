using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemXiLianHandler : AMActorLocationRpcHandler<Unit, C2M_ItemXiLianRequest, M2C_ItemXiLianResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemXiLianRequest request, M2C_ItemXiLianResponse response, Action reply)
        {
            try
            {
                ItemLocType itemLocType = ItemLocType.ItemLocBag;
                BagComponent bagComponent = unit.GetComponent<BagComponent>();
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID);

                if (bagInfo == null)
                {
                    bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocEquip, request.OperateBagID);
                    itemLocType = ItemLocType.ItemLocEquip;
                }
                if (bagInfo == null)
                {
                    bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocEquip_2, request.OperateBagID); 
                    itemLocType = ItemLocType.ItemLocEquip_2;
                }
                
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);

                if (itemConfig.EquipType == 101 || itemConfig.EquipType == 201)
                {
                    response.Error = ErrorCode.ERR_ItemUseError;
                    reply();
                    return;
                }

                int[] costItems = itemConfig.XiLianStone;
                List<RewardItem> rewardItems = new List<RewardItem>();

                bool ifZuanShi = false;

                if (request.Times == 1)
                {
                    if (costItems != null && costItems.Length > 1)
                    {
                        //普通洗炼
                        rewardItems.Add(new RewardItem() { ItemID = costItems[0], ItemNum = costItems[1] * request.Times });
                    }
                }
                else
                {
                    //钻石洗炼
                    rewardItems.Add(new RewardItem() { ItemID = (int)UserDataType.Diamond, ItemNum = GlobalValueConfigCategory.Instance.Get(73).Value2 });
                    ifZuanShi = true;
                }

                bool sucess = bagComponent.OnCostItemData(rewardItems);
                if (!sucess)
                {
                    reply();
                    return;
                }
                int diamondXiLianTimes = unit.GetComponent<DataCollationComponent>().DiamondXiLianTimes;
                int xilianLevel = XiLianHelper.GetXiLianId(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ItemXiLianDu));
                xilianLevel = xilianLevel != 0 ? EquipXiLianConfigCategory.Instance.Get(xilianLevel).XiLianLevel : 0;
                for (int i = 0; i < request.Times; i++)
                {
                    response.ItemXiLianResults.Add( XiLianHelper.XiLianItem(unit, bagInfo, 1, xilianLevel, ifZuanShi ? 1: 0, diamondXiLianTimes) );     //精炼属性不进行重置
                }

                if (request.Times == 1 && (itemLocType == ItemLocType.ItemLocEquip || itemLocType == ItemLocType.ItemLocEquip_2))
                {
                    unit.GetComponent<SkillSetComponent>().OnTakeOffEquip(itemLocType, bagInfo, bagInfo.BagInfoID);
                }

                if (request.Times == 1)
                {
                    ItemXiLianResult itemXiLian = response.ItemXiLianResults[0];
                    bagInfo.XiLianHideProLists = itemXiLian.XiLianHideProLists;              //基础属性洗炼
                    bagInfo.HideSkillLists = itemXiLian.HideSkillLists;                      //隐藏技能
                    bagInfo.XiLianHideTeShuProLists = itemXiLian.XiLianHideTeShuProLists;    //特殊属性洗炼

                    M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
                    //通知客户端背包道具发生改变
                    m2c_bagUpdate.BagInfoUpdate.Add(bagInfo);
                    MessageHelper.SendToClient(unit, m2c_bagUpdate);
                }

                if (request.Times == 1 && (itemLocType == ItemLocType.ItemLocEquip || itemLocType == ItemLocType.ItemLocEquip_2))
                {
                    unit.GetComponent<SkillSetComponent>().OnWearEquip(bagInfo);
                }

                for (int i = 0; i < response.ItemXiLianResults.Count; i++)
                {
                    ItemXiLianResult itemXiLianResult = response.ItemXiLianResults[i];
                    for (int skill = 0; skill < itemXiLianResult.HideSkillLists.Count; skill++)
                    {
                        unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.EquipActiveSkillId_222, itemXiLianResult.HideSkillLists[skill], 1);
                    }

                    for (int attr = 0;  attr < itemXiLianResult.XiLianHideProLists.Count; attr++ )
                    {
                        unit.GetComponent<TaskComponent>().TriggerTaskEvent( TaskTargetType.XiLianAttriId_45, itemXiLianResult.XiLianHideProLists[0].HideID, 1);
                        unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.XiLianAttriId_45, itemXiLianResult.XiLianHideProLists[0].HideID, 1);
                    }

                    unit.GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.XiLianSkillNumber_44, itemXiLianResult.HideSkillLists.Count, 1);
                    unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.XiLianSkillNumber_44, itemXiLianResult.HideSkillLists.Count, 1);
                }

                unit.GetComponent<ChengJiuComponent>().OnEquipXiLian(request.Times);
                unit.GetComponent<TaskComponent>().OnEquipXiLian(request.Times);
                unit.GetComponent<DataCollationComponent>().OnXiLian(request.Times);
                Function_Fight.GetInstance().UnitUpdateProperty_Base( unit, true, true );


                string[] xiliandu = GlobalValueConfigCategory.Instance.Get(49).Value.Split(";");
                int addXilian = RandomHelper.RandomNumber(int.Parse(xiliandu[0]), int.Parse(xiliandu[1]));
                if (ifZuanShi)
                {
                    addXilian = (int)(addXilian * 2f);
                }
                else 
                {
                    addXilian = (int)(addXilian * 0.7f);
                }
                unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.ItemXiLianDu, addXilian * request.Times, 0, true);
                //unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.Now_XiLian,1, 0, true);
                reply();
                await ETTask.CompletedTask;
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
        }
    }
}
