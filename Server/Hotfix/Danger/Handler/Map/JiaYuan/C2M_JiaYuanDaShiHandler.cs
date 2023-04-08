using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanDaShiHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanDaShiRequest, M2C_JiaYuanDaShiResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanDaShiRequest request, M2C_JiaYuanDaShiResponse response, Action reply)
        {
            if (request.BagInfoIDs.Count < 1)
            {
                reply();
                return;
            }
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.BagInfoIDs[0]);
            if (useBagInfo == null)
            {
                reply();
                return;
            }

            bagComponent.OnCostItemData(request.BagInfoIDs[0], 1);

            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();  
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(useBagInfo.ItemID);
            //7,15;100403,1,5;119203,1,5
            string[] itemUsePars = itemConfig.ItemUsePar.Split(';');
            for (int i = 0; i < itemUsePars.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                string[] attriinfo = itemUsePars[i].Split(',');
                if (attriinfo.Length < 2)
                {
                    continue;
                }

                int numeid = int.Parse(attriinfo[0]);
                int addvalue = RandomHelper.RandomNumber(int.Parse(attriinfo[1]), int.Parse(attriinfo[2]));
                jiaYuanComponent.UpdateDaShiProInfo( numeid, addvalue );
            }
            jiaYuanComponent.JiaYuanDaShiTime_1++;
            response.JiaYuanDaShiTime = jiaYuanComponent.JiaYuanDaShiTime_1;
            response.JiaYuanProList = jiaYuanComponent.JiaYuanProList_7;

            await DBHelper.SaveComponent( unit.DomainZone(), unit.Id, jiaYuanComponent);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
