using System;
using System.Collections.Generic;

namespace ET
{
    public class C2M_TowerOfSealNextHandler: AMActorLocationRpcHandler<Unit, C2M_TowerOfSealNextRequest, M2C_TowerOfSealNextResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TowerOfSealNextRequest request, M2C_TowerOfSealNextResponse response, Action reply)
        {
            Scene domainScene = unit.DomainScene();
            TowerOfSealComponent towerOfSealComponent = domainScene.GetComponent<TowerOfSealComponent>();
            if (towerOfSealComponent == null)
            {
                reply();
                return;
            }

            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            int oldArrived = numericComponent.GetAsInt(NumericType.TowerOfSealArrived);
            int oldFinished = numericComponent.GetAsInt(NumericType.TowerOfSealFinished);

            // 判断是否已经通关顶层
            if (oldFinished >= 100)
            {
                reply();
                return;
            }

            // 判断该层是否已经通关
            if (oldFinished != oldArrived)
            {
                reply();
                return;
            }

            // 判断道具是否足够
            if (request.CostType == 0) // 花费钻石
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(89);
                int needGold = int.Parse(globalValueConfig.Value);
                if (userInfoComponent.UserInfo.Diamond < needGold)
                {
                    reply();
                    return;
                }

                // 消耗钻石
                userInfoComponent.UpdateRoleMoneySub(UserDataType.Diamond, (-1 * needGold).ToString(), true, ItemGetWay.TowerOfSealCost);
            }
            else if(request.CostType == 1)//花费凭证
            {
                BagComponent bagComponent = unit.GetComponent<BagComponent>();
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(90);
                int itemConfigID = int.Parse(globalValueConfig.Value);
                if (bagComponent.GetItemNumber(itemConfigID) <= 0)
                {
                    reply();
                    return;
                }
                
                //消耗凭证
                for (int i = 0; i < bagComponent.BagItemList.Count; i++)
                {
                    if (bagComponent.BagItemList[i].ItemID == itemConfigID)
                    {
                        bagComponent.OnCostItemData(bagComponent.BagItemList[i].BagInfoID, 1);
                    }
                }
            }
            else if (request.CostType == 10) // 钻石+钻石 去某10层，这里就相信客户端吧
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(89);
                int needGold = int.Parse(globalValueConfig.Value) + 350;
                if (userInfoComponent.UserInfo.Diamond < needGold )
                {
                    reply();
                    return;
                }

                // 消耗钻石
                userInfoComponent.UpdateRoleMoneySub(UserDataType.Diamond, (-1 * needGold).ToString(), true, ItemGetWay.TowerOfSealCost);
            }
            else if (request.CostType == 11) // 凭证+钻石
            {
                int needGold = 350;
                if (userInfoComponent.UserInfo.Diamond < needGold)
                {
                    reply();
                    return;
                }

                // 消耗钻石
                userInfoComponent.UpdateRoleMoneySub(UserDataType.Diamond, (-1 * needGold).ToString(), true, ItemGetWay.TowerOfSealCost);

                BagComponent bagComponent = unit.GetComponent<BagComponent>();
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(90);
                int itemConfigID = int.Parse(globalValueConfig.Value);
                if (bagComponent.GetItemNumber(itemConfigID) <= 0)
                {
                    reply();
                    return;
                }

                //消耗凭证
                for (int i = 0; i < bagComponent.BagItemList.Count; i++)
                {
                    if (bagComponent.BagItemList[i].ItemID == itemConfigID)
                    {
                        bagComponent.OnCostItemData(bagComponent.BagItemList[i].BagInfoID, 1);
                    }
                }
            }

            // 改变玩家数据
            int nextArrived = oldArrived + request.DiceResult;
            if (request.DiceResult > 100 - oldArrived)
            {
                nextArrived = 100;
            }

            numericComponent.ApplyValue(NumericType.TowerOfSealArrived, nextArrived);

            // 清空关卡怪物
            List<Unit> monsterList = UnitHelper.GetUnitList(unit.DomainScene(), UnitType.Monster);
            for (int i = monsterList.Count - 1; i >= 0; i--)
            {
                domainScene.GetComponent<UnitComponent>().Remove(monsterList[i].Id);
            }

            await TimerComponent.Instance.WaitAsync(1000);

            // 重置关卡
            towerOfSealComponent.GenerateFuben(numericComponent.GetAsInt(NumericType.TowerOfSealArrived),
                numericComponent.GetAsInt(NumericType.TowerOfSealFinished));

            unit.GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.TowerOfSeal_28, 0, 1);
            unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskCountryTargetType.TowerOfSeal_28, 0, 1);

            reply();
            await ETTask.CompletedTask;
        }
    }
}