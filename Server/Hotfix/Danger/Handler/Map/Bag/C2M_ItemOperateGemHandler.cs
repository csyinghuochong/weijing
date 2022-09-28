//using System;
//using System.Collections.Generic;
//using UnityEngine;

//namespace ET
//{

//    [ActorMessageHandler]
//    public class C2M_ItemOperateGemHandler : AMActorLocationRpcHandler<Unit, C2M_ItemOperateGemRequest, M2C_ItemOperateGemResponse>
//    {

//        protected override async ETTask Run(Unit unit, C2M_ItemOperateGemRequest request, M2C_ItemOperateGemResponse response, Action reply)
//        {
//            long bagInfoID = request.OperateBagID;
//            ItemLocType locType = ItemLocType.ItemLocBag;
//            if (request.OperateType == 10)
//            {
//                locType = ItemLocType.ItemLocGem;
//            }
//            BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(locType, bagInfoID);
//            if (useBagInfo == null)
//            {
//                response.Error = ErrorCore.ERR_ItemUseError;
//                reply();
//                return;
//            }

//            // 通知客户端背包刷新
//            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
//            //通知客户端背包道具发生改变
//            m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();
//            //镶嵌宝石
//            if (request.OperateType == 9)
//            {
//                //宝石镶嵌
//                string[] geminfos = request.OperatePar.Split('_');
//                long equipid = long.Parse(geminfos[0]);
//                int gemIndex = int.Parse(geminfos[1]);

//                //获取装备baginfo
//                BagInfo equipInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip, equipid);
//                if (equipInfo == null)
//                {
//                    equipInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, equipid);
//                }
//                if (equipInfo == null)
//                {
//                    Log.Error($"equipInfo == null {equipid}");
//                    reply();
//                    return;
//                }
//                string[] gemIdList = equipInfo.GemID.Split('_');
//                gemIdList[gemIndex] = useBagInfo.BagInfoID.ToString();
//                equipInfo.GemID = "";
//                for (int i = 0; i < gemIdList.Length; i++)
//                {
//                    equipInfo.GemID = equipInfo.GemID + gemIdList[i] + "_";
//                }
//                equipInfo.GemID = equipInfo.GemID.Substring(0, equipInfo.GemID.Length - 1);

//                //改变宝石loc
//                unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.ItemLocGem, ItemLocType.ItemLocBag);
//                m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
//                m2c_bagUpdate.BagInfoUpdate.Add(equipInfo);

//                Function_Fight.GetInstance().UnitUpdateProperty_Base(unit);
//            }

//            //卸下宝石
//            if (request.OperateType == 10)
//            {
//                //宝石镶嵌
//                string[] geminfos = request.OperatePar.Split('_');
//                long equipid = long.Parse(geminfos[0]);
//                int gemIndex = int.Parse(geminfos[1]);

//                //获取装备baginfo
//                BagInfo equipInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip, equipid);
//                if (equipInfo == null)
//                {
//                    equipInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, equipid);
//                }
//                if (equipInfo == null)
//                {
//                    Log.Error($"equipInfo == null {equipid}");
//                    reply();
//                    return;
//                }
//                string[] gemIdList = equipInfo.GemID.Split('_');
//                gemIdList[gemIndex] = "0";
//                equipInfo.GemID = "";
//                for (int i = 0; i < gemIdList.Length; i++)
//                {
//                    equipInfo.GemID = equipInfo.GemID + gemIdList[i] + "_";
//                }
//                equipInfo.GemID = equipInfo.GemID.Substring(0, equipInfo.GemID.Length - 1);

//                //改变宝石loc
//                unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.ItemLocBag, ItemLocType.ItemLocGem);
//                m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
//                m2c_bagUpdate.BagInfoUpdate.Add(equipInfo);

//                Function_Fight.GetInstance().UnitUpdateProperty_Base(unit);
//            }


//            reply();
//            await ETTask.CompletedTask;
//        }
//    }
//}
