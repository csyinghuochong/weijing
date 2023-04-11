using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanPetWalkHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPetWalkRequest, M2C_JiaYuanPetWalkResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPetWalkRequest request, M2C_JiaYuanPetWalkResponse response, Action reply)
        {
            RolePetInfo rolePetInfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetId);
            if (rolePetInfo == null || rolePetInfo.PetStatus == 1)
            {
                reply();
                return;
            }
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfoComponent.UserInfo.JiaYuanLv);
            if (request.Position == 1 &&  userInfoComponent.UserInfo.Lv < jiaYuanConfig.Lv)
            {
                reply();
                return;
            }
            if (request.Position == 2 && userInfoComponent.UserInfo.Lv < jiaYuanConfig.Lv)
            {
                reply();
                return;
            }

            JiaYuanPet jiaYuanPet = unit.GetComponent<JiaYuanComponent>().GetJiaYuanPet(request.PetId);
            unit.GetComponent<PetComponent>().OnPetWalk(request.PetId, request.PetStatus);
            unit.GetComponent<PetComponent>().PetAddExp(rolePetInfo, (int)jiaYuanPet.CurExp);
            unit.GetComponent<JiaYuanComponent>().OnJiaYuanPetWalk(rolePetInfo, request.PetStatus, request.Position);
            UnitComponent unitComponent = unit.GetParent<UnitComponent>();
            if (request.PetStatus == 2)
            {
                if (unitComponent.Get(request.PetId) == null)
                {
                    UnitFactory.CreateJiaYuanPet(unit.DomainScene(), unit.Id, unit.GetComponent<JiaYuanComponent>().GetJiaYuanPet(request.PetId) );
                }
            }
            if (request.PetStatus == 0)
            {
                if (unitComponent.Get(request.PetId) != null)
                {
                    unitComponent.Remove(request.PetId);
                }
            }
            DBHelper.SaveComponent(unit.DomainZone(), unit.Id, unit.GetComponent<JiaYuanComponent>()).Coroutine();
            response.JiaYuanPetList = unit.GetComponent<JiaYuanComponent>().JiaYuanPetList_2;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
