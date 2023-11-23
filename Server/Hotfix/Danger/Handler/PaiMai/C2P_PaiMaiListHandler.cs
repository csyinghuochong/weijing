using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2P_PaiMaiListHandler: AMActorRpcHandler<Scene, C2P_PaiMaiListRequest, P2C_PaiMaiListResponse>
    {
        protected override async ETTask Run(Scene scene, C2P_PaiMaiListRequest request, P2C_PaiMaiListResponse response, Action reply)
        {
            PaiMaiSceneComponent paiMaiComponent = scene.GetComponent<PaiMaiSceneComponent>();
            List<PaiMaiItemInfo> PaiMaiItemInfo = paiMaiComponent.dBPaiMainInfo.PaiMaiItemInfos;
            // 0自己 1-4道具分类
            if (request.PaiMaiType == 0) // 0自己的
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
            else // 1-4道具
            {
                List<PaiMaiItemInfo> paimaiListShow = new List<PaiMaiItemInfo>();
                long nowTime = TimeHelper.ServerNow();

                // 获取物品缓存
                switch (request.PaiMaiType)
                {
                    //消耗品
                    case 1:

                        long chaTimeValue = nowTime - paiMaiComponent.UpdateTimeConsume;
                        //5分钟更新一次数据
                        if (chaTimeValue >= 150000 || !paiMaiComponent.PaiMaiItemInfos_Consume_New.ContainsKey(request.PaiMaiShowType))
                        {
                            paiMaiComponent.UpdateTimeConsume = nowTime;
                            PaiMaiHelper.UpdatePaiMaiDate(scene, request.PaiMaiType);
                        }

                        if (paiMaiComponent.PaiMaiItemInfos_Consume_New.TryGetValue(request.PaiMaiShowType, out var value))
                        {
                            paimaiListShow = value;
                        }

                        break;

                    //材料
                    case 2:

                        chaTimeValue = nowTime - paiMaiComponent.UpdateTimeMaterial;
                        //5分钟更新一次数据
                        if (chaTimeValue >= 150000 || !paiMaiComponent.PaiMaiItemInfos_Material_New.ContainsKey(request.PaiMaiShowType))
                        {
                            paiMaiComponent.UpdateTimeMaterial = nowTime;
                            PaiMaiHelper.UpdatePaiMaiDate(scene, request.PaiMaiType);
                        }

                        if (paiMaiComponent.PaiMaiItemInfos_Material_New.TryGetValue(request.PaiMaiShowType, out var value1))
                        {
                            paimaiListShow = value1;
                        }

                        break;

                    //装备
                    case 3:

                        chaTimeValue = nowTime - paiMaiComponent.UpdateTimeEquipment;
                        //5分钟更新一次数据
                        if (chaTimeValue >= 150000 || !paiMaiComponent.PaiMaiItemInfos_Equipment_New.ContainsKey(request.PaiMaiShowType))
                        {
                            paiMaiComponent.UpdateTimeEquipment = nowTime;
                            PaiMaiHelper.UpdatePaiMaiDate(scene, request.PaiMaiType);
                        }

                        if (paiMaiComponent.PaiMaiItemInfos_Equipment_New.TryGetValue(request.PaiMaiShowType, out var value2))
                        {
                            paimaiListShow = value2;
                        }

                        break;

                    //宝石
                    case 4:

                        chaTimeValue = nowTime - paiMaiComponent.UpdateTimeGemstone;
                        //5分钟更新一次数据
                        if (chaTimeValue >= 150000 || !paiMaiComponent.PaiMaiItemInfos_Gemstone_New.ContainsKey(request.PaiMaiShowType))
                        {
                            paiMaiComponent.UpdateTimeGemstone = nowTime;
                            PaiMaiHelper.UpdatePaiMaiDate(scene, request.PaiMaiType);
                        }

                        if (paiMaiComponent.PaiMaiItemInfos_Gemstone_New.TryGetValue(request.PaiMaiShowType, out var value3))
                        {
                            paimaiListShow = value3;
                        }

                        break;
                }

                // 拿到指定页数的物品
                int page = request.Page;
                int pagenum = int.Parse(GlobalValueConfigCategory.Instance.Get(104).Value); //每页的数量

                int maxpage = paimaiListShow.Count / pagenum;
                int extra = (paimaiListShow.Count % pagenum) > 0? 1 : 0;
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
                        response.Message = "1"; //没有下一页
                        response.NextPage = maxpage;
                    }
                    else
                    {
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
                    response.Message = "0"; //有下一页
                    response.NextPage = maxpage;
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}