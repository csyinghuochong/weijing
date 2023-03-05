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
                UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
                UserInfo useInfo = userInfoComponent.UserInfo;
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

                int weizhi = -1;
                ItemConfig itemConfig = null;
                BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(locType, bagInfoID);
                if (useBagInfo == null && request.OperateType!= 8)
                {
                    Log.Debug($"{request.OperateType} {request.OperateBagID}");
                    reply();
                    return;
                }

                if (useBagInfo != null)
                {
                    itemConfig = ItemConfigCategory.Instance.Get(useBagInfo.ItemID);
                    weizhi = itemConfig.ItemSubType;
                }
               
                //通知客户端背包刷新
                M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
                //通知客户端背包道具发生改变
                m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();

                //使用道具
                if (request.OperateType == 1 && itemConfig != null) 
                {
                    if (itemConfig.DayUseNum > 0 && userInfoComponent.GetDayItemUse(itemConfig.Id) >= itemConfig.DayUseNum)
                    {
                        response.Error = ErrorCore.ERR_ItemNoUseTime;
                        reply();
                        return;
                    }

                    //获取背包数据
                    int costNumber = 1;
                    bool bagIsFull = false;
                    List<RewardItem> droplist = new List<RewardItem>();
                    if (itemConfig.ItemSubType == 8)
                    {
                        string[] duihuanparams = itemConfig.ItemUsePar.Split(';');
                        int neednum = int.Parse(duihuanparams[0]);
                        if (unit.GetComponent<BagComponent>().GetItemNumber(itemConfig.Id) < neednum)
                        {
                            response.Error = ErrorCore.ERR_ItemNotEnoughError;
                            reply();
                            return;
                        }
                    }
                    if (itemConfig.ItemSubType == 9)
                    { 
                        string[] itemPar = itemConfig.ItemUsePar.Split(';');
                        if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RechargeNumber) < long.Parse(itemPar[0]))
                        {
                            response.Error = ErrorCore.ERR_NoPayValueError;
                            reply();
                            return;
                        }
                    }
                    if (itemConfig.ItemSubType == 102 || (itemConfig.ItemSubType == 103))
                    {
                        if (unit.GetComponent<BagComponent>().GetSpaceNumber() < 1)
                        {
                            bagIsFull = true;
                        }
                    }
                    if (itemConfig.ItemSubType == 104)
                    {
                        int dropid = int.Parse(itemConfig.ItemUsePar);
                        droplist = new List<RewardItem>();
                        DropHelper.DropIDToDropItem(dropid, droplist);
                        if (unit.GetComponent<BagComponent>().GetSpaceNumber() < droplist.Count)
                        {
                            bagIsFull = true;
                        }
                    }
                    if (itemConfig.ItemSubType == 110 && unit.DomainScene().GetComponent<MapComponent>().SceneId != 2000001)
                    {
                        response.Error = ErrorCore.ERR_ItemOnlyUseMiJing;
                        reply();
                        return;
                    }

                    if (itemConfig.ItemSubType == 14      //召唤卷轴
                        || itemConfig.ItemSubType == 114) //宝石
                    {
                        costNumber = 0;
                    }
                    if (itemConfig.ItemSubType == 112)
                    {
                        int openDay = DBHelper.GetOpenServerDay(unit.DomainZone());
                        if (openDay <= 1)
                        {
                            response.Error = ErrorCore.ERR_ItemNoUseTime;
                            reply();
                            return;
                        }
                    }

                    if (bagIsFull)
                    {
                        response.Error = ErrorCore.ERR_BagIsFull;
                        reply();
                        return;
                    }

                    if (itemConfig.ItemType != 1
                       && itemConfig.ItemType != 2)
                    {
                        reply();
                        return;
                    }
                    if (unit.GetComponent<BagComponent>().OnCostItemData(useBagInfo, ItemLocType.ItemLocBag, costNumber)) 
                    {
                        bool costItemStatus = true;
                        //根据道具子类分发不同的功能
                        switch (itemConfig.ItemSubType)
                        {
                            //增加金币
                            case 1:
                                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd(UserDataType.Gold, itemConfig.ItemUsePar);
                                break;
                            //增加经验
                            case 2:
                                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Exp, itemConfig.ItemUsePar);
                                break;
                            //回城卷轴[返回另外一个副本场景]
                            case 4:
                                if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                                {
                                    LocalDungeonComponent localDungeon = unit.DomainScene().GetComponent<LocalDungeonComponent>();
                                    TransferHelper.LocalDungeonTransfer(unit, 0, int.Parse(itemConfig.ItemUsePar), localDungeon.FubenDifficulty).Coroutine();
                                }
                                break;
                                //图纸制造
                            case 5:
                                break;
                                //随机宝箱
                            case 6:
                                List<RewardItem> rewardItems = new List<RewardItem>();
                                DropHelper.DropIDToDropItem_2(int.Parse(itemConfig.ItemUsePar), rewardItems);
                                unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.ItemBox}_{TimeHelper.ServerNow()}_{itemConfig.Id}");
                                break;
                            //兑换：
                            case 8:
                                string[] duihuanparams = itemConfig.ItemUsePar.Split(';');
                                int neednum = int.Parse(duihuanparams[0]);
                                int newItem = int.Parse(duihuanparams[1]);

                                unit.GetComponent<BagComponent>().OnCostItemData($"{itemConfig.Id};{neednum - 1}");
                                unit.GetComponent<BagComponent>().OnAddItemData($"{newItem};1", $"{ItemGetWay.ItemBox}_{TimeHelper.ServerNow()}");
                                break;
                            case 9:
                                rewardItems = new List<RewardItem>();
                                string[] rewardInfos = itemConfig.ItemUsePar.Split(';');
                                DropHelper.DropIDToDropItem(int.Parse(rewardInfos[1]), rewardItems);
                                unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.ItemBox}_{TimeHelper.ServerNow()}");
                                break;
                            //冷却时间清空卷轴"
                            case 12:
                                unit.GetComponent<UserInfoComponent>().OnCleanBossCD();
                                if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                                {
                                    unit.DomainScene().GetComponent<LocalDungeonComponent>().OnCleanBossCD();
                                }
                                break;
                                //召唤卷轴
                            case 14:
                                if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                                {
                                    UnitFactory.CreateTempFollower(unit, int.Parse(itemConfig.ItemUsePar));
                                }
                                break;
                            case 15:    //附魔道具
                                unit.GetComponent<BagComponent>().OnEquipFuMo(itemConfig.ItemUsePar);
                                unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.FoMoNumber_213, 0, 1);
                                break;
                            case 16: //附魔技能
                                unit.GetComponent<UserInfoComponent>().UserInfo.MakeList.Add(int.Parse(itemConfig.ItemUsePar));
                                break;
                            //使用技能
                            case 101:

                                break;
                            //宠物蛋
                            case 102:
                                unit.GetComponent<PetComponent>().OnAddPet(int.Parse(itemConfig.ItemUsePar));
                                break;
                            //随机宠物蛋
                            case 103:
                                int petId = DropHelper.GetRandomBoxItem_2(itemConfig.ItemUsePar);
                                unit.GetComponent<PetComponent>().OnAddPet(petId);
                                break;
                            //随机盒子
                            case 104:
                                unit.GetComponent<BagComponent>().OnAddItemData(droplist, string.Empty, $"{ItemGetWay.ItemBox}_{TimeHelper.ServerNow()}");
                                break;
                            //指定道具
                            case 106:
                                unit.GetComponent<BagComponent>().OnAddItemData(itemConfig.ItemUsePar, $"{ItemGetWay.ItemBox}_{TimeHelper.ServerNow()}");
                                break;
                            //永久技能
                            case 107:
                                //判定职业是否符合
                                if (itemConfig.ItemUsePar != "0")
                                {
                                    if (itemConfig.ItemUsePar == unit.GetComponent<UserInfoComponent>().UserInfo.Occ.ToString() || itemConfig.ItemUsePar == unit.GetComponent<UserInfoComponent>().UserInfo.OccTwo.ToString())
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
                                unit.GetComponent<SkillSetComponent>().OnAddSkill(SkillSourceEnum.Book, int.Parse(itemConfig.SkillID));
                                break;
                            case 108:   //宠物经验骨头
                            case 109:   //宠物经验牛奶
                                break;
                            case 110:
                                //1;20;70010101,70010102@21;70;70020101,70020102
                                int createMonsterID = 0;
                                int lv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                                string[] monsters = itemConfig.ItemUsePar.Split('@');
                                for (int c = 0; c < monsters.Length; c++)
                                {
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
                                    Unit monster = UnitFactory.CreateMonster(unit.DomainScene(), int.Parse(ids[r_number]), vector3, new CreateMonsterInfo()
                                    { 
                                        Camp = CampEnum.CampMonster1
                                    });

                                    createMonsterID = int.Parse(ids[r_number]);
                                }
                                //发送广播信息
                                if (createMonsterID != 0)
                                {
                                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(createMonsterID);
                                    ServerMessageHelper.SendServerMessage(DBHelper.GetChatServerId(unit.DomainZone()),
                                        NoticeType.Notice, "玩家" + unit.GetComponent<UserInfoComponent>().UserInfo.Name + "在宝藏之地召唤出领主怪物:<color=#FF75F0>" + monsterCof.MonsterName + "</color>").Coroutine();
                                }
                                break;
                            //金币袋子
                            case 111:
                                string[] jinbiInfos = itemConfig.ItemUsePar.Split(';');
                                int userLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                                ExpConfig expConfig = ExpConfigCategory.Instance.Get(userLv);
                                int addCoin = (int)RandomHelper.RandomNumberFloat(float.Parse(jinbiInfos[0]) * expConfig.RoseGoldPro, float.Parse(jinbiInfos[1]) * expConfig.RoseGoldPro);
                                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd(UserDataType.Gold, addCoin.ToString(), true, 39);
                                break;
                            //经验木桩
                            case 112:
                                string[] expInfos = itemConfig.ItemUsePar.Split('@');
                                int needZuanshi = request.OperatePar == "1" ?  int.Parse(expInfos[0]) : 0;
                                string[] paramInfo = expInfos[int.Parse(request.OperatePar)].Split(';');
                                userLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                                expConfig = ExpConfigCategory.Instance.Get(userLv);
                                int addExp = (int)RandomHelper.RandomNumberFloat(float.Parse(paramInfo[0]) * expConfig.RoseExpPro, float.Parse(paramInfo[1]) * expConfig.RoseExpPro);
                                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Exp, addExp.ToString());
                                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd(UserDataType.Diamond, (needZuanshi * -1).ToString());
                                response.OperatePar = addExp.ToString();
                                break;
                                //藏宝图
                            case 113:
                                int dropid = int.Parse(useBagInfo.ItemPar.Split('@')[2]);
                                UnitFactory.CreateDropItems(unit, unit, 0, dropid,  request.OperatePar);
                                break;
                            case 114: //宝石
                                break;
                            case 115://宠物皮肤激活道具
                                unit.GetComponent<PetComponent>().OnUnlockSkin(itemConfig.ItemUsePar);
                                break;
                            case 116:   //角色洗点
                                unit.GetComponent<HeroDataComponent>().OnResetPoint();
                                break;
                            case 117:   //宠物洗点
                            case 118:   //宠物资质
                            case 119:   //宠物成长
                                break;
                            case 120://120 冒险积分
                                unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.MaoXianExp, int.Parse(itemConfig.ItemUsePar), 0 );
                                break;
                            case 121: //鉴定符
                                break;
                            case 122:   //宠物技能书
                                break;
                            case 123:   //宠物扩展工具
                                unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.PetExtendNumber, 1, 0);
                                break;
                            case 124: //仓库扩展工具
                                int cangkuNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CangKuNumber);
                                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.CangKuNumber, cangkuNumber + 1);
                                break;
                            case 125://坐骑获取
                                unit.GetComponent<UserInfoComponent>().OnHorseActive(int.Parse(itemConfig.ItemUsePar), true);
                                break;
                            case 126: //集字
                                break;
                            case 127: //藏宝图
                                string rewardItem = useBagInfo.ItemPar.Split('@')[2];
                                unit.GetComponent<BagComponent>().OnAddItemData(rewardItem, $"{ItemGetWay.TreasureMap}_{TimeHelper.ServerNow()}");
                                break;
                            case 128://激活称号
                                unit.GetComponent<TitleComponent>().OnActiveTile(int.Parse(itemConfig.ItemUsePar));
                                break;
                            case 129://激活精灵
                                unit.GetComponent<ChengJiuComponent>().OnActiveJingLing(int.Parse(itemConfig.ItemUsePar));
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
                        if (itemConfig.DayUseNum > 0)
                        {
                            userInfoComponent.OnDayItemUse(itemConfig.Id);
                        }
                    }
                }

                //出售道具
                if (request.OperateType == 2 && locType == ItemLocType.ItemLocBag) 
                {
                    //默认出售全部
                    //给与对应金币或货币奖励
                    string[] gemids = useBagInfo.GemIDNew.Split('_');
                    List<int> gemIdList =  new List<int>();
                    ItemConfig itemConf = null;
                    for (int i = 0; i < gemids.Length; i++)
                    {
                        if (gemids[i]== "0")
                        {
                            continue;
                        }
                        gemIdList.Add(int.Parse(gemids[i]));
                        itemConf = ItemConfigCategory.Instance.Get(int.Parse(gemids[i]));
                        unit.GetComponent<UserInfoComponent>().UpdateRoleData((UserDataType)itemConf.SellMoneyType, (itemConf.SellMoneyValue).ToString());
                    }

                    //珍宝属性价格提升
                    int sellValue = itemConfig.SellMoneyValue;
                    if (useBagInfo.HideSkillLists.Contains(68000102))
                    {
                        sellValue = itemConfig.SellMoneyValue * 20;
                    }

                    itemConf = ItemConfigCategory.Instance.Get(useBagInfo.ItemID);
                    unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd((UserDataType)itemConf.SellMoneyType, (useBagInfo.ItemNum * sellValue).ToString(), true, 39);
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
                    unit.GetComponent<UserInfoComponent>().UpdateRoleData((UserDataType)itemConfig.SellMoneyType, (useBagInfo.ItemNum * itemConfig.SellMoneyValue).ToString());
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
                    int equipLv = itemConfig.UseLv;

                    //简易
                    if (useBagInfo.HideSkillLists.Contains(68000103))
                    {
                        equipLv = equipLv - 5;
                    }

                    //无级别
                    if (useBagInfo.HideSkillLists.Contains(68000106))
                    {
                        equipLv = 1;
                    }

                    if (roleLv < equipLv)
                    {
                        response.Error = ErrorCore.ERR_EquipLvLimit;    
                        reply();
                        return;
                    }

                    //对应部位是否符合
                    if (itemConfig.ItemType == 3 && itemConfig.EquipType != 0) {

                        //查看自身是否是二转
                        if (useInfo.OccTwo > 0)
                        {
                            OccupationTwoConfig occtwoCof = OccupationTwoConfigCategory.Instance.Get(useInfo.OccTwo);
                            if (occtwoCof.ArmorMastery == itemConfig.EquipType || itemConfig.EquipType == 99 || itemConfig.EquipType == 101)
                            {
                                //可以穿戴
                            }
                            else {
                                bool ifWear = false;
                                if (useInfo.Occ == 1 && (itemConfig.EquipType == 1 || itemConfig.EquipType == 2)) {
                                    ifWear = true;
                                }

                                if (useInfo.Occ == 2 && (itemConfig.EquipType == 3 || itemConfig.EquipType == 4))
                                {
                                    ifWear = true;
                                }
                                //佩戴部位不符
                                if (ifWear == false)
                                {
                                    response.Error = ErrorCore.ERR_EquipType;     //错误码:穿戴类型不符
                                    reply();
                                    return;
                                }
                            }
                        }
                    }

                    //获取之前的位置是否有装备
                    BagInfo beforeequip = null;
                    if (weizhi == (int)ItemSubTypeEnum.Shiping && !ComHelp.IsBanHaoZone(unit.DomainZone()))
                    {
                        List<BagInfo> equipList = unit.GetComponent<BagComponent>().GetEquipListByWeizhi(weizhi);
                        beforeequip = equipList.Count < 3 ? null : equipList[0];
                    }
                    else
                    {
                        beforeequip = unit.GetComponent<BagComponent>().GetEquipBySubType(weizhi);
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
                    int zodiacnumber = unit.GetComponent<BagComponent>().GetZodiacnumber();
                    unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.ZodiacEquipNumber_215, 0, zodiacnumber);
                    useBagInfo.isBinging = true;
                    Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);
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
                    Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);
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
                    bool ifItem = false;
                    if (baginfoId == 0 && itemConfig!= null)        
                    {
                        //金币鉴定，扣除金币
                        qulitylv = itemConfig.UseLv.ToString();
                        ifSell = unit.GetComponent<BagComponent>().OnCostItemData($"1;{ItemHelper.GetJianDingCoin(itemConfig.UseLv)}");
                    }
                    else
                    {
                        //道具鉴定，扣除道具
                        unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskCountryTargetType.JianDing_17,0, 1);
                        qulitylv = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, baginfoId).ItemPar;
                        qulitylv = string.IsNullOrEmpty(qulitylv) ? "0" : qulitylv;
                        ifSell = unit.GetComponent<BagComponent>().OnCostItemData(baginfoId,1);
                        ifItem = true;
                    }
                    if (ifSell)
                    {
                        //未鉴定才可以
                        useBagInfo.IfJianDing = false;
                        useBagInfo.HideProLists = ItemAddHelper.GetEquipZhuanJingHidePro(itemConfig.ItemEquipID, itemConfig.Id, int.Parse(qulitylv), unit, ifItem);
                        m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);

                        //如果当前有隐藏技能一起飘出
                        if (useBagInfo.HideSkillLists.Count>0)
                        {
                            string skillName = "";
                            for (int i = 0; i < useBagInfo.HideSkillLists.Count; i++) {
                                skillName = skillName + $" {SkillConfigCategory.Instance.Get(useBagInfo.HideSkillLists[0]).SkillName}";
                            }
                            string noticeContent = $"恭喜玩家<color=#B6FF00>{unit.GetComponent<UserInfoComponent>().UserName}</color>在拾取装备时,意外在装备上发现了隐藏技能:<color=#FFA313>{skillName}</color>";
                            ServerMessageHelper.SendBroadMessage(unit.DomainZone(), NoticeType.Notice, noticeContent);
                        }

                        unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.JianDingEqipNumber_212, int.Parse(qulitylv), 1);
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
