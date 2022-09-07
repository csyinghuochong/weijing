using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_PickItemHandler : AMActorLocationRpcHandler<Unit, Actor_PickItemRequest, Actor_PickItemResponse>
    {
        protected override async ETTask Run(Unit unit, Actor_PickItemRequest request, Actor_PickItemResponse response, Action reply)
        {
            List<DropInfo> drops = request.ItemIds;
            List<long> removeIds = new List<long>();

            int sceneTypeEnum = unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
            if (sceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                TeamDungeonComponent teamDungeonComponent = unit.DomainScene().GetComponent<TeamDungeonComponent>();

                List<Unit> allPlayer = new List<Unit>();
                foreach ((long id, Entity value) in unit.DomainScene().GetComponent<UnitComponent>().Children)
                {
                    if (value.GetComponent<UnitInfoComponent>().Type == UnitType.Player)
                    {
                        allPlayer.Add(value as Unit);
                    }
                }

                M2C_SyncChatInfo m2C_SyncChatInfo = new M2C_SyncChatInfo();
                for (int i = 0; i < drops.Count; i++)
                {
                    Unit unitDrop = unit.DomainScene().GetComponent<UnitComponent>().Get(drops[i].UnitId);
                    if (drops[i].DropType == 0 && unitDrop == null)
                    {
                        continue;
                    }
                    m2C_SyncChatInfo.ChatInfo = new ChatInfo();
                    m2C_SyncChatInfo.ChatInfo.PlayerLevel = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                    m2C_SyncChatInfo.ChatInfo.Occ = unit.GetComponent<UserInfoComponent>().UserInfo.Occ;
                    m2C_SyncChatInfo.ChatInfo.ChannelId = (int)ChannelEnum.System;

                    int addItemID = drops[i].ItemID;
                    int addItemNum = drops[i].ItemNum;
                    ItemConfig itemConfig = ItemConfigCategory.Instance.Get(addItemID);

                    Unit owner = null;
                    //已经有归属了
                    if (teamDungeonComponent.ItemFlags.ContainsKey(unitDrop.Id))
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

                    bool success = owner.GetComponent<BagComponent>().OnAddItemData(rewardItems, 0, $"{ItemGetWay.PickItem}_{TimeHelper.ServerNow()}");
                    if (!success)
                    {
                        if (!teamDungeonComponent.ItemFlags.ContainsKey(unitDrop.Id))
                        {
                            teamDungeonComponent.ItemFlags.Add(unitDrop.Id, owner.Id);
                        }
                        continue;
                    }

                    //移除掉落
                    owner.DomainScene().GetComponent<UnitComponent>().Remove(unitDrop.Id);       //移除掉落ID
                    removeIds.Add(drops[i].UnitId);

                    MessageHelper.Broadcast(unit, m2C_SyncChatInfo);
                }
            }
            else
            {
                M2C_SyncChatInfo m2C_SyncChatInfo = new M2C_SyncChatInfo();

                for (int i = 0; i < drops.Count; i++)
                {
                    Unit unitDrop = unit.DomainScene().GetComponent<UnitComponent>().Get(drops[i].UnitId);
                    if (drops[i].DropType == 0 && unitDrop == null)
                    {
                        continue;
                    }
                    int addItemID = drops[i].ItemID;
                    int addItemNum = drops[i].ItemNum;
                    List<RewardItem> rewardItems = new List<RewardItem>();
                    rewardItems.Add(new RewardItem() { ItemID = addItemID, ItemNum = addItemNum });
                    bool success = unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, 0, $"{ItemGetWay.PickItem}_{TimeHelper.ServerNow()}");
                    if (!success)
                    {
                        response.Error = ErrorCore.ERR_BagIsFull;
                        break;
                    }

                    //移除掉落
                    if (drops[i].DropType == 0)
                    {
                        unit.DomainScene().GetComponent<UnitComponent>().Remove(unitDrop.Id);       //移除掉落ID
                        removeIds.Add(drops[i].UnitId);
                    }

                    m2C_SyncChatInfo.ChatInfo = new ChatInfo();
                    m2C_SyncChatInfo.ChatInfo.PlayerLevel = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                    m2C_SyncChatInfo.ChatInfo.Occ = unit.GetComponent<UserInfoComponent>().UserInfo.Occ;
                    m2C_SyncChatInfo.ChatInfo.ChannelId = (int)ChannelEnum.System;

                    ItemConfig itemConfig = ItemConfigCategory.Instance.Get(addItemID);
                    string numShow = "";
                    if (itemConfig.Id == 1)
                    {
                        numShow = addItemNum.ToString();
                    }
                    string colorValue = ComHelp.QualityReturnColor(itemConfig.ItemQuality);
                    m2C_SyncChatInfo.ChatInfo.ChatMsg = $"<color=#FDD376>{unit.GetComponent<UserInfoComponent>().UserInfo.Name}</color>拾取<color=#{colorValue}>{numShow}{itemConfig.ItemName}</color>";
                    MessageHelper.Broadcast(unit, m2C_SyncChatInfo);
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }

}
