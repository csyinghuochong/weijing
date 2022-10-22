using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_RolePetEggOpenHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetEggOpen, M2C_RolePetEggOpen>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetEggOpen request, M2C_RolePetEggOpen response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            RolePetEgg rolePetEgg = petComponent.RolePetEggs[request.Index];
            if (rolePetEgg.ItemId == 0)
            {
                reply();
                return;
            }

            int needCost = 0;
            ItemConfig itemConf = ItemConfigCategory.Instance.Get(rolePetEgg.ItemId);
            string[] petinfos = itemConf.ItemUsePar.Split('@');
            if (TimeHelper.ServerNow() < rolePetEgg.EndTime)
            {
                needCost = int.Parse(petinfos[1]);
            }
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.Diamond < needCost)
            {
                response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                reply();
                return;
            }
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Diamond, (needCost * -1).ToString()).Coroutine();
            List<int> weights = new List<int>();
            List<int> petlists = new List<int>();
            for (int i = 2; i < petinfos.Length; i++)
            {
                string[] petitem = petinfos[i].Split(';');
                petlists.Add(int.Parse(petitem[0]));
                weights.Add(int.Parse(petitem[1]));
            }
            int index = RandomHelper.RandomByWeight(weights);
            response.PetInfo =  unit.GetComponent<PetComponent>().OnAddPet(petlists[index]);
            rolePetEgg.ItemId = 0;
            rolePetEgg.EndTime = 0;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
