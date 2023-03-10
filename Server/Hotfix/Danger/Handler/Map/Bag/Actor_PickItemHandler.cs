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
            for (int i = 0; i < drops.Count; i++)
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
            List<Unit> allPlayer = unit.GetUnitList(UnitType.Player);
            for (int i = 0; i < drops.Count; i++)
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

                int addItemID = dropComponent!=null ? dropComponent.ItemID : drops[i].ItemID;
                int addItemNum = dropComponent != null ? dropComponent.ItemNum : drops[i].ItemNum;
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(addItemID);

                bool teshuItem = itemConfig.ItemQuality == 5 && itemConfig.ItemType == 2 && itemConfig.ItemSubType == 1;

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

                Unit owner = null;
              
                if (drops[i].DropType == 1)
                {
                    owner = unit;
                }
                else
                {
                    if (teamDungeonComponent.ItemFlags.ContainsKey(unitDrop.Id))
                    {
                        owner = unit.DomainScene().GetComponent<UnitComponent>().Get(teamDungeonComponent.ItemFlags[unitDrop.Id]);
                        if (owner != null)
                        {
                            m2C_SyncChatInfo.ChatInfo.ChatMsg = $"{owner.GetComponent<UserInfoComponent>().UserInfo.Name}拾取{itemConfig.ItemName}";
                        }
                    }
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

                bool success = owner.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.PickItem}_{TimeHelper.ServerNow()}");
                if (!success && unitDrop!=null && !teamDungeonComponent.ItemFlags.ContainsKey(unitDrop.Id))
                {
                    teamDungeonComponent.ItemFlags.Add(unitDrop.Id, owner.Id);
                    continue;
                }

                if (success)
                {
                    if (drops[i].DropType != 1)
                    {
                        owner.DomainScene().GetComponent<UnitComponent>().Remove(unitDrop.Id);
                    }
                    MessageHelper.SendToClient(allPlayer, m2C_SyncChatInfo);
                }
            }

            return ErrorCode.ERR_Success;
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
