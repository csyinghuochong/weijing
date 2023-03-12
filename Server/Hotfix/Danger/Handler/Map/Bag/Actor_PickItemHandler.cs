using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_PickItemHandler : AMActorLocationRpcHandler<Unit, Actor_PickItemRequest, Actor_PickItemResponse>
    {
        private int OnFubenPick(Unit unit, Actor_PickItemRequest request)
        {
            List<DropInfo> drops = request.ItemIds;
            List<long> removeIds = new List<long>();
            long serverTime = TimeHelper.ServerNow();
            //DropType ==  0 公共掉落 2保护掉落   1私有掉落 3 归属掉落
            for (int i = drops.Count - 1; i >= 0; i--)
            {
                Unit unitDrop = unit.DomainScene().GetComponent<UnitComponent>().Get(drops[i].UnitId);
                DropComponent dropComponent = null;
                if (drops[i].DropType != 1)
                {
                    if (unitDrop == null)
                    {
                        continue;
                    }
                    dropComponent = unitDrop.GetComponent<DropComponent>();
                    int dropType = dropComponent.DropType;
                    if (dropType == 2)
                    {
                        if (dropComponent.OwnerId != 0 && dropComponent.OwnerId != unit.Id && serverTime < dropComponent.ProtectTime)
                        {
                            return ErrorCore.ERR_ItemDropProtect;
                        }
                    }
                    if (dropType == 3)
                    {
                        if (dropComponent.OwnerId != 0 && dropComponent.OwnerId != unit.Id)
                        {
                            return ErrorCore.ERR_ItemDropProtect;
                        }
                    }
                }
                int addItemID = dropComponent !=null ? dropComponent.ItemID : drops[i].ItemID;
                int addItemNum = dropComponent != null ? dropComponent.ItemNum : drops[i].ItemNum;
                List<RewardItem> rewardItems = new List<RewardItem>();
                rewardItems.Add(new RewardItem() { ItemID = addItemID, ItemNum = addItemNum });
                bool success = unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.PickItem}_{TimeHelper.ServerNow()}");
                if (!success)
                {
                    return  ErrorCore.ERR_BagIsFull;
                }
                //移除非私有掉落
                if (drops[i].DropType != 1)
                {
                    unit.DomainScene().GetComponent<UnitComponent>().Remove(unitDrop.Id);       //移除掉落ID
                    removeIds.Add(drops[i].UnitId);
                }
                FubenHelp.SendFubenPickMessage(unit, drops[i]);
            }
            
            return ErrorCore.ERR_Success;
        }

        private int OnTeamPick(Unit unit, Actor_PickItemRequest request)
        {
            List<DropInfo> drops = request.ItemIds;
            long serverTime = TimeHelper.ServerNow();

            TeamDungeonComponent teamDungeonComponent = unit.DomainScene().GetComponent<TeamDungeonComponent>();
            
            for (int i = drops.Count - 1; i >= 0; i--)
            {
                Unit unitDrop = unit.DomainScene().GetComponent<UnitComponent>().Get(drops[i].UnitId);
                DropComponent dropComponent = null;
                if (drops[i].DropType != 1)
                {
                    if (unitDrop == null)
                    {
                        Log.Debug($"OnTeamPick:unitDrop == null {unit.Id}");
						continue;
                    }
                    dropComponent = unitDrop.GetComponent<DropComponent>();
                    int dropType = dropComponent.DropType;
                    if (dropType == 2)
                    {
                        if (dropComponent.OwnerId != 0 && dropComponent.OwnerId != unit.Id && serverTime < dropComponent.ProtectTime)
                        {
                            return ErrorCore.ERR_ItemDropProtect;
                        }
                    }
                    if (dropType == 3)
                    {
                        if (dropComponent.OwnerId != 0 && dropComponent.OwnerId != unit.Id)
                        {
                            return ErrorCore.ERR_ItemDropProtect;
                        }
                    }
                }

                int addItemID = dropComponent!=null ? dropComponent.ItemID : drops[i].ItemID;
                int addItemNum = dropComponent != null ? dropComponent.ItemNum : drops[i].ItemNum;
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(addItemID);

                bool teshuItem = itemConfig.ItemQuality >= 4 && itemConfig.ItemType == 2 && itemConfig.ItemSubType == 1;

                //紫色品质通知客户端抉择
                //DropType ==   0 公共掉落 1私有掉落 2保护掉落   3 归属掉落
                if (drops[i].DropType == 0 && itemConfig.ItemQuality >= 4  && !teshuItem
                    && !teamDungeonComponent.ItemFlags.ContainsKey(unitDrop.Id))
                {
                    teamDungeonComponent.AddTeamDropItem(unit, drops[i]);   //这个地方通知客户端弹窗需求还是放弃
                    continue;
                }

                //普通道具直接随机分配
                M2C_SyncChatInfo m2C_SyncChatInfo = FubenHelp.m2C_SyncChatInfo;
                m2C_SyncChatInfo.ChatInfo = new ChatInfo();
                m2C_SyncChatInfo.ChatInfo.PlayerLevel = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                m2C_SyncChatInfo.ChatInfo.Occ = unit.GetComponent<UserInfoComponent>().UserInfo.Occ;
                m2C_SyncChatInfo.ChatInfo.ChannelId = (int)ChannelEnum.Pick;
                string colorValue = ComHelp.QualityReturnColor(itemConfig.ItemQuality);
                string numShow = "";
                if (itemConfig.Id == 1)
                {
                    numShow = unitDrop.GetComponent<DropComponent>().ItemNum.ToString();
                }

                Unit owner = null;
                if (drops[i].DropType == 1)
                {
                    owner = unit;
                }
                else
                {
                    //已经分配过的
                    if (teamDungeonComponent.ItemFlags.ContainsKey(unitDrop.Id))
                    {
                        owner = unit.DomainScene().GetComponent<UnitComponent>().Get(teamDungeonComponent.ItemFlags[unitDrop.Id]);
                        m2C_SyncChatInfo.ChatInfo.ChatMsg = $"{teamDungeonComponent.TeamPlayers[teamDungeonComponent.ItemFlags[unitDrop.Id]].PlayerName}拾取{itemConfig.ItemName}";
                    }
                    else
                    {
                        int maxRollpoint = 0;
                        long maxPlayerId = 0;
                        Dictionary<long, TeamPlayerInfo> allPlayer = teamDungeonComponent.TeamPlayers;
                        foreach((long uid, TeamPlayerInfo TeamPlayerInfo) in allPlayer)
                        {
                            int rollpoint = 0;
                            if (teshuItem && TeamPlayerInfo.RobotId > 0)
                            {
                                rollpoint = 0;
                            }
                            else
                            {
                                rollpoint = (RandomHelper.RandomNumber(1, 100));
                            }

                            if (rollpoint >= maxRollpoint)
                            {
                                maxRollpoint = rollpoint;
                                maxPlayerId = uid;
                            }
                            m2C_SyncChatInfo.ChatInfo.ChatMsg += $"{TeamPlayerInfo.PlayerName}:{rollpoint}点";
                            m2C_SyncChatInfo.ChatInfo.ChatMsg += "  ";
                        }
                        
                        teamDungeonComponent.ItemFlags.Add(unitDrop.Id, maxPlayerId);
                        owner = unit.DomainScene().GetComponent<UnitComponent>().Get(maxPlayerId);
                        m2C_SyncChatInfo.ChatInfo.ChatMsg = $"<color=#FDD376>{teamDungeonComponent.TeamPlayers[maxPlayerId].PlayerName}</color>拾取<color=#{colorValue}>{numShow}{itemConfig.ItemName}</color>({m2C_SyncChatInfo.ChatInfo.ChatMsg})";
                    }
                }
                if (owner == null)
                {
                    return ErrorCore.ERR_ItemBelongOther;
                }

                List<RewardItem> rewardItems = new List<RewardItem>();
                rewardItems.Add(new RewardItem() { ItemID = addItemID, ItemNum = addItemNum });

                bool success = owner.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.PickItem}_{TimeHelper.ServerNow()}");
                if (!success)
                {
                    return owner.Id == unit.Id ? ErrorCore.ERR_BagIsFull : ErrorCore.ERR_ItemDropProtect;
                }

                if (drops[i].DropType != 1)
                {
                    owner.DomainScene().GetComponent<UnitComponent>().Remove(unitDrop.Id);
                }
                MessageHelper.SendToClient(FubenHelp.GetUnitList(unit.DomainScene(), UnitType.Player), m2C_SyncChatInfo);
            }

            return ErrorCore.ERR_Success;
        }

        protected override async ETTask Run(Unit unit, Actor_PickItemRequest request, Actor_PickItemResponse response, Action reply)
        {
            //DropType ==  0 公共掉落 2保护掉落   1私有掉落
            for (int i = request.ItemIds.Count - 1; i >= 0; i--) 
            {
                if (request.ItemIds[i].DropType != 1)
                {
                    continue;
                }
                bool have = false;
                UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
                for (int d = unitInfoComponent.Drops.Count - 1; d >= 0; d--)
                {
                    if (unitInfoComponent.Drops[d].ItemID == request.ItemIds[i].ItemID
                      && unitInfoComponent.Drops[d].ItemNum == request.ItemIds[i].ItemNum)
                    {
                        have = true;
                        unitInfoComponent.Drops.RemoveAt(d);
                        break;
                    }
                }
                if (!have)
                {
                    request.ItemIds.RemoveAt(i);
                }
            }
            Log.Warning($"Actor_PickItemRequest: {unit.Id} {request.ItemIds.Count}");
            int sceneTypeEnum = unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
            if (sceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                response.Error = OnTeamPick(unit, request);
            }
            else
            {
                response.Error = OnFubenPick(unit, request);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }

}
