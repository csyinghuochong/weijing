using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ChouKaRequestHandler : AMActorLocationRpcHandler<Unit, C2M_ChouKaRequest, M2C_ChouKaResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ChouKaRequest request, M2C_ChouKaResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            if (bagComponent.GetSpaceNumber() < request.ChouKaType)
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            bool mianfei = false;
            long cdTime = long.Parse(GlobalValueConfigCategory.Instance.Get(request.ChouKaType == 1 ? 35:36).Value) * 1000;
            
            long lastTime = unit.GetComponent<NumericComponent>().GetAsLong(request.ChouKaType == 1 ? NumericType.ChouKaOneTime: NumericType.ChouKaTenTime);
            mianfei = TimeHelper.ServerNow() - lastTime >= cdTime;

            TakeCardConfig takeCardConfig = TakeCardConfigCategory.Instance.Get(request.ChapterId);
            int needZuanshi = request.ChouKaType == 1 ? takeCardConfig.ZuanShiNum : takeCardConfig.ZuanShiNum_Ten;
            int totalTimes = numericComponent.GetAsInt(NumericType.ChouKa);
            if (totalTimes >= 250)
            {
                needZuanshi = Mathf.CeilToInt(needZuanshi * 0.8f);
            }

            if (!mianfei && userInfo.Diamond < needZuanshi)
            {
                response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                reply();
                return;
            }

            int dropid = TakeCardConfigCategory.Instance.Get(request.ChapterId).DropID;
            List<RewardItem> droplist = new List<RewardItem>();
            for (int i = 0; i < request.ChouKaType; i++)
            {
                DropHelper.DropIDToDropItem_2(dropid, droplist);
            }
            for (int i = 0; i < droplist.Count; i++)
            {
                if (droplist[i].ItemID == 0)
                {
                    Log.Error($"抽卡[道具为0]： {unit.Id} {droplist[i].ItemID}");
                }
            }

            Log.Debug($"抽卡： {unit.Id} {droplist.Count}");
            bagComponent.OnAddItemData(droplist, "",$"{ItemGetWay.ChouKa}_{TimeHelper.ServerNow()}");
            
            unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.ChouKa, request.ChouKaType, 0);
            if (mianfei)
            {
                unit.GetComponent<NumericComponent>().ApplyValue(request.ChouKaType == 1 ? NumericType.ChouKaOneTime : NumericType.ChouKaTenTime, TimeHelper.ServerNow());
            }
            else
            {
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Diamond, (needZuanshi * -1).ToString());
            }
            if (request.ChouKaType == 10)
            {
                unit.GetComponent<ChengJiuComponent>().OnChouKaTen();
            }

            response.RewardList = droplist;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
