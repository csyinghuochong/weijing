using System;
using System.Collections.Generic;

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
                /*
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
                
                */

                //-------------------------------

                //List<PaiMaiItemInfo> paimaiList = new List<PaiMaiItemInfo>();
                List<PaiMaiItemInfo> paimaiListShow = new List<PaiMaiItemInfo>();
                long nowTime = TimeHelper.ServerNow();

                switch (request.PaiMaiShowType) {

                    //消耗品
                    case 1:

                        long chaTimeValue = nowTime - paiMaiComponent.UpdateTimeConsume;
                        //5分钟更新一次数据
                        if (chaTimeValue >= 150000 || paiMaiComponent.PaiMaiItemInfos_Consume == null) {
                            paiMaiComponent.UpdateTimeConsume = nowTime;
                            PaiMaiHelper.UpdatePaiMaiDate(scene, request.PaiMaiShowType);
                        }
                        paimaiListShow = paiMaiComponent.PaiMaiItemInfos_Consume;
                        break;

                    //材料
                    case 2:

                        chaTimeValue = nowTime - paiMaiComponent.UpdateTimeMaterial;
                        //5分钟更新一次数据
                        if (chaTimeValue >= 150000 || paiMaiComponent.PaiMaiItemInfos_Material == null)
                        {
                            paiMaiComponent.UpdateTimeMaterial = nowTime;
                            PaiMaiHelper.UpdatePaiMaiDate(scene, request.PaiMaiShowType);
                        }
                        paimaiListShow = paiMaiComponent.PaiMaiItemInfos_Material;
                        break;

                    //装备
                    case 3:

                        chaTimeValue = nowTime - paiMaiComponent.UpdateTimeEquipment;
                        //5分钟更新一次数据
                        if (chaTimeValue >= 150000 || paiMaiComponent.PaiMaiItemInfos_Equipment == null)
                        {
                            paiMaiComponent.UpdateTimeEquipment = nowTime;
                            PaiMaiHelper.UpdatePaiMaiDate(scene, request.PaiMaiShowType);
                        }
                        paimaiListShow = paiMaiComponent.PaiMaiItemInfos_Equipment;
                        break;

                    //宝石
                    case 4:

                        chaTimeValue = nowTime - paiMaiComponent.UpdateTimeGemstone;
                        //5分钟更新一次数据
                        if (chaTimeValue >= 150000 || paiMaiComponent.PaiMaiItemInfos_Gemstone == null)
                        {
                            paiMaiComponent.UpdateTimeGemstone = nowTime;
                            PaiMaiHelper.UpdatePaiMaiDate(scene, request.PaiMaiShowType);
     
                        }

                        paimaiListShow = paiMaiComponent.PaiMaiItemInfos_Gemstone;
                        break;

                }


                int page = (int)request.ActorId;
                int pagenum = int.Parse(GlobalValueConfigCategory.Instance.Get(104).Value);  //每页的数量

                int maxpage = paimaiListShow.Count / pagenum;
                int extra = (paimaiListShow.Count % pagenum) > 0 ? 1 : 0;
                maxpage += extra;

                int startindex = (page - 1) * pagenum;
                if (startindex >= paimaiListShow.Count)
                {
                    startindex = paimaiListShow.Count - 1;
                }
                if (startindex < 0)
                {
                    startindex = 0;
                }

                //页数切换
                if (page >= maxpage)
                {
                    if (page == maxpage)
                    {
                        int getnumber = Math.Max(paimaiListShow.Count - startindex, 0);

                        response.PaiMaiItemInfos = paimaiListShow.GetRange(startindex, getnumber);
                        response.Message = "1";  //没有下一页
                        response.NextPage = page;
                    }
                    else {
                        if (paimaiListShow.Count > 0)
                        {
                            response.Error = ErrorCode.ERR_PaiMaiBuyMaxPage;
                        }
                    }
                }
                else
                {
                    int getnumber = Math.Min(paimaiListShow.Count - startindex, pagenum);
                    response.PaiMaiItemInfos = paimaiListShow.GetRange(startindex, getnumber);
                    response.Message = "0";  //有下一页
                    response.NextPage = page;
                }
                
            }


            reply();
            await ETTask.CompletedTask;
        }
    }
}
