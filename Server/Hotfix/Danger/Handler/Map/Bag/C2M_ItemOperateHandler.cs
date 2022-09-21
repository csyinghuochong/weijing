using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemOperateHandler : AMActorLocationRpcHandler<Unit, C2M_ItemOperateRequest, M2C_ItemOperateResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemOperateRequest request, M2C_ItemOperateResponse response, Action reply)
        {
            try
            {
                //获取UserID及User数据
                UserInfo useInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
                long bagInfoID = request.OperateBagID;

                ItemLocType locType = ItemLocType.ItemLocBag;
                if (request.OperateType == 2)
                {
                    ItemConfig config = ItemConfigCategory.Instance.Get( int.Parse(request.OperatePar) );
                    locType = config.ItemType == (int)ItemTypeEnum.PetHeXin ? ItemLocType.ItemPetHeXinBag : locType;
                }
                if (request.OperateType == 4)
                {
                    locType = ItemLocType.ItemLocEquip;
                }
                if (request.OperateType == 7)
                {
                    locType = (ItemLocType)(int.Parse(request.OperatePar));
                }
                if (request.OperateType == 10)
                {
                    locType = ItemLocType.ItemLocGem;
                }

                int weizhi = -1;
                ItemConfig itemCof = null;
                BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(locType, bagInfoID);
                if (useBagInfo != null)
                {
                    itemCof = ItemConfigCategory.Instance.Get(useBagInfo.ItemID);
                    weizhi = ItemHelper.ReturnEquipSpaceNum(itemCof.ItemSubType);
                }

                //通知客户端背包刷新
                M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
                //通知客户端背包道具发生改变
                m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();

                //使用道具
                if (request.OperateType == 1) 
                {
                    //获取背包数据
                    int costNumber = 1;
                    ItemConfig itemConf = ItemConfigCategory.Instance.Get(useBagInfo.ItemID);
                    bool bagIsFull = false;
                    List<RewardItem> droplist = new List<RewardItem>();

                    if (itemCof.ItemSubType == 8)
                    {
                        string[] duihuanparams = itemConf.ItemUsePar.Split(';');
                        int neednum = int.Parse(duihuanparams[0]);
                        if (unit.GetComponent<BagComponent>().GetItemNumber(itemCof.Id) < neednum)
                        {
                            response.Error = ErrorCore.ERR_ItemNotEnoughError;
                            reply();
                            return;
                        }
                    }
                    if (itemCof.ItemSubType == 9)
                    { 
                        string[] itemPar = itemConf.ItemUsePar.Split(';');
                        if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RechargeNumber) < long.Parse(itemPar[0]))
                        {
                            response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                            reply();
                            return;
                        }
                    }
                     if (itemConf.ItemSubType == 102 || (itemConf.ItemSubType == 103))
                    {
                        if (unit.GetComponent<BagComponent>().GetSpaceNumber() < 1)
                        {
                            bagIsFull = true;
                        }
                    }
                    if (itemConf.ItemSubType == 104)
                    {
                        int dropid = int.Parse(itemConf.ItemUsePar);
                        droplist = new List<RewardItem>();
                        DropHelper.DropIDToDropItem(dropid, droplist);
                        if (unit.GetComponent<BagComponent>().GetSpaceNumber() < droplist.Count)
                        {
                            bagIsFull = true;
                        }
                    }
                    if (itemCof.ItemSubType == 110 && unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum != (int)SceneTypeEnum.YeWaiScene)
                    {
                        response.Error = ErrorCore.ERR_ItemOnlyUseMiJing;
                        reply();
                        return;
                    }
                    if (itemCof.ItemSubType == 14      //召唤卷轴
                        || itemCof.ItemSubType == 114) //宝石
                    {
                        costNumber = 0;
                    }
                    if (bagIsFull)
                    {
                        response.Error = ErrorCore.ERR_BagIsFull;
                        reply();
                        return;
                    }
                    if (itemConf.ItemType != 1
                       && itemConf.ItemType != 2)
                    {
                        reply();
                        return;
                    }
                    if (unit.GetComponent<BagComponent>().OnCostItemData(useBagInfo, ItemLocType.ItemLocBag, costNumber)) 
                    {
                        bool costItemStatus = true;
                        //根据道具子类分发不同的功能
                        switch (itemConf.ItemSubType)
                        {
                            //增加金币
                            case 1:
                                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, itemConf.ItemUsePar).Coroutine();
                                break;
                            //增加经验
                            case 2:
                                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Exp, itemConf.ItemUsePar).Coroutine();
                                break;
                            //回城卷轴[返回另外一个副本场景]
                            case 4:
                                if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                                {
                                    LocalDungeonComponent localDungeon = unit.DomainScene().GetComponent<LocalDungeonComponent>();
                                    TransferHelper.DungeonTransfer(unit,0, int.Parse(itemConf.ItemUsePar), localDungeon.Difficulty);
                                }
                                break;
                                //图纸制造
                            case 5:
                                break;
                                //随机宝箱
                            case 6:
                                List<RewardItem> rewardItems = new List<RewardItem>();
                                DropHelper.DropIDToDropItem_2(int.Parse(itemCof.ItemUsePar), rewardItems);
                                unit.GetComponent<BagComponent>().OnAddItemData(rewardItems,0, $"{ItemGetWay.ItemBox}_{TimeHelper.ServerNow()}");
                                break;
                            //兑换：
                            case 8:
                                string[] duihuanparams = itemConf.ItemUsePar.Split(';');
                                int neednum = int.Parse(duihuanparams[0]);
                                int newItem = int.Parse(duihuanparams[1]);

                                unit.GetComponent<BagComponent>().OnCostItemData($"{itemConf.Id};{neednum - 1}");
                                unit.GetComponent<BagComponent>().OnAddItemData($"{newItem};1", $"{ItemGetWay.ItemBox}_{TimeHelper.ServerNow()}");
                                break;
                            case 9:
                                rewardItems = new List<RewardItem>();
                                string[] rewardInfos = itemCof.ItemUsePar.Split(';');
                                DropHelper.DropIDToDropItem_2(int.Parse(rewardInfos[1]), rewardItems);
                                unit.GetComponent<BagComponent>().OnAddItemData(rewardItems,0, $"{ItemGetWay.ItemBox}_{TimeHelper.ServerNow()}");
                                break;
                            //冷却时间清空卷轴"
                            case 12:
                                unit.GetComponent<UserInfoComponent>().UserInfo.MonsterRevives.Clear();
                                if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                                {
                                    unit.DomainScene().GetComponent<LocalDungeonComponent>().OnCleanMonsterCD();
                                }
                                break;
                                //召唤卷轴
                            case 14:
                                if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                                {
                                    UnitFactory.CreateTempPet(unit, int.Parse(itemConf.ItemUsePar));
                                }
                                break;
                            //使用技能
                            case 101:
                                C2M_SkillCmd cmd = new C2M_SkillCmd();
                                cmd.SkillID = int.Parse(itemConf.ItemUsePar);
                                cmd.TargetAngle = 0;
                                cmd.TargetID = unit.Id;                                         //默认给自己释放
                                var result =  unit.GetComponent<SkillManagerComponent>().OnUseSkill(cmd);     //触发技能
                                response.Message = result.Item2.ToString();
                                break;
                            //宠物蛋
                            case 102:
                                unit.GetComponent<PetComponent>().OnAddPet(int.Parse(itemConf.ItemUsePar));
                                break;
                            //随机宠物蛋
                            case 103:
                                int petId = DropHelper.GetRandomBoxItem_2(itemConf.ItemUsePar);
                                unit.GetComponent<PetComponent>().OnAddPet(petId);
                                break;
                            //随机盒子
                            case 104:
                                unit.GetComponent<BagComponent>().OnAddItemData(droplist,0, $"{ItemGetWay.ItemBox}_{TimeHelper.ServerNow()}");
                                break;
                            //指定道具
                            case 106:
                                unit.GetComponent<BagComponent>().OnAddItemData(itemConf.ItemUsePar, $"{ItemGetWay.ItemBox}_{TimeHelper.ServerNow()}");
                                break;
                            //永久技能
                            case 107:
                                //判定职业是否符合
                                if (itemConf.ItemUsePar != "0")
                                {
                                    if (itemCof.ItemUsePar == unit.GetComponent<UserInfoComponent>().UserInfo.Occ.ToString() || itemCof.ItemUsePar == unit.GetComponent<UserInfoComponent>().UserInfo.OccTwo.ToString())
                                    {
                                        //符合条件
                                    }
                                    else
                                    {
                                        //不符合条件
                                        costItemStatus = false;
                                        response.Error = ErrorCore.ERR_ItemUseError;
                                        break;
                                    }
                                }
                                unit.GetComponent<SkillSetComponent>().OnAddSkill(SkillSourceEnum.Book, int.Parse(itemConf.SkillID));
                                break;
                            case 108:   //宠物经验骨头
                            case 109:   //宠物经验牛奶
                                break;
                            case 110:
                                //1;20;70010101,70010102@21;70;70020101,70020102
                                int lv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                                string[] monsters = itemConf.ItemUsePar.Split('@');
                                for (int c = 0; c < monsters.Length; c++)
                                {
                                    await TimerComponent.Instance.WaitAsync(1);
                                    //1;20;70010101,70010102
                                    string[] lelveparams = monsters[c].Split(";");
                                    int level_1 = int.Parse(lelveparams[0]);
                                    int level_2 = int.Parse(lelveparams[1]);
                                    if (lv < level_1 || lv > level_2)
                                    {
                                        continue;
                                    }
                                    string[] ids = lelveparams[2].Split(',');
                                    int r_number = RandomHelper.RandomNumber(0, ids.Length);
                                    Vector3 vector3 = new Vector3(unit.Position.x + RandomHelper.RandFloat01() * 1, unit.Position.y, unit.Position.z + RandomHelper.RandFloat01() * 1);
                                    Unit monster = UnitFactory.CreateMonster(unit.DomainScene(), vector3, FubenDifficulty.None, int.Parse(ids[r_number]), new CreateMonsterInfo());
                                }
                                break;
                            //金币袋子
                            case 111:
                                string[] jinbiInfos = itemConf.ItemUsePar.Split(';');
                                int userLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                                ExpConfig expConfig = ExpConfigCategory.Instance.Get(userLv);
                                int addCoin = (int)RandomHelper.RandomNumberFloat(float.Parse(jinbiInfos[0]) * expConfig.RoseGoldPro, float.Parse(jinbiInfos[1]) * expConfig.RoseGoldPro);
                                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, addCoin.ToString()).Coroutine();
                                break;
                            //经验木桩
                            case 112:
                                string[] expInfos = itemConf.ItemUsePar.Split('@');
                                int needZuanshi = request.OperatePar == "1" ?  int.Parse(expInfos[0]) : 0;
                                string[] paramInfo = expInfos[int.Parse(request.OperatePar)].Split(';');
                                userLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                                expConfig = ExpConfigCategory.Instance.Get(userLv);
                                int addExp = (int)RandomHelper.RandomNumberFloat(float.Parse(paramInfo[0]) * expConfig.RoseExpPro, float.Parse(paramInfo[1]) * expConfig.RoseExpPro);
                                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Exp, addExp.ToString()).Coroutine();
                                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Diamond, (needZuanshi * -1).ToString()).Coroutine();
                                response.OperatePar = addExp.ToString();
                                break;
                                //藏宝图
                            case 113:
                                int dropid = int.Parse(useBagInfo.ItemPar.Split('@')[2]);
                                UnitFactory.CreateDropItems(unit, dropid,  request.OperatePar);
                                break;
                            case 114: //宝石
                                break;
                            case 115://宠物皮肤激活道具
                                unit.GetComponent<PetComponent>().OnUnlockSkin(itemConf.ItemUsePar);
                                break;
                            case 116:   //角色洗点
                                unit.GetComponent<HeroDataComponent>().OnResetPoint();
                                break;
                            case 117:   //宠物洗点
                            case 118:   //宠物资质
                            case 119:   //宠物成长
                                break;
                            case 120://120 冒险积分
                                unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.MaoXianExp, int.Parse(itemCof.ItemUsePar), 0 );
                                break;
                            case 121:
                                break;
                            case 122:   //宠物技能书
                                break;
                        }

                        //扣除道具
                        if (costItemStatus)
                        {
                            if (useBagInfo.ItemNum == 0)
                            {
                                m2c_bagUpdate.BagInfoDelete.Add(useBagInfo);
                            }
                            else
                            {
                                m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
                            }
                        }
                    }
                }

                //出售道具
                if (request.OperateType == 2 && locType == ItemLocType.ItemLocBag) 
                {
                    //默认出售全部
                    //给与对应金币或货币奖励
                    string[] gemids = useBagInfo.GemID.Split('_');
                    List<long> gemIdList =  new List<long>();
                    ItemConfig itemConf = null;
                    for (int i = 0; i < gemids.Length; i++)
                    {
                        if (gemids[i]== "0")
                        {
                            continue;
                        }
                        gemIdList.Add(long.Parse(gemids[i]));
                        BagInfo bagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocGem, long.Parse(gemids[i]));
                        itemConf = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                        unit.GetComponent<UserInfoComponent>().UpdateRoleData((UserDataType)itemConf.SellMoneyType, (bagInfo.ItemNum * itemConf.SellMoneyValue).ToString()).Coroutine();
                    }
                    unit.GetComponent<BagComponent>().OnCostItemData(gemIdList, ItemLocType.ItemLocGem);

                    itemConf = ItemConfigCategory.Instance.Get(useBagInfo.ItemID);
                    unit.GetComponent<UserInfoComponent>().UpdateRoleData((UserDataType)itemConf.SellMoneyType, (useBagInfo.ItemNum * itemConf.SellMoneyValue).ToString()).Coroutine();
                    unit.GetComponent<BagComponent>().OnCostItemData(useBagInfo, locType, useBagInfo.ItemNum);
                    if (useBagInfo.ItemNum == 0)
                    {
                        m2c_bagUpdate.BagInfoDelete.Add(useBagInfo);
                    }
                    else
                    {
                        m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
                    }
                }

                if (request.OperateType == 2 && locType == ItemLocType.ItemPetHeXinBag)
                {
                    //默认出售全部
                    //给与对应金币或货币奖励
                    unit.GetComponent<UserInfoComponent>().UpdateRoleData((UserDataType)itemCof.SellMoneyType, (useBagInfo.ItemNum * itemCof.SellMoneyValue).ToString()).Coroutine();
                    unit.GetComponent<BagComponent>().OnCostItemData(useBagInfo, locType, useBagInfo.ItemNum);
                    if (useBagInfo.ItemNum == 0)
                    {
                        m2c_bagUpdate.BagInfoDelete.Add(useBagInfo);
                    }
                    else
                    {
                        m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
                    }
                }

                //穿戴装备
                if (request.OperateType == 3)
                {
                    //判断等级
                    int roleLv = useInfo.Lv;
                    int equipLv = itemCof.UseLv;
                    if (roleLv < equipLv)
                    {
                        response.Error = ErrorCore.ERR_EquipLvLimit;     //错误码:无效的装备ID
                        reply();
                        return;
                    }

                    //获取之前的位置是否有装备
                    BagInfo beforeequip = null;
                    if (weizhi == 5 && !ComHelp.IsBanHaoZone(unit.DomainZone()))
                    {
                        List<BagInfo> equipList = unit.GetComponent<BagComponent>().GetEquipListByWeizhi(weizhi);
                        beforeequip = equipList.Count < 3 ? null : equipList[0];
                    }
                    else
                    {
                        beforeequip = unit.GetComponent<BagComponent>().GetEquipByWeizhi(weizhi);
                    }
                    if (beforeequip != null)
                    {
                        unit.GetComponent<BagComponent>().OnChangeItemLoc(beforeequip, ItemLocType.ItemLocBag, ItemLocType.ItemLocEquip);
                        unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.ItemLocEquip, ItemLocType.ItemLocBag);

                        unit.GetComponent<SkillSetComponent>().OnTakeOffEquip(beforeequip);
                        unit.GetComponent<SkillSetComponent>().OnWearEquip(useBagInfo);
                        m2c_bagUpdate.BagInfoUpdate.Add(beforeequip);
                    }
                    else
                    {
                        unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.ItemLocEquip, ItemLocType.ItemLocBag);
                        unit.GetComponent<SkillSetComponent>().OnWearEquip(useBagInfo);
                    }
                    useBagInfo.isBinging = true;
                    Function_Fight.GetInstance().UnitUpdateProperty_Base(unit);
                    m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);

                    if (weizhi == (int)ItemSubTypeEnum.Wuqi)
                    {
                        unit.GetComponent<SkillPassiveComponent>().OnTrigegerPassiveSkill(SkillPassiveTypeEnum.WandBuff_8, useBagInfo.ItemID);
                        unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Weapon, useBagInfo.ItemID);
                    }
                }

                //卸下装备
                if (request.OperateType == 4)
                {
                    //判断背包格子是否足够
                    bool full = unit.GetComponent<BagComponent>().IsBagFull();
                    if (full)
                    {
                        response.Error = ErrorCore.ERR_BagIsFull;
                        reply();
                        return;
                    }

                    unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.ItemLocBag, ItemLocType.ItemLocEquip);
                    unit.GetComponent<SkillSetComponent>().OnTakeOffEquip(useBagInfo);
                    Function_Fight.GetInstance().UnitUpdateProperty_Base(unit);
                    m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
                    if (weizhi == (int)ItemSubTypeEnum.Wuqi)
                    {
                        unit.GetComponent<SkillPassiveComponent>().OnTrigegerPassiveSkill(SkillPassiveTypeEnum.WandBuff_8, 0);
                        unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Weapon, 0);
                    }
                }

                //鉴定装备
                if (request.OperateType == 5)
                {
                    //判定材料消耗
                    bool ifSell = false;     //默认出售全部
                    long baginfoId = long.Parse(request.OperatePar);
                    int rolelv = useInfo.Lv;
                    string qulitylv = "";

                    if (baginfoId == 0)        
                    {
                        //金币鉴定，扣除金币
                        ifSell = unit.GetComponent<BagComponent>().OnCostItemData($"1;{ComHelp.GetJianDingCoin(rolelv)}");
                        qulitylv = itemCof.UseLv.ToString();
                    }
                    else
                    {
                        //道具鉴定，扣除道具
                        ifSell = unit.GetComponent<BagComponent>().OnCostItemData(baginfoId,1);
                        qulitylv = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, baginfoId).ItemPar;
                        qulitylv = string.IsNullOrEmpty(qulitylv) ? "0" : qulitylv;
                    }
                    if (ifSell)
                    {
                        //未鉴定才可以
                        useBagInfo.IfJianDing = false;
                        useBagInfo.HideProLists = ComHelp.GetEquipZhuanJingHidePro(itemCof.ItemEquipID, itemCof.Id, int.Parse(qulitylv));
                        m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
                    }
                    else 
                    {
                        response.Error = ErrorCore.ERR_ItemNotEnoughError;
                        reply();
                        return;
                    }
                }

                //放入仓库
                if (request.OperateType == 6)
                {
                    int hourseId = int.Parse(request.OperatePar);
                    if (unit.GetComponent<BagComponent>().IsHourseFullByLoc(hourseId))
                    {
                        response.Error = ErrorCore.ERR_BagIsFull;     //错误码:仓库已满
                        reply();
                        return;
                    }

                    unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, (ItemLocType)hourseId, ItemLocType.ItemLocBag);

                    m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
                }

                //放回背包
                if (request.OperateType == 7)
                {
                    int hourseId = useBagInfo.Loc;
                    if (unit.GetComponent<BagComponent>().IsBagFull())
                    {
                        response.Error = ErrorCore.ERR_BagIsFull;     //错误码:仓库已满
                        reply();
                        return;
                    }

                    unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.ItemLocBag, (ItemLocType)hourseId);

                    m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
                }

                //整理背包
                if (request.OperateType == 8)
                {
                    unit.GetComponent<BagComponent>().OnRecvItemSort((ItemLocType)(int.Parse(request.OperatePar)));
                }

                //镶嵌宝石
                if (request.OperateType == 9)
                { 
                    //宝石镶嵌
                    string[] geminfos = request.OperatePar.Split('_');
                    long equipid = long.Parse(geminfos[0]);
                    int gemIndex = int.Parse(geminfos[1]);

                    //获取装备baginfo
                    BagInfo equipInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip, equipid);
                    if (equipInfo == null)
                    {
                        equipInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, equipid);
                    }
                    if (equipInfo == null)
                    {
                        Log.Error($"equipInfo == null {equipid}");
                        reply();
                        return;
                    }
                    string[] gemIdList = equipInfo.GemID.Split('_');
                    gemIdList[gemIndex] = useBagInfo.BagInfoID.ToString();
                    equipInfo.GemID = "";
                    for (int i = 0; i < gemIdList.Length; i++)
                    {
                        equipInfo.GemID = equipInfo.GemID  + gemIdList[i] + "_";
                    }
                    equipInfo.GemID = equipInfo.GemID.Substring(0, equipInfo.GemID.Length - 1);

                    //改变宝石loc
                    unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.ItemLocGem, ItemLocType.ItemLocBag);
                    m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
                    m2c_bagUpdate.BagInfoUpdate.Add(equipInfo);

                    Function_Fight.GetInstance().UnitUpdateProperty_Base(unit);
                }

                //卸下宝石
                if (request.OperateType == 10)
                {
                    //宝石镶嵌
                    string[] geminfos = request.OperatePar.Split('_');
                    long equipid = long.Parse(geminfos[0]);
                    int gemIndex = int.Parse(geminfos[1]);

                    //获取装备baginfo
                    BagInfo equipInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip, equipid);
                    if (equipInfo == null)
                    {
                        equipInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, equipid);
                    }
                    if (equipInfo == null)
                    {
                        Log.Error($"equipInfo == null {equipid}");
                        reply();
                        return;
                    }
                    string[] gemIdList = equipInfo.GemID.Split('_');
                    gemIdList[gemIndex] = "0";
                    equipInfo.GemID = "";
                    for (int i = 0; i < gemIdList.Length; i++)
                    {
                        equipInfo.GemID = equipInfo.GemID + gemIdList[i] + "_";
                    }
                    equipInfo.GemID = equipInfo.GemID.Substring(0, equipInfo.GemID.Length - 1);

                    //改变宝石loc
                    unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.ItemLocBag, ItemLocType.ItemLocGem);
                    m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
                    m2c_bagUpdate.BagInfoUpdate.Add(equipInfo);

                    Function_Fight.GetInstance().UnitUpdateProperty_Base(unit);
                }

                MessageHelper.SendToClient(unit, m2c_bagUpdate);
                //通知客户端属性刷新
                reply();
                await ETTask.CompletedTask;
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
        }
    }
}
