using System;
using System.Collections.Generic;
using System.Net;
using ET;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_RolePetUpStarHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetUpStar, M2C_RolePetUpStar>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetUpStar request, M2C_RolePetUpStar response, Action reply)
        {

            PetComponent petComponent = unit.GetComponent<PetComponent>();
            //string upStarStone = GlobalValueConfigCategory.Instance.Get(7).Value;
            //string[] upStarStoneInfo = upStarStone.Split(';');
            //int upStarStoneId = int.Parse(upStarStoneInfo[0]);
            //int upStarStoneNum = int.Parse(upStarStoneInfo[1]);
            //List<RewardItem> rewardItems = new List<RewardItem>();
            //rewardItems.Add(new RewardItem() {ItemID = upStarStoneId, ItemNum = upStarStoneNum });

            //获取当前操作宠物星数
            float upStartLvPro = 0;
            RolePetInfo rolePetInfo = petComponent.GetPetInfo(request.PetInfoId);
            switch (rolePetInfo.Star) {

                case 0:
                    upStartLvPro = 0.25f;
                    break;

                case 1:
                    upStartLvPro = 0.25f;
                    break;

                case 2:
                    upStartLvPro = 0.2f;
                    break;

                case 3:
                    upStartLvPro = 0.15f;
                    break;

                case 4:
                    upStartLvPro = 0.1f;
                    break;

            }

            //设置概率              
            upStartLvPro = upStartLvPro * request.CostPetInfoIds.Count;
            bool starError = false;
            //判断是否符合宠物条件
            for (int i = 0; i < request.CostPetInfoIds.Count; i++)
            {
                //判断星数是否符合
                if (petComponent.GetPetInfo(request.CostPetInfoIds[i]).Star < rolePetInfo.Star) 
                {
                    
                    starError = true;
                }
            }

            if (starError)
            {
                response.Error = ErrorCore.ERR_Pet_Hint_1;
                reply();
                return;
            }

            bool success = RandomHelper.RandFloat() <= upStartLvPro;
            if (!success)
            {
                response.Error = ErrorCore.ERR_Pet_UpStar;
                reply();
                return;
            }

            rolePetInfo.Star++;
            for (int i = 0; i < request.CostPetInfoIds.Count; i++)
            {
                petComponent.RemovePet(request.CostPetInfoIds[i]);
            }
            response.rolePetInfo = rolePetInfo;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
