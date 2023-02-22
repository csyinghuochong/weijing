using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemOperateGemHandler : AMActorLocationRpcHandler<Unit, C2M_ItemOperateGemRequest, M2C_ItemOperateGemResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ItemOperateGemRequest request, M2C_ItemOperateGemResponse response, Action reply)
        {
            long bagInfoID = request.OperateBagID;
            BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, bagInfoID);
            if (useBagInfo == null)
            {
                useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip, bagInfoID);
            }
            if (useBagInfo == null)
            {
                response.Error = ErrorCore.ERR_ItemUseError;
                reply();
                return;
            }

            // 通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            //通知客户端背包道具发生改变
            m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(useBagInfo.ItemID);

            //镶嵌宝石
            if (request.OperateType == 9)
            {
                //宝石镶嵌
                string[] geminfos = request.OperatePar.Split('_');
                long equipid = long.Parse(geminfos[0]);
                int gemIndex = int.Parse(geminfos[1]);

                BagInfo equipInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip, equipid);

                //获取装备baginfo
                //
                if (equipInfo == null)
                {
                    equipInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, equipid);
                }
                if (equipInfo == null)
                {
                    Log.Error($"equipInfo == null {equipid}");
                    reply();
                    return;
                }

                //判断孔位是否相符
                string[] equipGeminfos = equipInfo.GemHole.Split('_');

                if (equipGeminfos[gemIndex] != itemConfig.ItemSubType.ToString() && itemConfig.ItemSubType != 110 && itemConfig.ItemSubType != 111)
                {
                    response.Error = ErrorCore.ERR_ItemUseError;
                    reply();
                    return;
                }



                string[] gemIdList = equipInfo.GemIDNew.Split('_');
                gemIdList[gemIndex] = useBagInfo.ItemID.ToString();
                string gemIDNew = "";
                for (int i = 0; i < gemIdList.Length; i++)
                {
                    gemIDNew = gemIDNew + gemIdList[i] + "_";
                }
                equipInfo.GemIDNew = gemIDNew.Substring(0, gemIDNew.Length - 1);

                m2c_bagUpdate.BagInfoUpdate.Add(equipInfo);
                //消耗宝石
                unit.GetComponent<BagComponent>().OnCostItemData(useBagInfo.BagInfoID, 1);
                Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);
            }

            //卸下宝石
            if (request.OperateType == 10)
            {

                int gemIndex = int.Parse(request.OperatePar);
                string[] gemIdList = useBagInfo.GemIDNew.Split('_');
                int gemItemId = int.Parse(gemIdList[gemIndex]);

                //类型110的不能卸
                ItemConfig gemItemConfig = ItemConfigCategory.Instance.Get(gemItemId);
                if (gemItemConfig.ItemSubType == 110)
                {
                    response.Error = ErrorCore.ERR_GemNoError;
                    reply();
                    return;
                }

                gemIdList[gemIndex] = "0";
                string gemIDNew = "";
                for (int i = 0; i < gemIdList.Length; i++)
                {
                    gemIDNew = gemIDNew + gemIdList[i] + "_";
                }
                useBagInfo.GemIDNew = gemIDNew.Substring(0, gemIDNew.Length - 1);
                m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);

                //回收宝石
                Log.Debug($"拆下宝石: {unit.Id} {gemItemId}");
                if (gemItemId != 0)
                {
                    unit.GetComponent<BagComponent>().OnAddItemData($"{gemItemId};1", $"{ItemGetWay.StoreBuy}_{TimeHelper.ServerNow()}");
                    Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);
                }
            }
            MessageHelper.SendToClient(unit, m2c_bagUpdate);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
