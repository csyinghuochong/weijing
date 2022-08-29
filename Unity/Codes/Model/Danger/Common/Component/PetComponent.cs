
using System.Collections.Generic;
 
namespace ET
{
    public class PetComponent : Entity, IAwake, ITransfer, IUnitCache
    {
        public List<long> TeamPetList = new List<long>() { 0,0,0};
        public List<RolePetInfo> RolePetInfos = new List<RolePetInfo>();
        public List<RolePetEgg> RolePetEggs = new List<RolePetEgg>(3);
        public List<PetFubenInfo> PetFubenInfos = new List<PetFubenInfo>();
        public List<KeyValuePair> PetSkinList = new List<KeyValuePair>() { };
        public List<long> PetFormations = new List<long>() { };

        public int PetFubeRewardId = 0;

    }
}
