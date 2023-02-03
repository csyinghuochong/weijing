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
            M2C_SyncChatInfo m2C_SyncChatInfo = new M2C_SyncChatInfo();
            long serverTime = TimeHelper.ServerNow();
            //DropType ==  0 公共掉落 2保护掉落   1私有掉落
            for (int i = 0; i < drops.Count; i++)
            {
                Unit unitDrop = unit.DomainScene().GetComponent<UnitComponent>().Get(drops[i].UnitId);
                DropComponent dropComponent = unitDrop.GetComponent<DropComponent>();

                if (drops[i].DropType != 1)
                {
                    if (unitDrop == null)
                    {
                        continue;
                    }

                    
                    if (dropComponent.OwnerId!=0 && dropComponent.OwnerId!=unit.Id && serverTime < dropComponent.ProtectTime)
                    {
                        return ErrorCore.ERR_ItemDropProtect;
                    }
                }

                int addItemID = dropComponent.ItemID;
                int addItemNum = dropComponent.ItemNum;
                List<RewardItem> rewardItems = new List<RewardItem>();
                rewardItems.Add(new RewardItem() { ItemID = addItemID, ItemNum = addItemNum });
                bool success = unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, "", $"{ItemGetWay.PickItem}_{TimeHelper.ServerNow()}");
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
                FubenHelp.SendPickMessage(unit, drops[i], m2C_SyncChatInfo);
            }
            
            return ErrorCore.ERR_Success;
        }

        private int OnTeamPick(Unit unit, Actor_PickItemRequest request)
        {
            List<DropInfo> drops = request.ItemIds;
            long serverTime = TimeHelper.ServerNow();

            TeamDungeonComponent teamDungeonComponent = unit.DomainScene().GetComponent<TeamDungeonComponent>();
            List<Unit> allPlayer = unit.GetUnitList(UnitType.Player);
            for (int i = 0; i < drops.Count; i++)
            {
                Unit unitDrop = unit.DomainScene().GetComponent<UnitComponent>().Get(drops[i].UnitId);
                if (drops[i].DropType != 1)
                {
                    if (unitDrop == null)
                    {
                        continue;
                    }
                    DropComponent dropComponent = unitDrop.GetComponent<DropComponent>();
                    if (dropComponent.OwnerId != 0 && dropComponent.OwnerId != unit.Id && serverTime < dropComponent.ProtectTime)
                    {
                        return ErrorCore.ERR_ItemDropProtect;
                    }
                }

                int addItemID = drops[i].ItemID;
                int addItemNum = drops[i].ItemNum;
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(addItemID);
                //紫色品质通知客户端抉择
                //DropType ==  0 公共掉落 2保护掉落   1私有掉落
                if (drops[i].DropType != 1 && itemConfig.ItemQuality >= 4)
                {
                    teamDungeonComponent.AddTeamDropItem(unit, drops[i]);
                    continue;
                }
                M2C_SyncChatInfo m2C_SyncChatInfo = teamDungeonComponent.m2C_SyncChatInfo;
                m2C_SyncChatInfo.ChatInfo = new ChatInfo();
                m2C_SyncChatInfo.ChatInfo.PlayerLevel = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                m2C_SyncChatInfo.ChatInfo.Occ = unit.GetComponent<UserInfoComponent>().UserInfo.Occ;
                m2C_SyncChatInfo.ChatInfo.ChannelId = (int)ChannelEnum.System;

                Unit owner = null;
              
                if (drops[i].DropType == 1)
                {
                    owner = unit;
                }
                //已经有归属了
                else if (teamDungeonComponent.ItemFlags.ContainsKey(unitDrop.Id))
                {
                    owner = unit.DomainScene().GetComponent<UnitComponent>().Get(teamDungeonComponent.ItemFlags[unitDrop.Id]);
                    m2C_SyncChatInfo.ChatInfo.ChatMsg = $"{owner.GetComponent<UserInfoComponent>().UserInfo.Name}拾取{itemConfig.ItemName}";
                }
                if (owner == null)
                {
                    int maxNumber = 0;
                    List<int> randomNumbers = new List<int>();
                    for (int p = 0; p < allPlayer.Count; p++)
                    {
                        randomNumbers.Add(RandomHelper.RandomNumber(1, 100));
                        if (randomNumbers[p] > maxNumber)
                        {
                            maxNumber = randomNumbers[p];
                        }
                        m2C_SyncChatInfo.ChatInfo.ChatMsg += $"{allPlayer[p].GetComponent<UserInfoComponent>().UserInfo.Name}:{randomNumbers[p]}点";
                        m2C_SyncChatInfo.ChatInfo.ChatMsg += (p == allPlayer.Count - 1 ? "" : "  ");
                    }
                    owner = allPlayer[randomNumbers.IndexOf(maxNumber)];
                    string colorValue = ComHelp.QualityReturnColor(itemConfig.ItemQuality);
                    string numShow = "";
                    if (itemConfig.Id == 1)
                    {
                        numShow = unitDrop.GetComponent<DropComponent>().ItemNum.ToString();
                    }
                    m2C_SyncChatInfo.ChatInfo.ChatMsg = $"<color=#FDD376>{owner.GetComponent<UserInfoComponent>().UserInfo.Name}</color>拾取<color=#{colorValue}>{numShow}{itemConfig.ItemName}</color>({m2C_SyncChatInfo.ChatInfo.ChatMsg})";
                }

                List<RewardItem> rewardItems = new List<RewardItem>();
                rewardItems.Add(new RewardItem() { ItemID = addItemID, ItemNum = addItemNum });

                bool success = owner.GetComponent<BagComponent>().OnAddItemData(rewardItems, "", $"{ItemGetWay.PickItem}_{TimeHelper.ServerNow()}");
                if (!success && !teamDungeonComponent.ItemFlags.ContainsKey(unitDrop.Id))
                {
                    teamDungeonComponent.ItemFlags.Add(unitDrop.Id, owner.Id);
                    continue;
                }

                //移除掉落
                if (drops[i].DropType != 1)
                {
                    owner.DomainScene().GetComponent<UnitComponent>().Remove(unitDrop.Id);
                }

                MessageHelper.SendToClient(allPlayer, m2C_SyncChatInfo);
            }

            return ErrorCode.ERR_Success;
        }

        protected override async ETTask Run(Unit unit, Actor_PickItemRequest request, Actor_PickItemResponse response, Action reply)
        {
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
