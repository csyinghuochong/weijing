using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2P_PaiMaiListHandler : AMActorRpcHandler<Scene, C2P_PaiMaiListRequest, P2C_PaiMaiListResponse>
    {
        protected override async ETTask Run(Scene scene, C2P_PaiMaiListRequest request, P2C_PaiMaiListResponse response, Action reply)
        {
            PaiMaiSceneComponent paiMaiComponent = scene.GetComponent<PaiMaiSceneComponent>();
            List<PaiMaiItemInfo> PaiMaiItemInfo = paiMaiComponent.dBPaiMainInfo.PaiMaiItemInfos;

            //int32 PaiMaiType = 2;    //1自己 2所有
            if (request.PaiMaiType == 1)
            {
                List<PaiMaiItemInfo> paiMaiItemsTo = new List<PaiMaiItemInfo>();
                for (int i = 0; i < PaiMaiItemInfo.Count; i++)
                {
                    if (PaiMaiItemInfo[i].UserId == request.UserId)
                    {
                        paiMaiItemsTo.Add(PaiMaiItemInfo[i]);
                    }
                }
                response.PaiMaiItemInfos = paiMaiItemsTo;
                reply();
                return;
            }
            else if (request.PaiMaiType == 2)
            {
                //int page = request.Page;
                int page = (int)request.ActorId;
                int pagenum = 300;  //每页的数量
                ////新的方式 切页
                int maxpage = PaiMaiItemInfo.Count / pagenum;
                int extra = (PaiMaiItemInfo.Count % pagenum) > 0 ? 1 : 0;
                maxpage += extra;

                int startindex = (page - 1) * pagenum;
                if (startindex < 0)
                {
                    startindex = 0;
                }
                if (startindex >= PaiMaiItemInfo.Count)
                {
                    startindex = PaiMaiItemInfo.Count - 1;
                }

                if (page >= maxpage)
                {
                    int getnumber = Math.Max(PaiMaiItemInfo.Count - startindex, 0);
                    response.PaiMaiItemInfos = PaiMaiItemInfo.GetRange(startindex, getnumber);
                    response.Message = "1";  //没有下一页
                }
                else
                {
                    int getnumber = Math.Min(PaiMaiItemInfo.Count - startindex, pagenum);
                    response.PaiMaiItemInfos = PaiMaiItemInfo.GetRange(startindex, getnumber);
                    response.Message = "0";  //有下一页
                }

                //int maxpage = PaiMaiItemInfo.Count > 300 ? 300 : 0;
                //response.PaiMaiItemInfos = PaiMaiItemInfo.GetRange(0, maxpage);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
