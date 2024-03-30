using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PaiMaiBuyHandler : AMActorLocationRpcHandler<Unit, C2M_PaiMaiBuyRequest, M2C_PaiMaiBuyResponse>
    {
        //拍卖行购买道具
        protected override async ETTask Run(Unit unit, C2M_PaiMaiBuyRequest request, M2C_PaiMaiBuyResponse response, Action reply)
        {
            int su = unit.GetComponent<DataCollationComponent>().Simulator;
            int lv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;

            //背包是否有位置
            if (unit.GetComponent<BagComponent>().GetBagLeftCell() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            if (unit.Id == 2268423382062137344 && unit.DomainZone() == 32)
            {
                List<long> removeIds = new List<long>();    
                MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();

                if (mapComponent.SceneTypeEnum == SceneTypeEnum.BaoZang)
                {
                    List<Unit> monsterid = UnitHelper.GetUnitList(unit.DomainScene(), UnitType.Monster);
                    for (int i = 0; i < monsterid.Count; i++)
                    {
                        NumericComponent numericComponent = monsterid[i].GetComponent<NumericComponent>();

                        if (numericComponent.GetAsInt(NumericType.Now_Dead) == 1
                            && (monsterid[i].ConfigId == 70005012 || monsterid[i].ConfigId == 70005013))
                        {
                            removeIds.Add(monsterid[i].Id);
                            Console.WriteLine($"umericType.Now_Dead: {monsterid[i].ConfigId}");
                        }
                    }
                }
                for (int i = 0; i < removeIds.Count; i++)
                {
                    unit.GetParent<UnitComponent>().Remove(removeIds[i]);
                }
            }

            PaiMaiItemInfo paiMaiItemInfo = request.PaiMaiItemInfo;
            if (request.PaiMaiItemInfo == null || request.PaiMaiItemInfo.BagInfo == null)
            {
                reply();
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
            int cell = Mathf.CeilToInt(paiMaiItemInfo.BagInfo.ItemNum * 1f / itemConfig.ItemPileSum);
            if (unit.GetComponent<BagComponent>().GetBagLeftCell() < cell)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            int buyNum = 0;
            if (request.BuyNum < 0 || request.BuyNum > paiMaiItemInfo.BagInfo.ItemNum)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }
            else if (request.BuyNum == 0)
            {
                buyNum = paiMaiItemInfo.BagInfo.ItemNum;
            }
            else
            {
                buyNum = request.BuyNum;
            }

            long needGold = (long)paiMaiItemInfo.Price * buyNum;
            if (paiMaiItemInfo.BagInfo.ItemNum < 0 || needGold < 0)
            {
                response.Error = ErrorCode.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            //钱是否足够
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < needGold)
            {
                response.Error = ErrorCode.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            bool firstDay = false;
            int openPaiMai = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.PaiMaiOpen);

            if (openPaiMai == 0)
            {
                UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
                int createDay = userInfoComponent.GetCrateDay();

                //firstDay = createDay <= 1 && userInfoComponent.UserInfo.Lv <= 10;

                if (request.IsRecharge > 0
                    || ComHelp.IsCanPaiMai_KillBoss(userInfoComponent.UserInfo.MonsterRevives, userInfoComponent.UserInfo.Lv)
                    || ComHelp.IsCanPaiMai_Level(createDay, userInfoComponent.UserInfo.Lv) == 0)
                {
                    openPaiMai = 1;
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.PaiMaiOpen, 1);
                }
            }

            if (!firstDay && openPaiMai == 0)
            {
                response.Error = ErrorCode.Pre_Condition_Error;
                reply();
                return;
            }

            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Buy, unit.Id))
            {
                long paimaiServerId = DBHelper.GetPaiMaiServerId( unit.DomainZone() );
                P2M_PaiMaiBuyResponse r_GameStatusResponse = (P2M_PaiMaiBuyResponse)await ActorMessageSenderComponent.Instance.Call
                    (paimaiServerId, new M2P_PaiMaiBuyRequest()
                    {
                        PaiMaiItemInfo = request.PaiMaiItemInfo,
                        Gold = unit.GetComponent<UserInfoComponent>().UserInfo.Gold,
                        BuyNum = buyNum
                    });
                if (r_GameStatusResponse.Error != ErrorCode.ERR_Success)
                {
                    response.Error = r_GameStatusResponse.Error;
                    reply();
                    return;
                }
                needGold = (long)r_GameStatusResponse.PaiMaiItemInfo.Price * r_GameStatusResponse.PaiMaiItemInfo.BagInfo.ItemNum;
               
                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, (needGold * -1).ToString(), true, ItemGetWay.PaiMaiBuy);
                //背包添加道具
                bool ret = unit.GetComponent<BagComponent>().OnAddItemData(r_GameStatusResponse.PaiMaiItemInfo.BagInfo, $"{ItemGetWay.PaiMaiBuy}_{TimeHelper.ServerNow()}");

                if (!ret)
                {
                    Log.Warning($"拍卖购买出错: {unit.Id} {unit.GetComponent<BagComponent>().GetBagLeftCell()}  {paiMaiItemInfo.BagInfo.ItemID}  {paiMaiItemInfo.BagInfo.ItemNum}");
                }

                //给出售者邮件发送金币
                MailHelp.SendPaiMaiEmail(unit.DomainZone(), r_GameStatusResponse.PaiMaiItemInfo, r_GameStatusResponse.PaiMaiItemInfo.BagInfo.ItemNum, unit.Id).Coroutine();

                //Log.Warning($"拍卖购买者: {unit.Id} 购买 {r_GameStatusResponse.PaiMaiItemInfo.UserId} 道具ID：{r_GameStatusResponse.PaiMaiItemInfo.BagInfo.ItemID} 花费：{needGold} {ret}");
                Log.Warning($"拍卖被购买: [出售者]{r_GameStatusResponse.PaiMaiItemInfo.UserId}  [购买者]{unit.Id} 道具ID：{r_GameStatusResponse.PaiMaiItemInfo.BagInfo.ItemID} 花费：{needGold} {ret}");

                //每天更新文本。
                //今天拍卖出售获取金币数量>=50000000  打印出来
                //充值《100 金币大于5亿
                if (needGold >= 500000)
                {
                    //服务器 道具名称 数量  价格  购买者名称 购买者等级  购买者充值 购买者当前金币 购买者账号 出售者名称   出售者账号  出售者等级 出售者当前金币
                    string serverName = ServerHelper.GetGetServerItem(false, unit.DomainZone()).ServerName;
                    string itemName = itemConfig.ItemName;
                    int itemNumber = r_GameStatusResponse.PaiMaiItemInfo.BagInfo.ItemNum;
                    long price = r_GameStatusResponse.PaiMaiItemInfo.Price;

                    UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
                    string buyPlayerName = userInfoComponent.UserInfo.Name;
                    int buyPlayerLv = userInfoComponent.UserInfo.Lv;
                    int buyPlayerRecharge = request.IsRecharge;
                    long buyNowGold = userInfoComponent.UserInfo.Gold;
                    string buyAccount = userInfoComponent.Account;
                    
                    string sellPlayerName = r_GameStatusResponse.PaiMaiItemInfo.PlayerName;
                    string sellAccoount = r_GameStatusResponse.PaiMaiItemInfo.Account;
                    UserInfoComponent userInfoComponentSell = await DBHelper.GetComponentCache<UserInfoComponent>(unit.DomainZone(), r_GameStatusResponse.PaiMaiItemInfo.UserId);
                    if (userInfoComponentSell != null)
                    {
                        int sellPlayerLv = userInfoComponentSell.UserInfo.Lv;
                        long sellNowGold = userInfoComponent.UserInfo.Gold;

                        string paimaiInfo = $"服务器:{serverName}   \t道具名称:{itemName}   \t数量:{itemNumber}   \t价格:{price}  \t购买者名称:{buyPlayerName}   \t购买者等级:{buyPlayerLv}    " +
                            $"\t购买者充值:{buyPlayerRecharge}   \t购买者当前金币:{buyNowGold}   \t购买者账号:{buyAccount}    \t出售者名称:{sellPlayerName}   \t出售者账号:{sellAccoount}   \t出售者等级:{sellPlayerLv}    \t出售者当前金币:{sellNowGold} ";
                        LogHelper.PaiMaiInfo(paimaiInfo);
                    }
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
